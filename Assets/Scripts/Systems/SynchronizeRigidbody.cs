using Entia.Injectables;
using Entia.Queryables;
using Entia.Systems;
using UnityEngine;

namespace Systems
{
    public struct SynchronizeRigidbody : IRun, IRunFixed
    {
        public readonly Group<Unity<Rigidbody2D>, Write<Components.Velocity>> Group;

        void IRun.Run()
        {
            foreach (ref readonly var item in Group)
            {
                var body = item.Rigidbody2D();
                ref var velocity = ref item.Velocity();
                body.velocity = velocity;
            }
        }

        void IRunFixed.RunFixed()
        {
            foreach (ref readonly var item in Group)
            {
                var body = item.Rigidbody2D();
                ref var velocity = ref item.Velocity();
                velocity = body.velocity;
            }
        }
    }
}
using Entia.Injectables;
using Entia.Queryables;
using Entia.Systems;
using UnityEngine;

namespace Systems
{
    public struct SynchronizeTransform : IRun
    {
        public readonly Group<Unity<Transform>, Read<Components.Position>> Group;

        void IRun.Run()
        {
            foreach (ref readonly var item in Group)
            {
                var transform = item.Transform();
                ref readonly var position = ref item.Position();
                transform.position = position;
            }
        }
    }
}
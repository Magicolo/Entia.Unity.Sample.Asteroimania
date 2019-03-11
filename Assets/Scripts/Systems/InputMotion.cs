using Entia.Core;
using Entia.Injectables;
using Entia.Queryables;
using Entia.Systems;
using System.Linq;
using UnityEngine;

namespace Systems
{
    public struct InputMotion : IRun
    {
        public readonly Resource<Entia.Resources.Time>.Read Time;
        public readonly Group<Unity<Transform>, Write<Components.Velocity>, Read<Components.Input>, Read<Components.Motion>> Group;

        void IRun.Run()
        {
            ref readonly var time = ref Time.Value;
            foreach (ref readonly var item in Group)
            {
                var transform = item.Transform();
                ref var velocity = ref item.Velocity();
                ref readonly var input = ref item.Input();
                ref readonly var motion = ref item.Motion();

                if (input.Move.Any(key => Input.GetKey(key)))
                {
                    Vector3 vector = velocity;
                    vector += transform.up * motion.Acceleration * time.Delta;
                    vector /= Mathf.Max(vector.magnitude / motion.MoveSpeed, 1f);
                    vector *= motion.Drag;
                    velocity = vector;
                }
            }
        }
    }
}
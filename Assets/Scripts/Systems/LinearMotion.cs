using Entia.Injectables;
using Entia.Queryables;
using Entia.Systems;
using UnityEngine;

namespace Systems
{
    public struct LinearMotion : IRun
    {
        public readonly Group<Unity<Transform>, Write<Components.Velocity>, Read<Components.LinearMotion>> Group;

        void IRun.Run()
        {
            foreach (ref readonly var item in Group)
            {
                var transform = item.Transform();
                ref var velocity = ref item.Velocity();
                ref readonly var motion = ref item.LinearMotion();

                var direction = default(Vector3);
                switch (motion.Direction)
                {
                    case Components.Directions.Up: direction = transform.up; break;
                    case Components.Directions.Down: direction = -transform.up; break;
                    case Components.Directions.Left: direction = -transform.right; break;
                    case Components.Directions.Right: direction = transform.right; break;
                    case Components.Directions.Forward: direction = transform.forward; break;
                    case Components.Directions.Backward: direction = -transform.forward; break;
                    default: break;
                }
                velocity = direction * motion.Speed;
            }
        }
    }
}
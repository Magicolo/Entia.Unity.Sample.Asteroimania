using Entia.Injectables;
using Entia.Queryables;
using Entia.Systems;
using UnityEngine;

namespace Systems
{
    public struct LookAtMouse : IRun
    {
        public readonly Resource<Resources.Camera>.Read Camera;
        [All(typeof(Components.Input))]
        public readonly Group<Unity<Transform>, Read<Components.Motion>> Group;

        void IRun.Run()
        {
            ref readonly var camera = ref Camera.Value;
            var mouse = camera.Main.ScreenToWorldPoint(Input.mousePosition);

            foreach (ref readonly var item in Group)
            {
                var transform = item.Transform();
                ref readonly var motion = ref item.Motion();

                var position = transform.position;
                var target = mouse - position;
                target.z = 0f;
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(Vector3.forward, target), motion.RotationSpeed);
            }
        }
    }
}
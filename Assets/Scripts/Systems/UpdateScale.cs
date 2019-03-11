using Entia;
using Entia.Injectables;
using Entia.Messages;
using Entia.Queryables;
using Entia.Systems;
using UnityEngine;

namespace Systems
{
    public struct UpdateScale : IRun
    {
        public readonly Resource<Entia.Resources.Time>.Read Time;
        public readonly Group<Entity, Unity<Transform>, Write<Components.ScaleTo>> Group;
        public readonly Components<Components.ScaleTo> ScaleTo;

        void IRun.Run()
        {
            ref readonly var time = ref Time.Value;
            foreach (ref readonly var item in Group)
            {
                var entity = item.Entity();
                var transform = item.Transform();
                ref var scale = ref item.ScaleTo();
                scale.Counter += time.Delta;

                var ratio = scale.Counter / scale.Duration;
                if (ratio >= 1f)
                {
                    transform.localScale = scale.Target;
                    ScaleTo.Remove(entity);
                }
                else
                    transform.localScale = Vector3.Lerp(scale.Source, scale.Target, ratio);
            }
        }
    }
}
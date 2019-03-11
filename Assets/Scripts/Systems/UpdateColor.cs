using Entia;
using Entia.Injectables;
using Entia.Queryables;
using Entia.Systems;
using UnityEngine;

namespace Systems
{
    public struct UpdateColor : IRun
    {
        public readonly Resource<Entia.Resources.Time>.Read Time;
        public readonly Group<Entity, Unity<SpriteRenderer>, Write<Components.FadeTo>> Group;
        public readonly Components<Components.FadeTo> FadeTo;

        void IRun.Run()
        {
            ref readonly var time = ref Time.Value;
            foreach (ref readonly var item in Group)
            {
                var entity = item.Entity();
                var renderer = item.SpriteRenderer();
                ref var fade = ref item.FadeTo();
                fade.Counter += time.Delta;
                renderer.color = Color.Lerp(fade.Source, fade.Target, Mathf.Clamp01(fade.Counter / fade.Duration));

                var ratio = fade.Counter / fade.Duration;
                if (ratio >= 1f)
                {
                    renderer.color = fade.Target;
                    FadeTo.Remove(entity);
                }
                else
                    renderer.color = Color.Lerp(fade.Source, fade.Target, ratio);
            }
        }
    }
}
using Entia;
using Entia.Injectables;
using Entia.Queryables;
using Entia.Systems;

namespace Systems
{
    public struct UpdateLifetime : IRun
    {
        public readonly Resource<Entia.Resources.Time>.Read Time;
        public readonly AllEntities Entities;
        public readonly Group<Entity, Write<Components.Lifetime>> Group;

        void IRun.Run()
        {
            ref readonly var time = ref Time.Value;
            foreach (ref readonly var item in Group)
            {
                var entity = item.Entity();
                ref var lifetime = ref item.Lifetime();
                lifetime.Counter += time.Delta;
                if (lifetime.Counter >= lifetime.Duration) Entities.Destroy(entity);
            }
        }
    }
}
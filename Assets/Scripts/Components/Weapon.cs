using Entia;
using Entia.Core;
using Entia.Queryables;
using Entia.Unity;

namespace Components
{
    public struct Weapon : IComponent
    {
        [Default]
        public static Weapon Default => new Weapon { Cooldown = 0.1f };

        [All(typeof(Velocity), typeof(LinearMotion), typeof(Lifetime))]
        public EntityReference Bullet;
        public float Cooldown;
        [Disable]
        public float Counter;
    }
}
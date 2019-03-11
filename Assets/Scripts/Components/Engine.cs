using Entia;
using Entia.Core;
using Entia.Queryables;
using Entia.Unity;

namespace Components
{
    public struct Engine : IComponent
    {
        [Default]
        public static Engine Default => new Engine { Cooldown = 0.1f };

        [All(typeof(Velocity), typeof(LinearMotion), typeof(Lifetime))]
        public EntityReference Fire;
        public float Cooldown;
        [Disable]
        public float Counter;
    }
}
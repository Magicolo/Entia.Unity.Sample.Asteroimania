using Entia;
using Entia.Core;
using Entia.Unity;

namespace Components
{
    public struct Lifetime : IComponent
    {
        [Default]
        public static Lifetime Default => new Lifetime { Duration = 5f };

        public float Duration;
        [Disable]
        public float Counter;
    }
}
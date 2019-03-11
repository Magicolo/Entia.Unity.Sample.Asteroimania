using Entia;
using Entia.Core;
using Entia.Unity;
using UnityEngine;

namespace Components
{
    public struct ScaleTo : IComponent
    {
        [Default]
        public static ScaleTo Default => new ScaleTo { Source = Vector3.one, Target = Vector3.one, Duration = 1f };

        public Vector3 Source;
        public Vector3 Target;
        public float Duration;
        [Disable]
        public float Counter;
    }
}
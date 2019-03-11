using Entia;
using Entia.Core;
using Entia.Unity;
using UnityEngine;

namespace Components
{
    public struct FadeTo : IComponent
    {
        [Default]
        public static FadeTo Default => new FadeTo
        {
            Source = Color.white,
            Target = Color.white,
            Duration = 1f
        };

        public Color Source;
        public Color Target;
        public float Duration;
        [Disable]
        public float Counter;
    }
}
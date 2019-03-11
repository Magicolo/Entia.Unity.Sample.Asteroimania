using Entia;
using Entia.Core;
using UnityEngine;

namespace Components
{
    public struct Motion : IComponent
    {
        [Default]
        public static Motion Default => new Motion
        {
            Acceleration = 5f,
            MoveSpeed = 5f,
            RotationSpeed = 10f,
            Drag = 0.99f
        };

        public float Acceleration;
        public float MoveSpeed;
        public float RotationSpeed;
        [Range(0f, 1f)]
        public float Drag;
    }
}
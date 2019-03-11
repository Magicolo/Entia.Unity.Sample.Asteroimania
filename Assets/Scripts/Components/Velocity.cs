using Entia;
using UnityEngine;

namespace Components
{
    public struct Velocity : IComponent
    {
        public static implicit operator Vector3(in Velocity velocity) => new Vector3(velocity.X, velocity.Y, velocity.Z);
        public static implicit operator Vector2(in Velocity velocity) => new Vector2(velocity.X, velocity.Y);
        public static implicit operator Velocity(in Vector3 vector) => new Velocity { X = vector.x, Y = vector.y, Z = vector.z };
        public static implicit operator Velocity(in Vector2 vector) => new Velocity { X = vector.x, Y = vector.y };

        public float X, Y, Z;
    }
}
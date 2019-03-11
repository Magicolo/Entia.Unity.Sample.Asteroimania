using Entia;
using UnityEngine;

namespace Components
{
    public struct Position : IComponent
    {
        public static implicit operator Vector3(in Position position) => new Vector3(position.X, position.Y, position.Z);
        public static implicit operator Vector2(in Position position) => new Vector2(position.X, position.Y);
        public static implicit operator Position(in Vector3 vector) => new Position { X = vector.x, Y = vector.y, Z = vector.z };
        public static implicit operator Position(in Vector2 vector) => new Position { X = vector.x, Y = vector.y };

        public float X, Y, Z;
    }
}
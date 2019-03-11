using Entia;
using Entia.Core;

namespace Components
{
    public enum Directions { Up, Down, Left, Right, Forward, Backward }

    public struct LinearMotion : IComponent
    {
        [Default]
        public static LinearMotion Default => new LinearMotion { Direction = Directions.Up, Speed = 10f };

        public Directions Direction;
        public float Speed;
    }
}
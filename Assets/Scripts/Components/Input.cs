using Entia;
using Entia.Core;
using UnityEngine;

namespace Components
{
    public struct Input : IComponent
    {
        [Default]
        public static Input Default => new Input
        {
            Move = new[] { KeyCode.UpArrow, KeyCode.W },
            Shoot = new[] { KeyCode.Space, KeyCode.Mouse0, KeyCode.Mouse1 }
        };

        public KeyCode[] Move;
        public KeyCode[] Shoot;
    }
}
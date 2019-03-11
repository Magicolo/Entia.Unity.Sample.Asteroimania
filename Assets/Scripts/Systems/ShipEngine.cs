using Entia;
using Entia.Core;
using Entia.Injectables;
using Entia.Modules;
using Entia.Queryables;
using Entia.Systems;
using Entia.Unity;
using UnityEngine;

namespace Systems
{
    public struct ShipEngine : IRun
    {
        public readonly AllComponents Components;
        public readonly Resource<Entia.Resources.Time>.Read Time;
        public readonly Group<Unity<Ship>, Write<Components.Engine>, Read<Components.Input>> Group;
        public readonly Cloner Cloner;

        void IRun.Run()
        {
            ref readonly var time = ref Time.Value;
            foreach (ref readonly var item in Group)
            {
                var ship = item.Ship();
                ref var engine = ref item.Engine();
                ref readonly var input = ref item.Input();

                engine.Counter += time.Delta;
                if (engine.Counter >= engine.Cooldown && input.Move.Any(key => Input.GetKey(key)))
                {
                    engine.Counter = 0f;
                    var entity = Cloner.Clone(engine.Fire);
                    if (Components.TryUnity<Transform>(entity, out var fire))
                    {
                        fire.position = ship.Engine.position;
                        fire.rotation = ship.Engine.rotation;
                    }
                }
            }
        }
    }
}
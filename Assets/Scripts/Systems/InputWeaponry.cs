using Entia;
using Entia.Core;
using Entia.Injectables;
using Entia.Modules;
using Entia.Queryables;
using Entia.Systems;
using Entia.Unity;
using System.Linq;
using UnityEngine;

namespace Systems
{
    public struct InputWeaponry : IRun
    {
        public readonly AllComponents Components;
        public readonly Resource<Entia.Resources.Time>.Read Time;
        public readonly Group<Unity<Ship>, Write<Components.Weapon>, Read<Components.Input>> Group;
        public readonly Cloner Cloner;

        void IRun.Run()
        {
            ref readonly var time = ref Time.Value;
            foreach (ref readonly var item in Group)
            {
                var ship = item.Ship();
                ref var weapon = ref item.Weapon();
                ref readonly var input = ref item.Input();

                weapon.Counter += time.Delta;
                if (weapon.Counter >= weapon.Cooldown && input.Shoot.Any(key => Input.GetKey(key)))
                {
                    weapon.Counter = 0f;
                    var entity = Cloner.Clone(weapon.Bullet);
                    if (Components.TryUnity<Transform>(entity, out var bullet))
                    {
                        bullet.position = ship.Gun.position;
                        bullet.rotation = ship.Gun.rotation;
                    }
                }
            }
        }
    }
}
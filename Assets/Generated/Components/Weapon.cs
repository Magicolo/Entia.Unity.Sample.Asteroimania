using Entia.Core;
using Entia.Unity.Generation;

namespace Components.Generated
{

	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Components.Weapon), Link = "Assets/Scripts/Components/Weapon.cs", Path = new string[] { "Components", "Weapon" })][global::UnityEngine.AddComponentMenu("Components/Components.Weapon")]
	public sealed partial class Weapon : global::Entia.Unity.ComponentReference<global::Components.Weapon>
	{
		public ref global::Entia.Unity.EntityReference Bullet => ref base.Get((ref global::Components.Weapon data) => ref data.Bullet, ref this._Bullet);
		public ref global::System.Single Cooldown => ref base.Get((ref global::Components.Weapon data) => ref data.Cooldown, ref this._Cooldown);
		public ref global::System.Single Counter => ref base.Get((ref global::Components.Weapon data) => ref data.Counter, ref this._Counter);
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Bullet))] [global::Entia.Queryables.AllAttribute(new global::System.Type[] { typeof(Components.Velocity), typeof(Components.LinearMotion), typeof(Components.Lifetime) })]
		global::Entia.Unity.EntityReference _Bullet;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Cooldown))]
		global::System.Single _Cooldown;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Counter))] [global::Entia.Unity.DisableAttribute()]
		global::System.Single _Counter;
		public override global::Components.Weapon Raw
		{
			get => new global::Components.Weapon
			{
				Bullet = this._Bullet,
				Cooldown = this._Cooldown,
				Counter = this._Counter
			};
			set
			{
				this._Bullet = value.Bullet;
				this._Cooldown = value.Cooldown;
				this._Counter = value.Counter;
			}
		}

	}
}
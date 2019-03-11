using Entia.Core;
using Entia.Unity.Generation;

namespace Components.Generated
{

	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Components.Engine), Link = "Assets/Scripts/Components/Engine.cs", Path = new string[] { "Components", "Engine" })][global::UnityEngine.AddComponentMenu("Components/Components.Engine")]
	public sealed partial class Engine : global::Entia.Unity.ComponentReference<global::Components.Engine>
	{
		public ref global::Entia.Unity.EntityReference Fire => ref base.Get((ref global::Components.Engine data) => ref data.Fire, ref this._Fire);
		public ref global::System.Single Cooldown => ref base.Get((ref global::Components.Engine data) => ref data.Cooldown, ref this._Cooldown);
		public ref global::System.Single Counter => ref base.Get((ref global::Components.Engine data) => ref data.Counter, ref this._Counter);
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Fire))] [global::Entia.Queryables.AllAttribute(new global::System.Type[] { typeof(Components.Velocity), typeof(Components.LinearMotion), typeof(Components.Lifetime) })]
		global::Entia.Unity.EntityReference _Fire;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Cooldown))]
		global::System.Single _Cooldown;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Counter))] [global::Entia.Unity.DisableAttribute()]
		global::System.Single _Counter;
		public override global::Components.Engine Raw
		{
			get => new global::Components.Engine
			{
				Fire = this._Fire,
				Cooldown = this._Cooldown,
				Counter = this._Counter
			};
			set
			{
				this._Fire = value.Fire;
				this._Cooldown = value.Cooldown;
				this._Counter = value.Counter;
			}
		}

	}
}
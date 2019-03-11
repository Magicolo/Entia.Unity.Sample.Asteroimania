using Entia.Core;
using Entia.Unity.Generation;

namespace Components.Generated
{

	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Components.Lifetime), Link = "Assets/Scripts/Components/Lifetime.cs", Path = new string[] { "Components", "Lifetime" })][global::UnityEngine.AddComponentMenu("Components/Components.Lifetime")]
	public sealed partial class Lifetime : global::Entia.Unity.ComponentReference<global::Components.Lifetime>
	{
		public ref global::System.Single Duration => ref base.Get((ref global::Components.Lifetime data) => ref data.Duration, ref this._Duration);
		public ref global::System.Single Counter => ref base.Get((ref global::Components.Lifetime data) => ref data.Counter, ref this._Counter);
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Duration))]
		global::System.Single _Duration;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Counter))] [global::Entia.Unity.DisableAttribute()]
		global::System.Single _Counter;
		public override global::Components.Lifetime Raw
		{
			get => new global::Components.Lifetime
			{
				Duration = this._Duration,
				Counter = this._Counter
			};
			set
			{
				this._Duration = value.Duration;
				this._Counter = value.Counter;
			}
		}

	}
}
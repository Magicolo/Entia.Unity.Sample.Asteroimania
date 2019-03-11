using Entia.Core;
using Entia.Unity.Generation;

namespace Components.Generated
{

	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Components.FadeTo), Link = "Assets/Scripts/Components/FadeTo.cs", Path = new string[] { "Components", "FadeTo" })][global::UnityEngine.AddComponentMenu("Components/Components.FadeTo")]
	public sealed partial class FadeTo : global::Entia.Unity.ComponentReference<global::Components.FadeTo>
	{
		public ref global::UnityEngine.Color Source => ref base.Get((ref global::Components.FadeTo data) => ref data.Source, ref this._Source);
		public ref global::UnityEngine.Color Target => ref base.Get((ref global::Components.FadeTo data) => ref data.Target, ref this._Target);
		public ref global::System.Single Duration => ref base.Get((ref global::Components.FadeTo data) => ref data.Duration, ref this._Duration);
		public ref global::System.Single Counter => ref base.Get((ref global::Components.FadeTo data) => ref data.Counter, ref this._Counter);
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Source))]
		global::UnityEngine.Color _Source;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Target))]
		global::UnityEngine.Color _Target;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Duration))]
		global::System.Single _Duration;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Counter))] [global::Entia.Unity.DisableAttribute()]
		global::System.Single _Counter;
		public override global::Components.FadeTo Raw
		{
			get => new global::Components.FadeTo
			{
				Source = this._Source,
				Target = this._Target,
				Duration = this._Duration,
				Counter = this._Counter
			};
			set
			{
				this._Source = value.Source;
				this._Target = value.Target;
				this._Duration = value.Duration;
				this._Counter = value.Counter;
			}
		}

	}
}
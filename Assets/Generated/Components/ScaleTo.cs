using Entia.Core;
using Entia.Unity.Generation;

namespace Components.Generated
{

	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Components.ScaleTo), Link = "Assets/Scripts/Components/ScaleTo.cs", Path = new string[] { "Components", "ScaleTo" })][global::UnityEngine.AddComponentMenu("Components/Components.ScaleTo")]
	public sealed partial class ScaleTo : global::Entia.Unity.ComponentReference<global::Components.ScaleTo>
	{
		public ref global::UnityEngine.Vector3 Source => ref base.Get((ref global::Components.ScaleTo data) => ref data.Source, ref this._Source);
		public ref global::UnityEngine.Vector3 Target => ref base.Get((ref global::Components.ScaleTo data) => ref data.Target, ref this._Target);
		public ref global::System.Single Duration => ref base.Get((ref global::Components.ScaleTo data) => ref data.Duration, ref this._Duration);
		public ref global::System.Single Counter => ref base.Get((ref global::Components.ScaleTo data) => ref data.Counter, ref this._Counter);
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Source))]
		global::UnityEngine.Vector3 _Source;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Target))]
		global::UnityEngine.Vector3 _Target;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Duration))]
		global::System.Single _Duration;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Counter))] [global::Entia.Unity.DisableAttribute()]
		global::System.Single _Counter;
		public override global::Components.ScaleTo Raw
		{
			get => new global::Components.ScaleTo
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
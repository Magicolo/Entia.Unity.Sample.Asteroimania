using Entia.Core;
using Entia.Unity.Generation;

namespace Components.Generated
{

	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Components.Velocity), Link = "Assets/Scripts/Components/Velocity.cs", Path = new string[] { "Components", "Velocity" })][global::UnityEngine.AddComponentMenu("Components/Components.Velocity")]
	public sealed partial class Velocity : global::Entia.Unity.ComponentReference<global::Components.Velocity>
	{
		public ref global::System.Single X => ref base.Get((ref global::Components.Velocity data) => ref data.X, ref this._X);
		public ref global::System.Single Y => ref base.Get((ref global::Components.Velocity data) => ref data.Y, ref this._Y);
		public ref global::System.Single Z => ref base.Get((ref global::Components.Velocity data) => ref data.Z, ref this._Z);
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(X))]
		global::System.Single _X;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Y))]
		global::System.Single _Y;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Z))]
		global::System.Single _Z;
		public override global::Components.Velocity Raw
		{
			get => new global::Components.Velocity
			{
				X = this._X,
				Y = this._Y,
				Z = this._Z
			};
			set
			{
				this._X = value.X;
				this._Y = value.Y;
				this._Z = value.Z;
			}
		}

	}
}
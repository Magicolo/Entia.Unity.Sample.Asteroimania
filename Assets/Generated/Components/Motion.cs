using Entia.Core;
using Entia.Unity.Generation;

namespace Components.Generated
{

	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Components.Motion), Link = "Assets/Scripts/Components/Motion.cs", Path = new string[] { "Components", "Motion" })][global::UnityEngine.AddComponentMenu("Components/Components.Motion")]
	public sealed partial class Motion : global::Entia.Unity.ComponentReference<global::Components.Motion>
	{
		public ref global::System.Single Acceleration => ref base.Get((ref global::Components.Motion data) => ref data.Acceleration, ref this._Acceleration);
		public ref global::System.Single MoveSpeed => ref base.Get((ref global::Components.Motion data) => ref data.MoveSpeed, ref this._MoveSpeed);
		public ref global::System.Single RotationSpeed => ref base.Get((ref global::Components.Motion data) => ref data.RotationSpeed, ref this._RotationSpeed);
		public ref global::System.Single Drag => ref base.Get((ref global::Components.Motion data) => ref data.Drag, ref this._Drag);
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Acceleration))]
		global::System.Single _Acceleration;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(MoveSpeed))]
		global::System.Single _MoveSpeed;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(RotationSpeed))]
		global::System.Single _RotationSpeed;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Drag))] [global::UnityEngine.RangeAttribute(0f, 1f)]
		global::System.Single _Drag;
		public override global::Components.Motion Raw
		{
			get => new global::Components.Motion
			{
				Acceleration = this._Acceleration,
				MoveSpeed = this._MoveSpeed,
				RotationSpeed = this._RotationSpeed,
				Drag = this._Drag
			};
			set
			{
				this._Acceleration = value.Acceleration;
				this._MoveSpeed = value.MoveSpeed;
				this._RotationSpeed = value.RotationSpeed;
				this._Drag = value.Drag;
			}
		}

	}
}
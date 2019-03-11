using Entia.Core;
using Entia.Unity.Generation;

namespace Components.Generated
{

	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Components.LinearMotion), Link = "Assets/Scripts/Components/LinearMotion.cs", Path = new string[] { "Components", "LinearMotion" })][global::UnityEngine.AddComponentMenu("Components/Components.LinearMotion")]
	public sealed partial class LinearMotion : global::Entia.Unity.ComponentReference<global::Components.LinearMotion>
	{
		public ref global::Components.Directions Direction => ref base.Get((ref global::Components.LinearMotion data) => ref data.Direction, ref this._Direction);
		public ref global::System.Single Speed => ref base.Get((ref global::Components.LinearMotion data) => ref data.Speed, ref this._Speed);
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Direction))]
		global::Components.Directions _Direction;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Speed))]
		global::System.Single _Speed;
		public override global::Components.LinearMotion Raw
		{
			get => new global::Components.LinearMotion
			{
				Direction = this._Direction,
				Speed = this._Speed
			};
			set
			{
				this._Direction = value.Direction;
				this._Speed = value.Speed;
			}
		}

	}
}
using Entia.Core;
using Entia.Unity.Generation;

namespace Components.Generated
{

	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Components.Input), Link = "Assets/Scripts/Components/Input.cs", Path = new string[] { "Components", "Input" })][global::UnityEngine.AddComponentMenu("Components/Components.Input")]
	public sealed partial class Input : global::Entia.Unity.ComponentReference<global::Components.Input>
	{
		public ref global::UnityEngine.KeyCode[] Move => ref base.Get((ref global::Components.Input data) => ref data.Move, ref this._Move);
		public ref global::UnityEngine.KeyCode[] Shoot => ref base.Get((ref global::Components.Input data) => ref data.Shoot, ref this._Shoot);
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Move))]
		global::UnityEngine.KeyCode[] _Move;
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Shoot))]
		global::UnityEngine.KeyCode[] _Shoot;
		public override global::Components.Input Raw
		{
			get => new global::Components.Input
			{
				Move = this._Move,
				Shoot = this._Shoot
			};
			set
			{
				this._Move = value.Move;
				this._Shoot = value.Shoot;
			}
		}

	}
}
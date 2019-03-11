using Entia.Unity.Generation;

namespace Resources.Generated
{

	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Resources.Camera), Link = "Assets/Scripts/Resources/Camera.cs", Path = new string[] { "Resources", "Camera" })][global::UnityEngine.AddComponentMenu("Resources/Resources.Camera")]
	public sealed partial class Camera : global::Entia.Unity.ResourceReference<global::Resources.Camera>
	{
		public ref global::UnityEngine.Camera Main => ref base.Get((ref global::Resources.Camera data) => ref data.Main, ref this._Main);
		[global::UnityEngine.SerializeField, global::UnityEngine.Serialization.FormerlySerializedAsAttribute(nameof(Main))]
		global::UnityEngine.Camera _Main;
		public override global::Resources.Camera Raw
		{
			get => new global::Resources.Camera
			{
				Main = this._Main
			};
			set
			{
				this._Main = value.Main;
			}
		}

	}
}
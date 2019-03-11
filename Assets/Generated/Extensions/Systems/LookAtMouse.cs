namespace Systems
{
	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Systems.LookAtMouse), Link = "Assets/Scripts/Systems/LookAtMouse.cs", Path = new string[] { "Systems", "LookAtMouse" })]
	public static class LookAtMouseExtensions
	{
		public static global::UnityEngine.Transform Transform(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Read<global::Components.Motion>> item) => item.Value1.Value;
		public static ref readonly global::Components.Motion Motion(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Read<global::Components.Motion>> item) => ref item.Value2.Value;
	}
}
namespace Systems
{
	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Systems.SynchronizeTransform), Link = "Assets/Scripts/Systems/SynchronizeTransform.cs", Path = new string[] { "Systems", "SynchronizeTransform" })]
	public static class SynchronizeTransformExtensions
	{
		public static global::UnityEngine.Transform Transform(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Read<global::Components.Position>> item) => item.Value1.Value;
		public static ref readonly global::Components.Position Position(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Read<global::Components.Position>> item) => ref item.Value2.Value;
	}
}
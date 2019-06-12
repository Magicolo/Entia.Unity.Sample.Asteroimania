namespace Systems
{
	using Entia.Queryables;
	using Entia.Unity;

	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Systems.UpdateScale), Link = "Assets/Scripts/Systems/UpdateScale.cs", Path = new string[] { "Systems", "UpdateScale" })]
	public static class UpdateScaleExtensions
	{
		public static global::Entia.Entity Entity(in this global::Entia.Queryables.All<global::Entia.Entity, global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.ScaleTo>> item) => item.Value1;
		public static global::UnityEngine.Transform Transform(in this global::Entia.Queryables.All<global::Entia.Entity, global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.ScaleTo>> item) => item.Value2.Value;
		public static ref global::Components.ScaleTo ScaleTo(in this global::Entia.Queryables.All<global::Entia.Entity, global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.ScaleTo>> item) => ref item.Value3.Value;
		public static ref global::Components.ScaleTo ScaleTo(in this global::Entia.Queryables.All<global::Entia.Entity, global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.ScaleTo>> item, out global::Entia.States state) => ref item.Value3.Get(out state);
		public static void ScaleTo(in this global::Entia.Queryables.All<global::Entia.Entity, global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.ScaleTo>> item, in global::Components.ScaleTo value) => item.Value3.Value = value;
	}
}
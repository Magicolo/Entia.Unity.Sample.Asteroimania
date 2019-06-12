namespace Systems
{
	using Entia.Queryables;
	using Entia.Unity;

	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Systems.UpdateColor), Link = "Assets/Scripts/Systems/UpdateColor.cs", Path = new string[] { "Systems", "UpdateColor" })]
	public static class UpdateColorExtensions
	{
		public static global::Entia.Entity Entity(in this global::Entia.Queryables.All<global::Entia.Entity, global::Entia.Queryables.Unity<global::UnityEngine.SpriteRenderer>, global::Entia.Queryables.Write<global::Components.FadeTo>> item) => item.Value1;
		public static global::UnityEngine.SpriteRenderer SpriteRenderer(in this global::Entia.Queryables.All<global::Entia.Entity, global::Entia.Queryables.Unity<global::UnityEngine.SpriteRenderer>, global::Entia.Queryables.Write<global::Components.FadeTo>> item) => item.Value2.Value;
		public static ref global::Components.FadeTo FadeTo(in this global::Entia.Queryables.All<global::Entia.Entity, global::Entia.Queryables.Unity<global::UnityEngine.SpriteRenderer>, global::Entia.Queryables.Write<global::Components.FadeTo>> item) => ref item.Value3.Value;
		public static ref global::Components.FadeTo FadeTo(in this global::Entia.Queryables.All<global::Entia.Entity, global::Entia.Queryables.Unity<global::UnityEngine.SpriteRenderer>, global::Entia.Queryables.Write<global::Components.FadeTo>> item, out global::Entia.States state) => ref item.Value3.Get(out state);
		public static void FadeTo(in this global::Entia.Queryables.All<global::Entia.Entity, global::Entia.Queryables.Unity<global::UnityEngine.SpriteRenderer>, global::Entia.Queryables.Write<global::Components.FadeTo>> item, in global::Components.FadeTo value) => item.Value3.Value = value;
	}
}
namespace Systems
{
	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Systems.UpdateLifetime), Link = "Assets/Scripts/Systems/UpdateLifetime.cs", Path = new string[] { "Systems", "UpdateLifetime" })]
	public static class UpdateLifetimeExtensions
	{
		public static global::Entia.Entity Entity(in this global::Entia.Queryables.All<global::Entia.Entity, global::Entia.Queryables.Write<global::Components.Lifetime>> item) => item.Value1;
		public static ref global::Components.Lifetime Lifetime(in this global::Entia.Queryables.All<global::Entia.Entity, global::Entia.Queryables.Write<global::Components.Lifetime>> item) => ref item.Value2.Value;
		public static void Lifetime(in this global::Entia.Queryables.All<global::Entia.Entity, global::Entia.Queryables.Write<global::Components.Lifetime>> item, in global::Components.Lifetime value) => item.Value2.Value = value;
	}
}
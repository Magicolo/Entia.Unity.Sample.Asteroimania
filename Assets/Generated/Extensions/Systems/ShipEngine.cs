namespace Systems
{
	using Entia.Queryables;
	using Entia.Unity;

	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Systems.ShipEngine), Link = "Assets/Scripts/Systems/ShipEngine.cs", Path = new string[] { "Systems", "ShipEngine" })]
	public static class ShipEngineExtensions
	{
		public static global::Ship Ship(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::Ship>, global::Entia.Queryables.Write<global::Components.Engine>, global::Entia.Queryables.Read<global::Components.Input>> item) => item.Value1.Value;
		public static ref global::Components.Engine Engine(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::Ship>, global::Entia.Queryables.Write<global::Components.Engine>, global::Entia.Queryables.Read<global::Components.Input>> item) => ref item.Value2.Value;
		public static ref global::Components.Engine Engine(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::Ship>, global::Entia.Queryables.Write<global::Components.Engine>, global::Entia.Queryables.Read<global::Components.Input>> item, out global::Entia.States state) => ref item.Value2.Get(out state);
		public static void Engine(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::Ship>, global::Entia.Queryables.Write<global::Components.Engine>, global::Entia.Queryables.Read<global::Components.Input>> item, in global::Components.Engine value) => item.Value2.Value = value;
		public static ref readonly global::Components.Input Input(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::Ship>, global::Entia.Queryables.Write<global::Components.Engine>, global::Entia.Queryables.Read<global::Components.Input>> item) => ref item.Value3.Value;
		public static ref readonly global::Components.Input Input(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::Ship>, global::Entia.Queryables.Write<global::Components.Engine>, global::Entia.Queryables.Read<global::Components.Input>> item, out global::Entia.States state) => ref item.Value3.Get(out state);
	}
}
namespace Systems
{
	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Systems.InputWeaponry), Link = "Assets/Scripts/Systems/InputWeaponry.cs", Path = new string[] { "Systems", "InputWeaponry" })]
	public static class InputWeaponryExtensions
	{
		public static global::Ship Ship(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::Ship>, global::Entia.Queryables.Write<global::Components.Weapon>, global::Entia.Queryables.Read<global::Components.Input>> item) => item.Value1.Value;
		public static ref global::Components.Weapon Weapon(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::Ship>, global::Entia.Queryables.Write<global::Components.Weapon>, global::Entia.Queryables.Read<global::Components.Input>> item) => ref item.Value2.Value;
		public static void Weapon(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::Ship>, global::Entia.Queryables.Write<global::Components.Weapon>, global::Entia.Queryables.Read<global::Components.Input>> item, in global::Components.Weapon value) => item.Value2.Value = value;
		public static ref readonly global::Components.Input Input(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::Ship>, global::Entia.Queryables.Write<global::Components.Weapon>, global::Entia.Queryables.Read<global::Components.Input>> item) => ref item.Value3.Value;
	}
}
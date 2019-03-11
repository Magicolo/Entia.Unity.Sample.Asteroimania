namespace Systems
{
	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Systems.InputMotion), Link = "Assets/Scripts/Systems/InputMotion.cs", Path = new string[] { "Systems", "InputMotion" })]
	public static class InputMotionExtensions
	{
		public static global::UnityEngine.Transform Transform(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.Velocity>, global::Entia.Queryables.Read<global::Components.Input>, global::Entia.Queryables.Read<global::Components.Motion>> item) => item.Value1.Value;
		public static ref global::Components.Velocity Velocity(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.Velocity>, global::Entia.Queryables.Read<global::Components.Input>, global::Entia.Queryables.Read<global::Components.Motion>> item) => ref item.Value2.Value;
		public static void Velocity(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.Velocity>, global::Entia.Queryables.Read<global::Components.Input>, global::Entia.Queryables.Read<global::Components.Motion>> item, in global::Components.Velocity value) => item.Value2.Value = value;
		public static ref readonly global::Components.Input Input(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.Velocity>, global::Entia.Queryables.Read<global::Components.Input>, global::Entia.Queryables.Read<global::Components.Motion>> item) => ref item.Value3.Value;
		public static ref readonly global::Components.Motion Motion(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.Velocity>, global::Entia.Queryables.Read<global::Components.Input>, global::Entia.Queryables.Read<global::Components.Motion>> item) => ref item.Value4.Value;
	}
}
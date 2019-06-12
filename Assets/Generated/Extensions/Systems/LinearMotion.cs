namespace Systems
{
	using Entia.Queryables;
	using Entia.Unity;

	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Systems.LinearMotion), Link = "Assets/Scripts/Systems/LinearMotion.cs", Path = new string[] { "Systems", "LinearMotion" })]
	public static class LinearMotionExtensions
	{
		public static global::UnityEngine.Transform Transform(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.Velocity>, global::Entia.Queryables.Read<global::Components.LinearMotion>> item) => item.Value1.Value;
		public static ref global::Components.Velocity Velocity(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.Velocity>, global::Entia.Queryables.Read<global::Components.LinearMotion>> item) => ref item.Value2.Value;
		public static ref global::Components.Velocity Velocity(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.Velocity>, global::Entia.Queryables.Read<global::Components.LinearMotion>> item, out global::Entia.States state) => ref item.Value2.Get(out state);
		public static void Velocity(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.Velocity>, global::Entia.Queryables.Read<global::Components.LinearMotion>> item, in global::Components.Velocity value) => item.Value2.Value = value;
		public static ref readonly global::Components.LinearMotion LinearMotion(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.Velocity>, global::Entia.Queryables.Read<global::Components.LinearMotion>> item) => ref item.Value3.Value;
		public static ref readonly global::Components.LinearMotion LinearMotion(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Transform>, global::Entia.Queryables.Write<global::Components.Velocity>, global::Entia.Queryables.Read<global::Components.LinearMotion>> item, out global::Entia.States state) => ref item.Value3.Get(out state);
	}
}
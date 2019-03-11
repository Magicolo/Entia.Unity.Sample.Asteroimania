namespace Systems
{
	[global::Entia.Unity.Generation.GeneratedAttribute(Type = typeof(global::Systems.SynchronizeRigidbody), Link = "Assets/Scripts/Systems/SynchronizeRigidbody.cs", Path = new string[] { "Systems", "SynchronizeRigidbody" })]
	public static class SynchronizeRigidbodyExtensions
	{
		public static global::UnityEngine.Rigidbody2D Rigidbody2D(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Rigidbody2D>, global::Entia.Queryables.Write<global::Components.Velocity>> item) => item.Value1.Value;
		public static ref global::Components.Velocity Velocity(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Rigidbody2D>, global::Entia.Queryables.Write<global::Components.Velocity>> item) => ref item.Value2.Value;
		public static void Velocity(in this global::Entia.Queryables.All<global::Entia.Queryables.Unity<global::UnityEngine.Rigidbody2D>, global::Entia.Queryables.Write<global::Components.Velocity>> item, in global::Components.Velocity value) => item.Value2.Value = value;
	}
}
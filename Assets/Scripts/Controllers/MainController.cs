using Entia.Nodes;
using Entia.Unity;
using Systems;
using static Entia.Nodes.Node;

namespace Controllers
{
    public sealed class MainController : ControllerReference
    {
        public override Node Node =>
            Sequence(nameof(MainController),
                Nodes.Default,
                System<SynchronizePooled>(),

                // Input
                System<InputMotion>(),
                System<InputWeaponry>(),
                System<LookAtMouse>(),

                // Gameplay
                System<ShipEngine>(),
                System<LinearMotion>(),
                System<UpdateLifetime>(),

                // Cosmetic
                System<UpdateScale>(),
                System<UpdateColor>(),

                // Synchronization
                System<SynchronizeRigidbody>(),
                System<SynchronizeTransform>()
            );
    }
}
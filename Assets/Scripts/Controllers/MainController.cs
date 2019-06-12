using Entia.Nodes;
using Entia.Unity;
using Systems;
using static Entia.Nodes.Node;
using static Entia.Unity.Nodes;

namespace Nodes
{
    public sealed class MainController : NodeReference
    {
        public override Node Node =>
            Sequence(nameof(MainController),
                Default,
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
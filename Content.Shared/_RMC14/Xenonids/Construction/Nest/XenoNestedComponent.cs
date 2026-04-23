using Robust.Shared.GameStates;
using Robust.Shared.Network;

namespace Content.Shared._RMC14.Xenonids.Construction.Nest;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(XenoNestSystem))]
public sealed partial class XenoNestedComponent : Component
{
    [DataField, AutoNetworkedField]
    public EntityUid Nest;

    [DataField, AutoNetworkedField]
    public bool Detached;

    [DataField]
    public float IncubationMultiplier = 1.5f;

    [DataField, AutoNetworkedField]
    public NetUserId? GhostedId;

    /// <summary>
    ///     Whether the incubation multiplier is active. Always true while nested.
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool Running = true;

    /// <summary>
    ///     How long it takes the nested entity to break free on their own.
    /// </summary>
    [DataField]
    public TimeSpan EscapeDelay = TimeSpan.FromSeconds(45);

    /// <summary>
    ///     Whether a self-escape attempt is currently in progress.
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool BreakingFree;

    /// <summary>
    ///     How long it takes a helper (non-xeno) to free a nested entity.
    /// </summary>
    [DataField]
    public TimeSpan HelperEscapeDelay = TimeSpan.FromSeconds(15);
}

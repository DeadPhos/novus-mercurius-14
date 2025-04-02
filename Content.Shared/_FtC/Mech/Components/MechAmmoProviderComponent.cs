using Content.Shared.Weapons.Ranged.Components;
using Robust.Shared.GameStates;

namespace Content.Shared._FtC.Weapons.Ranged.Components;

/// <summary>
/// Базовый компонент для провайдера аммуниции меха
/// </summary>
[NetworkedComponent]
public abstract partial class MechAmmoProviderComponent : AmmoProviderComponent
{
}

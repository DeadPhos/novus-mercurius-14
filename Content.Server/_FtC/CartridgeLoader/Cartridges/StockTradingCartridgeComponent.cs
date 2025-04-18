namespace Content.Server._FtC.CartridgeLoader.Cartridges;

[RegisterComponent, Access(typeof(StockTradingCartridgeSystem))]
public sealed partial class StockTradingCartridgeComponent : Component
{
    /// <summary>
    /// Station entity to keep track of
    /// </summary>
    [DataField]
    public EntityUid? Station;
}

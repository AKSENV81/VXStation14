using Robust.Shared.Configuration;

namespace Content.Shared._ADT.CCVar;

[CVarDefs]
public sealed class ADTCCVars
{
    /*
    * Offer Items
    */
    public static readonly CVarDef<bool> OfferModeIndicatorsPointShow =
        CVarDef.Create("hud.offer_mode_indicators_point_show", true, CVar.ARCHIVE | CVar.CLIENTONLY);
}

namespace Content.Server._VXS.ActiveRadioHeading.Components;

[RegisterComponent]
public sealed partial class VXSRetargetComponent: Component
{
    [DataField]
    public float ChanceToRetarget = 0.9f;
}

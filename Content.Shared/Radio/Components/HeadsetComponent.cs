using Content.Shared.Inventory;
using Robust.Shared.Audio; // VXS

namespace Content.Shared.Radio.Components;

/// <summary>
///     This component relays radio messages to the parent entity's chat when equipped.
/// </summary>
[RegisterComponent]
public sealed partial class HeadsetComponent : Component
{
    [DataField("enabled")]
    public bool Enabled = true;

    public bool IsEquipped = false;

    [DataField("requiredSlot")]
    public SlotFlags RequiredSlot = SlotFlags.EARS;

    /// <summary> VXS-S
     /// The sound effect played when headset receive message
     /// </summary>
    [DataField("soundReceive")]
    public SoundSpecifier MessageReceiveSound = new SoundPathSpecifier("/Audio/_VXS/Effects/radio_receive.ogg");

     /// <summary>
     /// The sound effect played when headset send message
     /// </summary>
    [DataField("soundTalk")]
    public SoundSpecifier MessageSendSound = new SoundPathSpecifier("/Audio/_VXS/Effects/radio_talk.ogg"); // VXS-E
}

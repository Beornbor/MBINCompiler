using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x98, GUID = 0x0F0149679F3FBEF56, NameHash = 0x235BD45A5DEBE0D8)]
    public class GcCustomisationShipTrails : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string LinkedTechID;
        /* 0x10 */ public TkTextureResource Trails;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x94 */ public byte[] EndPadding;
    }
}

﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x3E54DAF2EF45ACEE, NameHash = 0x9439AD97E8673BC0)]
    public class GcProjectileDataTable : NMSTemplate
    {
        public List<GcProjectileData> Table;
        public List<GcLaserBeamData> Lasers;
    }
}

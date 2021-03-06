﻿using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Brit Plexi Brt amp model.
    /// </summary>
    [DataContract]
    public class BritPlexiBrt : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public BritPlexiBrt()
        {
            DisplayName = ConstAmp.DISP_BRIT_PLEXI_BRT;
        }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float ChVol { get; set; }

    };
}

﻿using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Mandarin 80 amp model.
    /// </summary>
    [DataContract]
    public class Mandarin80 : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Mandarin80()
        {
            DisplayName = ConstAmp.DISP_MANDARIN_80;
        }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public int FAC { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Bass { get; set; }
    };
}

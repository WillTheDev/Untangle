﻿using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Line6 Doom amp model.
    /// </summary>
    [DataContract]
    public class Line6Doom : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Line6Doom()
        {
            DisplayName = ConstAmp.DISP_LINE6_DOOM;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        public float Presence { get; set; }

        [DataMember]
        public float Treble { get; set; }
    };
}

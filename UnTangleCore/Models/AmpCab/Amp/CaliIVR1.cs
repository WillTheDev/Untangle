﻿using System.Runtime.Serialization;
using UnTangle.Core.Strings;
using Newtonsoft.Json;

namespace UnTangle.Core.Models.AmpCab.Amp
{
    /// <summary>
    /// Specific settings for the Cali IV R1 amplifier model.
    /// </summary>
    [DataContract]
    public class CaliIVR1 : AmpBase
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public CaliIVR1()
        {
            DisplayName = ConstAmp.DISP_CALI_IV_R1;
        }

        [DataMember]
        public float Mid { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "80Hz")]
        public float Eq80Hz { get; set; }
        
        [DataMember]
        public float Presence { get; set; }
        
        [DataMember]
        [JsonProperty(PropertyName = "240Hz")]
        public float Eq240Hz { get; set; }

        [DataMember]
        public float ChVol { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "6600Hz")]
        public float Eq6600Hz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "2200Hz")]
        public float Eq2200Hz { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "750Hz")]
        public float Eq750Hz { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Drive { get; set; }
    };
}

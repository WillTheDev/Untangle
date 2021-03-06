﻿using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Delay
{
    /// <summary>
    /// Specific settings for the Multitap 6 delay model.
    /// </summary>
    [DataContract]
    public class Multitap6 : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public Multitap6()
        {
            DisplayName = ConstDelay.DISP_MULTITAP_6;
        }

        [DataMember]
        public float Feedback { get; set; }

        [DataMember]
        public float HighCut { get; set; }

        [DataMember]
        public float Level { get; set; }

        [DataMember]
        public float LowCut { get; set; }

        [DataMember]
        public float Mix { get; set; }

        [DataMember]
        public float SyncSelect1 { get; set; }

        [DataMember]
        public float Tap1Delay { get; set; }

        [DataMember]
        public float Tap1Level { get; set; }

        [DataMember]
        public float Tap1Pan { get; set; }

        [DataMember]
        public float Tap2Delay { get; set; }

        [DataMember]
        public float Tap2Level { get; set; }

        [DataMember]
        public float Tap2Pan { get; set; }

        [DataMember]
        public float Tap3Delay { get; set; }

        [DataMember]
        public float Tap3Level { get; set; }

        [DataMember]
        public float Tap3Pan { get; set; }

        [DataMember]
        public float Tap4Delay { get; set; }

        [DataMember]
        public float Tap4Level { get; set; }

        [DataMember]
        public float Tap4Pan { get; set; }

        [DataMember]
        public float Tap5Delay { get; set; }

        [DataMember]
        public float Tap5Level { get; set; }

        [DataMember]
        public float Tap5Pan { get; set; }

        [DataMember]
        public float Tap6Delay { get; set; }

        [DataMember]
        public float Tap6Level { get; set; }

        [DataMember]
        public float Tap6Pan { get; set; }

        [DataMember]
        public bool TempoSync1 { get; set; }

        [DataMember]
        public float Time { get; set; }
    };
}

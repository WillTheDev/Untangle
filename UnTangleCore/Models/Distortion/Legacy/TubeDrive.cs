﻿using System.Runtime.Serialization;
using UnTangle.Core.Strings;

namespace UnTangle.Core.Models.Distortion.Legacy
{
    /// <summary>
    /// Specific settings for the Tube Drive distortion model.
    /// </summary>
    [DataContract]
    public class TubeDrive : Block
    {
        /// <summary>
        /// CTOR.  Sets the display name.
        /// </summary>
        public TubeDrive()
        {
            DisplayName = ConstDistortion.DISP_TUBE_DRIVE;
            IsLegacy = true;
        }

        [DataMember]
        public float Bass { get; set; }

        [DataMember]
        public float Drive { get; set; }

        [DataMember]
        public float Treble { get; set; }

        [DataMember]
        public float Output { get; set; }

        [DataMember]
        public float Mid { get; set; }
    };
}

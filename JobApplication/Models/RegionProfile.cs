using System;
using System.Collections.Generic;

namespace JobApplication.Models
{
    public partial class RegionProfile
    {
        public uint? RegionProfileId { get; set; }
        public uint? ProfileId { get; set; }
        public uint Id { get; set; }

        public Profile Profile { get; set; }
        public Region RegionProfileNavigation { get; set; }
    }
}

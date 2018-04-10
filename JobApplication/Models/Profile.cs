using System;
using System.Collections.Generic;

namespace JobApplication.Models
{
    public partial class Profile
    {
        public Profile()
        {
            KompetenceProfile = new HashSet<KompetenceProfile>();
            RegionProfile = new HashSet<RegionProfile>();
        }

        public uint Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }

        public ICollection<KompetenceProfile> KompetenceProfile { get; set; }
        public ICollection<RegionProfile> RegionProfile { get; set; }
    }
}

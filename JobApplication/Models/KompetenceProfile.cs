using System;
using System.Collections.Generic;

namespace JobApplication.Models
{
    public partial class KompetenceProfile
    {
        public uint? ProfilekompetenceId { get; set; }
        public uint? KompetenceprofileId { get; set; }
        public uint Id { get; set; }

        public Kompetence Kompetenceprofile { get; set; }
        public Profile Profilekompetence { get; set; }
    }
}

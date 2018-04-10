using JobApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplication.BLL
{
    public interface IJobDBRepository
    {
        IEnumerable<Region> AllRegions();
    }
}

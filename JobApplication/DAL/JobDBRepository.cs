using JobApplication.BLL;
using JobApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplication.DAL
{
    public class JobDBRepository : IJobDBRepository
    {
        private readonly jobdbContext _dbContext;
        public JobDBRepository(jobdbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Region> AllRegions()
        {
            return _dbContext.Region.ToList();   
        }
    }
}

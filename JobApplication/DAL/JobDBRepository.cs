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
        public IEnumerable<Kompetence> KompetenceByAnnonceID(long id)
        {
            IEnumerable<Kompetence> AKList = _dbContext.AnnonceKompetence.Where(x => x.AnnonceId == id).Select(z => z.Komptence);
            //IEnumerable<Kompetence> kList = AKList.Select(x => x.Komptence);
            
           
            return AKList.ToList();
        } 
    }
}

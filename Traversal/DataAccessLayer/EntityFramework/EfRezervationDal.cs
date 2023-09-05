using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfRezervationDal : GenericRepository<Rezervation>, IRezervationDal
    {
        public List<Rezervation> GetListWithRezervationBywithAccepted(int id)
        {
            using (var context = new Context())
            {
                return context.Rezervations.Include(x => x.Destination).Where(x => x.Status == 3 && x.UserId == id).ToList();
            }
        }

        public List<Rezervation> GetListWithRezervationBywithApproval(int id)
        {
            using (var context = new Context())
            {
                   return context.Rezervations.Include(x=>x.Destination).Where(x=>x.Status==1 && x.UserId==id).ToList();
            }
        }

        public List<Rezervation> GetListWithRezervationBywithPrevious(int id)
        {
            using (var context = new Context())
            {
                return context.Rezervations.Include(x => x.Destination).Where(x => x.Status == 4 && x.UserId == id).ToList();
            }
        }
    }
}

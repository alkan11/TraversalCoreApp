using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RezervationManager : IRezervationService
    {
        IRezervationDal _rezervationDal;

        public RezervationManager(IRezervationDal rezervationDal)
        {
            _rezervationDal = rezervationDal;
        }

        public List<Rezervation> GetListWithRezervationBywithAccepted(int id)
        {
            return _rezervationDal.GetListWithRezervationBywithAccepted(id);
        }

        public List<Rezervation> GetListWithRezervationBywithApproval(int id)
        {
            return _rezervationDal.GetListWithRezervationBywithApproval(id);
        }

        public List<Rezervation> GetListWithRezervationBywithPrevious(int id)
        {
            return _rezervationDal.GetListWithRezervationBywithPrevious(id);
        }

        public void TAdd(Rezervation r)
        {
            _rezervationDal.Insert(r);
        }

        public List<Rezervation> TGetAll()
        {
            throw new NotImplementedException();
        }

        public Rezervation TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Rezervation entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Rezervation entity)
        {
            throw new NotImplementedException();
        }
    }
}

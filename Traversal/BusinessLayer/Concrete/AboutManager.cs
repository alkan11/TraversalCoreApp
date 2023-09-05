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
    public class AboutManager : IAboutService
    {
        IAboutdal _aboutdal;
        public AboutManager(IAboutdal aboutdal)
        {
            _aboutdal = aboutdal;
        }
        public void TAdd(About entity)
        {
            _aboutdal.Insert(entity);
            
        }

        public List<About> TGetAll()
        {
            return _aboutdal.GetAll();
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TRemove(About entity)
        {
            _aboutdal.Delete(entity);
        }

        public void TUpdate(About entity)
        {
           _aboutdal.Update(entity);
        }
    }
}

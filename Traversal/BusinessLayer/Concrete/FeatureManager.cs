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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal dal;

        public FeatureManager(IFeatureDal dal)
        {

            this.dal = dal;

        }
        public void TAdd(Feature entity)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetAll()
        {
            return dal.GetAll();
        }

        public Feature TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TRemove(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}

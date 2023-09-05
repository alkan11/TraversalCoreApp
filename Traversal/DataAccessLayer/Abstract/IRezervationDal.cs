using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRezervationDal:IGenericDal<Rezervation>
    {
        List<Rezervation> GetListWithRezervationBywithApproval(int id);  
        List<Rezervation> GetListWithRezervationBywithAccepted(int id);  
        List<Rezervation> GetListWithRezervationBywithPrevious(int id);  
    }
}

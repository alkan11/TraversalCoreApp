using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRezervationService:IGenericService<Rezervation>
    {
        List<Rezervation> GetListWithRezervationBywithApproval(int id); 
        List<Rezervation> GetListWithRezervationBywithAccepted(int id); 
        List<Rezervation> GetListWithRezervationBywithPrevious(int id); 
    }
}

using System.Collections.Generic;
using System.Linq;
using EfSamuariDomain;
using EfSamuariDomain.Entities;

namespace SamuraiWEB.ViewModels
{
    public class StartPageViewModel
    {

        public IEnumerable<SamuraiViewModelOLD> Samurais { get; set; }


        public StartPageViewModel()
        {
            Samurais = new List<SamuraiViewModelOLD>();
        }
        
    }
}

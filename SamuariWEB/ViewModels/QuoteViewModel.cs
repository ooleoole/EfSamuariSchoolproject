using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfSamuariDomain;
using EfSamuariDomain.Entities;

namespace SamuraiWEB.ViewModels
{
    public class QuoteViewModel
    {
        public int Id { get; set; }
        public string SamuraiQuote { get; set; }
        public QuoteType Type { get; set; }
        public string SamuraiName { get; set; }
    }
}

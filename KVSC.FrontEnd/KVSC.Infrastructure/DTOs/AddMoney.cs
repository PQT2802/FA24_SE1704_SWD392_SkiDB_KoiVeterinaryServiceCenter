using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs
{
    public class AddMoney
    {
        public Extensions<AddMoneyData> Extensions { get; set; }
    }
    public class AddMoneyData
    { 
        public string Url { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs
{
    public class GenericTableViewModel
    {
        public List<IPropertyNameProvider> Items { get; set; }
        public List<string> PropertyNames { get; set; }
        public string ListType { get; set; }  // "service" or "appointment"
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs
{
    public interface IPropertyNameProvider
    {
        List<string> GetPropertyNames();
    }
}

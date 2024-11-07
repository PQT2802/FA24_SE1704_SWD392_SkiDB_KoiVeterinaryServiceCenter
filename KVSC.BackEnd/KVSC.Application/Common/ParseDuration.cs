using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Common
{
    public static class ParseDuration
    {
        public static TimeSpan ParseStrIntoTimeSpan(string duration)
        {
            if (duration.EndsWith("hours"))
            {
                var hours = double.Parse(duration.Replace("hours", "").Trim());
                return TimeSpan.FromHours(hours);
            }
            else if (duration.EndsWith("minutes"))
            {
                var minutes = double.Parse(duration.Replace("minutes", "").Trim());
                return TimeSpan.FromMinutes(minutes);
            }
            else
            {
                throw new ArgumentException("Unsupported duration format");
            }
        }
    }
}

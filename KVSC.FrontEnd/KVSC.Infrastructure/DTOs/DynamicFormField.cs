using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs
{
    public class DynamicFormField
    {
        public string Label { get; set; }  // Field label
        public string FieldType { get; set; }  // Field type (e.g., "text", "password", "select", "textarea", "file")
        public string Name { get; set; }  // Field name (used in form submission)
        public string Placeholder { get; set; }  // Field placeholder text
        public bool Required { get; set; }  // Is the field required
        public List<string>? Options { get; set; }  // For select inputs
    }
}

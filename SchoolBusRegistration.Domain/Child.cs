using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRegistration.Domain
{
    public class Child:BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int GradeId { get; set; }
        public int ParentId { get; set; }
        public virtual Parent Parent { get; set; }
        public virtual Grade Grade { get; set; }
    }
}

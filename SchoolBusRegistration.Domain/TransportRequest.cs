using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBusRegistration.Domain
{
    public class TransportRequest:BaseEntity
    {
        public int ChildId { get; set; }
        public int TransportType { get; set; }
        public DateTime StartDate { get; set; }
        public virtual Child Child { get; set; }
    }
}

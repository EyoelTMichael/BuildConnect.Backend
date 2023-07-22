using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Domain.Site
{
    public class Site
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid OwnerId { get; set; }
        
        public Guid ConsultantId { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}

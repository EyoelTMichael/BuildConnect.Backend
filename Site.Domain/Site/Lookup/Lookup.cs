using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Site.Domain.Enums.Enums;

namespace Site.Domain.Site.Lookup
{
    public class Lookup
    {
        public Guid Id { get; set; }
        public LookupType LookUpType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid SiteId { get; set; }

    }
}

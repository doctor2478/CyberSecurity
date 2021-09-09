using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity.Shared.Models.Directoryes
{
    public class CyberSecurityUser
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public Users Users { get; set; }

        public int PaoUnitID { get; set; }

        public PaoUnits PaoUnits { get; set; }
    }
}

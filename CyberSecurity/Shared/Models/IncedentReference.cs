using CyberSecurity.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity.Shared.Models
{
    /// <summary>
    /// Таблица с ссылками по событию
    /// </summary>
    public class IncedentReference
    {
        public int ID { get; set; }
        public int IncidentID { get; set; }

        public Incident Incident { get; set; }

        /// <summary>
        /// Строка с ссылкой
        /// </summary>
        public string Reference { get; set; }

        public int ReferenceTypeID { get; set; }

        public ReferenceType ReferenceType { get; set; }
    }
}

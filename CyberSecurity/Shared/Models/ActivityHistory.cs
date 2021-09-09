using CyberSecurity.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity.Shared.Models
{
    public class ActivityHistory
    {
        public int ID { get; set; }

        public int IncidentID { get; set; }

        public Incident Incident { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Discription { get; set; }

        /// <summary>
        /// Пользователь ответственный за обработку события
        /// </summary>
        public int UserID { get; set; }

        public Users Users { get; set; }


        /// <summary>
        /// Дата последней активности по событию
        /// </summary>
        public DateTime LastActivity { get; set; }

    }
}

using CyberSecurity.Shared.Models;
using CyberSecurity.Shared.Models.Directoryes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity.Shared.Model
{
    public class Incident
    {
        public int ID { get; set; }       
        

        /// <summary>
        /// Тип инцендента
        /// </summary>
        public int TypeID { get; set; }

        public TypeIncidents TypeIncidents { get; set; } 


        /// <summary>
        /// Источник 
        /// </summary>
        public int SourceID { get; set; }

        public SourceIncident SourceIncident { get; set; }


        /// <summary>
        /// Пользователь на ком сработал инцендент
        /// </summary>
        public string AutorUserID { get; set; }


        /// <summary>
        /// Назначеный модератор
        /// </summary>
        public int ModeratorID { get; set; }

        public Users Users { get; set; }

        /// <summary>
        /// Подразделение где произошло событие
        /// </summary>
        public int UnitID { get; set; }

        public PaoUnits PaoUnits { get; set; }

        /// <summary>
        /// Имя сервера KSC
        /// </summary>
        public string KSC_Server { get; set; }

        /// <summary>
        /// Дата создания события
        /// </summary>
        public DateTime DateOfCreation { get; set; }
    }
}

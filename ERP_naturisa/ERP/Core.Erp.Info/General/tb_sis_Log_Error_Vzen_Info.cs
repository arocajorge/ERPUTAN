using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_sis_Log_Error_Vzen_Info
    {

        public string Detalle { get; set; }
        public string Tipo { get; set; }
        public string Clase { get; set; }
        public string Pantalla { get; set; }
        public string Asamble { get; set; }
        public string Usuario { get; set; }
        public string Ip { get; set; }
        public string PC { get; set; }
        public DateTime? Fecha_Trans { get; set; }
        public decimal Id  { get; set; }


        public tb_sis_Log_Error_Vzen_Info(string _detalle, string _Tipo, string _Clase, string _Pantalla, string _Asamble, string _Usuario, string _Ip, string _PC, DateTime _Fecha_Trans)
        {
            Detalle = _detalle;
            Tipo=_Tipo;
            Clase = _Clase;
            Pantalla = _Pantalla;
            Asamble = _Asamble;
            Usuario = _Usuario;
            Ip = _Ip;
            PC = _PC;
            Fecha_Trans = _Fecha_Trans;

        }

        public tb_sis_Log_Error_Vzen_Info()
        {

        }

    }
}

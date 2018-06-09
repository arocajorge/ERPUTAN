using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Bancos;
namespace Core.Erp.Info.Bancos
{
    public class ba_Banco_Otros_Parametros_Info
    {
        public int IdEmpresa { get; set; }
        public bool El_Diario_Contable_es_modificable { get; set; }
        public string IdUsuario { get; set; }
        public string CiudadDefaultParaCrearCheques { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime FechaUltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
       public ba_Banco_Otros_Parametros_Info() { }
    }
}

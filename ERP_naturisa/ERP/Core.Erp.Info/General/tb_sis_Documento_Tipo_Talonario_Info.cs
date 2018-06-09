using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_sis_Documento_Tipo_Talonario_Info
    {

        public int  IdEmpresa { get; set; }
        public string CodDocumentoTipo { get; set; }
        public string  Establecimiento { get; set; }
        public string PuntoEmision { get; set; }
        public string NumDocumento { get; set; }
        public DateTime ? FechaCaducidad { get; set; }
        public bool  ? Usado { get; set; }
        public string Estado { get; set; }
        public int  IdSucursal { get; set; }
        public string NumAutorizacion { get; set; }
        public string NombreSucursal { get; set; }
        public string NombreEmpresa { get; set; }        
        public bool es_Documento_electronico { get; set; } 

       public tb_sis_Documento_Tipo_Talonario_Info()
       {

       }
    }
    
}

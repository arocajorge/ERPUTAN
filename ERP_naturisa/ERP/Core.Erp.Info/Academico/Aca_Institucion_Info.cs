
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Academico
{
   public class Aca_Institucion_Info
    {
        public int IdEmpresa { get; set; }
        public int IdInstitucion { get; set; }
        public string CodInstitucion { get; set; }
        public string Ruc { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }        
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Rector { get; set; }
        public string Coordinador { get; set; }
        public string Secretario { get; set; }
        public string Resolucion_Academica { get; set; }
        public string SitioWeb { get; set; }
        public string Estado { get; set; }
        public byte[] Logo { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public DateTime ? FechaCreacion { get; set; }
        public DateTime ? FechaMoficacion { get; set; }
        public DateTime ? FechaAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }

        public tb_pais_Info paisInfo { get; set; }
        public tb_ciudad_Info ciudadInfo { get; set; }
        public tb_provincia_Info provinciaInfo { get; set; }
        
       public Aca_Institucion_Info() {
           paisInfo = new tb_pais_Info();
           ciudadInfo = new tb_ciudad_Info();
           provinciaInfo = new tb_provincia_Info();           
       }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.General
{
    public class tb_contacto_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdContacto { get; set; }
        public decimal IdPersona { get; set; }
        public string CodContacto { get; set; }
        public string Organizacion { get; set; }
        public string Cargo { get; set; }
        public string Mostrar_como { get; set; }
        public DateTime Fecha_alta { get; set; }
        public DateTime Fecha_Ult_Contacto { get; set; }

        public string IdPais { get; set; }
        public string IdProvincia { get; set; }
        public string IdCiudad { get; set; }
        public string IdNacionalidad { get; set; }


        public string Notas { get; set; }
        public string Pagina_Web { get; set; }
        public string Codigo_postal { get; set; }
        public byte[] foto { get; set; }
        public tb_persona_Info Persona_Info { get; set; }
        public tb_pais_Info Pais_Info { get; set; }
        public tb_provincia_Info Provi_Info { get; set; }
        public tb_ciudad_Info Ciudad_Info { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public string Estado { get; set; }

        public tb_contacto_Info()
        {
            Persona_Info = new tb_persona_Info();
            Pais_Info = new tb_pais_Info();
            Ciudad_Info = new tb_ciudad_Info();
            Provi_Info = new tb_provincia_Info();
        }
    }
}

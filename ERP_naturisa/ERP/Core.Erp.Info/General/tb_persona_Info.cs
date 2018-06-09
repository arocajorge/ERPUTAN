using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Core.Erp.Info.General
{

    public class tb_persona_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPersona { get; set; }
        public string CodPersona { get; set; }
        public string pe_Naturaleza { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_razonSocial { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public int IdTipoPersona { get; set; }
        public string IdTipoDocumento { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_direccion { get; set; }


        public string pe_telefonoCasa { get; set; }
        public string pe_telefonoOfic { get; set; }
        public string pe_telefonoInter { get; set; }
        public string pe_telfono_Contacto { get; set; }
        public string pe_celular { get; set; }
        public string pe_correo { get; set; }
        public string pe_fax { get; set; }
        public string pe_casilla { get; set; }
        public string pe_sexo { get; set; }
        public string IdEstadoCivil { get; set; }
        public DateTime? pe_fechaNacimiento { get; set; }
        public string pe_estado { get; set; }
        public DateTime? pe_fechaCreacion { get; set; }
        public DateTime? pe_fechaModificacion { get; set; }
        public string pe_UltUsuarioModi { get; set; }

        public string IdUsuario { get; set; }
        public string pe_celularSecundario { get; set; }

        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }

        public string pe_correo_secundario1 { get; set; }
        public string pe_correo_secundario2 { get; set; }


        public string IdTipoCta_acreditacion_cat { get; set; }
        public string num_cta_acreditacion { get; set; }
        public Nullable<int> IdBanco_acreditacion { get; set; }

        public string CodigoLegal { get; set; }
        public string ba_descripcion { get; set; }

        public List<tb_persona_direccion_Info> list_direcciones_x_persona { get; set; }

        


        public tb_persona_Info()
        {
            list_direcciones_x_persona = new List<tb_persona_direccion_Info>();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Core.Erp.Info.General
{


    [DataContract(Name = "Empleado_Info", Namespace = "")]
   public  class tb_Empresa_Info
    {
        [DataMember]
        public int IdEmpresa { get; set; }
        public string codigo { get; set; }
        [DataMember]
        public string em_nombre { get; set; }
        public string em_nombre2 { get; set; }
        public string em_ruc { get; set; }
        public string em_gerente { get; set; }
        public string em_contador { get; set; }
        public string em_rucContador { get; set; }
        public string em_telefonos { get; set; }
        public string em_fax { get; set; }
        public int em_notificacion { get; set; }
        public string em_direccion { get; set; }
        public Boolean check{ get; set; }
      
        public string em_tel_int { get; set; }
        public byte [] em_logo { get; set; }
        public byte [] em_fondo { get; set; }

        public Image em_logo_Image { get; set; }
        public Image em_fondo_Image { get; set; }
       
        public DateTime em_fechaInicioContable { get; set; }

        public string Estado { get; set; }

        public string IdCtaCble { get; set; }
        public string nomCuenta { get; set; }

        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string ContribuyenteEspecial { get; set; }
        public string ObligadoAllevarConta { get; set; }

        public string cod_entidad_dinardap { get; set; }
        public string em_Email { get; set; }


        public tb_Empresa_Info() { }


    }


   

}

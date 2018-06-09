using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;


namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_proveedor_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdProveedor { get; set; }
        public Decimal IdPersona { get; set; }
        public string pr_codigo { get; set; }
        public string pr_nombre { get; set; }
        public string pr_nombre_codigo { get; set; }
        public string pr_girar_cheque_a { get; set; }
        public string IdTipoServicio { get; set; }
        public string IdCtaCble_CXP { get; set; }
        public string IdTipoGasto { get; set; }
        public string pr_contribuyenteEspecial { get; set; }
        public int? pr_plazo { get; set; }
        public string pr_estado { get; set; }
        public string pr_nacionalidad { get; set; }
        public int? idCredito_Predeter { get; set; }
        public string nom_Credito_Predeter { get; set; }
        public int? codigoSRI_ICE_Predeter { get; set; }
        public string nom_codigoSRI_ICE { get; set; }
        public int?  codigoSRI_101_Predeter { get; set; }
        public string nom_codigoSRI_101 { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string pr_nombre2 { get; set; }

        public string contacto { get; set; }
        public string responsable { get; set; }
        public string comentario { get; set; }
        public double Presupuesto { get; set; }

        public string IdCtaCble_Gasto { get; set; }
        public string IdCentroCosoto { get; set; }
        public string IdCtaCble_Anticipo { get; set; }
        public int IdClaseProveedor { get; set; }
        public string descripcion_clas_prove { get; set; }
        public string representante_legal { get; set; }

        public string SEstado { get; set; }

        public decimal secuencial { get; set; }
        public string IdSubCentroCosoto { get; set; }
        public string NumAutorizacion_Imprenta { get; set; }
        
        public tb_persona_Info Persona_Info  { get; set; }
        public List<cp_proveedor_codigo_SRI_Info> lista_codigoSRI_Proveedor { get; set; }
        public List<cp_proveedor_codigo_SRI_Info> lista_codigoSRI_Proveedor_Old { get; set; }

        public string MotivoAnulacion { get; set; }


        public string IdPais { get; set; }
        public string IdProvincia { get; set; }
        public string IdCiudad { get; set; }



        public string IdTipoCta_acreditacion_cat { get; set; }
        public string num_cta_acreditacion { get; set; }
        public Nullable<int> IdBanco_acreditacion { get; set; }

        public string CodigoLegal { get; set; }
        public string ba_descripcion { get; set; }

        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public bool es_empresa_relacionada { get; set; }

        public cp_proveedor_Info()
        {

            lista_codigoSRI_Proveedor = new List<cp_proveedor_codigo_SRI_Info>();
            lista_codigoSRI_Proveedor_Old = new List<cp_proveedor_codigo_SRI_Info>();
            Persona_Info = new tb_persona_Info();
        
        }

    }
}

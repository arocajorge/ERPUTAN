using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Facturacion
{
    public class fa_Cliente_Info 
    {
        public int IdEmpresa { get; set; }
        public decimal IdCliente { get; set; }
        public string Codigo { get; set; }
        public int IdSucursal { get; set; }
        public int IdVendedor { get; set; }
        public int Idtipo_cliente { get; set; }
        public string IdTipoCredito { get; set; }
        public string cl_Cat_crediticia { get; set; }
        public int cl_plazo { get; set; }
        public double cl_porcentaje_descuento { get; set; }
        public string IdCtaCble_cxc { get; set; }
        public string cl_Cell_Garante { get; set; }
        public string cl_Garante { get; set; }
        public string cl_Mail_Garante { get; set; }
        public string cl_observacion { get; set; }
        public string IdCiudad { get; set; }
        public double cl_Cupo { get; set; }
        
        public decimal? IdClienteRelacionado { get; set; }
        public string cl_Rep_Legal { get; set; }
        public string cl_Mail_Rep_Legal { get; set; }
        public string cl_Cell_Rep_Legal { get; set; }
        public string cl_Ger_Gen { get; set; }
        public string cl_Mail_Ger_Gen { get; set; }
        public string cl_Cell_Ger_Gen { get; set; }
        public string cl_casilla { get; set; }
        public string cl_fax { get; set; }
        public string IdActividadComercial { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string  Estado { get; set; }
        public string SEstado { get; set; }
        public decimal IdPersona { get; set; }
        
        public string Ubicacion { get; set; }
        public tb_persona_Info Persona_Info { get; set; }
        public string Nombre_Cliente { get; set; }
        public string IdCtaCble_Anti { get; set; }
        public string nomSucursal { get; set; }

        public string IdCentroCosto_CXC { get; set; }
        public string IdCentroCosto_Anticipo { get; set; }

        public string IdPais { get; set; }
        public string IdProvincia { get; set; }

        public string IdCentroCosto_CXC_Credito { get; set; }
        public string IdCtaCble_cxc_Credito { get; set; }
        
        

        public string Mail_Principal { get; set; }
        public string Mail_Secundario1 { get; set; }
        public string Mail_Secundario2 { get; set; }



        public string IdParroquia { get; set; }


        public List<fa_cliente_contactos_Info> list_contactos_x_cliente { get; set; }
        public List<fa_cliente_pto_emision_cliente_Info> list_punto_emision_x_cliente { get; set; }

        public bool es_empresa_relacionada { get; set; }
        

        public fa_Cliente_Info()
        {
            Persona_Info = new tb_persona_Info();
            list_contactos_x_cliente = new List<fa_cliente_contactos_Info>();
            list_punto_emision_x_cliente = new List<fa_cliente_pto_emision_cliente_Info>();

        }
     

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Contabilidad
{
    public class ct_Centro_costo_Info
    {
        public int IdEmpresa { get; set; }
        public string IdCentroCosto { get; set; }
        public string Centro_costo { get; set; }
        public string Centro_costo2 { get; set; }
        public string IdCentroCostoPadre { get; set; }
        public decimal IdCatalogo { get; set; }
        public string pc_EsMovimiento { get; set; }
        public int IdNivel { get; set; }
        public string pc_Estado { get; set; }
        public string CodCentroCosto { get; set; }
        public string Centro_costoPadre { get; set; }
        public string  IdCtaCble { get; set; }


        public DateTime? Fecha_Transac { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime? Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotivoAnulacion { get; set; }
        public Boolean Check { get; set; }
        public string Sestado { get; set; }

        public string pe_razonSocial { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telefonoOfic { get; set; }
        public decimal IdCliente_cli { get; set; }
        public string IdCentroCosto_cc { get; set; }
        public int IdEmpresa_cc { get; set; }
        public int IdEmpresa_cli { get; set; }
        public string nom_Centro_costo { get; set; }
        public string nom_Cliente { get; set; }
        public string Descripcion_Ciudad { get; set; }
        public string pe_correo { get; set; }
        public string pe_celular { get; set; }

        public ct_Centro_costo_Info() 
        { }

        public ct_Centro_costo_Info (int _IdEmpresa, string _IdCentroCosto,string _nom_centro_costo)
        {
            IdEmpresa = _IdEmpresa;
            Centro_costo = _nom_centro_costo;
            Centro_costo2 = "["+_IdCentroCosto + "]-  "+ _nom_centro_costo;
            IdCentroCosto = _IdCentroCosto;
        }

    }
}

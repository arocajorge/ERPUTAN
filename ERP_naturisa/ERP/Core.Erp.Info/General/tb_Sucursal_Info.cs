using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_Sucursal_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public string Su_Descripcion2 { get; set; }
        public string codigo { get; set; }

        public string Su_CodigoEstablecimiento { get; set; }
        public string Su_Ubicacion { get; set; }
        public string Su_Ruc { get; set; }
        public string Su_JefeSucursal { get; set; }
        public string Su_Telefonos { get; set; }
        public string Su_Direccion { get; set; }

        public Boolean Estado { get; set; }
        public string SEstado { get; set; }
        public string IdUsuario { get; set; }
        public string MotiAnula { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public Nullable<bool> Es_establecimiento { get; set; }
        public Boolean Chek { get; set; }

        public List<List<tb_Bodega_Info>> ListasBodegasXSucursal { get; set; }
        public string NomEmpresa { get; set; }

        public tb_Sucursal_Info()
        {
            ListasBodegasXSucursal = new List<List<tb_Bodega_Info>>();
        }

        public tb_Sucursal_Info(int _IdEmpresa, int _IdSucursal, string _Su_Descripcion)
        {
            IdEmpresa = _IdEmpresa;
            IdSucursal = _IdSucursal;
            Su_Descripcion = _Su_Descripcion;
            Su_Descripcion2 = "[" + _IdSucursal + "]" + _Su_Descripcion;
            Estado = true;
            codigo = _IdSucursal.ToString();
        }
    }
}
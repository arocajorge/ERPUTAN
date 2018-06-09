using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Caja
{
    public class caj_Caja_Movimiento_Tipo_Info
    {
        public Nullable<int> IdEmpresa { get; set; }
        public	int	IdTipoMovi	{ get; set; }
        public	string	tm_descripcion	{ get; set; }
        public	string	Estado	{ get; set; }
        public	string	tm_Signo	{ get; set; }
        public	string	IdCtaCble	{ get; set; }
        public	string	IdUsuario	{ get; set; }
        public	DateTime?	Fecha_Transac	{ get; set; }
        public	string	IdUsuarioUltMod	{ get; set; }
        public	DateTime?	Fecha_UltMod	{ get; set; }
        public	string	IdUsuarioUltAnu	{ get; set; }
        public	DateTime?	Fecha_UltAnu	{ get; set; }
        public	string	nom_pc	{ get; set; }
        public	string	ip	{ get; set; }
        public	string	MotivoAnulacion	{ get; set; }
        public string IngEgr { get; set; }
        public string SEstado { get; set; }
        public bool SeDeposita { get; set; }
        
        public string pc_clave_corta { get; set; }
        public string pc_Cuenta { get; set; }
    public  caj_Caja_Movimiento_Tipo_Info(){}
    }

}

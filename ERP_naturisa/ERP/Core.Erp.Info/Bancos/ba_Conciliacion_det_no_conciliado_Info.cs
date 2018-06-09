using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Bancos
{
    public class ba_Conciliacion_det_no_conciliado_Info
    {
        public	int	IdEmpresa	{ get; set; }
        public	decimal IdConciliacion	{ get; set; }
        public	int	Secuencia	{ get; set; }
        public	decimal IdCbteCble	{ get; set; }
        public	int	IdTipocbte	{ get; set; }
        public	int	SecuenciaCbte	{ get; set; }
        public	string 	Estado	{ get; set; }
        public	string	IdUsuario	{ get; set; }
        public	string	IdUsuario_Anu	{ get; set; }
        public	string IdUsuarioUltMod	{ get; set; }
        public	DateTime?	Fecha_Transac	{ get; set; }
        public	DateTime?	Fecha_UltMod	{ get; set; }
        public	DateTime?	FechaAnulacion	{ get; set; }
        public	string	ip	{ get; set; } 
        public	string	nom_pc	{ get; set; }
        public string MotivoAnulacion { get; set; }
        public string tipo_IngEgr { get; set; } 



        public ba_Conciliacion_det_no_conciliado_Info(){}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Drawing;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_reembolso_Info
    {

        public int IdEmpresa{ get; set; }
		public decimal IdCbteCble_Ogiro{ get; set; }
		public int IdTipoCbte_Ogiro{ get; set; }
        public decimal IdReembolso { get; set; }
		public Nullable<decimal> IdProveedor{ get; set; }
		public string TipoIdProveedor{ get; set; }
		public string IdentificacionProveedor{ get; set; }
		public string TipoDoc_CodSRI{ get; set; }
		public string Establecimiento{ get; set; }
		public string Punto_Emision{ get; set; }
		public string Secuencial{ get; set; }
		public string Autorizacion{ get; set; }
		public Nullable<DateTime> Fecha_Emision{ get; set; }
		public Nullable<double> TarifaIVAcero{ get; set; }
		public Nullable<double> TarifaIVADiferentecero{ get; set; }
		public Nullable<double> TarifaNoObjetoIVA{ get; set; }
		public Nullable<double> MontoICE{ get; set; }
        public Nullable<double> MontoIVA{ get; set; }

        public Nullable<double> baseImponible { get; set; }
        public Nullable<double> Total { get; set; }



        public Boolean Ico_Prove
        {
            get { return true; }
            set{} 
        }

        public Boolean Ico_Autoriza
        {
            get { return true; }
            set { }
        }

        //public Bitmap Ico_Prove { get; set; }
        //public Bitmap Ico_Autoriza { get; set; }




        public cp_reembolso_Info(){}
    }
}

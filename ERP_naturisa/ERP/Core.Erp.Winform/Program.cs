using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Core.Erp.Winform;
using Core.Erp.Winform.Contabilidad;
using Core.Erp.Winform.General;
using Core.Erp.Winform.CuentasxPagar;
using Core.Erp.Winform.ActivoFijo;
using Core.Erp.Winform.Academico;
using Core.Erp.Winform.Inventario_Cidersus;
using Core.Erp.Winform.Bancos;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Winform.Produc_Cirdesus;
using Core.Erp.Winform.Roles;
using Core.Erp.Winform.Compras;
using Core.Erp.Winform.Inventario;
using Core.Erp.Winform.Produccion_Talme;
using Core.Erp.Winform.Importacion;
using Core.Erp.Winform.CuentasxCobrar;
using Core.Erp.Winform.Compras_cidersus;
using Core.Erp.Winform.Caja;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.SeguridadAcceso;
using Core.Erp.Winform.ActivoFijo_FJ;
using Cus.Erp.Reports.FJ.ActivoFijo;
using Core.Erp.Business.General;
using Cus.Erp.Reports.Naturisa.CuentasxPagar;

using Cus.Erp.Reports.Naturisa.Compras;
using Core.Erp.Reportes.Compras;
using Core.Erp.Reportes.Facturacion;
using Core.Erp.Reportes.Caja;
using Core.Erp.Reportes.CuentasxCobrar;
using Core.Erp.Reportes.CuentasxPagar;
using Core.Erp.Reportes.Contabilidad;
using Core.Erp.Reportes.Roles;

using Core.Erp.Reportes.ActivoFijo;
using Core.Erp.Reportes.Inventario;
using Core.Erp.Reportes.Academico;
using Core.Erp.Reportes.Bancos;
using Core.Erp.Business.Academico;

using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using Core.Erp.Winform.Facturacion_Fj;
using Core.Erp.Winform.Facturacion_Grafinpren;
using DevExpress.XtraSplashForm;
using System.Threading;
using System.Globalization;
using Core.Erp.Winform.Roles_Fj;
using Core.Erp.Winform.CuentasxCobrar_Grafinpren;

using Cus.ERP.Reports.Grafinpren.Facturacion;
using Cus.Erp.Reports.CAH.Colecturia;
using Core.Erp.Winform.Compras_FJ;
using Cus.Erp.Reports.Cidersus.Produccion;


using Core.Erp.Winform.Inventario_Fj;
using Cus.Erp.Reports.FJ.Roles;
namespace Core.Erp.Winform
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Properties.Settings.Default.ConfRegional);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.ConfRegional);

            Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator=".";
            Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator=",";

            Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator=".";
            Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator=",";

            Thread.CurrentThread.CurrentCulture.NumberFormat.PercentDecimalSeparator=".";
            Thread.CurrentThread.CurrentCulture.NumberFormat.PercentGroupSeparator = ",";

            Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            

            tb_Empresa_Bus BusEmpresa = new tb_Empresa_Bus();
            tb_Empresa_Info InfoEmpresa = new tb_Empresa_Info();
            tb_Sucursal_Info InfoSucursal = new tb_Sucursal_Info();
            tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();

            try
            {
                InfoEmpresa  = BusEmpresa.Get_Info_Empresa(1); //CAMBIAR PARA INICIAR CON LA EMPRESA Q SE DESEE
                InfoSucursal = BusSucursal.Get_Info_Sucursal(InfoEmpresa.IdEmpresa, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la Base Verifique la cadena de conexion APP..\n\n\n\n" + ex.Message , "Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Core.Erp.Business.General.cl_parametrosGenerales_Bus param = Core.Erp.Business.General.cl_parametrosGenerales_Bus.Instance;
            param.IdEmpresa = InfoEmpresa.IdEmpresa;
            param.IdSucursal = InfoSucursal.IdSucursal;
            param.IdUsuario = "No_log_sysVZEN";
            param.IdSucursal = 1;
            param.InfoEmpresa = InfoEmpresa;
            param.InfoSucursal = InfoSucursal;
            param.IdInstitucion = 1;
            param.em_Email = InfoEmpresa.em_Email;
            Application.Run(new FrmMain());
            
         }
    }
}  
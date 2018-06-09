using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.Inventario
{
    public partial class XINV_Rpt025_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XINV_Rpt025_Info> Lista = new List<XINV_Rpt025_Info>();
        XINV_Rpt025_Bus bus_Rpt = new XINV_Rpt025_Bus();

        public XINV_Rpt025_Rpt()
        {
            InitializeComponent();
        }

        public void Set_parameters(int IdSucursal, string nom_Sucursal, int IdBodega, string nom_Bodega, int IdMovi_inven_tipo,string nom_Movi_inven_tipo, decimal IdProducto, string nom_Producto, DateTime fecha_ini, DateTime fecha_fin, string signo)
        {
            try
            {
                p_IdSusursal.Value = IdSucursal;
                p_IdSusursal.Visible = false;

                p_IdBodega.Value = IdBodega;
                p_IdBodega.Visible = false;

                p_IdMovi_inven_tipo.Value = IdMovi_inven_tipo;
                p_IdMovi_inven_tipo.Visible = false;

                p_IdProducto.Value = IdProducto;
                p_IdProducto.Visible = false;

                p_Fecha_ini.Value = fecha_ini;
                p_Fecha_ini.Visible = false;

                p_Fecha_fin.Value = fecha_fin;
                p_Fecha_fin.Visible = false;

                p_nom_Sucursal.Value = nom_Sucursal;
                p_nom_Bodega.Value = nom_Bodega;
                p_nom_Movi_inven_tipo.Value = nom_Movi_inven_tipo;
                p_nom_Producto.Value = nom_Producto;
                p_Signo.Value = signo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Set_parameters", ex.Message), ex) { EntityType = typeof(XINV_Rpt025_Rpt) };
            }
        }

        private void XINV_Rpt025_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblFecha.Text = param.Fecha_Transac.ToString();
                lblUsuario.Text = param.IdUsuario;
                pic_Empresa.Image = param.InfoEmpresa.em_logo_Image;

                int IdEmpresa = param.IdEmpresa;
                int IdSucursal = Convert.ToInt32(p_IdSusursal.Value);
                int IdBodega = Convert.ToInt32(p_IdBodega.Value);
                int IdMovi_inven_tipo = Convert.ToInt32(p_IdMovi_inven_tipo.Value);
                decimal IdProducto = Convert.ToDecimal(p_IdProducto.Value);
                DateTime fecha_ini = Convert.ToDateTime(p_Fecha_ini.Value);
                DateTime fecha_fin = Convert.ToDateTime(p_Fecha_fin.Value);
                string signo = p_Signo.Value.ToString();
                Lista = bus_Rpt.Get_list_reporte(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdProducto, fecha_ini, fecha_fin,signo);
                this.DataSource = Lista;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_Rpt025_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_Rpt025_Rpt) };
            }
        }

    }
}

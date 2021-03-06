﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;


namespace Cus.Erp.Reports.Naturisa.Compras
{
    public partial class XCOMP_NATU_Rpt001_frm : Form
    {
        #region Declaración de Variables
        //Bus
        tb_Sucursal_Bus buSucursal = new tb_Sucursal_Bus();
        cp_proveedor_Bus busProveedor = new cp_proveedor_Bus();
        in_producto_Bus busProducto = new in_producto_Bus();
        tb_persona_bus busPersona = new tb_persona_bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        com_comprador_Bus bus_Comprador = new com_comprador_Bus();
        //Listas
        List<com_comprador_Info> CompradorList = new List<com_comprador_Info>();        
        List<tb_Sucursal_Info> listSucursal = new List<tb_Sucursal_Info>();
        List<cp_proveedor_Info> listProveedor = new List<cp_proveedor_Info>();
        List<in_Producto_Info> ListProducto = new List<in_Producto_Info>();
        List<tb_persona_Info> listPersona = new List<tb_persona_Info>();
         
        #endregion
               
        public XCOMP_NATU_Rpt001_frm()
        {
            InitializeComponent();
        }

        void cargar_combos()
        {
            try
            {
                ucCom_Menu_Reportes1.Cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    
        private void XCOMP_NATU_Rpt001_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucCom_Menu_Reportes1_event_btnsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucCom_Menu_Reportes1_event_btnRefrescar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCOMP_NATU_Rpt001_Rpt Reporte = new XCOMP_NATU_Rpt001_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                Reporte.P_IdSucursal.Value = ucCom_Menu_Reportes1.bei_sucursal.EditValue == null ? 0 : Convert.ToInt32(ucCom_Menu_Reportes1.bei_sucursal.EditValue);
                Reporte.P_IdProducto.Value = ucCom_Menu_Reportes1.bei_producto.EditValue == null ? 0 : Convert.ToDecimal(ucCom_Menu_Reportes1.bei_producto.EditValue);
                Reporte.P_IdGrupo.Value = ucCom_Menu_Reportes1.bei_grupo.EditValue == null ? 0 : Convert.ToInt32(ucCom_Menu_Reportes1.bei_grupo.EditValue);
                Reporte.P_IdPunto_cargo.Value = ucCom_Menu_Reportes1.bei_punto_cargo.EditValue == null ? 0 : Convert.ToInt32(ucCom_Menu_Reportes1.bei_punto_cargo.EditValue);
                Reporte.P_IdProveedor.Value = ucCom_Menu_Reportes1.bei_proveedor.EditValue == null ? 0 : Convert.ToDecimal(ucCom_Menu_Reportes1.bei_proveedor.EditValue);
                Reporte.P_IdOrdenCompra.Value = ucCom_Menu_Reportes1.bei_num_oc.EditValue == null ? 0 : Convert.ToDecimal(ucCom_Menu_Reportes1.bei_num_oc.EditValue);
                Reporte.P_Fecha_ini.Value = ucCom_Menu_Reportes1.dtp_fechaIni.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucCom_Menu_Reportes1.dtp_fechaIni.EditValue);
                Reporte.P_Fecha_fin.Value = ucCom_Menu_Reportes1.dtp_fechaFin.EditValue == null ? DateTime.Now : Convert.ToDateTime(ucCom_Menu_Reportes1.dtp_fechaFin.EditValue);
                Reporte.P_Mostrar_anuladas.Value = ucCom_Menu_Reportes1.bei_check1.EditValue == null ? false : Convert.ToBoolean(ucCom_Menu_Reportes1.bei_check1.EditValue);

                pt.AutoShowParametersPanel = false;

                printControl1.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.Controles;
namespace Core.Erp.Winform.Inventario
{
    public partial class frmIn_AjusteFisico_Consulta : Form
    {//Version 1.1
        public frmIn_AjusteFisico_Consulta()
        {
            try
            {
              InitializeComponent();
              //  frm.Event_frmIn_Ajuste_Inventario_fisico_FormClosing += frm_Event_frmIn_Ajuste_Inventario_fisico_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
          
        }

        void frm_Event_frmIn_Ajuste_Inventario_fisico_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              CargarGrid();
            }
            catch (Exception ex)
            {
                   Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        frmIn_Ajuste_Inventario_fisico frm;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        UCIn_Sucursal_Bodega crtl_SucBod = new UCIn_Sucursal_Bodega();
        tb_Bodega_Info _InfoBodega = new tb_Bodega_Info();
        tb_Sucursal_Info _InfoSucursal = new tb_Sucursal_Info();
        in_ajusteFisico_Info _info = new in_ajusteFisico_Info();
       

        in_AjusteFisico_Bus oBus = new in_AjusteFisico_Bus();

        private void frmIn_AjusteFisico_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                dtpDesde.Value = DateTime.Today.AddDays(-30);

                crtl_SucBod.Dock = DockStyle.Fill;
                crtl_SucBod.TipoCarga = Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
                panelSucursal.Controls.Add(crtl_SucBod);
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }

        private in_ajusteFisico_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {

            try
            {
                return (in_ajusteFisico_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new in_ajusteFisico_Info();
            }
        }

        public void CargarGrid() 
        {
            try
            {

                _InfoBodega = crtl_SucBod.get_bodega();
                _InfoSucursal = crtl_SucBod.get_sucursal();


                gridControl.DataSource = oBus.ConsultaGenera(param.IdEmpresa, _InfoSucursal.IdSucursal, _InfoBodega.IdBodega, dtpDesde.Value, dtpHasta.Value);
        
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void mnuNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                     frm = new frmIn_Ajuste_Inventario_fisico();
                     frm.Event_frmIn_Ajuste_Inventario_fisico_FormClosing += frm_Event_frmIn_Ajuste_Inventario_fisico_FormClosing;
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }
        }

        private void mnu_consultar_Click(object sender, EventArgs e)
        {
            try
            {

                frmIn_Ajuste_Inventario_fisico frm = new frmIn_Ajuste_Inventario_fisico();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                frm.InfoSet = _info;
                frm.ShowDialog();
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }

        private void gvAjustes_Cabecera_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                _info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void mnu_salir_Click(object sender, EventArgs e)
        {
            try
            {
             Close();
            }
            catch ( Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

      
    }
}

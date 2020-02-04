using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
//ultima version 24 junio 2013
namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_cbtecble_Plantilla_Consulta : Form
    {
        #region Declaración de Variables
        frmCon_cbtecble_Plantilla frm = new frmCon_cbtecble_Plantilla();

        ct_cbtecble_Plantilla_Bus BusCbteCble_plantilla = new ct_cbtecble_Plantilla_Bus();
        ct_cbtecble_Plantilla_Info InfoCbteCble_Plantilla = new ct_cbtecble_Plantilla_Info();
        
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        public bool LlamaOtraPantalla { get; set; }
        

        int c;
        #endregion
        
        public frmCon_cbtecble_Plantilla_Consulta()
        {
            try
            {
              InitializeComponent();
              ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;

            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LlamaFrm(Cl_Enumeradores.eTipo_action.grabar, InfoCbteCble_Plantilla);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LlamaFrm(Cl_Enumeradores.eTipo_action.actualizar, InfoCbteCble_Plantilla);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LlamaFrm(Cl_Enumeradores.eTipo_action.consultar, InfoCbteCble_Plantilla);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LlamaFrm(Cl_Enumeradores.eTipo_action.Anular, InfoCbteCble_Plantilla);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void frmCon_cbtecble_Plantilla_Consulta_Load(object sender, EventArgs e)
        {
            try
             {
                 CargaLst();
                 c = 0;
                 if (LlamaOtraPantalla)
                 {
                    
                 }
             }
             catch (Exception ex)
             {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void CargaLst()
        {
            try
            {
                griCbte.DataSource= BusCbteCble_plantilla.Get_list_cbtecble_Plantilla(param.IdEmpresa); 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlamaFrm(Cl_Enumeradores.eTipo_action Accion, ct_cbtecble_Plantilla_Info Info)
        {
            try
            {
                frm = new frmCon_cbtecble_Plantilla();
                frm._Accion = Accion;
                frm.MdiParent = this.MdiParent;
                frm.event_frmCon_cbtecble_Plantilla_FormClosing += new frmCon_cbtecble_Plantilla.delegate_frmCon_cbtecble_Plantilla_FormClosing(frm_event_frmCon_cbtecble_Plantilla);
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.Info_Plantilla = Info;                    
                }
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCon_cbtecble_Plantilla(object sender, FormClosingEventArgs e)
        {
            try
            {
                 CargaLst();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewCbte_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoCbteCble_Plantilla = (ct_cbtecble_Plantilla_Info) gridViewCbte.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewCbte_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (LlamaOtraPantalla)
                {
                    c++;
                    if (c == 2)
                    {
                       
                        InfoCbteCble_Plantilla = BusCbteCble_plantilla.Get_Info_Plantilla(param.IdEmpresa, InfoCbteCble_Plantilla.IdTipoCbte, InfoCbteCble_Plantilla.IdPlantilla);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewCbte_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                     //if (LlamaOtraPantalla && e.KeyChar == '\r')
                     //{
                     //        CbteCble_I = BusCbteCble_plantilla.Get_Info_Plantilla_CbteCble(param.IdEmpresa, InfoCbteCble_Plantilla.IdTipoCbte, InfoCbteCble_Plantilla.IdPlantilla);
                     //        this.Close();
                     //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void gridViewCbte_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewCbte.GetRow(e.RowHandle) as ct_cbtecble_Plantilla_Info;
                if (data == null)
                    return;
                if (data.cb_Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        ct_Cbtecble_Info InfoCbte = new ct_Cbtecble_Info();

        public ct_cbtecble_Plantilla_Info  Get_Info_CbteCble_plantilla()
        { 
            try 
            {	        
		        return InfoCbteCble_Plantilla;
            }
            catch (Exception ex)
            {
                return new ct_cbtecble_Plantilla_Info();
            }
            
        }
        public ct_Cbtecble_Info Get_Info_CbteCble()
        {
            try
            {

                return InfoCbte;
            }
            catch (Exception ex)
            {
                return new ct_Cbtecble_Info();
            }

        }

        private void gridViewCbte_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (LlamaOtraPantalla)
                {
                    InfoCbteCble_Plantilla = BusCbteCble_plantilla.Get_Info_Plantilla(param.IdEmpresa, InfoCbteCble_Plantilla.IdTipoCbte, InfoCbteCble_Plantilla.IdPlantilla);

                    InfoCbte.IdTipoCbte = InfoCbteCble_Plantilla.IdTipoCbte;
                    InfoCbte.cb_Fecha = InfoCbteCble_Plantilla.cb_Fecha;
                    InfoCbte.cb_Observacion = InfoCbteCble_Plantilla.cb_Observacion;
                    InfoCbte._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();

                    foreach (var item in InfoCbteCble_Plantilla.LstDet)
                    {
                        ct_Cbtecble_det_Info infoDet= new ct_Cbtecble_det_Info();
                        infoDet.IdTipoCbte = item.IdTipoCbte;
                        infoDet.IdCtaCble = item.IdCtaCble;
                        infoDet.dc_Observacion = item.dc_Observacion;
                        infoDet.IdCentroCosto = item.IdCentroCosto;
                        infoDet.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        infoDet.IdPunto_cargo = item.IdPunto_cargo;
                        infoDet.dc_Valor = item.dc_Valor;
                        infoDet.dc_Valor_D = (item.dc_Valor > 0) ? item.dc_Valor : 0;
                        infoDet.dc_Valor_H = (item.dc_Valor < 0) ? item.dc_Valor * -1 : 0;

                        InfoCbte._cbteCble_det_lista_info.Add(infoDet);
                    }


                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

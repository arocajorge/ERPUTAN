using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Importacion;
using Core.Erp.Info.Importacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Importacion
{
    public partial class frmImp_ParametrosGastos_Consulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        imp_gastosxImport_Bus Bus = new imp_gastosxImport_Bus();
        frmImp_ParametrosGastosMant ofrm = new frmImp_ParametrosGastosMant();
        public frmImp_ParametrosGastos_Consulta()
        {
            try
            {
                InitializeComponent();
                gridControlGastos.DataSource = Bus.Get_List_gastosxImport();
                ofrm.Event_frmImp_ParametrosGastosMant_FormClosing += new frmImp_ParametrosGastosMant.Delegate_frmImp_ParametrosGastosMant_FormClosing(ofrm_Event_frmImp_ParametrosGastosMant_FormClosing);
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Mostrar(Info.General.Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_Info == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (_Info.ga_estado == "I")
                    MessageBox.Show("No se pueden modificar registros inactivos", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    ofrm = new frmImp_ParametrosGastosMant();
                    ofrm.Event_frmImp_ParametrosGastosMant_FormClosing += new frmImp_ParametrosGastosMant.Delegate_frmImp_ParametrosGastosMant_FormClosing(ofrm_Event_frmImp_ParametrosGastosMant_FormClosing);
                    ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                    ofrm.MdiParent = this.MdiParent;
                    ofrm._SetInfo = _Info;
                    ofrm.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                ofrm = new frmImp_ParametrosGastosMant();
                ofrm.Event_frmImp_ParametrosGastosMant_FormClosing += new frmImp_ParametrosGastosMant.Delegate_frmImp_ParametrosGastosMant_FormClosing(ofrm_Event_frmImp_ParametrosGastosMant_FormClosing);
                ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.consultar);
                ofrm.MdiParent = this.MdiParent;
                ofrm._SetInfo = _Info;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Bus.Validar(_Info))
                {
                    if (Bus.AnularDB(_Info))
                    {
                        MessageBox.Show("Anulado Con Exito el registro #: " + _Info.IdGastoImp);
                        gridControlGastos.DataSource = Bus.Get_List_gastosxImport();
                    }
                }
                else
                {
                    MessageBox.Show("No se Puede Anular el registro por que tiene movimientos activos");

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        void ofrm_Event_frmImp_ParametrosGastosMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                gridControlGastos.DataSource = Bus.Get_List_gastosxImport();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }

        public void Mostrar(Info.General.Cl_Enumeradores.eTipo_action Var)
        {
            try
            {
                ofrm = new frmImp_ParametrosGastosMant();
                ofrm.Event_frmImp_ParametrosGastosMant_FormClosing += new frmImp_ParametrosGastosMant.Delegate_frmImp_ParametrosGastosMant_FormClosing(ofrm_Event_frmImp_ParametrosGastosMant_FormClosing);
                ofrm.setAccion(Var);
                ofrm._SetInfo = _Info;
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }


        imp_gastosxImport_Info _Info = new imp_gastosxImport_Info();
        private void gridViewGastos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _Info = (imp_gastosxImport_Info)gridViewGastos.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }



        private void gridViewGastos_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewGastos.GetRow(e.RowHandle) as imp_gastosxImport_Info;
                if (data == null)
                    return;

                if (data.ga_estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Tipo_Prestamo_Cons : Form
    {
        #region Declaracion de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Tipo_Prestamo_Info Info_Tprestamo = new ro_Tipo_Prestamo_Info();
        ro_Tipo_Prestamo_Bus Bus_Tprestamo = new ro_Tipo_Prestamo_Bus();
        private Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmRo_Tipo_Prestamo_Mant frm;
        #endregion
       
        public frmRo_Tipo_Prestamo_Cons()
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
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                llama_frm(Cl_Enumeradores.eTipo_action.grabar);

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
                if (Info_Tprestamo != null)
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                }
                else
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (Info_Tprestamo != null)
                {
                    llama_frm(Cl_Enumeradores.eTipo_action.consultar);
                }
                else
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region Codigo Antiguo de Anular
            //try
            //{
            //    // if (Info_Tprestamo.IdTipoPrestamo != null)
            //    if (Info_Tprestamo != null)
            //    {
            //        if (MessageBox.Show("¿Está seguro que desea anular el tipo de préstamo ID # : " + Info_Tprestamo.IdTipoPrestamo + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            if (Info_Tprestamo.tp_Estado == "A")
            //            {
            //                if (Bus_Tprestamo.AnularDB(Info_Tprestamo) == false)
            //                {
            //                    string msg = "Problemas al anular el registro # :" + Info_Tprestamo.IdTipoPrestamo + " " + Info_Tprestamo.tp_Descripcion;
            //                    MessageBox.Show(msg, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    return;
            //                }
            //                else
            //                {
            //                    string msg = "Se ha anulado exitosamente el registro # :" + Info_Tprestamo.IdTipoPrestamo + " " + Info_Tprestamo.tp_Descripcion;
            //                    MessageBox.Show(msg, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    CargarGrid();
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("El tipo de préstamo # : " + Info_Tprestamo.IdTipoPrestamo + "  ya se encuentra anulado  ", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }

            //        }
            //    }

            //    else
            //    {
            //        MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Log_Error_bus.Log_Error(ex.ToString());
            //    MessageBox.Show(ex.ToString());
            //}
            #endregion

            try
            {
                if (Info_Tprestamo != null)
                {
                    if (Info_Tprestamo.tp_Estado == "I")
                    {
                        MessageBox.Show("El Registro Seleccionado ya Esta Anulado", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {

                        llama_frm(Cl_Enumeradores.eTipo_action.Anular);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void CargarGrid()
        {
            try
            {
                this.gridCtrlTprestamo.DataSource = Bus_Tprestamo.ConsultaGeneral(param.IdEmpresa).ToList();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frm = new frmRo_Tipo_Prestamo_Mant();
                frm.event_frmRo_Tipo_Prestamo_Mant_FormClosing += new frmRo_Tipo_Prestamo_Mant.delegate_frmRo_Tipo_Prestamo_Mant_FormClosing(frm_event_frmRo_Tipo_Prestamo_Mant_FormClosing);
                //frm.MdiParent = this.MdiParent;
                frm._SetInfo = Info_Tprestamo;
                frm.set_Accion(Accion);
                //frm.Show();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void frm_event_frmRo_Tipo_Prestamo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_Tipo_Prestamo_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                 CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void gridViewTprestamo_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewTprestamo.GetRow(e.RowHandle) as ro_Tipo_Prestamo_Info;
                if (data == null)
                    return;

                if (data.tp_Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewTprestamo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info_Tprestamo = (ro_Tipo_Prestamo_Info)gridViewTprestamo.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
          
        }

        ///Sumary Modificación de Codigo
        ///Progra : Eliana Veliz
        ///21/10/2014
        ///11:00
    }
}

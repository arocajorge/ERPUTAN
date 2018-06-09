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

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_ProductoTipo_Consu : Form
    {
        frmIn_ProductoTipo_Mant frm = new frmIn_ProductoTipo_Mant();

        public FrmIn_ProductoTipo_Consu()
        {
            try
            {
                   InitializeComponent();
                   ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                   ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                   ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                   ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                info = (in_ProductoTipo_Info)gridView.GetFocusedRow();
                if (info != null)
                {
                    
                        frm = new frmIn_ProductoTipo_Mant(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.Text = frm.Text + "***ACTUALIZAR REGISTRO***";
                        frm._SetInfo = info;
                        frm.Show();
                        frm.MdiParent = this.MdiParent;
                        frm.event_frmIn_ProductoTipo_Mant_FormClosing += frm_event_frmIn_ProductoTipo_Mant_FormClosing;
                    
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
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
                //if ((gridView.GetFocusedRow()) == null)
                //{
                //    MessageBox.Show("Seleccione una fila para realizar la respectiva actualización del reguistro", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}

                //info = gridView.GetFocusedRow() as in_ProductoTipo_Info;
                //if (info != null)
                //{

                //    if (MessageBox.Show("¿Está seguro que desea anular Tipo de Producto: " + info.tp_descripcion + " ?", "Anulación de Tipo de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //    {
                //        if (info.Estado == true)
                //        {
                //            string msg = "";
                //            in_ProductoTipo_Bus bus_prod_tipo = new in_ProductoTipo_Bus();
                //            info.IdUsuarioUltAnu = param.IdUsuario;
                //            info.IdUsuarioUltMod = param.IdUsuario;
                //            info.Fecha_UltAnu = DateTime.Now;
                //            info.Fecha_UltMod = DateTime.Now;
                //            bus_prod_tipo.EliminarDB(info, ref msg);
                //            MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            load_ProductoTipo();
                //        }
                //        else
                //        {
                //            MessageBox.Show("No se pudo anular el Tipo de Producto: " + info.tp_descripcion + " debido a que ya se encuentra anulado", "Anulación de Tipo de Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        }
                //    }
                //}

                try
                {
                    info = (in_ProductoTipo_Info)gridView.GetFocusedRow();
                    if (info != null)
                    {
                        if (info.Estado == "I")
                        {
                            MessageBox.Show("El registro ya fue Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        }
                        else
                        {
                            frm = new frmIn_ProductoTipo_Mant(Cl_Enumeradores.eTipo_action.Anular);
                            frm.Text = frm.Text + "***ANULAR REGISTRO***";
                            frm._SetInfo = info;
                            frm.Show();
                            frm.MdiParent = this.MdiParent;
                            frm.event_frmIn_ProductoTipo_Mant_FormClosing += frm_event_frmIn_ProductoTipo_Mant_FormClosing;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un Registro a Anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



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
                if (this.gridView.GetFocusedRow() == null)
                {
                    MessageBox.Show("Seleccione una fila para realizar la respectiva actualización del reguistro", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                info = gridView.GetFocusedRow() as in_ProductoTipo_Info;
                if (info != null)
                {
                    frm = new frmIn_ProductoTipo_Mant(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    frm._SetInfo = info;
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_frmIn_ProductoTipo_Mant_FormClosing += frm_event_frmIn_ProductoTipo_Mant_FormClosing;
                }


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
                frm = new frmIn_ProductoTipo_Mant(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                frm.Show();
                frm.MdiParent = this.MdiParent;
                frm.event_frmIn_ProductoTipo_Mant_FormClosing += frm_event_frmIn_ProductoTipo_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmIn_ProductoTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_ProductoTipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        List<in_ProductoTipo_Info> lm = new List<in_ProductoTipo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_ProductoTipo_Info info = new in_ProductoTipo_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        private void load_ProductoTipo()
        {
            try
            {
                in_ProductoTipo_Bus bus_producto_tipo = new in_ProductoTipo_Bus();
                lm = bus_producto_tipo.Obtener_ProductosTipos(param.IdEmpresa);
               gridControl.DataSource = lm;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FrmIn_ProductoTipo_General_Load(object sender, EventArgs e)
        {
            try
            {
               load_ProductoTipo();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView.GetRow(e.RowHandle) as in_ProductoTipo_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       

    }
}

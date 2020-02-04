using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using DevExpress.XtraEditors;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Ventas_Telefonicas_consu : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        fa_venta_telefonica_Bus BusVtaFono = new fa_venta_telefonica_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_venta_telefonica_Info Info = new fa_venta_telefonica_Info();
        List<fa_venta_telefonica_Info> nn = new List<fa_venta_telefonica_Info>();
        tb_Sucursal_Bus busSucu = new tb_Sucursal_Bus();
        frmFa_Ventas_Telefonicas_Mant frm1 = new frmFa_Ventas_Telefonicas_Mant();
        fa_Cliente_Bus busClien = new fa_Cliente_Bus();



        #endregion
        
        public frmFa_Ventas_Telefonicas_consu()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //showFormulario(Cl_Enumeradores.eTipo_action.borrar);
                fa_venta_telefonica_Info i = gridViewVentaFono.GetFocusedRow() as fa_venta_telefonica_Info;
               
                if (i == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (i.Estado == "I")
                    MessageBox.Show("No se pueden anular registros inactivos", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    frm1 = new frmFa_Ventas_Telefonicas_Mant(Cl_Enumeradores.eTipo_action.Anular);
                    frm1.Event_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing += new frmFa_Ventas_Telefonicas_Mant.delegate_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing(event_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing);
                    frm1.Text = frm1.Text + " ***ANULAR REGISTRO***";
                    frm1.setInfo(i);
                    frm1.Show();
                }



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //showFormulario(Cl_Enumeradores.eTipo_action.actualizar);
                fa_venta_telefonica_Info i = gridViewVentaFono.GetFocusedRow() as fa_venta_telefonica_Info;
               
                if (i == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (i.Estado == "I")
                    MessageBox.Show("No se pueden modificar registros inactivos", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frm1 = new frmFa_Ventas_Telefonicas_Mant(Cl_Enumeradores.eTipo_action.actualizar);
                    frm1.Event_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing += new frmFa_Ventas_Telefonicas_Mant.delegate_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing(event_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing);
                    frm1.Text = frm1.Text + " ***ACTUALIZAR REGISTRO***";
                    frm1.setInfo(i);
                    frm1.Show();
                }




            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
               // showFormulario(Cl_Enumeradores.eTipo_action.consultar);

                fa_venta_telefonica_Info i = gridViewVentaFono.GetFocusedRow() as fa_venta_telefonica_Info;

                if (i == null)
                    MessageBox.Show("Seleccione un registro", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    frm1 = new frmFa_Ventas_Telefonicas_Mant(Cl_Enumeradores.eTipo_action.consultar);
                    frm1.Event_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing += new frmFa_Ventas_Telefonicas_Mant.delegate_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing(event_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing);
                    frm1.Text = frm1.Text + " ***CONSULTAR REGISTRO***";
                    frm1.setInfo(i);
                    frm1.Show();
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta) < Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_desde))
                {
                    //dtpFechaFin.EditValue = DateTime.Now;
                    MessageBox.Show("La fecha de fin no puede ser menor que que la fecha de inicio", "Sistema");
                }
                else
                {
                    ActualizarGrid();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
   
        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // showFormulario(Cl_Enumeradores.eTipo_action.grabar);
            
            try
            {                       
                frm1 = new frmFa_Ventas_Telefonicas_Mant(Cl_Enumeradores.eTipo_action.grabar);
                frm1.Event_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing += new frmFa_Ventas_Telefonicas_Mant.delegate_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing(event_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing);
                frm1.Text = frm1.Text + " ***NUEVO REGISTRO***";
                frm1.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        private void frmFa_Ventas_Telefonicas_Load(object sender, EventArgs e)
        {
            try
            {
                
                repositoryCmbSucursal.DataSource = busSucu.Get_List_Sucursal(param.IdEmpresa);
                repositoryCmbCliente.DataSource = busClien.Get_List_Clientes(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void event_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ActualizarGrid();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ActualizarGrid()
        {
            try
            {
                if (Convert.ToInt32(ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal) == 0)
                {
                    gridControlVentaFono.DataSource =
                    BusVtaFono.Get_List_venta_telefonica(param.IdEmpresa);
                }
                else
                {
                    DateTime inicio = Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_desde).Date;
                    DateTime Fin = Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta).Date;
                    gridControlVentaFono.DataSource =
                        BusVtaFono.Get_List_venta_telefonica(param.IdEmpresa, Convert.ToInt32(ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal), inicio, Fin);
                    
                }
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
                ActualizarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewVentaFono_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e){}

        private void cmbSucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gridControlVentaFono.DataSource = null;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }

        private void gridViewVentaFono_RowCellStyle_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
           
        }

        private void gridViewVentaFono_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewVentaFono.GetRow(e.RowHandle) as fa_venta_telefonica_Info;
                if (data.Estado == "I")
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        //private void showFormulario(Cl_Enumeradores.eTipo_action accion)
        //{
        //    try
        //    {

        //        //if (accion != Cl_Enumeradores.eTipo_action.grabar)
        //        //{
        //        //    fa_venta_telefonica_Info i = gridViewVentaFono.GetFocusedRow() as fa_venta_telefonica_Info;
        //        //frm.Event_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing += new frmFa_Ventas_Telefonicas_Mant.delegate_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing(event_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing);
        //        //frm.Show();

        //        //    

        //        //}

        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }

        //}
    }
}

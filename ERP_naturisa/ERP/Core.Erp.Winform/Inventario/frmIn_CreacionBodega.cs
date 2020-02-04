using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_CreacionBodega : Form
    {

        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Sucursal_Bus _Sucursal_B = new tb_Sucursal_Bus();
        tb_Bodega_Bus _Bodegas_b = new Business.General.tb_Bodega_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<tb_Sucursal_Info> Sucursales;
        tb_Bodega_Info Bodega = new tb_Bodega_Info();
        #endregion
        
        public FrmIn_CreacionBodega()
        {
            try
            {
                InitializeComponent();
                CargarSucursales();
                lbxSucursales.SelectedIndex = 0;
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
                frmFa_Bodega ofrm = new frmFa_Bodega();
                ofrm.Event_frmFA_Bodega_FormClosing += new frmFa_Bodega.delegate_frmFA_Bodega_FormClosing(ofrm_Event_frmFA_Bodega_FormClosing);
                ofrm.lbl_id_sucursal.Text = lbxSucursales.SelectedValue.ToString();
                ofrm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.grabar);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
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
                frmFa_Bodega ofrm = new frmFa_Bodega();                
                ofrm.lbl_id_sucursal.Text = lbxSucursales.SelectedValue.ToString();
                ofrm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                Bodega = gridViewBodega.GetFocusedRow() as tb_Bodega_Info;
                ofrm.set_Bodega(Bodega);

                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
                ofrm.Event_frmFA_Bodega_FormClosing += new frmFa_Bodega.delegate_frmFA_Bodega_FormClosing(ofrm_Event_frmFA_Bodega_FormClosing);
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
                frmFa_Bodega ofrm = new frmFa_Bodega();
                ofrm.Event_frmFA_Bodega_FormClosing += new frmFa_Bodega.delegate_frmFA_Bodega_FormClosing(ofrm_Event_frmFA_Bodega_FormClosing);
                ofrm.lbl_id_sucursal.Text = lbxSucursales.SelectedValue.ToString();
                ofrm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.consultar);
                Bodega = gridViewBodega.GetFocusedRow() as tb_Bodega_Info;
                ofrm.set_Bodega(Bodega);
                ofrm.MdiParent = this.MdiParent;
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
                frmFa_Bodega ofrm = new frmFa_Bodega();
                ofrm.Event_frmFA_Bodega_FormClosing += new frmFa_Bodega.delegate_frmFA_Bodega_FormClosing(ofrm_Event_frmFA_Bodega_FormClosing);
                ofrm.lbl_id_sucursal.Text = lbxSucursales.SelectedValue.ToString();
                ofrm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.Anular);
                Bodega = gridViewBodega.GetFocusedRow() as tb_Bodega_Info;
                ofrm.set_Bodega(Bodega);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void CargarSucursales() 
        {
            try
            {

                var Sucursal = _Sucursal_B.Get_List_Sucursal(param.IdEmpresa);
                Sucursales = _Sucursal_B.Get_List_Sucursal(param.IdEmpresa);


               Sucursal.ForEach(var => var.Su_Descripcion = "[" + var.Su_CodigoEstablecimiento + "]- " + var.Su_Descripcion);
           
                lbxSucursales.DataSource = Sucursal;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void gridViewBodega_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Bodega = (tb_Bodega_Info)gridViewBodega.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }


        }

        private void lbxSucursales_SelectedIndexChanged(object sender, EventArgs e)
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

        void CargarGrid() 
        {
            try
            {
                if (((tb_Sucursal_Info)(lbxSucursales.SelectedItem)).Estado == false)
                {
                    ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = false;
                    ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = false;
                }
                else 
                {
                    ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
                    ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
                }

                gridControlBodega.DataSource = _Bodegas_b.Get_List_Bodega(param.IdEmpresa, Convert.ToInt32(lbxSucursales.SelectedValue));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void lbxSucursales_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {

                if (e.Button == MouseButtons.Right)
                {
                    Point p = new Point(e.X, e.Y);                   
                    menuSucursal.Show(lbxSucursales, p);                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

       
        void ofr_event_frmFA_Sucursal_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              CargarSucursales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }     
        }

        void ofrm_Event_frmFA_Bodega_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmFa_Sucursal_Mant ofr = new frmFa_Sucursal_Mant();
                ofr.event_frmFA_Sucursal_Mant_FormClosing += new frmFa_Sucursal_Mant.delegate_frmFA_Sucursal_Mant_FormClosing(ofr_event_frmFA_Sucursal_Mant_FormClosing);
                ofr.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                ofr.MdiParent = this.MdiParent;
                ofr.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                frmFa_Sucursal_Mant ofr = new frmFa_Sucursal_Mant();
                ofr.event_frmFA_Sucursal_Mant_FormClosing += new frmFa_Sucursal_Mant.delegate_frmFA_Sucursal_Mant_FormClosing(ofr_event_frmFA_Sucursal_Mant_FormClosing);
                ofr.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                ofr.set_Sucursal(Sucursales.First(var => var.IdSucursal == Convert.ToInt32(lbxSucursales.SelectedValue)));
                ofr.MdiParent = this.MdiParent;
                ofr.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmIn_CreacionBodega_Load(object sender, EventArgs e)
        {

        }
    }
}

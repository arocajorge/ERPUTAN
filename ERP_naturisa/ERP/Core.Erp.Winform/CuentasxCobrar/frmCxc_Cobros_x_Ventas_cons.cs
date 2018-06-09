using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using System.Threading;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_Cobros_x_Ventas_cons : Form
    {
        public frmCxc_Cobros_x_Ventas_cons()
        {
            try
            {
              InitializeComponent();
              ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.btnNuevo.Caption = "Nuevo Cobro";
              ucGe_Menu_Mantenimiento_x_usuario.btnNuevoChq.Caption = "Ingreso/Retencion";

                

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
                LlamaForm(Cl_Enumeradores.eTipo_action.grabar);
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
                LlamaForm(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {               
                cargar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        vwcxc_cartera_x_cobrar_Bus cartera_B = new vwcxc_cartera_x_cobrar_Bus();

        private void frmcxc_cobrosXventas_Load(object sender, EventArgs e)
        {
            try 
	        {	              
                cargar();
	        }
	        catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
        }

      
        List<vwcxc_cartera_x_cobrar_Info> lst = new List<vwcxc_cartera_x_cobrar_Info>();
        
        private void cargar()
        {
            try
            {
                lst = cartera_B.Get_List_cartera_x_cobrar(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal                    
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);

                gridControl_fac.DataSource = lst;
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        frmCxc_Cobros_x_Ventas_Mant frm;
        vwcxc_cartera_x_cobrar_Info cartera_I = new vwcxc_cartera_x_cobrar_Info();
        
       private void LlamaForm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                if (cartera_I != null)
                {
                    if (cartera_I.vt_NunDocumento != null)
                    {
                        frm = new frmCxc_Cobros_x_Ventas_Mant();
                        frm.event_frmcxc_CobrosXFactura_FormClosing += new frmCxc_Cobros_x_Ventas_Mant.delegate_frmcxc_CobrosXFactura_FormClosing(frm_event_frmcxc_CobrosXFactura_FormClosing);
                        frm.MdiParent = this.MdiParent;
                        frm.set(cartera_I.IdEmpresa, cartera_I.IdSucursal, cartera_I.IdBodega, cartera_I.vt_tipoDoc, cartera_I.IdComprobante, Accion);
                        switch (Accion)
                        {
                            case Cl_Enumeradores.eTipo_action.grabar:
                                if (cartera_I.Saldo > 0)
                                    frm.Show();
                                else
                                    MessageBox.Show("El Documento seleccionado Debe Tener Saldo a Cobrar", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case Cl_Enumeradores.eTipo_action.consultar:
                                frm.Show();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Antes de continuar seleccione un Documento a Cobrar", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmcxc_CobrosXFactura_FormClosing(object sender, FormClosingEventArgs e)
       {
           try
           {
              cargar();
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

        }

        private void gridView_fac_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                cartera_I = (vwcxc_cartera_x_cobrar_Info)gridView_fac.GetFocusedRow();
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dtp_desde_Enter(object sender, EventArgs e)
        {
            try
            {
             cargar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtp_hasta_Enter(object sender, EventArgs e)
        {
            try
            {
                cargar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevoChq_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (cartera_I.vt_NunDocumento != null)
                {

                    frmCxc_CobrosRetenciones frm = new frmCxc_CobrosRetenciones();
                    if (cartera_I.vt_tipoDoc == "FACT")
                    {
                        fa_factura_Info Infofac = new fa_factura_Info();
                        fa_factura_Bus busFac = new fa_factura_Bus();
                        Infofac = busFac.Get_Info_factura(cartera_I.IdEmpresa, cartera_I.IdSucursal, cartera_I.IdBodega, cartera_I.IdComprobante);
                        frm.setInfo(Infofac, null, cartera_I.pe_nombreCompleto, Convert.ToInt32(Infofac.IdCaja), cartera_I.vt_tipoDoc);
                    }
                    else
                    {
                        fa_notaCreDeb_Info InfoND = new fa_notaCreDeb_Info();
                        fa_notaCredDeb_Bus busND = new fa_notaCredDeb_Bus();
                        InfoND = busND.Get_Info_notaCreDeb_x_ND(cartera_I.IdEmpresa, cartera_I.IdSucursal, cartera_I.IdBodega, cartera_I.IdComprobante);
                        frm.setInfo(null, InfoND, cartera_I.pe_nombreCompleto, Convert.ToInt32(InfoND.IdCaja), cartera_I.vt_tipoDoc);
                    }                    

                    frm.Accion = Cl_Enumeradores.eTipo_action.grabar;
                    

                    if (cartera_I.Saldo > 0)
                    {
                        frm.ShowDialog();
                        cargar();
                    }
                    else
                        MessageBox.Show("El Documento seleccionado Debe Tener Saldo a Cobrar", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Antes de continuar seleccione un Documento a Cobrar", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

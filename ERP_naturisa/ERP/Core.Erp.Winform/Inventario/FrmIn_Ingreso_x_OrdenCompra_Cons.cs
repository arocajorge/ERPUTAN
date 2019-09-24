using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.General;
using Core.Erp.Business.General;

using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;

using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Ingreso_x_OrdenCompra_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;   
        in_Ing_Egr_Inven_Bus bus_IngEgr ;      
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_Ing_Egr_Inven_Info info ;    
        FrmIn_Ingreso_x_OrdenCompra_Mant frm ;
        com_parametro_Info info_param_compras = new com_parametro_Info();
        com_parametro_Bus bus_param_compras = new com_parametro_Bus();
        FrmIn_Ingreso_varios_Mant frm_ing_varios;

        int IdSucursalIni = 0;
        int IdSucursalFin = 0;
        int IdBodegaIni = 0;
        int IdBodegaFin = 0;
        DateTime fecha_desde;
        DateTime fecha_hasta;
      
        public FrmIn_Ingreso_x_OrdenCompra_Cons()
        {
            InitializeComponent();

            
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick;            
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick;            
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click;
        }

        private void cargagrid()
        {
            try
            {         
                fecha_desde = ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde;
                fecha_hasta = ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta;
                if (IdSucursalIni == 0 && IdBodegaIni ==0)
                {
                    IdSucursalIni = 1;
                    IdSucursalFin = 9999;
                    IdBodegaIni = 1;
                    IdBodegaFin = 9999;
                }    
              
                List<in_Ing_Egr_Inven_Info> LstIngEge = new List<in_Ing_Egr_Inven_Info>();
                bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                LstIngEge = bus_IngEgr.Get_List_Ing_Egr_Inven(param.IdEmpresa, IdSucursalIni,IdSucursalFin,IdBodegaIni,IdBodegaFin,fecha_desde, fecha_hasta,info_param_compras.IdMovi_inven_tipo_OC);                
                gridControlConsulta.DataSource = LstIngEge;
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;
                if (IdSucursalIni == 0)
                {                  
                    IdSucursalIni = 1;
                    IdSucursalFin = 9999;
                    IdBodegaIni = 1;
                    IdBodegaFin = 9999;
                }
                else
                {                    
                    IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;
                    IdSucursalFin = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal == 0 ? 9999 : ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;

                    IdBodegaIni = ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega == 0 ? 1 : ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega;
                    IdBodegaFin = ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega == 0 ? 9999 : ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega;
                } 
                 * */
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FrmIn_Ingreso_x_OrdenCompra_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                             
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewConsulta.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Close();   
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Ingreso_x_OrdenCompra_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                info_param_compras = bus_param_compras.Get_Info_parametro(param.IdEmpresa);

                IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;
                if (IdSucursalIni == 0)
                {
                    IdSucursalIni = 1;
                    IdSucursalFin = 9999;
                    IdBodegaIni = 1;
                    IdBodegaFin = 9999;
                }
                else
                {
                    IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;
                    IdSucursalFin = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;
                    IdBodegaIni = ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega;
                    IdBodegaFin = ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega;
                }            
               
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewConsulta_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                info = new in_Ing_Egr_Inven_Info();
                info = (in_Ing_Egr_Inven_Info)gridViewConsulta.GetFocusedRow();
            }
            catch (Exception ex)
            {
               Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewConsulta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewConsulta.GetRow(e.RowHandle) as in_Ing_Egr_Inven_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                {
                    e.Appearance.ForeColor = Color.Red;
                }
                else
                {
                    if (data.IdEstadoAproba == "APRO")
                        e.Appearance.ForeColor = Color.Blue;

                }
            }

            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_Load(object sender, EventArgs e)
        {
           
        }

        private void Preparar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {

            try
            {
                info = new in_Ing_Egr_Inven_Info();

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    info = (in_Ing_Egr_Inven_Info)gridViewConsulta.GetFocusedRow();

                    if (info == null)
                    {
                        MessageBox.Show("Seleccione un Registro a Mostrar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (info.Estado == "I")
                    {
                        MessageBox.Show("El registro ya se encuentra anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (info.IdEstadoAproba == "APRO" && Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        MessageBox.Show("No se puede anular el registro porque se encuentra aprobado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (Accion == Cl_Enumeradores.eTipo_action.Anular && !string.IsNullOrEmpty(info.co_factura))
                    {
                        MessageBox.Show("No se puede anular el registro porque tiene facturas asociadas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (Accion == Cl_Enumeradores.eTipo_action.actualizar && (info.co_factura != null || info.IdEstadoAproba == "APRO"))
                    {
                        Accion = Cl_Enumeradores.eTipo_action.actualizar_proceso_cerrado;
                    }
                    frm_ing_varios = new FrmIn_Ingreso_varios_Mant();
                    frm_ing_varios.MdiParent = this.MdiParent;
                    frm_ing_varios.event_FrmIn_Ingreso_varios_Mant_FormClosing += frm_ing_varios_event_FrmIn_Ingreso_varios_Mant_FormClosing;

                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            frm_ing_varios.Text = frm_ing_varios.Text + " ***MODIFICAR REGISTRO***";
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            if (info != null)
                            {
                                if (info.Estado == "I")
                                { MessageBox.Show("El registro ya se encuentra Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                                else
                                {
                                    frm_ing_varios.Text = frm_ing_varios.Text + "***ANULAR REGISTRO***";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Seleccione un Registro a Anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                            }
                            break;
                        case Cl_Enumeradores.eTipo_action.consultar:
                            frm_ing_varios.Text = frm_ing_varios.Text + "***CONSULTAR REGISTRO***";
                            break;
                        default:
                            break;
                    }

                    frm_ing_varios.set_Accion(Accion);
                    frm_ing_varios.setInfo(info);
                    frm_ing_varios.Show();
                }
                else
                {
                    frm = new FrmIn_Ingreso_x_OrdenCompra_Mant();
                    frm.SETINFO_ = info;
                    frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                    frm.set_Accion(Accion); frm.MdiParent = this.MdiParent;
                    frm.Show();
                    frm.event_FrmIn_Ingreso_x_OrdenCompra_Mant_FormClosing += frm_event_FrmIn_Ingreso_x_OrdenCompra_Mant_FormClosing;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void frm_ing_varios_event_FrmIn_Ingreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

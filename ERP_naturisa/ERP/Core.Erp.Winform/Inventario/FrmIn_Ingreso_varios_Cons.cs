using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Ingreso_varios_Cons : Form
    {
        FrmIn_Ingreso_varios_Cons_Handler Handler = new FrmIn_Ingreso_varios_Cons_Handler();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        #region Variables y atributos

        in_Ing_Egr_Inven_Bus bus_IngEgr;
        in_Ing_Egr_Inven_Info Info;
        FrmIn_Ingreso_varios_Mant frm;

        int IdSucursalIni = 0;
        int IdSucursalFin = 0;
        int IdBodegaIni = 0;
        int IdBodegaFin = 0;
        DateTime fecha_desde;
        DateTime fecha_hasta;
        #endregion

        public FrmIn_Ingreso_varios_Cons()
        {
            InitializeComponent();
        }

        private void FrmIn_Ingreso_varios_Cons_Load(object sender, EventArgs e)
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

        public void cargagrid()
        {
            try
            {
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
                    IdBodegaIni = ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega == 0 ? 1 : ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega;
                    IdBodegaFin = ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega == 0 ? 9999 : ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega;
                }

                fecha_desde = ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde;
                fecha_hasta = ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta;

                List<in_Ing_Egr_Inven_Info> LstIngEgr = new List<in_Ing_Egr_Inven_Info>();
                bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                LstIngEgr = bus_IngEgr.Get_List_Ing_Egr_Inven(param.IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, fecha_desde, fecha_hasta, "+");
                gridControlConsulta.DataSource = LstIngEgr.OrderByDescending(x => x.IdNumMovi);
                 
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Preparar_Formulario(Cl_Enumeradores.eTipo_action Accion)
        {

            try
            {
                Info = new in_Ing_Egr_Inven_Info();

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    Info = (in_Ing_Egr_Inven_Info)gridViewConsulta.GetFocusedRow();
                }


                if (Info == null)
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Info.Estado == "I")
                {
                    MessageBox.Show("El registro ya se encuentra anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Info.Estado == "APRO" && Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    MessageBox.Show("No se puede anular el registro porque se encuentra aprobado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (Accion == Cl_Enumeradores.eTipo_action.actualizar && (Info.co_factura != null || Info.IdEstadoAproba == "APRO"))
                {
                    Accion = Cl_Enumeradores.eTipo_action.actualizar_proceso_cerrado;
                }

                frm = new FrmIn_Ingreso_varios_Mant();
                frm.MdiParent = this.MdiParent;
                frm.event_FrmIn_Ingreso_varios_Mant_FormClosing += frm_event_FrmIn_Ingreso_varios_Mant_FormClosing;
                frm.set_Accion(Accion);
                frm.setInfo(Info);



                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        frm.Text = frm.Text + " ***MODIFICAR REGISTRO***";
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        if (Info != null)
                        {
                            if (Info.Estado == "I")
                            { MessageBox.Show("El registro ya se encuentra Anulado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }
                            else
                            {
                                frm.Text = frm.Text + "***ANULAR REGISTRO***";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un Registro a Anular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                        }

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                        break;
                    default:
                        break;
                }


                frm.Show();



            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void frm_event_FrmIn_Ingreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
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

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
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

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Info = (in_Ing_Egr_Inven_Info)gridViewConsulta.GetFocusedRow();
                if (Info == null) return;
                if (Info.Estado == "I") { MessageBox.Show("El registro se encuentra anulado y no se puede modificar"); return; }
                
                Preparar_Formulario(Cl_Enumeradores.eTipo_action.actualizar);

            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        public void gridViewConsulta_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info = new in_Ing_Egr_Inven_Info();
                Info = (in_Ing_Egr_Inven_Info)gridViewConsulta.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void gridViewConsulta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewConsulta.GetRow(e.RowHandle) as in_Ing_Egr_Inven_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
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
    }
}

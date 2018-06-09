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

using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public class FrmIn_Ingreso_varios_Cons_Handler
    {
        public FrmIn_Ingreso_varios_Cons_Handler()
        {
        }

        #region Controles
        public Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario1;
        public Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        public System.Windows.Forms.Panel panel1;
        public DevExpress.XtraGrid.GridControl gridControlConsulta;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewConsulta;
        public Form FrmMDIParent;
        #endregion

        #region Variables y atributos
            tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
            cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
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


        public void cargagrid()
        {
            try
            {
                fecha_desde = ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde;
                fecha_hasta = ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta;

                List<in_Ing_Egr_Inven_Info> LstIngEgr = new List<in_Ing_Egr_Inven_Info>();
                bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                LstIngEgr = bus_IngEgr.Get_List_Ing_Egr_Inven(param.IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, fecha_desde, fecha_hasta,"+");
                gridControlConsulta.DataSource = LstIngEgr.OrderByDescending(x => x.IdNumMovi);

            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public void frm_event_FrmIn_Ingreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                IdSucursalIni = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;
                IdSucursalFin = ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal;
                IdBodegaIni = ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega;
                IdBodegaFin = ucGe_Menu_Mantenimiento_x_usuario1.getIdBodega;

                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FrmIn_Ingreso_varios_Cons_Load(object sender, EventArgs e)
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
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                    return;
                }


                frm = new FrmIn_Ingreso_varios_Mant();
                frm.MdiParent = this.FrmMDIParent;
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
    }
}

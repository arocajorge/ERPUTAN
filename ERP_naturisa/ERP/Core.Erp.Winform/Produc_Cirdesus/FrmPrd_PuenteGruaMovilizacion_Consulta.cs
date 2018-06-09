using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Winform.Produc_Cirdesus;
using DevExpress.XtraPrinting;
//version 240620113 15:01
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_PuenteGruaMovilizacion_Consulta : Form
    {

        string msg = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_MovPteGrua_Info InfoMovPte = new prd_MovPteGrua_Info();
        prd_PuenteGruaMovimiento_Bus BusMovimientoPuenteGrua = new prd_PuenteGruaMovimiento_Bus();
        prd_Operador_Bus BusOperador = new prd_Operador_Bus();
        prd_PuenteGrua_Bus BusPuenteGrua = new prd_PuenteGrua_Bus();

        BindingList<prd_MovPteGrua_Info> ListaMovimientos = new BindingList<prd_MovPteGrua_Info>();

        List<prd_Operador_Info> ListadoOperadors = new List<prd_Operador_Info>();


        public FrmPrd_PuenteGruaMovilizacion_Consulta()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        #region "Eventos click de botones"

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
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
                FrmPrd_PuenteGruaMovilizacion_Mantenimiento frm = new FrmPrd_PuenteGruaMovilizacion_Mantenimiento();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;
                frm.GetIdMovimiento();
                frm.Show();
                frm.event_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing += frm_event_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing;
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
                if (InfoMovPte == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_PuenteGruaMovilizacion_Mantenimiento frm = new FrmPrd_PuenteGruaMovilizacion_Mantenimiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.Text = frm.Text + " ***MODIFICAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show();
                    frm.SetInfo(InfoMovPte);
                    frm.event_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing += frm_event_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //gridControlObra.ShowPrintPreview();
                string leftColumn = "Fecha: [Date Printed][Time Printed]";
                string middleColumn = "Página:[Page # of Pages #]";
                string rightColumn = "Usuario:" + param.IdUsuario;

                // Create a PageHeaderFooter object and initializing it with
                // the link's PageHeaderFooter.

                PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;

                // Clear the PageHeaderFooter's contents.
                phf.Header.Content.Clear();
                phf.Footer.Content.Clear();
                Font fte = new System.Drawing.Font("Tahoma", 8.5f, FontStyle.Bold, GraphicsUnit.Point);

                // Add custom information to the link's header.
                phf.Header.Font = fte;
                phf.Footer.Font = fte;
                phf.Header.Content.AddRange(new string[] { leftColumn, "", rightColumn, "hola" });
                phf.Header.LineAlignment = BrickAlignment.Center;
                phf.Footer.Content.AddRange(new string[] { "", "", middleColumn });
                phf.Footer.LineAlignment = BrickAlignment.Center;
                //printableComponentLink1.Component = null;
                printableComponentLink1.Component = gridControlMovilizacion;

                printableComponentLink1.ShowPreview();
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
                if (InfoMovPte == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_PuenteGruaMovilizacion_Mantenimiento frm = new FrmPrd_PuenteGruaMovilizacion_Mantenimiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                  //  frm.setCab(InfoMovPte);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show();


                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
       
        #endregion





        

        private prd_MovPteGrua_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (prd_MovPteGrua_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new prd_MovPteGrua_Info();
            }
        }

        void frm_event_FrmPrd_PuenteGruaMovilizacion_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               //CargaGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
 

        private void FrmPrd_PuenteGruaMovilizacion_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                  // CargaGrid();
                   CargarCombos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridViewMovilizacion_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
               InfoMovPte = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //try
            //{
            //    FrmPrd_PuenteGruaMantenimiento frm = new FrmPrd_PuenteGruaMantenimiento();
            //    frm.set_Acccion(Cl_Enumeradores.eTipo_action.grabar);
            //    frm.Text = frm.Text + " ***NUEVO REGISTRO***";
            //    frm.MdiParent = this.MdiParent;
            //    frm.Show();
            //    // frm.event_FrmPrd_ObraMantemiento_FormClosing += frm_event_FrmPrd_ObraMantemiento_FormClosing;
            //}
            //catch (Exception ex)
            //{
            //    Log_Error_bus.Log_Error(ex.ToString());
            //    MessageBox.Show(ex.InnerException.ToString());
            //}

        }

        public void CargarCombos()
        {

            try
            {
                List< prd_Operador_Info> ListaOperador = new List<prd_Operador_Info>();
                List<prd_PuenteGrua_Info> ListaPuenteGrua = new List<prd_PuenteGrua_Info>();


                ListadoOperadors.Add(BusOperador.ListadoOperadores().FirstOrDefault());

                ListaPuenteGrua.Add(BusPuenteGrua.ListadoPuenteGrua(param.IdEmpresa).FirstOrDefault());

              

                cmbPteGrua.Properties.DataSource=ListaPuenteGrua;

                cmbOperador.Properties.DataSource = ListadoOperadors;
                cmbOperador.EditValue = ListadoOperadors.FirstOrDefault().IdOperador;
                cmbPteGrua.EditValue = ListaPuenteGrua.FirstOrDefault().idPuenteGrua;

                
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarMovimientos();
        }

        public void BuscarMovimientos()
        {
            try
            {


               ListaMovimientos = new BindingList<prd_MovPteGrua_Info>(BusMovimientoPuenteGrua.ListadoMovimientos(Convert.ToInt32(cmbPteGrua.EditValue), Convert.ToInt32(cmbOperador.EditValue), Convert.ToInt32(cmbOperador.EditValue), dtPFechadesde.Value, dtPFechaHasta.Value, ref msg));
                gridControlMovilizacion.DataSource = ListaMovimientos;
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message);
            }    
        }
    }
}

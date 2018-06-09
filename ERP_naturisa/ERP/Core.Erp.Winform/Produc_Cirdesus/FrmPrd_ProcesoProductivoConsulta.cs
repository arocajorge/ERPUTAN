using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Microsoft.VisualBasic;
using Core.Erp.Info.Contabilidad;
using DevExpress.XtraPrinting;
//version 240620113 13:31
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_ProcesoProductivoConsulta : Form
    {
        public FrmPrd_ProcesoProductivoConsulta()
        {
            try
            {
                 InitializeComponent();
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnDuplicar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnDuplicar_ItemClick;
                 ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
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
                printableComponentLink1.Component = gridControlProcesoProductivo;

                printableComponentLink1.ShowPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnDuplicar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {


                if (this.gridViewModelo.RowCount == 0)
                {
                    MessageBox.Show("Seleccione una fila ", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                info = (prd_ProcesoProductivo_Info)gridViewModelo.GetFocusedRow();
                if (info != null)
                {

                    prd_EtapaProduccion_Bus BusEtapas = new prd_EtapaProduccion_Bus();
                    List<prd_EtapaProduccion_Info> ListEtapas = new List<prd_EtapaProduccion_Info>();
                    List<prd_EtapaProduccion_Info> lisTemporal = new List<prd_EtapaProduccion_Info>();
                    prd_ProcesoProductivo_Bus ProcesoProductivo_bus = new prd_ProcesoProductivo_Bus();
                    prd_ProcesoProductivo_Info infoDupl = new prd_ProcesoProductivo_Info();

                    string msg = "";
                    int idpp = 0;

                    infoDupl = info;
                    // necesario porque el infoDupl ocupa el mismo espacio en memoria que el info y necesito el id anterior
                    int idprocprodanterior = info.IdProcesoProductivo;

                    FrmPrd_Duplica Frm = new FrmPrd_Duplica();
                    Frm.nombrar(info.Nombre);
                    Frm.ShowDialog();
                    infoDupl.Nombre = Frm.descripcion;

                    if (Frm.duplicaSiNo == "S")
                    {

                        if (Frm.descripcion.Trim() != string.Empty)
                        {


                            if (ProcesoProductivo_bus.GrabarItem(infoDupl, ref idpp, ref msg))
                            {

                                infoDupl.IdProcesoProductivo = idpp;


                                string CodObra = Frm.CodOBra;

                                if (CodObra != string.Empty)
                                {
                                    prd_Obra_Info InfoObra = new prd_Obra_Info();
                                    InfoObra.IdEmpresa = param.IdEmpresa;
                                    InfoObra.CodObra = CodObra;
                                    ProcesoProductivo_bus.GrabarModelo_x_Obra(infoDupl, InfoObra);
                                }

                                //string IdCentroCosto = Frm.idcentrocosto;
                                //if (IdCentroCosto != string.Empty)
                                //{
                                //    ct_Centro_costo_Info InfoCC = new ct_Centro_costo_Info();
                                //    InfoCC.IdEmpresa = param.IdEmpresa;
                                //    InfoCC.IdCentroCosto = IdCentroCosto;
                                //    ProcesoProductivo_bus.GrabarModelo_x_CentroCosto(info, InfoCC);
                                //}
                            }



                            ListEtapas = BusEtapas.ObtenerListaEtapas(param.IdEmpresa, idprocprodanterior);

                            foreach (var item in ListEtapas)
                            {
                                item.IdProcesoProductivo = infoDupl.IdProcesoProductivo;
                                lisTemporal.Add(item);
                            }

                            //grabo la lista de etapas para el nuevo modelo duplicado
                            BusEtapas.GrabarListaEtapas(ListEtapas, param.IdEmpresa, infoDupl.IdProcesoProductivo, ref msg);


                            MessageBox.Show("Duplicado con éxito", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                        else
                            MessageBox.Show("No se grabó", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ListaModelos();
                    }
                }

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


                FrmPrd_ProcesoProductivoMantenimiento frm = new FrmPrd_ProcesoProductivoMantenimiento();
                frm.Set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.IdPP = Convert.ToInt32(this.gridViewModelo.RowCount + 1);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_FrmPrd_ProcesoProductivoMantenimiento_FormClosing += new FrmPrd_ProcesoProductivoMantenimiento.delegate_FrmPrd_ProcesoProductivoMantenimiento_FormClosing(frm_event_FrmPrd_ProcesoProductivoMantenimiento_FormClosing);



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
                if (this.gridViewModelo.SelectedRowsCount == 0)
                {
                    MessageBox.Show("Seleccione una fila para realizar la respectiva actualización del registro", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

                info = (prd_ProcesoProductivo_Info)gridViewModelo.GetFocusedRow();
                if (info.Estado == false )
                {
                    MessageBox.Show("No se puede modificar un registro anulado", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (info != null)
                {
                    FrmPrd_ProcesoProductivoMantenimiento frm = new FrmPrd_ProcesoProductivoMantenimiento();
                    frm.set_ProcesoProductivo(info);
                    frm.Set_Accion(Cl_Enumeradores.eTipo_action.actualizar); frm.MdiParent = this.MdiParent;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    frm.event_FrmPrd_ProcesoProductivoMantenimiento_FormClosing += new FrmPrd_ProcesoProductivoMantenimiento.delegate_FrmPrd_ProcesoProductivoMantenimiento_FormClosing(frm_event_FrmPrd_ProcesoProductivoMantenimiento_FormClosing);
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
                if (this.gridViewModelo.RowCount == 0)
                {
                    MessageBox.Show("Seleccione una fila ", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                info = (prd_ProcesoProductivo_Info)gridViewModelo.GetFocusedRow();
                if (info != null)
                {
                    FrmPrd_ProcesoProductivoMantenimiento frm = new FrmPrd_ProcesoProductivoMantenimiento();
                    frm.set_ProcesoProductivo(info);
                    frm.Set_Accion(Cl_Enumeradores.eTipo_action.consultar); frm.MdiParent = this.MdiParent;
                    frm.MdiParent = this.MdiParent; frm.Show();
                }
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
                if (this.gridViewModelo.RowCount == 0)
                {
                    MessageBox.Show("Seleccione una fila ", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                info = (prd_ProcesoProductivo_Info)gridViewModelo.GetFocusedRow();
                if (info != null)
                {
                    if (MessageBox.Show("¿Está seguro que desea anular  el Modelo de Producción: " + info.Nombre + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (info.Estado == true)
                        {
                            //string msg = "";
                            //prd_ProcesoProductivo_Bus bus_prodesoproductivo = new prd_ProcesoProductivo_Bus();
                            //bus_prodesoproductivo.AnularItem(info, ref msg);
                            //MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmPrd_ProcesoProductivoMantenimiento frm = new FrmPrd_ProcesoProductivoMantenimiento();
                            frm.set_ProcesoProductivo(info);
                            frm.Set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                            frm.MdiParent = this.MdiParent;
                            frm.Show();

                            ListaModelos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo anular el Modelo de Producción: " + info.Nombre + " debido a que ya se encuentra anulado", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                    MessageBox.Show("Por favor, seleccione un item a anular", "ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_ProcesoProductivo_Info info = new prd_ProcesoProductivo_Info();
        prd_ProcesoProductivo_Bus bus_proceso_productivo = new prd_ProcesoProductivo_Bus();


        private void FrmPrd_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                  ListaModelos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ListaModelos()
        {
            try
            {

                this.gridControlProcesoProductivo.DataSource = bus_proceso_productivo.ObtenerProcesProductivo(param.IdEmpresa);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frm_event_FrmPrd_ProcesoProductivoMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            ListaModelos();
        }

        void Frm_event_FrmPrd_Duplica_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                    ListaModelos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridViewModelo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewModelo.GetRow(e.RowHandle) as prd_ProcesoProductivo_Info;
                if (data == null)
                    return;
                if (data.Estado == false)
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


    }
}

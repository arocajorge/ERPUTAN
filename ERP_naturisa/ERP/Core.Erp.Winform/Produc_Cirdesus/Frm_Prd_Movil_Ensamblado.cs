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
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Business.Inventario ;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario_Cidersus ;
using Core.Erp.Info.Produc_Cirdesus;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class Frm_Prd_Movil_Ensamblado : Form
    {
        #region declaraciones de variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Dictionary<string, decimal> LstDicProd = new Dictionary<string, decimal>();
        tb_Bodega_Info _bodegaInfo = new tb_Bodega_Info();
        tb_Sucursal_Info _sucursalInfo = new tb_Sucursal_Info();
        prd_parametros_CusCidersus_Info paramCidersus = new prd_parametros_CusCidersus_Info();
        prd_parametros_CusCidersus_Bus Busparam = new prd_parametros_CusCidersus_Bus();
        tb_Bodega_Bus BusBod = new tb_Bodega_Bus();
        tb_Sucursal_Bus BusSuc = new tb_Sucursal_Bus();
        UCIn_Sucursal_Bodega UCSuc_Bod = new UCIn_Sucursal_Bodega();
        prd_Ensamblado_CusCider_Info Ensamblado = new prd_Ensamblado_CusCider_Info();
        prd_Ensamblado_CusCider_Bus BusEnsamblado = new prd_Ensamblado_CusCider_Bus();
        prd_OrdenTaller_Bus busOT = new prd_OrdenTaller_Bus();
        prd_OrdenTaller_Info OT = new prd_OrdenTaller_Info();
        prd_SubGrupoTrabajo_Info GT = new prd_SubGrupoTrabajo_Info();
        prd_SubGrupoTrabajo_Bus busGT = new prd_SubGrupoTrabajo_Bus();
        List<in_Producto_Info> LstProd = new List<in_Producto_Info>();
        in_producto_x_tb_bodega_Bus Bus_prodxbod = new in_producto_x_tb_bodega_Bus();
        in_movi_inve_Bus Bus_mv = new in_movi_inve_Bus();
        in_movi_inve_detalle_Bus Bus_mv_det = new in_movi_inve_detalle_Bus();
        in_movi_inve_detalle_x_Producto_CusCider_Bus Bus_mv_detXpro = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        in_Producto_Info Prod_Term = new in_Producto_Info();
        List<in_movi_inve_detalle_Info> Lst_mv_detalle_ing = new List<in_movi_inve_detalle_Info>();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> Lst_mv_detalleXprod_eg = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        List<in_movi_inve_detalle_Info> Lst_mv_detalle_eg = new List<in_movi_inve_detalle_Info>();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> Lst_mv_detalleXprod_ing = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        List<prd_Ensamblado_Det_CusCider_Info> DetalleEnsam = new List<prd_Ensamblado_Det_CusCider_Info>();
        prd_ensamblado_cusCider_x_in_movi_inven_Info infoTI = new prd_ensamblado_cusCider_x_in_movi_inven_Info();
        prd_ensamblado_cusCider_x_in_movi_inven_Bus busTI = new prd_ensamblado_cusCider_x_in_movi_inven_Bus();
        in_producto_Bus busprod = new in_producto_Bus();

        //variables de instancia
        Cl_Enumeradores.eTipo_action iAccion = new Cl_Enumeradores.eTipo_action(); cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        UCPrd_Obra UCObra = new UCPrd_Obra();
        #endregion

        public Frm_Prd_Movil_Ensamblado()
        {
            try
            {
                InitializeComponent();
                cargacontroles();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        private void Frm_Prd_Movil_Ensamblado_Load(object sender, EventArgs e)
        {
            try
            {
                     iAccion = Cl_Enumeradores.eTipo_action.grabar;
                    paramCidersus = Busparam.ObtenerObjeto(param.IdEmpresa);
                    _sucursalInfo.IdEmpresa = _bodegaInfo.IdEmpresa = param.IdEmpresa;
                    _sucursalInfo.IdSucursal = _bodegaInfo.IdSucursal = paramCidersus.IdSucursal_Produccion;
                    _bodegaInfo.IdBodega = paramCidersus.IdBodega_Produccion;

                    cargacontroles();
                    //cargacombos();

                    UCSuc_Bod.Event_cmb_bodega_SelectedIndexChanged += new UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectedIndexChanged(UCSuc_Bod_Event_cmb_bodega_SelectedIndexChanged);
                    UCSuc_Bod.Event_cmb_sucursal_SelectedIndexChanged += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectedIndexChanged(UCSuc_Bod_Event_cmb_sucursal_SelectedIndexChanged);
                    UCObra.Event_UCObra_SelectionChanged
                       += new UCPrd_Obra.delegadoUCObra_SelectionChanged(UCObra_Event_UCObra_SelectionChanged);
                    UCObra.Event_UCObra_Validating += new UCPrd_Obra.delegadoUCObra_Validating(UCObra_Event_UCObra_Validating);

                    Event_Frm_Prd_Movil_Ensamblado_FormClosing += Frm_Prd_Movil_Ensamblado_Event_Frm_Prd_Movil_Ensamblado_FormClosing;
                    gridCtrlEnsamblado.DataSource = BindLst;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            

        }

        void Frm_Prd_Movil_Ensamblado_Event_Frm_Prd_Movil_Ensamblado_FormClosing(object sender, FormClosingEventArgs e){}
        

        void UCObra_Event_UCObra_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (UCObra.get_item_info() == null)
                {
                    gridLkUOrdenTaller.EditValue = null;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }


        }

        void UCSuc_Bod_Event_cmb_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                getSucBod();
                //cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void UCSuc_Bod_Event_cmb_bodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                getSucBod();
                //cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void getSucBod()
        {

            try
            {
                _sucursalInfo = UCSuc_Bod.get_sucursal();
                _bodegaInfo = UCSuc_Bod.get_bodega();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message); 
            }
        }


        void UCObra_Event_UCObra_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                List<prd_OrdenTaller_Info> lstOt = new List<prd_OrdenTaller_Info>();
                lstOt = busOT.ObtenerListaOT_x_CentroCosto(param.IdEmpresa, UCObra.get_item());
                if (lstOt.Count > 0)
                {
                    gridLkUOrdenTaller.Properties.DataSource = lstOt;
                    //gridLkUOrdenTaller.SelectionStart = 1;
                }
                else
                {
                    gridLkUOrdenTaller.EditValue = "";
                }
                gridVwEnsamblado.SelectAll();
                gridVwEnsamblado.DeleteSelectedRows();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }

        public delegate void Delegate_Frm_Prd_Movil_Ensamblado_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_Frm_Prd_Movil_Ensamblado_FormClosing Event_Frm_Prd_Movil_Ensamblado_FormClosing;
        
        private void Frm_Prd_Movil_Ensamblado_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               Event_Frm_Prd_Movil_Ensamblado_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public void ObtenerIdBodegaSucursal()
        {
            try
            {
                _sucursalInfo = UCSuc_Bod.get_sucursal();
                _bodegaInfo = UCSuc_Bod.get_bodega();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void cargacontroles()
        {
            try
            {
                Font fte = new  System.Drawing.Font("Microsoft Sans Serif",6.5f);
                UCSuc_Bod.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
                UCSuc_Bod.cargar_sucursal(param.IdEmpresa);
                //UCSuc_Bod.cmb_sucursal.SelectedIndex = 0;
                UCSuc_Bod.Dock = DockStyle.Bottom;
                panelSucBod.Controls.Add(UCSuc_Bod);
                UCSuc_Bod.set_Idsucursal(_sucursalInfo.IdSucursal);
                UCSuc_Bod.set_Idbodega(_bodegaInfo.IdSucursal, _bodegaInfo.IdBodega);

                UCSuc_Bod.cmb_bodega.Size = new System.Drawing.Size(170, 18);
                UCSuc_Bod.cmb_sucursal.Size = new System.Drawing.Size(170, 18);
                UCSuc_Bod.label1.Text = "SUC:";
                UCSuc_Bod.lblBodega.Text = "BOD:";
                UCSuc_Bod.label1.Location = new Point(0, 8);
                UCSuc_Bod.lblBodega.Location = new Point(0, 30);
                UCSuc_Bod.label1.Font = fte;
                UCSuc_Bod.lblBodega.Font = fte;
                UCSuc_Bod.cmb_bodega.Font = fte;
                UCSuc_Bod.cmb_sucursal.Font = fte;
                //UCObra.UC_Obra.Font = fte;
                //UCObra.label.Font = fte;
                UCSuc_Bod.cmb_sucursal.Location = new Point(27, 5);
                UCSuc_Bod.cmb_bodega.Location = new Point(27, 27);
                UCObra.cargaCmb_Obra();
                panelObra.Controls.Add(UCObra);
                UCObra.Dock = DockStyle.Fill;
                //UCObra.UC_Obra.Size = new Size(170, 18);
                //UCObra.label.Text = "OB:";
                //UCObra.label.Location = new Point(0, 3);
                //UCObra.UC_Obra.Location = new Point(27,3);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }

        }

        void cargacombos()
        {
            try
            {

                List<prd_OrdenTaller_Info> lstOt = new List<prd_OrdenTaller_Info>();
                lstOt = busOT.ObtenerListaOT_x_CentroCosto(param.IdEmpresa, UCObra.get_item());
                gridLkUOrdenTaller.Properties.DataSource = lstOt;



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }


        }

        public void setCab(prd_Ensamblado_CusCider_Info Info)
        {
            try
            {
                Ensamblado = Info;
                _sucursalInfo.IdEmpresa = _bodegaInfo.IdEmpresa = Info.IdEmpresa;
                _sucursalInfo.IdSucursal = _bodegaInfo.IdSucursal = Info.IdSucursal;
                _bodegaInfo.IdBodega = Info.IdBodega;
                UCObra.set_item(Info.CodObra);
                UCSuc_Bod.set_Idsucursal(_sucursalInfo.IdSucursal);
                UCSuc_Bod.set_bodega(_bodegaInfo);
                OT = busOT.ObtenerUnaOT(param.IdEmpresa, Info.IdSucursal,
                    Info.IdOrdenTaller, Info.CodObra);
                gridLkUOrdenTaller.EditValue = OT.IdOrdenTaller;
                GT = busGT.OBtenerGT(param.IdEmpresa, Info.IdSucursal,
                    Info.IdGrupoTrabajo);
                gridLkUGrupoTrabajo.EditValue = GT.IdGrupoTrabajo;
                txtEnsamblado.Text = Convert.ToString(Info.IdEnsamblado);
                txtObservacion.Text = Info.Observacion;
                txtCodBarra.Text = Info.CodigoBarra;
                dtPfecha.Value = Info.FechaTransac;
                prd_Ensamblado_Det_CusCider_Bus busDetEns = new prd_Ensamblado_Det_CusCider_Bus();
                DetalleEnsam = busDetEns.ConsultaEnsamblado(Info.IdEmpresa,
                    Info.IdSucursal, Info.IdEnsamblado, ref msg);
                cargagrid(DetalleEnsam);

                List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info> LstMov = new List<vwIn_Movi_Inven_x_TI_CusCider_Cab_Info>();
                LstMov = Bus_mv_detXpro.ConsultaMovimienosxEnsamblado(Ensamblado.IdEnsamblado, Ensamblado.IdSucursal, Ensamblado.IdEmpresa);
                ////gridCtrlMov.DataSource = LstMov;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }


        }

        private void gridLkUOrdenTaller_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (gridLkUOrdenTaller.EditValue != null && gridLkUOrdenTaller.EditValue != "")
                {
                    List<prd_SubGrupoTrabajo_Info> lstGT = new List<prd_SubGrupoTrabajo_Info>();
                    OT = busOT.ObtenerUnaOT(param.IdEmpresa, _sucursalInfo.IdSucursal,
                        Convert.ToDecimal(gridLkUOrdenTaller.EditValue), UCObra.get_item());
                    lstGT = busGT.ObtenerGrupoTrabajoCab_x_OT(param.IdEmpresa, Convert.ToInt32(UCSuc_Bod.cmb_sucursal.EditValue), Convert.ToDecimal(gridLkUOrdenTaller.EditValue));
                    gridLkUGrupoTrabajo.Properties.DataSource = lstGT;
                    if (lstGT.Count > 0)
                    {
                        gridLkUGrupoTrabajo.SelectionStart = 1;
                    }
                    gridVwEnsamblado.SelectAll();
                    gridVwEnsamblado.DeleteSelectedRows();

                    cargadataproducto(OT);
                }
                else
                {
                    gridLkUGrupoTrabajo.Text = "";
                    txtCantAProducir.Text = "";

                    txtProducto.Text = "";
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message); 
            }
        }

        void cargadataproducto(prd_OrdenTaller_Info info)
        {
            try
            {
                txtProducto.Text = busprod.Get_DescripcionTot_Producto(OT.IdEmpresa, OT.IdProducto);
                ObtenerCantAProd(OT);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message); 
            }


        }

        BindingList<in_Producto_Info> BindLst = new BindingList<in_Producto_Info>();
        void cargagrid(List<prd_Ensamblado_Det_CusCider_Info> Det)
        {
            try
            {
                List<in_Producto_Info> LstProd = new List<in_Producto_Info>();
                //List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> LstDetxProd = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
                //in_movi_inve_detalle_x_Producto_CusCider_Bus BusDetxProd = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
                //LstDetxProd = BusDetxProd.ObtenerMateriaPrima(param.IdEmpresa, _sucursalInfo.IdSucursal, _bodegaInfo.IdBodega,
                //    OT.IdSucursal, OT.IdOrdenTaller, OT.CodObra, OT.IdEmpresa);
                foreach (var item in Det)
                {
                    in_Producto_Info prod = new in_Producto_Info();
                    prod.IdEmpresa = item.IdEmpresa;
                    prod.IdSucursal = item.IdSucursal;
                    prod.IdProducto = item.IdProducto;
                    prod.pr_descripcion = busprod.Get_DescripcionTot_Producto(item.IdEmpresa, item.IdProducto);
                    prod.pr_codigo_barra = item.CodigoBarra;
                    prod.CantidadAjustada = item.en_cantidad;
                    prod.pr_observacion = item.Observacion;
                    LstProd.Add(prod);

                }
                BindLst = new BindingList<in_Producto_Info>();
                BindLst = new BindingList<in_Producto_Info>(LstProd);
                gridCtrlEnsamblado.DataSource = BindLst;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }


        }


        string msg = "";

        private int ObtenerCantAProd(prd_OrdenTaller_Info info)
        {
            try
            {
                vwprd_CantidadEnsamblada_x_OT_CusCider_Info CantEnsam = new vwprd_CantidadEnsamblada_x_OT_CusCider_Info();
                int Cant = 0;

                CantEnsam = BusEnsamblado.TraerCantEnsamb(info, ref msg);
                txtCantAProducir.Text = Convert.ToString(CantEnsam.CantidadPieza - CantEnsam.CantEnsamblada);

                if (Convert.ToDecimal(txtCantAProducir.Text) <= 0)

                    txtCantAProducir.ForeColor = Color.Red;

                else
                    txtCantAProducir.ForeColor = Color.Black;

                if (Convert.ToDecimal(txtCantAProducir.Text) <= 0 && iAccion == Cl_Enumeradores.eTipo_action.grabar)

                    lblNoEnsamblar.Visible = true;


                else
                    lblNoEnsamblar.Visible = false;


                return Cant;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + msg + ex.InnerException.ToString()); 
                return 0; 
            }

        }

        private void gridVwEnsamblado_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string codbarra = "";
            List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> LstDetxProd = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
            in_movi_inve_detalle_x_Producto_CusCider_Bus BusDetxProd = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
            vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info SaldoDetXProd = new vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info();
            var row = (in_Producto_Info)gridVwEnsamblado.GetRow(e.RowHandle);
            try
            {


                if (e.Column.Name == "colpr_codigo_barra")
                {
                    if (UCObra.get_item_info() == null)
                    {
                        MessageBox.Show("Debe seleccionar la Obra Asignada y la Orden de Taller", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        panelObra.Focus();

                    }
                    else if (gridLkUOrdenTaller.EditValue == null)
                    {
                        MessageBox.Show("Debe seleccionar la Orden de Taller Asignada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gridLkUOrdenTaller.Focus();

                    }
                    else
                    {

                        codbarra = Convert.ToString(gridVwEnsamblado.GetFocusedRowCellValue(colpr_codigo_barra));

                        codbarra = row.pr_codigo_barra;

                        if (codbarra != "")
                        {

                           // LstDetxProd = BusDetxProd.ObtenerMateriaPrima(param.IdEmpresa, _sucursalInfo.IdSucursal, _bodegaInfo.IdBodega,
                          //  OT.IdSucursal, OT.IdOrdenTaller, OT.CodObra, OT.IdEmpresa);

                            LstDetxProd = LstDetxProd.FindAll(var =>
                               var.CodigoBarra == codbarra);

                            if (LstDetxProd.Count > 0)

                                foreach (var item in LstDetxProd)
                                {
                                    if (item.Saldo <= 0)
                                    {
                                        MessageBox.Show("No hay en stock el producto. Verifique el código", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        gridVwEnsamblado.DeleteRow(gridVwEnsamblado.FocusedRowHandle);
                                    }
                                    else
                                    {
                                        in_Producto_Info prod = new in_Producto_Info();

                                        prod.CodBarra = item.CodigoBarra;
                                        prod.IdProducto = item.IdProducto;
                                        prod.IdEmpresa = item.IdEmpresa;
                                        prod.IdSucursal = item.IdSucursal;
                                        prod.IdBodega = item.IdBodega;
                                        prod.pr_descripcion = busprod.Get_DescripcionTot_Producto(item.IdEmpresa, item.IdProducto);
                                        gridVwEnsamblado.SetFocusedRowCellValue(colProducto, prod.pr_descripcion);
                                        gridVwEnsamblado.SetFocusedRowCellValue("IdProducto", prod.IdProducto);
                                    }
                                }
                            else
                            {
                                MessageBox.Show("El producto no existe en la bodega " + UCSuc_Bod.get_bodega().bo_Descripcion
                                    + " o no esta asignado a esa Orden de Taller. \n Verifique el código",
                                       "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                gridVwEnsamblado.DeleteRow(gridVwEnsamblado.FocusedRowHandle);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString()); 
            }
        }

        void validarepetidos()
        {
            try
            {
                LstDicProd.Clear();
                for (int i = 0; i < gridVwEnsamblado.RowCount; i++)
                {
                    in_Producto_Info info = (in_Producto_Info)gridVwEnsamblado.GetRow(i);
                    if (info != null)
                    {
                        string c = info.IdProducto.ToString() + info.pr_codigo_barra;
                        LstDicProd.Add(c, 1);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("El Registro está repetido, \n Se procedio con su eliminación", "Eliminacion de registro repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gridVwEnsamblado.DeleteRow(gridVwEnsamblado.FocusedRowHandle);
            }



        }

        private void gridLkUOrdenTaller_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (gridLkUOrdenTaller.EditValue == null)
                {
                    gridLkUOrdenTaller.Text = "";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private int etapaanterior(int etapaensamblado, int idprocprod)
        {
            try
            {
                prd_EtapaProduccion_Bus BusEta = new prd_EtapaProduccion_Bus();
                prd_EtapaProduccion_Info etaorig = new prd_EtapaProduccion_Info();
                List<prd_EtapaProduccion_Info> ListEtapas = new List<prd_EtapaProduccion_Info>();
                etaorig = BusEta.ObtenerEtapa(param.IdEmpresa, etapaensamblado, idprocprod);
                ListEtapas = BusEta.ObtenerListaEtapas(param.IdEmpresa, idprocprod);

                foreach (var item in ListEtapas)
                {
                    if (etaorig.Posicion - 1 == item.Posicion)
                    {
                        return item.IdEtapa;


                    }

                }
                return 0;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return 0;
            }


        }
        void grabar()
        {
            try
            {
                txtObservacion.Focus();
                decimal idEnsamb = 0;
                decimal idMovIng = 0;
                decimal idMovEg = 0;
                string msg = "";
                string mensaje_cbte_cble = "";


                {
                    mv_cab.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_egr_Ensamblado);
                    mv_cab.cm_tipo = "-";
                    mv_cab.cm_observacion = " Egr Suc " + UCSuc_Bod.cmb_sucursal.Text +
                        " Bod " + UCSuc_Bod.cmb_bodega.Text + Ensamblado.Observacion;
                }

                GT = busGT.OBtenerGT(param.IdEmpresa, Ensamblado.IdSucursal, 
                                Convert.ToDecimal(gridLkUGrupoTrabajo.EditValue));

                if (Bus_mv.GrabarDB(mv_cab, ref idMovEg, ref mensaje_cbte_cble, ref msg))
                {
                    Lst_mv_detalle_eg.ForEach(var => var.IdNumMovi = idMovEg);
                    int et_anterior = etapaanterior(GT.IdEtapa, GT.IdProcesoProductivo);
                    if (et_anterior == 0)
                        Lst_mv_detalleXprod_eg.ForEach(var => var.IdNumMovi = idMovEg);
                    else
                    {


                        Lst_mv_detalleXprod_eg.ForEach(var =>
                        {
                            var.et_IdEmpresa = param.IdEmpresa;
                            var.IdNumMovi = idMovEg;
                            var.et_IdProcesoProductivo = GT.IdProcesoProductivo;
                            var.et_IdEtapa = et_anterior;

                        });
                    }
                    if (Bus_mv_det.GrabarDB(Lst_mv_detalle_eg, ref msg))
                    {

                        if (Bus_mv_detXpro.GuardarDB(Lst_mv_detalleXprod_eg, ref msg))
                            if (Bus_prodxbod.ActualizarStock_x_Bodega_con_moviInven(Lst_mv_detalle_eg, ref msg))
                                MessageBox.Show("Movimiento Inventario No. " + idMovEg
                                    + " Egreso de Bodega de Produccion. \n Grabado Satisfactoriamente",
                                    "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }

                {
                    mv_cab.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_ing_Ensamblado);
                    mv_cab.cm_tipo = "+";
                    mv_cab.cm_observacion = " Ing Suc " + UCSuc_Bod.cmb_sucursal.Text +
                        " Bod " + UCSuc_Bod.cmb_bodega.Text + Ensamblado.Observacion;
                }
                mv_cab.IdNumMovi = 0;
                if (Bus_mv.GrabarDB(mv_cab, ref idMovIng,ref mensaje_cbte_cble, ref msg))
                {
                    Lst_mv_detalle_ing.ForEach(var => var.IdNumMovi = idMovIng);
                    Lst_mv_detalleXprod_ing.ForEach(var => var.IdNumMovi = idMovIng);

                    if (Bus_mv_det.GrabarDB(Lst_mv_detalle_ing, ref msg))
                    {
                        //GT = busGT.OBtenerGT(param.IdEmpresa,Ensamblado.IdSucursal,Convert.ToDecimal( gridLkUOrdenTaller.EditValue),
                        //    Convert.ToDecimal( gridLkUGrupoTrabajo.EditValue) );

                        Lst_mv_detalleXprod_ing.ForEach(var =>
                        {
                            var.et_IdEmpresa = GT.IdEmpresa;
                            var.et_IdProcesoProductivo = GT.IdProcesoProductivo;
                            var.et_IdEtapa = GT.IdEtapa;
                        });

                        if (Bus_mv_detXpro.GuardarDB(Lst_mv_detalleXprod_ing, ref msg))
                            if (Bus_prodxbod.ActualizarStock_x_Bodega_con_moviInven(Lst_mv_detalle_ing, ref msg))
                                MessageBox.Show("Movimiento Inventario No. " + idMovIng
                                    + " Ingreso de Bodega de Produccion por Etapa de Ensamblado. \n Grabado Satisfactoriamente",
                                    "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }

                Ensamblado.CodigoBarra = txtCodBarra.Text = Lst_mv_detalleXprod_ing[0].CodigoBarra;
                Ensamblado.Observacion = Ensamblado.Observacion + "Mov Eg" + idMovEg + "Mov Ing" + idMovIng;

                if (BusEnsamblado.GuardarDB(Ensamblado, DetalleEnsam, ref idEnsamb, ref msg))
                {
                    infoTI.en_IdEmpresa = infoTI.IdEmpresa = Ensamblado.IdEmpresa;
                    infoTI.en_IdSucursal = infoTI.IdSucursal = Ensamblado.IdSucursal;
                    infoTI.en_IdEnsamblado = idEnsamb;
                    infoTI.IdBodega = mv_cab.IdBodega;
                    infoTI.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_egr_Ensamblado);
                    infoTI.IdNumMovi = idMovEg;


                    if (busTI.GuardarDB(infoTI, ref msg))
                    {
                        infoTI.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_ing_Ensamblado);
                        infoTI.IdNumMovi = idMovIng;

                        if (busTI.GuardarDB(infoTI, ref msg))
                        {
                            MessageBox.Show("Ensamblado No. " + idEnsamb + "\n Grabado Satisfactoriamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEnsamblado.Text = Convert.ToString(idEnsamb);
                           // btn_guardar.Enabled = false;
                            Ensamblado.IdEnsamblado = idEnsamb;
                            setCab(Ensamblado);
                        }
                    }
                }

                else
                { }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString()); 
            }
        }

        private Boolean getCab()
        {
            try
            {
                Ensamblado.IdEmpresa = param.IdEmpresa;
                Ensamblado.IdSucursal = _sucursalInfo.IdSucursal;
                Ensamblado.IdEnsamblado = 0;
                Ensamblado.IdBodega = _bodegaInfo.IdBodega;
                Ensamblado.IdGrupoTrabajo = Convert.ToDecimal(gridLkUGrupoTrabajo.EditValue);
                Ensamblado.IdProducto = OT.IdProducto;
                Ensamblado.CodObra = UCObra.get_item();
                Ensamblado.IdOrdenTaller = Convert.ToDecimal(gridLkUOrdenTaller.EditValue);
                Ensamblado.IdUsuario = param.IdUsuario;
                Ensamblado.FechaTransac = DateTime.Now;
                Ensamblado.Estado = "A";
                var prod = busprod.Get_Info_BuscarProducto(Ensamblado.IdProducto, param.IdEmpresa);

                Ensamblado.Observacion = txtObservacion.Text +
                    " Ens Prod " + prod.pr_descripcion +
                    " x Ob " + UCObra.get_item() +
                    " Ot " + gridLkUOrdenTaller.Text +
                    " Gt " + gridLkUGrupoTrabajo.Text
                    ;
                return getDet();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + ex.ToString());
                return false; 
            }

        }

        private Boolean getDet()
        {
            try
            {
                //LstProd = (List<in_Producto_Info>)gridVwEnsamblado.DataSource;
                DetalleEnsam = new List<prd_Ensamblado_Det_CusCider_Info>();
                string observacioncab = "";
                for (int i = 0; i < gridVwEnsamblado.RowCount; i++)
                {
                    in_Producto_Info item = (in_Producto_Info)gridVwEnsamblado.GetRow(i);
                    if (item != null)
                    {
                        prd_Ensamblado_Det_CusCider_Info info = new prd_Ensamblado_Det_CusCider_Info();
                        info.IdProducto = item.IdProducto;
                        var prod = busprod.Get_Info_BuscarProducto(info.IdProducto, param.IdEmpresa);
                        info.CodigoBarra = item.pr_codigo_barra;
                        info.Observacion = item.pr_observacion + " " +
                            Ensamblado.Observacion +
                            " con Prod " + prod.pr_descripcion +
                            " CB " + item.pr_codigo_barra;
                        info.en_cantidad = 1;
                        observacioncab = observacioncab +
                            " con Prod " + prod.pr_descripcion +
                            " CB " + item.pr_codigo_barra;
                        DetalleEnsam.Add(info); ;
                    }
                }
                Ensamblado.Observacion = Ensamblado.Observacion + observacioncab;


                //foreach (var item in LstProd)
                //{
                //    prd_Ensamblado_Det_CusCider_Info info = new prd_Ensamblado_Det_CusCider_Info();
                //    info.IdProducto = item.IdProducto;
                //    info.CodigoBarra = item.CodBarra;
                //    info.Observacion = item.pr_observacion;
                //    DetalleEnsam.Add(info);
                //}
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + ex.InnerException.ToString());
                return false; 
            }
        }

        private Boolean validaciones()
        {
            try
            {

                if (lblNoEnsamblar.Visible == true)
                {
                    MessageBox.Show("Debe seleccionar otra Orden de Taller. No tiene cantidades disponibles a Ensamblar.",
                        "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridLkUOrdenTaller.Focus();
                    return false;
                }
                if (UCObra.get_item_info() == null)
                {
                    MessageBox.Show("Debe seleccionar una Obra", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    panelObra.Focus();
                    return false;
                }
                else if (gridLkUOrdenTaller.EditValue == null || gridLkUOrdenTaller.EditValue == "")
                {
                    MessageBox.Show("Debe seleccionar una Orden de Taller", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridLkUOrdenTaller.Focus();
                    return false;
                }
                else if (gridLkUGrupoTrabajo.EditValue == null || gridLkUGrupoTrabajo.EditValue == "")
                {
                    MessageBox.Show("Debe seleccionar un Grupo de Trabajo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridLkUGrupoTrabajo.Focus();
                    return false;
                }
                else if (UCSuc_Bod.get_sucursal() == null)
                {
                    MessageBox.Show("Debe seleccionar una Sucursal", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridLkUOrdenTaller.Focus();
                    UCSuc_Bod.cmb_sucursal.Focus();
                    return false;
                }
                else if (UCSuc_Bod.get_bodega() == null)
                {
                    MessageBox.Show("Debe seleccionar una Bodega", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UCSuc_Bod.cmb_bodega.Focus();
                    return false;
                }
                else if (gridVwEnsamblado.RowCount <= 0)
                {
                    MessageBox.Show("Debe ingresar los elementos para el ensamblados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridVwEnsamblado.Focus();
                    return false;
                }
                List<in_Producto_Info> Valida = new List<in_Producto_Info>();
                for (int i = 0; i < gridVwEnsamblado.RowCount - 1; i++)
                {
                    in_Producto_Info info = (in_Producto_Info)gridVwEnsamblado.GetRow(i);
                    if (info != null)
                    {
                        in_Producto_Info producto = new in_Producto_Info();
                        producto.CodBarra = info.CodBarra;
                        producto.IdProducto = info.IdProducto;
                        producto.pr_observacion = info.pr_observacion;
                        Valida.Add(producto);
                    }
                }
                //Valida = (List<in_Producto_Info>)gridVwEnsamblado.DataSource;
                int sec = 0;
                foreach (var item in Valida)
                {
                    if (item.CodBarra == "" || item.pr_descripcion== "")
                    {
                        MessageBox.Show("Ingrese correctamente los elementos a ensamblar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gridVwEnsamblado.FocusedRowHandle = ++sec;
                        return false;
                    }

                }
                getSucBod();
                if (getCab())
                {
                    return getprod_mov();

                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + ex.InnerException.ToString());
                return false; 
            }

        }

        in_movi_inve_Info mv_cab = new in_movi_inve_Info();
        
        private Boolean getprod_mov()
        {
            try
            {


                //Cabecera del movimiento
                mv_cab.IdEmpresa = param.IdEmpresa;
                mv_cab.IdSucursal = _sucursalInfo.IdSucursal;
                mv_cab.IdBodega = _bodegaInfo.IdBodega;
                mv_cab.cm_observacion = Ensamblado.Observacion;
                mv_cab.cm_fecha = Convert.ToDateTime(dtPfecha.Value);
                mv_cab.cm_mes = mv_cab.cm_fecha.Month;
                mv_cab.cm_anio = mv_cab.cm_fecha.Year;
                mv_cab.Fecha_Transac = DateTime.Now;

                mv_cab.IdUsuario = param.IdUsuario;
                mv_cab.nom_pc = param.nom_pc;
                mv_cab.ip = param.ip;
                mv_cab.Estado = "A";

                if (getingresomov() == false)
                    return false;
                if (getegresomov() == false)
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + ex.InnerException.ToString()); 
                return false;
            }

        }

        private Boolean getegresomov()
        {

            try
            {

                //obtengo el Lst_mv_detalle_eg Detalle del movimiento de egreso
                int sec = 0;
                foreach (var item in DetalleEnsam)
                {
                    in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
                    in_movi_inve_detalle_x_Producto_CusCider_Info infoxprod = new in_movi_inve_detalle_x_Producto_CusCider_Info();

                    info.IdEmpresa = infoxprod.IdEmpresa = Convert.ToInt32(param.IdEmpresa);
                    infoxprod.ot_IdEmpresa = Convert.ToInt32(param.IdEmpresa);
                    info.IdSucursal = infoxprod.IdSucursal = _sucursalInfo.IdSucursal;
                    infoxprod.ot_IdSucursal = _sucursalInfo.IdSucursal;
                    info.IdBodega = infoxprod.IdBodega = _bodegaInfo.IdBodega;
                    info.IdProducto = infoxprod.IdProducto = item.IdProducto;
                    infoxprod.CodigoBarra = item.CodigoBarra;
                    info.Secuencia = infoxprod.mv_Secuencia = ++sec;
                    info.IdMovi_inven_tipo = infoxprod.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_egr_Ensamblado);
                    info.mv_tipo_movi = infoxprod.mv_tipo_movi = "-";
                    info.dm_cantidad = infoxprod.dm_cantidad = -1;

                    var saldo = Bus_prodxbod.Get_Info_Producto_x_Producto(param.IdEmpresa, _sucursalInfo.IdSucursal, _bodegaInfo.IdBodega, item.IdProducto);

                    info.dm_stock_ante = saldo.pr_stock;
                    info.dm_stock_actu = info.dm_stock_ante + info.dm_cantidad;

                    in_Producto_Info prodtemp = new in_Producto_Info();
                    prodtemp = busprod.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                    info.dm_precio = infoxprod.dm_precio = prodtemp.pr_precio_publico == null ? 0 : Convert.ToDouble(prodtemp.pr_precio_publico);
                    infoxprod.mv_costo = infoxprod.mv_costo = prodtemp.pr_costo_promedio == null ? 0 : Convert.ToDouble(prodtemp.pr_costo_promedio);
                    info.dm_observacion = infoxprod.dm_observacion =
                        " Egr Suc " + UCSuc_Bod.cmb_sucursal.Text +
                        " Bod " + UCSuc_Bod.cmb_bodega.Text + " " +
                         item.Observacion;
                    infoxprod.ot_CodObra = UCObra.get_item();
                    infoxprod.ot_IdOrdenTaller = OT.IdOrdenTaller;

                    Lst_mv_detalleXprod_eg.Add(infoxprod);
                    Lst_mv_detalle_eg.Add(info);

                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error:" + ex.InnerException.ToString()); 
                return false;
            }
        }

        private Boolean getingresomov()
        {
            try
            {

                //obtengo el Lst_mv_detalle_ing Detalle del movimiento de ingreso
                int sec = 0;

                in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
                in_movi_inve_detalle_x_Producto_CusCider_Info infoxprod = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                info.IdEmpresa = infoxprod.IdEmpresa = param.IdEmpresa;
                infoxprod.ot_IdEmpresa = param.IdEmpresa;
                info.IdSucursal = infoxprod.IdSucursal = _sucursalInfo.IdSucursal;
                infoxprod.ot_IdSucursal = _sucursalInfo.IdSucursal;
                info.IdBodega = infoxprod.IdBodega = _bodegaInfo.IdBodega;
                info.IdProducto = infoxprod.IdProducto = OT.IdProducto;
                info.Secuencia = infoxprod.mv_Secuencia = ++sec;
                info.IdMovi_inven_tipo = infoxprod.IdMovi_inven_tipo = Convert.ToInt32(paramCidersus.IdMovi_inven_tipo_ing_Ensamblado);
                info.mv_tipo_movi = infoxprod.mv_tipo_movi = "+";
                info.dm_cantidad = infoxprod.dm_cantidad = 1;
                var saldo = Bus_prodxbod.Get_Info_Producto_x_Producto(param.IdEmpresa, _sucursalInfo.IdSucursal, _bodegaInfo.IdBodega, OT.IdProducto);

                info.dm_stock_ante = saldo.pr_stock;
                info.dm_stock_actu = info.dm_stock_ante + info.dm_cantidad;

                in_Producto_Info prodtemp = new in_Producto_Info();

                prodtemp = busprod.Get_Info_BuscarProducto(OT.IdProducto, param.IdEmpresa);
                if (prodtemp != null)
                {


                    info.dm_precio = infoxprod.dm_precio = prodtemp.pr_precio_publico == null ? 0 : Convert.ToDouble(prodtemp.pr_precio_publico);
                    infoxprod.mv_costo = infoxprod.mv_costo = prodtemp.pr_costo_promedio == null ? 0 : Convert.ToDouble(prodtemp.pr_costo_promedio);
                    info.dm_observacion = infoxprod.dm_observacion =
                        " Ing Suc " + UCSuc_Bod.cmb_sucursal.Text +
                    " Bod " + UCSuc_Bod.cmb_bodega.Text +
                    Ensamblado.Observacion;
                }
                infoxprod.ot_CodObra = UCObra.get_item();
                infoxprod.ot_IdOrdenTaller = OT.IdOrdenTaller;
                Lst_mv_detalleXprod_ing.Add(infoxprod);
                Lst_mv_detalle_ing.Add(info);

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
                MessageBox.Show(ex.InnerException.ToString());
                return false; 
            }
        }

        private void gridLkUGrupoTrabajo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (gridLkUGrupoTrabajo.EditValue == null)
                {
                    gridLkUGrupoTrabajo.Text = "";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private void btn_salir_Click(object sender, EventArgs e)
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validaciones() == false)
                {
                    MessageBox.Show("No se guardo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    grabar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridVwEnsamblado_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
              validarepetidos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        
        private void gridVwEnsamblado_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
              if (e.KeyCode.ToString() == "Delete")
                gridVwEnsamblado.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){}

        private void tabPage1_Click(object sender, EventArgs e){}

        private void txtCantAProducir_TextChanged(object sender, EventArgs e){}

        private void txtCodBarra_TextChanged(object sender, EventArgs e){}

        private void label4_Click(object sender, EventArgs e){}

        private void label7_Click(object sender, EventArgs e) { }


        private void label5_Click(object sender, EventArgs e){}


        private void txtProducto_TextChanged(object sender, EventArgs e){}


        private void groupBox4_Enter(object sender, EventArgs e){}


        private void txtEnsamblado_TextChanged(object sender, EventArgs e){}


        private void gridLkUGrupoTrabajo_EditValueChanged(object sender, EventArgs e){}


        private void txtObservacion_TextChanged(object sender, EventArgs e){}


        private void panel1_Paint(object sender, PaintEventArgs e){}
  

        private void lblAnulado_Click(object sender, EventArgs e){}


        private void label8_Click(object sender, EventArgs e){}


        private void label3_Click(object sender, EventArgs e) { }


        private void lblBodega_Click(object sender, EventArgs e){}

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        

     


    
    }
}

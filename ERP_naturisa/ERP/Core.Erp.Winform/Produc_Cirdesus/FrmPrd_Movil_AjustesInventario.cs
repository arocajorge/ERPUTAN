using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Winform;
using System.Threading;
using DevExpress.XtraSplashScreen;
using Core.Erp.Winform.General;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Winform.Inventario;
using Core.Erp.Winform.Inventario_Cidersus;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_Movil_AjustesInventario : Form
    {
        public FrmPrd_Movil_AjustesInventario()
        {
            try
            {
                InitializeComponent();
                gridControlAjustes.DataSource = ListaBind;
                UCSucBod.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
                cambiacontroles();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_parametros_CusCidersus_Bus BusParametro = new prd_parametros_CusCidersus_Bus();
        prd_parametros_CusCidersus_Info InfoParametro = new prd_parametros_CusCidersus_Info();
        BindingList<in_movi_inve_detalle_x_Producto_CusCider_Info> ListaBind = new BindingList<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        private Cl_Enumeradores.eTipo_action _Accion;
        string tipomov = "+";
        void cambiacontroles()
        {
            try
            {
                Font fte = new System.Drawing.Font("Microsoft Sans Serif", 6.5f);

                UCSucBod.cmb_bodega.Size = new System.Drawing.Size(170, 18);
                UCSucBod.cmb_sucursal.Size = new System.Drawing.Size(170, 18);
                UCSucBod.label1.Text = "SUC:";
                UCSucBod.lblBodega.Text = "BOD:";
                UCSucBod.label1.Location = new Point(0, 8);
                UCSucBod.lblBodega.Location = new Point(0, 30);
                UCSucBod.label1.Font = fte;
                UCSucBod.lblBodega.Font = fte;
                UCSucBod.cmb_bodega.Font = fte;
                UCSucBod.cmb_sucursal.Font = fte;
                UCSucBod.cmb_sucursal.Location = new Point(27, 5);
                UCSucBod.cmb_bodega.Location = new Point(27, 27);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void FrmIn_AjustesInventario_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                UCSucBod.Event_cmb_bodega_SelectedIndexChanged += UCSucBod_Event_cmb_bodega_SelectedIndexChanged;
                UCSucBod.Event_cmb_sucursal_SelectedIndexChanged += UCSucBod_Event_cmb_sucursal_SelectedIndexChanged;
             
                if (_Accion == Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar)
                {
                    cargatipomov(tipomov);
                    cargaproductos();
                 
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        void FrmIn_AjustesInventario_Mant_event_FrmIn_AjustesInventario_Mant_FormClosing(object sender, FormClosingEventArgs e){}


        void UCSucBod_Event_cmb_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //    LstCodbar = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                //    gridControlAjustes.DataSource = LstCodbar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        void UCSucBod_Event_cmb_bodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                cargaproductos(); cargatipomov(tipomov);
                //LstCodbar = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                //gridControlAjustes.DataSource = LstCodbar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }
        in_movi_inven_tipo_Bus busTipMov = new in_movi_inven_tipo_Bus();

        void cargatipomov(string tipoMovi)
        {
            try
            {
                var tiposmov = (List<in_movi_inven_tipo_Info>)busTipMov.Get_list_movi_inven_tipo_x_bodega(param.IdEmpresa,
                    Convert.ToInt32(UCSucBod.cmb_sucursal.EditValue), Convert.ToInt32(UCSucBod.cmb_bodega.EditValue), tipoMovi, "N");
                cmb_tipoMoviInven.DisplayMember = "tm_descripcion";
                cmb_tipoMoviInven.ValueMember = "IdMovi_inven_tipo";
                cmb_tipoMoviInven.DataSource = tiposmov;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
        void cargaproductos()
        {
            try
            {
                cmbProducto.DataSource = busProd.Get_list_Producto(param.IdEmpresa,Convert.ToInt32(UCSucBod.cmb_sucursal.EditValue),
                    Convert.ToInt32(UCSucBod.cmb_bodega.EditValue) );

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        in_movi_inve_Info Info = new in_movi_inve_Info();
        List<in_movi_inve_detalle_Info> LstDetalle = new List<in_movi_inve_detalle_Info>();
        in_movi_inve_detalle_Bus BusDetMov = new in_movi_inve_detalle_Bus();
        in_movi_inve_Bus BusCabMov = new in_movi_inve_Bus();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> LstCodbar = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        in_movi_inve_detalle_x_Producto_CusCider_Bus BusCodBAr = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        in_producto_Bus busProd = new in_producto_Bus();
        in_producto_x_tb_bodega_Bus busProdxBod = new in_producto_x_tb_bodega_Bus();
        in_movi_inve_detalle_x_Producto_CusCider_Info row = new in_movi_inve_detalle_x_Producto_CusCider_Info();

        public void set_AjusteMoviInven(in_movi_inve_Info Cab)
        {
            try
            {
                LstCodbar = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                LstDetalle = new List<in_movi_inve_detalle_Info>();

                Info = Cab;
                UCSucBod.cmb_sucursal.EditValue = Info.IdSucursal;
                UCSucBod.cmb_bodega.EditValue = Info.IdBodega;
                cargaproductos();
                txtcodigoAjuste.Text = Info.CodMoviInven;
                this.txtNumAjuste.Text = Info.IdNumMovi.ToString();
                this.txtObservacion.Text = Info.cm_observacion.Trim();
                dtpFecha.Value = Info.cm_fecha;
                lblAnulado.Visible = (Info.Estado == "I") ? true : false;
                if (Info.cm_tipo == "+")
                {
                    opt_ingreso.Checked = true;

                }
                else if (Info.cm_tipo == "-")
                {
                    opt_egreso.Checked = true;

                }
                cargatipomov(Info.cm_tipo);
                cmb_tipoMoviInven.SelectedValue = Info.IdMovi_inven_tipo;


                LstDetalle = BusDetMov.Get_list_Movi_inven_det(param.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdMovi_inven_tipo,
                Info.IdNumMovi);
                foreach (var item in LstDetalle)
                {
                    row = new in_movi_inve_detalle_x_Producto_CusCider_Info();

                    row.IdEmpresa = item.IdEmpresa;
                    row.IdSucursal = item.IdSucursal;
                    row.IdProducto = item.IdProducto;
                    row.IdBodega = item.IdBodega;
                    row.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    row.IdNumMovi = item.IdNumMovi;

                    var listado = BusCodBAr.ConsultaxMovInvTipo(param.IdEmpresa, Info.IdSucursal, Info.IdBodega, Info.IdNumMovi, Info.IdMovi_inven_tipo, item.IdProducto);
                    if (listado.Count > 0)
                    {
                        foreach (var det in listado)
                        {
                            in_movi_inve_detalle_x_Producto_CusCider_Info newrow = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            newrow.IdEmpresa = param.IdEmpresa;
                            newrow.IdSucursal = Info.IdSucursal;
                            newrow.IdBodega = Info.IdBodega;
                            newrow.IdProducto = item.IdProducto;
                            newrow.IdMovi_inven_tipo = Info.IdMovi_inven_tipo;
                            newrow.IdNumMovi = Info.IdNumMovi;
                            newrow.dm_cantidad = det.dm_cantidad;
                            newrow.CodigoBarra = det.CodigoBarra;
                            newrow.dm_observacion = det.dm_observacion;
                            insertariconos(newrow);
                            LstCodbar.Add(newrow);
                        }
                    }
                    else
                    {
                        row.dm_cantidad = item.dm_cantidad;
                        row.CodigoBarra = "PROD SIN CB";
                        row.dm_observacion = item.dm_observacion;
                        insertariconos(row);
                        LstCodbar.Add(row);
                    }

                }

                if (tipomov == "-") LstCodbar.ForEach(row => row.dm_cantidad = row.dm_cantidad * -1);
                ListaBind = new BindingList<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                ListaBind = new BindingList<in_movi_inve_detalle_x_Producto_CusCider_Info>(LstCodbar);
                gridControlAjustes.DataSource = ListaBind;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        public Boolean Validaciones()
        {
            try
            {

                if (txtObservacion.Text == "")
                {
                    MessageBox.Show("Debe ingresar una observacion para poder grabar.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtObservacion.Focus();
                    return false;
                }

                if (cmb_tipoMoviInven.Text == "")
                {
                    MessageBox.Show("Debe escoger un tipo ajuste para poder grabar.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_tipoMoviInven.Focus();
                    return false;

                }

                if (Convert.ToInt32(UCSucBod.cmb_sucursal.EditValue) == 0)
                {

                    MessageBox.Show("Debe escoger una sucursal para poder grabar.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UCSucBod.cmb_sucursal.Focus();
                    return false;

                }

                if (Convert.ToInt32(UCSucBod.cmb_bodega.EditValue) == 0)
                {


                    MessageBox.Show("Debe escoger una bodega para poder grabar.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UCSucBod.cmb_bodega.Focus();
                    return false;

                }


                if (ListaBind.Count <= 0)
                {
                    MessageBox.Show("No existen registros de productos para grabar.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    int count = 0;
                    foreach (var item in LstCodbar)
                    {
                        if (item.dm_cantidad < 1)
                        {
                            MessageBox.Show("Verifique las cantidades de los productos para grabar." + count, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                    }

                }
                return getCab();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ha ocurrido un error en:" + ex.ToString());
                return false;
            }

        }

        private Boolean getCab()
        {
            try
            {
                Info = new in_movi_inve_Info();


                Info.cm_anio = dtpFecha.Value.Year;
                Info.cm_fecha = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
                Info.cm_mes = dtpFecha.Value.Month;

                Info.cm_tipo = (opt_ingreso.Checked == true) ? "+" : "-";
                if (Info.cm_tipo.Trim() == "+")
                {

                    Info.cm_observacion = txtObservacion.Text.Trim()
                        + " Ing Suc " + UCSucBod.get_sucursal().Su_Descripcion
                        + " Bod " + UCSucBod.get_bodega().bo_Descripcion
                        + cmb_tipoMoviInven.Text
                        ;
                }
                else
                {
                    Info.cm_observacion = txtObservacion.Text.Trim()
                          + " Egr Suc " + UCSucBod.get_sucursal().Su_Descripcion
                          + " Bod " + UCSucBod.get_bodega().bo_Descripcion
                          + cmb_tipoMoviInven.Text
                          ;
                }

                Info.CodMoviInven = txtcodigoAjuste.Text.Trim();
                Info.Estado = (lblAnulado.Visible == true) ? "I" : "A";
                Info.IdBodega = Convert.ToInt32(UCSucBod.cmb_bodega.EditValue);
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdSucursal = Convert.ToInt32(UCSucBod.cmb_sucursal.EditValue);
                Info.IdMovi_inven_tipo = Convert.ToInt32(cmb_tipoMoviInven.SelectedValue);
                Info.IdUsuario = param.IdUsuario;
                Info.Fecha_Transac = DateTime.Now;
                Info.nom_pc = param.nom_pc;
                Info.ip = param.ip;

                return getDet();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private Boolean getDet()
        {
            try
            {
                int secuencia_detalle = 0;

                LstCodbar = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> temporalLista = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                for (int i = 0; i < gridViewAjustes.RowCount; i++)
                {
                    row = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    row = (in_movi_inve_detalle_x_Producto_CusCider_Info)gridViewAjustes.GetRow(i);


                    if (row != null)
                    {
                        in_movi_inve_detalle_x_Producto_CusCider_Info rowtemp = new in_movi_inve_detalle_x_Producto_CusCider_Info();

                        var prod = busProd.Get_Info_BuscarProducto(row.IdProducto, param.IdEmpresa);
                        if (prod.pr_ManejaSeries == "N")
                        {
                            rowtemp.dm_observacion = row.dm_observacion;
                            rowtemp.dm_cantidad = row.dm_cantidad;
                            rowtemp.IdProducto = row.IdProducto;
                            rowtemp.CodigoBarra = "";
                            temporalLista.Add(rowtemp);
                        }
                        else
                        {
                            if (row.dm_cantidad > 1)
                            {
                                for (int x = 0; x < (row.dm_cantidad); x++)
                                {
                                    rowtemp.IdProducto = row.IdProducto;
                                    rowtemp.dm_observacion = row.dm_observacion;
                                    rowtemp.CodigoBarra = "generarCB";
                                    rowtemp.dm_cantidad = 1;
                                    temporalLista.Add(rowtemp);
                                }

                            }
                            else
                                if ((row.CodigoBarra == null) || (row.CodigoBarra == "") && tipomov == "+")
                                {
                                    rowtemp.IdProducto = row.IdProducto;
                                    rowtemp.dm_observacion = row.dm_observacion;
                                    rowtemp.dm_cantidad = row.dm_cantidad;
                                    rowtemp.CodigoBarra = "generarCB";
                                    temporalLista.Add(rowtemp);
                                }
                                else
                                {
                                    rowtemp.IdProducto = row.IdProducto;
                                    rowtemp.dm_observacion = row.dm_observacion;
                                    rowtemp.dm_cantidad = row.dm_cantidad;
                                    rowtemp.CodigoBarra = row.CodigoBarra;

                                    temporalLista.Add(rowtemp);
                                }



                        }

                    }

                }

                try
                {
                    var Detalle_SinCB = temporalLista.FindAll(var => var.CodigoBarra == "");
                    foreach (var item in Detalle_SinCB)
                    {

                        in_movi_inve_detalle_Info InfoDet = new in_movi_inve_detalle_Info();
                        InfoDet.IdEmpresa = param.IdEmpresa;
                        InfoDet.IdSucursal = Convert.ToInt32(UCSucBod.cmb_sucursal.EditValue);
                        InfoDet.IdBodega = Convert.ToInt32(UCSucBod.cmb_bodega.EditValue);
                        InfoDet.IdMovi_inven_tipo = Convert.ToInt32(cmb_tipoMoviInven.SelectedValue);
                        InfoDet.Secuencia = ++secuencia_detalle;
                        InfoDet.mv_tipo_movi = tipomov;
                        InfoDet.IdProducto = item.IdProducto;
                        var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                        InfoDet.dm_observacion = item.dm_observacion + Info.cm_observacion + " PROD " + prod.pr_descripcion;
                        if (tipomov == "+")

                            InfoDet.dm_cantidad = item.dm_cantidad;
                        else
                            InfoDet.dm_cantidad = item.dm_cantidad * -1;



                        var stock = busProdxBod.Get_Info_Producto_x_Producto(InfoDet.IdEmpresa, InfoDet.IdSucursal, InfoDet.IdBodega, InfoDet.IdProducto);
                        InfoDet.dm_stock_ante = stock.pr_stock;
                        InfoDet.dm_stock_actu = stock.pr_stock + InfoDet.dm_cantidad;

                        LstDetalle.Add(InfoDet);
                    }

                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                }

                try
                {

                    var Detalle_CB = temporalLista.FindAll(var => var.CodigoBarra != "");
                    var ListaDetalle = from C in Detalle_CB
                                       group C by new { C.IdProducto }
                                           into grouping
                                           select new { grouping.Key };

                    foreach (var key in ListaDetalle)
                    {
                        in_movi_inve_detalle_Info InfoDet = new in_movi_inve_detalle_Info();
                        InfoDet.IdEmpresa = param.IdEmpresa;
                        InfoDet.IdSucursal = Convert.ToInt32(UCSucBod.cmb_sucursal.EditValue);
                        InfoDet.IdBodega = Convert.ToInt32(UCSucBod.cmb_bodega.EditValue);
                        InfoDet.IdMovi_inven_tipo = Convert.ToInt32(cmb_tipoMoviInven.SelectedValue);
                        InfoDet.Secuencia = ++secuencia_detalle;
                        InfoDet.mv_tipo_movi = tipomov;
                        InfoDet.IdProducto = key.Key.IdProducto;


                        var prod = busProd.Get_Info_BuscarProducto(key.Key.IdProducto, param.IdEmpresa);
                        string obser = "";
                        foreach (var item in Detalle_CB)
                        {

                            if (key.Key.IdProducto == item.IdProducto)
                            {
                                obser = (obser != "") ? obser : item.dm_observacion;

                                item.dm_observacion = obser +
                                    Info.cm_observacion + " PROD " + prod.pr_descripcion;

                                InfoDet.dm_cantidad = InfoDet.dm_cantidad + item.dm_cantidad;

                                item.IdEmpresa = param.IdEmpresa;
                                item.IdSucursal = Convert.ToInt32(UCSucBod.cmb_sucursal.EditValue);
                                item.IdBodega = Convert.ToInt32(UCSucBod.cmb_bodega.EditValue);
                                item.IdMovi_inven_tipo = Convert.ToInt32(cmb_tipoMoviInven.SelectedValue);
                                item.mv_Secuencia = secuencia_detalle;
                                item.mv_tipo_movi = tipomov;


                                if (tipomov == "-")
                                    item.dm_cantidad = item.dm_cantidad * -1;

                                if (tipomov == "+" && item.CodigoBarra == "generarCB")
                                    item.CodigoBarra = "";

                                LstCodbar.Add(item);

                            }

                        }

                        InfoDet.dm_observacion = obser + Info.cm_observacion + " PROD " + prod.pr_descripcion;
                        if (tipomov == "-")
                            InfoDet.dm_cantidad = InfoDet.dm_cantidad * -1;

                        var stock = busProdxBod.Get_Info_Producto_x_Producto(InfoDet.IdEmpresa, InfoDet.IdSucursal, InfoDet.IdBodega, InfoDet.IdProducto);
                        InfoDet.dm_stock_ante = stock.pr_stock;
                        InfoDet.dm_stock_actu = stock.pr_stock + InfoDet.dm_cantidad;


                        LstDetalle.Add(InfoDet);

                    }

                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());

                }


                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }

        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {


                _Accion = iAccion;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.btnGrabar.Text = "Grabar";
                        this.btnGrabar.Enabled = true;

                        UCSucBod.cmb_sucursal.EditValue = 1;
                        UCSucBod.cmb_bodega.EditValue = 1;


                        break;
                   
                    case Cl_Enumeradores.eTipo_action.consultar:

                        this.btnGrabar.Enabled = false;
                        
                        break;

                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

       

        private void opt_egreso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                tipomov = "-";
                colIcoCodBarra.Visible = true;
                cargatipomov(tipomov);


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void opt_ingreso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                tipomov = "+";
                colIcoCodBarra.Visible = false;
                cargatipomov(tipomov);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                        grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        string msg = "";

        private Boolean grabar()
        {
            try
            {

                string mensaje_cbte_cble = "";


                txtcodigoAjuste.Focus();
                if (Validaciones())
                {
                    decimal idcab = 0;
                    if (BusCabMov.GrabarDB(Info, ref idcab,ref mensaje_cbte_cble, ref msg))
                    {
                        Info.IdNumMovi = idcab;
                        LstDetalle.ForEach(var => var.IdNumMovi = idcab);
                        if (BusDetMov.GrabarDB(LstDetalle, ref msg))
                        {
                            if (busProdxBod.ActualizarStock_x_Bodega_con_moviInven(LstDetalle, ref msg))
                            {
                                if (LstCodbar.Count == 0)
                                {
                                    MessageBox.Show("Se procedio a grabar el Ajuste# " + idcab, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    set_AjusteMoviInven(Info); set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                                    return true;
                                }
                                else
                                {
                                    LstCodbar.ForEach(var => var.IdNumMovi = idcab);
                                    if (BusCodBAr.GuardarDB(LstCodbar, ref msg))
                                    {
                                        MessageBox.Show("Se procedio a grabar el Ajuste# " + idcab, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        set_AjusteMoviInven(Info);
                                        set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                                        return true;
                                    }
                                    else return mostrarerror(msg);
                                }
                            }
                            else return mostrarerror(msg);
                        }
                        else return mostrarerror(msg);
                    }
                    else return mostrarerror(msg);

                }
                else return false;



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;

            }

        }

        private Boolean mostrarerror(string msg)
        {
            try
            {
                MessageBox.Show("Error ocurrido por:" + msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }


        }

        

        private void cmb_tipoMoviInven_SelectedIndexChanged(object sender, EventArgs e){}

        private void btnSalir_Click(object sender, EventArgs e)
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


        int secuencia = 0;



    

        private Boolean verificarrepetidos(string codbarra, decimal idproducto, int tipo, Boolean eliminar)
        {
            try
            {
                if (codbarra != "")
                {
                    var co = from q in ListaBind
                             where q.CodigoBarra == codbarra
                             && q.CodigoBarra.Trim() != "PROD SIN CB"
                             && q.CodigoBarra.Trim() != ""
                             select q;

                    if (co.Count() == tipo)
                        return true; // no hay
                    else
                    {
                        if (eliminar == true)
                        {
                            MessageBox.Show("El Codigo ya se encuentra Ingresado. Se procedera con su eliminación.");
                            gridViewAjustes.DeleteRow(gridViewAjustes.FocusedRowHandle);
                        }
                        else
                            MessageBox.Show("El Codigo ya se encuentra Ingresado. Se procedera con su eliminación.");


                        return false; // si hay repetidos

                    }
                }
                else
                {
                    var co = from q in ListaBind
                             where q.IdProducto == idproducto
                             select q;

                    if (co.Count() == tipo)
                        return true; // no hay
                    else
                    {
                        if (eliminar == true)
                        {
                            MessageBox.Show("El Codigo ya se encuentra Ingresado. Se procedera con su eliminación.");
                            gridViewAjustes.DeleteRow(gridViewAjustes.FocusedRowHandle);
                        }
                        else
                            MessageBox.Show("El Codigo ya se encuentra Ingresado. Se procedera con su eliminación.");

                        return false; // si hay repeditos
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;

            }

        }

        void insertariconos(in_movi_inve_detalle_x_Producto_CusCider_Info item)
        {
            try
            {
                item.IcoCodBarra = (Bitmap)imageList1.Images[2];
                item.IcoProdCons = (Bitmap)imageList1.Images[0];
                item.IcoProdNuevo = (Bitmap)imageList1.Images[1];

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        private void gridViewAjustes_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                row = (in_movi_inve_detalle_x_Producto_CusCider_Info)gridViewAjustes.GetRow(e.RowHandle);
                if (e.Column.Name == "colCodBarra")
                {
                    if (tipomov == "-")
                    #region
                    {

                        if (verificarrepetidos(Convert.ToString(e.Value), 0, 1, true))
                        {
                            in_movi_inve_detalle_x_Producto_CusCider_Info temprow = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            temprow = BusCodBAr.TraeProducto(Convert.ToString(e.Value), param.IdEmpresa);
                            if (temprow.IdProducto == 0)
                            {
                                MessageBox.Show("No existe ese código de barra, por favor verifique.");
                                gridViewAjustes.DeleteRow(gridViewAjustes.FocusedRowHandle);
                            }
                            else
                            {

                                var prodxbod = busProdxBod.Get_Info_Producto_x_Producto(param.IdEmpresa, Convert.ToInt32(UCSucBod.cmb_sucursal.EditValue), Convert.ToInt32(UCSucBod.cmb_bodega.EditValue), temprow.IdProducto);
                                if (prodxbod == null)
                                {
                                    MessageBox.Show("No existe el producto en la Bodega Seleccionada, por favor verifique");
                                    gridViewAjustes.DeleteRow(gridViewAjustes.FocusedRowHandle);

                                }
                                else if (prodxbod.pr_stock <= 0)
                                {
                                    MessageBox.Show("No hay stock en bodega, por favor verifique");
                                    gridViewAjustes.DeleteRow(gridViewAjustes.FocusedRowHandle);

                                }
                                else
                                {
                                    //validar si hay stock del producto con CB ValidarProdxCodBarra esta funcion retorna un List<in_movi_inve_detalle_Info> y recibe como parametros tambien List<in_movi_inve_detalle_Info> por ello la sig conversión


                                    in_movi_inve_detalle_x_Producto_CusCider_Info prodverif = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                                    prodverif.IdEmpresa = param.IdEmpresa;
                                    prodverif.IdSucursal = Convert.ToInt32(UCSucBod.cmb_sucursal.EditValue);
                                    prodverif.IdBodega = Convert.ToInt32(UCSucBod.cmb_bodega.EditValue);
                                    prodverif.IdProducto = temprow.IdProducto;
                                    prodverif.CodigoBarra = temprow.CodigoBarra;

                                    var listadoverif = BusCodBAr.SaldosxItemsxCodBarra(prodverif);
                                    if ((listadoverif.dm_cantidad <= 0))
                                    {
                                        MessageBox.Show("No hay stock en bodega, por favor verifique");
                                        gridViewAjustes.DeleteRow(gridViewAjustes.FocusedRowHandle);
                                    }
                                    else
                                    {
                                        if (row.Secuencia == 0)
                                        {
                                            foreach (var item in ListaBind)
                                            {
                                                if (item.Secuencia == row.Secuencia)
                                                {
                                                    item.dm_cantidad = 1;
                                                    item.Secuencia = ++secuencia;
                                                    item.CodigoBarra = temprow.CodigoBarra;
                                                    item.IdProducto = temprow.IdProducto;
                                                    insertariconos(item);

                                                }

                                            }
                                        }
                                        else
                                        {
                                            foreach (var item in ListaBind)
                                            {
                                                if (item.Secuencia == row.Secuencia)
                                                {
                                                    item.IdProducto = temprow.IdProducto;
                                                    item.CodigoBarra = temprow.CodigoBarra;
                                                    item.dm_cantidad = 1;
                                                    item.dm_observacion = "";
                                                    insertariconos(item);
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }



                    }
                    #endregion
                    else if (tipomov == "+")
                    #region
                    {

                        if (row != null)
                        {
                            if (verificarrepetidos(Convert.ToString(e.Value), 0, 1, true))
                            {

                                if (row.Secuencia == 0)
                                {
                                    foreach (var item in ListaBind)
                                    {
                                        if (item.Secuencia == row.Secuencia)
                                        {
                                            item.dm_cantidad = 1;
                                            item.Secuencia = ++secuencia;
                                            item.CodigoBarra = row.CodigoBarra;
                                            if (Convert.ToDecimal(row.IdProducto) != 0)
                                            {
                                                var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                                                if (prod.pr_ManejaSeries == "N")
                                                    item.CodigoBarra = "PROD SIN CB";
                                                else
                                                    item.dm_cantidad = 0;

                                            }

                                            item.IdProducto = row.IdProducto;
                                            insertariconos(item);
                                        }

                                    }
                                }
                                else
                                {
                                    foreach (var item in ListaBind)
                                    {
                                        if (item.Secuencia == row.Secuencia)
                                        {
                                            item.IdProducto = row.IdProducto;
                                            item.CodigoBarra = row.CodigoBarra;
                                            item.dm_cantidad = 1;

                                            if (Convert.ToDecimal(row.IdProducto) != 0)
                                            {
                                                var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                                                if (prod.pr_ManejaSeries == "N")
                                                    item.CodigoBarra = "PROD SIN CB";
                                                else
                                                    item.dm_cantidad = 0;

                                            }

                                            item.dm_observacion = "";
                                            insertariconos(item);
                                        }
                                    }
                                }
                            }

                        }

                    }
                    #endregion
                }
                else if (e.Column.Name == "colIdProducto")
                {
                    if (tipomov == "-")
                    #region
                    {

                        var prod = busProd.Get_Info_BuscarProducto(Convert.ToInt32(e.Value), param.IdEmpresa);
                        if (prod.pr_ManejaSeries == "S")
                        {
                            MessageBox.Show("Por favor, elija/ingrese primero el Código de Barra.");
                            gridViewAjustes.DeleteRow(gridViewAjustes.FocusedRowHandle);

                        }
                        else
                        {

                            if (verificarrepetidos("", Convert.ToDecimal(e.Value), 1, true))
                            {
                                var prodxbod = busProdxBod.Get_Info_Producto_x_Producto(param.IdEmpresa, Convert.ToInt32(UCSucBod.cmb_sucursal.EditValue), Convert.ToInt32(UCSucBod.cmb_bodega.EditValue), row.IdProducto);
                                if (prodxbod.pr_stock < 1)
                                {
                                    MessageBox.Show("Producto sin stock.");
                                    gridViewAjustes.DeleteRow(gridViewAjustes.FocusedRowHandle);

                                }
                                else
                                {
                                    if (row.Secuencia == 0)
                                    {
                                        foreach (var item in ListaBind)
                                        {
                                            if (item.Secuencia == row.Secuencia)
                                            {
                                                item.dm_cantidad = 0;
                                                item.Secuencia = ++secuencia;
                                                item.CodigoBarra = "PROD SIN CB";
                                                insertariconos(item);
                                            }

                                        }
                                    }
                                    else
                                    {
                                        foreach (var item in ListaBind)
                                        {
                                            if (item.Secuencia == row.Secuencia)
                                            {
                                                item.dm_cantidad = 0;
                                                item.dm_observacion = "";
                                                item.CodigoBarra = "PROD SIN CB";
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }


                    #endregion
                    else if (tipomov == "+")
                    #region
                    {
                        if (row != null)
                        {
                            if (row.Secuencia == 0)
                            {
                                var prod = busProd.Get_Info_BuscarProducto(row.IdProducto, param.IdEmpresa);
                                if (prod.pr_ManejaSeries == "N")
                                {
                                    if (verificarrepetidos("", row.IdProducto, 1, true) == false)
                                        return;
                                }

                                foreach (var item in ListaBind)
                                {

                                    if (item.Secuencia == 0)
                                    {
                                        item.dm_cantidad = 0;
                                        if (prod.pr_ManejaSeries == "N")
                                            row.CodigoBarra = "PROD SIN CB";
                                        else
                                            item.dm_cantidad = 1;
                                        item.Secuencia = ++secuencia;

                                        insertariconos(item);
                                    }

                                }
                            }
                            else
                            {
                                foreach (var item in ListaBind)
                                {
                                    if (item.Secuencia == row.Secuencia)
                                    {
                                        item.dm_cantidad = 0;
                                        var prod = busProd.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                                        if (prod.pr_ManejaSeries == "N")
                                            item.CodigoBarra = "PROD SIN CB";
                                        else
                                            item.dm_cantidad = 1;

                                        item.dm_observacion = "";

                                    }
                                }
                            }


                        }

                    }
                    #endregion
                }

                else if (e.Column.Name == "coldm_cantidad")
                {
                    #region
                    if (row != null)
                    {
                        if (row.IdProducto == null || row.IdProducto == 0)
                        {
                            MessageBox.Show("Por favor elija primero el producto");
                            gridViewAjustes.DeleteRow(gridViewAjustes.FocusedRowHandle);

                        }
                        else
                        {
                            var prod = busProd.Get_Info_BuscarProducto(row.IdProducto, param.IdEmpresa);
                            if (prod.pr_ManejaSeries == "S" && Convert.ToDouble(e.Value) > 1 && tipomov == "-")
                            {
                                MessageBox.Show("Producto que maneja código de barra cant max es 1");
                                foreach (var item in ListaBind)
                                {
                                    if (item.Secuencia == row.Secuencia)
                                        item.dm_cantidad = 1;
                                }

                            }
                            else if (Convert.ToDouble(e.Value) < 0)
                            {
                                MessageBox.Show("Cantidad mínima a registrar es 1.");
                                foreach (var item in ListaBind)
                                {
                                    if (item.Secuencia == row.Secuencia)
                                        item.dm_cantidad = 0;
                                }

                            }
                            else if (prod.pr_ManejaSeries == "N")
                            {
                                if (tipomov == "-")
                                {
                                    var prodxbod = busProdxBod.Get_Info_Producto_x_Producto(param.IdEmpresa, Convert.ToInt32(UCSucBod.cmb_sucursal.EditValue), Convert.ToInt32(UCSucBod.cmb_bodega.EditValue), row.IdProducto);
                                    if (prodxbod.pr_stock < row.dm_cantidad)
                                    {
                                        MessageBox.Show("Cantidad supera al stock del inventario.");
                                        foreach (var item in ListaBind)
                                        {
                                            if (item.Secuencia == row.Secuencia)
                                                item.dm_cantidad = 0;
                                        }

                                    }
                                }

                            }


                        }

                    }

                    #endregion

                }
                else if (e.Column.Name == "coldm_observacion")
                {
                    #region
                    if (row != null)
                    {
                        if ((row.Secuencia == 0))
                        {
                            MessageBox.Show("Por favor elija primero el producto");
                            gridViewAjustes.DeleteRow(gridViewAjustes.FocusedRowHandle);


                        }
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }


        }

        private void gridViewAjustes_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                    gridViewAjustes.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());


            }
        }

        private void gridViewAjustes_RowCountChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in ListaBind)
                {
                    item.IcoCodBarra = (Bitmap)imageList1.Images[2];
                    item.IcoProdCons = (Bitmap)imageList1.Images[0];
                    item.IcoProdNuevo = (Bitmap)imageList1.Images[1];
                }
                //  gridViewAjustes.RefreshData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private void gridViewAjustes_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name == "colIcoProdCons")
            #region
            {

                FrmIn_Producto_Busqueda frm = new FrmIn_Producto_Busqueda();
                frm.ShowDialog();
                if (frm._prodBod != null)
                {
                    var prod = frm._prodBod;
                    prod = busProd.Get_Info_BuscarProducto(prod.IdProducto, param.IdEmpresa);
                    var prodxbod = busProdxBod.Get_Info_Producto_x_Producto(param.IdEmpresa, Convert.ToInt32(UCSucBod.cmb_sucursal.EditValue), Convert.ToInt32(UCSucBod.cmb_bodega.EditValue), prod.IdProducto);
                    if (prodxbod == null)
                    {
                        MessageBox.Show("No existe el producto en bodega. Por favor asignelo");
                        return;
                    }

                    if (tipomov == "-")
                    {

                        if (prodxbod.pr_stock <= 0)
                        {
                            MessageBox.Show("No hay stock en bodega, por favor verifique");

                        }
                        else if (prod.pr_ManejaSeries == "S")
                        {
                            MessageBox.Show("Utilize el botón indicado para buscar Productos con Códigos de Barra");

                        }
                        else
                        {
                            if (verificarrepetidos("", prod.IdProducto, 0, false))
                            {
                                row = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                                row.IdProducto = prod.IdProducto;
                                row.dm_cantidad = 1;
                                row.check = true; // utilizo para verificar en el evento cellvaluechanged
                                row.CodigoBarra = "PROD SIN CB";
                                insertariconos(row);
                                row.Secuencia = ++secuencia;

                                ListaBind.Add(row);
                            }

                        }

                    }
                    else if (tipomov == "+")
                    {
                        if (prod.pr_ManejaSeries == "N")
                        {
                            if (verificarrepetidos("", prod.IdProducto, 0, false))
                            {
                                row = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                                row.IdProducto = prod.IdProducto;
                                row.dm_cantidad = 0;
                                row.check = true; // utilizo para verificar en el evento cellvaluechanged
                                row.CodigoBarra = "PROD SIN CB";
                                insertariconos(row);
                                row.Secuencia = ++secuencia;
                                ListaBind.Add(row);
                            }
                        }
                        else
                        {
                            row = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            row.IdProducto = prod.IdProducto;
                            row.dm_cantidad = 1;
                            row.check = true; // utilizo para verificar en el evento cellvaluechanged
                            row.CodigoBarra = "";
                            insertariconos(row);
                            row.Secuencia = ++secuencia;
                            ListaBind.Add(row);

                        }


                    }
                }

            }
            #endregion
            else if (e.Column.Name == "colIcoProdNuevo")//actualiza no hace uno nuevo
            #region
            {
                // row = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                var row = (in_movi_inve_detalle_x_Producto_CusCider_Info)gridViewAjustes.GetFocusedRow();
                //Productoinfo.IdProducto = Convert.ToDecimal(row.IdProducto);
                if (row == null)
                    return;

                if (row.IdProducto == 0)
                    return;

                var Productoinfo = busProd.Get_Info_BuscarProducto(row.IdProducto, param.IdEmpresa);
                FrmIn_Producto_Mant oFrmMantPro = new FrmIn_Producto_Mant();
                oFrmMantPro.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                oFrmMantPro.set_Info_producto(Productoinfo);
                oFrmMantPro.ShowDialog();



            }
            #endregion
            else if (e.Column.Name == "colIcoCodBarra")
            #region
            {
                if (tipomov == "-")
                {
                    FrmIn_CodigoBarra_Busqueda frm = new FrmIn_CodigoBarra_Busqueda();
                    frm.loadproducto(Convert.ToInt32(UCSucBod.cmb_sucursal.EditValue), Convert.ToInt32(UCSucBod.cmb_bodega.EditValue));
                    frm.ShowDialog();

                    var prod_CB = frm.Prod_CB;
                    if (prod_CB != null)
                    {
                        if (verificarrepetidos(prod_CB.CodigoBarra, 0, 0, false))
                        {
                            row = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                            row.IdProducto = prod_CB.IdProducto;
                            row.dm_cantidad = 1;
                            row.CodigoBarra = prod_CB.CodigoBarra;
                            row.check = true;// utilizo para verificar en el evento cellvaluechanged
                            insertariconos(row);
                            row.Secuencia = ++secuencia;
                            ListaBind.Add(row);
                        }

                    }


                    #region NO REQUIERO VERIFICAR STOCK YA LO HAGO EN LA PANTALLA CODIGOBARRA_BUSQUEDA
                    //var prod = busProd.Get_Info_BuscarProducto(prod_CB.IdProducto, param.IdEmpresa);
                    //var prodxbod = busProdxBod.ObtenerObjeto(param.IdEmpresa, Convert.ToInt32(UCSucBod.cmb_sucursal.SelectedValue), Convert.ToInt32(UCSucBod.cmb_bodega.SelectedValue), prod.IdProducto);
                    //if (prod.pr_ManejaSeries == "N")
                    //{
                    //    MessageBox.Show("Utilize el botón indicado para buscar Productos sin Codigos de Barra");
                    //    return;
                    //}

                    //{
                    //    //validar si hay stock del producto con CB ValidarProdxCodBarra esta funcion retorna un List<in_movi_inve_detalle_Info> y recibe como parametros tambien List<in_movi_inve_detalle_Info> por ello la sig conversión

                    //    List<in_movi_inve_detalle_Info> listaverif = new List<in_movi_inve_detalle_Info>();
                    //    in_movi_inve_detalle_Info prodverif = new in_movi_inve_detalle_Info();
                    //    prodverif.IdEmpresa = param.IdEmpresa; 
                    //    prodverif.IdSucursal = Convert.ToInt32(UCSucBod.cmb_sucursal.SelectedValue); 
                    //    prodverif.IdBodega = Convert.ToInt32(UCSucBod.cmb_bodega.SelectedValue);
                    //    prodverif.IdProducto = prod.IdProducto;
                    //    listaverif.Add(prodverif);
                    //    var listadoverif = BusCodBAr.ValidarProdxCodBarra(listaverif);
                    //    if((listadoverif.Count==0) || (listadoverif[0].valida == false))
                    //    {
                    //        MessageBox.Show("No hay stock en bodega, por favor verifique");
                    //        return;
                    //    }
                    //}

                    //if (prodxbod.pr_stock <= 0)
                    //{
                    //    MessageBox.Show("No hay stock en bodega, por favor verifique");

                    //}

                    //else
                    //{

                    //}


                    //frm.Event_FrmIn_CodigoBarra_Busqueda_FormClosing += frm_Event_FrmIn_CodigoBarra_Busqueda_FormClosing;
                    #endregion
                }
                else
                    MessageBox.Show("Botón Activado solo para Egresos de Inventario");


            }
            #endregion
        }

    

    
    }
}

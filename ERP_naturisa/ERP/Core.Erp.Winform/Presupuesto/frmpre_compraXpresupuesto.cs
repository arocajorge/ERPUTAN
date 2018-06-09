using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Presupuesto;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Presupuesto
{
    public partial class frmpre_compraXpresupuesto : Form
    {
        public frmpre_compraXpresupuesto()
        {
            try
            {
                InitializeComponent();
                searchLookUpEdit_Prove1.Properties.DataSource = proveedorB.Get_List_proveedor(param.IdEmpresa);
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        string motiAnulacion="";
        cp_proveedor_Bus proveedorB = new cp_proveedor_Bus();
        pre_PedidoXPresupuesto_det_Bus pedido_B = new pre_PedidoXPresupuesto_det_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<pre_PedidoXPresupuesto_det_Info> lstPedidoDet = new List<pre_PedidoXPresupuesto_det_Info>();
        List<pre_ordencompra_local_det_Info> lstOC_det = new List<pre_ordencompra_local_det_Info>();
        pre_ordencompra_local_Info PedidoOC_I = new pre_ordencompra_local_Info();
        pre_ordencompra_local_Bus PedidoOC_B = new pre_ordencompra_local_Bus();
        List<pre_ordencompra_local_det_Info> LstPedidoOC_det = new List<pre_ordencompra_local_det_Info>();
        List<pre_ordencompra_local_det_Info> lstAcumuladorOC = new List<pre_ordencompra_local_det_Info>();
        private Cl_Enumeradores.eTipo_action _Accion;
        pre_PedidoXPresupuesto_det_Bus PedidoDet_B= new pre_PedidoXPresupuesto_det_Bus();
        pre_ordencompra_local_det_Bus OCdet_B = new pre_ordencompra_local_det_Bus();
        decimal IdOCPedido;
        


        private void carga_pedidoDet()
        {
            try
            {
                lstPedidoDet = PedidoDet_B.ObtenerListPedidoDet(param.IdEmpresa,"APR","S");
                foreach (var item in lstPedidoDet)
                {
                    pre_ordencompra_local_det_Info info = new pre_ordencompra_local_det_Info();
                    info.chek = false;
                    info.IdPedidoXPre = item.IdPedidoXPre;
                    info.Secuencia_reg_ped = item.Secuencia_reg;
                    info.IdPresupuesto_pre = item.IdPresupuesto_pre;
                    info.IdAnio_pre = item.IdAnio_pre;
                    info.Secuencia_pre = item.Secuencia_pre;
                    info.Producto = item.Producto;
                    info.do_Cantidad = item.Cant;
                    info.NPresupuesto_pre = item.NPresupuesto_pre;
                    
                    lstOC_det.Add(info);
                }

                gridControl_Pedido.DataSource = lstOC_det;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmpre_compraXpresupuesto_Load(object sender, EventArgs e)
        {
            try
            {
                this.event_frmpre_compraXpresupuesto_FormClosing += new delegate_frmpre_compraXpresupuesto_FormClosing(frmpre_compraXpresupuesto_event_frmpre_compraXpresupuesto_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void frmpre_compraXpresupuesto_event_frmpre_compraXpresupuesto_FormClosing(object sender, FormClosingEventArgs e){}

        private void toolStripButtonSalir_Click(object sender, EventArgs e)
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

        private void gridView_Pedido_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                decimal total = 0;
                decimal Subtotal = 0;
                decimal valorIva = 0;
                var data = gridView_Pedido.GetFocusedRow() as pre_ordencompra_local_det_Info;

               if (e.Column.Name == "coldo_precioCompra")
                {
                    Subtotal = Convert.ToDecimal(gridView_Pedido.GetFocusedRowCellValue(coldo_Cantidad)) * Convert.ToDecimal(gridView_Pedido.GetFocusedRowCellValue(coldo_precioCompra));
                    gridView_Pedido.SetFocusedRowCellValue(coldo_subtotal, Subtotal);
                    valorIva = Subtotal * Convert.ToDecimal(param.iva)/100;
                    gridView_Pedido.SetFocusedRowCellValue(coldo_iva, valorIva);
                }
                else if (e.Column.Name == "coldo_subtotal" || e.Column.Name == "coldo_iva")
                {
                    total = Convert.ToDecimal(gridView_Pedido.GetFocusedRowCellValue(coldo_subtotal)) + Convert.ToDecimal(gridView_Pedido.GetFocusedRowCellValue(coldo_iva));
                    gridView_Pedido.SetFocusedRowCellValue(coldo_total, total);
                }
                else if (e.Column.Name == "coldo_total")
                {
                    if (Convert.ToDecimal(gridView_Pedido.GetFocusedRowCellValue(coldo_total)) > 0)
                    {
                        gridView_Pedido.SetFocusedRowCellValue(colchek, true);

                        for (int i = 0; i < lstAcumuladorOC.Count; i++)
                        {
                            pre_ordencompra_local_det_Info info = lstAcumuladorOC[i];
                            if (info.IdPedidoXPre == data.IdPedidoXPre && info.Secuencia_reg_ped == data.Secuencia_reg_ped && info.IdPresupuesto_pre == data.IdPresupuesto_pre && info.IdPresupuesto_pre == data.IdPresupuesto_pre && info.IdAnio_pre == data.IdAnio_pre && info.Secuencia_pre == data.Secuencia_pre && info.Producto == data.Producto && info.do_Cantidad == data.do_Cantidad && info.NPresupuesto_pre == data.NPresupuesto_pre)
                            {
                                lstAcumuladorOC.Remove(info);
                            }
                        }

                        lstAcumuladorOC.Add(data);
                    }
                    else
                    {
                        gridView_Pedido.SetFocusedRowCellValue(colchek, false);
                        lstAcumuladorOC.Remove(data); ;
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridView_Pedido_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                 if (e.Column.Name == "colchek")
                    {
                        if ((bool)gridView_Pedido.GetFocusedRowCellValue(colchek) == true)
                        {
                            gridView_Pedido.SetFocusedRowCellValue(coldo_precioCompra, 0);
                            gridView_Pedido.SetFocusedRowCellValue(coldo_iva, 0);
                        }
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void set_accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        carga_pedidoDet();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:


                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        btn_grabar.Enabled = false;
                        btn_grabarysalir.Enabled = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        btn_grabar.Enabled = false;
                        btn_grabarysalir.Enabled = false;
                        btnAnular.Enabled = false;

                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private List<pre_ordencompra_local_det_Info> get_PedidoOC_det()
        {
            try
            {
                LstPedidoOC_det.Clear();
                foreach (var item in lstAcumuladorOC)
                {
                    LstPedidoOC_det.Add(item);
                }

                return LstPedidoOC_det;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<pre_ordencompra_local_det_Info>();
            }
        }

        private pre_ordencompra_local_Info get_PedidoOC()
        {
            try
            {
                PedidoOC_I.IdEmpresa=param.IdEmpresa;
                PedidoOC_I.IdSucursal=param.IdSucursal;
                PedidoOC_I.IdOrdenCompra=Convert.ToDecimal(txt_NOC.Text);
                PedidoOC_I.IdProveedor=Convert.ToDecimal(searchLookUpEdit_Prove1.EditValue);
                PedidoOC_I.oc_NumDocumento=txt_NDoc.Text;
                PedidoOC_I.oc_fecha=dtp_fecha.Value;
                PedidoOC_I.oc_observacion=txt_Observacion.Text;
                PedidoOC_I.Estado = (lblanulado.Visible==true)?"I" :"A" ;
                PedidoOC_I.IdEstadoAprobacion="PEN";
                PedidoOC_I.CondicionPago = txt_CondiPago.Text.Trim();
                PedidoOC_I.FormaEnvio = txt_formaEnvio.Text.Trim();
                PedidoOC_I.Fecha_Transac=param.Fecha_Transac;
                PedidoOC_I.Fecha_UltMod=param.Fecha_Transac;
                PedidoOC_I.IdUsuarioUltMod=param.IdUsuario;
                PedidoOC_I.IdUsuarioUltAnu=param.IdUsuario;
                PedidoOC_I.EstadoRecepcion = "PEN";
                PedidoOC_I.IdUsuario = param.IdUsuario;
               // PedidoOC_I.MotivoAnulacion=
               // PedidoOC_I.IdTerminoPago
                // PedidoOC_I.FechaHoraAnul=
                // PedidoOC_I.co_fecha_aprobacion=
                // PedidoOC_I.IdUsuario_Aprueba=
                // PedidoOC_I.IdUsuario_Reprue=
                // PedidoOC_I.co_fechaReproba=

                PedidoOC_I.LstPedidoOC_det=LstPedidoOC_det;

                return PedidoOC_I;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new pre_ordencompra_local_Info();
            }
        }

        public void set_PedidoOC(pre_ordencompra_local_Info info)
        {
            try
            {
                txt_NOC.Text = info.IdOrdenCompra.ToString();
                searchLookUpEdit_Prove1.EditValue=info.IdProveedor;
                txt_NDoc.Text=info.oc_NumDocumento;
                dtp_fecha.Value=info.oc_fecha;
                txt_Observacion.Text = info.oc_observacion;
                lblanulado.Visible = (info.Estado == "I") ? true : false; ;
              //  info.IdEstadoAprobacion = "PEN";
                txt_CondiPago.Text=info.CondicionPago;
                txt_formaEnvio.Text=info.FormaEnvio;
                // PedidoOC_I.MotivoAnulacion=
                // PedidoOC_I.IdTerminoPago
                // PedidoOC_I.FechaHoraAnul=
                // PedidoOC_I.co_fecha_aprobacion=
                // PedidoOC_I.IdUsuario_Aprueba=
                // PedidoOC_I.IdUsuario_Reprue=
                // PedidoOC_I.co_fechaReproba=

               
                //info.LstPedidoOC_det = LstPedidoOC_det;

             PedidoOC_I=info;
             set_PedidoOC_det();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public void set_PedidoOC_det()
        {
            try
            {
                lstOC_det.Clear();
                var lst= OCdet_B.ObtenerLst(PedidoOC_I.IdEmpresa, PedidoOC_I.IdSucursal, PedidoOC_I.IdOrdenCompra);

                foreach (var item in lst)
                {
                    lstOC_det.Add(item);
                    lstAcumuladorOC.Add(item);
                }
                 
                gridControl_Pedido.DataSource = lstOC_det;
                int focus = gridView_Pedido.FocusedRowHandle;
                gridView_Pedido.FocusedRowHandle = focus + 1;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public Boolean valida()
        {
            try
            {
                Boolean estado = true;

                if (searchLookUpEdit_Prove1.EditValue == null || searchLookUpEdit_Prove1.EditValue == "")
                {
                    MessageBox.Show("Antes de Continuar debe Seleccionar el Proveedor   ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txt_NDoc.Text == "")
                {
                    MessageBox.Show("Antes de Continuar ingrese el # Documento ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txt_Observacion.Text == "")
                {
                    MessageBox.Show("Antes de Continuar ingrese la Observación ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                if (lstAcumuladorOC.Count <= 0)
                {
                    MessageBox.Show("No se puede continuar porque no ha seleccionado Productos. Por favor verifiqué eh intente nuevamente  ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                

                return estado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void Grabar()
        {
            try
            {
                txt_Observacion.Focus();
                if (valida())
                {
                    get_PedidoOC_det();
                    get_PedidoOC();
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (PedidoOC_B.GrabarDB(PedidoOC_I, ref IdOCPedido))
                        {
                            txt_NOC.Text = IdOCPedido.ToString();
                            MessageBox.Show("Orden de Compra por Pedido # " + txt_NOC.Text + " Ingresada exitosamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Inconveniente  al realizar la Orden de Compra por Pedido", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        btn_grabar.Enabled = false;
                        btn_grabarysalir.Enabled = false;

                    }
                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (PedidoOC_B.ModificarDB(PedidoOC_I))
                        {
                           
                            MessageBox.Show("Orden de Compra por Pedido # " + txt_NOC.Text + " Modificada exitosamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Inconveniente  al realizar la Modificada Orden de Compra por Pedido", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    }
                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        PedidoOC_I.MotivoAnulacion = motiAnulacion;
                        if (PedidoOC_B.AnularDB(PedidoOC_I))
                        {
                            MessageBox.Show("Orden de Compra por Pedido # " + txt_NOC.Text + " Anulado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblanulado.Visible = true;
                        }
                        else
                            MessageBox.Show("No se pudo Anuladar la Orden de Compra por Pedido # " + txt_NOC.Text, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (valida())
                {
                    Grabar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridControl_Pedido_Click(object sender, EventArgs e){}

        public delegate void delegate_frmpre_compraXpresupuesto_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmpre_compraXpresupuesto_FormClosing event_frmpre_compraXpresupuesto_FormClosing; 

        private void frmpre_compraXpresupuesto_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
             this.event_frmpre_compraXpresupuesto_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                 Grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblanulado.Visible == false)
                {
                    if (MessageBox.Show("¿Está seguro que desea anular Pedido # " + txt_NOC.Text + " ?", "Anulación de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();
                        motiAnulacion = fr.motivoAnulacion;
                        _Accion = Cl_Enumeradores.eTipo_action.Anular;
                        Grabar();
                    }
                }
                else
                {
                    MessageBox.Show("El pedido ya esta Anulada...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }


    }

    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Business.Presupuesto;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
//7/5/2013
namespace Core.Erp.Winform.Presupuesto
{
    public partial class frmpre_pedidoProducto : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<pre_PedidoXPresupuesto_det_Info> lstPediDet = new List<pre_PedidoXPresupuesto_det_Info>();
        List<pre_PedidoXPresupuesto_det_Info> lstPediDet2 = new List<pre_PedidoXPresupuesto_det_Info>();
        private Cl_Enumeradores.eTipo_action _Accion;
        List<ct_Centro_costo_Info> LstCenCos = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Bus _CentroCostoBus = new ct_Centro_costo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ct_Plancta_Bus _PlanCta_bus = new ct_Plancta_Bus();
        List<ct_Plancta_Info> LstCta = new List<ct_Plancta_Info>();
        pre_presupuesto_Bus Presu_B = new pre_presupuesto_Bus();
        pre_PedidoXPresupuesto_Info PediXPre_I = new pre_PedidoXPresupuesto_Info();
        pre_PedidoXPresupuesto_Bus PediXPre_B = new pre_PedidoXPresupuesto_Bus();
        List<pre_presupuesto_Info> LstPresu = new List<pre_presupuesto_Info>();
        cp_proveedor_Bus proveedorB = new cp_proveedor_Bus();
        List<cp_proveedor_Info> LstProveedores = new List<cp_proveedor_Info>();
        List<pre_PedidoXPresupuesto_det_Info> LstPedido_det = new List<pre_PedidoXPresupuesto_det_Info>();
        pre_PedidoXPresupuesto_det_Bus PediXPre_det_B = new pre_PedidoXPresupuesto_det_Bus();

        Dictionary<string, decimal> LstDicPresu = new Dictionary<string, decimal>();
        decimal IdPedidoXPresu;
        string motiAnulacion;
        string MensajeError = "";


        List<pre_PedidoXPresupuesto_det_Info> Lis = new List<pre_PedidoXPresupuesto_det_Info>();
        public delegate void delegate_frmpre_pedidoProducto_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmpre_pedidoProducto_FormClosing event_frmpre_pedidoProducto_FormClosing; 
		

        
        public frmpre_pedidoProducto()
        {
            try
            {
                InitializeComponent();
                LstCta = _PlanCta_bus.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                LstPresu = Presu_B.obtenerList(param.IdEmpresa);
                LstCenCos = _CentroCostoBus.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);

                if (LstPresu != null)
                {
                    (from q in LstPresu select q).ToList().ForEach(tb =>
                    {
                        foreach(var item in LstCta)
                        {
                            if (tb.IdCtaCble == item.IdCtaCble)
                                tb.NPresupuesto = (item.pc_Cuenta2 != null) ? item.pc_Cuenta2.Trim() : "";
                        }

                        foreach(var item in LstCenCos)
                        {
                            if (tb.IdCentroCosto == item.IdCentroCosto)
                                tb.NPresupuesto = tb.NPresupuesto + " / " + ((item.Centro_costo2 != null) ? item.Centro_costo2.Trim() : "");
                        }

                        tb.NPresupuesto = "[Año:" + tb.IdAnio + "] - " + tb.NPresupuesto + " / [" + tb.CodRubro + "]" + tb.NombreRubro;

                        string idCompuesto = tb.IdEmpresa.ToString() + tb.IdPresupuesto + tb.IdAnio + tb.Secuencia;
                        tb.IdPresupuestoCompuesto = Convert.ToDecimal(idCompuesto);
                    });

                    repositoryItemSearchLookUpEdit_Presupuesto.DataSource = LstPresu;
                }

                Carga_Departamento();
                Carga_Proveedor();
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        
        private void Carga_Departamento()
        {
            try
            {
                List<ro_Departamento_Info> depaInfo = new List<ro_Departamento_Info>();
                ro_Departamento_Bus depaBus = new ro_Departamento_Bus();
                depaInfo = depaBus.Get_List_Departamento(param.IdEmpresa);
                searchLookUpEdit_Depart.Properties.DataSource = depaInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Carga_Proveedor()
        {
            try
            {
                LstProveedores = proveedorB.Get_List_proveedor(param.IdEmpresa);
                searchLookUpEdit_Prove1.Properties.DataSource = LstProveedores;
                searchLookUpEdit_Prove2.Properties.DataSource = LstProveedores;
                searchLookUpEdit_Prove3.Properties.DataSource = LstProveedores;
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

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

        private void frmpre_pedidoProducto_Load(object sender, EventArgs e)
        {
            try 
	        {
                this.event_frmpre_pedidoProducto_FormClosing += new delegate_frmpre_pedidoProducto_FormClosing(frmpre_pedidoProducto_event_frmpre_pedidoProducto_FormClosing);
	        }
	        catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
	        }
        }

        void frmpre_pedidoProducto_event_frmpre_pedidoProducto_FormClosing(object sender, FormClosingEventArgs e){}

      
        private void gridView_Pedido_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if(MessageBox.Show("¿Está seguro que desea Eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_Pedido.DeleteSelectedRows();
                    }
                }
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());            
            }
        }

        private void get_pedido_det()
        {
            try
            {
                LstPedido_det.Clear();

                for (int i = 0; i < gridView_Pedido.RowCount; i++)
                {
                    pre_PedidoXPresupuesto_det_Info info = (pre_PedidoXPresupuesto_det_Info)gridView_Pedido.GetRow(i);
                    if (info != null)
                    {
                        info.IdEmpresa = param.IdEmpresa;
                        var pre= LstPresu.First(var => var.IdPresupuestoCompuesto == info.IdPresupuesto_pre);
                        info.IdPresupuesto_pre = pre.IdPresupuesto;
                        info.IdAnio_pre = Convert.ToInt32(pre.IdAnio);
                        info.Secuencia_pre = pre.Secuencia;
                        LstPedido_det.Add(info);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void get_pedido()
        {
            try
            {
                PediXPre_I.IdEmpresa = param.IdEmpresa;
                PediXPre_I.IdPedidoXPre = Convert.ToDecimal(txt_NPedido.Text);
                PediXPre_I.IdDepartamento = (int)this.searchLookUpEdit_Depart.EditValue;
                PediXPre_I.Fecha = dtp_fecha.Value;
                PediXPre_I.Observacion = txt_observacion.Text.Trim();
                PediXPre_I.IdProveedor1 = Convert.ToDecimal(searchLookUpEdit_Prove1.EditValue);
                PediXPre_I.IdProveedor2 = (searchLookUpEdit_Prove2.EditValue == "") ? 0 : Convert.ToDecimal(searchLookUpEdit_Prove2.EditValue);
                PediXPre_I.IdProveedor3 = (searchLookUpEdit_Prove3.EditValue == "") ? 0 : Convert.ToDecimal(searchLookUpEdit_Prove3.EditValue);
                PediXPre_I.IdUsuario = param.IdUsuario;
                PediXPre_I.Fecha_Transac = param.Fecha_Transac;
                PediXPre_I.IdUsuarioUltMod = param.IdUsuario;
                PediXPre_I.Fecha_UltMod = param.Fecha_Transac;
                PediXPre_I.IdUsuarioUltAnu = param.IdUsuario;
                PediXPre_I.Fecha_UltAnu = param.Fecha_Transac;
                PediXPre_I.Lst_PedidoXPre_D = LstPedido_det;
                PediXPre_I.nom_pc = param.nom_pc;
                PediXPre_I.ip = param.ip;
                PediXPre_I.Estado = (lblanulado.Visible == true) ? "I" : "A"; 

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public  void set_pedido(pre_PedidoXPresupuesto_Info info)
        {
            try
            {
                txt_NPedido.Text = info.IdPedidoXPre.ToString();
                searchLookUpEdit_Depart.EditValue=info.IdDepartamento;
                dtp_fecha.Value=info.Fecha;
                txt_observacion.Text=info.Observacion;
                searchLookUpEdit_Prove1.EditValue = info.IdProveedor1;
                searchLookUpEdit_Prove2.EditValue = info.IdProveedor2;
                searchLookUpEdit_Prove3.EditValue = info.IdProveedor3;
                txt_usuario.Text = info.IdUsuario;
                lblanulado.Visible = (info.Estado =="I")?true : false ;

                set_pedido_det(info.IdPedidoXPre);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void set_pedido_det(decimal IdPedidoXPre)
        {
            try
            {
                lstPediDet.Clear();
                lstPediDet = PediXPre_det_B.ObtenerList(param.IdEmpresa, IdPedidoXPre);
             int c = gridView_Pedido.RowCount;
             //  gridControl_Pedido.DataSource = null;
                             //for (int i = 0; i < c; i++){gridView_Pedido.DeleteRow(i);}

             gridView_Pedido.SelectAll();
             gridView_Pedido.DeleteSelectedRows();

            // gridView_Pedido = new DevExpress.XtraGrid.Views.Grid.GridView();

                foreach (var item in lstPediDet)
                {
                    string idCompuesto = item.IdEmpresa.ToString() + item.IdPresupuesto_pre + item.IdAnio_pre + item.Secuencia_pre;
                    gridView_Pedido.AddNewRow();

                    gridView_Pedido.SetFocusedRowCellValue(colIdPresupuesto_pre, idCompuesto);
                    gridView_Pedido.SetFocusedRowCellValue(colProducto, item.Producto);
                    gridView_Pedido.SetFocusedRowCellValue(colCant, item.Cant);
                    gridView_Pedido.SetFocusedRowCellValue(colIdAnio_pre1, item.IdAnio_pre);
                }
                int focus = gridView_Pedido.FocusedRowHandle;
                gridView_Pedido.FocusedRowHandle = focus + 1;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
 
        private bool  Validar()
        {
            try
            {
                if (searchLookUpEdit_Depart.EditValue == null ||searchLookUpEdit_Depart.EditValue =="")
                {
                    MessageBox.Show("Antes de Continuar debe Seleccionar el Departamento  ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (searchLookUpEdit_Prove1.EditValue == null || searchLookUpEdit_Prove1.EditValue == "")
                {
                    MessageBox.Show("Antes de Continuar debe Seleccionar el Proveedor 1  ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if ( txt_observacion.Text == "")
                {
                    MessageBox.Show("Antes de Continuar ingrese la Observación ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (gridView_Pedido.RowCount <= 1)
                {
                    MessageBox.Show("No se puede continuar porque no ha registrado Productos. Por favor verifiqué eh intente nuevamente  ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                for (int i = 0; i < gridView_Pedido.RowCount; i++)
                {
                    pre_PedidoXPresupuesto_det_Info info = (pre_PedidoXPresupuesto_det_Info)gridView_Pedido.GetRow(i);
                    if (info != null)
                    {
                        if (info.Cant <= 0.0)
                        {
                            MessageBox.Show("No se puede continuar porque existen registros con cantidad 0. Por favor verifiqué eh intente nuevamente  ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false  ;
                        }
                        if (info.Producto == "")
                        {
                            MessageBox.Show("No se puede continuar porque existen registros Sin Producto. Por favor verifiqué eh intente nuevamente  ", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
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

                        txt_usuario.Text = param.IdUsuario;
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

        private void Grabar()
        {
            try
            {
                txt_observacion.Focus();
                if (Validar())
                {
                    get_pedido_det();
                    get_pedido();

                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (PediXPre_B.GrabarDB(PediXPre_I, ref IdPedidoXPresu))
                        {
                            txt_NPedido.Text = IdPedidoXPresu.ToString();
                            MessageBox.Show("Pedido # " + IdPedidoXPresu + " Ingresado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.btn_grabar.Enabled = false;
                            btn_grabarysalir.Enabled = false;
                            set_pedido_det(IdPedidoXPresu);
                        }
                        else
                        MessageBox.Show("No se pudo Ingresar el Pedido", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (PediXPre_B.ModificarDB(PediXPre_I))
                        {
                            MessageBox.Show("Pedido # " + txt_NPedido.Text + " Modificado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            set_pedido_det(Convert.ToDecimal(txt_NPedido.Text));
                        }
                        else
                            MessageBox.Show("No se pudo Modificado el Pedido # " + txt_NPedido.Text, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        PediXPre_I.MotivoAnulacion = motiAnulacion;
                        if (PediXPre_B.AnularDB(PediXPre_I))
                        {
                            MessageBox.Show("Pedido # " + txt_NPedido.Text + " Anulado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblanulado.Visible = true;
                        }
                        else
                            MessageBox.Show("No se pudo Anulado el Pedido # " + txt_NPedido.Text, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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

        private void ValidaREgi()
        {
            try
            {
                LstDicPresu.Clear();
                for (int i = 0; i < gridView_Pedido.RowCount; i++)
                {
                    pre_PedidoXPresupuesto_det_Info info = (pre_PedidoXPresupuesto_det_Info)gridView_Pedido.GetRow(i);
                    if (info != null)
                    {
                        string c = info.IdPresupuesto_pre.ToString() + info.Producto;
                        LstDicPresu.Add(c, 1);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("El Registro está repetido, \n Se procedio con su eliminación", "Eliminacion de registro repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gridView_Pedido.DeleteRow(gridView_Pedido.FocusedRowHandle);
            }
        }

      
        
        private void gridView_Pedido_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
              ValidaREgi();
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
                    if (MessageBox.Show("¿Está seguro que desea anular Pedido # " + txt_NPedido.Text + " ?", "Anulación de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        
		
        private void frmpre_pedidoProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                  this.event_frmpre_pedidoProducto_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btn_imprimirChe_Click(object sender, EventArgs e)
        {
            try
            {
                
                pre_PedidoXPresupuesto_Bus ob = new pre_PedidoXPresupuesto_Bus();
                pre_rpt_PedidoXPresupuesto_Info lOg = new pre_rpt_PedidoXPresupuesto_Info();
                List<pre_rpt_PedidoXPresupuesto_Info> lst = new List<pre_rpt_PedidoXPresupuesto_Info>();
                lOg = ob.ObtenerListRpt(param.IdEmpresa,Convert.ToDecimal(this.txt_NPedido.Text));
                lOg.Empresa = param.InfoEmpresa ;
                lst.Add(lOg);
                
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
               ValidaREgi();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void btn_grabarysalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
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

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                 gridView_Pedido.SelectAll();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                gridView_Pedido.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
       

    }
}

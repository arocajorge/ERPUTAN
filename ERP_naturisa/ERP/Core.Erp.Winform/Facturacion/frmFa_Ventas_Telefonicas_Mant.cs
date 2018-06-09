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
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;


namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Ventas_Telefonicas_Mant : Form
    {
        #region DEclaraión de Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private fa_venta_telefonica_Info _Info = new fa_venta_telefonica_Info();
        public Cl_Enumeradores.eTipo_action _Accion { get; set; }
        //Listas
        BindingList<fa_venta_telefonica_det_Info> lstDET = new BindingList<fa_venta_telefonica_det_Info>();
        BindingList<fa_Cliente_Info> lstCliente = new BindingList<fa_Cliente_Info>();
        List<tb_Sucursal_Info> lstSucursal = new List<tb_Sucursal_Info>();
        List<fa_catalogo_Info> lstCatalogo = new List<fa_catalogo_Info>();
        BindingList<in_Producto_Info> lstProdu = new BindingList<in_Producto_Info>();
        //Bus
        fa_venta_telefonica_Bus BusVenta = new fa_venta_telefonica_Bus();
        fa_venta_telefonica_det_Bus busDet = new fa_venta_telefonica_det_Bus();
        fa_Cliente_Bus BusCliente = new fa_Cliente_Bus();
        tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();
        fa_catalogo_Bus BusCatalogo = new fa_catalogo_Bus();
        in_producto_Bus BusProducto = new in_producto_Bus();
        //Otras
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public delegate void delegate_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing Event_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing;
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();
        tb_Bodega_Info info_bodega = new tb_Bodega_Info();
        int CC = 0;
        decimal Id = 0;

        #endregion

        public frmFa_Ventas_Telefonicas_Mant()
        {
            try
            {
              InitializeComponent();
              ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
              ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
              ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
              ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
              ucIn_Sucursal_Bodega1.Event_cmb_bodega_SelectionChangeCommitted += ucIn_Sucursal_Bodega1_Event_cmb_bodega_SelectionChangeCommitted;

              ucIn_Sucursal_Bodega1.Event_cmb_sucursal_SelectionChangeCommitted += ucIn_Sucursal_Bodega1_Event_cmb_sucursal_SelectionChangeCommitted;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnClickGuardar() == true)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                btnClickGuardar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {

            try
            {
                Get();
                if (DialogResult.Yes == MessageBox.Show("Desea Anular este registro", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    BusVenta.AnularDB(_Info);
                    ucGe_Menu.Enabled_bntAnular = false;
                    lbEstado.Text = "   **Anulado**   ";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucIn_Sucursal_Bodega1_Event_cmb_sucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                ChangeCmbSucu();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public frmFa_Ventas_Telefonicas_Mant(Cl_Enumeradores.eTipo_action Numerador)
               : this()
          {
              try
              {
                   enu = Numerador;
              }
              catch (Exception ex)
              {
                  Log_Error_bus.Log_Error(ex.ToString());
              }
          }

        void ucIn_Sucursal_Bodega1_Event_cmb_bodega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                ChangeCmbSucu();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void setInfo(fa_venta_telefonica_Info Info)
        {
            try
            {
                _Info = Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmFa_Ventas_Telefonicas_Mantenimient_Load(object sender, EventArgs e)
        {
            try
            {
                
                dtFecha.EditValue = DateTime.Now;
               
                llenarCmbGrid();
                detalle();
                loader();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void modificarSecuencia()
        {
            try
            {
                for(int i=0; i<lstDET.Count;i++)
                {
                    var item = lstDET[i];
                    if(item.Secuencia != null)
                    item.Secuencia = i + 1;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void dropDownButton1_Click(object sender, EventArgs e){ }

        /// <summary>
        /// Agrega la información a los SearchLookUpEdit 
        /// </summary>
        /// 

        private void llenarCmbGrid()
        {
            try
            {
                //cmbSucursal.Properties.DataSource = lstSucursal = BusSucursal.Obtener_SucursalD(param.IdEmpresa, Cl_Enumeradores.eTipoFiltro.Normal);
                cmbCliente.Properties.DataSource = lstCliente = new BindingList<fa_Cliente_Info>(BusCliente.Get_List_Clientes(param.IdEmpresa));
                cmbMotivo.Properties.DataSource = lstCatalogo = BusCatalogo.Get_List_catalogo(2);
                gridControlVentaFono.DataSource = lstDET;
                lstDET.Add(new fa_venta_telefonica_det_Info { Observacion = "" });

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }
               
        void ChangeCmbSucu()
        {
            try
            {
               // if (Cl_Enumeradores.eTipo_action.grabar == _Accion)
                if (Cl_Enumeradores.eTipo_action.grabar == enu)
                {
                    info_sucursal = new tb_Sucursal_Info();
                    //Obtenemos el objeto info de la sucursal del control
                    info_sucursal = ucIn_Sucursal_Bodega1.get_sucursal();
                                 
                    info_bodega = new tb_Bodega_Info();                  
                    //Obtenemos el objeto info de la bodega del control
                    info_bodega = ucIn_Sucursal_Bodega1.get_bodega();
                }


                if (info_sucursal.IdSucursal != 0 && info_bodega.IdBodega != 0)
                {
                    repositoryCmbProduct.DataSource = lstProdu = new BindingList<in_Producto_Info>(BusProducto.Get_list_Producto(param.IdEmpresa, info_sucursal.IdSucursal, info_bodega.IdBodega));
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }

        private Boolean validar()
        {
            try
            {
                
                if (cmbCliente.EditValue == null || Convert.ToInt32(cmbCliente.EditValue) == 0)
                {
                    MessageBox.Show("Se ha seleccionado el cliente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (cmbMotivo.EditValue == null || cmbMotivo.EditValue.ToString() == "")
                {
                    MessageBox.Show("Se ha seleccionado el motivo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (dtFecha.EditValue == null || dtFecha.Text == "")
                {
                    MessageBox.Show("Se ha seleccionado la fecha", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (txtObservacion.Text == "")
                {
                    MessageBox.Show("Se ha Ingresado la Observación", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (lstDET.ToList().FindAll(var => var.Cantidad == 0).Count > 0)
                {
                    MessageBox.Show("En la Columna de Cantidad hay valores cero", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        Boolean guardarDet()
        {
            try
            {
                foreach(var item in lstDET)
                {
                    item.IdEmpresa = param.IdEmpresa;
                  //  item.IdSucursal = Convert.ToInt32(cmbSucursal.EditValue);
                    item.IdSucursal = _Info.IdSucursal;
                   
                  //  item.IdVenta_tel = Convert.ToDecimal(txtCodigo.Text);
                    item.IdVenta_tel =Id;

                    if (busDet.GuardarDB(item))
                    {
                        CC++;
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
       
        private Boolean Grabar()
        {
            Boolean ret = false;
            try
            {

                gridViewVentaFono.FocusedRowHandle = -1;
               
                if (validar())
                {
                    Get();

                   
                    if (BusVenta.GuardarDB(_Info, ref Id))
                    {
                        if (guardarDet())
                        {
                            MessageBox.Show("Se ha guardado con exito la factura #: " + Id + "", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.txtCodigo.Text = Convert.ToString(Id);
                            bloquear();
                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                            return true;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            return ret;
        }

        private Boolean btnClickGuardar()
        {
            Boolean ret = false;
            try
            {
                //if (Cl_Enumeradores.eTipo_action.grabar == _Accion)
                //{
                //    ret = Grabar();
                //}
                //if (Cl_Enumeradores.eTipo_action.actualizar == _Accion)
                //{
                //    ret = modificar();
                //}

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ret = Grabar();                      
                        break;
                 
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ret = modificar();                     
                        break;                 
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            return ret;
        }

        private Boolean modificar()
        {
            Boolean ret = false;
            try
            {
                txtObservacion.Focus();
                if (validar())
                {
                    Get();
                    if (BusVenta.ModificarDB(_Info))
                    {
                        if (busDet.EliminarDetalle(param.IdEmpresa, _Info.IdSucursal, _Info.IdVenta_tel))
                        {
                            if (busDet.GuardarDB(lstDET.ToList(), param.IdEmpresa, _Info.IdSucursal, _Info.IdVenta_tel))
                            {
                                MessageBox.Show("Se ha modificado con éxito la factura #: " + _Info.IdVenta_tel + " ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ret = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se puede guardar el detalle a ocurrido un error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            return ret;
        }

        private void frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmFa_Ventas_Telefonicas_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void bloquear()
        {
            try
            {
                cmbCliente.Properties.ReadOnly = true;
                cmbMotivo.Properties.ReadOnly = true;
                //cmbSucursal.Properties.ReadOnly = true;

                this.ucIn_Sucursal_Bodega1.Bloquerar_Combos();
               
                gridViewVentaFono.OptionsBehavior.Editable = false;
                checkContactar.Properties.ReadOnly = true;
                txtObservacion.ReadOnly = true;
                txtObservacion.ForeColor = Color.Black;
                txtObservacion.BackColor = Color.White;
                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                ucGe_Menu.Visible_btnGuardar = false;
                dtFecha.Enabled = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        private void loader()
        {
            try
            {
              //  cmbSucursal.EditValue = lstSucursal.First().IdSucursal;
               // switch(_Accion)
                switch(enu)
                { 
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        txtCodigo.Text = _Info.IdVenta_tel.ToString();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Set();
                        bloquear();
                         ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        detalle();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set();
                         ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        cmbCliente.Properties.ReadOnly = true;
                    //    cmbSucursal.Properties.ReadOnly = true;

                        this.ucIn_Sucursal_Bodega1.Bloquerar_Combos();
                        detalle();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntAnular = true;
                        Set();
                        bloquear();
                        break;
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void detalle()
        {
            try
            {
                gridControlVentaFono.DataSource = lstDET = new BindingList<fa_venta_telefonica_det_Info>(busDet.Get_List_venta_telefonica_det(param.IdEmpresa, _Info.IdSucursal, _Info.IdVenta_tel));
                

                lstDET.Add(new fa_venta_telefonica_det_Info { Observacion = "" });
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }

        private void Set()
        {
            try
            {
                txtCodigo.Text = _Info.IdVenta_tel.ToString();
                txtObservacion.Text = _Info.Observacion.Trim();
                cmbCliente.EditValue = _Info.IdCliente;

               // cmbSucursal.EditValue = _Info.IdSucursal;
                info_sucursal = new tb_Sucursal_Info();

                info_sucursal.IdSucursal = _Info.IdSucursal;

                this.ucIn_Sucursal_Bodega1.set_sucursal( info_sucursal);


                cmbMotivo.EditValue = _Info.IdMotivo;
                
                dtFecha.Text = _Info.Fecha.ToShortDateString();
                if (_Info.Contactar_futuro == "S")
                {
                    checkContactar.EditValue = true;
                }
                else
                    checkContactar.EditValue = false;

                if (_Info.Estado != "A")
                {
                    lbEstado.Text = "   **Anulado**   ";
                }

                ChangeCmbSucu();

                info_bodega = new tb_Bodega_Info();
                //Obtenemos el objeto info de la bodega del control
                info_bodega = ucIn_Sucursal_Bodega1.get_bodega();

                if(info_sucursal.IdSucursal !=0 && info_bodega.IdBodega !=0)
                {
                    repositoryCmbProduct.DataSource = lstProdu = new BindingList<in_Producto_Info>(BusProducto.Get_list_Producto(param.IdEmpresa, info_sucursal.IdSucursal, info_bodega.IdBodega));
                
                }

               

                gridControlVentaFono.DataSource = busDet.Get_List_venta_telefonica_det(param.IdEmpresa, _Info.IdSucursal, _Info.IdVenta_tel);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Get()
        {
            try
            {
                _Info.Observacion = txtObservacion.Text.Trim();
                _Info.IdCliente = Convert.ToInt32(cmbCliente.EditValue);

               // _Info.IdSucursal = Convert.ToInt32(cmbSucursal.EditValue);

                _Info.IdSucursal = info_sucursal.IdSucursal;

                _Info.IdMotivo = cmbMotivo.EditValue.ToString();
                _Info.Fecha = Convert.ToDateTime(dtFecha.Text);
                
                if (checkContactar.Checked == true)
                {
                    _Info.Contactar_futuro = "S";
                }
                else
                {
                    _Info.Contactar_futuro = "N";
                }
               // if (Cl_Enumeradores.eTipo_action.grabar == _Accion)
                if (Cl_Enumeradores.eTipo_action.grabar == enu)
                {
                    _Info.IdVenta_tel = Convert.ToDecimal(txtCodigo.Text);
                    _Info.IdEmpresa = param.IdEmpresa;
                    _Info.IdUsuario = param.IdUsuario;
                    _Info.nom_pc = param.nom_pc;
                    _Info.ip = param.ip;
                    _Info.Fecha_Transac = param.Fecha_Transac;
                    _Info.Estado = "A";
                }
                
             //   if (Cl_Enumeradores.eTipo_action.actualizar == _Accion)
                if (Cl_Enumeradores.eTipo_action.actualizar == enu)
                {
                    _Info.IdUsuarioUltMod = param.IdUsuario;
                    _Info.Fecha_UltMod = param.Fecha_Transac;
                }
              //  if (Cl_Enumeradores.eTipo_action.borrar == _Accion)
                if (Cl_Enumeradores.eTipo_action.Anular == enu)
                {
                    _Info.Estado = "I";
                    _Info.Fecha_UltAnu = param.Fecha_Transac;
                    _Info.IdUsuarioUltAnu = param.IdUsuario;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbSucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ChangeCmbSucu();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        private void repositoryCmbProduct_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {

                if (e.NewValue != null)
                {
                    var data = gridViewVentaFono.GetFocusedRow() as fa_venta_telefonica_det_Info;
                    gridViewVentaFono.FocusedColumn = colDescripcion;
                    data.Descripcion = (lstProdu.First(var => var.IdProducto == Convert.ToDecimal(e.NewValue))).pr_descripcion;
                    data.IdProducto = Convert.ToDecimal(e.NewValue);
                    if (data.Secuencia == null)
                    {
                        data.Secuencia = lstDET.Count;
                        data.Cantidad = 0;
                    }
                }
                else
                {
                    var data = gridViewVentaFono.GetFocusedRow() as fa_venta_telefonica_det_Info;
                    lstDET.Remove(data);
                    e.Cancel = true;
                    gridViewVentaFono.FocusedColumn = colDescripcion;
                    modificarSecuencia();
                }

                if (lstDET.Count == 1)
                {
                    lstDET[0].Secuencia = 1;
                }
                

                if(lstDET.ToList().Find(var => var.Secuencia == null) == null)
                {

                    lstDET.Add(new fa_venta_telefonica_det_Info { Observacion = "" });
                }
                
                else
                { 
                    
                }
                gridViewVentaFono.RefreshData();
                    

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewVentaFono_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
              //  if (Cl_Enumeradores.eTipo_action.consultar != _Accion && Cl_Enumeradores.eTipo_action.borrar != _Accion)
                if (Cl_Enumeradores.eTipo_action.consultar != enu && Cl_Enumeradores.eTipo_action.Anular != enu)
                {
                    if (e.KeyCode == System.Windows.Forms.Keys.Delete)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Esta seguro de eliminar el item", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            var data = gridViewVentaFono.GetFocusedRow() as fa_venta_telefonica_det_Info;
                            lstDET.Remove(data);
                            modificarSecuencia();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        //private void btnGrabar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        btnClickGuardar();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}

        //private void btnGrabarySalir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (btnClickGuardar() == true)
        //        {
        //            Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}

        //private void btnAnular_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Get();
        //        if (DialogResult.Yes == MessageBox.Show("Desea Anular este registro", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        //        {
        //            BusVenta.Anular(_Info);
        //            ucGe_Menu.Enabled_bntAnular = false;
        //            lbEstado.Text = "   **Anulado**   ";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}

        //private void btnSalir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Controles
{
    public partial class UCCP_Proveedor_Autoriza : UserControl
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_proveedor_Autorizacion_Bus aut_B = new cp_proveedor_Autorizacion_Bus();
        cp_proveedor_Autorizacion_Info Aut_I = new cp_proveedor_Autorizacion_Info();
        
        public cp_proveedor_Autorizacion_Info OtroFrm_Aut_I { get; set; }

        int c = 0;
        decimal IdProveedorl;
        decimal IdProveedor = 0;


        # region  'delegados'
        public delegate void delegate_gridView_AutoriProvee_DoubleClick(object sender, EventArgs e);
        public event delegate_gridView_AutoriProvee_DoubleClick event_gridView_AutoriProvee_DoubleClick;

        public delegate void delegate_gridView_AutoriProvee_KeyDown(object sender, EventArgs e);
        public event delegate_gridView_AutoriProvee_KeyDown event_gridView_AutoriProvee_KeyDown;

        public delegate void delegate_btn_Seleccionar_Click(object sender, EventArgs e);
        public event delegate_btn_Seleccionar_Click event_btn_Seleccionar_Click;

        public delegate void delegate_btn_Salir_Click(object sender, EventArgs e);
        public event delegate_btn_Salir_Click event_btn_Salir_Click;

        public delegate void delegate_btn_Nuevo_Click(object sender, EventArgs e);
        public event delegate_btn_Nuevo_Click event_btn_Nuevo_Click;
        #endregion


        
        public UCCP_Proveedor_Autoriza()
        {

            try
            {
                InitializeComponent();
                event_gridView_AutoriProvee_DoubleClick += UCCP_Proveedor_Autoriza_event_gridView_AutoriProvee_DoubleClick;
                event_gridView_AutoriProvee_KeyDown += UCCP_Proveedor_Autoriza_event_gridView_AutoriProvee_KeyDown;
                event_btn_Seleccionar_Click += UCCP_Proveedor_Autoriza_event_btn_Seleccionar_Click;
                event_btn_Salir_Click += UCCP_Proveedor_Autoriza_event_btn_Salir_Click;
                event_btn_Nuevo_Click += UCCP_Proveedor_Autoriza_event_btn_Nuevo_Click;
             
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }                                
        }

        void UCCP_Proveedor_Autoriza_event_btn_Nuevo_Click(object sender, EventArgs e)
        {
            
        }

        void UCCP_Proveedor_Autoriza_event_btn_Salir_Click(object sender, EventArgs e)
        {
            
        }

        void UCCP_Proveedor_Autoriza_event_btn_Seleccionar_Click(object sender, EventArgs e)
        {
           
        }

        void UCCP_Proveedor_Autoriza_event_gridView_AutoriProvee_KeyDown(object sender, EventArgs e)
        {
            
        }

        void UCCP_Proveedor_Autoriza_event_gridView_AutoriProvee_DoubleClick(object sender, EventArgs e)
        {
           
        }

        public void set_IdProveedor(decimal IdProvee)
        {
            try
            {
                IdProveedor = IdProvee;
                IdProveedorl = IdProveedor;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
               
            }
        }

        public void btn_selecionar_Visible()
        {
            try
            {
                btn_Seleccionar.Visible = false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        public void btn_Salir_Visible()
        {
            try
            {
                btn_Salir.Visible = false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        private void get()
        {
            try
            {
                for (int i = 0; i < gridView_AutoriProvee.RowCount; i++)
                {
                    if (gridView_AutoriProvee.GetRowCellValue(i, colIdAutorizacion) == null || gridView_AutoriProvee.GetRowCellValue(i, colIdAutorizacion).ToString() == "0")
                    {
                        Aut_I.factura_final = gridView_AutoriProvee.GetRowCellValue(i, colfactura_final).ToString();
                        Aut_I.factura_inicial = gridView_AutoriProvee.GetRowCellValue(i, colfactura_inicial).ToString();
                        Aut_I.IdEmpresa = param.IdEmpresa;
                        Aut_I.IdProveedor = IdProveedorl;
                        Aut_I.nAutorizacion = gridView_AutoriProvee.GetRowCellValue(i, colnAutorizacion).ToString();
                        Aut_I.Serie1 = gridView_AutoriProvee.GetRowCellValue(i, colSerie1).ToString();
                        Aut_I.Serie2 = gridView_AutoriProvee.GetRowCellValue(i, colSerie2).ToString();
                        Aut_I.Valido_Hasta = (DateTime)gridView_AutoriProvee.GetRowCellValue(i, colValido_Hasta);
                        Aut_I.Estado = Convert.ToBoolean(gridView_AutoriProvee.GetRowCellValue(i, Estado));
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Grabar(object sender, EventArgs e)
        {
            try
            {
                int focus = gridView_AutoriProvee.FocusedRowHandle;
                gridView_AutoriProvee.FocusedRowHandle = focus + 1;

                decimal id_autorizacion = 0;

                if (Valida())
                {
                    get();
                    if (aut_B.GrabarDB(Aut_I, ref id_autorizacion))
                    {
                        Aut_I.IdAutorizacion = id_autorizacion;
                        OtroFrm_Aut_I = Aut_I;
                       // this.Close();

                        MessageBox.Show("Autorización # : " + Aut_I .nAutorizacion + "..\nGrabada con Exito.. ", param.Nombre_sistema, MessageBoxButtons.OK);

                        btn_Nuevo.Text = "Nueva Autorización";

                        event_btn_Nuevo_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Por favor verifiqué que los datos estén Completos y vuelva a intentar..\nNo se pudo Grabra.. ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Boolean Valida()
        {
            try
            {
               // textBox1.Focus();

                Boolean r = true;
                for (int i = gridView_AutoriProvee.RowCount - 1; i < gridView_AutoriProvee.RowCount; i++)
                {
                    if (gridView_AutoriProvee.GetRowCellValue(i, colValido_Hasta) == null || gridView_AutoriProvee.GetRowCellValue(i, colnAutorizacion) == null || gridView_AutoriProvee.GetRowCellValue(i, colfactura_inicial) == null || gridView_AutoriProvee.GetRowCellValue(i, colfactura_final) == null || gridView_AutoriProvee.GetRowCellValue(i, colSerie1) == null || gridView_AutoriProvee.GetRowCellValue(i, colSerie2) == null)
                    {
                        MessageBox.Show("Antes de Continuar debe completar los dato de la(s) Autorización ingresadas.. \n Datos de Autorización incompletos..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView_AutoriProvee.Focus(); r = false;
                    }
                    else if (gridView_AutoriProvee.GetRowCellValue(i, colfactura_inicial).ToString().Length != gridView_AutoriProvee.GetRowCellValue(i, colfactura_final).ToString().Length)
                    {
                        MessageBox.Show("El número de digitos de la Factura Inicio no cuadran con el número de digitos de la Factura Fin, modifiquelos por favor ..\n Datos de Autorización inconsistentes..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView_AutoriProvee.Focus(); r = false;
                    }
                    else if (Convert.ToDecimal(gridView_AutoriProvee.GetRowCellValue(i, colfactura_inicial)) > Convert.ToDecimal(gridView_AutoriProvee.GetRowCellValue(i, colfactura_final)))
                    {
                        MessageBox.Show("El número de la Factura Inicio debe ser menor a el número la Factura Fin, modifiquelos por favor ..\n Datos de Autorización inconsistentes..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView_AutoriProvee.Focus(); r = false;
                    }
                    else if (Convert.ToDateTime(gridView_AutoriProvee.GetRowCellValue(i, colValido_Hasta)) < DateTime.Now)
                    {
                        MessageBox.Show("No se puede ingresar una Autorización con una fecha Valido Hasta menor a la fecha Actual..\n Datos de Autorización inconsistentes..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView_AutoriProvee.Focus(); r = false;
                    }
                  //  else if (Convert.ToDecimal(gridView_AutoriProvee.GetRowCellValue(i, colnAutorizacion)) == 0 || gridView_AutoriProvee.GetRowCellValue(i, colnAutorizacion).ToString().Length < 3 || gridView_AutoriProvee.GetRowCellValue(i, colnAutorizacion).ToString().Length > 37)
                    else if ( String.IsNullOrEmpty(Convert.ToString(gridView_AutoriProvee.GetRowCellValue(i, colnAutorizacion)).Trim()))
                    {
                       // MessageBox.Show("El valor # Autorización debe ser solo números.  Mínimo 3 dígitos, máximo 37. Diferente de cero. .. \n Datos de Autorización inconsistentes..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("El valor # Autorización debe ser solo números.  Mínimo 3 dígitos, máximo 37. Diferente de cero. .. \n Datos de Autorización inconsistentes..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView_AutoriProvee.Focus();
                        r = false;
                    }

                    else if (Convert.ToDecimal(gridView_AutoriProvee.GetRowCellValue(i, colnAutorizacion)) == 0 )
                    {
                        // MessageBox.Show("El valor # Autorización debe ser solo números.  Mínimo 3 dígitos, máximo 37. Diferente de cero. .. \n Datos de Autorización inconsistentes..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("El valor # Autorización debe ser solo números.  Mínimo 3 dígitos, máximo 37. Diferente de cero. .. \n Datos de Autorización inconsistentes..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView_AutoriProvee.Focus();
                        r = false;
                    }


                    else if (Convert.ToDecimal(gridView_AutoriProvee.GetRowCellValue(i, colSerie1)) == 0 || Convert.ToDecimal(gridView_AutoriProvee.GetRowCellValue(i, colSerie2)) == 0)
                    {
                        MessageBox.Show("Los # de serie no son correctos se están ingresando valores en 0 . .. \n Datos de Autorización inconsistentes..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        gridView_AutoriProvee.Focus();
                        r = false;
                    }

                    else if (IdProveedorl ==0)
                    {
                        MessageBox.Show("Antes de Continuar debe Grabar el Proveedor.. \n Datos de Autorización incompletos..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        r = false;
                    }
                }
                return r;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                 if (btn_Nuevo.Text == "Grabar")
                {
                    Grabar(sender,e);
                }
                if (c == 0)
                {
                   
                    if(IdProveedorl ==0)
                    {
                        MessageBox.Show("Antes de Continuar debe Grabar el Proveedor.. \n Datos de Autorización incompletos..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    List<cp_proveedor_Autorizacion_Info> Lis = (List<cp_proveedor_Autorizacion_Info>)gridControl_AutoriProvee.DataSource;
                    cp_proveedor_Autorizacion_Info NewItem = new cp_proveedor_Autorizacion_Info();
                    NewItem.Estado = true;
                    NewItem.Valido_Hasta = DateTime.Now.AddMonths(5);
                    Lis.Add(NewItem);
                    gridControl_AutoriProvee.DataSource = null;
                    gridControl_AutoriProvee.DataSource = Lis;
                    c = 1;
                    btn_Nuevo.Text = "Grabar";
                    MessageBox.Show("Después de Ingresar los Datos debe dar Clic en el botón Grabar", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_AutoriProvee_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                 Valida();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_AutoriProvee_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                 OtroFrm_Aut_I = (cp_proveedor_Autorizacion_Info)gridView_AutoriProvee.GetRow(gridView_AutoriProvee.FocusedRowHandle);

                 if (OtroFrm_Aut_I.Estado == false)
                 {
                     MessageBox.Show("El fecha de valides del Número de Autorización seleccionado está caducado. Por Favor Ingrese uno Válido.", param.Nombre_sistema);
                     return;
                 }
                 else
                 {
                     event_gridView_AutoriProvee_DoubleClick(sender, e);
                 }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_AutoriProvee_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                  OtroFrm_Aut_I = (cp_proveedor_Autorizacion_Info)gridView_AutoriProvee.GetRow(e.FocusedRowHandle);
                  if (OtroFrm_Aut_I != null)
                  {

                      if (OtroFrm_Aut_I.IdAutorizacion > 0)
                      {
                          colfactura_final.OptionsColumn.AllowEdit = false;
                          colfactura_inicial.OptionsColumn.AllowEdit = false;
                          colIdAutorizacion.OptionsColumn.AllowEdit = false;
                          colIdEmpresa.OptionsColumn.AllowEdit = false;
                          colIdProveedor.OptionsColumn.AllowEdit = false;
                          colSerie1.OptionsColumn.AllowEdit = false;
                          colSerie2.OptionsColumn.AllowEdit = false;
                          colValido_Hasta.OptionsColumn.AllowEdit = false;
                      }
                      else
                      {
                          colfactura_final.OptionsColumn.AllowEdit = true;
                          colfactura_inicial.OptionsColumn.AllowEdit = true;
                          colIdAutorizacion.OptionsColumn.AllowEdit = true;
                          colIdEmpresa.OptionsColumn.AllowEdit = true;
                          colIdProveedor.OptionsColumn.AllowEdit = true;
                          colSerie1.OptionsColumn.AllowEdit = true;
                          colSerie2.OptionsColumn.AllowEdit = true;
                          colValido_Hasta.OptionsColumn.AllowEdit = true;
                      }
                  }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_AutoriProvee_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                  OtroFrm_Aut_I = (cp_proveedor_Autorizacion_Info)gridView_AutoriProvee.GetRow(e.RowHandle);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_AutoriProvee_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                  var data = gridView_AutoriProvee.GetRow(e.RowHandle) as cp_proveedor_Autorizacion_Info;

                if(data == null)
                    return;
                if(data.Estado == false)
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
               
            }
        }

        private void gridView_AutoriProvee_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (OtroFrm_Aut_I.IdAutorizacion > 0)
                    {
                       // this.Close();

                        event_gridView_AutoriProvee_KeyDown(sender,e);
                    }
                    else
                    {
                        if (btn_Nuevo.Text == "Grabar")
                            MessageBox.Show("Esta Seleccionando una Autorizacion nueva.. Antes de continuar debe dar clic en Grabar..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (OtroFrm_Aut_I.IdAutorizacion > 0)
                {
                    //this.Close();

                    event_btn_Seleccionar_Click(sender,e);
                }
                else
                {
                    if (btn_Nuevo.Text == "Grabar")
                        MessageBox.Show("Esta Seleccionando una Autorizacion nueva.. Antes de continuar debe dar clic en Grabar..", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                OtroFrm_Aut_I = null;
               // this.Close();

                event_btn_Salir_Click(sender,e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCCP_Proveedor_Autoriza_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Autorizacion_x_Proveedor();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
              
            }
        }


        public void Limpiar_Autorizacion_x_Proveedor()
        {

            try
            {
                List<cp_proveedor_Autorizacion_Info> lm = new List<cp_proveedor_Autorizacion_Info>();
                IdProveedorl = 0;
                IdProveedor = 0;
                gridControl_AutoriProvee.DataSource = lm;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Cargar_Autorizacion_x_Proveedor()
        {
            try
            {
                List<cp_proveedor_Autorizacion_Info> lm = aut_B.Get_List_proveedor_Autorizacion(param.IdEmpresa, IdProveedor);
                IdProveedorl = IdProveedor;

                (from q in lm select q).ToList().ForEach(tb => { if (tb.Valido_Hasta > param.Fecha_Transac && tb.Estado == true)tb.Estado = true; else tb.Estado = false; });

                gridControl_AutoriProvee.DataSource = lm;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        private void gridView_AutoriProvee_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                //colfactura_inicial

                if (e.Column.Name == "colfactura_inicial")
                { //validar secuencial factura
                    string secuencia_aux = "";
                    string secuencia = "";

                    string valor_secu = "";
                    valor_secu = Convert.ToString(gridView_AutoriProvee.GetFocusedRowCellValue(colfactura_inicial));

                    if (!String.IsNullOrEmpty(valor_secu))
                    {
                        if (valor_secu.Length < 9)
                        {
                            int conta = valor_secu.Length;
                            int diferencia = 9 - conta;

                            secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                            secuencia = secuencia_aux + valor_secu;

                           

                            gridView_AutoriProvee.SetFocusedRowCellValue(colfactura_inicial, secuencia);
                        }

                    }
                }


                if (e.Column.Name == "colfactura_final")
                { //validar secuencial factura
                    string secuencia_aux = "";
                    string secuencia = "";

                    string valor_secu = "";
                    valor_secu = Convert.ToString(gridView_AutoriProvee.GetFocusedRowCellValue(colfactura_final));

                    if (!String.IsNullOrEmpty(valor_secu))
                    {
                        if (valor_secu.Length < 9)
                        {
                            int conta = valor_secu.Length;
                            int diferencia = 9 - conta;

                            secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                            secuencia = secuencia_aux + valor_secu;



                            gridView_AutoriProvee.SetFocusedRowCellValue(colfactura_final, secuencia);
                        }

                    }
                    
                }
                Aut_I = (cp_proveedor_Autorizacion_Info)gridView_AutoriProvee.GetRow(e.RowHandle);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridControl_AutoriProvee_Click(object sender, EventArgs e)
        {

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valida())
                {
                    int focus = gridView_AutoriProvee.FocusedRowHandle;
                    gridView_AutoriProvee.FocusedRowHandle = focus + 1;

                    if (Aut_I.IdAutorizacion != 0)
                    {
                        if (aut_B.ModificarDB(Aut_I))
                        {
                            MessageBox.Show("Autorización # : " + Aut_I.nAutorizacion + "..\nActualizada con Exito.. ", param.Nombre_sistema, MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Por favor verifiqué que los datos estén Completos y vuelva a intentar..\nNo se pudo Grabra.. ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }        
    }
}

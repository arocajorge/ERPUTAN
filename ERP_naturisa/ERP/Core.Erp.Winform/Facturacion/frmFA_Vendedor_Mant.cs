using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;



namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Vendedor_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje;
        tb_persona_Info persoI = new tb_persona_Info();
        tb_persona_bus PersoB = new tb_persona_bus();
        private fa_Vendedor_Info info = new fa_Vendedor_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Bus bus_sucursales = new tb_Sucursal_Bus();
        tb_Sucursal_Info infoS = new tb_Sucursal_Info();
        tb_Sucursal_Info Sucursal_I { get; set; }
        public List<tb_Sucursal_Info> lista_sucursal = new List<tb_Sucursal_Info>();
        public List<fa_VendedorxSucursal_Info> lm;
        public List<fa_VendedorxSucursal_Info> ListaxVendedor;
        private Cl_Enumeradores.eTipo_action _Accion;
        private int idemp;
        private int id;
        string msg = "";
        BindingList<tb_Sucursal_Info> ListaBind;
        fa_Vendedor_Bus vendedor_bus = new fa_Vendedor_Bus();
        fa_VendedorxSucursal_Bus vendedorxsucursal_bus;
        public delegate void delegate_frmFa_Vendedor_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmFa_Vendedor_Mant_FormClosing event_frmFa_Vendedor_Mant_FormClosing;
        #endregion

        public frmFa_Vendedor_Mant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                event_frmFa_Vendedor_Mant_FormClosing += frmFa_Vendedor_Mant_event_frmFa_Vendedor_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmFa_Vendedor_Mant_event_frmFa_Vendedor_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {                
                if (guardarDatos())
                {
                    this.Close();
                }     
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                guardarDatos(); 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    Anular();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean guardarDatos()
        {
            try
            {
                Boolean bolResult = false;
              string mensaje = "";
              int id_vendedor = 0;

              get_Vendedor();
              

           

              if (validarDatos())
              {
                  get_Lista_Sucursales();
                  switch (_Accion)
                  {
                      case Cl_Enumeradores.eTipo_action.grabar:

                          info.IdUsuario = param.IdUsuario;
                          info.Fecha_Transac = DateTime.Now;

                          if (vendedor_bus.GrabarDB(info, lm, ref id_vendedor, ref mensaje))
                          {
                              bolResult = true;
                              MessageBox.Show("Registro Guardado Exitosamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                              LimpiarDatos();
                          }
                          else {
                              MessageBox.Show("Error " + mensaje, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          }
                          break;

                      case Cl_Enumeradores.eTipo_action.actualizar:

                          info.IdUsuarioUltMod = param.IdUsuario;
                          info.Fecha_UltMod = DateTime.Now;

                          if (vendedor_bus.ModificarDB(info, lm, ref mensaje))
                          {
                              bolResult = true;
                              MessageBox.Show("Registro Actualizado Exitosamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                              //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                              //ucGe_Menu.Visible_btnGuardar = false;
                              LimpiarDatos();
                          }
                          else
                          {
                              MessageBox.Show("Error " + mensaje, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                          }

                          break;
   
                  }
              }
              return bolResult;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
            }
        }

        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                info = new fa_Vendedor_Info();
                lm = new List<fa_VendedorxSucursal_Info>();
                Cargar_Grid();

                this.lbl_id_vendedor.Text = "";
                this.txt_vendedor.Text = "";
                this.txt_comision.Text = "0.00";
                txt_ci_ruc.Text = "";
                chk_estado.Checked = true;
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Cargar_Grid()
        {
            try
            {
                tb_Sucursal_Bus _Sucursal_b = new tb_Sucursal_Bus();

                List<tb_Sucursal_Info> listaSucursal = new List<tb_Sucursal_Info>();
                listaSucursal = _Sucursal_b.Get_List_Sucursal(param.IdEmpresa).FindAll(c => c.Estado == true);
                ListaBind = new BindingList<tb_Sucursal_Info>(listaSucursal);

                gridControlSucursal.DataSource = ListaBind;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmFa_Vendedor_Mant(int IdEmpresa): this()
        {
            try
            {
                Cargar_Grid();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int num_item_sucursal()
        {
            int n = 0;
            #region Codigo anterior

            try
            {

                foreach (var item in ListaBind)
                {
                    if (item.Chek == true)
                    {
                        n++;

                    }
                }

                #region Codigo Anterior
                //for (int i = 0; i < dgSucursal.Rows.Count; i++)
                //{
                //    if (Convert.ToBoolean(this.dgSucursal.Rows[i].Cells[0].Value) == true)
                //    {
                //        n++;
                //    }
                //}
                #endregion


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                n = -1;
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion
            return n;


        }

        Boolean validarDatos()
        {
            try
            {
                if ((String.IsNullOrEmpty(txt_ci_ruc.Text) || String.IsNullOrWhiteSpace(txt_ci_ruc.Text)))
                {
                    MessageBox.Show("Por favor ingrese el numero de cédula.", " SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (this.txt_vendedor.Text == "" || this.txt_vendedor.Text == null)
                {
                    MessageBox.Show("Por favor ingrese el nombre del vendedor", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (this.txt_comision.Text == "" || this.txt_comision.Text == null)
                {
                    MessageBox.Show("Por favor ingrese el porcentaje de la comisión del vendedor", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

               if (num_item_sucursal() <= 0)
               {
                    MessageBox.Show("Debe al menos escoger una sucursal para el vendedor: " + info.Ve_Vendedor, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
               }
             
               return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<fa_VendedorxSucursal_Info> get_Lista_Sucursales()
        {

            try
            {
                lm = new List<fa_VendedorxSucursal_Info>();

                foreach (var item in ListaBind)
                {
                    if (item.Chek == true)
                    {
                        fa_VendedorxSucursal_Info info_sucursal = new fa_VendedorxSucursal_Info();
                        info_sucursal.IdEmpresa = item.IdEmpresa;
                        info_sucursal.IdSucursal = item.IdSucursal;                        
                        lm.Add(info_sucursal);
                    }
                }
                return lm;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<fa_VendedorxSucursal_Info>();
            }


        }

        public void set_Lista_Sucursales()
        {

            try
            {
                fa_VendedorxSucursal_Bus bus_sucursales = new fa_VendedorxSucursal_Bus();

                ListaxVendedor = new List<fa_VendedorxSucursal_Info>();
                ListaxVendedor = bus_sucursales.Get_List_VendedoresxSucursal(idemp, id);


                foreach (var item in ListaBind)
                {
                    foreach (var item2 in ListaxVendedor)
                    {
                        if (item.IdSucursal == item2.IdSucursal)
                        {
                            item.Chek = true;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void iniciar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.actualizar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Anular()
        {
            try
            {
                string mensaje = "";
                if (lblEstado.Visible == true)
                {
                    MessageBox.Show("No se puede Anular Debido a que ya se encuentra Anulado");
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro que desea anular Vendedor ?", "Anulación de Vendedor  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();

                        info.IdUsuarioUltAnu = param.IdUsuario;
                        info.Fecha_UltAnu = DateTime.Now; 
                        info.MotiAnula = ofrm.motivoAnulacion;

                        chk_estado.Checked = false;
                        if (vendedor_bus.AnularDB(info, ref mensaje))
                        {
                            MessageBox.Show("Vendedor # " + info.IdVendedor + " ANULADO SATISFACTORIAMENTE", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblEstado.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean ValidarCedula(string txt_cedulaRucEmpleado)
        {
            // haac 24/09/2013
            tb_persona_bus BusPersona = new tb_persona_bus();

            try
            {

                string variable = (txt_cedulaRucEmpleado).TrimEnd();

                //int variable = Convert.ToInt32((this.txt_cedulaRucEmpleado.Text.Length));
                int cedula = Convert.ToInt32(variable.Length);

                // valida por cedula
                if (cedula != 10)
                {
                    MessageBox.Show("Numero Cedula Invalido");
                    //this.txt_cedulaRucEmpleado.Text = "";

                    return false;
                }
                else
                {
                    try
                    {
                        if ((Convert.ToInt32(txt_cedulaRucEmpleado.Substring(0, 2)) > 25) || (Convert.ToInt32(txt_cedulaRucEmpleado.Substring(2, 1)) > 5))
                        {
                            MessageBox.Show("Numero Cedula Invalido");

                            return false;
                        }
                        if (!BusPersona.Verifica_Ruc(txt_cedulaRucEmpleado, ref msg))
                        {
                            MessageBox.Show("Numero Cedula Invalido");
                            return false;

                        }
                    }
                    catch (Exception ex)
                    {
                        Log_Error_bus.Log_Error(ex.ToString());
                        MessageBox.Show("Numero Cedula Invalido");

                        return false;

                    }

                }
                return true;
            }


            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public fa_Vendedor_Info get_Vendedor()
        {
            try
            {
               
                info = new fa_Vendedor_Info();
                info.IdEmpresa = param.IdEmpresa;
                info.IdVendedor = (this.lbl_id_vendedor.Text == "") ? 0 : Convert.ToInt32(this.lbl_id_vendedor.Text);
                info.Ve_Vendedor = this.txt_vendedor.Text;
                info.Ve_Comision = Convert.ToDouble(this.txt_comision.Text);
                info.ve_cedula = txt_ci_ruc.Text;
                info.Estado = (chk_estado.Checked == true) ? "A" : "I";
                info.IdUsuario = param.IdUsuario;
                info.Fecha_Transac = DateTime.Now;
                info.IdUsuarioUltAnu = param.IdUsuario;
                info.Fecha_UltAnu = DateTime.Now;
                info.IdUsuarioUltMod = param.IdUsuario;
                info.Fecha_UltMod = DateTime.Now;
                info.nom_pc = param.nom_pc;
                info.ip = param.ip;
                return info;
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new fa_Vendedor_Info();
            }
        }

        public void set_Vendedor(fa_Vendedor_Info info_vendedor)
        {
            try
            {
                if (info_vendedor != null)
                {
                    idemp = info_vendedor.IdEmpresa;
                    id = info_vendedor.IdVendedor;

                    this.lbl_id_vendedor.Text = info_vendedor.IdVendedor.ToString();
                    this.txt_vendedor.Text = info_vendedor.Ve_Vendedor;
                    this.txt_comision.Text = info_vendedor.Ve_Comision.ToString();
                    txt_ci_ruc.Text = info_vendedor.ve_cedula;
                    this.chk_estado.Checked = (info_vendedor.Estado == "A") ? true : false;
                    lblEstado.Visible = (info_vendedor.Estado == "I") ? true : false;
                    info = info_vendedor;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_Sucursal(List<tb_Sucursal_Info> lm)
        {
            try
            {
                tb_Empresa_Bus empresa_bus = new tb_Empresa_Bus();
                tb_Sucursal_Bus sucursal_bus = new tb_Sucursal_Bus();
                List<tb_Sucursal_Tabla_Info> lista_tabla = new List<tb_Sucursal_Tabla_Info>();
                List<tb_Empresa_Info> lista_empresa = new List<tb_Empresa_Info>();
                lista_sucursal = sucursal_bus.Get_List_Sucursal(param.IdEmpresa);
                lista_empresa = empresa_bus.Get_List_Empresa();
                if (lista_sucursal != null && lista_empresa != null)
                {
                    var select = from Suc in lista_sucursal
                                 join Emp in lista_empresa on Suc.IdEmpresa equals Emp.IdEmpresa
                                 select new
                                 {
                                     Suc.IdEmpresa,
                                     Suc.IdSucursal,
                                     Suc.Su_Descripcion,
                                     Su_Estado = Suc.Estado,
                                     Emp.em_nombre
                                 };
                    foreach (var item in select)
                    {
                        tb_Sucursal_Tabla_Info info = new tb_Sucursal_Tabla_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.Su_Descripcion = item.Su_Descripcion.Trim();
                        info.Su_Estado = item.Su_Estado;
                        info.em_nombre = item.em_nombre.Trim();
                        lista_tabla.Add(info);
                    }

                    List<tb_Sucursal_Info> listaSucu = new List<tb_Sucursal_Info>();
                    listaSucu = bus_sucursales.Get_List_Sucursal(param.IdEmpresa);
                    ListaBind = new BindingList<tb_Sucursal_Info>(listaSucu);
                    gridControlSucursal.DataSource = ListaBind;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmFA_Vendedor_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                ListaBind = new BindingList<tb_Sucursal_Info>();
                gridControlSucursal.DataSource = ListaBind;


                load_Sucursal(lista_sucursal);
                set_Lista_Sucursales();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        this.chk_estado.Checked = true;
                        this.chk_estado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        txt_ci_ruc.Enabled = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        this.chk_estado.Enabled = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = true;
                        this.chk_estado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        this.txt_vendedor.Enabled = false;
                        this.txt_comision.Enabled = false;
                        this.chk_estado.Enabled = false;
                        this.chk_todos.Enabled = false;
                        //gridControlSucursal.Enabled = false;
                        lblEstado.Visible = (info.Estado == "I") ? true : false;
                        //this.dgSucursal.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_todos_CheckedChanged(object sender, EventArgs e)//comentado
        {

            try
            {
                if (chk_todos.Checked == false)
                    foreach (var item in ListaBind)
                    {
                        item.Chek = false;
                    }
                else
                    foreach (var item in ListaBind)
                    {
                        item.Chek = true;
                    }

                gridControlSucursal.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txt_comision_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.Validanumero_decimal(e.KeyChar, this.txt_comision.Text);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgSucursal_CellContentClick(object sender, DataGridViewCellEventArgs e)//comentado
        {
            #region Cdigo anterior
            try
            {
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

        }

        private void txt_comision_Leave(object sender, EventArgs e)
        {
            try
            {
                Funciones f = new Funciones();
                txt_comision.Text = f.Format_text_2_decimales(txt_comision.Text);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ci_ruc_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                fa_Vendedor_Bus vendedor_bus = new fa_Vendedor_Bus();
                fa_Vendedor_Info info_ven = new fa_Vendedor_Info();
                fa_Vendedor_Bus busvend2 = new fa_Vendedor_Bus();
                bool bandVend = true;
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    if (PersoB.VericarCedulaExiste(txt_ci_ruc.Text.Trim(), ref mensaje) == true)
                    {
                        persoI = PersoB.Get_Info_Persona(txt_ci_ruc.Text.Trim());
                        info_ven = new fa_Vendedor_Info();
                        info_ven.IdEmpresa = param.IdEmpresa;
                        info_ven.ve_cedula = txt_ci_ruc.Text;
                        txt_vendedor.Text = persoI.pe_nombreCompleto;
                        bandVend = busvend2.VerificaSiExisteVendedor(info_ven, ref msg);
                        if (bandVend)
                        {
                            info_ven = busvend2.ConsultarVendedorPorCedula(param.IdEmpresa, txt_ci_ruc.Text);
                            lbl_id_vendedor.Text = info_ven.IdVendedor.ToString();
                            txt_vendedor.Text = info_ven.Ve_Vendedor;

                            idemp = param.IdEmpresa;
                            id = info_ven.IdVendedor;
                            set_Lista_Sucursales();

                            _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                            ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            ucGe_Menu.Visible_btnGuardar = true;
                        }

                    }
                    else
                    {
                                            
                        string msg = "";
                        info_ven = new fa_Vendedor_Info();
                        info_ven.IdEmpresa = param.IdEmpresa;                        
                        info_ven.IdVendedor = (this.lbl_id_vendedor.Text == "") ? 0 : Convert.ToInt32(this.lbl_id_vendedor.Text);
                        info_ven.Ve_Vendedor = this.txt_vendedor.Text;
                        info_ven.Ve_Comision = Convert.ToDouble(this.txt_comision.Text);
                        info_ven.ve_cedula = txt_ci_ruc.Text;
                        info_ven.Estado = (chk_estado.Checked == true) ? "A" : "I";
                        info_ven.IdUsuario = param.IdUsuario;
                        info_ven.Fecha_Transac = DateTime.Now;
                        info_ven.IdUsuarioUltAnu = param.IdUsuario;
                        info_ven.Fecha_UltAnu = DateTime.Now;
                        info_ven.IdUsuarioUltMod = param.IdUsuario;
                        info_ven.Fecha_UltMod = DateTime.Now;
                        info_ven.nom_pc = param.nom_pc;
                        info_ven.ip = param.ip;
                        bandVend = busvend2.VerificaSiExisteVendedor(info_ven, ref msg);

                        if (bandVend == false)
                        {
                            txt_vendedor.Text = "";
                        }
                        else
                        {
                            info_ven = busvend2.ConsultarVendedorPorCedula(param.IdEmpresa, txt_ci_ruc.Text);
                            lbl_id_vendedor.Text = info_ven.IdVendedor.ToString();
                            txt_vendedor.Text = info_ven.Ve_Vendedor;

                            _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                            ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            ucGe_Menu.Visible_btnGuardar = true;
                        }
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ci_ruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.Validanumero_decimal(e.KeyChar, txt_ci_ruc.Text.ToString());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ci_ruc_Leave(object sender, EventArgs e)
        {
            fa_Vendedor_Bus vendedor_bus = new fa_Vendedor_Bus();
            try
            {
                string Mensaje = "";
                tb_persona_bus busPer = new tb_persona_bus();
                if (!busPer.VericarCedulaExiste(txt_ci_ruc.Text, ref Mensaje))
                {
                    fa_Vendedor_Bus busvend = new fa_Vendedor_Bus();
                    fa_Vendedor_Info info_ven = new fa_Vendedor_Info();

                    info_ven = new fa_Vendedor_Info();
                    info_ven.IdEmpresa = param.IdEmpresa;
                    info_ven.IdVendedor = (this.lbl_id_vendedor.Text == "") ? 0 : Convert.ToInt32(this.lbl_id_vendedor.Text);
                    info_ven.Ve_Vendedor = this.txt_vendedor.Text;
                    info_ven.Ve_Comision = Convert.ToDouble(this.txt_comision.Text);
                    info_ven.ve_cedula = txt_ci_ruc.Text;
                    info_ven.Estado = (chk_estado.Checked == true) ? "A" : "I";
                    info_ven.IdUsuario = param.IdUsuario;
                    info_ven.Fecha_Transac = DateTime.Now;
                    info_ven.IdUsuarioUltAnu = param.IdUsuario;
                    info_ven.Fecha_UltAnu = DateTime.Now;
                    info_ven.IdUsuarioUltMod = param.IdUsuario;
                    info_ven.Fecha_UltMod = DateTime.Now;
                    info_ven.nom_pc = param.nom_pc;
                    info_ven.ip = param.ip;

                    if (busvend.VerificaSiExisteVendedor(info_ven, ref Mensaje))
                    {
                        _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                        MessageBox.Show("El Vendedor ya existe se procedera a Modificarlo");
                    }
                    else
                    {
                        _Accion = Cl_Enumeradores.eTipo_action.grabar;
                    }


                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewSucursal_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                infoS = (tb_Sucursal_Info)gridViewSucursal.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewSucursal_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridViewSucursal_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyValue == 13)
                {
                    Sucursal_I = infoS;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewSucursal_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewSucursal.GetRow(e.RowHandle) as tb_Sucursal_Info;
                if (data == null)
                    return;
                if (data.Estado == false)
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewSucursal_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {

                e.HitInfo.Column.FieldName = gridViewSucursal.FocusedColumn.FieldName;

                if (e.HitInfo.Column.FieldName == "Chek")
                {
                    if ((bool)gridViewSucursal.GetFocusedRowCellValue(colChek))
                    {
                        gridViewSucursal.SetFocusedRowCellValue(colChek, false);
                    }
                    else
                    {
                        gridViewSucursal.SetFocusedRowCellValue(colChek, true);
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFa_Vendedor_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmFa_Vendedor_Mant_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

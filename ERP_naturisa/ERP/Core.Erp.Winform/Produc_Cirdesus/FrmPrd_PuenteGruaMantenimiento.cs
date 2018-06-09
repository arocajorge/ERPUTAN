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
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Winform.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;

namespace Core.Erp.Winform.Produc_Cirdesus
{

    /// <summary>
    /// 
    /// </summary>
    public partial class FrmPrd_PuenteGruaMantenimiento : Form
    {
        string MensajeErrorr = "";
        public FrmPrd_PuenteGruaMantenimiento()
        {
            InitializeComponent();
        }

        public int MyProperty { get; set; }



        /// <summary>
        /// //
        /// </summary>
        Cl_Enumeradores.eTipo_action Accion;
        prd_PuenteGrua_Info infoPuenteGrua = new prd_PuenteGrua_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_PuenteGrua_Bus BusPuenteGrua = new prd_PuenteGrua_Bus();
        tb_Empresa_Bus BusEmpresa = new tb_Empresa_Bus();
        tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();
        prd_PuenteGrua_Info Set_Info = new prd_PuenteGrua_Info();
        prd_Operador_Bus BusOperador = new prd_Operador_Bus();


        public delegate void delegate_FrmPrd_PuenteGruaMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmPrd_PuenteGruaMantenimiento_FormClosing event_FrmPrd_PuenteGruaMantenimiento_FormClosing;
      
        public void set_Acccion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {

                Accion = _Accion;


                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       // txtCodigo.Text = Bus_Tip_movi.ObtenerIdObra(ref msg).ToString();
                        get_PuenteGrua();
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtIregistro.Enabled = false;
                       // txtCodigo.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                   
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtIregistro.Enabled = false;
                        txttoneladasSoporta.Enabled = false;
                        txtnombre.Enabled = false;
                        txtmarca.Enabled = false;
                        cmbOperador.Enabled = false;
                        ucGe_Sucursal_combo1.Enabled = false;
                        checkEstado.Enabled = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;


                        break;
                    default:
                        break;
                }



            }
            catch (Exception ex)
            {


            }

        }

        public void set_Info(prd_PuenteGrua_Info Grua)
        {
            try
            {

                

                infoPuenteGrua = new prd_PuenteGrua_Info();

                infoPuenteGrua = Grua;

               
                ucGe_Sucursal_combo1.set_SucursalInfo(infoPuenteGrua.Idsucural);
                txtnombre.Text = infoPuenteGrua.nombre;
                txtmarca.Text = infoPuenteGrua.marca;
                txttoneladasSoporta.Text = infoPuenteGrua.tonelada_Soporta.ToString();
                txtIregistro.Text = Convert.ToString(infoPuenteGrua.idPuenteGrua);
               // infoPuenteGrua.Fecha_Transac = DateTime.Now;
                if (infoPuenteGrua.estado == "A")
                {
                    checkEstado.Checked=true;
                }
                else
                {
                    checkEstado.Checked = false;
                }
                cmbOperador.EditValue = infoPuenteGrua.IdOperador;
                
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());

            }
        }

        public void get_PuenteGrua()
        {
            try
            {


                infoPuenteGrua = new prd_PuenteGrua_Info();
                infoPuenteGrua.idEmpresa = param.IdEmpresa;
                infoPuenteGrua.Idsucural = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                infoPuenteGrua.idPuenteGrua =Convert.ToInt32(txtIregistro.Text);
                infoPuenteGrua.nombre = txtnombre.Text;
                infoPuenteGrua.marca = txtmarca.Text;
                infoPuenteGrua.tonelada_Soporta = Convert.ToInt32(txttoneladasSoporta.Text);
                infoPuenteGrua.Fecha_Transac = DateTime.Now;
                if (checkEstado.Checked == true)
                {
                    infoPuenteGrua.estado = "A";
                }
                else
                {
                    infoPuenteGrua.estado = "I";
                }
                infoPuenteGrua.nom_pc = param.nom_pc;
                infoPuenteGrua.ip = param.ip;
                infoPuenteGrua.IdUsuario = param.IdUsuario;
                infoPuenteGrua.IdOperador =Convert.ToInt32( cmbOperador.EditValue);
                infoPuenteGrua.idEmpresa = param.IdEmpresa;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());

            }
        }

        public void CargarCombos()
        {
            try
            {
                tb_Empresa_Info info = new tb_Empresa_Info();
                info = BusEmpresa.Get_Info_Empresa(param.IdEmpresa);

                List<tb_Empresa_Info> lista=new List<tb_Empresa_Info>();
                lista.Add(info);

                cmbOperador.Properties.DataSource = BusOperador.ListadoOperadores();


            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void FrmPrd_PuenteGruaMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {

                switch (Accion)
                {

                       case Cl_Enumeradores.eTipo_action.consultar:
                       
                       
                        break;

                }
	           CargarCombos();
		
	        }
	       catch (Exception ex)
	        {
		
		        Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
           	}
        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaObjetos())
                    return;
                Grabar();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private Boolean Grabar()
        {
            try
            {

                get_PuenteGrua();
                   
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                           
                             if (BusPuenteGrua.GuardarDB(infoPuenteGrua, ref MensajeErrorr))
                              {
                              MessageBox.Show("Registro Nº " + txtIregistro.Text + " Se Grabo con Exito");
                              return true;
                              }
                              else
                              {
                              MessageBox.Show("Registro Nº " + txtIregistro.Text + " No se puedo Generar");
                              return false;
                              }
                         

                        case Cl_Enumeradores.eTipo_action.actualizar:

                             if (BusPuenteGrua.ModificarDB(infoPuenteGrua, ref MensajeErrorr))
                             {
                                 MessageBox.Show("Registro Nº " + txtIregistro.Text + " Se Grabo con Exito");
                                 return true;
                             }
                             else
                             {
                                 MessageBox.Show("Registro Nº " + txtIregistro.Text + " No se puedo Generar");
                                 return false;
                             }
                        case Cl_Enumeradores.eTipo_action.consultar:
                            //infoObra.Estado = "I";
                            //infoObra.IdUsuarioAnu = param.IdUsuario;
                            //infoObra.FechaAnu = param.Fecha_Transac;
                            //if (Bus_Tip_movi.AnularDB(infoObra, ref msg))
                            //{
                            //    MessageBox.Show("Se ha anulado correctamente la Obra: " + infoObra.Descripcion);
                            //    set_Acccion(Cl_Enumeradores.eTipo_action.consultar);
                            //    set_Info(infoObra); return true;
                            //}
                            //else 


                            return false;
                        default:
                            return false;

                    }


                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.InnerException.ToString()); return false;
            }


        }

        private void FrmPrd_PuenteGruaMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmPrd_PuenteGruaMantenimiento_FormClosing(sender,e);
            }
            catch (Exception EX)
            {
                
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaObjetos())
                    return;
                Grabar();
                this.Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        public void GetId()
        {
            try
            {txtIregistro.Text=Convert.ToString(BusPuenteGrua.GedId(ref MensajeErrorr));

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        public bool ValidaObjetos()
        {
            bool B_Valida = false;
            try
            {
                if (txtIregistro.Text == "")
                {
                    errorPValidaObjetos.SetError(txtIregistro,"No existe un ID");
                    B_Valida = true;
                }

                if (txtmarca.Text == "")
                {
                    errorPValidaObjetos.SetError(txtmarca, "Ingrese Marca");
                    B_Valida = true;
                }
                if (txtnombre.Text == "")
                {
                    errorPValidaObjetos.SetError(txtnombre, "Ingrese Nombre");
                    B_Valida = true;
                }


               



                if (ucGe_Sucursal_combo1.get_SucursalInfo() == null)
                {
                    errorPValidaObjetos.SetError(ucGe_Sucursal_combo1, "Ingrese Sucursal");
                    B_Valida = true;
                }

                if (txttoneladasSoporta.Text == "")
                {
                    errorPValidaObjetos.SetError(txttoneladasSoporta, "Ingrese Tonelada soporte");
                    B_Valida = true;
                }

                return B_Valida;
            }
            catch (Exception)
            {

                return B_Valida;

            }
        }

        private void txttoneladasSoporta_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                MessageBox.Show("Error Caracter no valido");
                txttoneladasSoporta.Text = "";
                return;
                
            }
        }

    }
}

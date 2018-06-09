using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produccion_Talme;
using Core.Erp.Business.General;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Winform.General;
namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_ProgramaProd_Mant : Form
    {
        #region Declaraciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        Cl_Enumeradores.eTipo_action iAccion = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prod_ProgramaProd_Bus Bus_Programa = new prod_ProgramaProd_Bus();
        prod_ProgramaProd_Info Info_Programa = new prod_ProgramaProd_Info();
        List<prod_ProgramaProd_Info> ListaGrabar = new List<prod_ProgramaProd_Info>();
        #endregion

        public frmProd_ProgramaProd_Mant()
        {
            try
            {
                InitializeComponent(); cargacombos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }            
        }

        private void frmProd_ProgramaProd_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                cargacombos();
                event_frmProd_ProgramaProd_Mant_FormClosing += frmProd_ProgramaProd_Mant_event_frmProd_ProgramaProd_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void frmProd_ProgramaProd_Mant_event_frmProd_ProgramaProd_Mant_FormClosing(object sender, FormClosingEventArgs e){}

      
        void cargacombos()
        {
            try
            {
                prod_Turno_Bus bus_turno = new prod_Turno_Bus();
                in_producto_Bus bus_producto = new in_producto_Bus();
                var turnos = bus_turno.ConsultaGeneral(param.IdEmpresa);
                cmbturno.Properties.DataSource = turnos;
               var productos  =bus_producto.Get_list_Producto(param.IdEmpresa);
               cmbproducto.Properties.DataSource = productos;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }      
        }

        public void set(prod_ProgramaProd_Info info)
        {
            try
            {
                Info_Programa = info;
                dtFecha.Value = info.Fecha;
                cmbturno.EditValue = info.IdTurno;
                cmbproducto.EditValue = info.IdProducto;
                txtId.Text = Convert.ToString(info.IdProgramaProd);
                txtUnidad.Text = Convert.ToString(info.Unidad);
                txtPedidos.Text = Convert.ToString(info.Pedidos);
                txtPeso.Text = Convert.ToString(info.Peso);
                txtToneladas.Text = Convert.ToString(info.Toneladas);
                checkBoxEstado.Checked = (info.Estado == "A") ? true : false;
                lbl_inactivo.Visible = (info.Estado == "I") ? true : false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        }

        public void setAccion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                iAccion = Accion;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.consultar:
                        {
                            btn_guardar.Visible = false;
                            btn_guardarysalir.Visible = false;
                            btnAnular.Visible = false;
                            break;
                        }
                    case Cl_Enumeradores.eTipo_action.Anular:
                        {
                            btn_guardar.Visible = false;
                            btn_guardarysalir.Visible = false;
                            btnAnular.Visible = true;
                            break;
                        }                       
                }
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
                 guardar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private Boolean guardar()
        {
            try
            {
                if (validar())
                {
                    if (existerepetidos())
                    {
                        MessageBox.Show("Verifique que el registro a ingresar no exista. No grabo.");
                        return false; }
                    else
                    {
                        switch (iAccion)
                        {
                            case Cl_Enumeradores.eTipo_action.grabar:

                                if (Bus_Programa.GuardarDB(ref Info_Programa))
                                {
                                    MessageBox.Show("Se ha grabado correctamente el Prog de Prod#:" + Info_Programa.IdProgramaProd);
                                    txtId.Text = Convert.ToString(Info_Programa.IdProgramaProd);
                                    setAccion(Cl_Enumeradores.eTipo_action.consultar);
                                    return true;
                                }
                                else return false;


                            case Cl_Enumeradores.eTipo_action.actualizar:
                                if (Bus_Programa.GuardarDB(ref Info_Programa))
                                {
                                    MessageBox.Show("Se ha modificado correctamente el Prog de Prod#:" + Info_Programa.IdProgramaProd);
                                    txtId.Text = Convert.ToString(Info_Programa.IdProgramaProd);
                                    setAccion(Cl_Enumeradores.eTipo_action.consultar); return true;
                                }
                                else return false;

                            default: return false;

                        }
                    }
                }
                else return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }        
        }

        private bool validar()
        {            
            try
            {

                if (Convert.ToInt32 (cmbturno.EditValue)== 0)
                {
                    MessageBox.Show("Por favor ingrese un turno."); cmbturno.Focus(); return false;
                }
                if (Convert.ToInt32(cmbproducto.EditValue) == 0)
                {
                    MessageBox.Show("Por favor ingrese un producto."); cmbproducto.Focus(); return false;
                }
                if (Convert.ToInt32( txtUnidad.Text) <= 0)
                {
                    MessageBox.Show("Por favor ingrese las unidades."); txtUnidad.Focus(); return false;
                }
                if (Convert.ToDecimal( txtPeso.Text )<= 0)
                {
                    MessageBox.Show("Por favor ingrese el peso."); txtUnidad.Focus(); return false;
                }
                if (Convert.ToDecimal(txtToneladas.Text) <= 0)
                {
                    MessageBox.Show("Por favor ingrese las toneladas."); txtUnidad.Focus(); return false;
                }
                if (Convert.ToInt32(txtPedidos .Text) <= 0)
                {
                    MessageBox.Show("Por favor ingrese los pedidos."); txtPedidos.Focus(); return false;
                }
                return get();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private bool get()
        {            
            try
            {
                Info_Programa.Fecha = dtFecha.Value;
                Info_Programa.IdEmpresa = param.IdEmpresa;
                Info_Programa.IdProducto = Convert.ToInt32(cmbproducto.EditValue);
                Info_Programa.IdTurno = Convert.ToInt32(cmbturno.EditValue);
                Info_Programa.Unidad = Convert.ToInt32(txtUnidad.Text);
                Info_Programa.Peso = Convert.ToDecimal(txtPeso.Text);
                Info_Programa.Toneladas = Convert.ToDecimal(txtToneladas.Text);
                Info_Programa.Pedidos = Convert.ToInt32(txtPedidos.Text);
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void btn_guardarysalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardar())
                    this.Close();
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

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
               anular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void anular()
        {
            try
            {
                if (Info_Programa  != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    if (Info_Programa.Estado == "A")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el Programa de Prod#: " + Info_Programa.IdProgramaProd + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                           
                            oFrm.ShowDialog();
                            
                            if (Bus_Programa.AnularDB(Info_Programa))
                            {
                                MessageBox.Show("Anulado con exito el Programa de Prod#: " + Info_Programa.IdProgramaProd);
                                checkBoxEstado.Checked = false;
                                lbl_inactivo.Visible = true;
                                setAccion(Cl_Enumeradores.eTipo_action.consultar);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular Programa de Prod#: " + Info_Programa.IdProgramaProd, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); 
            }
        }
        string msg = "";
        private Boolean existerepetidos()
        {
            try
            {  
                     return (Bus_Programa.VerificarExiste(Info_Programa, ref msg)) ;
             }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Ocurrio un error: " + ex.InnerException); return false;
            }
        
        }
        private void frmProd_ProgramaProd_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmProd_ProgramaProd_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        public delegate void delegate_frmProd_ProgramaProd_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmProd_ProgramaProd_Mant_FormClosing event_frmProd_ProgramaProd_Mant_FormClosing;
       
    }
}

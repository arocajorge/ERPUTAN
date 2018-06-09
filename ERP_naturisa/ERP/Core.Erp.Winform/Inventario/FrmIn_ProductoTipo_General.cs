using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class frmIn_ProductoTipo_General : Form
    {
        public frmIn_ProductoTipo_General()
        {
            try
            {
             InitializeComponent();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<in_ProductoTipo_Info> lm = new List<in_ProductoTipo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_ProductoTipo_Info info = new in_ProductoTipo_Info();

        private void load_ProductoTipo()
        {
            try
            {
                in_ProductoTipo_Bus bus_producto_tipo = new in_ProductoTipo_Bus();
                lm = bus_producto_tipo.Obtener_ProductosTipos(param.IdEmpresa);
               gridControl.DataSource = lm;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private void FrmIn_ProductoTipo_General_Load(object sender, EventArgs e)
        {
            try
            {
                  load_ProductoTipo();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
 
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmIn_ProductoTipo_Mant frm = new frmIn_ProductoTipo_Mant();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                load_ProductoTipo();
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

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView.GetFocusedRow() == null)
                {
                    MessageBox.Show("Seleccione una fila para realizar la respectiva actualización del reguistro", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

               
                    info = gridView.GetFocusedRow() as in_ProductoTipo_Info;
                    if (info != null)
                    {
                        frmIn_ProductoTipo_Mant frm = new frmIn_ProductoTipo_Mant();
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                        frm.set_ProductoTipo(info);
                        frm.ShowDialog();
                        load_ProductoTipo();
                    }
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gridView.GetFocusedRow()==null)
                {
                    MessageBox.Show("Seleccione una fila para realizar la respectiva actualización del reguistro" , "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                
                    info = gridView.GetFocusedRow() as in_ProductoTipo_Info;
                    if (info != null)
                    {
                        frmIn_ProductoTipo_Mant frm = new frmIn_ProductoTipo_Mant();
                        frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.set_ProductoTipo(info);
                        frm.ShowDialog();
                        load_ProductoTipo();
                    }
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            try
            {
                if ((gridView.GetFocusedRow()) == null)
                {
                    MessageBox.Show("Seleccione una fila para realizar la respectiva actualización del reguistro", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                   info = gridView.GetFocusedRow() as in_ProductoTipo_Info;
                    if (info != null)
                    {

                        if (MessageBox.Show("¿Está seguro que desea anular Tipo de Producto: " + info.tp_descripcion + " ?", "Anulación de Tipo de Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (info.Estado == true)
                            {
                                string msg = "";
                                in_ProductoTipo_Bus bus_prod_tipo = new in_ProductoTipo_Bus();
                                info.IdUsuarioUltAnu = param.IdUsuario;
                                info.IdUsuarioUltMod = param.IdUsuario;
                                info.Fecha_UltAnu = DateTime.Now;
                                info.Fecha_UltMod = DateTime.Now;
                                bus_prod_tipo.EliminarDB(info, ref msg);
                                MessageBox.Show(msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                load_ProductoTipo();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo anular el Tipo de Producto: " + info.tp_descripcion + " debido a que ya se encuentra anulado", "Anulación de Tipo de Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                }


                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }

       

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Winform.Inventario;



namespace Core.Erp.Winform.Inventario
{

    public partial class frmIn_MarcaConsulta : Form
    {

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public frmIn_MarcaConsulta()
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

        in_Marca_Info marcaI = new in_Marca_Info();



        private void load_datos()
        {
            try
            {

                in_marca_bus dat_ti = new in_marca_bus();


                this.UlGridMarca.DataSource = dat_ti.Obtener_listMarca(param.IdEmpresa);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }
        }



        private void frmIN_MarcaConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                 load_datos();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void UlGridMarca_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            try
            {
                e.Layout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
                e.Layout.GroupByBox.Prompt = "Arrastre la columna para agrupar ...";
                e.Layout.GroupByBox.Hidden = true;


                e.Layout.Bands[0].Columns[2].AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
                e.Layout.Bands[0].Columns[2].AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
                e.Layout.Bands[0].Columns[2].Width = 250;
            
                UlGridMarca.DisplayLayout.Bands[0].Columns[0].Hidden = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            

        }

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

        private void toolStripButtonModificar_Click(object sender, EventArgs e)
        {
            try
            {
              if (marcaI.IdMarca == 0)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    frmIN_MantMarca frm = new frmIN_MantMarca();
               
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.set_Info(marcaI);
                    frm.ShowDialog();
                    load_datos();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void UlGridMarca_BeforeRowActivate(object sender, Infragistics.Win.UltraWinGrid.RowEventArgs e)
        {
            try
            {
                in_Marca_Info  per = new in_Marca_Info();

                if (e.Row.Index >= 0)
                {
                    marcaI = (in_Marca_Info)e.Row.ListObject;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

              
        }

        private void toolStripButtonConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                   if (marcaI.IdMarca == 0)
                        {
                            MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                        frmIN_MantMarca frm = new frmIN_MantMarca();

                        frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                        frm.set_Info(marcaI);
                        frm.ShowDialog();
                        load_datos();
                        }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        private void toolStripButtonNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmIN_MantMarca frm = new frmIN_MantMarca();

                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
           
                frm.ShowDialog();
                load_datos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void toolStripButtonAnular_Click(object sender, EventArgs e)
        {
            try
            {
             if (marcaI.IdMarca  == 0)
                {
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (marcaI.Estado == "I")
                {
                    MessageBox.Show("No se procedio con la Anulación porque ya esta Anulado", "Informátivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (MessageBox.Show("¿Está seguro que desea anular dicha Marca?", "Anulación de Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmIN_MantMarca  frm = new frmIN_MantMarca();
               
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.borrar);
                    frm.marcaI = marcaI;
                    in_marca_bus MB = new in_marca_bus();
                    if(MB.Anular(marcaI))
                        MessageBox.Show("Anulado ok", "Operación Exitosa");
                    else
                        MessageBox.Show("No se Anulado", "Operación Fallida");

                    //frm.Grabar();
                    load_datos();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }
    }
}

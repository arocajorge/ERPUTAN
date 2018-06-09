using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_Duplica : Form
    {
        string msg = "";
        public string  CodOBra { get; set; }
        public string  descripcion { get; set; }
        public string duplicaSiNo { get; set; }

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        UCPrd_Obra UCObra = new UCPrd_Obra();
        prd_Obra_Bus BusObra = new prd_Obra_Bus();
        List<prd_Obra_Info> info = new List<prd_Obra_Info>();
        public cl_parametrosGenerales_Bus param =  cl_parametrosGenerales_Bus.Instance;
         
       
        public FrmPrd_Duplica()
        {
            try
            {
                InitializeComponent();
                iniciar_controles();
                duplicaSiNo = "N";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void iniciar_controles()
        {
            try
            {
                UCObra.cargaCmb_ObraxProcProd();
                PanelObra.Controls.Add(UCObra);
                UCObra.Dock = DockStyle.Fill;
                UCObra.Event_UCObra_SelectionChanged+= new UCPrd_Obra.delegadoUCObra_SelectionChanged(UCObra_Event_UCObra_SelectionChanged);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }
        void UCObra_Event_UCObra_SelectionChanged(object sender, EventArgs e){ }

       

        private Boolean validar()
        {
            try
            {
                prd_Obra_Info temp = new prd_Obra_Info();
                temp = UCObra.get_item_info();

                if (CodOBra == "")
                {
                    MessageBox.Show("Debe escoger la Obra");
                    return false;
                }
                else if (descripcion == "")
                {
                    MessageBox.Show("Debe ingresar el nombre del Modelo de Producción");
                    return false;
                }
                else if (temp == null)
                {
                    MessageBox.Show("Escoja una Obra");
                    UCObra.cargaCmb_Obra();
                    return false;
                }
                else
                {
                    CodOBra = UCObra.get_item();
                    descripcion = textBox1.Text;

                    return true;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
            


        }
        public void nombrar(string nombre)
        {
            try
            {
              textBox1.Text = nombre;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void  grabar()
        {
            try
            {
                if (validar())
                {
                    duplicaSiNo = "S";
                   
                }
                else
                
                    duplicaSiNo = "N";
                   
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
      

        private void btn_dulpicar_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("¿Esta seguro que desea duplicar el Modelo de Producción?", "Duplicar Modelo Producción", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.grabar();
                    if (duplicaSiNo =="S")
                        this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        
        }

        private void mnu_salir_Click(object sender, EventArgs e)
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

        private void FrmPrd_Duplica_Load(object sender, EventArgs e)
        {
            try
            {
                info = BusObra.ObtenerListaObra(param.IdEmpresa);

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        } 
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;

namespace Core.Erp.Winform.Controles
{
    public partial class UCPrd_Obra : UserControl
    {
        #region declaracion variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public delegate void delegadoUCObra_SelectionChanged(object sender, EventArgs e);
        public event delegadoUCObra_SelectionChanged Event_UCObra_SelectionChanged;

        public delegate void delegadoUCObra_Validating(object sender, CancelEventArgs e);
        public event delegadoUCObra_Validating Event_UCObra_Validating;


        public delegate void delegadoUCObra_EditValueChanged(object sender, EventArgs e);
        public event delegadoUCObra_EditValueChanged Event_UCObra_EditValueChanged;

        public int validating = 0;


       
        //
        prd_Obra_Bus BusOBra = new prd_Obra_Bus();
        prd_ProcesoProductivo_Bus BusMP = new prd_ProcesoProductivo_Bus();
        // aceder a la informacion de la obra publicamente
        public prd_Obra_Info _InfoObra = new prd_Obra_Info();
        public int _IDModProd = 0;
        

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        #endregion
        public UCPrd_Obra()
        {
            try
            {
                InitializeComponent();
                this.Event_UCObra_SelectionChanged += new delegadoUCObra_SelectionChanged(FuncUCObra_SelectionChanged);
                this.Event_UCObra_Validating += new delegadoUCObra_Validating(UCPrd_Obra_Event_UCObra_Validating);
                Event_UCObra_EditValueChanged += UCPrd_Obra_Event_UCObra_EditValueChanged;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }            
        }

        void UCPrd_Obra_Event_UCObra_EditValueChanged(object sender, EventArgs e)
        {
            
        }

      

        void UCPrd_Obra_Event_UCObra_Validating(object sender, CancelEventArgs e){}

         void FuncUCObra_SelectionChanged(object sender, EventArgs e){}


         public void cargaCmb_Obra()
         {
             try
             {
                 UC_Obra.Properties.DataSource = BusOBra.ObtenerListaObra(param.IdEmpresa);

                 UC_Obra.Properties.DisplayMember = "DetalleObra";
                 UC_Obra.Properties.ValueMember = "CodObra";


             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
             }
             
         }
         string msg = "";
         public void cargaCmb_ObraxProcProd()
         {
             try
             {
                 List<prd_Obra_Info> lstobra = new List<prd_Obra_Info>();
                 lstobra =  BusOBra.ObtenerListaObraxPP(param.IdEmpresa, ref msg);
                 lstobra.ForEach(var=> var.DetalleObra = "["+var.CodObra+"] - "+var.Descripcion);
                 UC_Obra.Properties.DataSource = lstobra;
                
             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
             }

         }

        public string get_item()
        {
            try 
	        {
               return UC_Obra.EditValue.ToString();
	        }
	        catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
	        }
        }


        public prd_Obra_Info   get_item_info()
        {
            try
            {

                prd_Obra_Info InfoOBra = new prd_Obra_Info();


                if (UC_Obra.EditValue != null)
                {
                    InfoOBra = (prd_Obra_Info)UC_Obra.Properties.View.GetFocusedRow();
                }
                else
                {
                    return new prd_Obra_Info();
                }

                return InfoOBra;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new prd_Obra_Info();
            }
        }

        public void set_item(string CodObra)
        {
            try 
	        {
                UC_Obra.EditValue = CodObra;
	        }
	        catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
	        }
        }

                     
   

        

        private void UC_Obra_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                _InfoObra = (prd_Obra_Info)UC_Obra.Properties.View.GetFocusedRow();


               this.Event_UCObra_SelectionChanged(sender, e);

                Event_UCObra_EditValueChanged(sender, e);

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

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
    public partial class UCPrd_OrdenTaller : UserControl
    {
       #region declaracion variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public delegate void delegadoUCOrdenTaller_SelectionChanged(object sender, EventArgs e);
        public event delegadoUCOrdenTaller_SelectionChanged Event_UCOrdenTaller_SelectionChanged;

        public delegate void delegadoUCOrdenTaller_Validating(object sender, CancelEventArgs e);
        public event delegadoUCOrdenTaller_Validating Event_UCOrdenTaller_Validating;


        public delegate void delegadoUCOrdenTaller_EditValueChanged(object sender, EventArgs e);
        public event delegadoUCOrdenTaller_EditValueChanged Event_UCOrdenTaller_EditValueChanged;

        public int validating = 0;


       
        //
        prd_OrdenTaller_Bus BusOrdenTaller = new prd_OrdenTaller_Bus();
        prd_ProcesoProductivo_Bus BusMP = new prd_ProcesoProductivo_Bus();
        // aceder a la informacion de la obra publicamente
        public prd_OrdenTaller_Info _InfoOrdenTaller = new prd_OrdenTaller_Info();
        public int _IDModProd = 0;
        

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        #endregion
        public UCPrd_OrdenTaller()
        {
            try
            {
                InitializeComponent();
                this.Event_UCOrdenTaller_SelectionChanged += new delegadoUCOrdenTaller_SelectionChanged(FuncUCOrdenTaller_SelectionChanged);
                this.Event_UCOrdenTaller_Validating += new delegadoUCOrdenTaller_Validating(UCPrd_OrdenTaller_Event_UCOrdenTaller_Validating);
                Event_UCOrdenTaller_EditValueChanged += UCPrd_OrdenTaller_Event_UCOrdenTaller_EditValueChanged;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }            
        }

        void UCPrd_OrdenTaller_Event_UCOrdenTaller_EditValueChanged(object sender, EventArgs e)
        {
            
        }

      

        void UCPrd_OrdenTaller_Event_UCOrdenTaller_Validating(object sender, CancelEventArgs e){}

         void FuncUCOrdenTaller_SelectionChanged(object sender, EventArgs e){}


         public void cargaCmb_OrdenTaller()
         {
             try
             {
                 UC_OrdenTaller.Properties.DataSource = BusOrdenTaller.ObtenerListaOT(param.IdEmpresa);

                 UC_OrdenTaller.Properties.DisplayMember = "Codigo";
                 UC_OrdenTaller.Properties.ValueMember = "IdOrdenTaller";


             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
             }
             
         }

         public void cargaCmb_OrdenTaller_x_Obra(string CodObra)
         {
             try
             {
                 UC_OrdenTaller.Properties.DataSource = BusOrdenTaller.ObtenerListaOT_x_Obra(param.IdEmpresa, CodObra);

                 UC_OrdenTaller.Properties.DisplayMember = "Codigo";
                 UC_OrdenTaller.Properties.ValueMember = "IdOrdenTaller";


             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
             }

         }
         string msg = "";
         //public void cargaCmb_OrdenTallerxProcProd()
         //{
         //    try
         //    {
         //        List<prd_OrdenTaller_Info> lstobra = new List<prd_OrdenTaller_Info>();
         //        lstobra =  BusOrdenTaller.ObtenerListaOrdenTallerxPP(param.IdEmpresa, ref msg);
         //        lstobra.ForEach(var=> var.DetalleOrdenTaller = "["+var.CodOrdenTaller+"] - "+var.Descripcion);
         //        UC_OrdenTaller.Properties.DataSource = lstobra;
                
         //    }
         //    catch (Exception ex)
         //    {
         //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
         //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
         //    }

         //}

        public string get_item()
        {
            try 
	        {
               return UC_OrdenTaller.EditValue.ToString();
	        }
	        catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
	        }
        }


        public prd_OrdenTaller_Info   get_item_info()
        {
            try
            {

                prd_OrdenTaller_Info InfoOrdenTaller = new prd_OrdenTaller_Info();


                if (UC_OrdenTaller.EditValue != null)
                {
                    InfoOrdenTaller = (prd_OrdenTaller_Info)UC_OrdenTaller.Properties.View.GetFocusedRow();
                }
                else
                {
                    return new prd_OrdenTaller_Info();
                }

                return InfoOrdenTaller;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new prd_OrdenTaller_Info();
            }
        }

        public void set_item(decimal IdOrdenTaller)
        {
            try 
	        {
                UC_OrdenTaller.EditValue = IdOrdenTaller;
	        }
	        catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
	        }
        }

                     
   

        

        private void UC_OrdenTaller_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                _InfoOrdenTaller = (prd_OrdenTaller_Info)UC_OrdenTaller.Properties.View.GetFocusedRow();


               this.Event_UCOrdenTaller_SelectionChanged(sender, e);

                Event_UCOrdenTaller_EditValueChanged(sender, e);

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

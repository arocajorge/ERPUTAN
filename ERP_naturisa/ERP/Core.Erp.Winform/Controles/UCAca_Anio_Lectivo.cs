using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Winform.ActivoFijo;
using Core.Erp.Info.General;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;

namespace Core.Erp.Winform.Controles
{
    public partial class UCAca_Anio_Lectivo : UserControl
    {
        #region declaracion variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public delegate void delegadoUCAca_Anio_Lectivo_SelectionChanged(object sender, EventArgs e);
        public event delegadoUCAca_Anio_Lectivo_SelectionChanged Event_UCAca_Anio_Lectivo_SelectionChanged;

        public delegate void delegadoUCAca_Anio_Lectivo_Validating(object sender, CancelEventArgs e);
        public event delegadoUCAca_Anio_Lectivo_Validating Event_UCAca_Anio_Lectivo_Validating;


        public delegate void delegadoUCAca_Anio_Lectivo_EditValueChanged(object sender, EventArgs e);
        public event delegadoUCAca_Anio_Lectivo_EditValueChanged Event_UCAca_Anio_Lectivo_EditValueChanged;

        public int validating = 0;


       
        //
        Aca_Anio_Lectivo_Bus BusAnio_Lectivo = new Aca_Anio_Lectivo_Bus();

        //prd_ProcesoProductivo_Bus BusMP = new prd_ProcesoProductivo_Bus();
        // aceder a la informacion de la obra publicamente
        public Aca_Anio_Lectivo_Info _InfoAnio_Lectivo = new Aca_Anio_Lectivo_Info();
      
        public int _IDModProd = 0;
        

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        #endregion
        public UCAca_Anio_Lectivo()
        {
            try
            {
                InitializeComponent();
                this.Event_UCAca_Anio_Lectivo_SelectionChanged += new delegadoUCAca_Anio_Lectivo_SelectionChanged(FuncUCAca_Anio_Lectivo_SelectionChanged);
                this.Event_UCAca_Anio_Lectivo_Validating += new delegadoUCAca_Anio_Lectivo_Validating(UCAca_Anio_Lectivo_Event_UCAca_Anio_Lectivo_Validating);
                Event_UCAca_Anio_Lectivo_EditValueChanged += UCAca_Anio_Lectivo_Event_UCAca_Anio_Lectivo_EditValueChanged;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }            
        }

        void UCAca_Anio_Lectivo_Event_UCAca_Anio_Lectivo_EditValueChanged(object sender, EventArgs e)
        {
            
        }

      

        void UCAca_Anio_Lectivo_Event_UCAca_Anio_Lectivo_Validating(object sender, CancelEventArgs e){}

         void FuncUCAca_Anio_Lectivo_SelectionChanged(object sender, EventArgs e){}


         public void cargaCmb_Anio_Lectivo_Activo()
         {
             //string IdAnioLectivoActivo;
             int IdAnioLectivoActivo = 0 ;

             try
             {
                 UC_Anio_Lectivo.Properties.DataSource = BusAnio_Lectivo.Get_List_Anio_Lectivo(param.IdInstitucion);
                 IdAnioLectivoActivo = BusAnio_Lectivo.Get_IdAnio_Lectivo_Activo(param.IdInstitucion);

                 UC_Anio_Lectivo.Properties.DisplayMember = "Descripcion";
                 UC_Anio_Lectivo.Properties.ValueMember = "IdAnioLectivo";
                 UC_Anio_Lectivo.EditValue = IdAnioLectivoActivo;
                 Enabled(false);
             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
             }
             
         }

        
        //public string get_item()
        //{
        //    try 
        //    {
        //        return UC_Anio_Lectivo.EditValue.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //        return null;
        //    }
        //}

         public int get_item()
         {
             try
             {
                 return Convert.ToInt16(UC_Anio_Lectivo.EditValue.ToString());
             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                 return 0;
             }
         }


        public Aca_Anio_Lectivo_Info   get_item_info()
        {
            try
            {

                Aca_Anio_Lectivo_Info InfoAnio_Lectivo = new Aca_Anio_Lectivo_Info();


                if (UC_Anio_Lectivo.EditValue != null)
                {
                    InfoAnio_Lectivo = (Aca_Anio_Lectivo_Info)UC_Anio_Lectivo.Properties.View.GetFocusedRow();
                }
                else
                {
                    return new Aca_Anio_Lectivo_Info();
                }

                return InfoAnio_Lectivo;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Aca_Anio_Lectivo_Info();
            }
        }

        public void set_item(decimal IdAnioLectivo)
        {
            try 
	        {
                UC_Anio_Lectivo.EditValue = IdAnioLectivo;
	        }
	        catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
	        }
        }

                     
   

        

        private void UC_Anio_Lectivo_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                _InfoAnio_Lectivo = (Aca_Anio_Lectivo_Info)UC_Anio_Lectivo.Properties.View.GetFocusedRow();


               this.Event_UCAca_Anio_Lectivo_SelectionChanged(sender, e);

                Event_UCAca_Anio_Lectivo_EditValueChanged(sender, e);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void UCAca_Anio_Lectivo_Load(object sender, EventArgs e)
        {
            cargaCmb_Anio_Lectivo_Activo();
        }

        private void Enabled(bool estado) 
        {
            UC_Anio_Lectivo.Enabled = estado;
        }
    }
}

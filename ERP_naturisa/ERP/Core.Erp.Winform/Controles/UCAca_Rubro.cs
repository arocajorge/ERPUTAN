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
    public partial class UCAca_Rubro : UserControl
    {
        #region declaracion variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public delegate void delegadoUCRubro_SelectionChanged(object sender, EventArgs e);
        public event delegadoUCRubro_SelectionChanged Event_UCRubro_SelectionChanged;

        public delegate void delegadoUCRubro_Validating(object sender, CancelEventArgs e);
        public event delegadoUCRubro_Validating Event_UCRubro_Validating;


        public delegate void delegadoUCRubro_EditValueChanged(object sender, EventArgs e);
        public event delegadoUCRubro_EditValueChanged Event_UCRubro_EditValueChanged;

        public int validating = 0;


       
        //
        Aca_Rubro_Bus BusRubro = new Aca_Rubro_Bus();
        //prd_ProcesoProductivo_Bus BusMP = new prd_ProcesoProductivo_Bus();
        // aceder a la informacion de la Rubro publicamente
        public Aca_Rubro_Info _InfoRubro = new Aca_Rubro_Info();
        List<Aca_Rubro_Info> ListRubro = new List<Aca_Rubro_Info>();

        public int _IDModProd = 0;
        

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        #endregion
        public UCAca_Rubro()
        {
            try
            {
                InitializeComponent();
                this.Event_UCRubro_SelectionChanged += new delegadoUCRubro_SelectionChanged(FuncUCRubro_SelectionChanged);
                this.Event_UCRubro_Validating += new delegadoUCRubro_Validating(UCAca_Rubro_Event_UCRubro_Validating);
                Event_UCRubro_EditValueChanged += UCAca_Rubro_Event_UCRubro_EditValueChanged;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }            
        }

        void UCAca_Rubro_Event_UCRubro_EditValueChanged(object sender, EventArgs e)
        {
            
        }

      

        void UCAca_Rubro_Event_UCRubro_Validating(object sender, CancelEventArgs e){}

         void FuncUCRubro_SelectionChanged(object sender, EventArgs e){}


         public void cargaCmb_Rubro()
         {
             try
             {
                 UC_Rubro.Properties.DataSource = BusRubro.Get_List_Rubro();

                 UC_Rubro.Properties.DisplayMember = "CodRubro";
                 UC_Rubro.Properties.ValueMember = "IdRubro";


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
               return UC_Rubro.EditValue.ToString();
	        }
	        catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
	        }
        }


        public Aca_Rubro_Info   get_item_info()
        {
            try
            {

                if (UC_Rubro.EditValue != null && UC_Rubro.Text != "")
                {
                    _InfoRubro = (Aca_Rubro_Info)UC_Rubro.Properties.View.GetFocusedRow();
                    if (_InfoRubro == null)
                    {
                        ListRubro = BusRubro.Get_List_Rubro();
                        _InfoRubro = ListRubro.Where(v => v.IdRubro == Convert.ToDecimal(UC_Rubro.EditValue)).FirstOrDefault();
                    }
                }
                else
                {
                    return new Aca_Rubro_Info();
                }

                return _InfoRubro;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Aca_Rubro_Info();
            }
        }

        public void set_item(int IdRubro)
        {
            try 
	        {
                UC_Rubro.EditValue = IdRubro;
                Event_UCRubro_EditValueChanged += UCAca_Rubro_Event_UCRubro_EditValueChanged;
	        }
	        catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
	        }
        }

        private void UCAca_Rubro_EditValueChanged_1(object sender, EventArgs e)
        {
           
               // _InfoRubro = (Aca_Rubro_Info)UC_Rubro.Properties.View.GetFocusedRow();


               //this.Event_UCRubro_SelectionChanged(sender, e);

               // Event_UCRubro_EditValueChanged(sender, e);

                try 
            {
                 _InfoRubro = (Aca_Rubro_Info)UC_Rubro.Properties.View.GetFocusedRow();
                 this.Event_UCRubro_SelectionChanged(sender, e);

                 Event_UCRubro_EditValueChanged(sender, e);

                if (_InfoRubro == null)
                {
                    ListRubro = BusRubro.Get_List_Rubro();
                    _InfoRubro = ListRubro.Where(v => v.IdRubro == Convert.ToDecimal(UC_Rubro.EditValue)).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }



        public void Inicializar_Combo()
        {
            try
            {

                UC_Rubro.EditValue = 0;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void InitializeComponent()
        {
            this.UC_Rubro = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Descripcion_rubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LbRubro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UC_Rubro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // UC_Rubro
            // 
            this.UC_Rubro.Location = new System.Drawing.Point(80, 4);
            this.UC_Rubro.Name = "UC_Rubro";
            this.UC_Rubro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UC_Rubro.Properties.DisplayMember = "CodRubro";
            this.UC_Rubro.Properties.ValueMember = "IdRubro";
            this.UC_Rubro.Properties.View = this.searchLookUpEdit1View;
            this.UC_Rubro.Size = new System.Drawing.Size(364, 20);
            this.UC_Rubro.TabIndex = 0;
            this.UC_Rubro.EditValueChanged += new System.EventHandler(this.UC_Rubro_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdRubro,
            this.CodRubro,
            this.Col_Descripcion_rubro});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // IdRubro
            // 
            this.IdRubro.Caption = "IdRubro";
            this.IdRubro.FieldName = "IdRubro";
            this.IdRubro.Name = "IdRubro";
            this.IdRubro.Visible = true;
            this.IdRubro.VisibleIndex = 0;
            // 
            // CodRubro
            // 
            this.CodRubro.Caption = "CodRubro";
            this.CodRubro.FieldName = "CodRubro";
            this.CodRubro.Name = "CodRubro";
            this.CodRubro.Visible = true;
            this.CodRubro.VisibleIndex = 1;
            // 
            // Col_Descripcion_rubro
            // 
            this.Col_Descripcion_rubro.Caption = "Descripcion Rubro";
            this.Col_Descripcion_rubro.FieldName = "Descripcion_rubro";
            this.Col_Descripcion_rubro.Name = "Col_Descripcion_rubro";
            this.Col_Descripcion_rubro.Visible = true;
            this.Col_Descripcion_rubro.VisibleIndex = 2;
            // 
            // LbRubro
            // 
            this.LbRubro.AutoSize = true;
            this.LbRubro.Location = new System.Drawing.Point(4, 9);
            this.LbRubro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbRubro.Name = "LbRubro";
            this.LbRubro.Size = new System.Drawing.Size(36, 13);
            this.LbRubro.TabIndex = 3;
            this.LbRubro.Text = "Rubro";
            // 
            // UCAca_Rubro
            // 
            this.Controls.Add(this.LbRubro);
            this.Controls.Add(this.UC_Rubro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCAca_Rubro";
            this.Size = new System.Drawing.Size(450, 33);
            ((System.ComponentModel.ISupportInitialize)(this.UC_Rubro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public void Enabled(bool estado) 
        {
            UC_Rubro.Enabled = estado;
        }
        private void UC_Rubro_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                _InfoRubro = (Aca_Rubro_Info)UC_Rubro.Properties.View.GetFocusedRow();
                this.Event_UCRubro_SelectionChanged(sender, e);

                Event_UCRubro_EditValueChanged(sender, e);

                if (_InfoRubro == null)
                {
                    ListRubro = BusRubro.Get_List_Rubro();
                    _InfoRubro = ListRubro.Where(v => v.IdRubro == Convert.ToDecimal(UC_Rubro.EditValue)).FirstOrDefault();
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

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
    public partial class UCAca_Curso : UserControl
    {

       #region declaracion variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public delegate void delegadoUCCurso_SelectionChanged(object sender, EventArgs e);
        public event delegadoUCCurso_SelectionChanged Event_UCCurso_SelectionChanged;

        public delegate void delegadoUCCurso_Validating(object sender, CancelEventArgs e);
        public event delegadoUCCurso_Validating Event_UCCurso_Validating;


        public delegate void delegadoUCCurso_EditValueChanged(object sender, EventArgs e);
        public event delegadoUCCurso_EditValueChanged Event_UCCurso_EditValueChanged;

        public int validating = 0;


       
        //
        Aca_Curso_Bus BusCurso = new Aca_Curso_Bus();
        //prd_ProcesoProductivo_Bus BusMP = new prd_ProcesoProductivo_Bus();
        // aceder a la informacion de la Curso publicamente
        public Aca_Curso_Info _InfoCurso = new Aca_Curso_Info();
        public int _IDModProd = 0;
        

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        #endregion
        public UCAca_Curso()
        {
            try
            {
                InitializeComponent();
                this.Event_UCCurso_SelectionChanged += new delegadoUCCurso_SelectionChanged(FuncUCCurso_SelectionChanged);
                this.Event_UCCurso_Validating += new delegadoUCCurso_Validating(UCAca_Curso_Event_UCCurso_Validating);
                Event_UCCurso_EditValueChanged += UCAca_Curso_Event_UCCurso_EditValueChanged;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }            
        }

        void UCAca_Curso_Event_UCCurso_EditValueChanged(object sender, EventArgs e)
        {
            
        }

      

        void UCAca_Curso_Event_UCCurso_Validating(object sender, CancelEventArgs e){}

         void FuncUCCurso_SelectionChanged(object sender, EventArgs e){}


         public void cargaCmb_Curso()
         {
             try
             {
                 UC_Curso.Properties.DataSource = BusCurso.Get_Lista_Curso(param.IdInstitucion);

                 UC_Curso.Properties.DisplayMember = "DescripcionCurso";
                 UC_Curso.Properties.ValueMember = "IdCurso";


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
               return UC_Curso.EditValue.ToString();
	        }
	        catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
	        }
        }


        public Aca_Curso_Info   get_item_info()
        {
            try
            {

                Aca_Curso_Info InfoCurso = new Aca_Curso_Info();


                if (UC_Curso.EditValue != null)
                {
                    InfoCurso = (Aca_Curso_Info)UC_Curso.Properties.View.GetFocusedRow();
                }
                else
                {
                    return new Aca_Curso_Info();
                }

                return InfoCurso;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new Aca_Curso_Info();
            }
        }

        public void set_item(Int16 IdCurso)
        {
            try 
	        {
                UC_Curso.EditValue = IdCurso;
	        }
	        catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
	        }
        }

        private void UCAca_Curso_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                _InfoCurso = (Aca_Curso_Info)UC_Curso.Properties.View.GetFocusedRow();


               this.Event_UCCurso_SelectionChanged(sender, e);

                Event_UCCurso_EditValueChanged(sender, e);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void InitializeComponent()
        {
            this.UC_Curso = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdCurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodCurso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LbCurso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UC_Curso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // UC_Curso
            // 
            this.UC_Curso.Location = new System.Drawing.Point(80, 4);
            this.UC_Curso.Name = "UC_Curso";
            this.UC_Curso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UC_Curso.Properties.DisplayMember = "Descripcion_cur";
            this.UC_Curso.Properties.ValueMember = "IdCurso";
            this.UC_Curso.Properties.View = this.searchLookUpEdit1View;
            this.UC_Curso.Size = new System.Drawing.Size(364, 22);
            this.UC_Curso.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdCurso,
            this.CodCurso});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // IdCurso
            // 
            this.IdCurso.Caption = "IdCurso";
            this.IdCurso.FieldName = "IdCurso";
            this.IdCurso.Name = "IdCurso";
            this.IdCurso.Visible = true;
            this.IdCurso.VisibleIndex = 0;
            // 
            // CodCurso
            // 
            this.CodCurso.Caption = "Curso";
            this.CodCurso.FieldName = "DescripcionCurso";
            this.CodCurso.Name = "CodCurso";
            this.CodCurso.Visible = true;
            this.CodCurso.VisibleIndex = 1;
            // 
            // LbCurso
            // 
            this.LbCurso.AutoSize = true;
            this.LbCurso.Location = new System.Drawing.Point(4, 9);
            this.LbCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbCurso.Name = "LbCurso";
            this.LbCurso.Size = new System.Drawing.Size(45, 17);
            this.LbCurso.TabIndex = 3;
            this.LbCurso.Text = "Curso";
            // 
            // UCAca_Curso
            // 
            this.Controls.Add(this.LbCurso);
            this.Controls.Add(this.UC_Curso);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCAca_Curso";
            this.Size = new System.Drawing.Size(450, 33);
            ((System.ComponentModel.ISupportInitialize)(this.UC_Curso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

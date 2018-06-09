namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Empleado_Gastos_Personales_Cons_Xml
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControlXmlError = new DevExpress.XtraGrid.GridControl();
            this.roempleadogastospersoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewXmlError = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colError = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRutaArchivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXmlError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roempleadogastospersoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewXmlError)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlXmlError
            // 
            this.gridControlXmlError.DataSource = this.roempleadogastospersoInfoBindingSource;
            this.gridControlXmlError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlXmlError.Location = new System.Drawing.Point(0, 0);
            this.gridControlXmlError.MainView = this.gridViewXmlError;
            this.gridControlXmlError.Name = "gridControlXmlError";
            this.gridControlXmlError.Size = new System.Drawing.Size(836, 171);
            this.gridControlXmlError.TabIndex = 0;
            this.gridControlXmlError.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewXmlError});
            // 
            // roempleadogastospersoInfoBindingSource
            // 
            this.roempleadogastospersoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_empleado_gastos_perso_Info);
            // 
            // gridViewXmlError
            // 
            this.gridViewXmlError.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSecuencia,
            this.colRutaArchivo,
            this.colError});
            this.gridViewXmlError.GridControl = this.gridControlXmlError;
            this.gridViewXmlError.Name = "gridViewXmlError";
            this.gridViewXmlError.OptionsBehavior.Editable = false;
            this.gridViewXmlError.OptionsView.ShowGroupPanel = false;
            // 
            // colSecuencia
            // 
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            this.colSecuencia.Visible = true;
            this.colSecuencia.VisibleIndex = 0;
            this.colSecuencia.Width = 56;
            // 
            // colError
            // 
            this.colError.FieldName = "Error";
            this.colError.Name = "colError";
            this.colError.Visible = true;
            this.colError.VisibleIndex = 2;
            this.colError.Width = 490;
            // 
            // colRutaArchivo
            // 
            this.colRutaArchivo.FieldName = "RutaArchivo";
            this.colRutaArchivo.Name = "colRutaArchivo";
            this.colRutaArchivo.Visible = true;
            this.colRutaArchivo.VisibleIndex = 1;
            this.colRutaArchivo.Width = 272;
            // 
            // frmRo_Empleado_Gastos_Personales_Cons_Xml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 171);
            this.Controls.Add(this.gridControlXmlError);
            this.Name = "frmRo_Empleado_Gastos_Personales_Cons_Xml";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Errores";
            this.Load += new System.EventHandler(this.frmRo_Empleado_Gastos_Personales_Cons_Xml_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXmlError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roempleadogastospersoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewXmlError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlXmlError;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewXmlError;
        private System.Windows.Forms.BindingSource roempleadogastospersoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colError;
        private DevExpress.XtraGrid.Columns.GridColumn colRutaArchivo;
    }
}
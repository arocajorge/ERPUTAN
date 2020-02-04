namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_CausalesdeModificacio_Anulacion
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
            this.cmbMotivo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.facatalogoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogo_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbrebiatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreIngles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facatalogoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.Location = new System.Drawing.Point(71, 9);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMotivo.Properties.DataSource = this.facatalogoInfoBindingSource;
            this.cmbMotivo.Properties.DisplayMember = "Nombre";
            this.cmbMotivo.Properties.ValueMember = "IdCatalogo";
            this.cmbMotivo.Properties.View = this.searchLookUpEdit1View;
            this.cmbMotivo.Size = new System.Drawing.Size(127, 20);
            this.cmbMotivo.TabIndex = 0;
            // 
            // facatalogoInfoBindingSource
            // 
            this.facatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Facturacion.fa_catalogo_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCatalogo,
            this.colIdCatalogo_tipo,
            this.colNombre,
            this.colEstado,
            this.colAbrebiatura,
            this.colNombreIngles,
            this.colOrden,
            this.colIdUsuario,
            this.colIdUsuarioUltMod,
            this.colFechaUltMod,
            this.colnom_pc,
            this.colip});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCatalogo
            // 
            this.colIdCatalogo.FieldName = "IdCatalogo";
            this.colIdCatalogo.Name = "colIdCatalogo";
            // 
            // colIdCatalogo_tipo
            // 
            this.colIdCatalogo_tipo.FieldName = "IdCatalogo_tipo";
            this.colIdCatalogo_tipo.Name = "colIdCatalogo_tipo";
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Descripción";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colAbrebiatura
            // 
            this.colAbrebiatura.FieldName = "Abrebiatura";
            this.colAbrebiatura.Name = "colAbrebiatura";
            // 
            // colNombreIngles
            // 
            this.colNombreIngles.FieldName = "NombreIngles";
            this.colNombreIngles.Name = "colNombreIngles";
            // 
            // colOrden
            // 
            this.colOrden.FieldName = "Orden";
            this.colOrden.Name = "colOrden";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            // 
            // colFechaUltMod
            // 
            this.colFechaUltMod.FieldName = "FechaUltMod";
            this.colFechaUltMod.Name = "colFechaUltMod";
            // 
            // colnom_pc
            // 
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Motivo";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(71, 37);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Aceptar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmFa_CausalesdeModificacio_Anulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 72);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbMotivo);
            this.Name = "frmFa_CausalesdeModificacio_Anulacion";
            this.Text = "Sistemas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFa_CausalesdeModificacio_Anulacion_FormClosing);
            this.Load += new System.EventHandler(this.frmFa_CausalesdeModificacio_Anulacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facatalogoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cmbMotivo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource facatalogoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colAbrebiatura;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreIngles;
        private DevExpress.XtraGrid.Columns.GridColumn colOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
    }
}
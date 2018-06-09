namespace Core.Erp.Winform.Controles
{
    partial class UCFa_FormaPago_x_Factura
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControlFormaPago = new DevExpress.XtraGrid.GridControl();
            this.gridViewFormaPago = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_FormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFormaPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFormaPago)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlFormaPago
            // 
            this.gridControlFormaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFormaPago.Location = new System.Drawing.Point(0, 0);
            this.gridControlFormaPago.MainView = this.gridViewFormaPago;
            this.gridControlFormaPago.Name = "gridControlFormaPago";
            this.gridControlFormaPago.Size = new System.Drawing.Size(282, 318);
            this.gridControlFormaPago.TabIndex = 0;
            this.gridControlFormaPago.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFormaPago});
            // 
            // gridViewFormaPago
            // 
            this.gridViewFormaPago.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheck,
            this.colIdFormaPago,
            this.colnom_FormaPago});
            this.gridViewFormaPago.GridControl = this.gridControlFormaPago;
            this.gridViewFormaPago.Name = "gridViewFormaPago";
            this.gridViewFormaPago.OptionsView.ShowAutoFilterRow = true;
            this.gridViewFormaPago.OptionsView.ShowGroupPanel = false;
            // 
            // colCheck
            // 
            this.colCheck.Caption = "*";
            this.colCheck.FieldName = "Cheked";
            this.colCheck.Name = "colCheck";
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 0;
            this.colCheck.Width = 20;
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.Caption = "IdFormaPago";
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            this.colIdFormaPago.OptionsColumn.AllowEdit = false;
            this.colIdFormaPago.Visible = true;
            this.colIdFormaPago.VisibleIndex = 2;
            this.colIdFormaPago.Width = 28;
            // 
            // colnom_FormaPago
            // 
            this.colnom_FormaPago.Caption = "FormaPago";
            this.colnom_FormaPago.FieldName = "nom_FormaPago";
            this.colnom_FormaPago.Name = "colnom_FormaPago";
            this.colnom_FormaPago.OptionsColumn.AllowEdit = false;
            this.colnom_FormaPago.Visible = true;
            this.colnom_FormaPago.VisibleIndex = 1;
            this.colnom_FormaPago.Width = 216;
            // 
            // UCFa_FormaPago_x_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlFormaPago);
            this.Name = "UCFa_FormaPago_x_Factura";
            this.Size = new System.Drawing.Size(282, 318);
            this.Load += new System.EventHandler(this.UCFa_FormaPago_x_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFormaPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFormaPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlFormaPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_FormaPago;
    }
}

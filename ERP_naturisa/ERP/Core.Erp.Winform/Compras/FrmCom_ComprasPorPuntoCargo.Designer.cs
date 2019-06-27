namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_ComprasPorPuntoCargo
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
            this.gc_consulta = new DevExpress.XtraGrid.GridControl();
            this.gv_consulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_consulta
            // 
            this.gc_consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_consulta.Location = new System.Drawing.Point(0, 0);
            this.gc_consulta.MainView = this.gv_consulta;
            this.gc_consulta.Name = "gc_consulta";
            this.gc_consulta.Size = new System.Drawing.Size(1258, 621);
            this.gc_consulta.TabIndex = 0;
            this.gc_consulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_consulta});
            // 
            // gv_consulta
            // 
            this.gv_consulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gv_consulta.GridControl = this.gc_consulta;
            this.gv_consulta.Name = "gv_consulta";
            this.gv_consulta.OptionsBehavior.ReadOnly = true;
            this.gv_consulta.OptionsView.ShowAutoFilterRow = true;
            this.gv_consulta.OptionsView.ShowFooter = true;
            this.gv_consulta.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "OC";
            this.gridColumn1.FieldName = "Codigo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 123;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "# Pedido";
            this.gridColumn2.FieldName = "IdOrdenPedido";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 78;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Producto";
            this.gridColumn3.FieldName = "producto";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 435;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "U.M";
            this.gridColumn4.FieldName = "Nom_UnidadMedida";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            this.gridColumn4.Width = 117;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cantidad";
            this.gridColumn5.FieldName = "do_Cantidad";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 117;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Precio";
            this.gridColumn6.FieldName = "do_precioCompra";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            this.gridColumn6.Width = 117;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "% Desc";
            this.gridColumn7.FieldName = "do_porc_des";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            this.gridColumn7.Width = 117;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Subtotal";
            this.gridColumn8.FieldName = "do_subtotal";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "do_subtotal", "{0:n2}")});
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 9;
            this.gridColumn8.Width = 139;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Proveedor";
            this.gridColumn9.FieldName = "pe_nombreCompleto";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 360;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Fecha";
            this.gridColumn10.FieldName = "oc_fecha";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            this.gridColumn10.Width = 131;
            // 
            // FrmCom_ComprasPorPuntoCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 621);
            this.Controls.Add(this.gc_consulta);
            this.Name = "FrmCom_ComprasPorPuntoCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras por punto de cargo";
            this.Load += new System.EventHandler(this.FrmCom_ComprasPorPuntoCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_consulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_consulta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}
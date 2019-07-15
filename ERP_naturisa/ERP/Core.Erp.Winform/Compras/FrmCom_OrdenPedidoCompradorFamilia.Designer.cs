namespace Core.Erp.Winform.Compras
{
    partial class FrmCom_OrdenPedidoCompradorFamilia
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
            this.gc_consulta.Size = new System.Drawing.Size(904, 511);
            this.gc_consulta.TabIndex = 1;
            this.gc_consulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_consulta});
            // 
            // gv_consulta
            // 
            this.gv_consulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gv_consulta.GridControl = this.gc_consulta;
            this.gv_consulta.Name = "gv_consulta";
            this.gv_consulta.OptionsBehavior.ReadOnly = true;
            this.gv_consulta.OptionsView.ShowAutoFilterRow = true;
            this.gv_consulta.OptionsView.ShowFooter = true;
            this.gv_consulta.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "# Pedido";
            this.gridColumn1.FieldName = "IdOrdenPedido";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 171;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Familia";
            this.gridColumn2.FieldName = "Familia";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 781;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Comprador";
            this.gridColumn3.FieldName = "Comprador";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 782;
            // 
            // FrmCom_OrdenPedidoCompradorFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 511);
            this.Controls.Add(this.gc_consulta);
            this.Name = "FrmCom_OrdenPedidoCompradorFamilia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compradores por pedido";
            this.Load += new System.EventHandler(this.FrmCom_OrdenPedidoCompradorFamilia_Load);
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
    }
}
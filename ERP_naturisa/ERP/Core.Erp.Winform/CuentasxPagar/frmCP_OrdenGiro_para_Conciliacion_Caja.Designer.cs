namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_OrdenGiro_para_Conciliacion_Caja
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Vaciar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlOrdenGiro = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrdenGiro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdenGiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenGiro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Vaciar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 32);
            this.panel1.TabIndex = 0;
            // 
            // btn_Vaciar
            // 
            this.btn_Vaciar.Location = new System.Drawing.Point(955, 5);
            this.btn_Vaciar.Name = "btn_Vaciar";
            this.btn_Vaciar.Size = new System.Drawing.Size(75, 23);
            this.btn_Vaciar.TabIndex = 0;
            this.btn_Vaciar.Text = "Vaciar";
            this.btn_Vaciar.Click += new System.EventHandler(this.btn_Vaciar_Click);
            // 
            // gridControlOrdenGiro
            // 
            this.gridControlOrdenGiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrdenGiro.Location = new System.Drawing.Point(0, 0);
            this.gridControlOrdenGiro.MainView = this.gridViewOrdenGiro;
            this.gridControlOrdenGiro.Name = "gridControlOrdenGiro";
            this.gridControlOrdenGiro.Size = new System.Drawing.Size(1037, 409);
            this.gridControlOrdenGiro.TabIndex = 1;
            this.gridControlOrdenGiro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrdenGiro});
            // 
            // gridViewOrdenGiro
            // 
            this.gridViewOrdenGiro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridViewOrdenGiro.GridControl = this.gridControlOrdenGiro;
            this.gridViewOrdenGiro.Name = "gridViewOrdenGiro";
            this.gridViewOrdenGiro.OptionsBehavior.Editable = false;
            this.gridViewOrdenGiro.OptionsBehavior.ReadOnly = true;
            this.gridViewOrdenGiro.OptionsView.ShowAutoFilterRow = true;
            this.gridViewOrdenGiro.OptionsView.ShowGroupPanel = false;
            this.gridViewOrdenGiro.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewOrdenGiro_FocusedRowChanged);
            this.gridViewOrdenGiro.DoubleClick += new System.EventHandler(this.gridViewOrdenGiro_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "# Comprobante";
            this.gridColumn1.FieldName = "IdCbteCble_Ogiro";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 83;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tipo comprobante";
            this.gridColumn2.FieldName = "tc_TipoCbte";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 80;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "# Documento";
            this.gridColumn3.FieldName = "co_factura";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 93;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Fecha documento";
            this.gridColumn4.FieldName = "co_FechaFactura";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 106;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Proveedor";
            this.gridColumn5.FieldName = "InfoProveedor.pr_nombre";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 223;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Observación";
            this.gridColumn6.FieldName = "co_observacion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 273;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Subtotal IVA";
            this.gridColumn7.FieldName = "co_subtotal_iva";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 96;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Subtotal sin IVA";
            this.gridColumn8.FieldName = "co_subtotal_siniva";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 96;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Base imponible";
            this.gridColumn9.FieldName = "co_baseImponible";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 130;
            // 
            // frmCP_OrdenGiro_para_Conciliacion_Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 441);
            this.ControlBox = false;
            this.Controls.Add(this.gridControlOrdenGiro);
            this.Controls.Add(this.panel1);
            this.Name = "frmCP_OrdenGiro_para_Conciliacion_Caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCP_OrdenGiro_para_Conciliacion_Caja_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdenGiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrdenGiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlOrdenGiro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrdenGiro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.SimpleButton btn_Vaciar;
    }
}
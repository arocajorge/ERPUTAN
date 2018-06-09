namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_factura_NotaDeb_a_cruzar
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
            this.btnVaciar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlDocs = new DevExpress.XtraGrid.GridControl();
            this.gridViewDocs = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVaciar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 36);
            this.panel1.TabIndex = 0;
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(835, 7);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(75, 23);
            this.btnVaciar.TabIndex = 0;
            this.btnVaciar.Text = "Salir";
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // gridControlDocs
            // 
            this.gridControlDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDocs.Location = new System.Drawing.Point(0, 0);
            this.gridControlDocs.MainView = this.gridViewDocs;
            this.gridControlDocs.Name = "gridControlDocs";
            this.gridControlDocs.Size = new System.Drawing.Size(918, 391);
            this.gridControlDocs.TabIndex = 1;
            this.gridControlDocs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDocs});
            // 
            // gridViewDocs
            // 
            this.gridViewDocs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridViewDocs.GridControl = this.gridControlDocs;
            this.gridViewDocs.GroupCount = 1;
            this.gridViewDocs.GroupFormat = "[#image]{1} {2}";
            this.gridViewDocs.Name = "gridViewDocs";
            this.gridViewDocs.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewDocs.OptionsBehavior.Editable = false;
            this.gridViewDocs.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDocs.OptionsView.ShowGroupPanel = false;
            this.gridViewDocs.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewDocs.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDocs_FocusedRowChanged);
            this.gridViewDocs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewDocs_KeyDown);
            this.gridViewDocs.DoubleClick += new System.EventHandler(this.gridViewDocs_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tipo Documento";
            this.gridColumn1.FieldName = "vt_tipoDoc";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 106;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Establecimiento";
            this.gridColumn2.FieldName = "vt_serie1";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 86;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Punto de emisión";
            this.gridColumn3.FieldName = "vt_serie2";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 88;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Número documento";
            this.gridColumn4.FieldName = "vt_NumFactura";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 102;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cliente";
            this.gridColumn5.FieldName = "nom_Cliente";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 253;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Fecha";
            this.gridColumn6.FieldName = "vt_fecha";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 97;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Fecha vencimiento";
            this.gridColumn7.FieldName = "vt_fech_venc";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 119;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Observación";
            this.gridColumn8.FieldName = "vt_Observacion";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 403;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Total";
            this.gridColumn9.FieldName = "vt_total";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 121;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "# Documento";
            this.gridColumn10.FieldName = "num_doc";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 198;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Saldo";
            this.gridColumn11.FieldName = "saldo";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            this.gridColumn11.Width = 120;
            // 
            // frmFa_factura_NotaDeb_a_cruzar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 427);
            this.ControlBox = false;
            this.Controls.Add(this.gridControlDocs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmFa_factura_NotaDeb_a_cruzar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDocs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnVaciar;
        private DevExpress.XtraGrid.GridControl gridControlDocs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDocs;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
    }
}
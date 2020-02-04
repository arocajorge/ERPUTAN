namespace Core.Erp.Winform.Controles
{
    partial class UCFa_Cliente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ruc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Telefonos = new System.Windows.Forms.TextBox();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCliente = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombre_Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbVendedor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colVe_Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVendedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ruc.:";
            // 
            // txt_Ruc
            // 
            this.txt_Ruc.Enabled = false;
            this.txt_Ruc.Location = new System.Drawing.Point(475, 3);
            this.txt_Ruc.MaxLength = 13;
            this.txt_Ruc.Name = "txt_Ruc";
            this.txt_Ruc.Size = new System.Drawing.Size(100, 20);
            this.txt_Ruc.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Dirección:";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Enabled = false;
            this.txt_Direccion.Location = new System.Drawing.Point(74, 29);
            this.txt_Direccion.Multiline = true;
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Direccion.Size = new System.Drawing.Size(327, 42);
            this.txt_Direccion.TabIndex = 22;
            this.txt_Direccion.TextChanged += new System.EventHandler(this.txt_Direccion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Teléfonos:";
            // 
            // txt_Telefonos
            // 
            this.txt_Telefonos.Enabled = false;
            this.txt_Telefonos.Location = new System.Drawing.Point(475, 29);
            this.txt_Telefonos.Name = "txt_Telefonos";
            this.txt_Telefonos.Size = new System.Drawing.Size(225, 20);
            this.txt_Telefonos.TabIndex = 24;
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 4;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 337F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 345F));
            this.tableLayout.Controls.Add(this.label5, 0, 2);
            this.tableLayout.Controls.Add(this.label1, 0, 0);
            this.tableLayout.Controls.Add(this.txt_Direccion, 1, 1);
            this.tableLayout.Controls.Add(this.label3, 0, 1);
            this.tableLayout.Controls.Add(this.label2, 2, 0);
            this.tableLayout.Controls.Add(this.txt_Ruc, 3, 0);
            this.tableLayout.Controls.Add(this.label4, 2, 1);
            this.tableLayout.Controls.Add(this.txt_Telefonos, 3, 1);
            this.tableLayout.Controls.Add(this.cmbCliente, 1, 0);
            this.tableLayout.Controls.Add(this.cmbVendedor, 1, 2);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Size = new System.Drawing.Size(750, 113);
            this.tableLayout.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Vendedor:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.Location = new System.Drawing.Point(74, 3);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCliente.Properties.View = this.searchLookUpEdit1View;
            this.cmbCliente.Size = new System.Drawing.Size(327, 20);
            this.cmbCliente.TabIndex = 28;
            this.cmbCliente.EditValueChanged += new System.EventHandler(this.cmbCliente_EditValueChanged);
            this.cmbCliente.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCliente_Validating);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombre_Cliente,
            this.colIdCliente});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colNombre_Cliente
            // 
            this.colNombre_Cliente.Caption = "Cliente";
            this.colNombre_Cliente.FieldName = "Nombre_Cliente";
            this.colNombre_Cliente.Name = "colNombre_Cliente";
            this.colNombre_Cliente.Visible = true;
            this.colNombre_Cliente.VisibleIndex = 0;
            this.colNombre_Cliente.Width = 858;
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "ID";
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.Visible = true;
            this.colIdCliente.VisibleIndex = 1;
            this.colIdCliente.Width = 322;
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.Location = new System.Drawing.Point(74, 77);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVendedor.Properties.View = this.searchLookUpEdit2View;
            this.cmbVendedor.Size = new System.Drawing.Size(327, 20);
            this.cmbVendedor.TabIndex = 29;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colVe_Vendedor,
            this.colIdVendedor});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colVe_Vendedor
            // 
            this.colVe_Vendedor.Caption = "Vendedor";
            this.colVe_Vendedor.FieldName = "Ve_Vendedor";
            this.colVe_Vendedor.Name = "colVe_Vendedor";
            this.colVe_Vendedor.Visible = true;
            this.colVe_Vendedor.VisibleIndex = 0;
            this.colVe_Vendedor.Width = 907;
            // 
            // colIdVendedor
            // 
            this.colIdVendedor.Caption = "ID";
            this.colIdVendedor.FieldName = "IdVendedor";
            this.colIdVendedor.Name = "colIdVendedor";
            this.colIdVendedor.Visible = true;
            this.colIdVendedor.VisibleIndex = 1;
            this.colIdVendedor.Width = 273;
            // 
            // UCFa_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayout);
            this.Name = "UCFa_Cliente";
            this.Size = new System.Drawing.Size(750, 113);
            this.Load += new System.EventHandler(this.UCFAC_Cliente_Load);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVendedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ruc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Telefonos;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbVendedor;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colVe_Vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVendedor;

    }
}

namespace Core.Erp.Winform.Roles
{
    partial class frmRo_HistoricoSueldo_Cons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRo_HistoricoSueldo_Cons));
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.grdLista = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Secuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SueldoAnterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SueldoActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PorIncrementoSueldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValorIncrementoSueldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Motivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_salir,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(822, 25);
            this.toolStrip1.TabIndex = 43;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(742, 22);
            this.toolStripLabel2.Text = resources.GetString("toolStripLabel2.Text");
            // 
            // grdLista
            // 
            this.grdLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLista.Location = new System.Drawing.Point(3, 16);
            this.grdLista.MainView = this.gridView;
            this.grdLista.Name = "grdLista";
            this.grdLista.Size = new System.Drawing.Size(816, 409);
            this.grdLista.TabIndex = 44;
            this.grdLista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Secuencia,
            this.IdEmpleado,
            this.SueldoAnterior,
            this.SueldoActual,
            this.PorIncrementoSueldo,
            this.ValorIncrementoSueldo,
            this.ca_descripcion,
            this.Motivo,
            this.Fecha});
            this.gridView.GridControl = this.grdLista;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // Secuencia
            // 
            this.Secuencia.Caption = "Secuencia";
            this.Secuencia.FieldName = "Secuencia";
            this.Secuencia.Name = "Secuencia";
            this.Secuencia.OptionsColumn.AllowEdit = false;
            this.Secuencia.Visible = true;
            this.Secuencia.VisibleIndex = 0;
            this.Secuencia.Width = 57;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.Caption = "IdEmpleado";
            this.IdEmpleado.FieldName = "IdEmpleado";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.Visible = true;
            this.IdEmpleado.VisibleIndex = 1;
            this.IdEmpleado.Width = 83;
            // 
            // SueldoAnterior
            // 
            this.SueldoAnterior.Caption = "Sueldo Anterior";
            this.SueldoAnterior.FieldName = "SueldoAnterior";
            this.SueldoAnterior.Name = "SueldoAnterior";
            this.SueldoAnterior.OptionsColumn.AllowEdit = false;
            this.SueldoAnterior.Visible = true;
            this.SueldoAnterior.VisibleIndex = 3;
            this.SueldoAnterior.Width = 97;
            // 
            // SueldoActual
            // 
            this.SueldoActual.Caption = "Sueldo Actual";
            this.SueldoActual.FieldName = "SueldoActual";
            this.SueldoActual.Name = "SueldoActual";
            this.SueldoActual.OptionsColumn.AllowEdit = false;
            this.SueldoActual.Visible = true;
            this.SueldoActual.VisibleIndex = 4;
            this.SueldoActual.Width = 79;
            // 
            // PorIncrementoSueldo
            // 
            this.PorIncrementoSueldo.Caption = "Incre. %";
            this.PorIncrementoSueldo.FieldName = "PorIncrementoSueldo";
            this.PorIncrementoSueldo.Name = "PorIncrementoSueldo";
            this.PorIncrementoSueldo.OptionsColumn.AllowEdit = false;
            this.PorIncrementoSueldo.Visible = true;
            this.PorIncrementoSueldo.VisibleIndex = 5;
            // 
            // ValorIncrementoSueldo
            // 
            this.ValorIncrementoSueldo.Caption = "$ Incre. Valor";
            this.ValorIncrementoSueldo.FieldName = "ValorIncrementoSueldo";
            this.ValorIncrementoSueldo.Name = "ValorIncrementoSueldo";
            this.ValorIncrementoSueldo.OptionsColumn.AllowEdit = false;
            this.ValorIncrementoSueldo.Visible = true;
            this.ValorIncrementoSueldo.VisibleIndex = 6;
            this.ValorIncrementoSueldo.Width = 94;
            // 
            // ca_descripcion
            // 
            this.ca_descripcion.Caption = "Cargo";
            this.ca_descripcion.FieldName = "ca_descripcion";
            this.ca_descripcion.Name = "ca_descripcion";
            this.ca_descripcion.OptionsColumn.AllowEdit = false;
            this.ca_descripcion.Visible = true;
            this.ca_descripcion.VisibleIndex = 2;
            this.ca_descripcion.Width = 116;
            // 
            // Motivo
            // 
            this.Motivo.Caption = "Motivo";
            this.Motivo.FieldName = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.OptionsColumn.AllowEdit = false;
            this.Motivo.Visible = true;
            this.Motivo.VisibleIndex = 7;
            this.Motivo.Width = 115;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 8;
            this.Fecha.Width = 88;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdLista);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 428);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // frmRo_HistoricoSueldo_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_HistoricoSueldo_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta - Histórico del Empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRo_HistoricoSueldo_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmRo_HistoricoSueldo_Mant_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_HistoricoSueldo_Cons_KeyPress);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl grdLista;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn Secuencia;
        private DevExpress.XtraGrid.Columns.GridColumn SueldoAnterior;
        private DevExpress.XtraGrid.Columns.GridColumn SueldoActual;
        private DevExpress.XtraGrid.Columns.GridColumn PorIncrementoSueldo;
        private DevExpress.XtraGrid.Columns.GridColumn ca_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn ValorIncrementoSueldo;
        private DevExpress.XtraGrid.Columns.GridColumn Motivo;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn IdEmpleado;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}
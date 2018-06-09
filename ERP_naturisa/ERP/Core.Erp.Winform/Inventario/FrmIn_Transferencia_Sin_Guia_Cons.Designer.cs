namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Transferencia_Sin_Guia_Cons
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
            this.gridControlConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_sucursal = new Core.Erp.Winform.Controles.UCGe_Sucursal_combo();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColBodega_Destino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColBodega_Origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSucursal_Destino = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSucursal_Origen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Coltr_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdTransferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlConsulta
            // 
            this.gridControlConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlConsulta.Location = new System.Drawing.Point(0, 62);
            this.gridControlConsulta.MainView = this.gridViewConsulta;
            this.gridControlConsulta.Name = "gridControlConsulta";
            this.gridControlConsulta.Size = new System.Drawing.Size(917, 389);
            this.gridControlConsulta.TabIndex = 2;
            this.gridControlConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsulta});
            // 
            // gridViewConsulta
            // 
            this.gridViewConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColBodega_Destino,
            this.ColBodega_Origen,
            this.ColSucursal_Destino,
            this.ColSucursal_Origen,
            this.Coltr_Observacion,
            this.ColIdTransferencia});
            this.gridViewConsulta.GridControl = this.gridControlConsulta;
            this.gridViewConsulta.Name = "gridViewConsulta";
            this.gridViewConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsulta.DoubleClick += new System.EventHandler(this.gridViewConsulta_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_sucursal);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.dtpFechaIni);
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 62);
            this.panel1.TabIndex = 3;
            // 
            // cmb_sucursal
            // 
            this.cmb_sucursal.Location = new System.Drawing.Point(95, 6);
            this.cmb_sucursal.Name = "cmb_sucursal";
            this.cmb_sucursal.Size = new System.Drawing.Size(332, 26);
            this.cmb_sucursal.TabIndex = 13;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(288, 31);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(139, 20);
            this.dtpFechaFin.TabIndex = 12;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(95, 31);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(139, 20);
            this.dtpFechaIni.TabIndex = 11;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(433, 21);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(105, 30);
            this.btnConsulta.TabIndex = 10;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sucursal:";
            // 
            // ColBodega_Destino
            // 
            this.ColBodega_Destino.Caption = "Bodega Destino";
            this.ColBodega_Destino.FieldName = "Bodega_Destino";
            this.ColBodega_Destino.Name = "ColBodega_Destino";
            this.ColBodega_Destino.Visible = true;
            this.ColBodega_Destino.VisibleIndex = 1;
            this.ColBodega_Destino.Width = 210;
            // 
            // ColBodega_Origen
            // 
            this.ColBodega_Origen.Caption = "Bodega Origen";
            this.ColBodega_Origen.FieldName = "Bodega_Origen";
            this.ColBodega_Origen.Name = "ColBodega_Origen";
            this.ColBodega_Origen.Visible = true;
            this.ColBodega_Origen.VisibleIndex = 2;
            this.ColBodega_Origen.Width = 210;
            // 
            // ColSucursal_Destino
            // 
            this.ColSucursal_Destino.Caption = "Sucursal Destino";
            this.ColSucursal_Destino.FieldName = "Sucursal_Destino";
            this.ColSucursal_Destino.Name = "ColSucursal_Destino";
            this.ColSucursal_Destino.Visible = true;
            this.ColSucursal_Destino.VisibleIndex = 3;
            this.ColSucursal_Destino.Width = 210;
            // 
            // ColSucursal_Origen
            // 
            this.ColSucursal_Origen.Caption = "Sucursal Origen";
            this.ColSucursal_Origen.FieldName = "Sucursal_Origen";
            this.ColSucursal_Origen.Name = "ColSucursal_Origen";
            this.ColSucursal_Origen.Visible = true;
            this.ColSucursal_Origen.VisibleIndex = 4;
            this.ColSucursal_Origen.Width = 210;
            // 
            // Coltr_Observacion
            // 
            this.Coltr_Observacion.Caption = "Observacion";
            this.Coltr_Observacion.FieldName = "tr_Observacion";
            this.Coltr_Observacion.Name = "Coltr_Observacion";
            this.Coltr_Observacion.Visible = true;
            this.Coltr_Observacion.VisibleIndex = 5;
            this.Coltr_Observacion.Width = 212;
            // 
            // ColIdTransferencia
            // 
            this.ColIdTransferencia.Caption = "Id Treansferencia";
            this.ColIdTransferencia.FieldName = "IdTransferencia";
            this.ColIdTransferencia.Name = "ColIdTransferencia";
            this.ColIdTransferencia.Visible = true;
            this.ColIdTransferencia.VisibleIndex = 0;
            this.ColIdTransferencia.Width = 94;
            // 
            // FrmIn_Transferencia_Sin_Guia_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 451);
            this.Controls.Add(this.gridControlConsulta);
            this.Controls.Add(this.panel1);
            this.Name = "FrmIn_Transferencia_Sin_Guia_Cons";
            this.Text = "FrmIn_Transferencia_Sin_Guia_Cons";
            this.Load += new System.EventHandler(this.FrmIn_Transferencia_Sin_Guia_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsulta;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Sucursal_combo cmb_sucursal;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn ColBodega_Destino;
        private DevExpress.XtraGrid.Columns.GridColumn ColBodega_Origen;
        private DevExpress.XtraGrid.Columns.GridColumn ColSucursal_Destino;
        private DevExpress.XtraGrid.Columns.GridColumn ColSucursal_Origen;
        private DevExpress.XtraGrid.Columns.GridColumn Coltr_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdTransferencia;
    }
}
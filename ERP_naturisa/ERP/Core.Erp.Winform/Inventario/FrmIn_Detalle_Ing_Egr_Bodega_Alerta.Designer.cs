namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Detalle_Ing_Egr_Bodega_Alerta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_Detalle_Ing_Egr_Bodega_Alerta));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.gridControlIngEgr = new DevExpress.XtraGrid.GridControl();
            this.gridViewIngEgr = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMotivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_registro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStripMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIngEgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIngEgr)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(954, 25);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 370);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(954, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.splitContainer1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(954, 345);
            this.panelMain.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lblMensaje);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControlIngEgr);
            this.splitContainer1.Size = new System.Drawing.Size(954, 345);
            this.splitContainer1.SplitterDistance = 78;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(842, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(12, 39);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(230, 24);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Esta Orden de Compra ";
            // 
            // gridControlIngEgr
            // 
            this.gridControlIngEgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlIngEgr.Location = new System.Drawing.Point(0, 0);
            this.gridControlIngEgr.MainView = this.gridViewIngEgr;
            this.gridControlIngEgr.Name = "gridControlIngEgr";
            this.gridControlIngEgr.Size = new System.Drawing.Size(954, 263);
            this.gridControlIngEgr.TabIndex = 0;
            this.gridControlIngEgr.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewIngEgr});
            // 
            // gridViewIngEgr
            // 
            this.gridViewIngEgr.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSucursal,
            this.colBodega,
            this.colMotivo,
            this.colNumMovi,
            this.colFecha,
            this.colFecha_registro,
            this.colusuario});
            this.gridViewIngEgr.GridControl = this.gridControlIngEgr;
            this.gridViewIngEgr.Name = "gridViewIngEgr";
            this.gridViewIngEgr.OptionsBehavior.Editable = false;
            this.gridViewIngEgr.OptionsView.ShowGroupPanel = false;
            // 
            // colSucursal
            // 
            this.colSucursal.Caption = "Sucursal";
            this.colSucursal.FieldName = "nom_sucu";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.Visible = true;
            this.colSucursal.VisibleIndex = 0;
            // 
            // colBodega
            // 
            this.colBodega.Caption = "Bodega";
            this.colBodega.FieldName = "nom_bodega";
            this.colBodega.Name = "colBodega";
            this.colBodega.Visible = true;
            this.colBodega.VisibleIndex = 1;
            // 
            // colMotivo
            // 
            this.colMotivo.Caption = "Motivo";
            this.colMotivo.FieldName = "nom_tipo_inv";
            this.colMotivo.Name = "colMotivo";
            this.colMotivo.Visible = true;
            this.colMotivo.VisibleIndex = 2;
            // 
            // colNumMovi
            // 
            this.colNumMovi.Caption = "#Movimiento";
            this.colNumMovi.FieldName = "IdNumMovi";
            this.colNumMovi.Name = "colNumMovi";
            this.colNumMovi.Visible = true;
            this.colNumMovi.VisibleIndex = 3;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "oc_fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 4;
            // 
            // colFecha_registro
            // 
            this.colFecha_registro.Caption = "Fecha_registro";
            this.colFecha_registro.DisplayFormat.FormatString = "\"dd/MM/yyyy hh:mm tt\"";
            this.colFecha_registro.FieldName = "Fecha_registro";
            this.colFecha_registro.Name = "colFecha_registro";
            this.colFecha_registro.Visible = true;
            this.colFecha_registro.VisibleIndex = 5;
            // 
            // colusuario
            // 
            this.colusuario.Caption = "usuario";
            this.colusuario.FieldName = "IdUsuario";
            this.colusuario.Name = "colusuario";
            // 
            // FrmIn_Detalle_Ing_Egr_Bodega_Alerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 396);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "FrmIn_Detalle_Ing_Egr_Bodega_Alerta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIn_Detalle_Ing_Egr_Bodega_Alerta";
            this.Load += new System.EventHandler(this.FrmIn_Detalle_Ing_Egr_Bodega_Alerta_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlIngEgr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIngEgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraGrid.GridControl gridControlIngEgr;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewIngEgr;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colMotivo;
        private DevExpress.XtraGrid.Columns.GridColumn colNumMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_registro;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblMensaje;

    }
}
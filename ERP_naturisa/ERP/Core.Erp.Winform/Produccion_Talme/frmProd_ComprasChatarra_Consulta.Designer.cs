namespace Core.Erp.Winform.Produccion_Talme
{
    partial class frmProd_ComprasChatarra_Consulta
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
            this.components = new System.ComponentModel.Container();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.prodCompraChatarraCusTalmeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdLiquidacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor_Presu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeneficiario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoChatarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioChatarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTLlenoKg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTVacionKg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTMermaKg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTNetokg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoChatarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPresupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodCompraChatarraCusTalmeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.AppearanceReadOnly.Image = global::Core.Erp.Winform.Properties.Resources.imprimir;
            this.repositoryItemPictureEdit1.AppearanceReadOnly.Options.UseImage = true;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.ReadOnly = true;
            this.repositoryItemPictureEdit1.ShowScrollBars = true;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.prodCompraChatarraCusTalmeInfoBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl.Size = new System.Drawing.Size(1161, 189);
            this.gridControl.TabIndex = 8;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // prodCompraChatarraCusTalmeInfoBindingSource
            // 
            this.prodCompraChatarraCusTalmeInfoBindingSource.DataSource = typeof(Core.Erp.Info.Produccion_Talme.prod_CompraChatarra_CusTalme_Info);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdLiquidacion,
            this.colIdProveedor_Presu,
            this.colIdProveedor,
            this.colFecha,
            this.colBeneficiario,
            this.colPlaca,
            this.colIdTipoChatarra,
            this.colPrecioChatarra,
            this.colTLlenoKg,
            this.colTVacionKg,
            this.colTMermaKg,
            this.colSubtotal,
            this.colDescuento,
            this.colTotal,
            this.colTNetokg,
            this.colTipoChatarra,
            this.colProveedor,
            this.colPresupuesto,
            this.colEstado});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView_RowStyle);
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdLiquidacion
            // 
            this.colIdLiquidacion.FieldName = "IdLiquidacion";
            this.colIdLiquidacion.Name = "colIdLiquidacion";
            this.colIdLiquidacion.Visible = true;
            this.colIdLiquidacion.VisibleIndex = 0;
            // 
            // colIdProveedor_Presu
            // 
            this.colIdProveedor_Presu.FieldName = "IdProveedor_Presu";
            this.colIdProveedor_Presu.Name = "colIdProveedor_Presu";
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 14;
            // 
            // colBeneficiario
            // 
            this.colBeneficiario.FieldName = "Beneficiario";
            this.colBeneficiario.Name = "colBeneficiario";
            this.colBeneficiario.Visible = true;
            this.colBeneficiario.VisibleIndex = 3;
            // 
            // colPlaca
            // 
            this.colPlaca.FieldName = "Placa";
            this.colPlaca.Name = "colPlaca";
            this.colPlaca.Visible = true;
            this.colPlaca.VisibleIndex = 4;
            // 
            // colIdTipoChatarra
            // 
            this.colIdTipoChatarra.FieldName = "IdTipoChatarra";
            this.colIdTipoChatarra.Name = "colIdTipoChatarra";
            // 
            // colPrecioChatarra
            // 
            this.colPrecioChatarra.FieldName = "PrecioChatarra";
            this.colPrecioChatarra.Name = "colPrecioChatarra";
            this.colPrecioChatarra.Visible = true;
            this.colPrecioChatarra.VisibleIndex = 5;
            // 
            // colTLlenoKg
            // 
            this.colTLlenoKg.FieldName = "TLlenoKg";
            this.colTLlenoKg.Name = "colTLlenoKg";
            this.colTLlenoKg.Visible = true;
            this.colTLlenoKg.VisibleIndex = 6;
            // 
            // colTVacionKg
            // 
            this.colTVacionKg.FieldName = "TVacionKg";
            this.colTVacionKg.Name = "colTVacionKg";
            this.colTVacionKg.Visible = true;
            this.colTVacionKg.VisibleIndex = 7;
            // 
            // colTMermaKg
            // 
            this.colTMermaKg.FieldName = "TMermaKg";
            this.colTMermaKg.Name = "colTMermaKg";
            this.colTMermaKg.Visible = true;
            this.colTMermaKg.VisibleIndex = 8;
            // 
            // colSubtotal
            // 
            this.colSubtotal.FieldName = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 9;
            // 
            // colDescuento
            // 
            this.colDescuento.FieldName = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.Visible = true;
            this.colDescuento.VisibleIndex = 10;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 11;
            // 
            // colTNetokg
            // 
            this.colTNetokg.FieldName = "TNetokg";
            this.colTNetokg.Name = "colTNetokg";
            this.colTNetokg.Visible = true;
            this.colTNetokg.VisibleIndex = 12;
            // 
            // colTipoChatarra
            // 
            this.colTipoChatarra.FieldName = "TipoChatarra";
            this.colTipoChatarra.Name = "colTipoChatarra";
            this.colTipoChatarra.Visible = true;
            this.colTipoChatarra.VisibleIndex = 13;
            // 
            // colProveedor
            // 
            this.colProveedor.FieldName = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 2;
            // 
            // colPresupuesto
            // 
            this.colPresupuesto.FieldName = "Presupuesto";
            this.colPresupuesto.Name = "colPresupuesto";
            this.colPresupuesto.Visible = true;
            this.colPresupuesto.VisibleIndex = 1;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 15;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 343);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1161, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1161, 154);
            this.panel1.TabIndex = 17;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 3, 25, 17, 53, 0, 120);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 5, 25, 17, 53, 0, 120);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1161, 154);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1161, 189);
            this.panel2.TabIndex = 18;
            // 
            // frmProd_ComprasChatarra_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 365);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmProd_ComprasChatarra_Consulta";
            this.Text = "Compra Chatarra consulta";
            this.Load += new System.EventHandler(this.frmProd_ComprasChatarra_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodCompraChatarraCusTalmeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource prodCompraChatarraCusTalmeInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLiquidacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor_Presu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colBeneficiario;
        private DevExpress.XtraGrid.Columns.GridColumn colPlaca;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoChatarra;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioChatarra;
        private DevExpress.XtraGrid.Columns.GridColumn colTLlenoKg;
        private DevExpress.XtraGrid.Columns.GridColumn colTVacionKg;
        private DevExpress.XtraGrid.Columns.GridColumn colTMermaKg;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuento;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTNetokg;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoChatarra;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colPresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
    }
}
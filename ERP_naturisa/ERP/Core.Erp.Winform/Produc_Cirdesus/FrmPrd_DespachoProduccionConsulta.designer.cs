namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_DespachoProduccionConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrd_DespachoProduccionConsulta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlDespacho = new DevExpress.XtraGrid.GridControl();
            this.prdDespachoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDespacho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdDespacho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdMotivoDespacho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PuntoPartida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PuntoLLegada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdTipoTransporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Placa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Chofer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaReg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Referencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumDespacho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDespacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdDespachoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDespacho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlDespacho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 360);
            this.panel1.TabIndex = 0;
            // 
            // gridControlDespacho
            // 
            this.gridControlDespacho.DataSource = this.prdDespachoInfoBindingSource;
            this.gridControlDespacho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDespacho.Location = new System.Drawing.Point(0, 0);
            this.gridControlDespacho.MainView = this.gridViewDespacho;
            this.gridControlDespacho.Name = "gridControlDespacho";
            this.gridControlDespacho.Size = new System.Drawing.Size(894, 360);
            this.gridControlDespacho.TabIndex = 15;
            this.gridControlDespacho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDespacho});
            // 
            // prdDespachoInfoBindingSource
            // 
            this.prdDespachoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Produc_Cirdesus.prd_Despacho_Info);
            // 
            // gridViewDespacho
            // 
            this.gridViewDespacho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdDespacho,
            this.IdMotivoDespacho,
            this.PuntoPartida,
            this.PuntoLLegada,
            this.IdTipoTransporte,
            this.Estado,
            this.Placa,
            this.Chofer,
            this.FechaReg,
            this.Referencia,
            this.colObservacion,
            this.colNomCliente,
            this.colNumDespacho,
            this.colSu_Descripcion});
            this.gridViewDespacho.GridControl = this.gridControlDespacho;
            this.gridViewDespacho.Name = "gridViewDespacho";
            this.gridViewDespacho.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewDespacho.OptionsCustomization.AllowGroup = false;
            this.gridViewDespacho.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridViewDespacho.OptionsCustomization.AllowRowSizing = true;
            this.gridViewDespacho.OptionsFind.AlwaysVisible = true;
            this.gridViewDespacho.OptionsView.ShowViewCaption = true;
            this.gridViewDespacho.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IdDespacho, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewDespacho.ViewCaption = "Listado de Despacho de Producción";
            this.gridViewDespacho.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewDespacho_RowCellStyle);
            this.gridViewDespacho.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewDespacho_FocusedRowChanged);
            // 
            // IdDespacho
            // 
            this.IdDespacho.AppearanceHeader.Options.UseTextOptions = true;
            this.IdDespacho.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdDespacho.Caption = "#Reg Despacho";
            this.IdDespacho.FieldName = "IdDespacho";
            this.IdDespacho.Name = "IdDespacho";
            this.IdDespacho.OptionsColumn.AllowEdit = false;
            this.IdDespacho.Visible = true;
            this.IdDespacho.VisibleIndex = 2;
            this.IdDespacho.Width = 58;
            // 
            // IdMotivoDespacho
            // 
            this.IdMotivoDespacho.AppearanceHeader.Options.UseTextOptions = true;
            this.IdMotivoDespacho.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdMotivoDespacho.Caption = "Motivo";
            this.IdMotivoDespacho.FieldName = "IdMotivoDespacho";
            this.IdMotivoDespacho.Name = "IdMotivoDespacho";
            this.IdMotivoDespacho.OptionsColumn.AllowEdit = false;
            this.IdMotivoDespacho.Width = 96;
            // 
            // PuntoPartida
            // 
            this.PuntoPartida.AppearanceHeader.Options.UseTextOptions = true;
            this.PuntoPartida.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PuntoPartida.Caption = "Punto Partida";
            this.PuntoPartida.FieldName = "PuntoPartida";
            this.PuntoPartida.Name = "PuntoPartida";
            this.PuntoPartida.OptionsColumn.AllowEdit = false;
            this.PuntoPartida.Visible = true;
            this.PuntoPartida.VisibleIndex = 6;
            this.PuntoPartida.Width = 112;
            // 
            // PuntoLLegada
            // 
            this.PuntoLLegada.AppearanceHeader.Options.UseTextOptions = true;
            this.PuntoLLegada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PuntoLLegada.Caption = "Punto LLegada";
            this.PuntoLLegada.FieldName = "PuntoLLegada";
            this.PuntoLLegada.Name = "PuntoLLegada";
            this.PuntoLLegada.OptionsColumn.AllowEdit = false;
            this.PuntoLLegada.Visible = true;
            this.PuntoLLegada.VisibleIndex = 7;
            this.PuntoLLegada.Width = 112;
            // 
            // IdTipoTransporte
            // 
            this.IdTipoTransporte.AppearanceHeader.Options.UseTextOptions = true;
            this.IdTipoTransporte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.IdTipoTransporte.Caption = "Tipo Transporte";
            this.IdTipoTransporte.FieldName = "IdTipoTransporte";
            this.IdTipoTransporte.Name = "IdTipoTransporte";
            this.IdTipoTransporte.OptionsColumn.AllowEdit = false;
            this.IdTipoTransporte.Width = 84;
            // 
            // Estado
            // 
            this.Estado.AppearanceHeader.Options.UseTextOptions = true;
            this.Estado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.OptionsColumn.AllowEdit = false;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 11;
            this.Estado.Width = 31;
            // 
            // Placa
            // 
            this.Placa.AppearanceHeader.Options.UseTextOptions = true;
            this.Placa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Placa.Caption = "Placa";
            this.Placa.FieldName = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.OptionsColumn.AllowEdit = false;
            this.Placa.Visible = true;
            this.Placa.VisibleIndex = 9;
            this.Placa.Width = 49;
            // 
            // Chofer
            // 
            this.Chofer.AppearanceHeader.Options.UseTextOptions = true;
            this.Chofer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Chofer.Caption = "Chofer";
            this.Chofer.FieldName = "Chofer";
            this.Chofer.Name = "Chofer";
            this.Chofer.OptionsColumn.AllowEdit = false;
            this.Chofer.Visible = true;
            this.Chofer.VisibleIndex = 8;
            this.Chofer.Width = 45;
            // 
            // FechaReg
            // 
            this.FechaReg.AppearanceHeader.Options.UseTextOptions = true;
            this.FechaReg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.FechaReg.Caption = "Fecha";
            this.FechaReg.FieldName = "FechaReg";
            this.FechaReg.Name = "FechaReg";
            this.FechaReg.OptionsColumn.AllowEdit = false;
            this.FechaReg.Visible = true;
            this.FechaReg.VisibleIndex = 0;
            this.FechaReg.Width = 47;
            // 
            // Referencia
            // 
            this.Referencia.AppearanceHeader.Options.UseTextOptions = true;
            this.Referencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Referencia.Caption = "Obra";
            this.Referencia.FieldName = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.OptionsColumn.AllowEdit = false;
            this.Referencia.Visible = true;
            this.Referencia.VisibleIndex = 4;
            this.Referencia.Width = 45;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observación";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 10;
            this.colObservacion.Width = 117;
            // 
            // colNomCliente
            // 
            this.colNomCliente.Caption = "Cliente";
            this.colNomCliente.FieldName = "NomCliente";
            this.colNomCliente.Name = "colNomCliente";
            this.colNomCliente.Visible = true;
            this.colNomCliente.VisibleIndex = 5;
            this.colNomCliente.Width = 65;
            // 
            // colNumDespacho
            // 
            this.colNumDespacho.Caption = "#Despacho";
            this.colNumDespacho.FieldName = "NumDespacho";
            this.colNumDespacho.Name = "colNumDespacho";
            this.colNumDespacho.Visible = true;
            this.colNumDespacho.VisibleIndex = 3;
            this.colNumDespacho.Width = 93;
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Sucursal";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 1;
            this.colSu_Descripcion.Width = 49;
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            // 
            // 
            // 
            this.printableComponentLink1.ImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream")));
            this.printableComponentLink1.Owner = null;
            this.printableComponentLink1.PrintingSystem = this.printingSystem1;
            this.printableComponentLink1.PrintingSystemBase = this.printingSystem1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(894, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 7, 9, 24, 0, 20);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 7, 9, 24, 0, 20);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(894, 95);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 15;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // FrmPrd_DespachoProduccionConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmPrd_DespachoProduccionConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta de Despachos de Producción";
            this.Load += new System.EventHandler(this.FrmPrd_DespachoProduccionConsulta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDespacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdDespachoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDespacho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printableComponentLink1.ImageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlDespacho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDespacho;
        private DevExpress.XtraGrid.Columns.GridColumn IdDespacho;
        private DevExpress.XtraGrid.Columns.GridColumn IdMotivoDespacho;
        private DevExpress.XtraGrid.Columns.GridColumn PuntoPartida;
        private DevExpress.XtraGrid.Columns.GridColumn PuntoLLegada;
        private DevExpress.XtraGrid.Columns.GridColumn IdTipoTransporte;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Placa;
        private DevExpress.XtraGrid.Columns.GridColumn Chofer;
        private DevExpress.XtraGrid.Columns.GridColumn FechaReg;
        private DevExpress.XtraGrid.Columns.GridColumn Referencia;
        private System.Windows.Forms.BindingSource prdDespachoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNomCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNumDespacho;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
    }
}
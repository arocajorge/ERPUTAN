namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxc_CobrosGenerales_Consulta
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gridViewCuentaxCobrar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_TotalCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Tarjeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_NumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_estadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Cobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdVendedorCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBancoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_propietarioCta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlCuentaxCobrar = new DevExpress.XtraGrid.GridControl();
            this.cxccobroInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colcr_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCuentaxCobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCuentaxCobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 369);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1103, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gridViewCuentaxCobrar
            // 
            this.gridViewCuentaxCobrar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCobro,
            this.colIdCobro_tipo,
            this.colcr_TotalCobro,
            this.colcr_observacion,
            this.colcr_Banco,
            this.colcr_cuenta,
            this.colcr_Tarjeta,
            this.colnSucursal,
            this.colcr_NumDocumento,
            this.colcr_estado,
            this.colcr_estadoCobro,
            this.colcr_Codigo,
            this.colIdEstadoCobro,
            this.colFecha_Cobro,
            this.colIdVendedorCliente,
            this.colnCliente,
            this.colBancoCuenta,
            this.colcr_propietarioCta,
            this.IdBanco,
            this.colcr_fecha});
            this.gridViewCuentaxCobrar.GridControl = this.gridControlCuentaxCobrar;
            this.gridViewCuentaxCobrar.Name = "gridViewCuentaxCobrar";
            this.gridViewCuentaxCobrar.OptionsBehavior.Editable = false;
            this.gridViewCuentaxCobrar.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCuentaxCobrar.OptionsView.ShowGroupPanel = false;
            this.gridViewCuentaxCobrar.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdCobro, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewCuentaxCobrar.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewCuentaxCobrar_RowClick);
            this.gridViewCuentaxCobrar.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCuentaxCobrar_RowCellStyle);
            // 
            // colIdCobro
            // 
            this.colIdCobro.Caption = "Id Cobro";
            this.colIdCobro.FieldName = "IdCobro";
            this.colIdCobro.Name = "colIdCobro";
            this.colIdCobro.Visible = true;
            this.colIdCobro.VisibleIndex = 1;
            this.colIdCobro.Width = 83;
            // 
            // colIdCobro_tipo
            // 
            this.colIdCobro_tipo.Caption = "Cobro Tipo";
            this.colIdCobro_tipo.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo.Name = "colIdCobro_tipo";
            this.colIdCobro_tipo.Visible = true;
            this.colIdCobro_tipo.VisibleIndex = 5;
            this.colIdCobro_tipo.Width = 86;
            // 
            // colcr_TotalCobro
            // 
            this.colcr_TotalCobro.Caption = "Total Cobro";
            this.colcr_TotalCobro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colcr_TotalCobro.FieldName = "cr_TotalCobro";
            this.colcr_TotalCobro.Name = "colcr_TotalCobro";
            this.colcr_TotalCobro.Visible = true;
            this.colcr_TotalCobro.VisibleIndex = 9;
            this.colcr_TotalCobro.Width = 89;
            // 
            // colcr_observacion
            // 
            this.colcr_observacion.Caption = "Observacion";
            this.colcr_observacion.FieldName = "cr_observacion";
            this.colcr_observacion.Name = "colcr_observacion";
            this.colcr_observacion.Visible = true;
            this.colcr_observacion.VisibleIndex = 8;
            this.colcr_observacion.Width = 179;
            // 
            // colcr_Banco
            // 
            this.colcr_Banco.Caption = "Banco";
            this.colcr_Banco.FieldName = "cr_Banco";
            this.colcr_Banco.Name = "colcr_Banco";
            this.colcr_Banco.Visible = true;
            this.colcr_Banco.VisibleIndex = 7;
            this.colcr_Banco.Width = 86;
            // 
            // colcr_cuenta
            // 
            this.colcr_cuenta.Caption = "Cuenta";
            this.colcr_cuenta.FieldName = "cr_cuenta";
            this.colcr_cuenta.Name = "colcr_cuenta";
            this.colcr_cuenta.Width = 55;
            // 
            // colcr_Tarjeta
            // 
            this.colcr_Tarjeta.Caption = "Tarjeta";
            this.colcr_Tarjeta.FieldName = "cr_Tarjeta";
            this.colcr_Tarjeta.Name = "colcr_Tarjeta";
            this.colcr_Tarjeta.Width = 44;
            // 
            // colnSucursal
            // 
            this.colnSucursal.Caption = "Sucursal";
            this.colnSucursal.FieldName = "nSucursal";
            this.colnSucursal.Name = "colnSucursal";
            this.colnSucursal.Visible = true;
            this.colnSucursal.VisibleIndex = 0;
            this.colnSucursal.Width = 86;
            // 
            // colcr_NumDocumento
            // 
            this.colcr_NumDocumento.Caption = "#Documento";
            this.colcr_NumDocumento.FieldName = "cr_NumDocumento";
            this.colcr_NumDocumento.Name = "colcr_NumDocumento";
            this.colcr_NumDocumento.Visible = true;
            this.colcr_NumDocumento.VisibleIndex = 6;
            this.colcr_NumDocumento.Width = 89;
            // 
            // colcr_estado
            // 
            this.colcr_estado.Caption = "Estado";
            this.colcr_estado.FieldName = "cr_estado";
            this.colcr_estado.Name = "colcr_estado";
            this.colcr_estado.Width = 62;
            // 
            // colcr_estadoCobro
            // 
            this.colcr_estadoCobro.Caption = "Estado Cobro";
            this.colcr_estadoCobro.FieldName = "cr_estadoCobro";
            this.colcr_estadoCobro.Name = "colcr_estadoCobro";
            this.colcr_estadoCobro.Width = 72;
            // 
            // colcr_Codigo
            // 
            this.colcr_Codigo.Caption = "Codigo Cobro";
            this.colcr_Codigo.FieldName = "cr_Codigo";
            this.colcr_Codigo.Name = "colcr_Codigo";
            this.colcr_Codigo.Width = 104;
            // 
            // colIdEstadoCobro
            // 
            this.colIdEstadoCobro.Caption = "IdEstadoCobro";
            this.colIdEstadoCobro.FieldName = "IdEstadoCobro";
            this.colIdEstadoCobro.Name = "colIdEstadoCobro";
            this.colIdEstadoCobro.Width = 70;
            // 
            // colFecha_Cobro
            // 
            this.colFecha_Cobro.Caption = "Fecha Cobro";
            this.colFecha_Cobro.FieldName = "cr_fechaCobro";
            this.colFecha_Cobro.Name = "colFecha_Cobro";
            this.colFecha_Cobro.Visible = true;
            this.colFecha_Cobro.VisibleIndex = 3;
            this.colFecha_Cobro.Width = 90;
            // 
            // colIdVendedorCliente
            // 
            this.colIdVendedorCliente.Caption = "Vendedor";
            this.colIdVendedorCliente.FieldName = "IdVendedorCliente";
            this.colIdVendedorCliente.Name = "colIdVendedorCliente";
            this.colIdVendedorCliente.Width = 63;
            // 
            // colnCliente
            // 
            this.colnCliente.Caption = "Cliente";
            this.colnCliente.FieldName = "nCliente";
            this.colnCliente.Name = "colnCliente";
            this.colnCliente.Visible = true;
            this.colnCliente.VisibleIndex = 4;
            this.colnCliente.Width = 208;
            // 
            // colBancoCuenta
            // 
            this.colBancoCuenta.Caption = "Banco Cta.";
            this.colBancoCuenta.FieldName = "BancoCuenta";
            this.colBancoCuenta.Name = "colBancoCuenta";
            this.colBancoCuenta.Width = 56;
            // 
            // colcr_propietarioCta
            // 
            this.colcr_propietarioCta.FieldName = "cr_propietarioCta";
            this.colcr_propietarioCta.Name = "colcr_propietarioCta";
            // 
            // IdBanco
            // 
            this.IdBanco.Caption = "IdBanco";
            this.IdBanco.FieldName = "IdBanco";
            this.IdBanco.Name = "IdBanco";
            // 
            // gridControlCuentaxCobrar
            // 
            this.gridControlCuentaxCobrar.DataSource = this.cxccobroInfoBindingSource;
            this.gridControlCuentaxCobrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCuentaxCobrar.Location = new System.Drawing.Point(0, 0);
            this.gridControlCuentaxCobrar.MainView = this.gridViewCuentaxCobrar;
            this.gridControlCuentaxCobrar.Name = "gridControlCuentaxCobrar";
            this.gridControlCuentaxCobrar.Size = new System.Drawing.Size(1103, 211);
            this.gridControlCuentaxCobrar.TabIndex = 1;
            this.gridControlCuentaxCobrar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCuentaxCobrar});
            // 
            // cxccobroInfoBindingSource
            // 
            this.cxccobroInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_cobro_Info);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 158);
            this.panel1.TabIndex = 14;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasSucursales = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 12, 16, 17, 46, 51, 545);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 2, 16, 17, 46, 51, 545);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1103, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlCuentaxCobrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 211);
            this.panel2.TabIndex = 15;
            // 
            // colcr_fecha
            // 
            this.colcr_fecha.Caption = "Fecha";
            this.colcr_fecha.FieldName = "cr_fecha";
            this.colcr_fecha.Name = "colcr_fecha";
            this.colcr_fecha.Visible = true;
            this.colcr_fecha.VisibleIndex = 2;
            this.colcr_fecha.Width = 106;
            // 
            // frmCxc_CobrosGenerales_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1103, 391);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmCxc_CobrosGenerales_Consulta";
            this.Text = "Cobros Generales";
            this.Load += new System.EventHandler(this.frmcxc_CobrosGenerales_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCuentaxCobrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCuentaxCobrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCuentaxCobrar;
        private DevExpress.XtraGrid.GridControl gridControlCuentaxCobrar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_TotalCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Banco;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Tarjeta;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_NumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_estadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Cobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVendedorCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colnSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colnCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colBancoCuenta;
        private System.Windows.Forms.BindingSource cxccobroInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_propietarioCta;
        private DevExpress.XtraGrid.Columns.GridColumn IdBanco;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_fecha;
    }
}
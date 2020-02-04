namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxc_cancelacion_Intercompany_Cons
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
            this.cxccancelacionIntercompanyInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControlCancelacion = new DevExpress.XtraGrid.GridControl();
            this.gridViewCancelacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCancelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco_Deposito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPapeletaDeposito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcbteban_IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcbteban_IdCbteCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcbteban_IdTipocbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_TotalCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_fechaDocu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_fechaCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_NumDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_Tarjeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_propietarioCta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcr_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneraDeps = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreTipoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCaja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoNotaCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomEmp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cxccancelacionIntercompanyInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCancelacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCancelacion)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cxccancelacionIntercompanyInfoBindingSource
            // 
            this.cxccancelacionIntercompanyInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_cancelacion_Intercompany_Info);
            // 
            // gridControlCancelacion
            // 
            this.gridControlCancelacion.DataSource = this.cxccancelacionIntercompanyInfoBindingSource;
            this.gridControlCancelacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCancelacion.Location = new System.Drawing.Point(0, 0);
            this.gridControlCancelacion.MainView = this.gridViewCancelacion;
            this.gridControlCancelacion.Name = "gridControlCancelacion";
            this.gridControlCancelacion.Size = new System.Drawing.Size(977, 248);
            this.gridControlCancelacion.TabIndex = 16;
            this.gridControlCancelacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCancelacion});
            // 
            // gridViewCancelacion
            // 
            this.gridViewCancelacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdCancelacion,
            this.colIdCliente,
            this.colIdCobro_tipo,
            this.colIdBanco_Deposito,
            this.colObservacion,
            this.colPapeletaDeposito,
            this.colcbteban_IdEmpresa,
            this.colcbteban_IdCbteCble,
            this.colcbteban_IdTipocbte,
            this.colcr_TotalCobro,
            this.colcr_fecha,
            this.colcr_fechaDocu,
            this.colcr_fechaCobro,
            this.colcr_observacion,
            this.colcr_Banco,
            this.colcr_cuenta,
            this.colcr_NumDocumento,
            this.colcr_Tarjeta,
            this.colcr_propietarioCta,
            this.colcr_estado,
            this.colFecha_Transac,
            this.colIdUsuario,
            this.colIdUsuarioUltMod,
            this.colFecha_UltMod,
            this.colIdUsuarioUltAnu,
            this.colFecha_UltAnu,
            this.colnom_pc,
            this.colip,
            this.colIdSucursal,
            this.colGeneraDeps,
            this.colNombreCliente,
            this.colNombreSucursal,
            this.colNombreTipoCobro,
            this.colIdCaja,
            this.colIdTipoNotaCredito,
            this.colNomEmp});
            this.gridViewCancelacion.GridControl = this.gridControlCancelacion;
            this.gridViewCancelacion.Name = "gridViewCancelacion";
            this.gridViewCancelacion.OptionsBehavior.Editable = false;
            this.gridViewCancelacion.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCancelacion_RowCellStyle);
            this.gridViewCancelacion.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCancelacion_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.Caption = "IdEmpresa";
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 59;
            // 
            // colIdCancelacion
            // 
            this.colIdCancelacion.Caption = "IdCancelación";
            this.colIdCancelacion.FieldName = "IdCancelacion";
            this.colIdCancelacion.Name = "colIdCancelacion";
            this.colIdCancelacion.Visible = true;
            this.colIdCancelacion.VisibleIndex = 0;
            this.colIdCancelacion.Width = 77;
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colIdCobro_tipo
            // 
            this.colIdCobro_tipo.FieldName = "IdCobro_tipo";
            this.colIdCobro_tipo.Name = "colIdCobro_tipo";
            // 
            // colIdBanco_Deposito
            // 
            this.colIdBanco_Deposito.FieldName = "IdBanco_Deposito";
            this.colIdBanco_Deposito.Name = "colIdBanco_Deposito";
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observación";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 7;
            this.colObservacion.Width = 133;
            // 
            // colPapeletaDeposito
            // 
            this.colPapeletaDeposito.FieldName = "PapeletaDeposito";
            this.colPapeletaDeposito.Name = "colPapeletaDeposito";
            // 
            // colcbteban_IdEmpresa
            // 
            this.colcbteban_IdEmpresa.FieldName = "cbteban_IdEmpresa";
            this.colcbteban_IdEmpresa.Name = "colcbteban_IdEmpresa";
            // 
            // colcbteban_IdCbteCble
            // 
            this.colcbteban_IdCbteCble.FieldName = "cbteban_IdCbteCble";
            this.colcbteban_IdCbteCble.Name = "colcbteban_IdCbteCble";
            // 
            // colcbteban_IdTipocbte
            // 
            this.colcbteban_IdTipocbte.FieldName = "cbteban_IdTipocbte";
            this.colcbteban_IdTipocbte.Name = "colcbteban_IdTipocbte";
            // 
            // colcr_TotalCobro
            // 
            this.colcr_TotalCobro.Caption = "Total de Cobro";
            this.colcr_TotalCobro.FieldName = "cr_TotalCobro";
            this.colcr_TotalCobro.Name = "colcr_TotalCobro";
            this.colcr_TotalCobro.Visible = true;
            this.colcr_TotalCobro.VisibleIndex = 8;
            this.colcr_TotalCobro.Width = 74;
            // 
            // colcr_fecha
            // 
            this.colcr_fecha.Caption = "Fecha";
            this.colcr_fecha.FieldName = "cr_fecha";
            this.colcr_fecha.Name = "colcr_fecha";
            this.colcr_fecha.Visible = true;
            this.colcr_fecha.VisibleIndex = 1;
            this.colcr_fecha.Width = 66;
            // 
            // colcr_fechaDocu
            // 
            this.colcr_fechaDocu.Caption = "Fecha del Documento";
            this.colcr_fechaDocu.FieldName = "cr_fechaDocu";
            this.colcr_fechaDocu.Name = "colcr_fechaDocu";
            this.colcr_fechaDocu.Visible = true;
            this.colcr_fechaDocu.VisibleIndex = 5;
            this.colcr_fechaDocu.Width = 92;
            // 
            // colcr_fechaCobro
            // 
            this.colcr_fechaCobro.Caption = "Fecha de Cobro";
            this.colcr_fechaCobro.FieldName = "cr_fechaCobro";
            this.colcr_fechaCobro.Name = "colcr_fechaCobro";
            this.colcr_fechaCobro.Visible = true;
            this.colcr_fechaCobro.VisibleIndex = 6;
            this.colcr_fechaCobro.Width = 66;
            // 
            // colcr_observacion
            // 
            this.colcr_observacion.FieldName = "cr_observacion";
            this.colcr_observacion.Name = "colcr_observacion";
            // 
            // colcr_Banco
            // 
            this.colcr_Banco.FieldName = "cr_Banco";
            this.colcr_Banco.Name = "colcr_Banco";
            // 
            // colcr_cuenta
            // 
            this.colcr_cuenta.FieldName = "cr_cuenta";
            this.colcr_cuenta.Name = "colcr_cuenta";
            // 
            // colcr_NumDocumento
            // 
            this.colcr_NumDocumento.FieldName = "cr_NumDocumento";
            this.colcr_NumDocumento.Name = "colcr_NumDocumento";
            // 
            // colcr_Tarjeta
            // 
            this.colcr_Tarjeta.FieldName = "cr_Tarjeta";
            this.colcr_Tarjeta.Name = "colcr_Tarjeta";
            // 
            // colcr_propietarioCta
            // 
            this.colcr_propietarioCta.FieldName = "cr_propietarioCta";
            this.colcr_propietarioCta.Name = "colcr_propietarioCta";
            // 
            // colcr_estado
            // 
            this.colcr_estado.Caption = "Estado";
            this.colcr_estado.FieldName = "cr_estado";
            this.colcr_estado.Name = "colcr_estado";
            this.colcr_estado.Visible = true;
            this.colcr_estado.VisibleIndex = 9;
            this.colcr_estado.Width = 70;
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            // 
            // colIdUsuarioUltAnu
            // 
            this.colIdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Name = "colIdUsuarioUltAnu";
            // 
            // colFecha_UltAnu
            // 
            this.colFecha_UltAnu.FieldName = "Fecha_UltAnu";
            this.colFecha_UltAnu.Name = "colFecha_UltAnu";
            // 
            // colnom_pc
            // 
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // colGeneraDeps
            // 
            this.colGeneraDeps.FieldName = "GeneraDeps";
            this.colGeneraDeps.Name = "colGeneraDeps";
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.Caption = "Cliente";
            this.colNombreCliente.FieldName = "NombreCliente";
            this.colNombreCliente.Name = "colNombreCliente";
            this.colNombreCliente.Visible = true;
            this.colNombreCliente.VisibleIndex = 3;
            this.colNombreCliente.Width = 176;
            // 
            // colNombreSucursal
            // 
            this.colNombreSucursal.Caption = "Sucursal";
            this.colNombreSucursal.FieldName = "NombreSucursal";
            this.colNombreSucursal.Name = "colNombreSucursal";
            this.colNombreSucursal.Visible = true;
            this.colNombreSucursal.VisibleIndex = 2;
            this.colNombreSucursal.Width = 66;
            // 
            // colNombreTipoCobro
            // 
            this.colNombreTipoCobro.Caption = "Tipo de Cobro";
            this.colNombreTipoCobro.FieldName = "NombreTipoCobro";
            this.colNombreTipoCobro.Name = "colNombreTipoCobro";
            this.colNombreTipoCobro.Visible = true;
            this.colNombreTipoCobro.VisibleIndex = 4;
            this.colNombreTipoCobro.Width = 80;
            // 
            // colIdCaja
            // 
            this.colIdCaja.FieldName = "IdCaja";
            this.colIdCaja.Name = "colIdCaja";
            // 
            // colIdTipoNotaCredito
            // 
            this.colIdTipoNotaCredito.FieldName = "IdTipoNotaCredito";
            this.colIdTipoNotaCredito.Name = "colIdTipoNotaCredito";
            // 
            // colNomEmp
            // 
            this.colNomEmp.Caption = "Empresa";
            this.colNomEmp.FieldName = "NomEmp";
            this.colNomEmp.Name = "colNomEmp";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 345);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(977, 22);
            this.statusStrip1.TabIndex = 17;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 3, 28, 10, 44, 55, 849);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 5, 28, 10, 44, 55, 849);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(977, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 18;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 97);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlCancelacion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 248);
            this.panel2.TabIndex = 20;
            // 
            // frmCo_cxc_cancelacion_Intercompany_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 367);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmCo_cxc_cancelacion_Intercompany_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Cobros InterCompany";
            this.Load += new System.EventHandler(this.frmCo_cxc_cancelacion_Intercompany_Cons_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.cxccancelacionIntercompanyInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCancelacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCancelacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmCo_cxc_cancelacion_Intercompany_Cons_Load(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.BindingSource cxccancelacionIntercompanyInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlCancelacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCancelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCancelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco_Deposito;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colPapeletaDeposito;
        private DevExpress.XtraGrid.Columns.GridColumn colcbteban_IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colcbteban_IdCbteCble;
        private DevExpress.XtraGrid.Columns.GridColumn colcbteban_IdTipocbte;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_TotalCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_fechaDocu;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_fechaCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Banco;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_NumDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_Tarjeta;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_propietarioCta;
        private DevExpress.XtraGrid.Columns.GridColumn colcr_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneraDeps;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreTipoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCaja;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoNotaCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colNomEmp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
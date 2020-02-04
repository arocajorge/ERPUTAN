namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxc_anticipo_clientes_Cons
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
            this.gridControlAnticipo = new DevExpress.XtraGrid.GridControl();
            this.cxccobroxAnticipoInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewAnticipo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdAnticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteCble_Caja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipocbte_Caja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa_Caja = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxccobroInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAnticipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroxAnticipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnticipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlAnticipo
            // 
            this.gridControlAnticipo.DataSource = this.cxccobroxAnticipoInfoBindingSource;
            this.gridControlAnticipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAnticipo.Location = new System.Drawing.Point(0, 0);
            this.gridControlAnticipo.MainView = this.gridViewAnticipo;
            this.gridControlAnticipo.Name = "gridControlAnticipo";
            this.gridControlAnticipo.Size = new System.Drawing.Size(783, 199);
            this.gridControlAnticipo.TabIndex = 9;
            this.gridControlAnticipo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAnticipo});
            // 
            // cxccobroxAnticipoInfoBindingSource
            // 
            this.cxccobroxAnticipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_cobro_x_Anticipo_Info);
            // 
            // gridViewAnticipo
            // 
            this.gridViewAnticipo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdAnticipo,
            this.colIdCliente,
            this.colObservacion,
            this.colFecha,
            this.colIdCbteCble_Caja,
            this.colIdTipocbte_Caja,
            this.colIdEmpresa_Caja,
            this.colnombreCliente,
            this.colIdSucursal,
            this.colIdBanco,
            this.colFecha_Transac,
            this.colIdUsuario,
            this.colFecha_UltMod,
            this.colIdUsuarioUltAnu,
            this.colIdUsuarioUltMod,
            this.colip,
            this.colnom_pc,
            this.colFecha_UltAnu,
            this.colEstado});
            this.gridViewAnticipo.GridControl = this.gridControlAnticipo;
            this.gridViewAnticipo.Name = "gridViewAnticipo";
            this.gridViewAnticipo.OptionsBehavior.Editable = false;
            this.gridViewAnticipo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewAnticipo.OptionsView.ShowGroupPanel = false;
            this.gridViewAnticipo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewAnticipo_RowCellStyle);
            this.gridViewAnticipo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewAnticipo_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdAnticipo
            // 
            this.colIdAnticipo.FieldName = "IdAnticipo";
            this.colIdAnticipo.Name = "colIdAnticipo";
            this.colIdAnticipo.Visible = true;
            this.colIdAnticipo.VisibleIndex = 0;
            this.colIdAnticipo.Width = 64;
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 3;
            this.colObservacion.Width = 417;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            this.colFecha.Width = 58;
            // 
            // colIdCbteCble_Caja
            // 
            this.colIdCbteCble_Caja.FieldName = "IdCbteCble_Caja";
            this.colIdCbteCble_Caja.Name = "colIdCbteCble_Caja";
            this.colIdCbteCble_Caja.Width = 97;
            // 
            // colIdTipocbte_Caja
            // 
            this.colIdTipocbte_Caja.FieldName = "IdTipocbte_Caja";
            this.colIdTipocbte_Caja.Name = "colIdTipocbte_Caja";
            this.colIdTipocbte_Caja.Width = 91;
            // 
            // colIdEmpresa_Caja
            // 
            this.colIdEmpresa_Caja.FieldName = "IdEmpresa_Caja";
            this.colIdEmpresa_Caja.Name = "colIdEmpresa_Caja";
            this.colIdEmpresa_Caja.Width = 91;
            // 
            // colnombreCliente
            // 
            this.colnombreCliente.Caption = "Cliente";
            this.colnombreCliente.FieldName = "nombreCliente";
            this.colnombreCliente.Name = "colnombreCliente";
            this.colnombreCliente.Visible = true;
            this.colnombreCliente.VisibleIndex = 1;
            this.colnombreCliente.Width = 173;
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // colIdBanco
            // 
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            this.colFecha_Transac.Width = 82;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            this.colFecha_UltMod.Width = 80;
            // 
            // colIdUsuarioUltAnu
            // 
            this.colIdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Name = "colIdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Width = 96;
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            this.colIdUsuarioUltMod.Width = 97;
            // 
            // colip
            // 
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            // 
            // colnom_pc
            // 
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            // 
            // colFecha_UltAnu
            // 
            this.colFecha_UltAnu.FieldName = "Fecha_UltAnu";
            this.colFecha_UltAnu.Name = "colFecha_UltAnu";
            this.colFecha_UltAnu.Width = 79;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 4;
            this.colEstado.Width = 53;
            // 
            // cxccobroInfoBindingSource
            // 
            this.cxccobroInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_cobro_Info);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(783, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 100);
            this.panel1.TabIndex = 11;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 2, 17, 17, 10, 58, 491);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 4, 17, 17, 10, 58, 491);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(783, 97);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlAnticipo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 199);
            this.panel2.TabIndex = 12;
            // 
            // frmCxc_anticipo_clientes_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 321);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmCxc_anticipo_clientes_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Anticipo de Clientes";
            this.Load += new System.EventHandler(this.frmcxc_anticipo_clientes_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAnticipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroxAnticipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnticipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxccobroInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlAnticipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAnticipo;
        private System.Windows.Forms.BindingSource cxccobroInfoBindingSource;
        private System.Windows.Forms.BindingSource cxccobroxAnticipoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAnticipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble_Caja;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipocbte_Caja;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa_Caja;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
    }
}
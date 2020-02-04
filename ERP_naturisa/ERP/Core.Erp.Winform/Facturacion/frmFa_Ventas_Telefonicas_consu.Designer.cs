namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Ventas_Telefonicas_consu
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
            this.faventatelefonicaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSucursalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faClienteInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gridControlVentaFono = new DevExpress.XtraGrid.GridControl();
            this.gridViewVentaFono = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryCmbSucursal = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdVenta_tel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryCmbCliente = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMotivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactar_futuro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.faventatelefonicaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSucursalInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faClienteInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVentaFono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVentaFono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCmbSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCmbCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // faventatelefonicaInfoBindingSource
            // 
            this.faventatelefonicaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Facturacion.fa_venta_telefonica_Info);
            // 
            // tbSucursalInfoBindingSource
            // 
            this.tbSucursalInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Sucursal_Info);
            // 
            // faClienteInfoBindingSource
            // 
            this.faClienteInfoBindingSource.DataSource = typeof(Core.Erp.Info.Facturacion.fa_Cliente_Info);
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 5, 4, 17, 19, 47, 67);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 7, 4, 17, 19, 47, 67);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(847, 156);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 156);
            this.panel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(847, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gridControlVentaFono
            // 
            this.gridControlVentaFono.DataSource = this.faventatelefonicaInfoBindingSource;
            this.gridControlVentaFono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlVentaFono.Location = new System.Drawing.Point(0, 156);
            this.gridControlVentaFono.MainView = this.gridViewVentaFono;
            this.gridControlVentaFono.Name = "gridControlVentaFono";
            this.gridControlVentaFono.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryCmbSucursal,
            this.repositoryCmbCliente});
            this.gridControlVentaFono.Size = new System.Drawing.Size(847, 261);
            this.gridControlVentaFono.TabIndex = 7;
            this.gridControlVentaFono.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVentaFono});
            // 
            // gridViewVentaFono
            // 
            this.gridViewVentaFono.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colIdVenta_tel,
            this.colIdCliente,
            this.colFecha,
            this.colObservacion,
            this.colIdMotivo,
            this.colContactar_futuro,
            this.colIdUsuario,
            this.colEstado,
            this.colFecha_Transac,
            this.colIdUsuarioUltMod,
            this.colFecha_UltMod,
            this.colIdUsuarioUltAnu,
            this.colFecha_UltAnu,
            this.colnom_pc,
            this.colip});
            this.gridViewVentaFono.GridControl = this.gridControlVentaFono;
            this.gridViewVentaFono.Name = "gridViewVentaFono";
            this.gridViewVentaFono.OptionsBehavior.Editable = false;
            this.gridViewVentaFono.OptionsView.ShowAutoFilterRow = true;
            this.gridViewVentaFono.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewVentaFono.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewVentaFono_RowCellStyle);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.Caption = "Sucursal";
            this.colIdSucursal.ColumnEdit = this.repositoryCmbSucursal;
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.Visible = true;
            this.colIdSucursal.VisibleIndex = 0;
            this.colIdSucursal.Width = 85;
            // 
            // repositoryCmbSucursal
            // 
            this.repositoryCmbSucursal.AutoHeight = false;
            this.repositoryCmbSucursal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryCmbSucursal.DataSource = this.tbSucursalInfoBindingSource;
            this.repositoryCmbSucursal.DisplayMember = "Su_Descripcion";
            this.repositoryCmbSucursal.Name = "repositoryCmbSucursal";
            this.repositoryCmbSucursal.ValueMember = "IdSucursal";
            this.repositoryCmbSucursal.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdVenta_tel
            // 
            this.colIdVenta_tel.Caption = "ID Venta ";
            this.colIdVenta_tel.FieldName = "IdVenta_tel";
            this.colIdVenta_tel.Name = "colIdVenta_tel";
            this.colIdVenta_tel.Visible = true;
            this.colIdVenta_tel.VisibleIndex = 2;
            this.colIdVenta_tel.Width = 102;
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "Cliente";
            this.colIdCliente.ColumnEdit = this.repositoryCmbCliente;
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.Visible = true;
            this.colIdCliente.VisibleIndex = 1;
            this.colIdCliente.Width = 102;
            // 
            // repositoryCmbCliente
            // 
            this.repositoryCmbCliente.AutoHeight = false;
            this.repositoryCmbCliente.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryCmbCliente.DataSource = this.faClienteInfoBindingSource;
            this.repositoryCmbCliente.DisplayMember = "Nombre_Cliente";
            this.repositoryCmbCliente.Name = "repositoryCmbCliente";
            this.repositoryCmbCliente.PopupFormSize = new System.Drawing.Size(500, 200);
            this.repositoryCmbCliente.ValueMember = "IdCliente";
            this.repositoryCmbCliente.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 3;
            this.colFecha.Width = 102;
            // 
            // colObservacion
            // 
            this.colObservacion.Caption = "Observación";
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 4;
            this.colObservacion.Width = 102;
            // 
            // colIdMotivo
            // 
            this.colIdMotivo.Caption = "Motivo";
            this.colIdMotivo.FieldName = "IdMotivo";
            this.colIdMotivo.Name = "colIdMotivo";
            this.colIdMotivo.Visible = true;
            this.colIdMotivo.VisibleIndex = 5;
            this.colIdMotivo.Width = 102;
            // 
            // colContactar_futuro
            // 
            this.colContactar_futuro.Caption = "Contartar a Futuro";
            this.colContactar_futuro.FieldName = "Contactar_futuro";
            this.colContactar_futuro.Name = "colContactar_futuro";
            this.colContactar_futuro.Visible = true;
            this.colContactar_futuro.VisibleIndex = 6;
            this.colContactar_futuro.Width = 102;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
            this.colEstado.Width = 108;
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
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
            // frmFa_Ventas_Telefonicas_consu
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 439);
            this.Controls.Add(this.gridControlVentaFono);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmFa_Ventas_Telefonicas_consu";
            this.Text = "Ventas Telefonicas";
            this.Load += new System.EventHandler(this.frmFa_Ventas_Telefonicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.faventatelefonicaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSucursalInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faClienteInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVentaFono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVentaFono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCmbSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCmbCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource faventatelefonicaInfoBindingSource;
        private System.Windows.Forms.BindingSource tbSucursalInfoBindingSource;
        private System.Windows.Forms.BindingSource faClienteInfoBindingSource;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.GridControl gridControlVentaFono;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVentaFono;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryCmbSucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdVenta_tel;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryCmbCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivo;
        private DevExpress.XtraGrid.Columns.GridColumn colContactar_futuro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
    }
}
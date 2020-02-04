namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Sucursal_consul
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControlSucursal = new DevExpress.XtraGrid.GridControl();
            this.gridViewSucursal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_CodigoEstablecimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Ubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Ruc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_JefeSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Telefonos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(615, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 94);
            this.panel1.TabIndex = 5;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 3, 2, 15, 50, 36, 145);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 5, 2, 15, 50, 36, 145);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(615, 94);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlSucursal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 314);
            this.panel2.TabIndex = 6;
            // 
            // gridControlSucursal
            // 
            this.gridControlSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSucursal.Location = new System.Drawing.Point(0, 0);
            this.gridControlSucursal.MainView = this.gridViewSucursal;
            this.gridControlSucursal.Name = "gridControlSucursal";
            this.gridControlSucursal.Size = new System.Drawing.Size(615, 314);
            this.gridControlSucursal.TabIndex = 2;
            this.gridControlSucursal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSucursal});
            // 
            // gridViewSucursal
            // 
            this.gridViewSucursal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdEmpresa,
            this.colIdSucursal,
            this.colcodigo,
            this.colSu_Descripcion,
            this.colSu_CodigoEstablecimiento,
            this.colSu_Ubicacion,
            this.colSu_Ruc,
            this.colSu_JefeSucursal,
            this.colSu_Telefonos,
            this.colSu_Direccion,
            this.colIdUsuario,
            this.colFecha_Transac,
            this.colIdUsuarioUltMod,
            this.colFecha_UltMod,
            this.colIdUsuarioUltAnu,
            this.colFecha_UltAnu,
            this.colnom_pc,
            this.colip,
            this.colEstado});
            this.gridViewSucursal.GridControl = this.gridControlSucursal;
            this.gridViewSucursal.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridViewSucursal.Name = "gridViewSucursal";
            this.gridViewSucursal.OptionsBehavior.Editable = false;
            this.gridViewSucursal.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSucursal.OptionsView.ShowGroupPanel = false;
            this.gridViewSucursal.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewSucursal_RowClick);
            this.gridViewSucursal.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewSucursal_RowCellStyle);
            this.gridViewSucursal.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSucursal_FocusedRowChanged);
            this.gridViewSucursal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridViewSucursal_KeyUp);
            this.gridViewSucursal.DoubleClick += new System.EventHandler(this.gridViewSucursal_DoubleClick);
            // 
            // ColIdEmpresa
            // 
            this.ColIdEmpresa.Caption = "Empresa";
            this.ColIdEmpresa.FieldName = "IdEmpresa";
            this.ColIdEmpresa.Name = "ColIdEmpresa";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.Caption = "Sucursal";
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.Visible = true;
            this.colIdSucursal.VisibleIndex = 0;
            this.colIdSucursal.Width = 145;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Descripcion";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 1;
            this.colSu_Descripcion.Width = 294;
            // 
            // colSu_CodigoEstablecimiento
            // 
            this.colSu_CodigoEstablecimiento.Caption = "Establecimiento";
            this.colSu_CodigoEstablecimiento.FieldName = "Su_CodigoEstablecimiento";
            this.colSu_CodigoEstablecimiento.Name = "colSu_CodigoEstablecimiento";
            this.colSu_CodigoEstablecimiento.Visible = true;
            this.colSu_CodigoEstablecimiento.VisibleIndex = 3;
            this.colSu_CodigoEstablecimiento.Width = 337;
            // 
            // colSu_Ubicacion
            // 
            this.colSu_Ubicacion.Caption = "Ubicacion";
            this.colSu_Ubicacion.FieldName = "Su_Ubicacion";
            this.colSu_Ubicacion.Name = "colSu_Ubicacion";
            // 
            // colSu_Ruc
            // 
            this.colSu_Ruc.Caption = "Ruc";
            this.colSu_Ruc.FieldName = "Su_Ruc";
            this.colSu_Ruc.Name = "colSu_Ruc";
            // 
            // colSu_JefeSucursal
            // 
            this.colSu_JefeSucursal.Caption = "Jefe";
            this.colSu_JefeSucursal.FieldName = "Su_JefeSucursal";
            this.colSu_JefeSucursal.Name = "colSu_JefeSucursal";
            // 
            // colSu_Telefonos
            // 
            this.colSu_Telefonos.Caption = "Telefono";
            this.colSu_Telefonos.FieldName = "Su_Telefonos";
            this.colSu_Telefonos.Name = "colSu_Telefonos";
            // 
            // colSu_Direccion
            // 
            this.colSu_Direccion.Caption = "Direccion";
            this.colSu_Direccion.FieldName = "Su_Direccion";
            this.colSu_Direccion.Name = "colSu_Direccion";
            this.colSu_Direccion.Visible = true;
            this.colSu_Direccion.VisibleIndex = 2;
            this.colSu_Direccion.Width = 294;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.Caption = "IdUsuario";
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.Caption = "Fecha_Transac";
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.Caption = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.Caption = "Fecha_UltMod";
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            // 
            // colIdUsuarioUltAnu
            // 
            this.colIdUsuarioUltAnu.Caption = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Name = "colIdUsuarioUltAnu";
            // 
            // colFecha_UltAnu
            // 
            this.colFecha_UltAnu.Caption = "Fecha_UltAnu";
            this.colFecha_UltAnu.FieldName = "Fecha_UltAnu";
            this.colFecha_UltAnu.Name = "colFecha_UltAnu";
            // 
            // colnom_pc
            // 
            this.colnom_pc.Caption = "nom_pc";
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            // 
            // colip
            // 
            this.colip.Caption = "ip";
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 4;
            this.colEstado.Width = 94;
            // 
            // frmFa_Sucursal_consul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 430);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmFa_Sucursal_consul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Sucursales";
            this.Load += new System.EventHandler(this.frmFA_Sucursal_General_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControlSucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_CodigoEstablecimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Ubicacion;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Ruc;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_JefeSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Telefonos;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Direccion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;

    }
}
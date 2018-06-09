namespace Core.Erp.Winform.Produccion_Talme
{
    partial class frmProd_Gestion_Prod_Lamin_Cons
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
            this.gridControlOrdeCompra = new DevExpress.XtraGrid.GridControl();
            this.prodGestionProductivaLaminadoCusTalmeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGestionProductiva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_Orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEficienciaProduccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre_JefeTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_turno_ini = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_turno_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdeCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodGestionProductivaLaminadoCusTalmeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlOrdeCompra
            // 
            this.gridControlOrdeCompra.DataSource = this.prodGestionProductivaLaminadoCusTalmeInfoBindingSource;
            this.gridControlOrdeCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrdeCompra.Location = new System.Drawing.Point(0, 0);
            this.gridControlOrdeCompra.MainView = this.gridView;
            this.gridControlOrdeCompra.Name = "gridControlOrdeCompra";
            this.gridControlOrdeCompra.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControlOrdeCompra.Size = new System.Drawing.Size(1061, 284);
            this.gridControlOrdeCompra.TabIndex = 8;
            this.gridControlOrdeCompra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // prodGestionProductivaLaminadoCusTalmeInfoBindingSource
            // 
            this.prodGestionProductivaLaminadoCusTalmeInfoBindingSource.DataSource = typeof(Core.Erp.Info.Produccion_Talme.prod_GestionProductivaLaminado_CusTalme_Info);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGestionProductiva,
            this.colNum_Orden,
            this.colEficienciaProduccion,
            this.colEstado,
            this.colFecha,
            this.colNombre_JefeTurno,
            this.colDescripcion,
            this.colhora_turno_ini,
            this.colhora_turno_fin});
            this.gridView.GridControl = this.gridControlOrdeCompra;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_RowCellClick);
            // 
            // colIdGestionProductiva
            // 
            this.colIdGestionProductiva.Caption = "Id Gestion Productiva";
            this.colIdGestionProductiva.FieldName = "IdGestionProductiva";
            this.colIdGestionProductiva.Name = "colIdGestionProductiva";
            this.colIdGestionProductiva.Visible = true;
            this.colIdGestionProductiva.VisibleIndex = 0;
            this.colIdGestionProductiva.Width = 46;
            // 
            // colNum_Orden
            // 
            this.colNum_Orden.Caption = "Num. Orden";
            this.colNum_Orden.FieldName = "Num_Orden";
            this.colNum_Orden.Name = "colNum_Orden";
            this.colNum_Orden.Visible = true;
            this.colNum_Orden.VisibleIndex = 1;
            this.colNum_Orden.Width = 85;
            // 
            // colEficienciaProduccion
            // 
            this.colEficienciaProduccion.Caption = "Eficiencia Produccion";
            this.colEficienciaProduccion.FieldName = "EficienciaProduccion";
            this.colEficienciaProduccion.Name = "colEficienciaProduccion";
            this.colEficienciaProduccion.Visible = true;
            this.colEficienciaProduccion.VisibleIndex = 6;
            this.colEficienciaProduccion.Width = 133;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 8;
            this.colEstado.Width = 147;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 7;
            this.colFecha.Width = 133;
            // 
            // colNombre_JefeTurno
            // 
            this.colNombre_JefeTurno.Caption = "Jefe De Turno";
            this.colNombre_JefeTurno.FieldName = "Nombre_JefeTurno";
            this.colNombre_JefeTurno.Name = "colNombre_JefeTurno";
            this.colNombre_JefeTurno.Visible = true;
            this.colNombre_JefeTurno.VisibleIndex = 2;
            this.colNombre_JefeTurno.Width = 154;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Turno";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 3;
            this.colDescripcion.Width = 154;
            // 
            // colhora_turno_ini
            // 
            this.colhora_turno_ini.Caption = "Hora Inicio Turno";
            this.colhora_turno_ini.FieldName = "hora_turno_ini";
            this.colhora_turno_ini.Name = "colhora_turno_ini";
            this.colhora_turno_ini.Visible = true;
            this.colhora_turno_ini.VisibleIndex = 4;
            this.colhora_turno_ini.Width = 101;
            // 
            // colhora_turno_fin
            // 
            this.colhora_turno_fin.Caption = "Hora Fin Turno";
            this.colhora_turno_fin.FieldName = "hora_turno_fin";
            this.colhora_turno_fin.Name = "colhora_turno_fin";
            this.colhora_turno_fin.Visible = true;
            this.colhora_turno_fin.VisibleIndex = 5;
            this.colhora_turno_fin.Width = 90;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 6, 14, 27, 12, 887);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 6, 14, 27, 12, 887);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1061, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 9;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlOrdeCompra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 284);
            this.panel1.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1061, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmProd_Gestion_Prod_Lamin_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 439);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "frmProd_Gestion_Prod_Lamin_Cons";
            this.Text = "Gestion Productiva Laminados Consulta";
            this.Load += new System.EventHandler(this.frmProd_Diara_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrdeCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodGestionProductivaLaminadoCusTalmeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlOrdeCompra;
        private System.Windows.Forms.BindingSource prodGestionProductivaLaminadoCusTalmeInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGestionProductiva;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_Orden;
        private DevExpress.XtraGrid.Columns.GridColumn colEficienciaProduccion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre_JefeTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_turno_ini;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_turno_fin;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
namespace Core.Erp.Winform.Produccion_Talme
{
    partial class frmProd_GestionProductivaTechos_Consulta
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
            this.prodGestionProductivaTechosCusTalmeCabInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGestionProductiva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto_MateriaPrima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEsEje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHrsTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTprep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDespacho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNum_Personas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsumo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChatarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltModi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdusuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodGestionProductivaTechosCusTalmeCabInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
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
            this.gridControl.DataSource = this.prodGestionProductivaTechosCusTalmeCabInfoBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 157);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl.Size = new System.Drawing.Size(1070, 227);
            this.gridControl.TabIndex = 8;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // prodGestionProductivaTechosCusTalmeCabInfoBindingSource
            // 
            this.prodGestionProductivaTechosCusTalmeCabInfoBindingSource.DataSource = typeof(Core.Erp.Info.Produccion_Talme.prod_GestionProductivaTechos_CusTalme_Cab_Info);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdGestionProductiva,
            this.colIdProducto_MateriaPrima,
            this.colFecha,
            this.colEsEje,
            this.colHrsTurno,
            this.colTprep,
            this.colDespacho,
            this.colFactor,
            this.colNum_Personas,
            this.colConsumo,
            this.colChatarra,
            this.colIdTurno,
            this.colIdUsuario,
            this.colFecha_Transac,
            this.colIdUsuarioUltModi,
            this.colFecha_UltMod,
            this.colIdusuarioUltAnu,
            this.colFecha_UltAnu,
            this.colnom_pc,
            this.colip,
            this.colEstado,
            this.colDescripcion,
            this.colpr_descripcion});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdGestionProductiva, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdGestionProductiva
            // 
            this.colIdGestionProductiva.FieldName = "IdGestionProductiva";
            this.colIdGestionProductiva.Name = "colIdGestionProductiva";
            this.colIdGestionProductiva.Visible = true;
            this.colIdGestionProductiva.VisibleIndex = 0;
            // 
            // colIdProducto_MateriaPrima
            // 
            this.colIdProducto_MateriaPrima.FieldName = "IdProducto_MateriaPrima";
            this.colIdProducto_MateriaPrima.Name = "colIdProducto_MateriaPrima";
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 3;
            // 
            // colEsEje
            // 
            this.colEsEje.FieldName = "EsEje";
            this.colEsEje.Name = "colEsEje";
            // 
            // colHrsTurno
            // 
            this.colHrsTurno.FieldName = "HrsTurno";
            this.colHrsTurno.Name = "colHrsTurno";
            this.colHrsTurno.Visible = true;
            this.colHrsTurno.VisibleIndex = 4;
            // 
            // colTprep
            // 
            this.colTprep.FieldName = "Tprep";
            this.colTprep.Name = "colTprep";
            this.colTprep.Visible = true;
            this.colTprep.VisibleIndex = 5;
            // 
            // colDespacho
            // 
            this.colDespacho.FieldName = "Despacho";
            this.colDespacho.Name = "colDespacho";
            this.colDespacho.Visible = true;
            this.colDespacho.VisibleIndex = 6;
            // 
            // colFactor
            // 
            this.colFactor.FieldName = "Factor";
            this.colFactor.Name = "colFactor";
            this.colFactor.Visible = true;
            this.colFactor.VisibleIndex = 7;
            // 
            // colNum_Personas
            // 
            this.colNum_Personas.FieldName = "Num_Personas";
            this.colNum_Personas.Name = "colNum_Personas";
            this.colNum_Personas.Visible = true;
            this.colNum_Personas.VisibleIndex = 8;
            // 
            // colConsumo
            // 
            this.colConsumo.FieldName = "Consumo";
            this.colConsumo.Name = "colConsumo";
            this.colConsumo.Visible = true;
            this.colConsumo.VisibleIndex = 9;
            // 
            // colChatarra
            // 
            this.colChatarra.FieldName = "Chatarra";
            this.colChatarra.Name = "colChatarra";
            this.colChatarra.Visible = true;
            this.colChatarra.VisibleIndex = 10;
            // 
            // colIdTurno
            // 
            this.colIdTurno.FieldName = "IdTurno";
            this.colIdTurno.Name = "colIdTurno";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            // 
            // colIdUsuarioUltModi
            // 
            this.colIdUsuarioUltModi.FieldName = "IdUsuarioUltModi";
            this.colIdUsuarioUltModi.Name = "colIdUsuarioUltModi";
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            // 
            // colIdusuarioUltAnu
            // 
            this.colIdusuarioUltAnu.FieldName = "IdusuarioUltAnu";
            this.colIdusuarioUltAnu.Name = "colIdusuarioUltAnu";
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
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 11;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Turno";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Materia Prima";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1070, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 157);
            this.panel2.TabIndex = 19;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 3, 28, 9, 8, 9, 131);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 5, 28, 9, 8, 9, 132);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1070, 155);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
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
            // frmProd_GestionProductivaTechos_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 406);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmProd_GestionProductivaTechos_Consulta";
            this.Text = "Gestion Productiva Techos Consulta";
            this.Load += new System.EventHandler(this.frmProd_GestionProductivaTechos_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodGestionProductivaTechosCusTalmeCabInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.BindingSource prodGestionProductivaTechosCusTalmeCabInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGestionProductiva;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto_MateriaPrima;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colEsEje;
        private DevExpress.XtraGrid.Columns.GridColumn colHrsTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colTprep;
        private DevExpress.XtraGrid.Columns.GridColumn colDespacho;
        private DevExpress.XtraGrid.Columns.GridColumn colFactor;
        private DevExpress.XtraGrid.Columns.GridColumn colNum_Personas;
        private DevExpress.XtraGrid.Columns.GridColumn colConsumo;
        private DevExpress.XtraGrid.Columns.GridColumn colChatarra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltModi;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdusuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
    }
}
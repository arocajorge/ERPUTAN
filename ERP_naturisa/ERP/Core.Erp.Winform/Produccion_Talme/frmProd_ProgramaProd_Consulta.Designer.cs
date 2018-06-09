namespace Core.Erp.Winform.Produccion_Talme
{
    partial class frmProd_ProgramaProd_Consulta
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridCtrPrograma = new DevExpress.XtraGrid.GridControl();
            this.prodProgramaProdInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewProgramaP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ColProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColToneladas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPedidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProgramaProd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTurno1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryTurno = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryProducto = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion_Pro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Men_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrPrograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodProgramaProdInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProgramaP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCtrPrograma
            // 
            this.gridCtrPrograma.DataSource = this.prodProgramaProdInfoBindingSource;
            this.gridCtrPrograma.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridCtrPrograma.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridCtrPrograma.Location = new System.Drawing.Point(0, 0);
            this.gridCtrPrograma.MainView = this.gridViewProgramaP;
            this.gridCtrPrograma.Name = "gridCtrPrograma";
            this.gridCtrPrograma.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTurno,
            this.repositoryProducto,
            this.repositoryItemDateEdit1,
            this.repositoryItemTimeEdit1,
            this.repositoryItemCheckEdit1});
            this.gridCtrPrograma.Size = new System.Drawing.Size(743, 223);
            this.gridCtrPrograma.TabIndex = 69;
            this.gridCtrPrograma.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProgramaP});
            // 
            // prodProgramaProdInfoBindingSource
            // 
            this.prodProgramaProdInfoBindingSource.DataSource = typeof(Core.Erp.Info.Produccion_Talme.prod_ProgramaProd_Info);
            // 
            // gridViewProgramaP
            // 
            this.gridViewProgramaP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdTurno,
            this.ColFecha,
            this.ColProducto,
            this.ColUnidad,
            this.ColPeso,
            this.ColToneladas,
            this.ColPedidos,
            this.colIdProgramaProd,
            this.colIdTurno1,
            this.colIdEmpresa,
            this.colEstado,
            this.colIdCategoria,
            this.colNomProducto});
            this.gridViewProgramaP.CustomizationFormBounds = new System.Drawing.Rectangle(512, 442, 216, 185);
            this.gridViewProgramaP.GridControl = this.gridCtrPrograma;
            this.gridViewProgramaP.Name = "gridViewProgramaP";
            this.gridViewProgramaP.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewProgramaP.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewProgramaP.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProgramaP.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.ColIdTurno, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewProgramaP.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewProgramaP_RowCellStyle);
            // 
            // ColIdTurno
            // 
            this.ColIdTurno.Caption = "Turno";
            this.ColIdTurno.FieldName = "IdTurno";
            this.ColIdTurno.Name = "ColIdTurno";
            this.ColIdTurno.Width = 139;
            // 
            // ColFecha
            // 
            this.ColFecha.Caption = "Fecha";
            this.ColFecha.ColumnEdit = this.repositoryItemDateEdit1;
            this.ColFecha.DisplayFormat.FormatString = "d";
            this.ColFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColFecha.FieldName = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.Visible = true;
            this.ColFecha.VisibleIndex = 0;
            this.ColFecha.Width = 87;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // ColProducto
            // 
            this.ColProducto.Caption = "Producto";
            this.ColProducto.FieldName = "IdProducto";
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.Width = 270;
            // 
            // ColUnidad
            // 
            this.ColUnidad.Caption = "Unidad";
            this.ColUnidad.FieldName = "Unidad";
            this.ColUnidad.Name = "ColUnidad";
            this.ColUnidad.Visible = true;
            this.ColUnidad.VisibleIndex = 4;
            this.ColUnidad.Width = 162;
            // 
            // ColPeso
            // 
            this.ColPeso.Caption = "Peso";
            this.ColPeso.FieldName = "Peso";
            this.ColPeso.Name = "ColPeso";
            this.ColPeso.Visible = true;
            this.ColPeso.VisibleIndex = 5;
            this.ColPeso.Width = 167;
            // 
            // ColToneladas
            // 
            this.ColToneladas.Caption = "Toneladas";
            this.ColToneladas.FieldName = "Toneladas";
            this.ColToneladas.Name = "ColToneladas";
            this.ColToneladas.Visible = true;
            this.ColToneladas.VisibleIndex = 6;
            this.ColToneladas.Width = 96;
            // 
            // ColPedidos
            // 
            this.ColPedidos.Caption = "Pedidos";
            this.ColPedidos.FieldName = "Pedidos";
            this.ColPedidos.Name = "ColPedidos";
            this.ColPedidos.Visible = true;
            this.ColPedidos.VisibleIndex = 7;
            this.ColPedidos.Width = 141;
            // 
            // colIdProgramaProd
            // 
            this.colIdProgramaProd.Caption = "#Reg Programa de Producción";
            this.colIdProgramaProd.FieldName = "IdProgramaProd";
            this.colIdProgramaProd.Name = "colIdProgramaProd";
            this.colIdProgramaProd.Visible = true;
            this.colIdProgramaProd.VisibleIndex = 1;
            this.colIdProgramaProd.Width = 91;
            // 
            // colIdTurno1
            // 
            this.colIdTurno1.Caption = "Turno";
            this.colIdTurno1.FieldName = "Turno";
            this.colIdTurno1.Name = "colIdTurno1";
            this.colIdTurno1.Visible = true;
            this.colIdTurno1.VisibleIndex = 2;
            this.colIdTurno1.Width = 120;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 8;
            this.colEstado.Width = 62;
            // 
            // colIdCategoria
            // 
            this.colIdCategoria.FieldName = "IdCategoria";
            this.colIdCategoria.Name = "colIdCategoria";
            // 
            // colNomProducto
            // 
            this.colNomProducto.Caption = "Producto";
            this.colNomProducto.FieldName = "Producto";
            this.colNomProducto.Name = "colNomProducto";
            this.colNomProducto.Visible = true;
            this.colNomProducto.VisibleIndex = 3;
            this.colNomProducto.Width = 222;
            // 
            // repositoryTurno
            // 
            this.repositoryTurno.AutoHeight = false;
            this.repositoryTurno.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTurno.DisplayMember = "Descripcion";
            this.repositoryTurno.HideSelection = false;
            this.repositoryTurno.Name = "repositoryTurno";
            this.repositoryTurno.ValueMember = "IdTurno";
            this.repositoryTurno.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTurno,
            this.colDescripcion});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colTurno
            // 
            this.colTurno.Caption = "IdTurno";
            this.colTurno.FieldName = "IdTurno";
            this.colTurno.Name = "colTurno";
            this.colTurno.Visible = true;
            this.colTurno.VisibleIndex = 0;
            this.colTurno.Width = 267;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 907;
            // 
            // repositoryProducto
            // 
            this.repositoryProducto.AutoHeight = false;
            this.repositoryProducto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryProducto.DisplayMember = "pr_descripcion";
            this.repositoryProducto.Name = "repositoryProducto";
            this.repositoryProducto.ValueMember = "IdProducto";
            this.repositoryProducto.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colDescripcion_Pro});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "IdProducto";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 0;
            this.colIdProducto.Width = 306;
            // 
            // colDescripcion_Pro
            // 
            this.colDescripcion_Pro.Caption = "Descripción";
            this.colDescripcion_Pro.FieldName = "pr_descripcion";
            this.colDescripcion_Pro.Name = "colDescripcion_Pro";
            this.colDescripcion_Pro.Visible = true;
            this.colDescripcion_Pro.VisibleIndex = 1;
            this.colDescripcion_Pro.Width = 868;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Men_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 157);
            this.panel1.TabIndex = 74;
            // 
            // ucGe_Men_Mantenimiento_x_usuario
            // 
            this.ucGe_Men_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Men_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Men_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Men_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Men_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Men_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Men_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Men_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Men_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 3, 28, 9, 20, 28, 797);
            this.ucGe_Men_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 5, 28, 9, 20, 28, 797);
            this.ucGe_Men_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Men_Mantenimiento_x_usuario.Name = "ucGe_Men_Mantenimiento_x_usuario";
            this.ucGe_Men_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Men_Mantenimiento_x_usuario.Size = new System.Drawing.Size(743, 154);
            this.ucGe_Men_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Men_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Men_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Men_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Men_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Men_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Men_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Men_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Men_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Men_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Men_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Men_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Men_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Men_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Men_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridCtrPrograma);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 223);
            this.panel2.TabIndex = 75;
            // 
            // frmProd_ProgramaProd_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 380);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmProd_ProgramaProd_Consulta";
            this.Text = "Programa de Producción";
            this.Load += new System.EventHandler(this.frmProd_ProgramaProd_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrPrograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodProgramaProdInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProgramaP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource prodProgramaProdInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridCtrPrograma;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewProgramaP;
        public DevExpress.XtraGrid.Columns.GridColumn ColIdTurno;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryTurno;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        public DevExpress.XtraGrid.Columns.GridColumn ColFecha;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        public DevExpress.XtraGrid.Columns.GridColumn ColProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion_Pro;
        public DevExpress.XtraGrid.Columns.GridColumn ColUnidad;
        public DevExpress.XtraGrid.Columns.GridColumn ColPeso;
        public DevExpress.XtraGrid.Columns.GridColumn ColToneladas;
        public DevExpress.XtraGrid.Columns.GridColumn ColPedidos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProgramaProd;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTurno1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoria;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colNomProducto;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Men_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;

    }
}
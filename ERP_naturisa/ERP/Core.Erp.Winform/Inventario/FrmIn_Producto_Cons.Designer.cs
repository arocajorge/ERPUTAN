namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Producto_Cons
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
            this.gridControlProducto = new DevExpress.XtraGrid.GridControl();
            this.gridViewProducto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_Categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_Linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducto)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlProducto
            // 
            this.gridControlProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProducto.Location = new System.Drawing.Point(0, 0);
            this.gridControlProducto.MainView = this.gridViewProducto;
            this.gridControlProducto.Name = "gridControlProducto";
            this.gridControlProducto.Size = new System.Drawing.Size(1129, 382);
            this.gridControlProducto.TabIndex = 14;
            this.gridControlProducto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducto});
            // 
            // gridViewProducto
            // 
            this.gridViewProducto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colpr_descripcion,
            this.colEstado,
            this.colTipo_Producto,
            this.colca_Categoria,
            this.col_nom_Linea,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewProducto.GridControl = this.gridControlProducto;
            this.gridViewProducto.Name = "gridViewProducto";
            this.gridViewProducto.OptionsBehavior.Editable = false;
            this.gridViewProducto.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProducto.OptionsView.ShowGroupPanel = false;
            this.gridViewProducto.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewProducto_RowClick);
            this.gridViewProducto.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewProducto_RowCellClick);
            this.gridViewProducto.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewProducto_RowCellStyle);
            this.gridViewProducto.DoubleClick += new System.EventHandler(this.gridViewProducto_DoubleClick);
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "Id";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 0;
            this.colIdProducto.Width = 133;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripción";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 1;
            this.colpr_descripcion.Width = 342;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 9;
            this.colEstado.Width = 153;
            // 
            // colTipo_Producto
            // 
            this.colTipo_Producto.Caption = "Tipo Producto";
            this.colTipo_Producto.FieldName = "nom_Tipo_Producto";
            this.colTipo_Producto.Name = "colTipo_Producto";
            this.colTipo_Producto.Visible = true;
            this.colTipo_Producto.VisibleIndex = 2;
            this.colTipo_Producto.Width = 182;
            // 
            // colca_Categoria
            // 
            this.colca_Categoria.Caption = "Categoria";
            this.colca_Categoria.FieldName = "nom_Categoria";
            this.colca_Categoria.Name = "colca_Categoria";
            this.colca_Categoria.Visible = true;
            this.colca_Categoria.VisibleIndex = 3;
            this.colca_Categoria.Width = 142;
            // 
            // col_nom_Linea
            // 
            this.col_nom_Linea.Caption = "Linea";
            this.col_nom_Linea.FieldName = "nom_Linea";
            this.col_nom_Linea.Name = "col_nom_Linea";
            this.col_nom_Linea.Visible = true;
            this.col_nom_Linea.VisibleIndex = 4;
            this.col_nom_Linea.Width = 132;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucGe_Menu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 180);
            this.panel2.TabIndex = 7;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.CargarTodasBodegas = false;
            this.ucGe_Menu.CargarTodasSucursales = true;
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_anular = true;
            this.ucGe_Menu.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu.Enable_boton_consultar = true;
            this.ucGe_Menu.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu.Enable_boton_Duplicar = true;
            this.ucGe_Menu.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu.Enable_boton_GenerarXml = true;
            this.ucGe_Menu.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu.Enable_boton_Importar_XML = true;
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2020, 11, 16, 0, 0, 0, 0);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2020, 11, 23, 0, 0, 0, 0);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(1129, 179);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_beiCerrar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_event_btnBuscar_Click);
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 562);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(1129, 26);
            this.ucGe_BarraEstado.TabIndex = 15;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gridControlProducto);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 180);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1129, 382);
            this.panelMain.TabIndex = 16;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Grupo";
            this.gridColumn1.FieldName = "nom_Grupo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 153;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Familia";
            this.gridColumn2.FieldName = "fa_Descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 195;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "U. Compra";
            this.gridColumn3.FieldName = "nom_UnidadMedida";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 7;
            this.gridColumn3.Width = 153;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "U. Consumo";
            this.gridColumn4.FieldName = "nom_UnidadMedida_Consumo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            this.gridColumn4.Width = 149;
            // 
            // FrmIn_Producto_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 588);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Controls.Add(this.panel2);
            this.Name = "FrmIn_Producto_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Producto_Cons_FormClosing);
            this.Load += new System.EventHandler(this.frmIn_ProductoConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        
        private DevExpress.XtraGrid.GridControl gridControlProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo_Producto;
        private DevExpress.XtraGrid.Columns.GridColumn colca_Categoria;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private System.Windows.Forms.Panel panelMain;
        public Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_Linea;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;

    }
}
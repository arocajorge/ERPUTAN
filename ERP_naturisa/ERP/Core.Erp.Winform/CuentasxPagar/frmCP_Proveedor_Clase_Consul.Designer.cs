namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_Proveedor_Clase_Consul
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
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlClaseProveedor = new DevExpress.XtraGrid.GridControl();
            this.gridViewClaseProveedor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdClaseProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion_clas_prove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Anticipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_gasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCentroCosto_sub_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_CXP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClaseProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClaseProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 419);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(830, 26);
            this.ucGe_BarraEstado.TabIndex = 0;
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2016, 12, 10, 12, 12, 38, 794);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 2, 10, 12, 12, 38, 794);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(830, 176);
            this.ucGe_Menu.TabIndex = 1;
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
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlClaseProveedor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 243);
            this.panel1.TabIndex = 2;
            // 
            // gridControlClaseProveedor
            // 
            this.gridControlClaseProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlClaseProveedor.Location = new System.Drawing.Point(0, 0);
            this.gridControlClaseProveedor.MainView = this.gridViewClaseProveedor;
            this.gridControlClaseProveedor.Name = "gridControlClaseProveedor";
            this.gridControlClaseProveedor.Size = new System.Drawing.Size(830, 243);
            this.gridControlClaseProveedor.TabIndex = 0;
            this.gridControlClaseProveedor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClaseProveedor});
            this.gridControlClaseProveedor.Click += new System.EventHandler(this.gridControlClaseProveedor_Click);
            // 
            // gridViewClaseProveedor
            // 
            this.gridViewClaseProveedor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdClaseProveedor,
            this.coldescripcion_clas_prove,
            this.colIdCtaCble_Anticipo,
            this.colIdCtaCble_gasto,
            this.colIdCentroCosto,
            this.colIdCentroCosto_sub_centro_costo,
            this.colEstado,
            this.colcodigo,
            this.colIdCtaCble_CXP});
            this.gridViewClaseProveedor.GridControl = this.gridControlClaseProveedor;
            this.gridViewClaseProveedor.Name = "gridViewClaseProveedor";
            this.gridViewClaseProveedor.OptionsView.ShowGroupPanel = false;
            this.gridViewClaseProveedor.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewClaseProveedor_RowCellStyle);
            // 
            // colIdClaseProveedor
            // 
            this.colIdClaseProveedor.Caption = "IdClaseProveedor";
            this.colIdClaseProveedor.FieldName = "IdClaseProveedor";
            this.colIdClaseProveedor.Name = "colIdClaseProveedor";
            this.colIdClaseProveedor.OptionsColumn.ReadOnly = true;
            this.colIdClaseProveedor.Visible = true;
            this.colIdClaseProveedor.VisibleIndex = 0;
            this.colIdClaseProveedor.Width = 119;
            // 
            // coldescripcion_clas_prove
            // 
            this.coldescripcion_clas_prove.Caption = "Descripcion";
            this.coldescripcion_clas_prove.FieldName = "descripcion_clas_prove";
            this.coldescripcion_clas_prove.Name = "coldescripcion_clas_prove";
            this.coldescripcion_clas_prove.OptionsColumn.ReadOnly = true;
            this.coldescripcion_clas_prove.Visible = true;
            this.coldescripcion_clas_prove.VisibleIndex = 2;
            this.coldescripcion_clas_prove.Width = 539;
            // 
            // colIdCtaCble_Anticipo
            // 
            this.colIdCtaCble_Anticipo.Caption = "IdCtaCble_Anticipo";
            this.colIdCtaCble_Anticipo.FieldName = "IdCtaCble_Anticipo";
            this.colIdCtaCble_Anticipo.Name = "colIdCtaCble_Anticipo";
            this.colIdCtaCble_Anticipo.OptionsColumn.ReadOnly = true;
            this.colIdCtaCble_Anticipo.Width = 160;
            // 
            // colIdCtaCble_gasto
            // 
            this.colIdCtaCble_gasto.Caption = "IdCtaCble_gasto";
            this.colIdCtaCble_gasto.FieldName = "IdCtaCble_gasto";
            this.colIdCtaCble_gasto.Name = "colIdCtaCble_gasto";
            this.colIdCtaCble_gasto.OptionsColumn.ReadOnly = true;
            this.colIdCtaCble_gasto.Width = 86;
            // 
            // colIdCentroCosto
            // 
            this.colIdCentroCosto.Caption = "IdCentroCosto";
            this.colIdCentroCosto.FieldName = "IdCentroCosto";
            this.colIdCentroCosto.Name = "colIdCentroCosto";
            this.colIdCentroCosto.OptionsColumn.ReadOnly = true;
            this.colIdCentroCosto.Width = 71;
            // 
            // colIdCentroCosto_sub_centro_costo
            // 
            this.colIdCentroCosto_sub_centro_costo.Caption = "IdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.FieldName = "IdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.Name = "colIdCentroCosto_sub_centro_costo";
            this.colIdCentroCosto_sub_centro_costo.OptionsColumn.ReadOnly = true;
            this.colIdCentroCosto_sub_centro_costo.Width = 112;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 3;
            this.colEstado.Width = 94;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "cod_clase_proveedor";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.OptionsColumn.ReadOnly = true;
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            this.colcodigo.Width = 119;
            // 
            // colIdCtaCble_CXP
            // 
            this.colIdCtaCble_CXP.Caption = "IdCtaCble_CXP";
            this.colIdCtaCble_CXP.FieldName = "IdCtaCble_CXP";
            this.colIdCtaCble_CXP.Name = "colIdCtaCble_CXP";
            this.colIdCtaCble_CXP.OptionsColumn.ReadOnly = true;
            this.colIdCtaCble_CXP.Visible = true;
            this.colIdCtaCble_CXP.VisibleIndex = 4;
            this.colIdCtaCble_CXP.Width = 131;
            // 
            // frmCP_Proveedor_Clase_Consul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Name = "frmCP_Proveedor_Clase_Consul";
            this.Text = "Consulta de Clase de Proveedor";
            this.Load += new System.EventHandler(this.frmCP_Proveedor_Clase_Consul_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClaseProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClaseProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlClaseProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClaseProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdClaseProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion_clas_prove;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Anticipo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_gasto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto_sub_centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_CXP;
    }
}
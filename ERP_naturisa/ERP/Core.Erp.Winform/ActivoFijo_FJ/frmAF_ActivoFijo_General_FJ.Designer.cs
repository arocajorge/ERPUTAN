namespace Core.Erp.Winform.ActivoFijo_FJ
{
    partial class frmAF_ActivoFijo_General_FJ
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
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.dgActivoFijo = new DevExpress.XtraGrid.GridControl();
            this.gridViewActivoFijo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdActivoFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAf_Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAf_Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAf_Modelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAf_Color = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEncargado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAf_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_punto_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor_Unidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCentro_costo_sub_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgActivoFijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivoFijo)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2017, 2, 22, 12, 24, 0, 252);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 4, 22, 12, 24, 0, 252);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(847, 178);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 7;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnImpExcel_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImpExcel_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnImpExcel_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 467);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(847, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 9;
            // 
            // dgActivoFijo
            // 
            this.dgActivoFijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgActivoFijo.Location = new System.Drawing.Point(0, 178);
            this.dgActivoFijo.MainView = this.gridViewActivoFijo;
            this.dgActivoFijo.Name = "dgActivoFijo";
            this.dgActivoFijo.Size = new System.Drawing.Size(847, 289);
            this.dgActivoFijo.TabIndex = 10;
            this.dgActivoFijo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewActivoFijo});
            // 
            // gridViewActivoFijo
            // 
            this.gridViewActivoFijo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEstado,
            this.colIdActivoFijo,
            this.colAf_Nombre,
            this.colAf_Marca,
            this.colAf_Modelo,
            this.colAf_Color,
            this.colEncargado,
            this.colAf_observacion,
            this.colCentro_costo,
            this.colnom_punto_cargo,
            this.colCliente,
            this.colUnidad,
            this.colValor_Unidad,
            this.colCentro_costo_sub_centro_costo});
            this.gridViewActivoFijo.GridControl = this.dgActivoFijo;
            this.gridViewActivoFijo.Name = "gridViewActivoFijo";
            this.gridViewActivoFijo.OptionsBehavior.Editable = false;
            this.gridViewActivoFijo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewActivoFijo.OptionsView.ShowGroupPanel = false;
            this.gridViewActivoFijo.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewActivoFijo_RowClick);
            this.gridViewActivoFijo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewActivoFijo_RowCellStyle);
            this.gridViewActivoFijo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewActivoFijo_FocusedRowChanged);
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 102;
            // 
            // colIdActivoFijo
            // 
            this.colIdActivoFijo.Caption = "ID";
            this.colIdActivoFijo.FieldName = "IdActivoFijo";
            this.colIdActivoFijo.Name = "colIdActivoFijo";
            this.colIdActivoFijo.Visible = true;
            this.colIdActivoFijo.VisibleIndex = 0;
            this.colIdActivoFijo.Width = 41;
            // 
            // colAf_Nombre
            // 
            this.colAf_Nombre.Caption = "Nombre";
            this.colAf_Nombre.FieldName = "Af_Nombre";
            this.colAf_Nombre.Name = "colAf_Nombre";
            this.colAf_Nombre.Visible = true;
            this.colAf_Nombre.VisibleIndex = 1;
            this.colAf_Nombre.Width = 151;
            // 
            // colAf_Marca
            // 
            this.colAf_Marca.Caption = "Marca";
            this.colAf_Marca.FieldName = "Marca";
            this.colAf_Marca.Name = "colAf_Marca";
            this.colAf_Marca.Visible = true;
            this.colAf_Marca.VisibleIndex = 2;
            this.colAf_Marca.Width = 117;
            // 
            // colAf_Modelo
            // 
            this.colAf_Modelo.Caption = "Modelo";
            this.colAf_Modelo.FieldName = "Modelo";
            this.colAf_Modelo.Name = "colAf_Modelo";
            this.colAf_Modelo.Visible = true;
            this.colAf_Modelo.VisibleIndex = 3;
            this.colAf_Modelo.Width = 95;
            // 
            // colAf_Color
            // 
            this.colAf_Color.Caption = "Color";
            this.colAf_Color.FieldName = "nom_Color";
            this.colAf_Color.Name = "colAf_Color";
            this.colAf_Color.Width = 118;
            // 
            // colEncargado
            // 
            this.colEncargado.Caption = "Encargado";
            this.colEncargado.FieldName = "nom_encargado";
            this.colEncargado.Name = "colEncargado";
            this.colEncargado.Visible = true;
            this.colEncargado.VisibleIndex = 4;
            this.colEncargado.Width = 148;
            // 
            // colAf_observacion
            // 
            this.colAf_observacion.Caption = "Observacion";
            this.colAf_observacion.FieldName = "Af_observacion";
            this.colAf_observacion.Name = "colAf_observacion";
            this.colAf_observacion.Width = 73;
            // 
            // colCentro_costo
            // 
            this.colCentro_costo.Caption = "Centro costo";
            this.colCentro_costo.FieldName = "nom_Centro_costo";
            this.colCentro_costo.Name = "colCentro_costo";
            this.colCentro_costo.Visible = true;
            this.colCentro_costo.VisibleIndex = 5;
            this.colCentro_costo.Width = 118;
            // 
            // colnom_punto_cargo
            // 
            this.colnom_punto_cargo.Caption = "Punto de cargo";
            this.colnom_punto_cargo.FieldName = "nom_punto_cargo";
            this.colnom_punto_cargo.Name = "colnom_punto_cargo";
            this.colnom_punto_cargo.Width = 99;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "nom_Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 7;
            this.colCliente.Width = 102;
            // 
            // colUnidad
            // 
            this.colUnidad.Caption = "Unidad";
            this.colUnidad.FieldName = "nom_UnidadFact";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 9;
            this.colUnidad.Width = 99;
            // 
            // colValor_Unidad
            // 
            this.colValor_Unidad.Caption = "Unidades actuales";
            this.colValor_Unidad.FieldName = "Af_ValorUnidad_Actu";
            this.colValor_Unidad.Name = "colValor_Unidad";
            this.colValor_Unidad.Visible = true;
            this.colValor_Unidad.VisibleIndex = 8;
            this.colValor_Unidad.Width = 102;
            // 
            // colCentro_costo_sub_centro_costo
            // 
            this.colCentro_costo_sub_centro_costo.Caption = "Subcentro de costo";
            this.colCentro_costo_sub_centro_costo.FieldName = "nom_Centro_costo_sub_centro_costo";
            this.colCentro_costo_sub_centro_costo.Name = "colCentro_costo_sub_centro_costo";
            this.colCentro_costo_sub_centro_costo.Visible = true;
            this.colCentro_costo_sub_centro_costo.VisibleIndex = 6;
            this.colCentro_costo_sub_centro_costo.Width = 108;
            // 
            // frmAF_ActivoFijo_General_FJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 493);
            this.Controls.Add(this.dgActivoFijo);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "frmAF_ActivoFijo_General_FJ";
            this.Text = "Consulta de Activo Fijo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_event_frmAF_ActivoFijo_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmAF_ActivoFijo_General_FJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgActivoFijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActivoFijo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl dgActivoFijo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewActivoFijo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdActivoFijo;
        private DevExpress.XtraGrid.Columns.GridColumn colAf_Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colAf_Marca;
        private DevExpress.XtraGrid.Columns.GridColumn colAf_Modelo;
        private DevExpress.XtraGrid.Columns.GridColumn colAf_Color;
        private DevExpress.XtraGrid.Columns.GridColumn colEncargado;
        private DevExpress.XtraGrid.Columns.GridColumn colAf_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_punto_cargo;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colValor_Unidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCentro_costo_sub_centro_costo;
    }
}
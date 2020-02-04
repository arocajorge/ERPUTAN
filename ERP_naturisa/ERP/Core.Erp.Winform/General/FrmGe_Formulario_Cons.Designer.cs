namespace Core.Erp.Winform.General
{
    partial class FrmGe_Formulario_Cons
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
            this.panelMail = new System.Windows.Forms.Panel();
            this.gridControl_Report = new DevExpress.XtraGrid.GridControl();
            this.gridViewFormulario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFormulario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_Formulario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodModulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_Asembly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoFormulario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFormulario)).BeginInit();
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 9, 14, 10, 8, 0, 298);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 11, 14, 10, 8, 0, 298);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(969, 158);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_event_btnBuscar_Click);
            // 
            // panelMail
            // 
            this.panelMail.Controls.Add(this.gridControl_Report);
            this.panelMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMail.Location = new System.Drawing.Point(0, 158);
            this.panelMail.Name = "panelMail";
            this.panelMail.Size = new System.Drawing.Size(969, 320);
            this.panelMail.TabIndex = 1;
            // 
            // gridControl_Report
            // 
            this.gridControl_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Report.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Report.MainView = this.gridViewFormulario;
            this.gridControl_Report.Name = "gridControl_Report";
            this.gridControl_Report.Size = new System.Drawing.Size(969, 320);
            this.gridControl_Report.TabIndex = 0;
            this.gridControl_Report.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFormulario});
            // 
            // gridViewFormulario
            // 
            this.gridViewFormulario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFormulario,
            this.colnom_Formulario,
            this.colCodModulo,
            this.colText,
            this.colobservacion,
            this.colestado,
            this.colnom_Asembly,
            this.colCodigoFormulario});
            this.gridViewFormulario.GridControl = this.gridControl_Report;
            this.gridViewFormulario.Name = "gridViewFormulario";
            this.gridViewFormulario.OptionsBehavior.Editable = false;
            this.gridViewFormulario.OptionsView.ShowAutoFilterRow = true;
            this.gridViewFormulario.OptionsView.ShowGroupPanel = false;
            this.gridViewFormulario.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewFormulario_FocusedRowChanged);
            // 
            // colIdFormulario
            // 
            this.colIdFormulario.Caption = "IdFormulario";
            this.colIdFormulario.FieldName = "IdFormulario";
            this.colIdFormulario.Name = "colIdFormulario";
            this.colIdFormulario.Visible = true;
            this.colIdFormulario.VisibleIndex = 4;
            this.colIdFormulario.Width = 142;
            // 
            // colnom_Formulario
            // 
            this.colnom_Formulario.Caption = "nom_Formulario";
            this.colnom_Formulario.FieldName = "nom_Formulario";
            this.colnom_Formulario.Name = "colnom_Formulario";
            this.colnom_Formulario.Visible = true;
            this.colnom_Formulario.VisibleIndex = 1;
            this.colnom_Formulario.Width = 671;
            // 
            // colCodModulo
            // 
            this.colCodModulo.Caption = "CodModulo";
            this.colCodModulo.FieldName = "CodModulo";
            this.colCodModulo.Name = "colCodModulo";
            this.colCodModulo.Visible = true;
            this.colCodModulo.VisibleIndex = 2;
            this.colCodModulo.Width = 158;
            // 
            // colText
            // 
            this.colText.Caption = "Text";
            this.colText.FieldName = "Text";
            this.colText.Name = "colText";
            this.colText.Width = 141;
            // 
            // colobservacion
            // 
            this.colobservacion.Caption = "observacion";
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.Width = 141;
            // 
            // colestado
            // 
            this.colestado.Caption = "estado";
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.Width = 180;
            // 
            // colnom_Asembly
            // 
            this.colnom_Asembly.Caption = "nom_Asembly";
            this.colnom_Asembly.FieldName = "nom_Asembly";
            this.colnom_Asembly.Name = "colnom_Asembly";
            this.colnom_Asembly.Visible = true;
            this.colnom_Asembly.VisibleIndex = 3;
            this.colnom_Asembly.Width = 133;
            // 
            // colCodigoFormulario
            // 
            this.colCodigoFormulario.Caption = "Cod Formulario";
            this.colCodigoFormulario.FieldName = "cod_Formulario";
            this.colCodigoFormulario.Name = "colCodigoFormulario";
            this.colCodigoFormulario.Visible = true;
            this.colCodigoFormulario.VisibleIndex = 0;
            this.colCodigoFormulario.Width = 76;
            // 
            // FrmGe_Formulario_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 478);
            this.Controls.Add(this.panelMail);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "FrmGe_Formulario_Cons";
            this.Text = "FrmGe_Formulario_Cons";
            this.Load += new System.EventHandler(this.FrmGe_Formulario_Cons_Load);
            this.panelMail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFormulario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panelMail;
        private DevExpress.XtraGrid.GridControl gridControl_Report;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFormulario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormulario;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_Formulario;
        private DevExpress.XtraGrid.Columns.GridColumn colCodModulo;
        private DevExpress.XtraGrid.Columns.GridColumn colText;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_Asembly;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoFormulario;
    }
}
namespace Core.Erp.Winform.SeguridadAcceso
{
    partial class FrmSeg_Usuario_Consul
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
            this.uC_Menu_Consultas1 = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.gridControlUsuario = new DevExpress.XtraGrid.GridControl();
            this.gridViewUsuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContrasenia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // uC_Menu_Consultas1
            // 
            this.uC_Menu_Consultas1.CargarTodasBodegas = false;
            this.uC_Menu_Consultas1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_Menu_Consultas1.Enable_boton_anular = true;
            this.uC_Menu_Consultas1.Enable_boton_CancelarCuotas = true;
            this.uC_Menu_Consultas1.Enable_boton_CargaMarcaciónExcel = true;
            this.uC_Menu_Consultas1.Enable_boton_consultar = true;
            this.uC_Menu_Consultas1.Enable_boton_DiseñoCheque = true;
            this.uC_Menu_Consultas1.Enable_boton_DiseñoChequeComprobante = true;
            this.uC_Menu_Consultas1.Enable_boton_Duplicar = true;
            this.uC_Menu_Consultas1.Enable_boton_GenerarPeriodos = true;
            this.uC_Menu_Consultas1.Enable_boton_GenerarXml = true;
            this.uC_Menu_Consultas1.Enable_boton_Habilitar_Reg = true;
            this.uC_Menu_Consultas1.Enable_boton_Importar_XML = true;
            this.uC_Menu_Consultas1.Enable_boton_imprimir = true;
            this.uC_Menu_Consultas1.Enable_boton_LoteCheque = true;
            this.uC_Menu_Consultas1.Enable_boton_modificar = true;
            this.uC_Menu_Consultas1.Enable_boton_nuevo = true;
            this.uC_Menu_Consultas1.Enable_boton_NuevoCheque = true;
            this.uC_Menu_Consultas1.Enable_boton_periodo = true;
            this.uC_Menu_Consultas1.Enable_boton_salir = true;
            this.uC_Menu_Consultas1.Enable_btnImpExcel = true;
            this.uC_Menu_Consultas1.Enable_Descargar_Marca_Base_exter = true;
            this.uC_Menu_Consultas1.fecha_desde = new System.DateTime(2016, 3, 14, 12, 14, 31, 122);
            this.uC_Menu_Consultas1.fecha_hasta = new System.DateTime(2016, 4, 15, 12, 14, 31, 122);
            this.uC_Menu_Consultas1.FormConsulta = null;
            this.uC_Menu_Consultas1.FormMain = null;
            this.uC_Menu_Consultas1.GridControlConsulta = null;
            this.uC_Menu_Consultas1.Location = new System.Drawing.Point(0, 0);
            this.uC_Menu_Consultas1.Name = "uC_Menu_Consultas1";
            this.uC_Menu_Consultas1.Perfil_x_usuario = null;
            this.uC_Menu_Consultas1.Size = new System.Drawing.Size(799, 116);
            this.uC_Menu_Consultas1.TabIndex = 2;
            this.uC_Menu_Consultas1.Visible_bodega = false;
            this.uC_Menu_Consultas1.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uC_Menu_Consultas1.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uC_Menu_Consultas1.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uC_Menu_Consultas1.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uC_Menu_Consultas1.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uC_Menu_Consultas1.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uC_Menu_Consultas1.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uC_Menu_Consultas1.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uC_Menu_Consultas1.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uC_Menu_Consultas1.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uC_Menu_Consultas1.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uC_Menu_Consultas1.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uC_Menu_Consultas1.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uC_Menu_Consultas1.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uC_Menu_Consultas1.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uC_Menu_Consultas1.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uC_Menu_Consultas1.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uC_Menu_Consultas1.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uC_Menu_Consultas1.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uC_Menu_Consultas1.Visible_fechas = false;
            this.uC_Menu_Consultas1.Visible_Grupo_Cancelaciones = true;
            this.uC_Menu_Consultas1.Visible_Grupo_Diseño_Reporte = false;
            this.uC_Menu_Consultas1.Visible_Grupo_filtro = true;
            this.uC_Menu_Consultas1.Visible_Grupo_Impresion = true;
            this.uC_Menu_Consultas1.Visible_Grupo_Otras_Trans = true;
            this.uC_Menu_Consultas1.Visible_Grupo_Transacciones = true;
            this.uC_Menu_Consultas1.Visible_Pie_fechas_Boton_buscar = false;
            this.uC_Menu_Consultas1.Visible_sucursal = false;
            this.uC_Menu_Consultas1.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.uC_Menu_Consultas1_event_btnNuevo_ItemClick);
            this.uC_Menu_Consultas1.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.uC_Menu_Consultas1_event_btnModificar_ItemClick);
            this.uC_Menu_Consultas1.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.uC_Menu_Consultas1_event_btnconsultar_ItemClick);
            this.uC_Menu_Consultas1.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.uC_Menu_Consultas1_event_btnAnular_ItemClick);
            this.uC_Menu_Consultas1.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.uC_Menu_Consultas1_event_btnImprimir_ItemClick);
            this.uC_Menu_Consultas1.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.uC_Menu_Consultas1_event_btnSalir_ItemClick);
            this.uC_Menu_Consultas1.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.uC_Menu_Consultas1_event_btnBuscar_Click);
            // 
            // gridControlUsuario
            // 
            this.gridControlUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUsuario.Location = new System.Drawing.Point(0, 116);
            this.gridControlUsuario.MainView = this.gridViewUsuario;
            this.gridControlUsuario.Name = "gridControlUsuario";
            this.gridControlUsuario.Size = new System.Drawing.Size(799, 334);
            this.gridControlUsuario.TabIndex = 3;
            this.gridControlUsuario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsuario});
            // 
            // gridViewUsuario
            // 
            this.gridViewUsuario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUsuario,
            this.colContrasenia,
            this.colEstado,
            this.colNombre});
            this.gridViewUsuario.GridControl = this.gridControlUsuario;
            this.gridViewUsuario.Name = "gridViewUsuario";
            this.gridViewUsuario.OptionsBehavior.Editable = false;
            this.gridViewUsuario.OptionsView.ShowAutoFilterRow = true;
            this.gridViewUsuario.OptionsView.ShowGroupPanel = false;
            this.gridViewUsuario.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewUsuario_RowCellStyle);
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.Caption = "IdUsusario";
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Visible = true;
            this.colIdUsuario.VisibleIndex = 0;
            this.colIdUsuario.Width = 221;
            // 
            // colContrasenia
            // 
            this.colContrasenia.Caption = "Contraseña";
            this.colContrasenia.FieldName = "Contrasena";
            this.colContrasenia.Name = "colContrasenia";
            this.colContrasenia.Width = 189;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 2;
            this.colEstado.Width = 153;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 653;
            // 
            // FrmSeg_Usuario_Consul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.gridControlUsuario);
            this.Controls.Add(this.uC_Menu_Consultas1);
            this.Name = "FrmSeg_Usuario_Consul";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmSeg_Usuario_Consul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario uC_Menu_Consultas1;
        private DevExpress.XtraGrid.GridControl gridControlUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colContrasenia;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;


    }
}
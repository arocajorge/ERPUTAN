namespace Core.Erp.Winform.Academico
{
    partial class FrmAcaAdmision_Cons
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControlAdmision = new DevExpress.XtraGrid.GridControl();
            this.acaAdmisionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvAdmision = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAdmision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodAdmision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpersonaInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaspiranteInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPoseeDiscapacidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonoEmergente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdmision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaAdmisionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdmision)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.CargarTodasBodegas = false;
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 12, 12, 11, 13, 2, 997);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2016, 2, 12, 11, 13, 2, 998);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(684, 112);
            this.ucGe_Menu.TabIndex = 3;
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
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_sucursal = false;
            // 
            // ucGe_BarraEstadoInferior_Forms
            // 
            this.ucGe_BarraEstadoInferior_Forms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms.Location = new System.Drawing.Point(0, 377);
            this.ucGe_BarraEstadoInferior_Forms.Name = "ucGe_BarraEstadoInferior_Forms";
            this.ucGe_BarraEstadoInferior_Forms.Size = new System.Drawing.Size(684, 31);
            this.ucGe_BarraEstadoInferior_Forms.TabIndex = 4;
            // 
            // gridControlAdmision
            // 
            this.gridControlAdmision.DataSource = this.acaAdmisionInfoBindingSource;
            this.gridControlAdmision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAdmision.Location = new System.Drawing.Point(0, 112);
            this.gridControlAdmision.MainView = this.gvAdmision;
            this.gridControlAdmision.Name = "gridControlAdmision";
            this.gridControlAdmision.Size = new System.Drawing.Size(684, 265);
            this.gridControlAdmision.TabIndex = 5;
            this.gridControlAdmision.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAdmision});
            // 
            // acaAdmisionInfoBindingSource
            // 
            this.acaAdmisionInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Admision_Info);
            // 
            // gvAdmision
            // 
            this.gvAdmision.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAdmision,
            this.colCodAdmision,
            this.colpersonaInfo,
            this.colNombres,
            this.colApellidos,
            this.colaspiranteInfo,
            this.colPoseeDiscapacidad,
            this.colTelefonoEmergente,
            this.colEstado});
            this.gvAdmision.GridControl = this.gridControlAdmision;
            this.gvAdmision.Name = "gvAdmision";
            this.gvAdmision.OptionsView.ShowAutoFilterRow = true;
            this.gvAdmision.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdAdmision, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdAdmision
            // 
            this.colIdAdmision.FieldName = "IdAdmision";
            this.colIdAdmision.Name = "colIdAdmision";
            this.colIdAdmision.OptionsColumn.AllowEdit = false;
            this.colIdAdmision.Visible = true;
            this.colIdAdmision.VisibleIndex = 0;
            this.colIdAdmision.Width = 87;
            // 
            // colCodAdmision
            // 
            this.colCodAdmision.FieldName = "CodAdmision";
            this.colCodAdmision.Name = "colCodAdmision";
            this.colCodAdmision.OptionsColumn.AllowEdit = false;
            this.colCodAdmision.Visible = true;
            this.colCodAdmision.VisibleIndex = 1;
            this.colCodAdmision.Width = 101;
            // 
            // colpersonaInfo
            // 
            this.colpersonaInfo.Caption = "Cédula";
            this.colpersonaInfo.FieldName = "aspiranteInfo.Persona_Info.pe_cedulaRuc";
            this.colpersonaInfo.Name = "colpersonaInfo";
            this.colpersonaInfo.OptionsColumn.AllowEdit = false;
            this.colpersonaInfo.Visible = true;
            this.colpersonaInfo.VisibleIndex = 2;
            this.colpersonaInfo.Width = 137;
            // 
            // colNombres
            // 
            this.colNombres.Caption = "Nombres";
            this.colNombres.FieldName = "aspiranteInfo.Persona_Info.pe_nombre";
            this.colNombres.Name = "colNombres";
            this.colNombres.OptionsColumn.AllowEdit = false;
            this.colNombres.Visible = true;
            this.colNombres.VisibleIndex = 3;
            this.colNombres.Width = 163;
            // 
            // colApellidos
            // 
            this.colApellidos.Caption = "Apellidos";
            this.colApellidos.FieldName = "aspiranteInfo.Persona_Info.pe_apellido";
            this.colApellidos.Name = "colApellidos";
            this.colApellidos.OptionsColumn.AllowEdit = false;
            this.colApellidos.Visible = true;
            this.colApellidos.VisibleIndex = 4;
            this.colApellidos.Width = 160;
            // 
            // colaspiranteInfo
            // 
            this.colaspiranteInfo.Caption = "Nacionalidad";
            this.colaspiranteInfo.FieldName = "aspiranteInfo.Pais_Info.Nacionalidad";
            this.colaspiranteInfo.Name = "colaspiranteInfo";
            this.colaspiranteInfo.OptionsColumn.AllowEdit = false;
            this.colaspiranteInfo.Visible = true;
            this.colaspiranteInfo.VisibleIndex = 5;
            this.colaspiranteInfo.Width = 123;
            // 
            // colPoseeDiscapacidad
            // 
            this.colPoseeDiscapacidad.Caption = "Posee Discapacidad";
            this.colPoseeDiscapacidad.FieldName = "PoseeDiscapacidad";
            this.colPoseeDiscapacidad.Name = "colPoseeDiscapacidad";
            this.colPoseeDiscapacidad.OptionsColumn.AllowEdit = false;
            this.colPoseeDiscapacidad.Visible = true;
            this.colPoseeDiscapacidad.VisibleIndex = 6;
            this.colPoseeDiscapacidad.Width = 117;
            // 
            // colTelefonoEmergente
            // 
            this.colTelefonoEmergente.Caption = "Teléfono Emergente";
            this.colTelefonoEmergente.FieldName = "TelefonoEmergente";
            this.colTelefonoEmergente.Name = "colTelefonoEmergente";
            this.colTelefonoEmergente.OptionsColumn.AllowEdit = false;
            this.colTelefonoEmergente.Visible = true;
            this.colTelefonoEmergente.VisibleIndex = 7;
            this.colTelefonoEmergente.Width = 211;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 8;
            this.colEstado.Width = 59;
            // 
            // FrmAcaAdmision_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 408);
            this.Controls.Add(this.gridControlAdmision);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmAcaAdmision_Cons";
            this.Text = "FrmAcaAdmision_Cons";
            this.Load += new System.EventHandler(this.FrmAcaAdmision_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdmision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaAdmisionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdmision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms;
        private DevExpress.XtraGrid.GridControl gridControlAdmision;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAdmision;
        private System.Windows.Forms.BindingSource acaAdmisionInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAdmision;
        private DevExpress.XtraGrid.Columns.GridColumn colCodAdmision;
        private DevExpress.XtraGrid.Columns.GridColumn colpersonaInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombres;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidos;
        private DevExpress.XtraGrid.Columns.GridColumn colaspiranteInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colPoseeDiscapacidad;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonoEmergente;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}
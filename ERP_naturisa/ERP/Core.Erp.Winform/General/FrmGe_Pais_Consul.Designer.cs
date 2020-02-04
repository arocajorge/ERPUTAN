namespace Core.Erp.Winform.General
{
    partial class FrmGe_Pais_Consul
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
            this.gridControlPais = new DevExpress.XtraGrid.GridControl();
            this.gridViewPais = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdPais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodPais = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nacionalidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.estado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPais)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 387);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(899, 26);
            this.ucGe_BarraEstado.TabIndex = 0;
            // 
            // ucGe_Menu
            // 
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 6, 20, 23, 43, 56, 169);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 8, 20, 23, 43, 56, 169);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(899, 116);
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
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_event_btnImprimir_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            // 
            // gridControlPais
            // 
            this.gridControlPais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPais.Location = new System.Drawing.Point(0, 116);
            this.gridControlPais.MainView = this.gridViewPais;
            this.gridControlPais.Name = "gridControlPais";
            this.gridControlPais.Size = new System.Drawing.Size(899, 271);
            this.gridControlPais.TabIndex = 2;
            this.gridControlPais.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPais});
            // 
            // gridViewPais
            // 
            this.gridViewPais.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdPais,
            this.CodPais,
            this.Nombre,
            this.Nacionalidad,
            this.estado});
            this.gridViewPais.GridControl = this.gridControlPais;
            this.gridViewPais.Name = "gridViewPais";
            this.gridViewPais.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewPais_RowCellStyle);
            // 
            // IdPais
            // 
            this.IdPais.Caption = "Id Pais";
            this.IdPais.FieldName = "IdPais";
            this.IdPais.Name = "IdPais";
            this.IdPais.Visible = true;
            this.IdPais.VisibleIndex = 0;
            // 
            // CodPais
            // 
            this.CodPais.Caption = "Código Pais";
            this.CodPais.FieldName = "CodPais";
            this.CodPais.Name = "CodPais";
            this.CodPais.Visible = true;
            this.CodPais.VisibleIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 2;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.Caption = "Nacionalidad";
            this.Nacionalidad.FieldName = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.Visible = true;
            this.Nacionalidad.VisibleIndex = 3;
            // 
            // estado
            // 
            this.estado.Caption = "Estado";
            this.estado.FieldName = "estado";
            this.estado.Name = "estado";
            this.estado.Visible = true;
            this.estado.VisibleIndex = 4;
            // 
            // FrmGe_Pais_Consul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 413);
            this.Controls.Add(this.gridControlPais);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Name = "FrmGe_Pais_Consul";
            this.Text = "FrmGe_Pais_Consul";
            this.Load += new System.EventHandler(this.FrmGe_Pais_Consul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridControlPais;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPais;
        private DevExpress.XtraGrid.Columns.GridColumn IdPais;
        private DevExpress.XtraGrid.Columns.GridColumn CodPais;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Nacionalidad;
        private DevExpress.XtraGrid.Columns.GridColumn estado;
    }
}
namespace Core.Erp.Winform.Caja
{
    partial class FrmCa_Caja_Talonario_Recibo_Cons
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
            this.gridConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridViewConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdRecibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Su_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_PuntoVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Su_CodigoEstablecimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cod_PuntoVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Num_Recibo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Usado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Check = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check)).BeginInit();
            this.SuspendLayout();
            // 
            // gridConsulta
            // 
            this.gridConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsulta.Location = new System.Drawing.Point(0, 176);
            this.gridConsulta.MainView = this.gridViewConsulta;
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Check});
            this.gridConsulta.Size = new System.Drawing.Size(866, 237);
            this.gridConsulta.TabIndex = 14;
            this.gridConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewConsulta});
            // 
            // gridViewConsulta
            // 
            this.gridViewConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdRecibo,
            this.col_Su_Descripcion,
            this.col_nom_PuntoVta,
            this.col_Su_CodigoEstablecimiento,
            this.col_cod_PuntoVta,
            this.col_Num_Recibo,
            this.col_Usado,
            this.col_Estado});
            this.gridViewConsulta.GridControl = this.gridConsulta;
            this.gridViewConsulta.Name = "gridViewConsulta";
            this.gridViewConsulta.OptionsBehavior.Editable = false;
            this.gridViewConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gridViewConsulta.OptionsView.ShowGroupPanel = false;
            this.gridViewConsulta.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewConsulta_RowCellStyle);
            // 
            // col_IdRecibo
            // 
            this.col_IdRecibo.Caption = "IdRecibo";
            this.col_IdRecibo.FieldName = "IdRecibo";
            this.col_IdRecibo.Name = "col_IdRecibo";
            this.col_IdRecibo.Visible = true;
            this.col_IdRecibo.VisibleIndex = 0;
            this.col_IdRecibo.Width = 51;
            // 
            // col_Su_Descripcion
            // 
            this.col_Su_Descripcion.Caption = "Sucursal";
            this.col_Su_Descripcion.FieldName = "Su_Descripcion";
            this.col_Su_Descripcion.Name = "col_Su_Descripcion";
            this.col_Su_Descripcion.Visible = true;
            this.col_Su_Descripcion.VisibleIndex = 1;
            this.col_Su_Descripcion.Width = 159;
            // 
            // col_nom_PuntoVta
            // 
            this.col_nom_PuntoVta.Caption = "Punto Venta";
            this.col_nom_PuntoVta.FieldName = "nom_PuntoVta";
            this.col_nom_PuntoVta.Name = "col_nom_PuntoVta";
            this.col_nom_PuntoVta.Visible = true;
            this.col_nom_PuntoVta.VisibleIndex = 2;
            this.col_nom_PuntoVta.Width = 159;
            // 
            // col_Su_CodigoEstablecimiento
            // 
            this.col_Su_CodigoEstablecimiento.Caption = "Establecimiento";
            this.col_Su_CodigoEstablecimiento.FieldName = "Su_CodigoEstablecimiento";
            this.col_Su_CodigoEstablecimiento.Name = "col_Su_CodigoEstablecimiento";
            this.col_Su_CodigoEstablecimiento.Visible = true;
            this.col_Su_CodigoEstablecimiento.VisibleIndex = 3;
            this.col_Su_CodigoEstablecimiento.Width = 117;
            // 
            // col_cod_PuntoVta
            // 
            this.col_cod_PuntoVta.Caption = "Punto Emisión";
            this.col_cod_PuntoVta.FieldName = "cod_PuntoVta";
            this.col_cod_PuntoVta.Name = "col_cod_PuntoVta";
            this.col_cod_PuntoVta.Visible = true;
            this.col_cod_PuntoVta.VisibleIndex = 4;
            this.col_cod_PuntoVta.Width = 102;
            // 
            // col_Num_Recibo
            // 
            this.col_Num_Recibo.Caption = "Num_Recibo";
            this.col_Num_Recibo.FieldName = "Num_Recibo";
            this.col_Num_Recibo.Name = "col_Num_Recibo";
            this.col_Num_Recibo.Visible = true;
            this.col_Num_Recibo.VisibleIndex = 5;
            this.col_Num_Recibo.Width = 306;
            // 
            // col_Usado
            // 
            this.col_Usado.Caption = "Usado";
            this.col_Usado.FieldName = "Usado";
            this.col_Usado.Name = "col_Usado";
            this.col_Usado.Visible = true;
            this.col_Usado.VisibleIndex = 6;
            this.col_Usado.Width = 129;
            // 
            // col_Estado
            // 
            this.col_Estado.Caption = "Estado";
            this.col_Estado.FieldName = "Estado";
            this.col_Estado.Name = "col_Estado";
            this.col_Estado.Visible = true;
            this.col_Estado.VisibleIndex = 7;
            this.col_Estado.Width = 147;
            // 
            // Check
            // 
            this.Check.AutoHeight = false;
            this.Check.Name = "Check";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(866, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2017, 1, 10, 15, 37, 33, 627);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 3, 10, 15, 37, 33, 627);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(866, 176);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 13;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // FrmCa_Caja_Talonario_Recibo_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 435);
            this.Controls.Add(this.gridConsulta);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "FrmCa_Caja_Talonario_Recibo_Cons";
            this.Text = "FrmCa_Caja_Talonario_Recibo_Cons";
            this.Load += new System.EventHandler(this.FrmCa_Caja_Talonario_Recibo_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewConsulta;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit Check;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdRecibo;
        private DevExpress.XtraGrid.Columns.GridColumn col_Su_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_PuntoVta;
        private DevExpress.XtraGrid.Columns.GridColumn col_Su_CodigoEstablecimiento;
        private DevExpress.XtraGrid.Columns.GridColumn col_cod_PuntoVta;
        private DevExpress.XtraGrid.Columns.GridColumn col_Num_Recibo;
        private DevExpress.XtraGrid.Columns.GridColumn col_Usado;
        private DevExpress.XtraGrid.Columns.GridColumn col_Estado;
    }
}
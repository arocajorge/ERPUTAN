namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_OperadorConsulta
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.gridControlOperador = new DevExpress.XtraGrid.GridControl();
            this.gridViewOperador = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdOperador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNomEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelConsulta = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOperador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOperador)).BeginInit();
            this.panelConsulta.SuspendLayout();
            this.SuspendLayout();
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
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 5, 21, 4, 33, 26, 291);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 7, 21, 4, 33, 26, 291);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(666, 116);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = false;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            // 
            // gridControlOperador
            // 
            this.gridControlOperador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOperador.Location = new System.Drawing.Point(0, 0);
            this.gridControlOperador.MainView = this.gridViewOperador;
            this.gridControlOperador.Name = "gridControlOperador";
            this.gridControlOperador.Size = new System.Drawing.Size(666, 208);
            this.gridControlOperador.TabIndex = 1;
            this.gridControlOperador.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOperador});
            // 
            // gridViewOperador
            // 
            this.gridViewOperador.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdOperador,
            this.colIdEmpleado,
            this.ColNomEmpleado,
            this.ColEstado});
            this.gridViewOperador.GridControl = this.gridControlOperador;
            this.gridViewOperador.Name = "gridViewOperador";
            this.gridViewOperador.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewOperador_RowClick);
            this.gridViewOperador.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewOperador_RowCellStyle);
            // 
            // ColIdOperador
            // 
            this.ColIdOperador.Caption = "Id Operador";
            this.ColIdOperador.FieldName = "IdOperador";
            this.ColIdOperador.Name = "ColIdOperador";
            this.ColIdOperador.Visible = true;
            this.ColIdOperador.VisibleIndex = 1;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.Caption = "Id Empleado";
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 0;
            // 
            // ColNomEmpleado
            // 
            this.ColNomEmpleado.Caption = "Nombre Operador";
            this.ColNomEmpleado.FieldName = "NomEmpleado";
            this.ColNomEmpleado.Name = "ColNomEmpleado";
            this.ColNomEmpleado.Visible = true;
            this.ColNomEmpleado.VisibleIndex = 2;
            // 
            // ColEstado
            // 
            this.ColEstado.Caption = "Estado";
            this.ColEstado.FieldName = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.Visible = true;
            this.ColEstado.VisibleIndex = 3;
            // 
            // panelConsulta
            // 
            this.panelConsulta.Controls.Add(this.gridControlOperador);
            this.panelConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsulta.Location = new System.Drawing.Point(0, 116);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(666, 208);
            this.panelConsulta.TabIndex = 2;
            // 
            // FrmPrd_OperadorConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 324);
            this.Controls.Add(this.panelConsulta);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmPrd_OperadorConsulta";
            this.Text = "FrmPrd_OperadorConsulta";
            this.Load += new System.EventHandler(this.FrmPrd_OperadorConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOperador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOperador)).EndInit();
            this.panelConsulta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridControlOperador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOperador;
        private System.Windows.Forms.Panel panelConsulta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdOperador;
        private DevExpress.XtraGrid.Columns.GridColumn ColNomEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstado;
    }
}
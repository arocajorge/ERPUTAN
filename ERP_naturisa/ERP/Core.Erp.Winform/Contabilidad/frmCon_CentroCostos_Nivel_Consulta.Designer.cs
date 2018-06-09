namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_CentroCostos_Nivel_Consulta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridNivel = new DevExpress.XtraGrid.GridControl();
            this.gridViewNivel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdNivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ni_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ni_digitos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNivel)).BeginInit();
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
            this.ucGe_Menu.Enable_boton_Duplicar = true;
            this.ucGe_Menu.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu.Enable_boton_GenerarXml = true;
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 3, 29, 10, 19, 20, 210);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 5, 29, 10, 19, 20, 210);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(790, 116);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.gridNivel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 286);
            this.panel1.TabIndex = 1;
            // 
            // gridNivel
            // 
            this.gridNivel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNivel.Location = new System.Drawing.Point(0, 0);
            this.gridNivel.MainView = this.gridViewNivel;
            this.gridNivel.Name = "gridNivel";
            this.gridNivel.Size = new System.Drawing.Size(790, 286);
            this.gridNivel.TabIndex = 8;
            this.gridNivel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNivel});
            // 
            // gridViewNivel
            // 
            this.gridViewNivel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdNivel,
            this.ni_descripcion,
            this.ni_digitos,
            this.Estado});
            this.gridViewNivel.GridControl = this.gridNivel;
            this.gridViewNivel.Name = "gridViewNivel";
            this.gridViewNivel.OptionsBehavior.Editable = false;
            this.gridViewNivel.OptionsView.ShowAutoFilterRow = true;
            this.gridViewNivel.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewNivel_RowClick);
            this.gridViewNivel.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewNivel_RowCellStyle);
            // 
            // IdNivel
            // 
            this.IdNivel.Caption = "Id Nivel";
            this.IdNivel.FieldName = "IdNivel";
            this.IdNivel.Name = "IdNivel";
            this.IdNivel.Visible = true;
            this.IdNivel.VisibleIndex = 0;
            this.IdNivel.Width = 62;
            // 
            // ni_descripcion
            // 
            this.ni_descripcion.Caption = "Descripción";
            this.ni_descripcion.FieldName = "ni_descripcion";
            this.ni_descripcion.Name = "ni_descripcion";
            this.ni_descripcion.Visible = true;
            this.ni_descripcion.VisibleIndex = 1;
            this.ni_descripcion.Width = 249;
            // 
            // ni_digitos
            // 
            this.ni_digitos.Caption = "N° Digitos";
            this.ni_digitos.FieldName = "ni_digitos";
            this.ni_digitos.Name = "ni_digitos";
            this.ni_digitos.Visible = true;
            this.ni_digitos.VisibleIndex = 2;
            this.ni_digitos.Width = 94;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 3;
            this.Estado.Width = 95;
            // 
            // frmCon_CentroCostos_Nivel_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCon_CentroCostos_Nivel_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Nivel de Centro de Costos";
            this.Load += new System.EventHandler(this.frmCon_CentroCostos_Nivel_Consulta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNivel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridNivel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNivel;
        private DevExpress.XtraGrid.Columns.GridColumn IdNivel;
        private DevExpress.XtraGrid.Columns.GridColumn ni_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn ni_digitos;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
    }
}
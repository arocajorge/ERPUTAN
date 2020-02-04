namespace Core.Erp.Winform.General
{
    partial class FrmGe_transportista_Consulta
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
            this.gridTransportista = new DevExpress.XtraGrid.GridControl();
            this.gridViewTransportista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdTransportista = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransportista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransportista)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridTransportista
            // 
            this.gridTransportista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTransportista.Location = new System.Drawing.Point(0, 0);
            this.gridTransportista.MainView = this.gridViewTransportista;
            this.gridTransportista.Name = "gridTransportista";
            this.gridTransportista.Size = new System.Drawing.Size(628, 212);
            this.gridTransportista.TabIndex = 0;
            this.gridTransportista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransportista});
            // 
            // gridViewTransportista
            // 
            this.gridViewTransportista.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdEmpresa,
            this.IdTransportista,
            this.IdPersona,
            this.Estado,
            this.Nombre,
            this.Cedula});
            this.gridViewTransportista.GridControl = this.gridTransportista;
            this.gridViewTransportista.Name = "gridViewTransportista";
            this.gridViewTransportista.OptionsBehavior.Editable = false;
            this.gridViewTransportista.OptionsView.ShowAutoFilterRow = true;
            this.gridViewTransportista.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Nombre, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewTransportista.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewTransportista_RowClick);
            this.gridViewTransportista.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewTransportista_RowCellStyle);
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.Caption = "Id Empresa";
            this.IdEmpresa.FieldName = "IdEmpresa";
            this.IdEmpresa.Name = "IdEmpresa";
            // 
            // IdTransportista
            // 
            this.IdTransportista.Caption = "Id Transportista";
            this.IdTransportista.FieldName = "IdTransportista";
            this.IdTransportista.Name = "IdTransportista";
            this.IdTransportista.Visible = true;
            this.IdTransportista.VisibleIndex = 0;
            this.IdTransportista.Width = 90;
            // 
            // IdPersona
            // 
            this.IdPersona.Caption = "Id Persona";
            this.IdPersona.FieldName = "IdPersona";
            this.IdPersona.Name = "IdPersona";
            this.IdPersona.Width = 70;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 3;
            this.Estado.Width = 214;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 2;
            this.Nombre.Width = 564;
            // 
            // Cedula
            // 
            this.Cedula.Caption = "Cedula";
            this.Cedula.FieldName = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.Visible = true;
            this.Cedula.VisibleIndex = 1;
            this.Cedula.Width = 290;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 303);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(628, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 91);
            this.panel1.TabIndex = 25;
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
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 5, 1, 10, 27, 4, 444);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 7, 1, 10, 27, 4, 445);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(628, 91);
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridTransportista);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 212);
            this.panel2.TabIndex = 26;
            // 
            // FrmGe_transportista_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 325);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmGe_transportista_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transportista Consulta";
            this.Load += new System.EventHandler(this.frmGE_transportista_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTransportista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransportista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridTransportista;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransportista;
        private DevExpress.XtraGrid.Columns.GridColumn IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn IdTransportista;
        private DevExpress.XtraGrid.Columns.GridColumn IdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Cedula;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
    }
}
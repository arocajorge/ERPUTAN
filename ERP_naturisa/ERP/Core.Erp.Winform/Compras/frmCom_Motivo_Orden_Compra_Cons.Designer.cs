namespace Core.Erp.Winform.Compras
{
    partial class frmCom_Motivo_Orden_Compra_Cons
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
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gridControlMotivo = new DevExpress.XtraGrid.GridControl();
            this.gridViewMotivo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMotivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCod_Motivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COLestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMotivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMotivo)).BeginInit();
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 3, 22, 16, 7, 31, 413);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 5, 22, 16, 7, 31, 413);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(760, 95);
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
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 462);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(760, 26);
            this.ucGe_BarraEstado.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gridControlMotivo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 95);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(760, 367);
            this.panelMain.TabIndex = 2;
            // 
            // gridControlMotivo
            // 
            this.gridControlMotivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMotivo.Location = new System.Drawing.Point(0, 0);
            this.gridControlMotivo.MainView = this.gridViewMotivo;
            this.gridControlMotivo.Name = "gridControlMotivo";
            this.gridControlMotivo.Size = new System.Drawing.Size(760, 367);
            this.gridControlMotivo.TabIndex = 0;
            this.gridControlMotivo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMotivo});
            this.gridControlMotivo.Click += new System.EventHandler(this.gridControlMotivo_Click);
            // 
            // gridViewMotivo
            // 
            this.gridViewMotivo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMotivo,
            this.colCod_Motivo,
            this.colDescripcion,
            this.COLestado});
            this.gridViewMotivo.GridControl = this.gridControlMotivo;
            this.gridViewMotivo.Name = "gridViewMotivo";
            this.gridViewMotivo.OptionsBehavior.Editable = false;
            this.gridViewMotivo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewMotivo_RowCellStyle);
            // 
            // colIdMotivo
            // 
            this.colIdMotivo.Caption = "IdMotivo";
            this.colIdMotivo.FieldName = "IdMotivo";
            this.colIdMotivo.Name = "colIdMotivo";
            this.colIdMotivo.Visible = true;
            this.colIdMotivo.VisibleIndex = 0;
            this.colIdMotivo.Width = 110;
            // 
            // colCod_Motivo
            // 
            this.colCod_Motivo.Caption = "Cod_Motivo";
            this.colCod_Motivo.FieldName = "Cod_Motivo";
            this.colCod_Motivo.Name = "colCod_Motivo";
            this.colCod_Motivo.Visible = true;
            this.colCod_Motivo.VisibleIndex = 1;
            this.colCod_Motivo.Width = 124;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripcion";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            this.colDescripcion.Width = 498;
            // 
            // COLestado
            // 
            this.COLestado.Caption = "estado";
            this.COLestado.FieldName = "estado";
            this.COLestado.Name = "COLestado";
            this.COLestado.Visible = true;
            this.COLestado.VisibleIndex = 3;
            // 
            // frmCom_Motivo_Orden_Compra_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 488);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmCom_Motivo_Orden_Compra_Cons";
            this.Text = "Consulta Motivo";
            this.Load += new System.EventHandler(this.frmCom_Motivo_Orden_Compra_Cons_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMotivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMotivo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraGrid.GridControl gridControlMotivo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMotivo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivo;
        private DevExpress.XtraGrid.Columns.GridColumn colCod_Motivo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn COLestado;
    }
}
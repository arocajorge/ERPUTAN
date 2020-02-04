namespace Core.Erp.Winform.Contabilidad
{
    partial class frmCon_CbteCble_Consulta
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.griCbte = new DevExpress.XtraGrid.GridControl();
            this.gridViewCbte = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCbteCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodCbteCble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griCbte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbte)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // griCbte
            // 
            this.griCbte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.griCbte.Location = new System.Drawing.Point(0, 0);
            this.griCbte.MainView = this.gridViewCbte;
            this.griCbte.Name = "griCbte";
            this.griCbte.Size = new System.Drawing.Size(939, 254);
            this.griCbte.TabIndex = 13;
            this.griCbte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCbte});
            // 
            // gridViewCbte
            // 
            this.gridViewCbte.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdTipoCbte,
            this.IdCbteCble,
            this.CodCbteCble,
            this.Fecha,
            this.Observacion,
            this.IdPeriodo,
            this.Estado,
            this.Valor});
            this.gridViewCbte.GridControl = this.griCbte;
            this.gridViewCbte.Name = "gridViewCbte";
            this.gridViewCbte.OptionsBehavior.Editable = false;
            this.gridViewCbte.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCbte.OptionsView.ShowFooter = true;
            this.gridViewCbte.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IdCbteCble, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Fecha, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewCbte.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCbte_RowCellStyle);
            this.gridViewCbte.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCbte_FocusedRowChanged);
            // 
            // IdTipoCbte
            // 
            this.IdTipoCbte.Caption = "Tipo Cbte";
            this.IdTipoCbte.FieldName = "tipoCTCB";
            this.IdTipoCbte.Name = "IdTipoCbte";
            this.IdTipoCbte.OptionsColumn.AllowEdit = false;
            this.IdTipoCbte.Visible = true;
            this.IdTipoCbte.VisibleIndex = 2;
            this.IdTipoCbte.Width = 101;
            // 
            // IdCbteCble
            // 
            this.IdCbteCble.Caption = "#Comprobante";
            this.IdCbteCble.FieldName = "IdCbteCble";
            this.IdCbteCble.Name = "IdCbteCble";
            this.IdCbteCble.OptionsColumn.AllowEdit = false;
            this.IdCbteCble.Visible = true;
            this.IdCbteCble.VisibleIndex = 1;
            this.IdCbteCble.Width = 107;
            // 
            // CodCbteCble
            // 
            this.CodCbteCble.Caption = "Cod Comprobante";
            this.CodCbteCble.FieldName = "CodCbteCble";
            this.CodCbteCble.Name = "CodCbteCble";
            this.CodCbteCble.OptionsColumn.AllowEdit = false;
            this.CodCbteCble.Visible = true;
            this.CodCbteCble.VisibleIndex = 0;
            this.CodCbteCble.Width = 102;
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "cb_Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.OptionsColumn.AllowEdit = false;
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 3;
            this.Fecha.Width = 95;
            // 
            // Observacion
            // 
            this.Observacion.Caption = "Observacion";
            this.Observacion.FieldName = "cb_Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.OptionsColumn.AllowEdit = false;
            this.Observacion.Visible = true;
            this.Observacion.VisibleIndex = 4;
            this.Observacion.Width = 263;
            // 
            // IdPeriodo
            // 
            this.IdPeriodo.Caption = "Periodo";
            this.IdPeriodo.FieldName = "IdPeriodo";
            this.IdPeriodo.Name = "IdPeriodo";
            this.IdPeriodo.OptionsColumn.AllowEdit = false;
            this.IdPeriodo.Visible = true;
            this.IdPeriodo.VisibleIndex = 6;
            this.IdPeriodo.Width = 71;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.OptionsColumn.AllowEdit = false;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 7;
            this.Estado.Width = 73;
            // 
            // Valor
            // 
            this.Valor.Caption = "Valor";
            this.Valor.DisplayFormat.FormatString = "n2";
            this.Valor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Valor.FieldName = "cb_Valor";
            this.Valor.Name = "Valor";
            this.Valor.OptionsColumn.AllowEdit = false;
            this.Valor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cb_Valor", "{0:n2}")});
            this.Valor.Visible = true;
            this.Valor.VisibleIndex = 5;
            this.Valor.Width = 85;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 154);
            this.panel1.TabIndex = 14;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 8, 6, 13, 2, 5, 371);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 10, 6, 13, 2, 5, 371);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(939, 153);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 408);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(939, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.griCbte);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 254);
            this.panel2.TabIndex = 16;
            // 
            // frmCon_CbteCble_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.panel1);
            this.Name = "frmCon_CbteCble_Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobante Contable Consulta";
            this.Load += new System.EventHandler(this.frmCon_CbteCble_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griCbte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCbte)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl griCbte;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCbte;
        private DevExpress.XtraGrid.Columns.GridColumn IdTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn IdCbteCble;
        private DevExpress.XtraGrid.Columns.GridColumn CodCbteCble;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn IdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Valor;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel2;
    }
}
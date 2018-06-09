namespace Core.Erp.Winform.Academico
{
    partial class Frm_Aca_Forma_Pago_Cons
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
            this.gridControl_Mecanismo_Pago = new DevExpress.XtraGrid.GridControl();
            this.gridView_Mecanismo_Pago = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Id_Mecanismo_Pago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Mecanismo_Pago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Mecanismo_Pago)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.CargarTodasBodegas = false;
            this.ucGe_Menu.CargarTodasSucursales = true;
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 4, 17, 13, 48, 43, 292);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 6, 17, 13, 48, 43, 292);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(639, 90);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible = false;
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
            this.ucGe_Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 277);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(639, 26);
            this.ucGe_BarraEstado.TabIndex = 2;
            this.ucGe_BarraEstado.Visible = false;
            // 
            // gridControl_Mecanismo_Pago
            // 
            this.gridControl_Mecanismo_Pago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Mecanismo_Pago.Location = new System.Drawing.Point(0, 90);
            this.gridControl_Mecanismo_Pago.MainView = this.gridView_Mecanismo_Pago;
            this.gridControl_Mecanismo_Pago.Name = "gridControl_Mecanismo_Pago";
            this.gridControl_Mecanismo_Pago.Size = new System.Drawing.Size(639, 187);
            this.gridControl_Mecanismo_Pago.TabIndex = 3;
            this.gridControl_Mecanismo_Pago.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Mecanismo_Pago});
            // 
            // gridView_Mecanismo_Pago
            // 
            this.gridView_Mecanismo_Pago.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Id_Mecanismo_Pago,
            this.col_Descripcion,
            this.col_Codigo,
            this.colEstado});
            this.gridView_Mecanismo_Pago.GridControl = this.gridControl_Mecanismo_Pago;
            this.gridView_Mecanismo_Pago.Name = "gridView_Mecanismo_Pago";
            this.gridView_Mecanismo_Pago.OptionsBehavior.Editable = false;
            this.gridView_Mecanismo_Pago.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Mecanismo_Pago.OptionsView.ShowGroupPanel = false;
            this.gridView_Mecanismo_Pago.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_Mecanismo_Pago_FocusedRowChanged);
            this.gridView_Mecanismo_Pago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_Mecanismo_Pago_KeyDown);
            this.gridView_Mecanismo_Pago.DoubleClick += new System.EventHandler(this.gridView_Mecanismo_Pago_DoubleClick);
            // 
            // col_Id_Mecanismo_Pago
            // 
            this.col_Id_Mecanismo_Pago.Caption = "Id Mecanismo Pago";
            this.col_Id_Mecanismo_Pago.FieldName = "Id_tipo_meca_pago";
            this.col_Id_Mecanismo_Pago.Name = "col_Id_Mecanismo_Pago";
            this.col_Id_Mecanismo_Pago.Visible = true;
            this.col_Id_Mecanismo_Pago.VisibleIndex = 0;
            this.col_Id_Mecanismo_Pago.Width = 140;
            // 
            // col_Descripcion
            // 
            this.col_Descripcion.Caption = "Descripcion";
            this.col_Descripcion.FieldName = "nombre";
            this.col_Descripcion.Name = "col_Descripcion";
            this.col_Descripcion.Visible = true;
            this.col_Descripcion.VisibleIndex = 2;
            this.col_Descripcion.Width = 686;
            // 
            // col_Codigo
            // 
            this.col_Codigo.Caption = "Código";
            this.col_Codigo.FieldName = "Codigo";
            this.col_Codigo.Name = "col_Codigo";
            this.col_Codigo.Visible = true;
            this.col_Codigo.VisibleIndex = 1;
            this.col_Codigo.Width = 265;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 3;
            this.colEstado.Width = 89;
            // 
            // Frm_Aca_Forma_Pago_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 303);
            this.Controls.Add(this.gridControl_Mecanismo_Pago);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "Frm_Aca_Forma_Pago_Cons";
            this.Text = "Frm_Aca_Forma_Pago_Cons";
            this.Load += new System.EventHandler(this.Frm_Aca_Forma_Pago_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Mecanismo_Pago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Mecanismo_Pago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private DevExpress.XtraGrid.GridControl gridControl_Mecanismo_Pago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Mecanismo_Pago;
        private DevExpress.XtraGrid.Columns.GridColumn col_Id_Mecanismo_Pago;
        private DevExpress.XtraGrid.Columns.GridColumn col_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn col_Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}
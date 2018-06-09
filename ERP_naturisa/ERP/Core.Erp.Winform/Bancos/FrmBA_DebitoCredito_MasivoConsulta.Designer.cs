namespace Core.Erp.Winform.Bancos
{
    partial class FrmBA_DebitoCredito_MasivoConsulta
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
            this.gridControl_nota = new DevExpress.XtraGrid.GridControl();
            this.banotasDebCremasivoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UltraGrid_nota = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa_cb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCbteCble_cb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipocbte_cb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeb_Cred = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalTransacciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_nota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banotasDebCremasivoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_nota)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_nota
            // 
            this.gridControl_nota.DataSource = this.banotasDebCremasivoInfoBindingSource;
            this.gridControl_nota.Location = new System.Drawing.Point(0, 0);
            this.gridControl_nota.MainView = this.UltraGrid_nota;
            this.gridControl_nota.Name = "gridControl_nota";
            this.gridControl_nota.Size = new System.Drawing.Size(758, 305);
            this.gridControl_nota.TabIndex = 0;
            this.gridControl_nota.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGrid_nota});
            // 
            // banotasDebCremasivoInfoBindingSource
            // 
            this.banotasDebCremasivoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Bancos.ba_notasDebCre_masivo_Info);
            // 
            // UltraGrid_nota
            // 
            this.UltraGrid_nota.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdTransaccion,
            this.colIdEmpresa_cb,
            this.colIdCbteCble_cb,
            this.colIdTipocbte_cb,
            this.colObservacion,
            this.colfecha,
            this.colDeb_Cred,
            this.colIdUsuario,
            this.colTotalTransacciones});
            this.UltraGrid_nota.GridControl = this.gridControl_nota;
            this.UltraGrid_nota.Name = "UltraGrid_nota";
            this.UltraGrid_nota.OptionsView.ShowAutoFilterRow = true;
            this.UltraGrid_nota.OptionsView.ShowGroupPanel = false;
            this.UltraGrid_nota.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdTransaccion, DevExpress.Data.ColumnSortOrder.Descending)});
            this.UltraGrid_nota.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.UltraGrid_nota_FocusedRowChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            // 
            // colIdTransaccion
            // 
            this.colIdTransaccion.Caption = "Trans#";
            this.colIdTransaccion.FieldName = "IdTransaccion";
            this.colIdTransaccion.Name = "colIdTransaccion";
            this.colIdTransaccion.OptionsColumn.AllowEdit = false;
            this.colIdTransaccion.Visible = true;
            this.colIdTransaccion.VisibleIndex = 1;
            this.colIdTransaccion.Width = 49;
            // 
            // colIdEmpresa_cb
            // 
            this.colIdEmpresa_cb.FieldName = "IdEmpresa_cb";
            this.colIdEmpresa_cb.Name = "colIdEmpresa_cb";
            this.colIdEmpresa_cb.OptionsColumn.AllowEdit = false;
            // 
            // colIdCbteCble_cb
            // 
            this.colIdCbteCble_cb.FieldName = "IdCbteCble_cb";
            this.colIdCbteCble_cb.Name = "colIdCbteCble_cb";
            this.colIdCbteCble_cb.OptionsColumn.AllowEdit = false;
            // 
            // colIdTipocbte_cb
            // 
            this.colIdTipocbte_cb.FieldName = "IdTipocbte_cb";
            this.colIdTipocbte_cb.Name = "colIdTipocbte_cb";
            this.colIdTipocbte_cb.OptionsColumn.AllowEdit = false;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.OptionsColumn.AllowEdit = false;
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 5;
            this.colObservacion.Width = 397;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 0;
            this.colfecha.Width = 53;
            // 
            // colDeb_Cred
            // 
            this.colDeb_Cred.Caption = "Tipo";
            this.colDeb_Cred.FieldName = "Deb_Cred";
            this.colDeb_Cred.Name = "colDeb_Cred";
            this.colDeb_Cred.Visible = true;
            this.colDeb_Cred.VisibleIndex = 2;
            this.colDeb_Cred.Width = 100;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.Caption = "Usuario";
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Visible = true;
            this.colIdUsuario.VisibleIndex = 3;
            this.colIdUsuario.Width = 89;
            // 
            // colTotalTransacciones
            // 
            this.colTotalTransacciones.Caption = "Total Transacciones";
            this.colTotalTransacciones.FieldName = "TotalTransacciones";
            this.colTotalTransacciones.Name = "colTotalTransacciones";
            this.colTotalTransacciones.Visible = true;
            this.colTotalTransacciones.VisibleIndex = 4;
            this.colTotalTransacciones.Width = 52;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 94);
            this.panel1.TabIndex = 5;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 3, 2, 11, 50, 14, 111);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 5, 2, 11, 50, 14, 111);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(758, 94);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.panel2.Controls.Add(this.gridControl_nota);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 327);
            this.panel2.TabIndex = 6;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 301);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(758, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // FrmBA_DebitoCredito_MasivoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 421);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBA_DebitoCredito_MasivoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Debito Credito Masivo Consulta";
            this.Load += new System.EventHandler(this.FrmBA_DebitoCredito_MasivoConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_nota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banotasDebCremasivoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_nota)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_nota;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGrid_nota;
        private System.Windows.Forms.BindingSource banotasDebCremasivoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa_cb;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble_cb;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipocbte_cb;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colDeb_Cred;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalTransacciones;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
    }
}
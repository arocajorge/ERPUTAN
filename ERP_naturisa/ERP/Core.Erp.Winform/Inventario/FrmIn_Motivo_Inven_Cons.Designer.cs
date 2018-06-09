namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Motivo_Inven_Cons
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
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlMovi_inve_tipo = new DevExpress.XtraGrid.GridControl();
            this.gridViewTipoInve = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMotivo_Inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCod_Motivo_Inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesc_mov_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneracc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colexigirpc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgenera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMovi_inve_tipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoInve)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 389);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(854, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
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
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2014, 9, 6, 17, 12, 35, 999);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2014, 11, 6, 17, 12, 35, 999);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(854, 96);
            this.ucGe_Menu.TabIndex = 1;
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
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlMovi_inve_tipo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 293);
            this.panel1.TabIndex = 2;
            // 
            // gridControlMovi_inve_tipo
            // 
            this.gridControlMovi_inve_tipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMovi_inve_tipo.Location = new System.Drawing.Point(0, 0);
            this.gridControlMovi_inve_tipo.MainView = this.gridViewTipoInve;
            this.gridControlMovi_inve_tipo.Name = "gridControlMovi_inve_tipo";
            this.gridControlMovi_inve_tipo.Size = new System.Drawing.Size(854, 293);
            this.gridControlMovi_inve_tipo.TabIndex = 0;
            this.gridControlMovi_inve_tipo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTipoInve});
            this.gridControlMovi_inve_tipo.Click += new System.EventHandler(this.gridControlMovi_inve_tipo_Click);
            // 
            // gridViewTipoInve
            // 
            this.gridViewTipoInve.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMotivo_Inv,
            this.colCod_Motivo_Inv,
            this.colDesc_mov_inv,
            this.colGeneracc,
            this.colexigirpc,
            this.colEstado,
            this.colgenera});
            this.gridViewTipoInve.GridControl = this.gridControlMovi_inve_tipo;
            this.gridViewTipoInve.Name = "gridViewTipoInve";
            this.gridViewTipoInve.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewTipoInve_RowCellStyle);
            // 
            // colIdMotivo_Inv
            // 
            this.colIdMotivo_Inv.Caption = "Id";
            this.colIdMotivo_Inv.FieldName = "IdMotivo_Inv";
            this.colIdMotivo_Inv.Name = "colIdMotivo_Inv";
            this.colIdMotivo_Inv.Visible = true;
            this.colIdMotivo_Inv.VisibleIndex = 0;
            this.colIdMotivo_Inv.Width = 35;
            // 
            // colCod_Motivo_Inv
            // 
            this.colCod_Motivo_Inv.Caption = "codigo";
            this.colCod_Motivo_Inv.FieldName = "Cod_Motivo_Inv";
            this.colCod_Motivo_Inv.Name = "colCod_Motivo_Inv";
            this.colCod_Motivo_Inv.Visible = true;
            this.colCod_Motivo_Inv.VisibleIndex = 1;
            this.colCod_Motivo_Inv.Width = 46;
            // 
            // colDesc_mov_inv
            // 
            this.colDesc_mov_inv.Caption = "Descripcion";
            this.colDesc_mov_inv.FieldName = "Desc_mov_inv";
            this.colDesc_mov_inv.Name = "colDesc_mov_inv";
            this.colDesc_mov_inv.Visible = true;
            this.colDesc_mov_inv.VisibleIndex = 2;
            this.colDesc_mov_inv.Width = 68;
            // 
            // colGeneracc
            // 
            this.colGeneracc.Caption = "Genera Cuentas por Pagar";
            this.colGeneracc.FieldName = "Genera_CXP";
            this.colGeneracc.Name = "colGeneracc";
            this.colGeneracc.Visible = true;
            this.colGeneracc.VisibleIndex = 4;
            this.colGeneracc.Width = 143;
            // 
            // colexigirpc
            // 
            this.colexigirpc.Caption = "Exigir Puntos de Cargo";
            this.colexigirpc.FieldName = "Genera_CXP";
            this.colexigirpc.Name = "colexigirpc";
            this.colexigirpc.Visible = true;
            this.colexigirpc.VisibleIndex = 5;
            this.colexigirpc.Width = 96;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 6;
            this.colEstado.Width = 319;
            // 
            // colgenera
            // 
            this.colgenera.Caption = "Genera Movimientos de Inventario";
            this.colgenera.FieldName = "Genera_Movi_Inven";
            this.colgenera.Name = "colgenera";
            this.colgenera.Visible = true;
            this.colgenera.VisibleIndex = 3;
            this.colgenera.Width = 129;
            // 
            // FrmIn_Motivo_Inven_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Name = "FrmIn_Motivo_Inven_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Motivo de Inventario";
            this.Load += new System.EventHandler(this.FrmIn_Motivo_Inven_Cons_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMovi_inve_tipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTipoInve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlMovi_inve_tipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTipoInve;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivo_Inv;
        private DevExpress.XtraGrid.Columns.GridColumn colCod_Motivo_Inv;
        private DevExpress.XtraGrid.Columns.GridColumn colDesc_mov_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneracc;
        private DevExpress.XtraGrid.Columns.GridColumn colexigirpc;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colgenera;

    }
}
namespace Core.Erp.Winform.Inventario
{
    partial class frmIn_Tipo_Movi_Inven_Consulta
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.inmoviinventipoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_tipoMovi_Inven = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi_inven_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltm_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_tipo_movi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_interno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_descripcionCorta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinventipoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_tipoMovi_Inven)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(829, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.inmoviinventipoInfoBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 98);
            this.gridControl.MainView = this.gridView_tipoMovi_Inven;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(829, 333);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_tipoMovi_Inven});
            // 
            // inmoviinventipoInfoBindingSource
            // 
            this.inmoviinventipoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_movi_inven_tipo_Info);
            // 
            // gridView_tipoMovi_Inven
            // 
            this.gridView_tipoMovi_Inven.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdMovi_inven_tipo,
            this.colCodigo,
            this.coltm_descripcion,
            this.colcm_tipo_movi,
            this.colcm_interno,
            this.colcm_descripcionCorta,
            this.colEstado,
            this.colIdTipoCbte,
            this.colChek});
            this.gridView_tipoMovi_Inven.GridControl = this.gridControl;
            this.gridView_tipoMovi_Inven.Name = "gridView_tipoMovi_Inven";
            this.gridView_tipoMovi_Inven.OptionsBehavior.Editable = false;
            this.gridView_tipoMovi_Inven.OptionsView.ShowAutoFilterRow = true;
            this.gridView_tipoMovi_Inven.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdMovi_inven_tipo
            // 
            this.colIdMovi_inven_tipo.FieldName = "IdMovi_inven_tipo";
            this.colIdMovi_inven_tipo.Name = "colIdMovi_inven_tipo";
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 99;
            // 
            // coltm_descripcion
            // 
            this.coltm_descripcion.Caption = "Descripcion";
            this.coltm_descripcion.FieldName = "tm_descripcion";
            this.coltm_descripcion.Name = "coltm_descripcion";
            this.coltm_descripcion.Visible = true;
            this.coltm_descripcion.VisibleIndex = 1;
            this.coltm_descripcion.Width = 442;
            // 
            // colcm_tipo_movi
            // 
            this.colcm_tipo_movi.Caption = "Tipo (-/+)";
            this.colcm_tipo_movi.FieldName = "cm_tipo_movi";
            this.colcm_tipo_movi.Name = "colcm_tipo_movi";
            this.colcm_tipo_movi.Visible = true;
            this.colcm_tipo_movi.VisibleIndex = 2;
            this.colcm_tipo_movi.Width = 84;
            // 
            // colcm_interno
            // 
            this.colcm_interno.FieldName = "cm_interno";
            this.colcm_interno.Name = "colcm_interno";
            // 
            // colcm_descripcionCorta
            // 
            this.colcm_descripcionCorta.FieldName = "cm_descripcionCorta";
            this.colcm_descripcionCorta.Name = "colcm_descripcionCorta";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 3;
            this.colEstado.Width = 186;
            // 
            // colIdTipoCbte
            // 
            this.colIdTipoCbte.FieldName = "IdTipoCbte";
            this.colIdTipoCbte.Name = "colIdTipoCbte";
            // 
            // colChek
            // 
            this.colChek.FieldName = "Chek";
            this.colChek.Name = "colChek";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 98);
            this.panel2.TabIndex = 6;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 26, 11, 51, 26, 159);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 26, 11, 51, 26, 159);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(829, 95);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // frmIn_Tipo_Movi_Inven_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 453);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmIn_Tipo_Movi_Inven_Consulta";
            this.Text = "Consulta de Tipos de Movimientos de Inventario";
            this.Load += new System.EventHandler(this.FrmIn_Tipo_Movi_Inven_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmoviinventipoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_tipoMovi_Inven)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_tipoMovi_Inven;
        private System.Windows.Forms.BindingSource inmoviinventipoInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi_inven_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coltm_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_tipo_movi;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_interno;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_descripcionCorta;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colChek;
        private System.Windows.Forms.Panel panel2;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
       
    }
}
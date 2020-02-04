namespace Core.Erp.Winform.General
{
    partial class FrmGe_CatalogoConsulta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridControlCatalogo = new DevExpress.XtraGrid.GridControl();
            this.gridViewCatalogo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCatalogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colca_orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnNuevo_TipoCat = new System.Windows.Forms.ToolStripSplitButton();
            this.lstbox_TipoCatalogo = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCatalogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 537);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridControlCatalogo);
            this.panel4.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 99);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(684, 438);
            this.panel4.TabIndex = 0;
            // 
            // gridControlCatalogo
            // 
            this.gridControlCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCatalogo.Location = new System.Drawing.Point(0, 0);
            this.gridControlCatalogo.MainView = this.gridViewCatalogo;
            this.gridControlCatalogo.Name = "gridControlCatalogo";
            this.gridControlCatalogo.Size = new System.Drawing.Size(684, 412);
            this.gridControlCatalogo.TabIndex = 12;
            this.gridControlCatalogo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCatalogo});
            // 
            // gridViewCatalogo
            // 
            this.gridViewCatalogo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodCatalogo,
            this.colIdTipoCatalogo,
            this.colIdCatalogo,
            this.colca_descripcion,
            this.colca_estado,
            this.colca_orden});
            this.gridViewCatalogo.GridControl = this.gridControlCatalogo;
            this.gridViewCatalogo.Name = "gridViewCatalogo";
            this.gridViewCatalogo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewCatalogo_RowCellStyle);
            // 
            // colCodCatalogo
            // 
            this.colCodCatalogo.Caption = "Código";
            this.colCodCatalogo.FieldName = "CodCatalogo";
            this.colCodCatalogo.Name = "colCodCatalogo";
            this.colCodCatalogo.OptionsColumn.AllowEdit = false;
            this.colCodCatalogo.Visible = true;
            this.colCodCatalogo.VisibleIndex = 0;
            // 
            // colIdTipoCatalogo
            // 
            this.colIdTipoCatalogo.Caption = "IdTipoCatalogo";
            this.colIdTipoCatalogo.FieldName = "IdTipoCatalogo";
            this.colIdTipoCatalogo.Name = "colIdTipoCatalogo";
            this.colIdTipoCatalogo.OptionsColumn.AllowEdit = false;
            this.colIdTipoCatalogo.Visible = true;
            this.colIdTipoCatalogo.VisibleIndex = 1;
            // 
            // colIdCatalogo
            // 
            this.colIdCatalogo.Caption = "IdCatalogo";
            this.colIdCatalogo.FieldName = "IdCatalogo";
            this.colIdCatalogo.Name = "colIdCatalogo";
            this.colIdCatalogo.OptionsColumn.AllowEdit = false;
            this.colIdCatalogo.Visible = true;
            this.colIdCatalogo.VisibleIndex = 2;
            // 
            // colca_descripcion
            // 
            this.colca_descripcion.Caption = "Descripción";
            this.colca_descripcion.FieldName = "ca_descripcion";
            this.colca_descripcion.Name = "colca_descripcion";
            this.colca_descripcion.OptionsColumn.AllowEdit = false;
            this.colca_descripcion.Visible = true;
            this.colca_descripcion.VisibleIndex = 3;
            // 
            // colca_estado
            // 
            this.colca_estado.Caption = "Estado";
            this.colca_estado.FieldName = "ca_estado";
            this.colca_estado.Name = "colca_estado";
            this.colca_estado.OptionsColumn.AllowEdit = false;
            this.colca_estado.Visible = true;
            this.colca_estado.VisibleIndex = 4;
            // 
            // colca_orden
            // 
            this.colca_orden.FieldName = "ca_orden";
            this.colca_orden.Name = "colca_orden";
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 412);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(684, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 99);
            this.panel3.TabIndex = 0;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 1, 4, 18, 44, 8, 828);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 3, 4, 18, 44, 8, 829);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(684, 96);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 11;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Controls.Add(this.lstbox_TipoCatalogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 537);
            this.panel2.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo_TipoCat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 515);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(200, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnNuevo_TipoCat
            // 
            this.btnNuevo_TipoCat.Image = global::Core.Erp.Winform.Properties.Resources.nuevo;
            this.btnNuevo_TipoCat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo_TipoCat.Name = "btnNuevo_TipoCat";
            this.btnNuevo_TipoCat.Size = new System.Drawing.Size(74, 20);
            this.btnNuevo_TipoCat.Text = "Nuevo";
            this.btnNuevo_TipoCat.ButtonClick += new System.EventHandler(this.btnNuevo_TipoCat_ButtonClick);
            // 
            // lstbox_TipoCatalogo
            // 
            this.lstbox_TipoCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstbox_TipoCatalogo.FormattingEnabled = true;
            this.lstbox_TipoCatalogo.Location = new System.Drawing.Point(0, 0);
            this.lstbox_TipoCatalogo.Name = "lstbox_TipoCatalogo";
            this.lstbox_TipoCatalogo.Size = new System.Drawing.Size(200, 537);
            this.lstbox_TipoCatalogo.TabIndex = 0;
            this.lstbox_TipoCatalogo.SelectedIndexChanged += new System.EventHandler(this.lstbox_TipoCatalogo_SelectedIndexChanged);
            // 
            // FrmGe_CatalogoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 537);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGe_CatalogoConsulta";
            this.Text = "Consulta de Catálogos varios";
            this.Load += new System.EventHandler(this.FrmGe_CatalogoConsulta_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCatalogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstbox_TipoCatalogo;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl gridControlCatalogo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCatalogo;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton btnNuevo_TipoCat;
        private DevExpress.XtraGrid.Columns.GridColumn colCodCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCatalogo;
        private DevExpress.XtraGrid.Columns.GridColumn colca_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colca_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colca_orden;

    }
}
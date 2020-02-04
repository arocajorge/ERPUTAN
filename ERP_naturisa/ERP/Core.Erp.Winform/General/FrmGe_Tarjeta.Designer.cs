namespace Core.Erp.Winform.General
{
    partial class FrmGe_Tarjeta
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
            this.gridControlTarjeta = new DevExpress.XtraGrid.GridControl();
            this.vwGetbTarjetatbParametroInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridViewTarjeta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTarjeta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltr_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Tarj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_tipo_x_Tarj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_tipo_x_RetFu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCobro_tipo_x_RetIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcetaje_Comision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_Comision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbtarjetaInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGetbTarjetatbParametroInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtarjetaInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlTarjeta
            // 
            this.gridControlTarjeta.DataSource = this.vwGetbTarjetatbParametroInfoBindingSource;
            this.gridControlTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTarjeta.Location = new System.Drawing.Point(0, 0);
            this.gridControlTarjeta.MainView = this.gridViewTarjeta;
            this.gridControlTarjeta.Name = "gridControlTarjeta";
            this.gridControlTarjeta.Size = new System.Drawing.Size(951, 273);
            this.gridControlTarjeta.TabIndex = 0;
            this.gridControlTarjeta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTarjeta});
            // 
            // vwGetbTarjetatbParametroInfoBindingSource
            // 
            this.vwGetbTarjetatbParametroInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.vwGe_tb_Tarjeta_tb_Parametro_Info);
            // 
            // gridViewTarjeta
            // 
            this.gridViewTarjeta.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewTarjeta.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTarjeta.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewTarjeta.AppearancePrint.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTarjeta.ColumnPanelRowHeight = 60;
            this.gridViewTarjeta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTarjeta,
            this.coltr_Descripcion,
            this.colIdBanco,
            this.colIdCtaCble_Tarj,
            this.colIdCobro_tipo_x_Tarj,
            this.colIdCobro_tipo_x_RetFu,
            this.colIdCobro_tipo_x_RetIva,
            this.colPorcetaje_Comision,
            this.colIdCtaCble_Comision,
            this.colEstado});
            this.gridViewTarjeta.GridControl = this.gridControlTarjeta;
            this.gridViewTarjeta.Name = "gridViewTarjeta";
            this.gridViewTarjeta.OptionsBehavior.Editable = false;
            this.gridViewTarjeta.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewTarjeta_RowCellStyle);
            // 
            // colIdTarjeta
            // 
            this.colIdTarjeta.FieldName = "IdTarjeta";
            this.colIdTarjeta.Name = "colIdTarjeta";
            this.colIdTarjeta.Visible = true;
            this.colIdTarjeta.VisibleIndex = 0;
            this.colIdTarjeta.Width = 46;
            // 
            // coltr_Descripcion
            // 
            this.coltr_Descripcion.Caption = "Descripción";
            this.coltr_Descripcion.FieldName = "tr_Descripcion";
            this.coltr_Descripcion.Name = "coltr_Descripcion";
            this.coltr_Descripcion.Visible = true;
            this.coltr_Descripcion.VisibleIndex = 1;
            this.coltr_Descripcion.Width = 147;
            // 
            // colIdBanco
            // 
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Visible = true;
            this.colIdBanco.VisibleIndex = 2;
            this.colIdBanco.Width = 90;
            // 
            // colIdCtaCble_Tarj
            // 
            this.colIdCtaCble_Tarj.Caption = "Id Cta Cble de la Tarjeta";
            this.colIdCtaCble_Tarj.FieldName = "IdCtaCble_Tarj";
            this.colIdCtaCble_Tarj.Name = "colIdCtaCble_Tarj";
            this.colIdCtaCble_Tarj.Visible = true;
            this.colIdCtaCble_Tarj.VisibleIndex = 3;
            this.colIdCtaCble_Tarj.Width = 106;
            // 
            // colIdCobro_tipo_x_Tarj
            // 
            this.colIdCobro_tipo_x_Tarj.Caption = "Id Tipo de cobro por tarjerta";
            this.colIdCobro_tipo_x_Tarj.FieldName = "IdCobro_tipo_x_Tarj";
            this.colIdCobro_tipo_x_Tarj.Name = "colIdCobro_tipo_x_Tarj";
            this.colIdCobro_tipo_x_Tarj.Visible = true;
            this.colIdCobro_tipo_x_Tarj.VisibleIndex = 4;
            this.colIdCobro_tipo_x_Tarj.Width = 107;
            // 
            // colIdCobro_tipo_x_RetFu
            // 
            this.colIdCobro_tipo_x_RetFu.Caption = "Id Tipo de cobro de retención a la fuente";
            this.colIdCobro_tipo_x_RetFu.FieldName = "IdCobro_tipo_x_RetFu";
            this.colIdCobro_tipo_x_RetFu.Name = "colIdCobro_tipo_x_RetFu";
            this.colIdCobro_tipo_x_RetFu.Visible = true;
            this.colIdCobro_tipo_x_RetFu.VisibleIndex = 5;
            this.colIdCobro_tipo_x_RetFu.Width = 108;
            // 
            // colIdCobro_tipo_x_RetIva
            // 
            this.colIdCobro_tipo_x_RetIva.Caption = "Id Tipo de cobro de retención de IVA";
            this.colIdCobro_tipo_x_RetIva.FieldName = "IdCobro_tipo_x_RetIva";
            this.colIdCobro_tipo_x_RetIva.Name = "colIdCobro_tipo_x_RetIva";
            this.colIdCobro_tipo_x_RetIva.Visible = true;
            this.colIdCobro_tipo_x_RetIva.VisibleIndex = 6;
            this.colIdCobro_tipo_x_RetIva.Width = 108;
            // 
            // colPorcetaje_Comision
            // 
            this.colPorcetaje_Comision.Caption = "% Comision";
            this.colPorcetaje_Comision.FieldName = "Porcetaje_Comision";
            this.colPorcetaje_Comision.Name = "colPorcetaje_Comision";
            this.colPorcetaje_Comision.Visible = true;
            this.colPorcetaje_Comision.VisibleIndex = 7;
            this.colPorcetaje_Comision.Width = 64;
            // 
            // colIdCtaCble_Comision
            // 
            this.colIdCtaCble_Comision.Caption = "Id CtaCble Comision";
            this.colIdCtaCble_Comision.FieldName = "IdCtaCble_Comision";
            this.colIdCtaCble_Comision.Name = "colIdCtaCble_Comision";
            this.colIdCtaCble_Comision.Visible = true;
            this.colIdCtaCble_Comision.VisibleIndex = 8;
            this.colIdCtaCble_Comision.Width = 99;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 9;
            this.colEstado.Width = 58;
            // 
            // tbtarjetaInfoBindingSource
            // 
            this.tbtarjetaInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_tarjeta_Info);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 91);
            this.panel1.TabIndex = 1;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 3, 1, 10, 5, 47, 506);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 5, 1, 10, 5, 47, 506);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(951, 97);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlTarjeta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 273);
            this.panel2.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 342);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(951, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmGe_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 364);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGe_Tarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarjeta";
            this.Load += new System.EventHandler(this.FrmGe_Tarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwGetbTarjetatbParametroInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbtarjetaInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlTarjeta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTarjeta;
        private System.Windows.Forms.BindingSource tbtarjetaInfoBindingSource;
        private System.Windows.Forms.BindingSource vwGetbTarjetatbParametroInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTarjeta;
        private DevExpress.XtraGrid.Columns.GridColumn coltr_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Tarj;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo_x_Tarj;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo_x_RetFu;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCobro_tipo_x_RetIva;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcetaje_Comision;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_Comision;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxc_cobro_tipo
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
            this.gridConsulta = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdCobro_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc_EsCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc_Afecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc_interno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc_generaNCAuto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc_abreviatura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc_cobroDirecto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc_cobroInDirecto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc_docXCobrar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tc_Orden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridConsulta
            // 
            this.gridConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsulta.Location = new System.Drawing.Point(0, 0);
            this.gridConsulta.MainView = this.gridView1;
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.Size = new System.Drawing.Size(1094, 233);
            this.gridConsulta.TabIndex = 26;
            this.gridConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdCobro_tipo,
            this.tc_descripcion,
            this.tc_EsCheque,
            this.tc_Afecha,
            this.tc_interno,
            this.Estado,
            this.tc_generaNCAuto,
            this.tc_abreviatura,
            this.tc_cobroDirecto,
            this.tc_cobroInDirecto,
            this.tc_docXCobrar,
            this.tc_Orden,
            this.IdUsuario,
            this.Fecha_Transac,
            this.IdUsuarioUltMod,
            this.Fecha_UltMod,
            this.IdUsuarioUltAnu});
            this.gridView1.GridControl = this.gridConsulta;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IdCobro_tipo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // IdCobro_tipo
            // 
            this.IdCobro_tipo.Caption = "ID Cobro Tipo";
            this.IdCobro_tipo.FieldName = "IdCobro_tipo";
            this.IdCobro_tipo.Name = "IdCobro_tipo";
            this.IdCobro_tipo.Visible = true;
            this.IdCobro_tipo.VisibleIndex = 0;
            this.IdCobro_tipo.Width = 82;
            // 
            // tc_descripcion
            // 
            this.tc_descripcion.Caption = "Descripcion";
            this.tc_descripcion.FieldName = "tc_descripcion";
            this.tc_descripcion.Name = "tc_descripcion";
            this.tc_descripcion.Visible = true;
            this.tc_descripcion.VisibleIndex = 1;
            this.tc_descripcion.Width = 82;
            // 
            // tc_EsCheque
            // 
            this.tc_EsCheque.Caption = "Es Cheque";
            this.tc_EsCheque.FieldName = "tc_EsCheque";
            this.tc_EsCheque.Name = "tc_EsCheque";
            this.tc_EsCheque.Visible = true;
            this.tc_EsCheque.VisibleIndex = 2;
            this.tc_EsCheque.Width = 82;
            // 
            // tc_Afecha
            // 
            this.tc_Afecha.Caption = "A Fecha";
            this.tc_Afecha.FieldName = "tc_Afecha";
            this.tc_Afecha.Name = "tc_Afecha";
            this.tc_Afecha.Visible = true;
            this.tc_Afecha.VisibleIndex = 3;
            this.tc_Afecha.Width = 82;
            // 
            // tc_interno
            // 
            this.tc_interno.Caption = "Interno";
            this.tc_interno.FieldName = "tc_interno";
            this.tc_interno.Name = "tc_interno";
            this.tc_interno.Visible = true;
            this.tc_interno.VisibleIndex = 4;
            this.tc_interno.Width = 82;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 12;
            this.Estado.Width = 89;
            // 
            // tc_generaNCAuto
            // 
            this.tc_generaNCAuto.Caption = "GeneraNCAuto";
            this.tc_generaNCAuto.FieldName = "tc_generaNCAuto";
            this.tc_generaNCAuto.Name = "tc_generaNCAuto";
            this.tc_generaNCAuto.Visible = true;
            this.tc_generaNCAuto.VisibleIndex = 5;
            this.tc_generaNCAuto.Width = 82;
            // 
            // tc_abreviatura
            // 
            this.tc_abreviatura.Caption = "Abreviatura";
            this.tc_abreviatura.FieldName = "tc_abreviatura";
            this.tc_abreviatura.Name = "tc_abreviatura";
            this.tc_abreviatura.Visible = true;
            this.tc_abreviatura.VisibleIndex = 6;
            this.tc_abreviatura.Width = 82;
            // 
            // tc_cobroDirecto
            // 
            this.tc_cobroDirecto.Caption = "Cobro Directo";
            this.tc_cobroDirecto.FieldName = "tc_cobroDirecto";
            this.tc_cobroDirecto.Name = "tc_cobroDirecto";
            this.tc_cobroDirecto.Visible = true;
            this.tc_cobroDirecto.VisibleIndex = 7;
            this.tc_cobroDirecto.Width = 82;
            // 
            // tc_cobroInDirecto
            // 
            this.tc_cobroInDirecto.Caption = "Cobro Indirecto";
            this.tc_cobroInDirecto.FieldName = "tc_cobroInDirecto";
            this.tc_cobroInDirecto.Name = "tc_cobroInDirecto";
            this.tc_cobroInDirecto.Visible = true;
            this.tc_cobroInDirecto.VisibleIndex = 8;
            this.tc_cobroInDirecto.Width = 82;
            // 
            // tc_docXCobrar
            // 
            this.tc_docXCobrar.Caption = "tc_docXCobrar";
            this.tc_docXCobrar.FieldName = "tc_docXCobrar";
            this.tc_docXCobrar.Name = "tc_docXCobrar";
            this.tc_docXCobrar.Visible = true;
            this.tc_docXCobrar.VisibleIndex = 9;
            this.tc_docXCobrar.Width = 91;
            // 
            // tc_Orden
            // 
            this.tc_Orden.Caption = "tc_Orden";
            this.tc_Orden.FieldName = "tc_Orden";
            this.tc_Orden.Name = "tc_Orden";
            this.tc_Orden.Visible = true;
            this.tc_Orden.VisibleIndex = 10;
            this.tc_Orden.Width = 79;
            // 
            // IdUsuario
            // 
            this.IdUsuario.Caption = "IdUsuario";
            this.IdUsuario.FieldName = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Visible = true;
            this.IdUsuario.VisibleIndex = 11;
            this.IdUsuario.Width = 79;
            // 
            // Fecha_Transac
            // 
            this.Fecha_Transac.Caption = "Fecha_Transac";
            this.Fecha_Transac.FieldName = "Fecha_Transac";
            this.Fecha_Transac.Name = "Fecha_Transac";
            // 
            // IdUsuarioUltMod
            // 
            this.IdUsuarioUltMod.Caption = "IdUsuarioUltMod";
            this.IdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.IdUsuarioUltMod.Name = "IdUsuarioUltMod";
            // 
            // Fecha_UltMod
            // 
            this.Fecha_UltMod.Caption = "Fecha_UltMod";
            this.Fecha_UltMod.FieldName = "Fecha_UltMod";
            this.Fecha_UltMod.Name = "Fecha_UltMod";
            // 
            // IdUsuarioUltAnu
            // 
            this.IdUsuarioUltAnu.Caption = "IdUsuarioUltAnu";
            this.IdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.IdUsuarioUltAnu.Name = "IdUsuarioUltAnu";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 327);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1094, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 94);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridConsulta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1094, 233);
            this.panel2.TabIndex = 29;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 3, 28, 11, 31, 19, 731);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 5, 28, 11, 31, 19, 731);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1094, 94);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // frmCo_cxc_cobro_tipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 349);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmCo_cxc_cobro_tipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cuentas por Cobrar";
            this.Load += new System.EventHandler(this.frmCo_cxc_cobro_tipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdCobro_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn tc_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn tc_EsCheque;
        private DevExpress.XtraGrid.Columns.GridColumn tc_Afecha;
        private DevExpress.XtraGrid.Columns.GridColumn tc_interno;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn tc_generaNCAuto;
        private DevExpress.XtraGrid.Columns.GridColumn tc_abreviatura;
        private DevExpress.XtraGrid.Columns.GridColumn tc_cobroDirecto;
        private DevExpress.XtraGrid.Columns.GridColumn tc_cobroInDirecto;
        private DevExpress.XtraGrid.Columns.GridColumn tc_docXCobrar;
        private DevExpress.XtraGrid.Columns.GridColumn tc_Orden;
        private DevExpress.XtraGrid.Columns.GridColumn IdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn IdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn IdUsuarioUltAnu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;

    }
}
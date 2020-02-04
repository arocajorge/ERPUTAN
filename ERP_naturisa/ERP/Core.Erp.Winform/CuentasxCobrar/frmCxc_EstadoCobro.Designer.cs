namespace Core.Erp.Winform.CuentasxCobrar
{
    partial class frmCxc_EstadoCobro
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
            this.gridControlEstadoCobro = new DevExpress.XtraGrid.GridControl();
            this.cxcEstadoCobroInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewEstadoCobro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEstadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cxcEstadoCobroInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEstadoCobro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxcEstadoCobroInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEstadoCobro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxcEstadoCobroInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlEstadoCobro
            // 
            this.gridControlEstadoCobro.DataSource = this.cxcEstadoCobroInfoBindingSource1;
            this.gridControlEstadoCobro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEstadoCobro.Location = new System.Drawing.Point(0, 0);
            this.gridControlEstadoCobro.MainView = this.gridViewEstadoCobro;
            this.gridControlEstadoCobro.Name = "gridControlEstadoCobro";
            this.gridControlEstadoCobro.Size = new System.Drawing.Size(500, 220);
            this.gridControlEstadoCobro.TabIndex = 10;
            this.gridControlEstadoCobro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEstadoCobro});
            // 
            // cxcEstadoCobroInfoBindingSource1
            // 
            this.cxcEstadoCobroInfoBindingSource1.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_EstadoCobro_Info);
            // 
            // gridViewEstadoCobro
            // 
            this.gridViewEstadoCobro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEstadoCobro,
            this.colDescripcion,
            this.colposicion});
            this.gridViewEstadoCobro.GridControl = this.gridControlEstadoCobro;
            this.gridViewEstadoCobro.Name = "gridViewEstadoCobro";
            this.gridViewEstadoCobro.OptionsBehavior.Editable = false;
            // 
            // colIdEstadoCobro
            // 
            this.colIdEstadoCobro.FieldName = "IdEstadoCobro";
            this.colIdEstadoCobro.Name = "colIdEstadoCobro";
            this.colIdEstadoCobro.Visible = true;
            this.colIdEstadoCobro.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colposicion
            // 
            this.colposicion.Caption = "Posicion";
            this.colposicion.FieldName = "posicion";
            this.colposicion.Name = "colposicion";
            this.colposicion.Visible = true;
            this.colposicion.VisibleIndex = 2;
            // 
            // cxcEstadoCobroInfoBindingSource
            // 
            this.cxcEstadoCobroInfoBindingSource.DataSource = typeof(Core.Erp.Info.CuentasxCobrar.cxc_EstadoCobro_Info);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(500, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 94);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlEstadoCobro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 220);
            this.panel2.TabIndex = 13;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 3, 28, 15, 31, 31, 988);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 5, 28, 15, 31, 31, 988);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(500, 97);
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
            // frmCxc_EstadoCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 336);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmCxc_EstadoCobro";
            this.Text = "Estado De Cobro";
            this.Load += new System.EventHandler(this.frmCxc_EstadoCobro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEstadoCobro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxcEstadoCobroInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEstadoCobro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxcEstadoCobroInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlEstadoCobro;
        private System.Windows.Forms.BindingSource cxcEstadoCobroInfoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEstadoCobro;
        private System.Windows.Forms.BindingSource cxcEstadoCobroInfoBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colposicion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
    }
}
namespace Core.Erp.Winform.Importacion
{
    partial class frmImp_ParametrosGastos_Consulta
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
            this.gridControlGastos = new DevExpress.XtraGrid.GridControl();
            this.impgastosxImportInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewGastos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdGastoImp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colga_decripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colga_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impgastosxImportInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGastos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlGastos
            // 
            this.gridControlGastos.DataSource = this.impgastosxImportInfoBindingSource;
            this.gridControlGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGastos.Location = new System.Drawing.Point(0, 0);
            this.gridControlGastos.MainView = this.gridViewGastos;
            this.gridControlGastos.Name = "gridControlGastos";
            this.gridControlGastos.Size = new System.Drawing.Size(768, 333);
            this.gridControlGastos.TabIndex = 1;
            this.gridControlGastos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGastos});
            // 
            // impgastosxImportInfoBindingSource
            // 
            this.impgastosxImportInfoBindingSource.DataSource = typeof(Core.Erp.Info.Importacion.imp_gastosxImport_Info);
            // 
            // gridViewGastos
            // 
            this.gridViewGastos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdGastoImp,
            this.Codigo,
            this.colga_decripcion,
            this.colga_estado});
            this.gridViewGastos.GridControl = this.gridControlGastos;
            this.gridViewGastos.Name = "gridViewGastos";
            this.gridViewGastos.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewGastos_RowCellStyle);
            this.gridViewGastos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewGastos_FocusedRowChanged);
            // 
            // colIdGastoImp
            // 
            this.colIdGastoImp.Caption = "Id";
            this.colIdGastoImp.FieldName = "IdGastoImp";
            this.colIdGastoImp.Name = "colIdGastoImp";
            this.colIdGastoImp.Visible = true;
            this.colIdGastoImp.VisibleIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "CodGastoImp";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 1;
            // 
            // colga_decripcion
            // 
            this.colga_decripcion.Caption = "Descripcion";
            this.colga_decripcion.FieldName = "ga_decripcion";
            this.colga_decripcion.Name = "colga_decripcion";
            this.colga_decripcion.Visible = true;
            this.colga_decripcion.VisibleIndex = 2;
            // 
            // colga_estado
            // 
            this.colga_estado.Caption = "Estado";
            this.colga_estado.FieldName = "ga_estado";
            this.colga_estado.Name = "colga_estado";
            this.colga_estado.Visible = true;
            this.colga_estado.VisibleIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 96);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlGastos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 333);
            this.panel2.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 407);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(768, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 5, 15, 37, 48, 437);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 5, 15, 37, 48, 437);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(768, 97);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            // 
            // frmImp_ParametrosGastos_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 429);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmImp_ParametrosGastos_Consulta";
            this.Text = "Gastos De Importación Parámetros Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impgastosxImportInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGastos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlGastos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGastos;
        private System.Windows.Forms.BindingSource impgastosxImportInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGastoImp;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn colga_decripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colga_estado;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}
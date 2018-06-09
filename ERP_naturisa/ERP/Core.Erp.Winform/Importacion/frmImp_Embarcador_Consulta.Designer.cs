namespace Core.Erp.Winform.Importacion
{
    partial class frmImp_Embarcador_Consulta
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
            this.impEmbarcadorInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlEmbarcador = new DevExpress.XtraGrid.GridControl();
         //**  this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmbarcador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_contacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewEmbarcador = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.impEmbarcadorInfoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmbarcador)).BeginInit();
          //**  ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmbarcador)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // impEmbarcadorInfoBindingSource
            // 
            this.impEmbarcadorInfoBindingSource.DataSource = typeof(Core.Erp.Info.Importacion.imp_Embarcador_Info);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1007, 22);
            this.statusStrip1.TabIndex = 17;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2014, 4, 5, 14, 41, 20, 432);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2014, 6, 5, 14, 41, 20, 433);
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1007, 97);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 18;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 91);
            this.panel1.TabIndex = 19;
            // 
            // gridControlEmbarcador
            // 
            this.gridControlEmbarcador.DataSource = this.impEmbarcadorInfoBindingSource;
            this.gridControlEmbarcador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEmbarcador.Location = new System.Drawing.Point(0, 0);
            this.gridControlEmbarcador.MainView = this.gridViewEmbarcador;
            this.gridControlEmbarcador.Name = "gridControlEmbarcador";
            this.gridControlEmbarcador.Size = new System.Drawing.Size(1007, 258);
            this.gridControlEmbarcador.TabIndex = 16;
            this.gridControlEmbarcador.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmbarcador});
            // 
            // gridView1
            // 
            //this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            //this.colIdEmbarcador,
            //this.colem_descripcion,
            //this.colem_direccion,
            //this.colem_telefono,
            //this.colem_contacto,
            //this.colem_email,
            //this.colEstado});
            //this.gridView1.GridControl = this.gridControlEmbarcador;
            //this.gridView1.Name = "gridView1";
            // 
            // gridViewEmbarcador
            // 
            this.gridViewEmbarcador.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmbarcador,
            this.colem_descripcion,
            this.colem_direccion,
            this.colem_telefono,
            this.colem_contacto,
            this.colem_email,
            this.colEstado});
            this.gridViewEmbarcador.GridControl = this.gridControlEmbarcador;
            this.gridViewEmbarcador.Name = "gridViewEmbarcador";
            this.gridViewEmbarcador.OptionsBehavior.Editable = false;
            this.gridViewEmbarcador.OptionsView.ShowAutoFilterRow = true;
            this.gridViewEmbarcador.OptionsView.ShowGroupPanel = false;
            this.gridViewEmbarcador.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdEmbarcador, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewEmbarcador.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewEmbarcador_RowCellStyle);
            this.gridViewEmbarcador.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewEmbarcador_FocusedRowChanged);
           
            // 
            // colIdEmbarcador
            // 
            this.colIdEmbarcador.Caption = "# Embarcador";
            this.colIdEmbarcador.FieldName = "IdEmbarcador";
            this.colIdEmbarcador.Name = "colIdEmbarcador";
            this.colIdEmbarcador.Visible = true;
            this.colIdEmbarcador.VisibleIndex = 0;
            // 
            // colem_descripcion
            // 
            this.colem_descripcion.Caption = "Descripcion";
            this.colem_descripcion.FieldName = "em_descripcion";
            this.colem_descripcion.Name = "colem_descripcion";
            this.colem_descripcion.Visible = true;
            this.colem_descripcion.VisibleIndex = 1;
            // 
            // colem_direccion
            // 
            this.colem_direccion.Caption = "Direccion";
            this.colem_direccion.FieldName = "em_direccion";
            this.colem_direccion.Name = "colem_direccion";
            this.colem_direccion.Visible = true;
            this.colem_direccion.VisibleIndex = 2;
            // 
            // colem_telefono
            // 
            this.colem_telefono.Caption = "Telefono";
            this.colem_telefono.FieldName = "em_telefono";
            this.colem_telefono.Name = "colem_telefono";
            this.colem_telefono.Visible = true;
            this.colem_telefono.VisibleIndex = 3;
            // 
            // colem_contacto
            // 
            this.colem_contacto.Caption = "Contacto";
            this.colem_contacto.FieldName = "em_contacto";
            this.colem_contacto.Name = "colem_contacto";
            this.colem_contacto.Visible = true;
            this.colem_contacto.VisibleIndex = 4;
            // 
            // colem_email
            // 
            this.colem_email.Caption = "E-mail";
            this.colem_email.FieldName = "em_email";
            this.colem_email.Name = "colem_email";
            this.colem_email.Visible = true;
            this.colem_email.VisibleIndex = 5;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 6;
          // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlEmbarcador);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 258);
            this.panel2.TabIndex = 20;
            // 
            // frmImp_Embarcador_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 371);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmImp_Embarcador_Consulta";
            this.Text = "Embarcardor Consulta";
            this.Load += new System.EventHandler(this.frmImp_Embarcador_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.impEmbarcadorInfoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmbarcador)).EndInit();
          //**  ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmbarcador)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource impEmbarcadorInfoBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlEmbarcador;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmbarcador;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmbarcador;
        private DevExpress.XtraGrid.Columns.GridColumn colem_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colem_direccion;
        private DevExpress.XtraGrid.Columns.GridColumn colem_telefono;
        private DevExpress.XtraGrid.Columns.GridColumn colem_contacto;
        private DevExpress.XtraGrid.Columns.GridColumn colem_email;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
     //**   private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
    }
}
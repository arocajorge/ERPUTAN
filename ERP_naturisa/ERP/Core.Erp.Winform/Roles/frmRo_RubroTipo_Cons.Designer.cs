namespace Core.Erp.Winform.Roles
{
    partial class frmRo_RubroTipo_Cons
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
            this.gridCtrlRubro = new DevExpress.XtraGrid.GridControl();
            this.gridViewRubro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColCodRubro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNombreC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColOrden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubro)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCtrlRubro
            // 
            this.gridCtrlRubro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlRubro.Location = new System.Drawing.Point(0, 0);
            this.gridCtrlRubro.MainView = this.gridViewRubro;
            this.gridCtrlRubro.Name = "gridCtrlRubro";
            this.gridCtrlRubro.Size = new System.Drawing.Size(687, 311);
            this.gridCtrlRubro.TabIndex = 12;
            this.gridCtrlRubro.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRubro});
            // 
            // gridViewRubro
            // 
            this.gridViewRubro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColCodRubro,
            this.ColDescripcion,
            this.ColNombreC,
            this.ColTipo,
            this.ColEstado,
            this.ColOrden,
            this.ColID});
            this.gridViewRubro.CustomizationFormBounds = new System.Drawing.Rectangle(512, 442, 216, 185);
            this.gridViewRubro.GridControl = this.gridCtrlRubro;
            this.gridViewRubro.Name = "gridViewRubro";
            this.gridViewRubro.OptionsBehavior.ReadOnly = true;
            this.gridViewRubro.OptionsView.ShowAutoFilterRow = true;
            this.gridViewRubro.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.ColOrden, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewRubro.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewRubro_RowStyle);
            this.gridViewRubro.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewRubro_FocusedRowChanged);
            // 
            // ColCodRubro
            // 
            this.ColCodRubro.Caption = "Código";
            this.ColCodRubro.FieldName = "rub_codigo";
            this.ColCodRubro.Name = "ColCodRubro";
            this.ColCodRubro.Visible = true;
            this.ColCodRubro.VisibleIndex = 1;
            this.ColCodRubro.Width = 105;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.Caption = "Descripción";
            this.ColDescripcion.FieldName = "ru_descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.Visible = true;
            this.ColDescripcion.VisibleIndex = 2;
            this.ColDescripcion.Width = 587;
            // 
            // ColNombreC
            // 
            this.ColNombreC.Caption = "Nombre Corto";
            this.ColNombreC.FieldName = "NombreCorto";
            this.ColNombreC.Name = "ColNombreC";
            this.ColNombreC.Visible = true;
            this.ColNombreC.VisibleIndex = 3;
            this.ColNombreC.Width = 124;
            // 
            // ColTipo
            // 
            this.ColTipo.Caption = "Tipo";
            this.ColTipo.FieldName = "ru_tipo";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.Visible = true;
            this.ColTipo.VisibleIndex = 4;
            this.ColTipo.Width = 130;
            // 
            // ColEstado
            // 
            this.ColEstado.Caption = "Estado";
            this.ColEstado.FieldName = "ru_estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.Visible = true;
            this.ColEstado.VisibleIndex = 5;
            this.ColEstado.Width = 134;
            // 
            // ColOrden
            // 
            this.ColOrden.Caption = "Orden";
            this.ColOrden.FieldName = "ru_orden";
            this.ColOrden.Name = "ColOrden";
            this.ColOrden.Visible = true;
            this.ColOrden.VisibleIndex = 0;
            this.ColOrden.Width = 94;
            // 
            // ColID
            // 
            this.ColID.Caption = "gridColumn1";
            this.ColID.FieldName = "IdRubro";
            this.ColID.Name = "ColID";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 405);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(687, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 94);
            this.panel1.TabIndex = 14;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2015, 2, 23, 9, 18, 35, 327);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2015, 4, 23, 9, 18, 35, 327);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(687, 94);
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
            this.panel2.Controls.Add(this.gridCtrlRubro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 311);
            this.panel2.TabIndex = 15;
            // 
            // frmRo_RubroTipo_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmRo_RubroTipo_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Tipo Rubro";
            this.Load += new System.EventHandler(this.frmRo_RubroTipo_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRubro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCtrlRubro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRubro;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodRubro;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn ColNombreC;
        private DevExpress.XtraGrid.Columns.GridColumn ColTipo;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstado;
        private DevExpress.XtraGrid.Columns.GridColumn ColOrden;
        private DevExpress.XtraGrid.Columns.GridColumn ColID;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
    }
}
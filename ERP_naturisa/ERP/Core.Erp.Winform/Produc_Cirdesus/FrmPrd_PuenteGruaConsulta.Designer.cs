namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class FrmPrd_PuenteGruaConsulta
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControlPuenteGrua = new DevExpress.XtraGrid.GridControl();
            this.gridViewPuenteGrua = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColidPuenteGrua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Coltonelada_Soporta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPuenteGrua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPuenteGrua)).BeginInit();
            this.SuspendLayout();
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
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 3, 7, 11, 50, 49, 888);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 5, 7, 11, 50, 49, 888);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(652, 111);
            this.ucGe_Menu.TabIndex = 17;
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
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_event_btnImprimir_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlPuenteGrua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 214);
            this.panel1.TabIndex = 18;
            // 
            // gridControlPuenteGrua
            // 
            this.gridControlPuenteGrua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPuenteGrua.Location = new System.Drawing.Point(0, 0);
            this.gridControlPuenteGrua.MainView = this.gridViewPuenteGrua;
            this.gridControlPuenteGrua.Name = "gridControlPuenteGrua";
            this.gridControlPuenteGrua.Size = new System.Drawing.Size(652, 214);
            this.gridControlPuenteGrua.TabIndex = 0;
            this.gridControlPuenteGrua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPuenteGrua});
            // 
            // gridViewPuenteGrua
            // 
            this.gridViewPuenteGrua.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColidPuenteGrua,
            this.Colnombre,
            this.Coltonelada_Soporta,
            this.Colestado});
            this.gridViewPuenteGrua.GridControl = this.gridControlPuenteGrua;
            this.gridViewPuenteGrua.Name = "gridViewPuenteGrua";
            this.gridViewPuenteGrua.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridViewPuenteGrua.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridViewPuenteGrua.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewPuenteGrua_RowCellStyle);
            // 
            // ColidPuenteGrua
            // 
            this.ColidPuenteGrua.Caption = "Id PuenteGrua";
            this.ColidPuenteGrua.FieldName = "idPuenteGrua";
            this.ColidPuenteGrua.Name = "ColidPuenteGrua";
            this.ColidPuenteGrua.Visible = true;
            this.ColidPuenteGrua.VisibleIndex = 0;
            // 
            // Colnombre
            // 
            this.Colnombre.Caption = "Nombre";
            this.Colnombre.FieldName = "nombre";
            this.Colnombre.Name = "Colnombre";
            this.Colnombre.Visible = true;
            this.Colnombre.VisibleIndex = 1;
            // 
            // Coltonelada_Soporta
            // 
            this.Coltonelada_Soporta.Caption = "Tonelada Soporta";
            this.Coltonelada_Soporta.FieldName = "tonelada_Soporta";
            this.Coltonelada_Soporta.Name = "Coltonelada_Soporta";
            this.Coltonelada_Soporta.Visible = true;
            this.Coltonelada_Soporta.VisibleIndex = 2;
            // 
            // Colestado
            // 
            this.Colestado.Caption = "Estado";
            this.Colestado.FieldName = "estado";
            this.Colestado.Name = "Colestado";
            this.Colestado.Visible = true;
            this.Colestado.VisibleIndex = 3;
            // 
            // FrmPrd_PuenteGruaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 325);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmPrd_PuenteGruaConsulta";
            this.Text = "FrmPrd_PuenteGruaConsulta";
            this.Load += new System.EventHandler(this.FrmPrd_PuenteGruaConsulta_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPuenteGrua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPuenteGrua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlPuenteGrua;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPuenteGrua;
        private DevExpress.XtraGrid.Columns.GridColumn ColidPuenteGrua;
        private DevExpress.XtraGrid.Columns.GridColumn Colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn Coltonelada_Soporta;
        private DevExpress.XtraGrid.Columns.GridColumn Colestado;
    }
}
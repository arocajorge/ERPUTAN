namespace Core.Erp.Winform.General
{
    partial class FrmGE_EmpresaCons
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
            this.gridControlEmpresa = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmpresa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnem_ruc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnem_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnem_gerente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnem_telefonos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnem_direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnem_logo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridColumnEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2015, 2, 28, 14, 40, 16, 367);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2015, 4, 30, 14, 40, 16, 367);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(973, 115);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = true;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_sucursal = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControlEmpresa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 390);
            this.panel1.TabIndex = 1;
            // 
            // gridControlEmpresa
            // 
            this.gridControlEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEmpresa.Location = new System.Drawing.Point(0, 0);
            this.gridControlEmpresa.MainView = this.gridViewEmpresa;
            this.gridControlEmpresa.Name = "gridControlEmpresa";
            this.gridControlEmpresa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControlEmpresa.Size = new System.Drawing.Size(973, 390);
            this.gridControlEmpresa.TabIndex = 0;
            this.gridControlEmpresa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmpresa});
            // 
            // gridViewEmpresa
            // 
            this.gridViewEmpresa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnIdEmpresa,
            this.gridColumnem_ruc,
            this.gridColumnem_nombre,
            this.gridColumnem_gerente,
            this.gridColumnem_telefonos,
            this.gridColumnem_direccion,
            this.gridColumnem_logo,
            this.gridColumnEstado});
            this.gridViewEmpresa.GridControl = this.gridControlEmpresa;
            this.gridViewEmpresa.Name = "gridViewEmpresa";
            this.gridViewEmpresa.OptionsBehavior.Editable = false;
            // 
            // gridColumnIdEmpresa
            // 
            this.gridColumnIdEmpresa.Caption = "IdEmpresa";
            this.gridColumnIdEmpresa.FieldName = "IdEmpresa";
            this.gridColumnIdEmpresa.Name = "gridColumnIdEmpresa";
            this.gridColumnIdEmpresa.Visible = true;
            this.gridColumnIdEmpresa.VisibleIndex = 0;
            this.gridColumnIdEmpresa.Width = 62;
            // 
            // gridColumnem_ruc
            // 
            this.gridColumnem_ruc.Caption = "Ruc";
            this.gridColumnem_ruc.FieldName = "em_ruc";
            this.gridColumnem_ruc.Name = "gridColumnem_ruc";
            this.gridColumnem_ruc.Visible = true;
            this.gridColumnem_ruc.VisibleIndex = 1;
            this.gridColumnem_ruc.Width = 155;
            // 
            // gridColumnem_nombre
            // 
            this.gridColumnem_nombre.Caption = "Nombre";
            this.gridColumnem_nombre.FieldName = "em_nombre";
            this.gridColumnem_nombre.Name = "gridColumnem_nombre";
            this.gridColumnem_nombre.Visible = true;
            this.gridColumnem_nombre.VisibleIndex = 2;
            this.gridColumnem_nombre.Width = 215;
            // 
            // gridColumnem_gerente
            // 
            this.gridColumnem_gerente.Caption = "Gerente";
            this.gridColumnem_gerente.FieldName = "em_gerente";
            this.gridColumnem_gerente.Name = "gridColumnem_gerente";
            this.gridColumnem_gerente.Visible = true;
            this.gridColumnem_gerente.VisibleIndex = 3;
            this.gridColumnem_gerente.Width = 143;
            // 
            // gridColumnem_telefonos
            // 
            this.gridColumnem_telefonos.Caption = "Télefonos";
            this.gridColumnem_telefonos.FieldName = "em_telefonos";
            this.gridColumnem_telefonos.Name = "gridColumnem_telefonos";
            this.gridColumnem_telefonos.Visible = true;
            this.gridColumnem_telefonos.VisibleIndex = 4;
            this.gridColumnem_telefonos.Width = 143;
            // 
            // gridColumnem_direccion
            // 
            this.gridColumnem_direccion.Caption = "Direccion";
            this.gridColumnem_direccion.FieldName = "em_direccion";
            this.gridColumnem_direccion.Name = "gridColumnem_direccion";
            this.gridColumnem_direccion.Visible = true;
            this.gridColumnem_direccion.VisibleIndex = 5;
            this.gridColumnem_direccion.Width = 246;
            // 
            // gridColumnem_logo
            // 
            this.gridColumnem_logo.Caption = "Logo";
            this.gridColumnem_logo.ColumnEdit = this.repositoryItemPictureEdit1;
            this.gridColumnem_logo.FieldName = "em_logo";
            this.gridColumnem_logo.Name = "gridColumnem_logo";
            this.gridColumnem_logo.Visible = true;
            this.gridColumnem_logo.VisibleIndex = 6;
            this.gridColumnem_logo.Width = 106;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // gridColumnEstado
            // 
            this.gridColumnEstado.Caption = "Estado";
            this.gridColumnEstado.FieldName = "Estado";
            this.gridColumnEstado.Name = "gridColumnEstado";
            this.gridColumnEstado.Visible = true;
            this.gridColumnEstado.VisibleIndex = 7;
            this.gridColumnEstado.Width = 88;
            // 
            // FrmGE_EmpresaCons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "FrmGE_EmpresaCons";
            this.Text = "CONSULTA DE EMPRESAS";
            this.Load += new System.EventHandler(this.FrmGE_EmpresaCons_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlEmpresa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnem_ruc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnem_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnem_gerente;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnem_telefonos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnem_direccion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnem_logo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
    }
}
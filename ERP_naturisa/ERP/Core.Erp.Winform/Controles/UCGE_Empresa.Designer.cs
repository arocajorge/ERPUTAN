
namespace Core.Erp.Winform.Controles
{
    partial class UCGe_Empresa
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbEmpresaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxEmpresa = new System.Windows.Forms.GroupBox();
            this.gridControlEmpresa = new DevExpress.XtraGrid.GridControl();
            this.gridViewEmpresa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_ruc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_gerente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_contador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_rucContador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_telefonos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_fax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_notificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_tel_int = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_logo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_fondo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colem_fechaInicioContable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaInfoBindingSource)).BeginInit();
            this.groupBoxEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmpresaInfoBindingSource
            // 
            this.tbEmpresaInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Empresa_Info);
            // 
            // groupBoxEmpresa
            // 
            this.groupBoxEmpresa.Controls.Add(this.gridControlEmpresa);
            this.groupBoxEmpresa.Controls.Add(this.chkTodos);
            this.groupBoxEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEmpresa.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEmpresa.Name = "groupBoxEmpresa";
            this.groupBoxEmpresa.Size = new System.Drawing.Size(400, 266);
            this.groupBoxEmpresa.TabIndex = 1;
            this.groupBoxEmpresa.TabStop = false;
            this.groupBoxEmpresa.Text = "Empresas";
            // 
            // gridControlEmpresa
            // 
            this.gridControlEmpresa.DataSource = this.tbEmpresaInfoBindingSource;
            this.gridControlEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlEmpresa.Location = new System.Drawing.Point(3, 33);
            this.gridControlEmpresa.MainView = this.gridViewEmpresa;
            this.gridControlEmpresa.Name = "gridControlEmpresa";
            this.gridControlEmpresa.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkEdit});
            this.gridControlEmpresa.Size = new System.Drawing.Size(394, 230);
            this.gridControlEmpresa.TabIndex = 2;
            this.gridControlEmpresa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmpresa});
            // 
            // gridViewEmpresa
            // 
            this.gridViewEmpresa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colem_nombre,
            this.colem_ruc,
            this.colem_gerente,
            this.colem_contador,
            this.colem_rucContador,
            this.colem_telefonos,
            this.colem_fax,
            this.colem_notificacion,
            this.colem_direccion,
            this.colem_tel_int,
            this.colem_logo,
            this.colem_fondo,
            this.colem_fechaInicioContable,
            this.colcheck});
            this.gridViewEmpresa.GridControl = this.gridControlEmpresa;
            this.gridViewEmpresa.Name = "gridViewEmpresa";
            this.gridViewEmpresa.OptionsView.ShowGroupPanel = false;
            this.gridViewEmpresa.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewEmpresa_RowCellClick);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colem_nombre
            // 
            this.colem_nombre.Caption = "Empresa";
            this.colem_nombre.FieldName = "em_nombre";
            this.colem_nombre.Name = "colem_nombre";
            this.colem_nombre.OptionsColumn.AllowEdit = false;
            this.colem_nombre.Visible = true;
            this.colem_nombre.VisibleIndex = 1;
            this.colem_nombre.Width = 1097;
            // 
            // colem_ruc
            // 
            this.colem_ruc.FieldName = "em_ruc";
            this.colem_ruc.Name = "colem_ruc";
            // 
            // colem_gerente
            // 
            this.colem_gerente.FieldName = "em_gerente";
            this.colem_gerente.Name = "colem_gerente";
            // 
            // colem_contador
            // 
            this.colem_contador.FieldName = "em_contador";
            this.colem_contador.Name = "colem_contador";
            // 
            // colem_rucContador
            // 
            this.colem_rucContador.FieldName = "em_rucContador";
            this.colem_rucContador.Name = "colem_rucContador";
            // 
            // colem_telefonos
            // 
            this.colem_telefonos.FieldName = "em_telefonos";
            this.colem_telefonos.Name = "colem_telefonos";
            // 
            // colem_fax
            // 
            this.colem_fax.FieldName = "em_fax";
            this.colem_fax.Name = "colem_fax";
            // 
            // colem_notificacion
            // 
            this.colem_notificacion.FieldName = "em_notificacion";
            this.colem_notificacion.Name = "colem_notificacion";
            // 
            // colem_direccion
            // 
            this.colem_direccion.FieldName = "em_direccion";
            this.colem_direccion.Name = "colem_direccion";
            // 
            // colem_tel_int
            // 
            this.colem_tel_int.FieldName = "em_tel_int";
            this.colem_tel_int.Name = "colem_tel_int";
            // 
            // colem_logo
            // 
            this.colem_logo.FieldName = "em_logo";
            this.colem_logo.Name = "colem_logo";
            // 
            // colem_fondo
            // 
            this.colem_fondo.FieldName = "em_fondo";
            this.colem_fondo.Name = "colem_fondo";
            // 
            // colem_fechaInicioContable
            // 
            this.colem_fechaInicioContable.FieldName = "em_fechaInicioContable";
            this.colem_fechaInicioContable.Name = "colem_fechaInicioContable";
            // 
            // colcheck
            // 
            this.colcheck.ColumnEdit = this.checkEdit;
            this.colcheck.FieldName = "check";
            this.colcheck.Name = "colcheck";
            this.colcheck.OptionsColumn.AllowEdit = false;
            this.colcheck.OptionsColumn.ShowCaption = false;
            this.colcheck.Visible = true;
            this.colcheck.VisibleIndex = 0;
            this.colcheck.Width = 52;
            // 
            // checkEdit
            // 
            this.checkEdit.AutoHeight = false;
            this.checkEdit.Name = "checkEdit";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkTodos.Location = new System.Drawing.Point(3, 16);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(394, 17);
            this.chkTodos.TabIndex = 1;
            this.chkTodos.Text = "Marcar Todas";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // UCGe_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxEmpresa);
            this.Name = "UCGe_Empresa";
            this.Size = new System.Drawing.Size(400, 266);
            ((System.ComponentModel.ISupportInitialize)(this.tbEmpresaInfoBindingSource)).EndInit();
            this.groupBoxEmpresa.ResumeLayout(false);
            this.groupBoxEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmpresa;
        private System.Windows.Forms.BindingSource tbEmpresaInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlEmpresa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colem_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colem_ruc;
        private DevExpress.XtraGrid.Columns.GridColumn colem_gerente;
        private DevExpress.XtraGrid.Columns.GridColumn colem_contador;
        private DevExpress.XtraGrid.Columns.GridColumn colem_rucContador;
        private DevExpress.XtraGrid.Columns.GridColumn colem_telefonos;
        private DevExpress.XtraGrid.Columns.GridColumn colem_fax;
        private DevExpress.XtraGrid.Columns.GridColumn colem_notificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colem_direccion;
        private DevExpress.XtraGrid.Columns.GridColumn colem_tel_int;
        private DevExpress.XtraGrid.Columns.GridColumn colem_logo;
        private DevExpress.XtraGrid.Columns.GridColumn colem_fondo;
        private DevExpress.XtraGrid.Columns.GridColumn colem_fechaInicioContable;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkEdit;
        public System.Windows.Forms.CheckBox chkTodos;
    }
}


namespace Core.Erp.Winform.Controles
{
    partial class UCGe_list_Sucursal
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
            this.groupBoxSucursales = new System.Windows.Forms.GroupBox();
            this.gridControlSucursales = new DevExpress.XtraGrid.GridControl();
            this.tbSucursalInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewSucursales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colChek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Check = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.checkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.groupBoxSucursales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSucursalInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSucursales
            // 
            this.groupBoxSucursales.Controls.Add(this.gridControlSucursales);
            this.groupBoxSucursales.Controls.Add(this.chkTodos);
            this.groupBoxSucursales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSucursales.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSucursales.Name = "groupBoxSucursales";
            this.groupBoxSucursales.Size = new System.Drawing.Size(268, 306);
            this.groupBoxSucursales.TabIndex = 2;
            this.groupBoxSucursales.TabStop = false;
            this.groupBoxSucursales.Text = "Sucursales";
            // 
            // gridControlSucursales
            // 
            this.gridControlSucursales.DataSource = this.tbSucursalInfoBindingSource;
            this.gridControlSucursales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSucursales.Location = new System.Drawing.Point(3, 33);
            this.gridControlSucursales.MainView = this.gridViewSucursales;
            this.gridControlSucursales.Name = "gridControlSucursales";
            this.gridControlSucursales.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.checkEdit,
            this.Check});
            this.gridControlSucursales.Size = new System.Drawing.Size(262, 270);
            this.gridControlSucursales.TabIndex = 3;
            this.gridControlSucursales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSucursales});
            // 
            // tbSucursalInfoBindingSource
            // 
            this.tbSucursalInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Sucursal_Info);
            // 
            // gridViewSucursales
            // 
            this.gridViewSucursales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChek,
            this.colIdEmpresa,
            this.colIdSucursal,
            this.colSu_Descripcion,
            this.colEstado,
            this.colNomEmpresa});
            this.gridViewSucursales.GridControl = this.gridControlSucursales;
            this.gridViewSucursales.Name = "gridViewSucursales";
            this.gridViewSucursales.OptionsView.ShowDetailButtons = false;
            this.gridViewSucursales.OptionsView.ShowGroupPanel = false;
            this.gridViewSucursales.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewSucursales_CellValueChanged);
            // 
            // colChek
            // 
            this.colChek.ColumnEdit = this.Check;
            this.colChek.FieldName = "Chek";
            this.colChek.Name = "colChek";
            this.colChek.OptionsColumn.ShowCaption = false;
            this.colChek.Visible = true;
            this.colChek.VisibleIndex = 0;
            this.colChek.Width = 20;
            // 
            // Check
            // 
            this.Check.AutoHeight = false;
            this.Check.Name = "Check";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.Width = 141;
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Sucursal";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.OptionsColumn.AllowEdit = false;
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 1;
            this.colSu_Descripcion.Width = 647;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colNomEmpresa
            // 
            this.colNomEmpresa.Caption = "Empresa";
            this.colNomEmpresa.FieldName = "NomEmpresa";
            this.colNomEmpresa.Name = "colNomEmpresa";
            this.colNomEmpresa.Visible = true;
            this.colNomEmpresa.VisibleIndex = 2;
            this.colNomEmpresa.Width = 310;
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
            this.chkTodos.Size = new System.Drawing.Size(262, 17);
            this.chkTodos.TabIndex = 2;
            this.chkTodos.Text = "Marcar Todas";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // UCGe_list_Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxSucursales);
            this.Name = "UCGe_list_Sucursal";
            this.Size = new System.Drawing.Size(268, 306);
            this.groupBoxSucursales.ResumeLayout(false);
            this.groupBoxSucursales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSucursalInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSucursales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSucursales;
        private System.Windows.Forms.BindingSource tbSucursalInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlSucursales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSucursales;
        private DevExpress.XtraGrid.Columns.GridColumn colChek;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit Check;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkEdit;
        public System.Windows.Forms.CheckBox chkTodos;
        private DevExpress.XtraGrid.Columns.GridColumn colNomEmpresa;
    }
}

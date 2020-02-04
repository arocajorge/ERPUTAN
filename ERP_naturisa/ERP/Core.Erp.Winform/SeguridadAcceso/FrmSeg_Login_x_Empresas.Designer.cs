namespace Core.Erp.Winform.SeguridadAcceso
{
    partial class FrmSeg_Login_x_Empresas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeg_Login_x_Empresas));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbempresainfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_empresa = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnColIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColCdigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnColRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_sucursal = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbempresainfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sucursal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit1.EditValue = global::Core.Erp.Winform.Properties.Resources.Usuario_acceso;
            this.pictureEdit1.Location = new System.Drawing.Point(455, 78);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(84, 72);
            this.pictureEdit1.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresar.Location = new System.Drawing.Point(130, 206);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(109, 29);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Location = new System.Drawing.Point(303, 206);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 29);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empresa:";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(96, 38);
            this.pictureEdit2.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 251);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(551, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(455, 12);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(84, 26);
            this.pictureEdit3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sucursal:";
            // 
            // cmb_empresa
            // 
            this.cmb_empresa.Location = new System.Drawing.Point(130, 77);
            this.cmb_empresa.Name = "cmb_empresa";
            this.cmb_empresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_empresa.Properties.DisplayMember = "em_nombre2";
            this.cmb_empresa.Properties.ValueMember = "IdEmpresa";
            this.cmb_empresa.Properties.View = this.searchLookUpEdit1View;
            this.cmb_empresa.Size = new System.Drawing.Size(297, 20);
            this.cmb_empresa.TabIndex = 10;
            this.cmb_empresa.EditValueChanged += new System.EventHandler(this.cmb_empresa_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnColIdEmpresa,
            this.gridColumnColCdigo,
            this.gridColumnColNombre,
            this.gridColumnColRazonSocial});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnColIdEmpresa
            // 
            this.gridColumnColIdEmpresa.Caption = "IdEmpresa";
            this.gridColumnColIdEmpresa.FieldName = "IdEmpresa";
            this.gridColumnColIdEmpresa.Name = "gridColumnColIdEmpresa";
            this.gridColumnColIdEmpresa.Visible = true;
            this.gridColumnColIdEmpresa.VisibleIndex = 0;
            this.gridColumnColIdEmpresa.Width = 99;
            // 
            // gridColumnColCdigo
            // 
            this.gridColumnColCdigo.Caption = "codigo";
            this.gridColumnColCdigo.FieldName = "codigo";
            this.gridColumnColCdigo.Name = "gridColumnColCdigo";
            this.gridColumnColCdigo.Visible = true;
            this.gridColumnColCdigo.VisibleIndex = 3;
            this.gridColumnColCdigo.Width = 185;
            // 
            // gridColumnColNombre
            // 
            this.gridColumnColNombre.Caption = "Nombre";
            this.gridColumnColNombre.FieldName = "em_nombre";
            this.gridColumnColNombre.Name = "gridColumnColNombre";
            this.gridColumnColNombre.Visible = true;
            this.gridColumnColNombre.VisibleIndex = 1;
            this.gridColumnColNombre.Width = 350;
            // 
            // gridColumnColRazonSocial
            // 
            this.gridColumnColRazonSocial.Caption = "Razon Social";
            this.gridColumnColRazonSocial.FieldName = "RazonSocial";
            this.gridColumnColRazonSocial.Name = "gridColumnColRazonSocial";
            this.gridColumnColRazonSocial.Visible = true;
            this.gridColumnColRazonSocial.VisibleIndex = 2;
            this.gridColumnColRazonSocial.Width = 182;
            // 
            // cmb_sucursal
            // 
            this.cmb_sucursal.Location = new System.Drawing.Point(130, 113);
            this.cmb_sucursal.Name = "cmb_sucursal";
            this.cmb_sucursal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_sucursal.Properties.DisplayMember = "Su_Descripcion2";
            this.cmb_sucursal.Properties.ValueMember = "IdSucursal";
            this.cmb_sucursal.Properties.View = this.searchLookUpEdit2View;
            this.cmb_sucursal.Size = new System.Drawing.Size(297, 20);
            this.cmb_sucursal.TabIndex = 11;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdSucursal,
            this.colcodigo,
            this.colSu_Descripcion});
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdSucursal
            // 
            this.ColIdSucursal.Caption = "IdSucursal";
            this.ColIdSucursal.FieldName = "IdSucursal";
            this.ColIdSucursal.Name = "ColIdSucursal";
            this.ColIdSucursal.Visible = true;
            this.ColIdSucursal.VisibleIndex = 2;
            this.ColIdSucursal.Width = 202;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "Codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 84;
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Descripcion";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 1;
            this.colSu_Descripcion.Width = 530;
            // 
            // FrmSeg_Login_x_Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(551, 273);
            this.Controls.Add(this.cmb_sucursal);
            this.Controls.Add(this.cmb_empresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeg_Login_x_Empresas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.FrmEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbempresainfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_sucursal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tbempresainfoBindingSource;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_empresa;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColCdigo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColNombre;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnColRazonSocial;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_sucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
    }
}
namespace Core.Erp.Winform.Controles
{
    partial class UCFa_Cliente_x_Contacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFa_Cliente_x_Contacto));
            this.grcContacto = new DevExpress.XtraGrid.GridControl();
            this.grvContacto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo_contacto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_buscar_contacto = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grcContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvContacto)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grcContacto
            // 
            this.grcContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcContacto.Location = new System.Drawing.Point(0, 0);
            this.grcContacto.MainView = this.grvContacto;
            this.grcContacto.Name = "grcContacto";
            this.grcContacto.Size = new System.Drawing.Size(500, 275);
            this.grcContacto.TabIndex = 1;
            this.grcContacto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvContacto});
            // 
            // grvContacto
            // 
            this.grvContacto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colCedula,
            this.colNombre,
            this.colApellido,
            this.colRazonSocial,
            this.colTelefono,
            this.colDireccion,
            this.gridColumn7});
            this.grvContacto.GridControl = this.grcContacto;
            this.grvContacto.Name = "grvContacto";
            this.grvContacto.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvContacto.OptionsSelection.MultiSelect = true;
            this.grvContacto.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvContacto.OptionsView.ShowAutoFilterRow = true;
            this.grvContacto.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsColumn.ShowCaption = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 23;
            // 
            // colCedula
            // 
            this.colCedula.Caption = "Cedula";
            this.colCedula.FieldName = "Persona_Info.pe_cedulaRuc";
            this.colCedula.Name = "colCedula";
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 1;
            this.colCedula.Width = 82;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Persona_Info.pe_nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            this.colNombre.Width = 89;
            // 
            // colApellido
            // 
            this.colApellido.Caption = "Apellido";
            this.colApellido.FieldName = "Persona_Info.pe_apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 3;
            this.colApellido.Width = 89;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.Caption = "Razón Social";
            this.colRazonSocial.FieldName = "Persona_Info.pe_razonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            // 
            // colTelefono
            // 
            this.colTelefono.Caption = "Telefono";
            this.colTelefono.FieldName = "Persona_Info.pe_celular";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 4;
            this.colTelefono.Width = 89;
            // 
            // colDireccion
            // 
            this.colDireccion.Caption = "Dirección";
            this.colDireccion.FieldName = "Persona_Info.pe_direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 5;
            this.colDireccion.Width = 110;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Name = "gridColumn7";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo_contacto,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.btn_buscar_contacto});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(500, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_nuevo_contacto
            // 
            this.btn_nuevo_contacto.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo_contacto.Image")));
            this.btn_nuevo_contacto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo_contacto.Name = "btn_nuevo_contacto";
            this.btn_nuevo_contacto.Size = new System.Drawing.Size(62, 22);
            this.btn_nuevo_contacto.Text = "Nuevo";
            this.btn_nuevo_contacto.Click += new System.EventHandler(this.sbNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel1.Text = "             ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_buscar_contacto
            // 
            this.btn_buscar_contacto.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_contacto.Image")));
            this.btn_buscar_contacto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_buscar_contacto.Name = "btn_buscar_contacto";
            this.btn_buscar_contacto.Size = new System.Drawing.Size(62, 22);
            this.btn_buscar_contacto.Text = "Buscar";
            this.btn_buscar_contacto.Click += new System.EventHandler(this.sbBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grcContacto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 275);
            this.panel1.TabIndex = 3;
            // 
            // UCFa_Cliente_x_Contacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UCFa_Cliente_x_Contacto";
            this.Size = new System.Drawing.Size(500, 300);
            this.Load += new System.EventHandler(this.UCFa_Cliente_x_Contacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvContacto)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcContacto;
        private DevExpress.XtraGrid.Views.Grid.GridView grvContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_nuevo_contacto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_buscar_contacto;
        private System.Windows.Forms.Panel panel1;

    }
}

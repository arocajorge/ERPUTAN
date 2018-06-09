namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Vendedor_Mant
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ci_ruc = new System.Windows.Forms.TextBox();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.txt_comision = new System.Windows.Forms.TextBox();
            this.txt_vendedor = new System.Windows.Forms.TextBox();
            this.lbl_id_vendedor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControlSucursal = new DevExpress.XtraGrid.GridControl();
            this.gridViewSucursal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_CodigoEstablecimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Ubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Ruc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_JefeSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Telefonos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Transac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltMod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuarioUltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_UltAnu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_pc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_ci_ruc);
            this.groupBox1.Controls.Add(this.chk_estado);
            this.groupBox1.Controls.Add(this.txt_comision);
            this.groupBox1.Controls.Add(this.txt_vendedor);
            this.groupBox1.Controls.Add(this.lbl_id_vendedor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Vendedor";
            // 
            // lblEstado
            // 
            this.lblEstado.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblEstado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(459, 6);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(156, 33);
            this.lblEstado.TabIndex = 66;
            this.lblEstado.Text = "**Anulado**";
            this.lblEstado.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cedula/Ruc";
            // 
            // txt_ci_ruc
            // 
            this.txt_ci_ruc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ci_ruc.Location = new System.Drawing.Point(312, 17);
            this.txt_ci_ruc.MaxLength = 13;
            this.txt_ci_ruc.Name = "txt_ci_ruc";
            this.txt_ci_ruc.Size = new System.Drawing.Size(141, 20);
            this.txt_ci_ruc.TabIndex = 1;
            this.txt_ci_ruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ci_ruc_KeyPress);
            this.txt_ci_ruc.Leave += new System.EventHandler(this.txt_ci_ruc_Leave);
            this.txt_ci_ruc.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ci_ruc_Validating);
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(25, 84);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(56, 17);
            this.chk_estado.TabIndex = 3;
            this.chk_estado.Text = "Activo";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // txt_comision
            // 
            this.txt_comision.Location = new System.Drawing.Point(325, 84);
            this.txt_comision.Name = "txt_comision";
            this.txt_comision.Size = new System.Drawing.Size(100, 20);
            this.txt_comision.TabIndex = 4;
            this.txt_comision.Text = "0.00";
            this.txt_comision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_comision_KeyPress);
            this.txt_comision.Leave += new System.EventHandler(this.txt_comision_Leave);
            // 
            // txt_vendedor
            // 
            this.txt_vendedor.Location = new System.Drawing.Point(136, 50);
            this.txt_vendedor.MaxLength = 200;
            this.txt_vendedor.Name = "txt_vendedor";
            this.txt_vendedor.Size = new System.Drawing.Size(317, 20);
            this.txt_vendedor.TabIndex = 2;
            // 
            // lbl_id_vendedor
            // 
            this.lbl_id_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_id_vendedor.Location = new System.Drawing.Point(135, 15);
            this.lbl_id_vendedor.Name = "lbl_id_vendedor";
            this.lbl_id_vendedor.Size = new System.Drawing.Size(100, 23);
            this.lbl_id_vendedor.TabIndex = 0;
            this.lbl_id_vendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comisión del Vendedor (%):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Vendedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Vendedor:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.gridControlSucursal);
            this.groupBox2.Controls.Add(this.chk_todos);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "                                          Sucursal donde puede vender";
            // 
            // gridControlSucursal
            // 
            this.gridControlSucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSucursal.Location = new System.Drawing.Point(3, 16);
            this.gridControlSucursal.MainView = this.gridViewSucursal;
            this.gridControlSucursal.Name = "gridControlSucursal";
            this.gridControlSucursal.Size = new System.Drawing.Size(622, 223);
            this.gridControlSucursal.TabIndex = 1;
            this.gridControlSucursal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSucursal});
            // 
            // gridViewSucursal
            // 
            this.gridViewSucursal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdEmpresa,
            this.colIdSucursal,
            this.colcodigo,
            this.colSu_Descripcion,
            this.colSu_CodigoEstablecimiento,
            this.colSu_Ubicacion,
            this.colSu_Ruc,
            this.colSu_JefeSucursal,
            this.colSu_Telefonos,
            this.colSu_Direccion,
            this.colIdUsuario,
            this.colFecha_Transac,
            this.colIdUsuarioUltMod,
            this.colFecha_UltMod,
            this.colIdUsuarioUltAnu,
            this.colFecha_UltAnu,
            this.colnom_pc,
            this.colip,
            this.colEstado,
            this.colChek});
            this.gridViewSucursal.GridControl = this.gridControlSucursal;
            this.gridViewSucursal.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridViewSucursal.Name = "gridViewSucursal";
            this.gridViewSucursal.OptionsBehavior.Editable = false;
            this.gridViewSucursal.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSucursal.OptionsView.ShowGroupPanel = false;
            this.gridViewSucursal.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewSucursal_RowClick);
            this.gridViewSucursal.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewSucursal_RowCellStyle);
            this.gridViewSucursal.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewSucursal_FocusedRowChanged);
            this.gridViewSucursal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridViewSucursal_KeyUp);
            this.gridViewSucursal.DoubleClick += new System.EventHandler(this.gridViewSucursal_DoubleClick);
            // 
            // ColIdEmpresa
            // 
            this.ColIdEmpresa.Caption = "Empresa";
            this.ColIdEmpresa.FieldName = "IdEmpresa";
            this.ColIdEmpresa.Name = "ColIdEmpresa";
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.Caption = "Sucursal";
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            this.colIdSucursal.Visible = true;
            this.colIdSucursal.VisibleIndex = 1;
            this.colIdSucursal.Width = 144;
            // 
            // colcodigo
            // 
            this.colcodigo.Caption = "codigo";
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "Descripcion";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 2;
            this.colSu_Descripcion.Width = 294;
            // 
            // colSu_CodigoEstablecimiento
            // 
            this.colSu_CodigoEstablecimiento.Caption = "Establecimiento";
            this.colSu_CodigoEstablecimiento.FieldName = "Su_CodigoEstablecimiento";
            this.colSu_CodigoEstablecimiento.Name = "colSu_CodigoEstablecimiento";
            // 
            // colSu_Ubicacion
            // 
            this.colSu_Ubicacion.Caption = "Ubicacion";
            this.colSu_Ubicacion.FieldName = "Su_Ubicacion";
            this.colSu_Ubicacion.Name = "colSu_Ubicacion";
            // 
            // colSu_Ruc
            // 
            this.colSu_Ruc.Caption = "Ruc";
            this.colSu_Ruc.FieldName = "Su_Ruc";
            this.colSu_Ruc.Name = "colSu_Ruc";
            // 
            // colSu_JefeSucursal
            // 
            this.colSu_JefeSucursal.Caption = "Jefe";
            this.colSu_JefeSucursal.FieldName = "Su_JefeSucursal";
            this.colSu_JefeSucursal.Name = "colSu_JefeSucursal";
            // 
            // colSu_Telefonos
            // 
            this.colSu_Telefonos.Caption = "Telefono";
            this.colSu_Telefonos.FieldName = "Su_Telefonos";
            this.colSu_Telefonos.Name = "colSu_Telefonos";
            // 
            // colSu_Direccion
            // 
            this.colSu_Direccion.Caption = "Direccion";
            this.colSu_Direccion.FieldName = "Su_Direccion";
            this.colSu_Direccion.Name = "colSu_Direccion";
            this.colSu_Direccion.Visible = true;
            this.colSu_Direccion.VisibleIndex = 3;
            this.colSu_Direccion.Width = 294;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.Caption = "IdUsuario";
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colFecha_Transac
            // 
            this.colFecha_Transac.Caption = "Fecha_Transac";
            this.colFecha_Transac.FieldName = "Fecha_Transac";
            this.colFecha_Transac.Name = "colFecha_Transac";
            // 
            // colIdUsuarioUltMod
            // 
            this.colIdUsuarioUltMod.Caption = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.FieldName = "IdUsuarioUltMod";
            this.colIdUsuarioUltMod.Name = "colIdUsuarioUltMod";
            // 
            // colFecha_UltMod
            // 
            this.colFecha_UltMod.Caption = "Fecha_UltMod";
            this.colFecha_UltMod.FieldName = "Fecha_UltMod";
            this.colFecha_UltMod.Name = "colFecha_UltMod";
            // 
            // colIdUsuarioUltAnu
            // 
            this.colIdUsuarioUltAnu.Caption = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.FieldName = "IdUsuarioUltAnu";
            this.colIdUsuarioUltAnu.Name = "colIdUsuarioUltAnu";
            // 
            // colFecha_UltAnu
            // 
            this.colFecha_UltAnu.Caption = "Fecha_UltAnu";
            this.colFecha_UltAnu.FieldName = "Fecha_UltAnu";
            this.colFecha_UltAnu.Name = "colFecha_UltAnu";
            // 
            // colnom_pc
            // 
            this.colnom_pc.Caption = "nom_pc";
            this.colnom_pc.FieldName = "nom_pc";
            this.colnom_pc.Name = "colnom_pc";
            // 
            // colip
            // 
            this.colip.Caption = "ip";
            this.colip.FieldName = "ip";
            this.colip.Name = "colip";
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 4;
            this.colEstado.Width = 419;
            // 
            // colChek
            // 
            this.colChek.Caption = "*";
            this.colChek.FieldName = "Chek";
            this.colChek.Name = "colChek";
            this.colChek.OptionsColumn.AllowEdit = false;
            this.colChek.Visible = true;
            this.colChek.VisibleIndex = 0;
            this.colChek.Width = 23;
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(50, -1);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(56, 17);
            this.chk_todos.TabIndex = 0;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            this.chk_todos.CheckedChanged += new System.EventHandler(this.chk_todos_CheckedChanged);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpLote = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(628, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 29);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(628, 369);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.TabIndex = 2;
            // 
            // frmFa_Vendedor_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 398);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ucGe_Menu);
            this.MaximizeBox = false;
            this.Name = "frmFa_Vendedor_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Vendedores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFa_Vendedor_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmFA_Vendedor_Mant_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.TextBox txt_comision;
        private System.Windows.Forms.TextBox txt_vendedor;
        private System.Windows.Forms.Label lbl_id_vendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox txt_ci_ruc;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraGrid.GridControl gridControlSucursal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_CodigoEstablecimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Ubicacion;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Ruc;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_JefeSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Telefonos;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Direccion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Transac;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltMod;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuarioUltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_UltAnu;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_pc;
        private DevExpress.XtraGrid.Columns.GridColumn colip;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colChek;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private System.Windows.Forms.SplitContainer splitContainer1;

    }
}
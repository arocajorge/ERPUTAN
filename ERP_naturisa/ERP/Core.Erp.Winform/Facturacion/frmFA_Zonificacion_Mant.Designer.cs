namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_Zonificacion_Mant
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
            this.chk_Estado = new System.Windows.Forms.CheckBox();
            this.txt_posicion = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ubicacion = new System.Windows.Forms.ComboBox();
            this.txt_idUbicacion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treelist_Ubicacion = new DevExpress.XtraTreeList.TreeList();
            this.Ubicacion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.IdUbicacion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Nivel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Pos = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tbubicacionInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_nivel = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_title_IdUbicacion = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_posicion)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treelist_Ubicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbubicacionInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nivel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_Estado);
            this.groupBox1.Controls.Add(this.txt_posicion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_ubicacion);
            this.groupBox1.Controls.Add(this.txt_idUbicacion);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.txt_nivel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_title_IdUbicacion);
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 362);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // chk_Estado
            // 
            this.chk_Estado.AutoSize = true;
            this.chk_Estado.Checked = true;
            this.chk_Estado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Estado.Location = new System.Drawing.Point(89, 322);
            this.chk_Estado.Name = "chk_Estado";
            this.chk_Estado.Size = new System.Drawing.Size(59, 17);
            this.chk_Estado.TabIndex = 6;
            this.chk_Estado.Text = "Estado";
            this.chk_Estado.UseVisualStyleBackColor = true;
            // 
            // txt_posicion
            // 
            this.txt_posicion.Location = new System.Drawing.Point(88, 296);
            this.txt_posicion.Name = "txt_posicion";
            this.txt_posicion.Size = new System.Drawing.Size(60, 20);
            this.txt_posicion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Posición:";
            // 
            // cmb_ubicacion
            // 
            this.cmb_ubicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ubicacion.FormattingEnabled = true;
            this.cmb_ubicacion.Location = new System.Drawing.Point(374, 266);
            this.cmb_ubicacion.Name = "cmb_ubicacion";
            this.cmb_ubicacion.Size = new System.Drawing.Size(150, 21);
            this.cmb_ubicacion.TabIndex = 3;
            this.cmb_ubicacion.Visible = false;
            //this.cmb_ubicacion.SelectedValueChanged += new System.EventHandler(this.cmb_ubicacion_SelectedValueChanged);
            // 
            // txt_idUbicacion
            // 
            this.txt_idUbicacion.BackColor = System.Drawing.Color.White;
            this.txt_idUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_idUbicacion.Location = new System.Drawing.Point(95, 16);
            this.txt_idUbicacion.Name = "txt_idUbicacion";
            this.txt_idUbicacion.Size = new System.Drawing.Size(172, 22);
            this.txt_idUbicacion.TabIndex = 1;
            this.txt_idUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treelist_Ubicacion);
            this.groupBox2.Location = new System.Drawing.Point(15, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 219);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MenuPadre";
            // 
            // treelist_Ubicacion
            // 
            this.treelist_Ubicacion.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.treelist_Ubicacion.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treelist_Ubicacion.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.Ubicacion,
            this.IdUbicacion,
            this.Nivel,
            this.Pos});
            this.treelist_Ubicacion.DataSource = this.tbubicacionInfoBindingSource;
            this.treelist_Ubicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treelist_Ubicacion.KeyFieldName = "IdUbicacion";
            this.treelist_Ubicacion.Location = new System.Drawing.Point(3, 16);
            this.treelist_Ubicacion.Name = "treelist_Ubicacion";
            this.treelist_Ubicacion.OptionsPrint.PrintAllNodes = true;
            this.treelist_Ubicacion.OptionsPrint.UsePrintStyles = true;
            this.treelist_Ubicacion.OptionsSelection.MultiSelect = true;
            this.treelist_Ubicacion.OptionsView.ShowIndentAsRowStyle = true;
            this.treelist_Ubicacion.ParentFieldName = "IdUbicacion_Padre";
            this.treelist_Ubicacion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.treelist_Ubicacion.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow;
            this.treelist_Ubicacion.Size = new System.Drawing.Size(526, 200);
            this.treelist_Ubicacion.TabIndex = 26;
            
            
            // 
            // Ubicacion
            // 
            this.Ubicacion.Caption = "Ubicación";
            this.Ubicacion.FieldName = "ub_descripcion";
            this.Ubicacion.MinWidth = 32;
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.OptionsColumn.AllowEdit = false;
            this.Ubicacion.OptionsColumn.ReadOnly = true;
            this.Ubicacion.Visible = true;
            this.Ubicacion.VisibleIndex = 0;
            this.Ubicacion.Width = 278;
            // 
            // IdUbicacion
            // 
            this.IdUbicacion.Caption = "IdUbicacion";
            this.IdUbicacion.FieldName = "IdUbicacion";
            this.IdUbicacion.Name = "IdUbicacion";
            this.IdUbicacion.OptionsColumn.AllowEdit = false;
            // 
            // Nivel
            // 
            this.Nivel.Caption = "Nivel";
            this.Nivel.FieldName = "ub_nivel";
            this.Nivel.Name = "Nivel";
            this.Nivel.OptionsColumn.AllowEdit = false;
            // 
            // Pos
            // 
            this.Pos.Caption = "Pos";
            this.Pos.FieldName = "ub_posicion";
            this.Pos.Name = "Pos";
            this.Pos.OptionsColumn.AllowEdit = false;
            // 
            // tbubicacionInfoBindingSource
            // 
            //this.tbubicacionInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_ubicacion_Info);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AllowGrayed = true;
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(88, 267);
            this.txt_descripcion.MaxLength = 100;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(280, 23);
            this.txt_descripcion.TabIndex = 2;
            // 
            // txt_nivel
            // 
            this.txt_nivel.Location = new System.Drawing.Point(260, 296);
            this.txt_nivel.Name = "txt_nivel";
            this.txt_nivel.Size = new System.Drawing.Size(60, 20);
            this.txt_nivel.TabIndex = 5;
            this.txt_nivel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nivel:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Descripción:";
            // 
            // lbl_title_IdUbicacion
            // 
            this.lbl_title_IdUbicacion.AutoSize = true;
            this.lbl_title_IdUbicacion.Location = new System.Drawing.Point(19, 21);
            this.lbl_title_IdUbicacion.Name = "lbl_title_IdUbicacion";
            this.lbl_title_IdUbicacion.Size = new System.Drawing.Size(70, 13);
            this.lbl_title_IdUbicacion.TabIndex = 30;
            this.lbl_title_IdUbicacion.Text = "Id Ubicación:";
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(582, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            // 
            // frmFa_Zonificacion_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 387);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmFa_Zonificacion_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Ubicación";
            //this.Load += new System.EventHandler(this.frmFA_Zonificacion_Mant_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_posicion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treelist_Ubicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbubicacionInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nivel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_ubicacion;
        private System.Windows.Forms.Label txt_idUbicacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraTreeList.TreeList treelist_Ubicacion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Ubicacion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn IdUbicacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.NumericUpDown txt_nivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_title_IdUbicacion;
        private System.Windows.Forms.NumericUpDown txt_posicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_Estado;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Nivel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Pos;
        private System.Windows.Forms.BindingSource tbubicacionInfoBindingSource;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;

    }
}
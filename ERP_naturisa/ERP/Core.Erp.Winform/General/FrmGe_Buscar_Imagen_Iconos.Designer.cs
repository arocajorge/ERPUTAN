namespace Core.Erp.Winform.General
{
    partial class FrmGe_Buscar_Imagen_Iconos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGe_Buscar_Imagen_Iconos));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit_Imagen = new DevExpress.XtraEditors.PictureEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl_Imagen = new DevExpress.XtraGrid.GridControl();
            this.gridView_Iconos_vzen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Imagen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_borrar_local = new System.Windows.Forms.Button();
            this.btn_import_local = new System.Windows.Forms.Button();
            this.opt_img_sys_vzen = new System.Windows.Forms.RadioButton();
            this.opt_Img_local = new System.Windows.Forms.RadioButton();
            this.openFileDialog_buscar_imag = new System.Windows.Forms.OpenFileDialog();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_salir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Imagen.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Iconos_vzen)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(566, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureEdit_Imagen);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 398);
            this.panel1.TabIndex = 45;
            // 
            // pictureEdit_Imagen
            // 
            this.pictureEdit_Imagen.Location = new System.Drawing.Point(231, 13);
            this.pictureEdit_Imagen.Name = "pictureEdit_Imagen";
            this.pictureEdit_Imagen.Size = new System.Drawing.Size(323, 340);
            this.pictureEdit_Imagen.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btn_borrar_local);
            this.groupBox1.Controls.Add(this.btn_import_local);
            this.groupBox1.Controls.Add(this.opt_img_sys_vzen);
            this.groupBox1.Controls.Add(this.opt_Img_local);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contexto del Recurso";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl_Imagen);
            this.panel2.Location = new System.Drawing.Point(1, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 209);
            this.panel2.TabIndex = 7;
            // 
            // gridControl_Imagen
            // 
            this.gridControl_Imagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Imagen.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Imagen.MainView = this.gridView_Iconos_vzen;
            this.gridControl_Imagen.Name = "gridControl_Imagen";
            this.gridControl_Imagen.Size = new System.Drawing.Size(200, 209);
            this.gridControl_Imagen.TabIndex = 6;
            this.gridControl_Imagen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Iconos_vzen});
            // 
            // gridView_Iconos_vzen
            // 
            this.gridView_Iconos_vzen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Imagen});
            this.gridView_Iconos_vzen.GridControl = this.gridControl_Imagen;
            this.gridView_Iconos_vzen.Name = "gridView_Iconos_vzen";
            this.gridView_Iconos_vzen.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Iconos_vzen.OptionsView.ShowGroupPanel = false;
            this.gridView_Iconos_vzen.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_Iconos_vzen_FocusedRowChanged);
            // 
            // Imagen
            // 
            this.Imagen.Caption = "Imagen/Icono";
            this.Imagen.FieldName = "IdIcono";
            this.Imagen.Name = "Imagen";
            this.Imagen.Visible = true;
            this.Imagen.VisibleIndex = 0;
            // 
            // btn_borrar_local
            // 
            this.btn_borrar_local.Location = new System.Drawing.Point(92, 65);
            this.btn_borrar_local.Name = "btn_borrar_local";
            this.btn_borrar_local.Size = new System.Drawing.Size(80, 29);
            this.btn_borrar_local.TabIndex = 3;
            this.btn_borrar_local.Text = "Borrar";
            this.btn_borrar_local.UseVisualStyleBackColor = true;
            this.btn_borrar_local.Click += new System.EventHandler(this.btn_borrar_local_Click);
            // 
            // btn_import_local
            // 
            this.btn_import_local.Location = new System.Drawing.Point(6, 65);
            this.btn_import_local.Name = "btn_import_local";
            this.btn_import_local.Size = new System.Drawing.Size(80, 29);
            this.btn_import_local.TabIndex = 2;
            this.btn_import_local.Text = "Importar";
            this.btn_import_local.UseVisualStyleBackColor = true;
            this.btn_import_local.Click += new System.EventHandler(this.btn_import_local_Click);
            // 
            // opt_img_sys_vzen
            // 
            this.opt_img_sys_vzen.AutoSize = true;
            this.opt_img_sys_vzen.Checked = true;
            this.opt_img_sys_vzen.Location = new System.Drawing.Point(6, 117);
            this.opt_img_sys_vzen.Name = "opt_img_sys_vzen";
            this.opt_img_sys_vzen.Size = new System.Drawing.Size(142, 17);
            this.opt_img_sys_vzen.TabIndex = 1;
            this.opt_img_sys_vzen.TabStop = true;
            this.opt_img_sys_vzen.Text = "Imagen del sistema Vzen";
            this.opt_img_sys_vzen.UseVisualStyleBackColor = true;
            // 
            // opt_Img_local
            // 
            this.opt_Img_local.AutoSize = true;
            this.opt_Img_local.Location = new System.Drawing.Point(6, 31);
            this.opt_Img_local.Name = "opt_Img_local";
            this.opt_Img_local.Size = new System.Drawing.Size(161, 17);
            this.opt_Img_local.TabIndex = 0;
            this.opt_Img_local.TabStop = true;
            this.opt_Img_local.Text = "Imagen de un directorio local";
            this.opt_Img_local.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(68, 22);
            this.btn_guardar.Text = "Aceptar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(109, 22);
            this.toolStripLabel1.Text = "                                  ";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(49, 22);
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(89, 22);
            this.toolStripLabel2.Text = "V29042014:1008";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.toolStripSeparator5,
            this.toolStripLabel1,
            this.toolStripSeparator6,
            this.btn_salir,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(566, 25);
            this.toolStrip1.TabIndex = 44;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FrmGe_Buscar_Imagen_Iconos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmGe_Buscar_Imagen_Iconos";
            this.Text = "Seleccionar Imagen";
            this.Load += new System.EventHandler(this.FrmGe_Buscar_Imagen_Iconos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit_Imagen.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Iconos_vzen)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_borrar_local;
        private System.Windows.Forms.Button btn_import_local;
        private System.Windows.Forms.RadioButton opt_img_sys_vzen;
        private System.Windows.Forms.RadioButton opt_Img_local;
        private DevExpress.XtraEditors.PictureEdit pictureEdit_Imagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog_buscar_imag;
        private DevExpress.XtraGrid.GridControl gridControl_Imagen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Iconos_vzen;
        private DevExpress.XtraGrid.Columns.GridColumn Imagen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btn_salir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip toolStrip1;

    }
}
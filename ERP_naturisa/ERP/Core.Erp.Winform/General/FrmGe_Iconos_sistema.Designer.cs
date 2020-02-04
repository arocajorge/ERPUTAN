namespace Core.Erp.Winform.General
{
    partial class FrmGe_Iconos_sistema
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnsalir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl_iconos = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.IdIcono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Icono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Extencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Length = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.openFileDialog_buscar_imag = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_iconos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargar,
            this.toolStripLabel1,
            this.btnsalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(895, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCargar
            // 
            this.btnCargar.Image = global::Core.Erp.Winform.Properties.Resources.Refres;
            this.btnCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(194, 22);
            this.btnCargar.Text = "Cargar Imagenes desde Carpeta";
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(79, 22);
            this.toolStripLabel1.Text = "                        ";
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::Core.Erp.Winform.Properties.Resources.salir;
            this.btnsalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(49, 22);
            this.btnsalir.Text = "Salir";
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(895, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl_iconos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 359);
            this.panel1.TabIndex = 3;
            // 
            // gridControl_iconos
            // 
            this.gridControl_iconos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_iconos.Location = new System.Drawing.Point(0, 0);
            this.gridControl_iconos.MainView = this.cardView1;
            this.gridControl_iconos.Name = "gridControl_iconos";
            this.gridControl_iconos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1});
            this.gridControl_iconos.Size = new System.Drawing.Size(895, 359);
            this.gridControl_iconos.TabIndex = 0;
            this.gridControl_iconos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdIcono,
            this.Icono,
            this.descripcion,
            this.Extencion,
            this.FullName,
            this.Length});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl_iconos;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.FieldAutoHeight = true;
            this.cardView1.OptionsFind.AlwaysVisible = true;
            this.cardView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IdIcono, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // IdIcono
            // 
            this.IdIcono.Caption = "IdIcono";
            this.IdIcono.FieldName = "IdIcono";
            this.IdIcono.Name = "IdIcono";
            this.IdIcono.Visible = true;
            this.IdIcono.VisibleIndex = 0;
            this.IdIcono.Width = 117;
            // 
            // Icono
            // 
            this.Icono.Caption = "Imagen";
            this.Icono.ColumnEdit = this.repositoryItemPictureEdit1;
            this.Icono.FieldName = "Icono_image";
            this.Icono.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.Icono.Name = "Icono";
            this.Icono.Visible = true;
            this.Icono.VisibleIndex = 1;
            this.Icono.Width = 158;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // descripcion
            // 
            this.descripcion.Caption = "descripcion";
            this.descripcion.FieldName = "descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Visible = true;
            this.descripcion.VisibleIndex = 2;
            this.descripcion.Width = 78;
            // 
            // Extencion
            // 
            this.Extencion.Caption = "Extencion";
            this.Extencion.FieldName = "Extencion";
            this.Extencion.Name = "Extencion";
            this.Extencion.Visible = true;
            this.Extencion.VisibleIndex = 3;
            this.Extencion.Width = 142;
            // 
            // FullName
            // 
            this.FullName.Caption = "FullName";
            this.FullName.FieldName = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.Visible = true;
            this.FullName.VisibleIndex = 4;
            this.FullName.Width = 142;
            // 
            // Length
            // 
            this.Length.Caption = "Length";
            this.Length.FieldName = "Length";
            this.Length.Name = "Length";
            this.Length.Visible = true;
            this.Length.VisibleIndex = 5;
            this.Length.Width = 161;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // openFileDialog_buscar_imag
            // 
            this.openFileDialog_buscar_imag.FileName = "openFileDialog1";
            // 
            // FrmGe_Iconos_sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmGe_Iconos_sistema";
            this.Text = "Administrador de Iconos e Imagenes";
            this.Load += new System.EventHandler(this.FrmGe_Iconos_sistema_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_iconos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnsalir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl_iconos;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_buscar_imag;
        private System.Windows.Forms.ToolStripButton btnCargar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdIcono;
        private DevExpress.XtraGrid.Columns.GridColumn Icono;
        private DevExpress.XtraGrid.Columns.GridColumn descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Extencion;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private DevExpress.XtraGrid.Columns.GridColumn Length;
    }
}
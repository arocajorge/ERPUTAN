namespace Core.Erp.Winform.General
{
    partial class FrmGe_LogError_visor
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridControl_data = new DevExpress.XtraGrid.GridControl();
            this.gridView_data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_Trans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Clase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pantalla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Asamble = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.richTextBox_detalle = new System.Windows.Forms.RichTextBox();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_data)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(864, 22);
            this.statusStrip1.TabIndex = 46;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 375);
            this.panel1.TabIndex = 47;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridControl_data);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox_detalle);
            this.splitContainer1.Size = new System.Drawing.Size(864, 375);
            this.splitContainer1.SplitterDistance = 597;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridControl_data
            // 
            this.gridControl_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_data.Location = new System.Drawing.Point(0, 0);
            this.gridControl_data.MainView = this.gridView_data;
            this.gridControl_data.Name = "gridControl_data";
            this.gridControl_data.Size = new System.Drawing.Size(597, 375);
            this.gridControl_data.TabIndex = 0;
            this.gridControl_data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_data});
            // 
            // gridView_data
            // 
            this.gridView_data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Fecha_Trans,
            this.Detalle,
            this.Tipo,
            this.Clase,
            this.Pantalla,
            this.Asamble,
            this.Usuario,
            this.Ip,
            this.PC});
            this.gridView_data.GridControl = this.gridControl_data;
            this.gridView_data.Name = "gridView_data";
            this.gridView_data.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_data_RowClick);
            this.gridView_data.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_data_FocusedRowChanged);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 20;
            // 
            // Fecha_Trans
            // 
            this.Fecha_Trans.Caption = "Fecha_Trans";
            this.Fecha_Trans.FieldName = "Fecha_Trans";
            this.Fecha_Trans.Name = "Fecha_Trans";
            this.Fecha_Trans.Visible = true;
            this.Fecha_Trans.VisibleIndex = 1;
            this.Fecha_Trans.Width = 37;
            // 
            // Detalle
            // 
            this.Detalle.Caption = "Detalle";
            this.Detalle.FieldName = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.Visible = true;
            this.Detalle.VisibleIndex = 2;
            this.Detalle.Width = 115;
            // 
            // Tipo
            // 
            this.Tipo.Caption = "Tipo";
            this.Tipo.FieldName = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Visible = true;
            this.Tipo.VisibleIndex = 3;
            this.Tipo.Width = 36;
            // 
            // Clase
            // 
            this.Clase.Caption = "Clase";
            this.Clase.FieldName = "Clase";
            this.Clase.Name = "Clase";
            this.Clase.Visible = true;
            this.Clase.VisibleIndex = 4;
            this.Clase.Width = 34;
            // 
            // Pantalla
            // 
            this.Pantalla.Caption = "Pantalla";
            this.Pantalla.FieldName = "Pantalla";
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Visible = true;
            this.Pantalla.VisibleIndex = 5;
            this.Pantalla.Width = 28;
            // 
            // Asamble
            // 
            this.Asamble.Caption = "Asamble";
            this.Asamble.FieldName = "Asamble";
            this.Asamble.Name = "Asamble";
            this.Asamble.Visible = true;
            this.Asamble.VisibleIndex = 6;
            this.Asamble.Width = 33;
            // 
            // Usuario
            // 
            this.Usuario.Caption = "Usuario";
            this.Usuario.FieldName = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.Visible = true;
            this.Usuario.VisibleIndex = 7;
            this.Usuario.Width = 41;
            // 
            // Ip
            // 
            this.Ip.Caption = "Ip";
            this.Ip.FieldName = "Ip";
            this.Ip.Name = "Ip";
            this.Ip.Visible = true;
            this.Ip.VisibleIndex = 8;
            this.Ip.Width = 46;
            // 
            // PC
            // 
            this.PC.Caption = "PC";
            this.PC.FieldName = "PC";
            this.PC.Name = "PC";
            this.PC.Visible = true;
            this.PC.VisibleIndex = 9;
            this.PC.Width = 21;
            // 
            // richTextBox_detalle
            // 
            this.richTextBox_detalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_detalle.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_detalle.Name = "richTextBox_detalle";
            this.richTextBox_detalle.Size = new System.Drawing.Size(263, 375);
            this.richTextBox_detalle.TabIndex = 0;
            this.richTextBox_detalle.Text = "";
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
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(864, 29);
            this.ucGe_Menu.TabIndex = 48;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 375);
            this.panel2.TabIndex = 49;
            // 
            // FrmGe_LogError_visor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 426);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmGe_LogError_visor";
            this.Text = "Visor Log Errores del Sistema";
            this.Load += new System.EventHandler(this.FrmGe_LogError_visor_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_data)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl_data;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_data;
        private System.Windows.Forms.RichTextBox richTextBox_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_Trans;
        private DevExpress.XtraGrid.Columns.GridColumn Detalle;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn Clase;
        private DevExpress.XtraGrid.Columns.GridColumn Pantalla;
        private DevExpress.XtraGrid.Columns.GridColumn Asamble;
        private DevExpress.XtraGrid.Columns.GridColumn Usuario;
        private DevExpress.XtraGrid.Columns.GridColumn Ip;
        private DevExpress.XtraGrid.Columns.GridColumn PC;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panel2;
    }
}
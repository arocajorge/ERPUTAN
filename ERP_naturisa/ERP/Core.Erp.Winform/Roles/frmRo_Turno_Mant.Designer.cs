namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Turno_Mant
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
            this.roturnoxtbdiaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_descTurno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.gridControlDetalleTurno = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetalleTurno = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.chek_jornada_desfasada = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.roturnoxtbdiaInfoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // roturnoxtbdiaInfoBindingSource
            // 
            this.roturnoxtbdiaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_turno_x_tb_dia_Info);
            // 
            // txt_descTurno
            // 
            this.txt_descTurno.Location = new System.Drawing.Point(95, 64);
            this.txt_descTurno.Multiline = true;
            this.txt_descTurno.Name = "txt_descTurno";
            this.txt_descTurno.Size = new System.Drawing.Size(272, 20);
            this.txt_descTurno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripcion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chek_jornada_desfasada);
            this.groupBox1.Controls.Add(this.checkEstado);
            this.groupBox1.Controls.Add(this.txtDia);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.gridControlDetalleTurno);
            this.groupBox1.Controls.Add(this.txt_descTurno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 341);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(311, 41);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(56, 17);
            this.checkEstado.TabIndex = 15;
            this.checkEstado.Text = "Activo";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // txtDia
            // 
            this.txtDia.Enabled = false;
            this.txtDia.Location = new System.Drawing.Point(97, 39);
            this.txtDia.MaxLength = 5;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(65, 20);
            this.txtDia.TabIndex = 0;
            // 
            // lblEstado
            // 
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(3, 16);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(411, 24);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "***Anulado***";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gridControlDetalleTurno
            // 
            this.gridControlDetalleTurno.DataSource = this.roturnoxtbdiaInfoBindingSource;
            this.gridControlDetalleTurno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlDetalleTurno.Location = new System.Drawing.Point(3, 90);
            this.gridControlDetalleTurno.MainView = this.gridViewDetalleTurno;
            this.gridControlDetalleTurno.Name = "gridControlDetalleTurno";
            this.gridControlDetalleTurno.Size = new System.Drawing.Size(411, 248);
            this.gridControlDetalleTurno.TabIndex = 2;
            this.gridControlDetalleTurno.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalleTurno});
            // 
            // gridViewDetalleTurno
            // 
            this.gridViewDetalleTurno.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDia,
            this.colActivo});
            this.gridViewDetalleTurno.GridControl = this.gridControlDetalleTurno;
            this.gridViewDetalleTurno.Name = "gridViewDetalleTurno";
            this.gridViewDetalleTurno.OptionsView.ShowGroupPanel = false;
            // 
            // colDia
            // 
            this.colDia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colDia.AppearanceHeader.Options.UseFont = true;
            this.colDia.Caption = "Día";
            this.colDia.FieldName = "Dia";
            this.colDia.Name = "colDia";
            this.colDia.OptionsColumn.AllowEdit = false;
            this.colDia.Visible = true;
            this.colDia.VisibleIndex = 0;
            this.colDia.Width = 135;
            // 
            // colActivo
            // 
            this.colActivo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.colActivo.AppearanceHeader.Options.UseFont = true;
            this.colActivo.AppearanceHeader.Options.UseTextOptions = true;
            this.colActivo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colActivo.Caption = "Activo";
            this.colActivo.FieldName = "Activo";
            this.colActivo.Name = "colActivo";
            this.colActivo.Visible = true;
            this.colActivo.VisibleIndex = 1;
            this.colActivo.Width = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turno:";
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
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(417, 29);
            this.ucGe_Menu.TabIndex = 5;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.Load += new System.EventHandler(this.ucGe_Menu_Load);
            // 
            // chek_jornada_desfasada
            // 
            this.chek_jornada_desfasada.AutoSize = true;
            this.chek_jornada_desfasada.Location = new System.Drawing.Point(168, 41);
            this.chek_jornada_desfasada.Name = "chek_jornada_desfasada";
            this.chek_jornada_desfasada.Size = new System.Drawing.Size(77, 17);
            this.chek_jornada_desfasada.TabIndex = 16;
            this.chek_jornada_desfasada.Text = "Desfasada";
            this.chek_jornada_desfasada.UseVisualStyleBackColor = true;
            // 
            // frmRo_Turno_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 376);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRo_Turno_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento - Turno ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRo_Turno_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmRo_Turno_Mant_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmRo_Turno_Mant_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.roturnoxtbdiaInfoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDetalleTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleTurno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_descTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource roturnoxtbdiaInfoBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlDetalleTurno;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalleTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colDia;
        private DevExpress.XtraGrid.Columns.GridColumn colActivo;
        private System.Windows.Forms.Label label2;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.CheckBox checkEstado;
        private System.Windows.Forms.CheckBox chek_jornada_desfasada;
    }
}
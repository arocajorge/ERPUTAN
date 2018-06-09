namespace Core.Erp.Winform.Compras
{
    partial class frmCom_Motivo_Orden_Compra_Mant
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
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucSeg_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.chkEstado = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblAnulado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 175);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(500, 26);
            this.ucGe_BarraEstado.TabIndex = 0;
            // 
            // ucSeg_Menu
            // 
            this.ucSeg_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucSeg_Menu.Enabled_bnRetImprimir = true;
            this.ucSeg_Menu.Enabled_bntAnular = true;
            this.ucSeg_Menu.Enabled_bntAprobar = true;
            this.ucSeg_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucSeg_Menu.Enabled_bntImprimir = true;
            this.ucSeg_Menu.Enabled_bntImprimir_Guia = true;
            this.ucSeg_Menu.Enabled_bntLimpiar = true;
            this.ucSeg_Menu.Enabled_bntSalir = true;
            this.ucSeg_Menu.Enabled_btnAceptar = true;
            this.ucSeg_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucSeg_Menu.Enabled_btnEstadosOC = true;
            this.ucSeg_Menu.Enabled_btnGuardar = true;
            this.ucSeg_Menu.Enabled_btnImpFrm = true;
            this.ucSeg_Menu.Enabled_btnImpRep = true;
            this.ucSeg_Menu.Enabled_btnImprimirSoporte = true;
            this.ucSeg_Menu.Enabled_btnproductos = true;
            this.ucSeg_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucSeg_Menu.Name = "ucSeg_Menu";
            this.ucSeg_Menu.Size = new System.Drawing.Size(500, 29);
            this.ucSeg_Menu.TabIndex = 0;
            this.ucSeg_Menu.Visible_bntAnular = true;
            this.ucSeg_Menu.Visible_bntAprobar = false;
            this.ucSeg_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucSeg_Menu.Visible_bntImprimir = false;
            this.ucSeg_Menu.Visible_bntImprimir_Guia = false;
            this.ucSeg_Menu.Visible_bntLimpiar = true;
            this.ucSeg_Menu.Visible_bntReImprimir = false;
            this.ucSeg_Menu.Visible_bntSalir = true;
            this.ucSeg_Menu.Visible_btnAceptar = false;
            this.ucSeg_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucSeg_Menu.Visible_btnEstadosOC = false;
            this.ucSeg_Menu.Visible_btnGuardar = true;
            this.ucSeg_Menu.Visible_btnImpFrm = false;
            this.ucSeg_Menu.Visible_btnImpRep = false;
            this.ucSeg_Menu.Visible_btnImprimirSoporte = false;
            this.ucSeg_Menu.Visible_btnproductos = false;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(90, 80);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(401, 20);
            this.txtdescripcion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(90, 54);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(90, 28);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 0;
            this.txtid.Text = "0";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // chkEstado
            // 
            this.chkEstado.Location = new System.Drawing.Point(20, 115);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Properties.Caption = "Activo";
            this.chkEstado.Size = new System.Drawing.Size(75, 19);
            this.chkEstado.TabIndex = 7;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblAnulado);
            this.panelControl1.Controls.Add(this.txtid);
            this.panelControl1.Controls.Add(this.chkEstado);
            this.panelControl1.Controls.Add(this.lblId);
            this.panelControl1.Controls.Add(this.txtdescripcion);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtcodigo);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(500, 146);
            this.panelControl1.TabIndex = 8;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(302, 26);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(136, 20);
            this.lblAnulado.TabIndex = 10;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // frmCom_Motivo_Orden_Compra_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 201);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucSeg_Menu);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Name = "frmCom_Motivo_Orden_Compra_Mant";
            this.Text = "Mantenimiento Motivo Orden Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCom_Motivo_Orden_Compra_Mant_FormClosing);
            this.Load += new System.EventHandler(this.frmCom_Motivo_Orden_Compra_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private Controles.UCGe_Menu_Superior_Mant ucSeg_Menu;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblId;
        private DevExpress.XtraEditors.CheckEdit chkEstado;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lblAnulado;
    }
}
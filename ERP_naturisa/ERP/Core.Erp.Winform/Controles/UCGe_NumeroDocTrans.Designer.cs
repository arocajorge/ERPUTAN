namespace Core.Erp.Winform.Controles
{
    partial class UCGe_NumeroDocTrans
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCGe_NumeroDocTrans));
            this.rbt_doc_Electronico = new System.Windows.Forms.RadioButton();
            this.rbt_pre_impresa = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txe_Serie = new DevExpress.XtraEditors.TextEdit();
            this.txtNumDoc = new DevExpress.XtraEditors.TextEdit();
            this.lblFactura = new System.Windows.Forms.Label();
            this.faSecuenciaDocumentoTalonarioInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txe_Serie.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faSecuenciaDocumentoTalonarioInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rbt_doc_Electronico
            // 
            this.rbt_doc_Electronico.AutoSize = true;
            this.rbt_doc_Electronico.Checked = true;
            this.rbt_doc_Electronico.Location = new System.Drawing.Point(189, 1);
            this.rbt_doc_Electronico.Name = "rbt_doc_Electronico";
            this.rbt_doc_Electronico.Size = new System.Drawing.Size(136, 17);
            this.rbt_doc_Electronico.TabIndex = 7;
            this.rbt_doc_Electronico.TabStop = true;
            this.rbt_doc_Electronico.Text = "Documento Electronico";
            this.rbt_doc_Electronico.UseVisualStyleBackColor = true;
            this.rbt_doc_Electronico.CheckedChanged += new System.EventHandler(this.rbt_doc_Electronico_CheckedChanged);
            // 
            // rbt_pre_impresa
            // 
            this.rbt_pre_impresa.AutoSize = true;
            this.rbt_pre_impresa.Location = new System.Drawing.Point(65, 1);
            this.rbt_pre_impresa.Name = "rbt_pre_impresa";
            this.rbt_pre_impresa.Size = new System.Drawing.Size(81, 17);
            this.rbt_pre_impresa.TabIndex = 6;
            this.rbt_pre_impresa.Text = "Pre-Impresa";
            this.rbt_pre_impresa.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageIndex = 0;
            this.btnBuscar.ImageList = this.imageList1;
            this.btnBuscar.Location = new System.Drawing.Point(333, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(42, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "buscar_file_32x32.png");
            // 
            // txe_Serie
            // 
            this.txe_Serie.Location = new System.Drawing.Point(65, 20);
            this.txe_Serie.Name = "txe_Serie";
            this.txe_Serie.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txe_Serie.Properties.Appearance.Options.UseFont = true;
            this.txe_Serie.Properties.Mask.EditMask = "\\d\\d\\d-\\d\\d\\d";
            this.txe_Serie.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txe_Serie.Size = new System.Drawing.Size(118, 22);
            this.txe_Serie.TabIndex = 4;
            this.txe_Serie.EditValueChanged += new System.EventHandler(this.txe_Serie_EditValueChanged);
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(189, 20);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDoc.Properties.Appearance.Options.UseFont = true;
            this.txtNumDoc.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumDoc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtNumDoc.Properties.Mask.EditMask = "\\d?{0,20}";
            this.txtNumDoc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumDoc.Size = new System.Drawing.Size(138, 22);
            this.txtNumDoc.TabIndex = 2;
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(3, 24);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(56, 13);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "# Factura:";
            // 
            // faSecuenciaDocumentoTalonarioInfoBindingSource
            // 
            this.faSecuenciaDocumentoTalonarioInfoBindingSource.DataSource = typeof(Core.Erp.Info.Facturacion.fa_Secuencia_Documento_Talonario_Info);
            // 
            // UCGe_NumeroDocTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbt_doc_Electronico);
            this.Controls.Add(this.rbt_pre_impresa);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.txe_Serie);
            this.Controls.Add(this.txtNumDoc);
            this.Name = "UCGe_NumeroDocTrans";
            this.Size = new System.Drawing.Size(378, 46);
            this.Load += new System.EventHandler(this.UCFA_NumeroDocTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txe_Serie.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faSecuenciaDocumentoTalonarioInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.TextEdit txtNumDoc;
        private System.Windows.Forms.BindingSource faSecuenciaDocumentoTalonarioInfoBindingSource;
        public DevExpress.XtraEditors.TextEdit txe_Serie;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Label lblFactura;
        public System.Windows.Forms.RadioButton rbt_doc_Electronico;
        public System.Windows.Forms.RadioButton rbt_pre_impresa;
    }
}

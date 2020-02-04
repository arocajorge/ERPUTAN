namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Motivo_Inven_borrar_Mant
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.chk_gen_movi_inv = new System.Windows.Forms.CheckBox();
            this.label_descri = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label_codigo = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.chk_estado);
            this.panelMain.Controls.Add(this.chk_gen_movi_inv);
            this.panelMain.Controls.Add(this.label_descri);
            this.panelMain.Controls.Add(this.txt_descripcion);
            this.panelMain.Controls.Add(this.txt_codigo);
            this.panelMain.Controls.Add(this.label_codigo);
            this.panelMain.Controls.Add(this.txt_id);
            this.panelMain.Controls.Add(this.labelId);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 29);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(546, 175);
            this.panelMain.TabIndex = 2;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(390, 131);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(56, 17);
            this.chk_estado.TabIndex = 7;
            this.chk_estado.Text = "Activo";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // chk_gen_movi_inv
            // 
            this.chk_gen_movi_inv.AutoSize = true;
            this.chk_gen_movi_inv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_gen_movi_inv.Location = new System.Drawing.Point(108, 107);
            this.chk_gen_movi_inv.Name = "chk_gen_movi_inv";
            this.chk_gen_movi_inv.Size = new System.Drawing.Size(183, 17);
            this.chk_gen_movi_inv.TabIndex = 6;
            this.chk_gen_movi_inv.Text = "Genera Movimiento de Inventario";
            this.chk_gen_movi_inv.UseVisualStyleBackColor = true;
            // 
            // label_descri
            // 
            this.label_descri.AutoSize = true;
            this.label_descri.Location = new System.Drawing.Point(36, 68);
            this.label_descri.Name = "label_descri";
            this.label_descri.Size = new System.Drawing.Size(66, 13);
            this.label_descri.TabIndex = 5;
            this.label_descri.Text = "Descripcion:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(108, 61);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(341, 20);
            this.txt_descripcion.TabIndex = 4;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(349, 30);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 3;
            // 
            // label_codigo
            // 
            this.label_codigo.AutoSize = true;
            this.label_codigo.Location = new System.Drawing.Point(309, 33);
            this.label_codigo.Name = "label_codigo";
            this.label_codigo.Size = new System.Drawing.Size(43, 13);
            this.label_codigo.TabIndex = 2;
            this.label_codigo.Text = "Codigo:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(108, 26);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 1;
            this.txt_id.Text = "0";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(36, 30);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id:";
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(546, 29);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 204);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(546, 26);
            this.ucGe_BarraEstado.TabIndex = 0;
            // 
            // FrmIn_Motivo_Inven_borrar_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 230);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Name = "FrmIn_Motivo_Inven_borrar_Mant";
            this.Text = "FrmIn_Motivo_Inven_borrar_Mant";
            this.Load += new System.EventHandler(this.FrmIn_Motivo_Inven_borrar_Mant_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.CheckBox chk_gen_movi_inv;
        private System.Windows.Forms.Label label_descri;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label_codigo;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.CheckBox chk_estado;
    }
}
namespace Core.Erp.Winform.Controles
{
    partial class UCGe_Tabla_Empresa
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgEmpresa = new System.Windows.Forms.DataGridView();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.IdEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoInter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.em_contador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.em_rucContador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.em_logo = new System.Windows.Forms.DataGridViewImageColumn();
            this.em_fondo = new System.Windows.Forms.DataGridViewImageColumn();
            this.em_fechaInicioContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(723, 492);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgEmpresa);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnconsultar);
            this.splitContainer2.Panel2.Controls.Add(this.btnmodificar);
            this.splitContainer2.Panel2.Controls.Add(this.btnnuevo);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(723, 463);
            this.splitContainer2.SplitterDistance = 575;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgEmpresa
            // 
            this.dgEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpresa,
            this.colCodigo,
            this.NomEmpresa,
            this.Gerente,
            this.Ruc,
            this.Telefono,
            this.Fax,
            this.Direccion,
            this.TelefonoInter,
            this.em_contador,
            this.em_rucContador,
            this.em_logo,
            this.em_fondo,
            this.em_fechaInicioContable,
            this.colEstado});
            this.dgEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEmpresa.Location = new System.Drawing.Point(0, 0);
            this.dgEmpresa.Name = "dgEmpresa";
            this.dgEmpresa.Size = new System.Drawing.Size(575, 463);
            this.dgEmpresa.TabIndex = 0;
            this.dgEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpresa_CellContentClick);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(16, 208);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(115, 42);
            this.btnconsultar.TabIndex = 11;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(17, 64);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(114, 40);
            this.btnmodificar.TabIndex = 9;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(17, 20);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(114, 38);
            this.btnnuevo.TabIndex = 8;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.DataPropertyName = "IdEmpresa";
            this.IdEmpresa.HeaderText = "IdEmpresa";
            this.IdEmpresa.Name = "IdEmpresa";
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "codigo";
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            // 
            // NomEmpresa
            // 
            this.NomEmpresa.DataPropertyName = "em_nombre";
            this.NomEmpresa.HeaderText = "Nombre";
            this.NomEmpresa.Name = "NomEmpresa";
            // 
            // Gerente
            // 
            this.Gerente.DataPropertyName = "em_gerente";
            this.Gerente.HeaderText = "Gerente";
            this.Gerente.Name = "Gerente";
            // 
            // Ruc
            // 
            this.Ruc.DataPropertyName = "em_ruc";
            this.Ruc.HeaderText = "Ruc";
            this.Ruc.Name = "Ruc";
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "em_telefonos";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Fax
            // 
            this.Fax.DataPropertyName = "em_fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "em_direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // TelefonoInter
            // 
            this.TelefonoInter.DataPropertyName = "em_tel_int";
            this.TelefonoInter.HeaderText = "Telf.Interna.";
            this.TelefonoInter.Name = "TelefonoInter";
            // 
            // em_contador
            // 
            this.em_contador.HeaderText = "contador";
            this.em_contador.Name = "em_contador";
            // 
            // em_rucContador
            // 
            this.em_rucContador.HeaderText = "RucContador";
            this.em_rucContador.Name = "em_rucContador";
            // 
            // em_logo
            // 
            this.em_logo.HeaderText = "logo";
            this.em_logo.Name = "em_logo";
            this.em_logo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.em_logo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // em_fondo
            // 
            this.em_fondo.HeaderText = "fondo";
            this.em_fondo.Name = "em_fondo";
            this.em_fondo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.em_fondo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // em_fechaInicioContable
            // 
            this.em_fechaInicioContable.HeaderText = "FechaInicioContable";
            this.em_fechaInicioContable.Name = "em_fechaInicioContable";
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "estado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // UCGe_Tabla_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCGe_Tabla_Empresa";
            this.Size = new System.Drawing.Size(723, 492);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DataGridView dgEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gerente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoInter;
        private System.Windows.Forms.DataGridViewTextBoxColumn em_contador;
        private System.Windows.Forms.DataGridViewTextBoxColumn em_rucContador;
        private System.Windows.Forms.DataGridViewImageColumn em_logo;
        private System.Windows.Forms.DataGridViewImageColumn em_fondo;
        private System.Windows.Forms.DataGridViewTextBoxColumn em_fechaInicioContable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}

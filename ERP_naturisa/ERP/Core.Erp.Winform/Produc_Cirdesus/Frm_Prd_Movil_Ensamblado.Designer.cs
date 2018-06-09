namespace Core.Erp.Winform.Produc_Cirdesus
{
    partial class Frm_Prd_Movil_Ensamblado
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCodBarra = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantAProducir = new System.Windows.Forms.TextBox();
            this.lblNoEnsamblar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelObra = new System.Windows.Forms.Panel();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.panelSucBod = new System.Windows.Forms.Panel();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnsamblado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridLkUOrdenTaller = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenTaller = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadPieza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPfecha = new System.Windows.Forms.DateTimePicker();
            this.gridLkUGrupoTrabajo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGrupoTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSu_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridCtrlEnsamblado = new DevExpress.XtraGrid.GridControl();
            this.gridVwEnsamblado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_codigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLkUOrdenTaller.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLkUGrupoTrabajo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlEnsamblado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwEnsamblado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(20, 14);
            this.tabControl1.Location = new System.Drawing.Point(0, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(224, 254);
            this.tabControl1.TabIndex = 121;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 18);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(216, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DATOS";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCodBarra);
            this.groupBox4.Controls.Add(this.txtProducto);
            this.groupBox4.Controls.Add(this.txtCantAProducir);
            this.groupBox4.Controls.Add(this.lblNoEnsamblar);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 62);
            this.groupBox4.TabIndex = 125;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PRODUCTO A ENSAMBLAR:";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.txtCodBarra.Location = new System.Drawing.Point(32, 34);
            this.txtCodBarra.MaximumSize = new System.Drawing.Size(170, 15);
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.ReadOnly = true;
            this.txtCodBarra.Size = new System.Drawing.Size(170, 17);
            this.txtCodBarra.TabIndex = 115;
            this.txtCodBarra.Text = "POR GENERAR";
            this.txtCodBarra.TextChanged += new System.EventHandler(this.txtCodBarra_TextChanged);
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.txtProducto.Location = new System.Drawing.Point(32, 14);
            this.txtProducto.MaximumSize = new System.Drawing.Size(170, 15);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(170, 17);
            this.txtProducto.TabIndex = 115;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // txtCantAProducir
            // 
            this.txtCantAProducir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCantAProducir.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.txtCantAProducir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCantAProducir.Location = new System.Drawing.Point(32, 52);
            this.txtCantAProducir.MaximumSize = new System.Drawing.Size(160, 15);
            this.txtCantAProducir.Name = "txtCantAProducir";
            this.txtCantAProducir.ReadOnly = true;
            this.txtCantAProducir.Size = new System.Drawing.Size(80, 17);
            this.txtCantAProducir.TabIndex = 114;
            this.txtCantAProducir.TextChanged += new System.EventHandler(this.txtCantAProducir_TextChanged);
            // 
            // lblNoEnsamblar
            // 
            this.lblNoEnsamblar.AutoSize = true;
            this.lblNoEnsamblar.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoEnsamblar.ForeColor = System.Drawing.Color.Red;
            this.lblNoEnsamblar.Location = new System.Drawing.Point(128, 56);
            this.lblNoEnsamblar.Name = "lblNoEnsamblar";
            this.lblNoEnsamblar.Size = new System.Drawing.Size(53, 9);
            this.lblNoEnsamblar.TabIndex = 112;
            this.lblNoEnsamblar.Text = "No Disp.";
            this.lblNoEnsamblar.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label7.Location = new System.Drawing.Point(4, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 12);
            this.label7.TabIndex = 112;
            this.label7.Text = "CB:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label5.Location = new System.Drawing.Point(4, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 12);
            this.label5.TabIndex = 112;
            this.label5.Text = "DISP:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label4.Location = new System.Drawing.Point(4, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 12);
            this.label4.TabIndex = 112;
            this.label4.Text = "PRD:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelObra);
            this.panel1.Controls.Add(this.lblAnulado);
            this.panel1.Controls.Add(this.panelSucBod);
            this.panel1.Controls.Add(this.txtObservacion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEnsamblado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.gridLkUOrdenTaller);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtPfecha);
            this.panel1.Controls.Add(this.gridLkUGrupoTrabajo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 164);
            this.panel1.TabIndex = 124;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelObra
            // 
            this.panelObra.Location = new System.Drawing.Point(4, 70);
            this.panelObra.Margin = new System.Windows.Forms.Padding(2);
            this.panelObra.Name = "panelObra";
            this.panelObra.Size = new System.Drawing.Size(204, 21);
            this.panelObra.TabIndex = 121;
            // 
            // lblAnulado
            // 
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(47, 134);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(95, 15);
            this.lblAnulado.TabIndex = 106;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAnulado.Visible = false;
            this.lblAnulado.Click += new System.EventHandler(this.lblAnulado_Click);
            // 
            // panelSucBod
            // 
            this.panelSucBod.Location = new System.Drawing.Point(4, 24);
            this.panelSucBod.Margin = new System.Windows.Forms.Padding(2);
            this.panelSucBod.Name = "panelSucBod";
            this.panelSucBod.Size = new System.Drawing.Size(204, 45);
            this.panelSucBod.TabIndex = 120;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.txtObservacion.Location = new System.Drawing.Point(32, 134);
            this.txtObservacion.MaxLength = 1000;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(170, 23);
            this.txtObservacion.TabIndex = 123;
            this.txtObservacion.TextChanged += new System.EventHandler(this.txtObservacion_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label8.Location = new System.Drawing.Point(4, 134);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 116;
            this.label8.Text = "OBS:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label2.Location = new System.Drawing.Point(4, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 12);
            this.label2.TabIndex = 116;
            this.label2.Text = "OT:";
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label1.Location = new System.Drawing.Point(89, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 116;
            this.label1.Text = "FEC:";
            // 
            // txtEnsamblado
            // 
            this.txtEnsamblado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEnsamblado.Enabled = false;
            this.txtEnsamblado.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.txtEnsamblado.Location = new System.Drawing.Point(32, 6);
            this.txtEnsamblado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnsamblado.MaximumSize = new System.Drawing.Size(30, 15);
            this.txtEnsamblado.Name = "txtEnsamblado";
            this.txtEnsamblado.ReadOnly = true;
            this.txtEnsamblado.Size = new System.Drawing.Size(30, 17);
            this.txtEnsamblado.TabIndex = 115;
            this.txtEnsamblado.Text = "0";
            this.txtEnsamblado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEnsamblado.TextChanged += new System.EventHandler(this.txtEnsamblado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label3.Location = new System.Drawing.Point(4, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 12);
            this.label3.TabIndex = 118;
            this.label3.Text = "GT:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gridLkUOrdenTaller
            // 
            this.gridLkUOrdenTaller.Location = new System.Drawing.Point(32, 92);
            this.gridLkUOrdenTaller.Margin = new System.Windows.Forms.Padding(2);
            this.gridLkUOrdenTaller.Name = "gridLkUOrdenTaller";
            this.gridLkUOrdenTaller.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.gridLkUOrdenTaller.Properties.Appearance.Options.UseFont = true;
            this.gridLkUOrdenTaller.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLkUOrdenTaller.Properties.DisplayMember = "Codigo";
            this.gridLkUOrdenTaller.Properties.ValueMember = "IdOrdenTaller";
            this.gridLkUOrdenTaller.Properties.View = this.gridLookUpEdit1View;
            this.gridLkUOrdenTaller.Size = new System.Drawing.Size(170, 18);
            this.gridLkUOrdenTaller.TabIndex = 117;
            this.gridLkUOrdenTaller.EditValueChanged += new System.EventHandler(this.gridLkUOrdenTaller_EditValueChanged);
            this.gridLkUOrdenTaller.Validating += new System.ComponentModel.CancelEventHandler(this.gridLkUOrdenTaller_Validating);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.GroupRow.Font = new System.Drawing.Font("Lucida Console", 6.75F);
            this.gridLookUpEdit1View.Appearance.GroupRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Lucida Console", 6.75F);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa1,
            this.colIdOrdenTaller,
            this.colCodigo,
            this.colNomProducto,
            this.colIdProducto1,
            this.colCantidadPieza});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            // 
            // colIdOrdenTaller
            // 
            this.colIdOrdenTaller.Caption = "#";
            this.colIdOrdenTaller.FieldName = "IdOrdenTaller";
            this.colIdOrdenTaller.Name = "colIdOrdenTaller";
            this.colIdOrdenTaller.Visible = true;
            this.colIdOrdenTaller.VisibleIndex = 0;
            this.colIdOrdenTaller.Width = 135;
            // 
            // colCodigo
            // 
            this.colCodigo.Caption = "OT";
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 1;
            this.colCodigo.Width = 353;
            // 
            // colNomProducto
            // 
            this.colNomProducto.Caption = "PROD";
            this.colNomProducto.FieldName = "NomProducto";
            this.colNomProducto.Name = "colNomProducto";
            this.colNomProducto.Visible = true;
            this.colNomProducto.VisibleIndex = 2;
            this.colNomProducto.Width = 514;
            // 
            // colIdProducto1
            // 
            this.colIdProducto1.FieldName = "IdProducto";
            this.colIdProducto1.Name = "colIdProducto1";
            this.colIdProducto1.Width = 273;
            // 
            // colCantidadPieza
            // 
            this.colCantidadPieza.Caption = "Unidades";
            this.colCantidadPieza.FieldName = "CantidadPieza";
            this.colCantidadPieza.Name = "colCantidadPieza";
            this.colCantidadPieza.Visible = true;
            this.colCantidadPieza.VisibleIndex = 3;
            this.colCantidadPieza.Width = 178;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.label6.Location = new System.Drawing.Point(4, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 114;
            this.label6.Text = "N#";
            // 
            // dtPfecha
            // 
            this.dtPfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.dtPfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPfecha.Location = new System.Drawing.Point(120, 6);
            this.dtPfecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtPfecha.MaximumSize = new System.Drawing.Size(80, 15);
            this.dtPfecha.Name = "dtPfecha";
            this.dtPfecha.Size = new System.Drawing.Size(80, 15);
            this.dtPfecha.TabIndex = 117;
            // 
            // gridLkUGrupoTrabajo
            // 
            this.gridLkUGrupoTrabajo.Location = new System.Drawing.Point(32, 112);
            this.gridLkUGrupoTrabajo.Margin = new System.Windows.Forms.Padding(2);
            this.gridLkUGrupoTrabajo.Name = "gridLkUGrupoTrabajo";
            this.gridLkUGrupoTrabajo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.gridLkUGrupoTrabajo.Properties.Appearance.Options.UseFont = true;
            this.gridLkUGrupoTrabajo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLkUGrupoTrabajo.Properties.DisplayMember = "Descripcion";
            this.gridLkUGrupoTrabajo.Properties.ValueMember = "IdGrupoTrabajo";
            this.gridLkUGrupoTrabajo.Properties.View = this.gridView1;
            this.gridLkUGrupoTrabajo.Size = new System.Drawing.Size(170, 18);
            this.gridLkUGrupoTrabajo.TabIndex = 119;
            this.gridLkUGrupoTrabajo.EditValueChanged += new System.EventHandler(this.gridLkUGrupoTrabajo_EditValueChanged);
            this.gridLkUGrupoTrabajo.Validating += new System.ComponentModel.CancelEventHandler(this.gridLkUGrupoTrabajo_Validating);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colIdGrupoTrabajo,
            this.colDescripcion,
            this.colpe_nombreCompleto,
            this.colSu_Descripcion,
            this.colIdSucursal});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdEmpresa";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Orden de Taller No.";
            this.gridColumn2.FieldName = "IdOrdenTaller";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 135;
            // 
            // colIdGrupoTrabajo
            // 
            this.colIdGrupoTrabajo.Caption = "#";
            this.colIdGrupoTrabajo.FieldName = "IdGrupoTrabajo";
            this.colIdGrupoTrabajo.Name = "colIdGrupoTrabajo";
            this.colIdGrupoTrabajo.Visible = true;
            this.colIdGrupoTrabajo.VisibleIndex = 1;
            this.colIdGrupoTrabajo.Width = 52;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "GT";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            this.colDescripcion.Width = 447;
            // 
            // colpe_nombreCompleto
            // 
            this.colpe_nombreCompleto.Caption = "LIDER";
            this.colpe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.colpe_nombreCompleto.Name = "colpe_nombreCompleto";
            this.colpe_nombreCompleto.Visible = true;
            this.colpe_nombreCompleto.VisibleIndex = 3;
            this.colpe_nombreCompleto.Width = 590;
            // 
            // colSu_Descripcion
            // 
            this.colSu_Descripcion.Caption = "SUC";
            this.colSu_Descripcion.FieldName = "Su_Descripcion";
            this.colSu_Descripcion.Name = "colSu_Descripcion";
            this.colSu_Descripcion.Visible = true;
            this.colSu_Descripcion.VisibleIndex = 0;
            this.colSu_Descripcion.Width = 91;
            // 
            // colIdSucursal
            // 
            this.colIdSucursal.Caption = "Sucursal";
            this.colIdSucursal.FieldName = "IdSucursal";
            this.colIdSucursal.Name = "colIdSucursal";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Controls.Add(this.gridCtrlEnsamblado);
            this.tabPage2.Location = new System.Drawing.Point(4, 18);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(216, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DETALLE";
            // 
            // gridCtrlEnsamblado
            // 
            this.gridCtrlEnsamblado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlEnsamblado.Location = new System.Drawing.Point(3, 3);
            this.gridCtrlEnsamblado.MainView = this.gridVwEnsamblado;
            this.gridCtrlEnsamblado.Name = "gridCtrlEnsamblado";
            this.gridCtrlEnsamblado.Size = new System.Drawing.Size(210, 226);
            this.gridCtrlEnsamblado.TabIndex = 1;
            this.gridCtrlEnsamblado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVwEnsamblado});
            // 
            // gridVwEnsamblado
            // 
            this.gridVwEnsamblado.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridVwEnsamblado.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridVwEnsamblado.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridVwEnsamblado.Appearance.Row.Options.UseFont = true;
            this.gridVwEnsamblado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colpr_codigo_barra,
            this.colpr_observacion,
            this.colProducto,
            this.colCantidad});
            this.gridVwEnsamblado.GridControl = this.gridCtrlEnsamblado;
            this.gridVwEnsamblado.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridVwEnsamblado.Name = "gridVwEnsamblado";
            this.gridVwEnsamblado.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridVwEnsamblado.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridVwEnsamblado.OptionsView.ShowGroupPanel = false;
            this.gridVwEnsamblado.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridVwEnsamblado.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridVwEnsamblado_CellValueChanged);
            this.gridVwEnsamblado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridVwEnsamblado_KeyDown);
            this.gridVwEnsamblado.RowCountChanged += new System.EventHandler(this.gridVwEnsamblado_RowCountChanged);
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "ID";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.MinWidth = 25;
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 3;
            this.colIdProducto.Width = 26;
            // 
            // colpr_codigo_barra
            // 
            this.colpr_codigo_barra.Caption = "CB";
            this.colpr_codigo_barra.FieldName = "pr_codigo_barra";
            this.colpr_codigo_barra.MinWidth = 120;
            this.colpr_codigo_barra.Name = "colpr_codigo_barra";
            this.colpr_codigo_barra.Visible = true;
            this.colpr_codigo_barra.VisibleIndex = 0;
            this.colpr_codigo_barra.Width = 454;
            // 
            // colpr_observacion
            // 
            this.colpr_observacion.Caption = "OBS";
            this.colpr_observacion.FieldName = "pr_observacion";
            this.colpr_observacion.MinWidth = 120;
            this.colpr_observacion.Name = "colpr_observacion";
            this.colpr_observacion.Visible = true;
            this.colpr_observacion.VisibleIndex = 2;
            this.colpr_observacion.Width = 156;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "PROD";
            this.colProducto.FieldName = "Producto";
            this.colProducto.MinWidth = 120;
            this.colProducto.Name = "colProducto";
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 1;
            this.colProducto.Width = 527;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cant";
            this.colCantidad.FieldName = "CantidadAjustada";
            this.colCantidad.Name = "colCantidad";
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
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(228, 29);
            this.ucGe_Menu.TabIndex = 122;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = false;
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
            // Frm_Prd_Movil_Ensamblado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(4, 4);
            this.AutoScrollMinSize = new System.Drawing.Size(4, 4);
            this.ClientSize = new System.Drawing.Size(224, 288);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(1, 1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Frm_Prd_Movil_Ensamblado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ensamblado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Prd_Movil_Ensamblado_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Prd_Movil_Ensamblado_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLkUOrdenTaller.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLkUGrupoTrabajo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlEnsamblado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVwEnsamblado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLkUOrdenTaller;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenTaller;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNomProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadPieza;
        private System.Windows.Forms.DateTimePicker dtPfecha;
        private DevExpress.XtraEditors.GridLookUpEdit gridLkUGrupoTrabajo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupoTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_nombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn colSu_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnsamblado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridCtrlEnsamblado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVwEnsamblado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_codigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private System.Windows.Forms.Panel panelSucBod;
        private System.Windows.Forms.Panel panelObra;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCodBarra;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantAProducir;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.Label lblNoEnsamblar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
    }
}
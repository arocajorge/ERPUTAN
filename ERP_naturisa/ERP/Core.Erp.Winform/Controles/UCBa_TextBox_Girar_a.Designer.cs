namespace Core.Erp.Winform.Controles
{
    partial class UCBa_TextBox_Girar_a
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_girar_a = new DevExpress.XtraEditors.ButtonEdit();
            this.cmb_persona = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_razonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_apellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txt_girar_a.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_persona.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_girar_a
            // 
            this.txt_girar_a.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_girar_a.Location = new System.Drawing.Point(0, 3);
            this.txt_girar_a.Name = "txt_girar_a";
            this.txt_girar_a.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_girar_a.Size = new System.Drawing.Size(441, 20);
            this.txt_girar_a.TabIndex = 0;
            this.txt_girar_a.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txt_girar_a_ButtonClick);
            this.txt_girar_a.EditValueChanged += new System.EventHandler(this.txt_girar_a_EditValueChanged);
            // 
            // cmb_persona
            // 
            this.cmb_persona.Location = new System.Drawing.Point(0, 29);
            this.cmb_persona.Name = "cmb_persona";
            this.cmb_persona.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_persona.Properties.DisplayMember = "pe_nombreCompleto";
            this.cmb_persona.Properties.ValueMember = "IdPersona";
            this.cmb_persona.Properties.View = this.searchLookUpEdit1View;
            this.cmb_persona.Size = new System.Drawing.Size(456, 20);
            this.cmb_persona.TabIndex = 1;
            this.cmb_persona.EditValueChanged += new System.EventHandler(this.cmb_persona_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPersona,
            this.colpe_razonSocial,
            this.colpe_apellido,
            this.colpe_nombre,
            this.colCodPersona,
            this.colpe_cedulaRuc});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdPersona
            // 
            this.colIdPersona.Caption = "IdPersona";
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            this.colIdPersona.Visible = true;
            this.colIdPersona.VisibleIndex = 5;
            this.colIdPersona.Width = 67;
            // 
            // colpe_razonSocial
            // 
            this.colpe_razonSocial.Caption = "Razon Social";
            this.colpe_razonSocial.FieldName = "pe_razonSocial";
            this.colpe_razonSocial.Name = "colpe_razonSocial";
            this.colpe_razonSocial.Visible = true;
            this.colpe_razonSocial.VisibleIndex = 2;
            this.colpe_razonSocial.Width = 453;
            // 
            // colpe_apellido
            // 
            this.colpe_apellido.Caption = "Apellido";
            this.colpe_apellido.FieldName = "pe_apellido";
            this.colpe_apellido.Name = "colpe_apellido";
            this.colpe_apellido.Visible = true;
            this.colpe_apellido.VisibleIndex = 3;
            this.colpe_apellido.Width = 199;
            // 
            // colpe_nombre
            // 
            this.colpe_nombre.Caption = "Nombre";
            this.colpe_nombre.FieldName = "pe_nombre";
            this.colpe_nombre.Name = "colpe_nombre";
            this.colpe_nombre.Visible = true;
            this.colpe_nombre.VisibleIndex = 4;
            this.colpe_nombre.Width = 233;
            // 
            // colCodPersona
            // 
            this.colCodPersona.Caption = "CodPersona";
            this.colCodPersona.FieldName = "CodPersona";
            this.colCodPersona.Name = "colCodPersona";
            this.colCodPersona.Visible = true;
            this.colCodPersona.VisibleIndex = 0;
            this.colCodPersona.Width = 97;
            // 
            // colpe_cedulaRuc
            // 
            this.colpe_cedulaRuc.Caption = "CedulaRuc";
            this.colpe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.colpe_cedulaRuc.Name = "colpe_cedulaRuc";
            this.colpe_cedulaRuc.Visible = true;
            this.colpe_cedulaRuc.VisibleIndex = 1;
            this.colpe_cedulaRuc.Width = 131;
            // 
            // UCBa_TextBox_Girar_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_persona);
            this.Controls.Add(this.txt_girar_a);
            this.Name = "UCBa_TextBox_Girar_a";
            this.Size = new System.Drawing.Size(444, 27);
            this.Load += new System.EventHandler(this.UCBa_TextBox_Girar_a_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_girar_a.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_persona.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit txt_girar_a;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_persona;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_razonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_apellido;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCodPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_cedulaRuc;
    }
}

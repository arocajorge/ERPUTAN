namespace Core.Erp.Winform.Controles
{
    partial class UCCp_cuotas_x_doc
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_num_cuotas = new DevExpress.XtraEditors.TextEdit();
            this.txt_total_a_pagar = new DevExpress.XtraEditors.TextEdit();
            this.txt_observacion = new DevExpress.XtraEditors.MemoEdit();
            this.gridControlCuotas = new DevExpress.XtraGrid.GridControl();
            this.gridViewCuotas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.de_fecha_inicio = new DevExpress.XtraEditors.DateEdit();
            this.txt_dias_plazo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_cuotas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_a_pagar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha_inicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha_inicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dias_plazo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "# Cuotas:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Fecha primera cuota:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Total a pagar:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 122);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Observación:";
            // 
            // txt_num_cuotas
            // 
            this.txt_num_cuotas.Location = new System.Drawing.Point(124, 15);
            this.txt_num_cuotas.Name = "txt_num_cuotas";
            this.txt_num_cuotas.Properties.Mask.EditMask = "\\d+";
            this.txt_num_cuotas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt_num_cuotas.Size = new System.Drawing.Size(72, 20);
            this.txt_num_cuotas.TabIndex = 4;
            this.txt_num_cuotas.EditValueChanged += new System.EventHandler(this.txt_num_cuotas_EditValueChanged);
            // 
            // txt_total_a_pagar
            // 
            this.txt_total_a_pagar.Location = new System.Drawing.Point(124, 93);
            this.txt_total_a_pagar.Name = "txt_total_a_pagar";
            this.txt_total_a_pagar.Size = new System.Drawing.Size(136, 20);
            this.txt_total_a_pagar.TabIndex = 5;
            this.txt_total_a_pagar.EditValueChanged += new System.EventHandler(this.txt_total_a_pagar_EditValueChanged);
            // 
            // txt_observacion
            // 
            this.txt_observacion.Location = new System.Drawing.Point(124, 119);
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(212, 91);
            this.txt_observacion.TabIndex = 6;
            // 
            // gridControlCuotas
            // 
            this.gridControlCuotas.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControlCuotas.Location = new System.Drawing.Point(342, 0);
            this.gridControlCuotas.MainView = this.gridViewCuotas;
            this.gridControlCuotas.Name = "gridControlCuotas";
            this.gridControlCuotas.Size = new System.Drawing.Size(350, 222);
            this.gridControlCuotas.TabIndex = 7;
            this.gridControlCuotas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCuotas});
            // 
            // gridViewCuotas
            // 
            this.gridViewCuotas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewCuotas.GridControl = this.gridControlCuotas;
            this.gridViewCuotas.Name = "gridViewCuotas";
            this.gridViewCuotas.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "# Cuota";
            this.gridColumn1.FieldName = "Num_cuota";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 126;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fecha vcto";
            this.gridColumn2.FieldName = "Fecha_vcto_cuota";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 253;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Valor";
            this.gridColumn3.FieldName = "Valor_cuota";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 384;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Estado";
            this.gridColumn4.FieldName = "Estado";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 76;
            // 
            // de_fecha_inicio
            // 
            this.de_fecha_inicio.EditValue = null;
            this.de_fecha_inicio.Location = new System.Drawing.Point(124, 67);
            this.de_fecha_inicio.Name = "de_fecha_inicio";
            this.de_fecha_inicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_fecha_inicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_fecha_inicio.Size = new System.Drawing.Size(136, 20);
            this.de_fecha_inicio.TabIndex = 8;
            this.de_fecha_inicio.EditValueChanged += new System.EventHandler(this.de_fecha_inicio_EditValueChanged);
            // 
            // txt_dias_plazo
            // 
            this.txt_dias_plazo.Location = new System.Drawing.Point(124, 41);
            this.txt_dias_plazo.Name = "txt_dias_plazo";
            this.txt_dias_plazo.Properties.Mask.EditMask = "\\d+";
            this.txt_dias_plazo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt_dias_plazo.Size = new System.Drawing.Size(72, 20);
            this.txt_dias_plazo.TabIndex = 11;
            this.txt_dias_plazo.EditValueChanged += new System.EventHandler(this.txt_dias_plazo_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 44);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Días plazo:";
            // 
            // UCCp_cuotas_x_doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_dias_plazo);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.de_fecha_inicio);
            this.Controls.Add(this.gridControlCuotas);
            this.Controls.Add(this.txt_total_a_pagar);
            this.Controls.Add(this.txt_num_cuotas);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_observacion);
            this.Name = "UCCp_cuotas_x_doc";
            this.Size = new System.Drawing.Size(692, 222);
            this.Load += new System.EventHandler(this.UCCp_cuotas_x_doc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_num_cuotas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_a_pagar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha_inicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha_inicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dias_plazo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridControlCuotas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCuotas;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.TextEdit txt_num_cuotas;
        public DevExpress.XtraEditors.TextEdit txt_total_a_pagar;
        public DevExpress.XtraEditors.MemoEdit txt_observacion;
        public DevExpress.XtraEditors.DateEdit de_fecha_inicio;
        public DevExpress.XtraEditors.TextEdit txt_dias_plazo;

    }
}

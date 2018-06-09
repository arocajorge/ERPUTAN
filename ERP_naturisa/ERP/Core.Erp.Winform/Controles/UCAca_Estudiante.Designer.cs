namespace Core.Erp.Winform.Controles
{
    partial class UCAca_Estudiante
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
            this.components = new System.ComponentModel.Container();
            this.cmbEstudiante = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.acaEstudianteInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdInstitucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_estudiante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collugar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbarrio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersona_Info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPais_Info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcod_alterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioCreacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarioModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Sede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Jornada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Seccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Paralelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Curso = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstudiante.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaEstudianteInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstudiante
            // 
            this.cmbEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstudiante.Location = new System.Drawing.Point(4, 5);
            this.cmbEstudiante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstudiante.Properties.DataSource = this.acaEstudianteInfoBindingSource;
            this.cmbEstudiante.Properties.DisplayMember = "NombreCompleto";
            this.cmbEstudiante.Properties.ValueMember = "IdEstudiante";
            this.cmbEstudiante.Properties.View = this.searchLookUpEdit1View;
            this.cmbEstudiante.Size = new System.Drawing.Size(541, 22);
            this.cmbEstudiante.TabIndex = 0;
            this.cmbEstudiante.EditValueChanged += new System.EventHandler(this.cmbEstudiante_EditValueChanged);
            // 
            // acaEstudianteInfoBindingSource
            // 
            this.acaEstudianteInfoBindingSource.DataSource = typeof(Core.Erp.Info.Academico.Aca_Estudiante_Info);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdInstitucion,
            this.colIdEstudiante,
            this.colcod_estudiante,
            this.collugar,
            this.colbarrio,
            this.colfoto,
            this.colestado,
            this.colPersona_Info,
            this.colPais_Info,
            this.colcod_alterno,
            this.colFechaModificacion,
            this.colFechaCreacion,
            this.colUsuarioCreacion,
            this.colUsuarioModificacion,
            this.Col_Sede,
            this.Col_Jornada,
            this.Col_Seccion,
            this.Col_Paralelo,
            this.Col_Curso});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdInstitucion
            // 
            this.colIdInstitucion.FieldName = "IdInstitucion";
            this.colIdInstitucion.Name = "colIdInstitucion";
            // 
            // colIdEstudiante
            // 
            this.colIdEstudiante.FieldName = "IdEstudiante";
            this.colIdEstudiante.Name = "colIdEstudiante";
            this.colIdEstudiante.OptionsColumn.AllowEdit = false;
            this.colIdEstudiante.Visible = true;
            this.colIdEstudiante.VisibleIndex = 1;
            // 
            // colcod_estudiante
            // 
            this.colcod_estudiante.FieldName = "cod_estudiante";
            this.colcod_estudiante.Name = "colcod_estudiante";
            // 
            // collugar
            // 
            this.collugar.FieldName = "lugar";
            this.collugar.Name = "collugar";
            // 
            // colbarrio
            // 
            this.colbarrio.FieldName = "barrio";
            this.colbarrio.Name = "colbarrio";
            // 
            // colfoto
            // 
            this.colfoto.FieldName = "foto";
            this.colfoto.Name = "colfoto";
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            // 
            // colPersona_Info
            // 
            this.colPersona_Info.Caption = "Nombres";
            this.colPersona_Info.FieldName = "Persona_Info.pe_nombreCompleto";
            this.colPersona_Info.Name = "colPersona_Info";
            this.colPersona_Info.OptionsColumn.AllowEdit = false;
            this.colPersona_Info.Visible = true;
            this.colPersona_Info.VisibleIndex = 0;
            // 
            // colPais_Info
            // 
            this.colPais_Info.FieldName = "Pais_Info";
            this.colPais_Info.Name = "colPais_Info";
            // 
            // colcod_alterno
            // 
            this.colcod_alterno.FieldName = "cod_alterno";
            this.colcod_alterno.Name = "colcod_alterno";
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            // 
            // colFechaCreacion
            // 
            this.colFechaCreacion.FieldName = "FechaCreacion";
            this.colFechaCreacion.Name = "colFechaCreacion";
            // 
            // colUsuarioCreacion
            // 
            this.colUsuarioCreacion.FieldName = "UsuarioCreacion";
            this.colUsuarioCreacion.Name = "colUsuarioCreacion";
            // 
            // colUsuarioModificacion
            // 
            this.colUsuarioModificacion.FieldName = "UsuarioModificacion";
            this.colUsuarioModificacion.Name = "colUsuarioModificacion";
            // 
            // Col_Sede
            // 
            this.Col_Sede.Caption = "Sede";
            this.Col_Sede.FieldName = "Sede";
            this.Col_Sede.Name = "Col_Sede";
            this.Col_Sede.Visible = true;
            this.Col_Sede.VisibleIndex = 2;
            // 
            // Col_Jornada
            // 
            this.Col_Jornada.Caption = "Jornada";
            this.Col_Jornada.FieldName = "Jornada";
            this.Col_Jornada.Name = "Col_Jornada";
            this.Col_Jornada.Visible = true;
            this.Col_Jornada.VisibleIndex = 3;
            // 
            // Col_Seccion
            // 
            this.Col_Seccion.Caption = "Seccion";
            this.Col_Seccion.FieldName = "Seccion";
            this.Col_Seccion.Name = "Col_Seccion";
            this.Col_Seccion.Visible = true;
            this.Col_Seccion.VisibleIndex = 4;
            // 
            // Col_Paralelo
            // 
            this.Col_Paralelo.Caption = "Paralelo";
            this.Col_Paralelo.FieldName = "Paralelo";
            this.Col_Paralelo.Name = "Col_Paralelo";
            this.Col_Paralelo.Visible = true;
            this.Col_Paralelo.VisibleIndex = 5;
            // 
            // Col_Curso
            // 
            this.Col_Curso.Caption = "Curso";
            this.Col_Curso.FieldName = "Curso";
            this.Col_Curso.Name = "Col_Curso";
            this.Col_Curso.Visible = true;
            this.Col_Curso.VisibleIndex = 6;
            // 
            // UCAca_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbEstudiante);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCAca_Estudiante";
            this.Size = new System.Drawing.Size(549, 33);
            this.Load += new System.EventHandler(this.UCAca_Estudiante_Load);
            this.Leave += new System.EventHandler(this.UCAca_Estudiante_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstudiante.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaEstudianteInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource acaEstudianteInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdInstitucion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstudiante;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_estudiante;
        private DevExpress.XtraGrid.Columns.GridColumn collugar;
        private DevExpress.XtraGrid.Columns.GridColumn colbarrio;
        private DevExpress.XtraGrid.Columns.GridColumn colfoto;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colPersona_Info;
        private DevExpress.XtraGrid.Columns.GridColumn colPais_Info;
        private DevExpress.XtraGrid.Columns.GridColumn colcod_alterno;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioCreacion;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarioModificacion;
        public DevExpress.XtraEditors.SearchLookUpEdit cmbEstudiante;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Sede;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Jornada;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Seccion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Paralelo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Curso;
    }
}

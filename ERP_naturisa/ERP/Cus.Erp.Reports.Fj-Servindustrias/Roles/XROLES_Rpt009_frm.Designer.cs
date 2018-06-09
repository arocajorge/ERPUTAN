namespace Cus.Erp.Reports.FJ.Roles
{
    partial class XROLES_Rpt009_frm
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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.Col_Grupo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.Col_pe_cedulaRuc = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_pe_nombre = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_Cargo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_em_status = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_Orden = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_Valor = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_rubro = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_pe_FechaIni = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_Centro_costo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_FechaInicio = new DevExpress.XtraPivotGrid.PivotGridField();
            this.Col_Antiguedad = new DevExpress.XtraPivotGrid.PivotGridField();
            this.ucRo_Menu = new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes();
            this.Col_Af_DescripcionCorta = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // Col_Grupo
            // 
            this.Col_Grupo.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.Col_Grupo.AreaIndex = 0;
            this.Col_Grupo.Caption = "Grupo";
            this.Col_Grupo.FieldName = "Grupo";
            this.Col_Grupo.Name = "Col_Grupo";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Appearance.FieldHeader.BackColor = System.Drawing.Color.White;
            this.pivotGridControl1.Appearance.FieldHeader.BackColor2 = System.Drawing.Color.White;
            this.pivotGridControl1.Appearance.FieldHeader.ForeColor = System.Drawing.Color.Red;
            this.pivotGridControl1.Appearance.FieldHeader.Options.UseBackColor = true;
            this.pivotGridControl1.Appearance.FieldHeader.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.FieldValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pivotGridControl1.Appearance.FieldValue.Options.UseForeColor = true;
            this.pivotGridControl1.Appearance.FieldValueTotal.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.Appearance.FieldValueTotal.Options.UseForeColor = true;
            this.pivotGridControl1.AppearancePrint.FieldHeader.BackColor = System.Drawing.Color.Black;
            this.pivotGridControl1.AppearancePrint.FieldHeader.BackColor2 = System.Drawing.Color.White;
            this.pivotGridControl1.AppearancePrint.FieldHeader.ForeColor = System.Drawing.Color.Red;
            this.pivotGridControl1.AppearancePrint.FieldHeader.Options.UseBackColor = true;
            this.pivotGridControl1.AppearancePrint.FieldHeader.Options.UseBorderColor = true;
            this.pivotGridControl1.AppearancePrint.FieldHeader.Options.UseFont = true;
            this.pivotGridControl1.AppearancePrint.FieldHeader.Options.UseForeColor = true;
            this.pivotGridControl1.AppearancePrint.FieldValue.BackColor = System.Drawing.Color.Transparent;
            this.pivotGridControl1.AppearancePrint.FieldValue.BackColor2 = System.Drawing.Color.Transparent;
            this.pivotGridControl1.AppearancePrint.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.pivotGridControl1.AppearancePrint.FieldValue.Options.UseBackColor = true;
            this.pivotGridControl1.AppearancePrint.FieldValue.Options.UseForeColor = true;
            this.pivotGridControl1.AppearancePrint.FieldValueTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pivotGridControl1.AppearancePrint.FieldValueTotal.Options.UseForeColor = true;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.Col_pe_cedulaRuc,
            this.Col_pe_nombre,
            this.Col_Cargo,
            this.Col_em_status,
            this.Col_Orden,
            this.Col_Valor,
            this.Col_rubro,
            this.Col_pe_FechaIni,
            this.Col_Grupo,
            this.Col_Centro_costo,
            this.Col_FechaInicio,
            this.Col_Antiguedad,
            this.Col_Af_DescripcionCorta});
            pivotGridGroup1.Caption = "Grupos";
            pivotGridGroup1.Fields.Add(this.Col_Grupo);
            pivotGridGroup1.Hierarchy = null;
            pivotGridGroup1.ShowNewValues = true;
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 74);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsPrint.MergeRowFieldValues = false;
            this.pivotGridControl1.OptionsPrint.PrintHeadersOnEveryPage = true;
            this.pivotGridControl1.OptionsPrint.PrintUnusedFilterFields = false;
            this.pivotGridControl1.OptionsPrint.UsePrintAppearance = true;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotalHeader = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowRowTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(1284, 417);
            this.pivotGridControl1.TabIndex = 149;
            this.pivotGridControl1.Click += new System.EventHandler(this.pivotGridControl1_Click);
            // 
            // Col_pe_cedulaRuc
            // 
            this.Col_pe_cedulaRuc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_pe_cedulaRuc.AreaIndex = 0;
            this.Col_pe_cedulaRuc.Caption = "Cedula";
            this.Col_pe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.Col_pe_cedulaRuc.Name = "Col_pe_cedulaRuc";
            this.Col_pe_cedulaRuc.Options.ReadOnly = true;
            this.Col_pe_cedulaRuc.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            // 
            // Col_pe_nombre
            // 
            this.Col_pe_nombre.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_pe_nombre.AreaIndex = 1;
            this.Col_pe_nombre.Caption = "Empleado";
            this.Col_pe_nombre.FieldName = "pe_apellido";
            this.Col_pe_nombre.Name = "Col_pe_nombre";
            this.Col_pe_nombre.Options.ReadOnly = true;
            // 
            // Col_Cargo
            // 
            this.Col_Cargo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_Cargo.AreaIndex = 2;
            this.Col_Cargo.Caption = "Cargo";
            this.Col_Cargo.FieldName = "ca_descripcion";
            this.Col_Cargo.Name = "Col_Cargo";
            this.Col_Cargo.Options.ReadOnly = true;
            // 
            // Col_em_status
            // 
            this.Col_em_status.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_em_status.AreaIndex = 7;
            this.Col_em_status.Caption = "Fecha Salida";
            this.Col_em_status.FieldName = "EstadoEmpleado";
            this.Col_em_status.Name = "Col_em_status";
            // 
            // Col_Orden
            // 
            this.Col_Orden.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.Col_Orden.AreaIndex = 1;
            this.Col_Orden.Caption = "Orden";
            this.Col_Orden.FieldName = "Orden";
            this.Col_Orden.Name = "Col_Orden";
            // 
            // Col_Valor
            // 
            this.Col_Valor.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.Col_Valor.AreaIndex = 0;
            this.Col_Valor.Caption = "Valor";
            this.Col_Valor.FieldName = "Valor";
            this.Col_Valor.Name = "Col_Valor";
            // 
            // Col_rubro
            // 
            this.Col_rubro.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.Col_rubro.AreaIndex = 2;
            this.Col_rubro.Caption = "Rubro";
            this.Col_rubro.FieldName = "Descripcion";
            this.Col_rubro.Name = "Col_rubro";
            // 
            // Col_pe_FechaIni
            // 
            this.Col_pe_FechaIni.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_pe_FechaIni.AreaIndex = 6;
            this.Col_pe_FechaIni.Caption = "Fecha Mes";
            this.Col_pe_FechaIni.CellFormat.FormatString = "{0:d}";
            this.Col_pe_FechaIni.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Col_pe_FechaIni.FieldName = "pe_FechaIni";
            this.Col_pe_FechaIni.Name = "Col_pe_FechaIni";
            // 
            // Col_Centro_costo
            // 
            this.Col_Centro_costo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_Centro_costo.AreaIndex = 3;
            this.Col_Centro_costo.Caption = "Ubicacion";
            this.Col_Centro_costo.FieldName = "Centro_costo";
            this.Col_Centro_costo.Name = "Col_Centro_costo";
            this.Col_Centro_costo.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            // 
            // Col_FechaInicio
            // 
            this.Col_FechaInicio.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_FechaInicio.AreaIndex = 5;
            this.Col_FechaInicio.Caption = "Fecha Ingreso";
            this.Col_FechaInicio.FieldName = "FechaInicio";
            this.Col_FechaInicio.Name = "Col_FechaInicio";
            // 
            // Col_Antiguedad
            // 
            this.Col_Antiguedad.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_Antiguedad.AreaIndex = 8;
            this.Col_Antiguedad.Caption = "Antiguedad";
            this.Col_Antiguedad.FieldName = "Antiguedad";
            this.Col_Antiguedad.Name = "Col_Antiguedad";
            // 
            // ucRo_Menu
            // 
            this.ucRo_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucRo_Menu.EnableBotonImprimir = true;
            this.ucRo_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucRo_Menu.Name = "ucRo_Menu";
            this.ucRo_Menu.Size = new System.Drawing.Size(1284, 74);
            this.ucRo_Menu.TabIndex = 148;
            this.ucRo_Menu.VisibleCmbCentroCosto = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbDivision = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbEmpleado = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbNominaTipo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu.VisibleCmbNominaTipoLiqui = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu.VisibleCmbPeriodo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu.VisibleCmbRubro = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleGrupoFecha = false;
            this.ucRo_Menu.VisibleGrupoFiltro1 = true;
            this.ucRo_Menu.VisibleGrupoFiltro2 = false;
            this.ucRo_Menu.event_cmdCargar_ItemClick += new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes.delegate_cmdCargar_ItemClick(this.ucRo_Menu_event_cmdCargar_ItemClick);
            this.ucRo_Menu.event_btnsalir_ItemClick += new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes.delegate_btnsalir_ItemClick(this.ucRo_Menu_event_btnsalir_ItemClick);
            // 
            // Col_Af_DescripcionCorta
            // 
            this.Col_Af_DescripcionCorta.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.Col_Af_DescripcionCorta.AreaIndex = 4;
            this.Col_Af_DescripcionCorta.Caption = "Maquina";
            this.Col_Af_DescripcionCorta.FieldName = "Af_DescripcionCorta";
            this.Col_Af_DescripcionCorta.Name = "Col_Af_DescripcionCorta";
            // 
            // XROLES_Rpt009_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 491);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.ucRo_Menu);
            this.Name = "XROLES_Rpt009_frm";
            this.Text = "XROLES_Rpt009_frm";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField Col_pe_cedulaRuc;
        private DevExpress.XtraPivotGrid.PivotGridField Col_pe_nombre;
        private DevExpress.XtraPivotGrid.PivotGridField Col_Cargo;
        private DevExpress.XtraPivotGrid.PivotGridField Col_em_status;
        private Core.Erp.Reportes.Controles.UCRo_Menu_Reportes ucRo_Menu;
        private DevExpress.XtraPivotGrid.PivotGridField Col_Orden;
        private DevExpress.XtraPivotGrid.PivotGridField Col_Valor;
        private DevExpress.XtraPivotGrid.PivotGridField Col_rubro;
        private DevExpress.XtraPivotGrid.PivotGridField Col_pe_FechaIni;
        private DevExpress.XtraPivotGrid.PivotGridField Col_Grupo;
        private DevExpress.XtraPivotGrid.PivotGridField Col_Centro_costo;
        private DevExpress.XtraPivotGrid.PivotGridField Col_FechaInicio;
        private DevExpress.XtraPivotGrid.PivotGridField Col_Antiguedad;
        private DevExpress.XtraPivotGrid.PivotGridField Col_Af_DescripcionCorta;
    }
}
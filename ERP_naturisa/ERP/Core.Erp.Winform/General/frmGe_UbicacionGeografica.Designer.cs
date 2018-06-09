namespace Core.Erp.Winform.General
{
    partial class frmGe_UbicacionGeografica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGe_UbicacionGeografica));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.treeListUbicacionGeo = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn8 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn9 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Menu_Evento = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNuevoNodo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificarNodo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultarNodo = new System.Windows.Forms.ToolStripMenuItem();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tool_BtnPais = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnNuevo_Pais = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar_Pais = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultar_Pais = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_BtnProvincia = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnNuevo_Provincia = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar_Provincia = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultar_Provinica = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_BtnCiudad = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnNuevo_Ciudad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar_Ciudad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultar_Ciudad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListUbicacionGeo)).BeginInit();
            this.Menu_Evento.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.treeListUbicacionGeo);
            this.panelControl1.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.panelControl1.Controls.Add(this.toolStrip1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(977, 498);
            this.panelControl1.TabIndex = 0;
            // 
            // treeListUbicacionGeo
            // 
            this.treeListUbicacionGeo.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7,
            this.treeListColumn8,
            this.treeListColumn9});
            this.treeListUbicacionGeo.ContextMenuStrip = this.Menu_Evento;
            this.treeListUbicacionGeo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListUbicacionGeo.Location = new System.Drawing.Point(2, 27);
            this.treeListUbicacionGeo.Name = "treeListUbicacionGeo";
            this.treeListUbicacionGeo.OptionsPrint.UsePrintStyles = true;
            this.treeListUbicacionGeo.ParentFieldName = "IdPadre";
            this.treeListUbicacionGeo.Size = new System.Drawing.Size(973, 443);
            this.treeListUbicacionGeo.TabIndex = 2;
            this.treeListUbicacionGeo.BeforeFocusNode += new DevExpress.XtraTreeList.BeforeFocusNodeEventHandler(this.treeListUbicacionGeo_BeforeFocusNode);
            this.treeListUbicacionGeo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeListUbicacionGeo_MouseDown);
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Codigo";
            this.treeListColumn3.FieldName = "Codigo";
            this.treeListColumn3.Name = "treeListColumn3";
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Ubicacion";
            this.treeListColumn4.FieldName = "Nombre";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 0;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Estado";
            this.treeListColumn5.FieldName = "Estado";
            this.treeListColumn5.Name = "treeListColumn5";
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "IdPais";
            this.treeListColumn6.FieldName = "IdPais";
            this.treeListColumn6.Name = "treeListColumn6";
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "IdProvincia";
            this.treeListColumn7.FieldName = "IdProvincia";
            this.treeListColumn7.Name = "treeListColumn7";
            // 
            // treeListColumn8
            // 
            this.treeListColumn8.Caption = "IdCiudad";
            this.treeListColumn8.FieldName = "IdCiudad";
            this.treeListColumn8.Name = "treeListColumn8";
            // 
            // treeListColumn9
            // 
            this.treeListColumn9.Caption = "Nivel";
            this.treeListColumn9.FieldName = "Nivel";
            this.treeListColumn9.Name = "treeListColumn9";
            // 
            // Menu_Evento
            // 
            this.Menu_Evento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevoNodo,
            this.btnModificarNodo,
            this.btnConsultarNodo});
            this.Menu_Evento.Name = "Menu_Evento";
            this.Menu_Evento.Size = new System.Drawing.Size(126, 70);
            // 
            // btnNuevoNodo
            // 
            this.btnNuevoNodo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoNodo.Image")));
            this.btnNuevoNodo.Name = "btnNuevoNodo";
            this.btnNuevoNodo.Size = new System.Drawing.Size(125, 22);
            this.btnNuevoNodo.Text = "Nuevo";
            this.btnNuevoNodo.Click += new System.EventHandler(this.btnNuevoNodo_Click);
            // 
            // btnModificarNodo
            // 
            this.btnModificarNodo.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarNodo.Image")));
            this.btnModificarNodo.Name = "btnModificarNodo";
            this.btnModificarNodo.Size = new System.Drawing.Size(125, 22);
            this.btnModificarNodo.Text = "Modificar";
            this.btnModificarNodo.Click += new System.EventHandler(this.btnModificarNodo_Click);
            // 
            // btnConsultarNodo
            // 
            this.btnConsultarNodo.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarNodo.Image")));
            this.btnConsultarNodo.Name = "btnConsultarNodo";
            this.btnConsultarNodo.Size = new System.Drawing.Size(125, 22);
            this.btnConsultarNodo.Text = "Consultar";
            this.btnConsultarNodo.Click += new System.EventHandler(this.btnConsultarNodo_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(2, 470);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(973, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_BtnPais,
            this.toolStripSeparator1,
            this.tool_BtnProvincia,
            this.toolStripSeparator2,
            this.tool_BtnCiudad,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(2, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(973, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tool_BtnPais
            // 
            this.tool_BtnPais.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo_Pais,
            this.btnModificar_Pais,
            this.btnConsultar_Pais});
            this.tool_BtnPais.Image = ((System.Drawing.Image)(resources.GetObject("tool_BtnPais.Image")));
            this.tool_BtnPais.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_BtnPais.Name = "tool_BtnPais";
            this.tool_BtnPais.Size = new System.Drawing.Size(57, 22);
            this.tool_BtnPais.Text = "Pais";
            // 
            // btnNuevo_Pais
            // 
            this.btnNuevo_Pais.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo_Pais.Image")));
            this.btnNuevo_Pais.Name = "btnNuevo_Pais";
            this.btnNuevo_Pais.Size = new System.Drawing.Size(152, 22);
            this.btnNuevo_Pais.Text = "Nuevo";
            this.btnNuevo_Pais.Click += new System.EventHandler(this.btnNuevo_Pais_Click);
            // 
            // btnModificar_Pais
            // 
            this.btnModificar_Pais.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar_Pais.Image")));
            this.btnModificar_Pais.Name = "btnModificar_Pais";
            this.btnModificar_Pais.Size = new System.Drawing.Size(152, 22);
            this.btnModificar_Pais.Text = "Modificar";
            this.btnModificar_Pais.Click += new System.EventHandler(this.btnModificar_Pais_Click);
            // 
            // btnConsultar_Pais
            // 
            this.btnConsultar_Pais.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar_Pais.Image")));
            this.btnConsultar_Pais.Name = "btnConsultar_Pais";
            this.btnConsultar_Pais.Size = new System.Drawing.Size(152, 22);
            this.btnConsultar_Pais.Text = "Consultar";
            this.btnConsultar_Pais.Click += new System.EventHandler(this.btnConsultar_Pais_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tool_BtnProvincia
            // 
            this.tool_BtnProvincia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo_Provincia,
            this.btnModificar_Provincia,
            this.btnConsultar_Provinica});
            this.tool_BtnProvincia.Image = ((System.Drawing.Image)(resources.GetObject("tool_BtnProvincia.Image")));
            this.tool_BtnProvincia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_BtnProvincia.Name = "tool_BtnProvincia";
            this.tool_BtnProvincia.Size = new System.Drawing.Size(85, 22);
            this.tool_BtnProvincia.Text = "Provinica";
            // 
            // btnNuevo_Provincia
            // 
            this.btnNuevo_Provincia.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo_Provincia.Image")));
            this.btnNuevo_Provincia.Name = "btnNuevo_Provincia";
            this.btnNuevo_Provincia.Size = new System.Drawing.Size(152, 22);
            this.btnNuevo_Provincia.Text = "Nuevo";
            this.btnNuevo_Provincia.Click += new System.EventHandler(this.btnNuevo_Provincia_Click);
            // 
            // btnModificar_Provincia
            // 
            this.btnModificar_Provincia.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar_Provincia.Image")));
            this.btnModificar_Provincia.Name = "btnModificar_Provincia";
            this.btnModificar_Provincia.Size = new System.Drawing.Size(152, 22);
            this.btnModificar_Provincia.Text = "Modificar";
            this.btnModificar_Provincia.Click += new System.EventHandler(this.btnModificar_Provincia_Click);
            // 
            // btnConsultar_Provinica
            // 
            this.btnConsultar_Provinica.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar_Provinica.Image")));
            this.btnConsultar_Provinica.Name = "btnConsultar_Provinica";
            this.btnConsultar_Provinica.Size = new System.Drawing.Size(152, 22);
            this.btnConsultar_Provinica.Text = "Consultar";
            this.btnConsultar_Provinica.Click += new System.EventHandler(this.btnConsultar_Provinica_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tool_BtnCiudad
            // 
            this.tool_BtnCiudad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo_Ciudad,
            this.btnModificar_Ciudad,
            this.btnConsultar_Ciudad});
            this.tool_BtnCiudad.Image = ((System.Drawing.Image)(resources.GetObject("tool_BtnCiudad.Image")));
            this.tool_BtnCiudad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_BtnCiudad.Name = "tool_BtnCiudad";
            this.tool_BtnCiudad.Size = new System.Drawing.Size(74, 22);
            this.tool_BtnCiudad.Text = "Ciudad";
            // 
            // btnNuevo_Ciudad
            // 
            this.btnNuevo_Ciudad.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo_Ciudad.Image")));
            this.btnNuevo_Ciudad.Name = "btnNuevo_Ciudad";
            this.btnNuevo_Ciudad.Size = new System.Drawing.Size(152, 22);
            this.btnNuevo_Ciudad.Text = "Nuevo";
            this.btnNuevo_Ciudad.Click += new System.EventHandler(this.btnNuevo_Ciudad_Click);
            // 
            // btnModificar_Ciudad
            // 
            this.btnModificar_Ciudad.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar_Ciudad.Image")));
            this.btnModificar_Ciudad.Name = "btnModificar_Ciudad";
            this.btnModificar_Ciudad.Size = new System.Drawing.Size(152, 22);
            this.btnModificar_Ciudad.Text = "Modificar";
            this.btnModificar_Ciudad.Click += new System.EventHandler(this.btnModificar_Ciudad_Click);
            // 
            // btnConsultar_Ciudad
            // 
            this.btnConsultar_Ciudad.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar_Ciudad.Image")));
            this.btnConsultar_Ciudad.Name = "btnConsultar_Ciudad";
            this.btnConsultar_Ciudad.Size = new System.Drawing.Size(152, 22);
            this.btnConsultar_Ciudad.Text = "Consultar";
            this.btnConsultar_Ciudad.Click += new System.EventHandler(this.btnConsultar_Ciudad_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmGe_UbicacionGeografica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 498);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmGe_UbicacionGeografica";
            this.Text = "frmGe_UbicacionGeografica";
            this.Load += new System.EventHandler(this.frmGe_UbicacionGeografica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListUbicacionGeo)).EndInit();
            this.Menu_Evento.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tool_BtnPais;
        private System.Windows.Forms.ToolStripDropDownButton tool_BtnProvincia;
        private System.Windows.Forms.ToolStripDropDownButton tool_BtnCiudad;
        private System.Windows.Forms.ToolStripMenuItem btnNuevo_Pais;
        private System.Windows.Forms.ToolStripMenuItem btnModificar_Pais;
        private System.Windows.Forms.ToolStripMenuItem btnConsultar_Pais;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnNuevo_Provincia;
        private System.Windows.Forms.ToolStripMenuItem btnModificar_Provincia;
        private System.Windows.Forms.ToolStripMenuItem btnConsultar_Provinica;
        private System.Windows.Forms.ToolStripMenuItem btnNuevo_Ciudad;
        private System.Windows.Forms.ToolStripMenuItem btnModificar_Ciudad;
        private System.Windows.Forms.ToolStripMenuItem btnConsultar_Ciudad;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraTreeList.TreeList treeListUbicacionGeo;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn8;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn9;
        private System.Windows.Forms.ContextMenuStrip Menu_Evento;
        private System.Windows.Forms.ToolStripMenuItem btnNuevoNodo;
        private System.Windows.Forms.ToolStripMenuItem btnModificarNodo;
        private System.Windows.Forms.ToolStripMenuItem btnConsultarNodo;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}
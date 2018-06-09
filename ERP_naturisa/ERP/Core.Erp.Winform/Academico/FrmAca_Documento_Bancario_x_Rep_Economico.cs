using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Academico
{
    public partial class FrmAca_Documento_Bancario_x_Rep_Economico : Form
    {
        #region "Variables y Propiedades"
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<Aca_Familiar_Info> lista_familiar = new List<Aca_Familiar_Info>();
        string Mesg = "";
        Aca_Familiar_Bus bus_familiar = new Aca_Familiar_Bus();
        BindingList<Aca_Documento_Bancario_x_Rep_Economico_Info> lista_documentos = new BindingList<Aca_Documento_Bancario_x_Rep_Economico_Info>();
        Aca_Documento_Bancario_x_Rep_Economico_Bus bus_documentos = new Aca_Documento_Bancario_x_Rep_Economico_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<tb_banco_x_mg_banco_Info> lista_bancos = new List<tb_banco_x_mg_banco_Info>();
        tb_banco_x_mg_banco_Info Item = new tb_banco_x_mg_banco_Info();
        Aca_Tipo_mecanismo_de_pago_Info Meca_Pago_Info = new Aca_Tipo_mecanismo_de_pago_Info();
        tb_banco_x_mg_banco_Bus bus_banco = new tb_banco_x_mg_banco_Bus();
        Aca_tipo_mecanismo_de_pago_Bus bus_tipo_meca_pago = new Aca_tipo_mecanismo_de_pago_Bus();
        Aca_Documento_Bancario_x_Rep_Economico_Info Info_doc_ban = new Aca_Documento_Bancario_x_Rep_Economico_Info();
        List<Aca_Tipo_mecanismo_de_pago_Info> list_tipo_meca_pago = new List<Aca_Tipo_mecanismo_de_pago_Info>();
        Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Bus bus_forma_pagp_x_estudiante_x_matricula = new Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Bus();
        Aca_Familiar_Info info_familiar = new Aca_Familiar_Info();
        Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info Info_rep_eco_Estu_Matri = new Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info();
        Aca_matricula_Bus bus_matricula = new Aca_matricula_Bus();
        Aca_Matricula_Info info_matricula = new Aca_Matricula_Info();
        int RowHandle = 0;
        int IdDocumentoBancario = 0;
        #endregion

        #region "Constructor"
        public FrmAca_Documento_Bancario_x_Rep_Economico()
        {
            InitializeComponent();
            gridView_Dco_bancario.CellValueChanging += gridView_Dco_bancario_CellValueChanging;
           
        }
        #endregion

        #region "Eventos"
        void gridView_Dco_bancario_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void gridView_rep_Eco_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
       {
            try
            {
                if (e.Column.Name == "Col_Check")
                {
                    if (e.Value.Equals(false))
                    {
                        Limpiar();
                    }
                    else
                    {
                        foreach (var item in lista_familiar)
                        {
                            item.check = false;
                        }
                        info_familiar = (Aca_Familiar_Info)gridView_rep_Eco.GetFocusedRow();
                        gridView_rep_Eco.SetFocusedRowCellValue(Col_Check, true);



                        lista_documentos = new BindingList<Aca_Documento_Bancario_x_Rep_Economico_Info>(bus_documentos.Get_List_Matricula_Tipo_Documento(info_familiar.IdInstitucion, Convert.ToInt32(info_familiar.IdFamiliar)));


                        gridControl_Dco_bancario.DataSource = lista_documentos;
                        gridControl_Dco_bancario.RefreshDataSource();
                        gridControl_rep_Eco.RefreshDataSource();


                    }
                }

            }

            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            
            if(!Validar())
            return;
            Grabar();
        }

        private void FrmAca_Documento_Bancario_x_Rep_Economico_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Combo();               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_banco_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
              
                //foreach (var item in lista_documentos)
                //{
                // item.eliminar=true;
                //}
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
      
            }

         private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                    Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
           
        }

        private void cmb_forma_de_pago_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Llamar_pantalla_forma_pago();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_forma_de_pago_Click(object sender, EventArgs e)
        {
            Llamar_pantalla_forma_pago();
        }

        private void gridView_Dco_bancario_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                Info_doc_ban = (Aca_Documento_Bancario_x_Rep_Economico_Info)this.gridView_Dco_bancario.GetFocusedRow();
                int c = 0;
                if (e.Column.Name == "Col_IdBanco" || e.Column.Name == "Col_forma_de_Pago")
                {
                    
                    foreach (var item in lista_documentos)
                    {
                        var itemBan = lista_bancos.FirstOrDefault(p => p.Id_tb_banco_x_mgbanco == Info_doc_ban.Id_tb_banco_x_mgbanco);                       
                        if (item.Id_tb_banco_x_mgbanco == Info_doc_ban.Id_tb_banco_x_mgbanco)
                        {
                            c++;
                            if (c != 1)
                            {
                                MessageBox.Show("Ya tiene una forma de pago con  " + itemBan.nombre + " verifique la forma de pago ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }
                    }
                }

                if (e.Column.Name == "Col_eliminar")
                {
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Esta seguro de querer eliminar el registro?", param.Nombre_sistema, MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            gridView_Dco_bancario.DeleteSelectedRows();
                        }

                    }
                    catch (Exception ex)
                    {

                        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                        NameMetodo = NameMetodo + " - " + ex.ToString();
                        MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                            , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_Dco_bancario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_Dco_bancario.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_Dco_bancario_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                
                RowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #endregion

        #region "Combos"
        private void Cargar_Combo()
        {
            try
            {

                lista_familiar = bus_familiar.Get_List_RepreEco_x_Estudiante(param.IdInstitucion);
                gridControl_rep_Eco.DataSource = lista_familiar;

                lista_bancos = bus_banco.Get_List_Banco_Aca();            
                cmb_banco.DataSource = lista_bancos;
                cmb_banco.DisplayMember = "nombre";
                cmb_banco.ValueMember = "Id_tb_banco_x_mgbanco";

                list_tipo_meca_pago = bus_tipo_meca_pago.Get_Lista_tipo_mecanismo_Pago();
                cmb_forma_de_pago.DataSource = list_tipo_meca_pago;
                cmb_forma_de_pago.DisplayMember = "nombre";
                cmb_forma_de_pago.ValueMember = "Id_tipo_meca_pago";
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region"Get"
        private void Get()
        {
            try
            {


                foreach (var item in lista_documentos)
                {
                    item.IdInstitucion = param.IdInstitucion;
                    item.IdFamiliar = info_familiar.IdFamiliar;
                    item.IdParentesco_cat = info_familiar.IdParentesco_cat;
                    item.IdBanco = lista_bancos.FirstOrDefault(p => p.Id_tb_banco_x_mgbanco == item.Id_tb_banco_x_mgbanco).IdBanco_Erp;
                   
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #endregion

        #region "Grabar"
        private bool Grabar()
        {
            try
            {
                bool resultado = false;
                groupControl1.Focus();
                Get();

                if (bus_documentos.GrabarDB(lista_documentos.ToList(), ref IdDocumentoBancario, ref Mesg))
                {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        resultado = true;                    
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_guardaron_los_datos), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
          
        }
        #endregion

        #region"Validacion"
        private bool Validar()
        {
            try
            {
                bool ba = true;
                if (info_familiar == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Representante Economico", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ba = false;
                }

                if (lista_documentos.Count() == 0)
                {
                    MessageBox.Show("No exinte ningun registro para guardar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ba = false;
                }
                return ba;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void Limpiar()
        {
            try
            {
                lista_documentos = new BindingList<Aca_Documento_Bancario_x_Rep_Economico_Info>();
                gridControl_Dco_bancario.DataSource = lista_documentos;
                info_familiar = new Aca_Familiar_Info();
                gridView_rep_Eco.SetFocusedRowCellValue(Col_Check, false);
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region"llamar Pantalla forma de pago"
        private void Llamar_pantalla_forma_pago()
        {
            try
            {
                list_tipo_meca_pago = new List<Aca_Tipo_mecanismo_de_pago_Info>();
                decimal IdBanco = 0;
                if (lista_documentos.Count() != 0)
                {

                    if (RowHandle >= 0)
                    {
                        IdBanco = Convert.ToDecimal(gridView_Dco_bancario.GetRowCellValue(RowHandle, Col_IdBanco));
                        Item = lista_bancos.FirstOrDefault(q => q.Id_tb_banco_x_mgbanco == IdBanco);
                        if (Item != null)
                        {
                            list_tipo_meca_pago = bus_tipo_meca_pago.Get_Lista_tipo_mecanismo_Pago_x_Banco(Item.Id_tb_banco_x_mgbanco);

                            Frm_Aca_Forma_Pago_Cons frm_combo = new Frm_Aca_Forma_Pago_Cons();
                            frm_combo.set_config_combo(list_tipo_meca_pago);
                            frm_combo.ShowDialog();
                            Meca_Pago_Info = frm_combo.Get_info_meca_Pago();
                            gridView_Dco_bancario.SetRowCellValue(RowHandle, Col_forma_de_Pago, Meca_Pago_Info == null ? 0 : Meca_Pago_Info.Id_tipo_meca_pago);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

    }
    }



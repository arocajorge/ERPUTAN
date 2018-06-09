/*CLASE: frmRo_Empleado_Gastos_Personales_Cons_Identificacion
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 04-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using Core.Erp.Business.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
//Derek 19/12/2013
//Gastos Personales
//Derek Mejía Soria
//ultima modificacion : 08/01/2014
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Empleado_Gastos_Personales_Cons_Identificacion : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        BindingList<ro_CargaFamiliar_Info> Obj_cafa = new BindingList<ro_CargaFamiliar_Info>();
        ro_CargaFamiliar_Bus cargafamBus = new ro_CargaFamiliar_Bus();
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int Idcatalogo { get; set; } 

        public frmRo_Empleado_Gastos_Personales_Cons_Identificacion()
        {
            try
            {
                InitializeComponent();
                tb_Catalogo_Bus busCatalogo = new tb_Catalogo_Bus();
                List<tb_Catalogo_Info> ListInfo = new List<tb_Catalogo_Info>();
                ListInfo = busCatalogo.Get_List_Catalogo(Cl_Enumeradores.TipoCatalogo.SEXO);
                cmb_Sexo.DataSource = ListInfo;
                gridCargaFam.DataSource = Obj_cafa;

                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
            
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {pu_Guardar();
            this.Close();

            }
            catch (Exception ex)
            {
                
             MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
           
            try
            {
                pu_Guardar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                  this.Close();
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        public void SEtInfo(List<ro_CargaFamiliar_Info> lista)
        {

            try
            {
                Obj_cafa = new BindingList<ro_CargaFamiliar_Info>(lista);
                gridCargaFam.DataSource = Obj_cafa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        
        }
        void pu_Cargar()
        {
            try
            {
                ro_Catalogo_Bus bus_cat = new ro_Catalogo_Bus();
                List<ro_Catalogo_Info> cat = new List<ro_Catalogo_Info>();
                var parentezco = bus_cat.Get_List_Catalogo_x_Tipo(3);
                foreach (var item in parentezco)
	                {
                        if (item.IdCatalogo == Idcatalogo)
	                        {
		                         cat.Add(item);
                                 if (Idcatalogo==36)
                                 {
                                     Idcatalogo = 19;
                                 }
	                        }
	                }            
                repositoryParentezco.DataSource = cat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        public Boolean Ingresa_familiares()
        {
            try
            {
                //List<ro_CargaFamiliar_Info> ListFamiliar = new List<ro_CargaFamiliar_Info>();
                ro_CargaFamiliar_Bus BusFamiliar = new ro_CargaFamiliar_Bus();
                string msg = "";

                var CV = (BindingList<ro_CargaFamiliar_Info>)gridCargaFam.DataSource;
                if (CV != null && CV.Count != 0)
                {
                    if (ValidaFamiliar() == false)
                    {
                        MessageBox.Show("No se guardaron los datos del Familiar.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }


                    foreach (var item in Obj_cafa)
                    {
                        ro_CargaFamiliar_Info Info_familiar = new ro_CargaFamiliar_Info();

                        Info_familiar.IdEmpresa = IdEmpresa;
                        Info_familiar.IdCargaFamiliar = item.IdCargaFamiliar;
                        Info_familiar.IdEmpleado = IdEmpleado;
                        Info_familiar.Cedula = item.Cedula;
                        Info_familiar.Sexo = item.Sexo;
                        Info_familiar.TipoFamiliar = item.TipoFamiliar;
                        Info_familiar.Nombres = item.Nombres;
                        Info_familiar.FechaNacimiento = (item.FechaNacimiento == null) ? null : item.FechaNacimiento;
                        //Info_familiar.Estado = true;
                        Info_familiar.Estado = item.Estado;


                    }
                    MessageBox.Show("Se ha grabado exitosamente la carga del empleado: #" + IdEmpleado, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridViewCafa.OptionsBehavior.Editable = false;
                    //mnuNuevo.Enabled = false;
                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }

        }
        private Boolean ValidaFamiliar()
        {
            try
            {   
                //Valida si es conyugue y si solo hay uno
                if (Idcatalogo == 20)
                {
                    int contador = 0;
                    foreach (var item in Obj_cafa)
                    {
                        contador++;
                    }
                    if(contador>1){
                        MessageBox.Show("Solo puede tener un Conyugue ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                //Valida si la cedula se repite
                int contadorCedula = 0;                
                foreach (var item in Obj_cafa)
                {         
                    contadorCedula++;
                    int contadorCedula2 = 1;
                    foreach (var item2 in Obj_cafa)
                    {
                        if (contadorCedula2 > contadorCedula)
                        {
                          if (item.Cedula == item2.Cedula)
                            {
                                MessageBox.Show("La cedula del empleado "+item.Nombres+" es igual a la de la persona\n"+
                                item2.Nombres+" , no pueden existir cedulas repetidas", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }  
                        }                        
                        contadorCedula2 = contadorCedula2 + 1;
                    }                    
                }

                foreach (var item in Obj_cafa)
                {
                    ro_CargaFamiliar_Info Info_familiar = new ro_CargaFamiliar_Info();

                    Info_familiar.Sexo = item.Sexo;

                    if (Info_familiar.Sexo == null)
                    {
                        MessageBox.Show("No ha ingresado el Sexo del Familiar ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    Info_familiar.TipoFamiliar = item.TipoFamiliar;

                    if (Info_familiar.TipoFamiliar == null)
                    {
                        MessageBox.Show("No ha ingresado  el Parentezco del Familiar ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    Info_familiar.Nombres = item.Nombres;

                    if (Info_familiar.Nombres == null)
                    {
                        MessageBox.Show("No ha ingresado los nombres del Familiar ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;                
            }
        }

        private void frmRo_Empleado_Gastos_Personales_Cons_Identificacion_Load(object sender, EventArgs e)
        {
            try
            {
                pu_Cargar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        private void pu_Guardar() {
            try {
                groupBox4.Focus();
                Ingresa_familiares();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }        
        }





        private void mnuNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Guardar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
              
        }

        private void frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing(sender, e);
                //frmRo_Empleado_Gastos_Personales_Mant EMGPM = new frmRo_Empleado_Gastos_Personales_Mant();
                //EMGPM.loadxEmpleado( Convert.ToInt32(IdEmpleado));         
                //EMGPM.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        private void mnu_salir_Click(object sender, EventArgs e)
        {
            try
            {
                 Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        //Delegado
        public delegate void delegate_frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing event_frmRo_Empleado_Gastos_Personales_Cons_Identificacion_FormClosing;

        private void gridViewCafa_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                 if (e.Column.Name == "colTipoFamiliar")
                 {
                     string valor = Convert.ToString(e.Value);
                   
                     if(!Convert.ToBoolean(gridViewCafa.GetFocusedRowCellValue("Estado")))
                     gridViewCafa.SetFocusedRowCellValue(colEstado1, true);
                }

                 if (e.Column.Name == "colCedula")
                 {
                     if (e.Value != null || e.Value != "")
                     {
                         String caracteres = Convert.ToString(e.Value);
                         if (caracteres.Length==10 || caracteres.Length==13)
                         {
                             tb_persona_bus bus = new tb_persona_bus();
                             string mens = "";                             
                             if (!bus.Verifica_Ruc(Convert.ToString(e.Value), ref mens))
                             {
                                 MessageBox.Show(mens, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             }
                             //mnuNuevo.Enabled = true;
                         }
                         else
                         {
                             if (caracteres.Length > 10 && caracteres.Length < 13)
                             {
                                 MessageBox.Show("Faltan " + (13-caracteres.Length) + " caracteres en el Ruc");
                                 //mnuNuevo.Enabled = false;
                             }
                             else
                             {
                                 if (caracteres.Length > 0 && caracteres.Length < 10)
                                 {
                                     MessageBox.Show("Faltan " + (10 - caracteres.Length) + " caracteres en la Cédula");
                                     //mnuNuevo.Enabled = false;
                                 }
                                 else
                                 {
                                     //igual a 0
                                     //mnuNuevo.Enabled = true;
                                 }
                                 
                             }                           
                         }

                     } if (!Convert.ToBoolean(gridViewCafa.GetFocusedRowCellValue("Estado")))
                         gridViewCafa.SetFocusedRowCellValue(colEstado1, true);
                 }                 
                 //gridViewCafa.SetFocusedRowCellValue(colEstado1, true);
                 //repositoryItemCheckEditEstado.ValueChecked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return;
            }
        }

        private void gridViewCafa_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                    if (e.KeyCode == Keys.Delete)
                {                
                        if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ro_CargaFamiliar_Info info = new ro_CargaFamiliar_Info();
                            info = gridViewCafa.GetFocusedRow() as ro_CargaFamiliar_Info;
                            cargafamBus.eliminar1registro(info);
                            gridViewCafa.DeleteSelectedRows();

                            Obj_cafa = new BindingList<ro_CargaFamiliar_Info>();
                            var r = (BindingList<ro_CargaFamiliar_Info>)gridViewCafa.DataSource;
                            Obj_cafa = new BindingList<ro_CargaFamiliar_Info>(r);
                            //int secuencia = 1;
                            //foreach (var item in Obj_cafa)
                            //{
                            //    item.Secuencia = secuencia;
                            //    secuencia++;
                            //}
                        }                             
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void gridViewCafa_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if(e.Column.FieldName == "Estado")
                    if (Convert.ToBoolean(e.CellValue) == true)
                    { gridViewCafa.SetFocusedRowCellValue(colEstado1, false); }
                    else { gridViewCafa.SetFocusedRowCellValue(colEstado1, true); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void mnu_Modificar_Click(object sender, EventArgs e)
        {

        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaEstudiante_Cons : DevExpress.XtraEditors.XtraForm
    {

        public FrmAcaEstudiante_Cons()
        {
            InitializeComponent();

           
            //this.MdiParent
            //
            //this.gridViewEstudiante.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(frmHadler.gridViewEstudiante_RowCellStyle);
            //this.Load += new System.EventHandler(frmHadler.FrmAcaEstudiante_Cons_Load);
            //ucGe_Menu.event_btnSalir_ItemClick += frmHadler.ucGe_Menu_event_btnSalir_ItemClick;
            //ucGe_Menu.event_btnNuevo_ItemClick += frmHadler.ucGe_Menu_event_btnNuevo_ItemClick;
            //ucGe_Menu.event_btnModificar_ItemClick += frmHadler.ucGe_Menu_event_btnModificar_ItemClick;
            //ucGe_Menu.event_btnAnular_ItemClick += frmHadler.ucGe_Menu_event_btnAnular_ItemClick;
            //ucGe_Menu.event_btnconsultar_ItemClick += frmHadler.ucGe_Menu_event_btnconsultar_ItemClick;
            //ucGe_Menu.event_btnBuscar_Click += frmHadler.ucGe_Menu_event_btnBuscar_Click;

        }

               #region Declaracion de variables
       tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Aca_Estudiante_Info infoEstudiante = new Aca_Estudiante_Info();
        tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();
        Aca_Estudiante_Bus busEstudiante = new Aca_Estudiante_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action Accion;
        FrmAcaEstudiante_Mant frm;

        public DevExpress.XtraGrid.GridControl gridControlEstudiante;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewEstudiante;
        public Form FrmMDIParent;

        #endregion

     
      
       private void carga_Estudiantes()
        {
            try
            {
                List<Aca_Estudiante_Info> listEstudiantes = new List<Aca_Estudiante_Info>();
                listEstudiantes = busEstudiante.Get_List_Estudiantes_Sin_Matricula(param.IdInstitucion);
                this.gridControlEstudiante.DataSource = null;
                this.gridControlEstudiante.DataSource = listEstudiantes;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + "", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {


                frm = new FrmAcaEstudiante_Mant();
                //if (FrmMDIParent != null)
                //{
                //    frm.MdiParent = FrmMDIParent;
                //}

                if (Accion!=Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm.set_Estudiante(infoEstudiante);    
                }

                frm.event_FrmAcaEstudiante_Mant_FormClosing += frm_event_FrmAcaEstudiante_Mant_FormClosing;
                frm.MdiParent = this.MdiParent;
                frm.set_Accion(Accion);
                frm.Show();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       public  void frm_event_FrmAcaEstudiante_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                carga_Estudiantes();
            }
            catch (Exception ex)
            {
              Log_Error_bus.Log_Error(ex.ToString());
              MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       private void FrmAcaEstudiante_Cons_Load_1(object sender, EventArgs e)
       {
           try
           {

               carga_Estudiantes();
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           try
           {

               llama_frm(Cl_Enumeradores.eTipo_action.grabar);

           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           try
           {
               infoEstudiante = (Aca_Estudiante_Info)this.gridViewEstudiante.GetFocusedRow();

               if (infoEstudiante == null)
               {
                   MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
               else
               {
                   if (infoEstudiante.estado != "I")
                   {
                       llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                   }
                   else
                   {
                       MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_modif_regis_Inac), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   }
               }
             
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           try
           {
               infoEstudiante = (Aca_Estudiante_Info)this.gridViewEstudiante.GetFocusedRow();

               if (infoEstudiante == null)
               {
                   MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
               else
               {
                   if (infoEstudiante.estado != "I")
                   {
                       llama_frm(Cl_Enumeradores.eTipo_action.Anular);
                   }
                   else
                   {
                       MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   }
               }
              
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
       {
           try
           {
               carga_Estudiantes();
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           this.Close();
       }

       private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
       {
           try
           {
               infoEstudiante = (Aca_Estudiante_Info)this.gridViewEstudiante.GetFocusedRow();

               if (infoEstudiante == null)
               {
                   MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_consul), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
               else
               {
                   llama_frm(Cl_Enumeradores.eTipo_action.consultar);
               }
           }
           catch (Exception ex)
           {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void gridViewEstudiante_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
       {
           try
           {
               var data = gridViewEstudiante.GetRow(e.RowHandle) as Aca_Estudiante_Info;
               if (data == null)
                   return;
               if (data.estado == "I")
                   e.Appearance.ForeColor = Color.Red;
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message.ToString());
           }
       }
    }
}
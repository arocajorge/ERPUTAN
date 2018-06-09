using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaPreparacion_Alumno_Mant : Form
    {

        #region "Variables"
        string mensaje = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        Aca_matricula_Bus Bus_Matricula = new Aca_matricula_Bus();
        Aca_Matricula_Info matriculaInfo = new Aca_Matricula_Info();
        //List<Aca_Matricula_Info> LstEst_Matr_Con_Sin_Contrato = new List<Aca_Matricula_Info>();

        Aca_Contrato_x_Estudiante_Bus Bus_Contrato = new Aca_Contrato_x_Estudiante_Bus();
        Aca_Contrato_x_Estudiante_Info ContratoInfo = new Aca_Contrato_x_Estudiante_Info();
        List<Aca_Contrato_x_Estudiante_Info> LsContrato = new List<Aca_Contrato_x_Estudiante_Info>();

        vwAca_AnioPeriodo_Activo_Bus BusAnioPeriodoActivo = new vwAca_AnioPeriodo_Activo_Bus();
        vwAca_AnioPeriodo_Activo_Info InfovwAca_AnioPeriodo_Activo = new vwAca_AnioPeriodo_Activo_Info();
        
        //vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Bus BusEst_Matr_Con_Sin_Contrato = new vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Bus();
        //List<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info> LstEst_Matr_Con_Sin_Contrato = new List<vwAca_Estudiante_Matricula_Con_y_Sin_Contrato_Info>();



        #endregion


        public FrmAcaPreparacion_Alumno_Mant()
        {
            InitializeComponent();
        }

        #region "Eventos"

        private void FrmAcaPreparacion_Alumno_Mant_Load(object sender, EventArgs e)
        {
            CargaAnioPeriodo();
            CargaGridPreparacionAlumno();
            
        }


        private void btnExepciones_x_Estudiante_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ContratoInfo = (Aca_Contrato_x_Estudiante_Info)this.gridvwPreparacionAlumno.GetFocusedRow();
            //CargaGridPreparacionAlumno();
            if (ContratoInfo == null)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                llama_frmAcaExepciones_x_Estudiante(Cl_Enumeradores.eTipo_action.grabar);
            }

        }

        private void btb_beca_x_alumno_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {


                FrmAca_Beca_Estudiante_x_rubros_Mant frm = new FrmAca_Beca_Estudiante_x_rubros_Mant();
                ContratoInfo = (Aca_Contrato_x_Estudiante_Info)this.gridvwPreparacionAlumno.GetFocusedRow();
                if (ContratoInfo == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_un_registro), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                frm.MdiParent = this.MdiParent;
                frm.Set(ContratoInfo);
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void barLinkContainerItem2_ItemDoubleClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ContratoInfo = (Aca_Contrato_x_Estudiante_Info)this.gridvwPreparacionAlumno.GetFocusedRow();
            //CargaGridPreparacionAlumno();
            if (ContratoInfo == null)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                llama_FrmAca_Rubros_Asigandos_x_Estudiante_x_Periodo(Cl_Enumeradores.eTipo_action.grabar);
            }
        }


        #endregion



        #region Funciones
        public void CargaAnioPeriodo()
        {
            InfovwAca_AnioPeriodo_Activo = BusAnioPeriodoActivo.Get_vwAca_AnioPeriodo_Activo_Info(ref mensaje);

            //txtAnioLectivo.Text = InfovwAca_AnioPeriodo_Activo.AnioLectivo;
            lblPeriodoActivo.Text = InfovwAca_AnioPeriodo_Activo.IdPeriodo.ToString();
        }

        public void CargaGridPreparacionAlumno()
        {
            LsContrato = Bus_Contrato.Get_List_Contrato_Preparacion_x_Estudiante(param.IdInstitucion, param.IdSucursal);
            gridCtrlPreparacionAlumno.DataSource = LsContrato;


        }
        private void llama_frmAcaExepciones_x_Estudiante(Cl_Enumeradores.eTipo_action Accion)
        {
            FrmAcaExepciones_x_Estudiante frm;
            try
            {
                ContratoInfo = (Aca_Contrato_x_Estudiante_Info)this.gridvwPreparacionAlumno.GetFocusedRow();
                if (ContratoInfo == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if ((ContratoInfo.IdContrato == 0 || ContratoInfo.IdContrato == null))
                    {
                        MessageBox.Show("Estudiante " + ContratoInfo.nombreCompleto + " " + "con matricula" + ContratoInfo.IdMatricula + " No se rubros asignados.");
                    }
                    else
                    {
                        //llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                        frm = new FrmAcaExepciones_x_Estudiante();
                        frm.MdiParent = this.MdiParent;
                        //frm.event_FrmAcaMatricula_Mant_FormClosing += frm_event_FrmAcaMatricula_Mant_FormClosing;
                        if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                        {
                            //frm.set_matricula(matriculaInfo);
                            frm.InfoContrato = ContratoInfo;
                        }
                        frm.set_Accion(Accion);
                        frm.Show();
                    }
                }

               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void llama_FrmAca_Rubros_Asigandos_x_Estudiante_x_Periodo(Cl_Enumeradores.eTipo_action Accion)
        {
            FrmAca_Rubros_Asigandos_x_Estudiante_x_Periodo frm;
            try
            {
                ContratoInfo = (Aca_Contrato_x_Estudiante_Info)this.gridvwPreparacionAlumno.GetFocusedRow();
                if (ContratoInfo == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if ((ContratoInfo.IdContrato == 0 || ContratoInfo.IdContrato == null))
                    {
                        MessageBox.Show("Estudiante " + ContratoInfo.nombreCompleto + " " + "con matricula" + ContratoInfo.IdMatricula + " No se rubros asignados.");
                    }
                    else
                    {
                        //llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                        frm = new FrmAca_Rubros_Asigandos_x_Estudiante_x_Periodo();
                        frm.MdiParent = this.MdiParent;
                        //frm.event_FrmAcaMatricula_Mant_FormClosing += frm_event_FrmAcaMatricula_Mant_FormClosing;
                        if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                        {
                            //frm.set_matricula(matriculaInfo);
                            frm.InfoContrato = ContratoInfo;
                        }
                        frm.set_Accion(Accion);
                        frm.Show();
                    }
                }



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void llama_FrmAca_Retiro_Estudiante()
        {
            FrmAca_Retiro_Estudiante frm;
            try
            {
                ContratoInfo = (Aca_Contrato_x_Estudiante_Info)this.gridvwPreparacionAlumno.GetFocusedRow();
                if (ContratoInfo == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if ((ContratoInfo.IdContrato == 0 || ContratoInfo.IdContrato == null))
                    {
                        MessageBox.Show("Estudiante " + ContratoInfo.nombreCompleto + " " + "con matricula" + ContratoInfo.IdMatricula + " No se rubros asignados.");
                    }
                    else
                    {
                        //llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                        frm = new FrmAca_Retiro_Estudiante();
                        frm.MdiParent = this.MdiParent;
                        //frm.event_FrmAcaMatricula_Mant_FormClosing += frm_event_FrmAcaMatricula_Mant_FormClosing;
                        
                            //frm.set_matricula(matriculaInfo);
                        frm.Set(ContratoInfo);
                        
                        //frm.set_Accion(Accion);
                        frm.Show();
                    }
                }



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llama_FrmAca_Contrato_Mant()
        {
            FrmAca_Contrato_Mant frm;
            try
            {
                ContratoInfo = (Aca_Contrato_x_Estudiante_Info)this.gridvwPreparacionAlumno.GetFocusedRow();
                if (ContratoInfo == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if ((ContratoInfo.IdContrato == 0 || ContratoInfo.IdContrato == null))
                    {
                        MessageBox.Show("Estudiante " + ContratoInfo.nombreCompleto + " " + "con matricula" + ContratoInfo.IdMatricula + " No se rubros asignados.");
                    }
                    else
                    {
                        //llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
                        frm = new FrmAca_Contrato_Mant();
                        frm.MdiParent = this.MdiParent;
                        //frm.event_FrmAcaMatricula_Mant_FormClosing += frm_event_FrmAcaMatricula_Mant_FormClosing;

                        //frm.set_matricula(matriculaInfo);
                        frm.Set(ContratoInfo);

                        //frm.set_Accion(Accion);
                        frm.Show();
                    }
                }



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_FrmAca_Retiro_Estudiante();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        private void barBtnModificarContrato_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //try
            //{
            //    llama_FrmAca_Contrato_Mant();
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
        }

        private void barBtn_ConsultarContrato_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_FrmAca_Contrato_Mant();
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        //private void chkGarantizados_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    ContratoInfo = new Aca_Contrato_x_Estudiante_Info();
        //    ContratoInfo = (Aca_Contrato_x_Estudiante_Info)this.gridvwPreparacionAlumno.GetFocusedRow();


        //    foreach (var item in LsContrato)
        //    {
        //        item.estado_contrato_pago_garantizado = (bool)chkGarantizados.EditValue;
        //    }
        //    gridCtrlPreparacionAlumno.RefreshDataSource();
        //}

        
        #region "Set"

        #endregion


        #region "Get"

        #endregion


        #region "Grabar,Actualizar,Eliminar"

        #endregion


        #region "Validaciones"

        #endregion









    }
}

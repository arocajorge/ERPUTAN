using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;


namespace Core.Erp.Winform.SeguridadAcceso
{
    public partial class FrmSeg_Login_x_Empresas : Form
    {

        
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public FrmSeg_Login_x_Empresas()
        {
            InitializeComponent();
            
        }

        tb_Empresa_Info InfoEmpresa = new tb_Empresa_Info();
        List<tb_Empresa_Info> ListInfoEmpresa = new List<tb_Empresa_Info>();
        tb_Empresa_Bus BusEmpresa = new tb_Empresa_Bus();

        tb_Sucursal_Bus BusSucursal = new tb_Sucursal_Bus();
        List<tb_Sucursal_Info> ListInfoSucursal = new List<tb_Sucursal_Info>();
        tb_Sucursal_Info InfoSucursal = new tb_Sucursal_Info();


        Aca_Institucion_Bus BusInstitucion = new Aca_Institucion_Bus();
        Aca_Institucion_Info InfoInstitucion = new Aca_Institucion_Info();
        List<Aca_Institucion_Info> ListInfoInstitucion = new List<Aca_Institucion_Info>();



        private seg_usuario_info InfoUsuario = new seg_usuario_info();
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Si cancela ahora cerrara el sistema. \n¿Seguro que desea salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (salir==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ListInfoEmpresa.Count()>0)
            {
                tb_Empresa_Info my_info = (tb_Empresa_Info)ListInfoEmpresa.FirstOrDefault(v => v.IdEmpresa == Convert.ToInt32(cmb_empresa.EditValue));
                param.InfoEmpresa=my_info;
                param.IdEmpresa=my_info.IdEmpresa;
                param.NombreEmpresa = my_info.em_nombre;
                
                

                InfoSucursal = (tb_Sucursal_Info)ListInfoSucursal.FirstOrDefault(v => v.IdSucursal == Convert.ToInt32(cmb_sucursal.EditValue));
                param.IdSucursal = InfoSucursal.IdSucursal;
                param.InfoSucursal = InfoSucursal;

                if (InfoInstitucion != null)
                {
                    param.IdInstitucion = InfoInstitucion.IdInstitucion;
                    param.InfoInstitucion = InfoInstitucion;
                }


                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione una empresa a la que desea ingresar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void FrmEmpresas_Load(object sender, EventArgs e)
        
        {
            string error = "";
            try
            {
                

                ListInfoEmpresa = BusEmpresa.Get_List_Empresa_x_Usuario(param.IdUsuario);
                cmb_empresa.Properties.DataSource = ListInfoEmpresa;
                InfoEmpresa = ListInfoEmpresa.FirstOrDefault();
                cmb_empresa.EditValue = InfoEmpresa.IdEmpresa;


            }
            catch (Exception ex)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_empresa_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmb_empresa.EditValue != null)
                {

                    InfoEmpresa = ListInfoEmpresa.FirstOrDefault(v => v.IdEmpresa == Convert.ToInt32(cmb_empresa.EditValue));

                    //sucursal
                    ListInfoSucursal = new List<tb_Sucursal_Info>();
                    ListInfoSucursal = BusSucursal.Get_List_Sucursal(InfoEmpresa.IdEmpresa);
                    cmb_sucursal.Properties.DataSource = ListInfoSucursal;
                    InfoSucursal = ListInfoSucursal.FirstOrDefault();
                    cmb_sucursal.EditValue = InfoSucursal.IdSucursal;

                    //insttitucion

                    ListInfoInstitucion = new List<Aca_Institucion_Info>();
                    ListInfoInstitucion = BusInstitucion.Get_List_Institucion(InfoEmpresa.IdEmpresa);
                    InfoInstitucion = ListInfoInstitucion.FirstOrDefault();


                }

            }
            catch (Exception ex)
            {
                
                
            }
        }

        
    }
}

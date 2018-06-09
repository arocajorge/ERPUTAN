using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.Inventario_Cidersus;
using DevExpress.XtraPrinting;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_GrupoTrabajoMant : Form
    {
        prd_GrupoTrabajo_Info Info = new prd_GrupoTrabajo_Info();
        prd_GrupoTrabajo_Bus BusGT = new prd_GrupoTrabajo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;
        public FrmPrd_GrupoTrabajoMant()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        public void Get()
        {
            try
            {
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdSucursal = CmbSucursal.get_sucursal().IdSucursal;
                Info.IdGrupoTrabajo = Info.IdGrupoTrabajo;
                Info.Descripcion = TextNombreGrupo.Text;
                Info.AreaProduccion = txtareaProduccion.Text;
                Info.Fecha = DateTime.Now;
                Info.Estado = "A";
                Info.Usuario = param.IdUsuario;

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        public void Set(prd_GrupoTrabajo_Info info)
        {
            try
            {
                CmbSucursal.set_Idsucursal(info.IdSucursal);
                txtareaProduccion.Text = info.AreaProduccion;
                TextNombreGrupo.Text = info.Descripcion;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void SetAcciones(   Cl_Enumeradores.eTipo_action Acc)
        {
            try
            {
                Accion = Acc;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        public void Grabar()
        {
            try
            {
                Get();
                switch (Accion)
                {
                  case  Cl_Enumeradores.eTipo_action.grabar :

                        if (BusGT.GrabarCabeceraDB(Info))
                        {
                            MessageBox.Show("se grabo El Grupo trabajo " + TextNombreGrupo.Text);
                            ucGe_Menu.Enabled_btnGuardar = false;
                            ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                            
                        }
                        else
                        {
                            MessageBox.Show("No se grabo El Grupo trabajo "+TextNombreGrupo.Text);

                        }
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        if (BusGT.ModificarDB(Info))
                        {
                            MessageBox.Show("se actualizo El Grupo trabajo " + TextNombreGrupo.Text);
                            ucGe_Menu.Enabled_btnGuardar = false;
                            ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        }
                        else
                        {
                            MessageBox.Show("No se Actualizo El Grupo trabajo " + TextNombreGrupo.Text);

                        }
                        break;

                    default:
                       
                       
                        break;
                }

              

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}

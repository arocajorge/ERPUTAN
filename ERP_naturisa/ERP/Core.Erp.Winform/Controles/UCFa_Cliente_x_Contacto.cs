using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;

namespace Core.Erp.Winform.Controles
{
    public partial class UCFa_Cliente_x_Contacto : UserControl
    {
        #region "Variables Y Propiedades"

        string MensajeError = "";

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        tb_contacto_Info info_contacto = new tb_contacto_Info();
        tb_contacto_Bus Bus_contacto = new tb_contacto_Bus();
        BindingList<tb_contacto_Info> Bindign_List_contacto = new BindingList<tb_contacto_Info>();

        fa_cliente_contactos_Bus BusCliente_Contacto = new fa_cliente_contactos_Bus();
        fa_cliente_contactos_Info Info_clien_connt = new fa_cliente_contactos_Info();


        fa_Cliente_Info InfoCliente = new fa_Cliente_Info();

        #endregion
       
        public UCFa_Cliente_x_Contacto()
        {
            InitializeComponent();            
        }
     
        public void Set_Info_Cliente(fa_Cliente_Info _InfoCliente)
        {
            try
            {
                InfoCliente = _InfoCliente;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            
               
            }
        }

        #region "LLamar Formulario"

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {

                FrmGe_Contacto_Mant frm = new FrmGe_Contacto_Mant();
                frm.event_FormGe_Contacto_Mant_FormClosing += frm_event_FormGe_Contacto_Mant_FormClosing;
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    frm.set_Contacto(info_contacto);
                }
                frm.set_Accion(Accion);
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LLamar_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                FrmGe_Contacto_Cons frmc = new FrmGe_Contacto_Cons();
                frmc.event_FrmGe_Contacto_Cons_FormClosing += frmc_event_FrmGe_Contacto_Cons_FormClosing;
                frmc.set_Accion(Accion);
                frmc.ShowDialog();
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "eventos"

        void frmc_event_FrmGe_Contacto_Cons_FormClosing(object sender, FormClosingEventArgs e, tb_contacto_Info InfoContacto_out)
        {
            try
            {
                if (InfoContacto_out.IdContacto != 0)
                {                   
                    llenagrid(InfoContacto_out);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
       
        void frm_event_FormGe_Contacto_Mant_FormClosing(object sender, FormClosingEventArgs e, tb_contacto_Info InfoContacto_out)
        {
            try
            {
                if (InfoContacto_out.IdContacto != 0)
                {
                    llenagrid(InfoContacto_out);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        #endregion

        #region "CargarGrid"

        public void CargarGrid()
        {
            try
            {
                Bindign_List_contacto = new BindingList<tb_contacto_Info>(BusCliente_Contacto.Get_List_Contactos_x_Clientes(InfoCliente.IdEmpresa, InfoCliente.IdCliente));
                this.grcContacto.DataSource = Bindign_List_contacto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void llenagrid(tb_contacto_Info info_contacto)
        {
            try
            {
                int i = 0;
                i = Bindign_List_contacto.Where(v => v.IdContacto == info_contacto.IdContacto).Count();
                if (i == 0)
                {
                    Bindign_List_contacto.Add(info_contacto);
                }
                else
                {
                    MessageBox.Show("El contacto ya esta agregado en la lista, escoja otro", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.grcContacto.DataSource = Bindign_List_contacto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Botones"

        private void sbNuevo_Click(object sender, EventArgs e)
        {
            llama_frm(Cl_Enumeradores.eTipo_action.grabar);
        }

        private void sbBuscar_Click(object sender, EventArgs e)
        {
            LLamar_frm(Cl_Enumeradores.eTipo_action.consultar);
        }

        #endregion

        public List<fa_cliente_contactos_Info> Get_List_cliente_contactos()
        {
            try
            {
                List<fa_cliente_contactos_Info> lista = new List<fa_cliente_contactos_Info>();

                foreach (var item in Bindign_List_contacto)
                {
                    fa_cliente_contactos_Info Info_clien_cont = new fa_cliente_contactos_Info();
                    Info_clien_cont.IdEmpresa_cont = item.IdEmpresa;
                    Info_clien_cont.IdContacto = item.IdContacto;
                    Info_clien_cont.IdEmpresa_cli = InfoCliente.IdEmpresa;
                    Info_clien_cont.IdCliente = InfoCliente.IdCliente;
                    Info_clien_cont.observacion = "";
                    lista.Add(Info_clien_cont);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error comunicarse con Sistemas " + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<fa_cliente_contactos_Info>();
            }
        }

        public bool Buscar_cliente(ref string mensaje)
        {
            try
            {
                //bool existe = BusCliente_Contacto.ExisteCliente(param.IdEmpresa, InfoCliente.IdCliente, InfoCliente.IdContacto, ref MensajeError);
                bool existe = false;
                return existe;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void UCFa_Cliente_x_Contacto_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
    }
}

/*CLASE: frmRo_Nomina_Orden_Rubro_Cons
 *CREADO POR: ALBERTO MENA
 *FECHA: 25-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Nomina_Orden_Rubro_Mant : Form
    {
        public int oIdNominaTipo { get; set; }
        public int oIdNominaTipoLiqui { get; set; }
        public int oIdEmpresa { get; set; }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        

        //BUS
        ro_nomina_tipo_liqui_orden_Bus oRo_nomina_tipo_liqui_orden_Bus = new ro_nomina_tipo_liqui_orden_Bus();

        //INFO
        List<ro_nomina_tipo_liqui_orden_Info> oLstOrdenRubrosNomina_Info = new List<ro_nomina_tipo_liqui_orden_Info>();



        public frmRo_Nomina_Orden_Rubro_Mant()
        {
            InitializeComponent();
        }

        private void frmRo_Nomina_Orden_Rubro_Mant_Load(object sender, EventArgs e)
        {
            pu_CargaInicial();

        }


        private void pu_CargaInicial() { 
            try{
                oLstOrdenRubrosNomina_Info = new List<ro_nomina_tipo_liqui_orden_Info>();
                oLstOrdenRubrosNomina_Info = oRo_nomina_tipo_liqui_orden_Bus.Get_List_nomina_tipo_liqui_orden(oIdEmpresa, oIdNominaTipo, oIdNominaTipoLiqui);
                gridListado.DataSource = oLstOrdenRubrosNomina_Info;

            }catch (Exception ex){
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }       
        }

       
    }
}

/*CLASE: ro_Rdep_Detalle_Data
 *CREADO POR: ALBERTO MENA
 *FECHA: 05-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

using Core.Erp.Info.Roles;


namespace Core.Erp.Data.Roles
{
    public class ro_Rdep_Detalle_Data
    {
        string mensaje = "";

        public List<ro_Rdep_Detalle_Info> GetListPorId(int idEmpresa, decimal idEmpleado, int anioFiscal, ref string msg)
        {
            List<ro_Rdep_Detalle_Info> listado = new List<ro_Rdep_Detalle_Info>();

            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.ro_rdep_detalle where a.IdEmpresa == idEmpresa
                                 && a.IdEmpleado==idEmpleado && a.AnioFiscal==anioFiscal
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Rdep_Detalle_Info item = new ro_Rdep_Detalle_Info();

                        item.IdEmpresa = info.IdEmpresa;
                        item.IdEmpleado = info.IdEmpleado;
                        item.AnioFiscal= info.AnioFiscal;
                        item.Secuencia = info.Secuencia;
                        item.suelSal = info.suelSal.ToString();
                        item.sobSuelComRemu = info.sobSuelComRemu.ToString();
                        item.partUtil = info.partUtil.ToString();
                        item.intGrabGen = info.intGrabGen.ToString();
                        item.impRentEmpl = info.impRentEmpl.ToString();
                        item.decimTer = info.decimTer.ToString();
                        item.fondoReserva = info.fondoReserva.ToString();
                        item.salarioDigno = info.salarioDigno.ToString();
                        item.otrosIngRenGrav = info.otrosIngRenGrav.ToString();
                        item.ingGravConEsteEmpl = info.ingGravConEsteEmpl.ToString();
                        item.sisSalNet = info.sisSalNet.ToString();
                        item.apoPerIess = info.apoPerIess.ToString();
                        item.aporPerIessConOtrosEmpls = info.aporPerIessConOtrosEmpls.ToString();
                        item.deducVivienda = info.deducVivienda.ToString();
                        item.deducSalud = info.deducSalud.ToString();
                        item.deducEduca = info.deducEduca.ToString();
                        item.deducAliement = info.deducAliement.ToString();
                        item.deducVestim = info.deducVestim.ToString();
                        item.exoDiscap = info.exoDiscap.ToString();
                        item.exoTerEd = info.exoTerEd.ToString();
                        item.basImp = info.basImp.ToString();
                        item.impRentCaus = info.impRentCaus.ToString();
                        item.valRetAsuOtrosEmpls = info.valRetAsuOtrosEmpls.ToString();
                        item.valImpAsuEsteEmpl = info.valImpAsuEsteEmpl.ToString();
                        item.valRet = info.valRet.ToString();

                        item.UsuarioIngresa = info.UsuarioIngresa;
                        item.FechaIngresa = info.FechaIngresa;
                        item.UsuarioModifica = info.UsuarioModifica;
                        item.FechaModifica = info.FechaModifica;


                       
                        listado.Add(item);
                    }
                }

                return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje =msg= ex.InnerException + " " + ex.Message;
                return new List<ro_Rdep_Detalle_Info>();
            }
        }



        public Boolean GetExiste(ro_Rdep_Detalle_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_rdep_detalle
                                where a.IdEmpresa == info.IdEmpresa && a.IdEmpleado == info.IdEmpleado
                                && a.AnioFiscal == info.AnioFiscal && a.Secuencia == info.Secuencia
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = msg = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return false;
            }

        }

        public Boolean GuardarBD(ro_Rdep_Detalle_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {

                    ro_rdep_detalle item = new ro_rdep_detalle();

                    item.IdEmpresa = info.IdEmpresa;
                    item.IdEmpleado = info.IdEmpleado;
                    item.AnioFiscal = info.AnioFiscal;
                    item.Secuencia = info.Secuencia;
                    item.suelSal = Convert.ToDouble(info.suelSal);
                    item.sobSuelComRemu = Convert.ToDouble(info.sobSuelComRemu);
                    item.partUtil = Convert.ToDouble(info.partUtil);
                    item.intGrabGen = Convert.ToDouble(info.intGrabGen);
                    item.impRentEmpl = Convert.ToDouble(info.impRentEmpl);
                    item.decimTer = Convert.ToDouble(info.decimTer);
                    item.fondoReserva = Convert.ToDouble(info.fondoReserva);
                    item.salarioDigno = Convert.ToDouble(info.salarioDigno);
                    item.otrosIngRenGrav = Convert.ToDouble(info.otrosIngRenGrav);
                    item.ingGravConEsteEmpl = Convert.ToDouble(info.ingGravConEsteEmpl);
                    item.sisSalNet = Convert.ToDouble(info.sisSalNet);
                    item.apoPerIess = Convert.ToDouble(info.apoPerIess);
                    item.aporPerIessConOtrosEmpls = Convert.ToDouble(info.aporPerIessConOtrosEmpls);
                    item.deducVivienda = Convert.ToDouble(info.deducVivienda);
                    item.deducSalud = Convert.ToDouble(info.deducSalud);
                    item.deducEduca = Convert.ToDouble(info.deducEduca);
                    item.deducAliement = Convert.ToDouble(info.deducAliement);
                    item.deducVestim = Convert.ToDouble(info.deducVestim);
                    item.exoDiscap = Convert.ToDouble(info.exoDiscap);
                    item.exoTerEd = Convert.ToDouble(info.exoTerEd);
                    item.basImp = Convert.ToDouble(info.basImp);
                    item.impRentCaus = Convert.ToDouble(info.impRentCaus);
                    item.valRetAsuOtrosEmpls = Convert.ToDouble(info.valRetAsuOtrosEmpls);
                    item.valImpAsuEsteEmpl = Convert.ToDouble(info.valImpAsuEsteEmpl);
                    item.valRet = Convert.ToDouble(info.valRet);

                    item.UsuarioIngresa = info.UsuarioIngresa;
                    item.FechaIngresa = info.FechaIngresa;
                    item.UsuarioModifica = info.UsuarioModifica;
                    item.FechaModifica = info.FechaModifica;

                    db.ro_rdep_detalle.AddObject(item);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return false;
            }
        }


        public Boolean ModificarBD(ro_Rdep_Detalle_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {

                    ro_rdep_detalle item = (from a in db.ro_rdep_detalle
                                            where a.IdEmpresa==info.IdEmpresa && a.IdEmpleado==info.IdEmpleado
                                            && a.AnioFiscal==info.AnioFiscal && a.Secuencia==info.Secuencia
                                            select a).FirstOrDefault();

                    //item.IdEmpresa = info.IdEmpresa;
                    //item.IdEmpleado = info.IdEmpleado;
                    //item.AnioFiscal = info.AnioFiscal;
                    //item.Secuencia = info.Secuencia;
                    item.suelSal = Convert.ToDouble(info.suelSal);
                    item.sobSuelComRemu = Convert.ToDouble(info.sobSuelComRemu);
                    item.partUtil = Convert.ToDouble(info.partUtil);
                    item.intGrabGen = Convert.ToDouble(info.intGrabGen);
                    item.impRentEmpl = Convert.ToDouble(info.impRentEmpl);
                    item.decimTer = Convert.ToDouble(info.decimTer);
                    item.fondoReserva = Convert.ToDouble(info.fondoReserva);
                    item.salarioDigno = Convert.ToDouble(info.salarioDigno);
                    item.otrosIngRenGrav = Convert.ToDouble(info.otrosIngRenGrav);
                    item.ingGravConEsteEmpl = Convert.ToDouble(info.ingGravConEsteEmpl);
                    item.sisSalNet = Convert.ToDouble(info.sisSalNet);
                    item.apoPerIess = Convert.ToDouble(info.apoPerIess);
                    item.aporPerIessConOtrosEmpls = Convert.ToDouble(info.aporPerIessConOtrosEmpls);
                    item.deducVivienda = Convert.ToDouble(info.deducVivienda);
                    item.deducSalud = Convert.ToDouble(info.deducSalud);
                    item.deducEduca = Convert.ToDouble(info.deducEduca);
                    item.deducAliement = Convert.ToDouble(info.deducAliement);
                    item.deducVestim = Convert.ToDouble(info.deducVestim);
                    item.exoDiscap = Convert.ToDouble(info.exoDiscap);
                    item.exoTerEd = Convert.ToDouble(info.exoTerEd);
                    item.basImp = Convert.ToDouble(info.basImp);
                    item.impRentCaus = Convert.ToDouble(info.impRentCaus);
                    item.valRetAsuOtrosEmpls = Convert.ToDouble(info.valRetAsuOtrosEmpls);
                    item.valImpAsuEsteEmpl = Convert.ToDouble(info.valImpAsuEsteEmpl);
                    item.valRet = Convert.ToDouble(info.valRet);

                    //item.UsuarioIngresa = info.UsuarioIngresa;
                    //item.FechaIngresa = info.FechaIngresa;
                    item.UsuarioModifica = info.UsuarioModifica;
                    item.FechaModifica = info.FechaModifica;

                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return false;
            }
        }


        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, int anioFiscal, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.ExecuteStoreCommand("delete from dbo.ro_rdep_detalle where IdEmpresa =" + idEmpresa.ToString()
                       + " AND IdEmpleado=" + idEmpleado.ToString()
                       + " AND AnioFiscal=" + anioFiscal.ToString()                     
                       );
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = msg = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return false;
            }

        }





    }
}

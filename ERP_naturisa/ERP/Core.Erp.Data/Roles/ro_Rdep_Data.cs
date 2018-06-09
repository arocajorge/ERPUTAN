/*CLASE: ro_Rdep_Data
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
    public class ro_Rdep_Data
    {
        string mensaje = "";

        public List<ro_Rdep_Info> GetListGeneral(int idEmpresa, ref string msg)
        {
            List<ro_Rdep_Info> listado = new List<ro_Rdep_Info>();

            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwRo_Rdep_x_Empleado
                                 where a.IdEmpresa == idEmpresa
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Rdep_Info item = new ro_Rdep_Info();

                        item.IdEmpresa = info.IdEmpresa;
                        item.IdEmpleado = info.IdEmpleado;
                        item.AnioFiscal = info.AnioFiscal;
                        item.Observacion = info.Observacion;
                        item.Estado = info.Estado;
                        item.suelSal = info.suelSal.ToString();
                        item.sobSuelComRemu = info.sobSuelComRemu.ToString();
                        item.partUtil = info.partUtil.ToString();
                        item.intGrabGen = info.intGrabGen.ToString();
                        item.impRentEmpl = info.impRentEmpl.ToString();
                        item.decimTer = info.decimTer.ToString();
                        item.decimCuar = info.decimCuar.ToString();
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
                        item.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        item.Fecha_UltAnu = info.Fecha_UltAnu;
                        item.MotiAnula = info.MotiAnula;
 

                        //VISTA
                        item.Cargo = info.cargo;
                        item.Departamento = info.departamento;
                        item.EstadoEmpleado = info.EstadoEmpleado;
                        item.Apellido = info.Apellido;
                        item.Nombre = info.Nombre;
                        item.StatusEmpleado = info.StatusEmpleado;
                        item.NomCompleto = info.NomCompleto;
                        item.CedulaRuc = info.CedulaRuc;
                        
                        listado.Add(item);
                    }
                }

                return listado;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public ro_Rdep_Info GetInfoPorEmpleado(int idEmpresa, decimal idEmpleado, int anioFiscal, ref string msg)
        {
            //<ro_Rdep_Info> listado = new List<ro_Rdep_Info>();
            ro_Rdep_Info item = new ro_Rdep_Info();

            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwRo_Rdep_x_Empleado
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdEmpleado==idEmpleado
                                 && a.AnioFiscal == anioFiscal
                                 select a);

                    foreach (var info in datos)
                    {
                        
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdEmpleado = info.IdEmpleado;
                        item.AnioFiscal = info.AnioFiscal;
                        item.Observacion = info.Observacion;
                        item.Estado = info.Estado;
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
                        item.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        item.Fecha_UltAnu = info.Fecha_UltAnu;
                        item.MotiAnula = info.MotiAnula;
 
                        //VISTA
                        item.Cargo = info.cargo;
                        item.Departamento = info.departamento;
                        item.EstadoEmpleado = info.EstadoEmpleado;
                        item.Apellido = info.Apellido;
                        item.Nombre = info.Nombre;
                        item.StatusEmpleado = info.StatusEmpleado;
                        item.NomCompleto = info.NomCompleto;
                        item.CedulaRuc = info.CedulaRuc;

                        //listado.Add(item);
                    }
                }

                return item;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public Boolean GetExiste(ro_Rdep_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_rdep
                                where a.IdEmpresa == info.IdEmpresa && a.IdEmpleado == info.IdEmpleado
                                && a.AnioFiscal == info.AnioFiscal
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }




        public Boolean GuardarBD(ro_Rdep_Info info, ref string msg)
        {
           

            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {

                        ro_rdep item = new ro_rdep();

                        item.IdEmpresa = info.IdEmpresa;
                        item.IdEmpleado = info.IdEmpleado;
                        item.AnioFiscal = info.AnioFiscal;
                        item.Observacion = info.Observacion;
                        item.Estado = info.Estado;

                        item.AnioFiscal = info.AnioFiscal;
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
                        item.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        item.Fecha_UltAnu = info.Fecha_UltAnu;
                        item.MotiAnula = info.MotiAnula;
 

                        db.ro_rdep.Add(item);
                        db.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarBD(ro_Rdep_Info info, ref string msg)
        {

            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {

                    ro_rdep item = (from a in db.ro_rdep
                                   where a.IdEmpresa==info.IdEmpresa && a.IdEmpleado==info.IdEmpleado 
                                   && a.AnioFiscal==info.AnioFiscal
                                   select a).FirstOrDefault();
     
                    item.Observacion = info.Observacion;
                    item.Estado = info.Estado;
     
                    item.suelSal = Convert.ToDouble(info.suelSal);
                    item.sobSuelComRemu = Convert.ToDouble(info.sobSuelComRemu);
                    item.partUtil = Convert.ToDouble(info.partUtil);
                    item.intGrabGen = Convert.ToDouble(info.intGrabGen);
                    item.impRentEmpl = Convert.ToDouble(info.impRentEmpl);
                    item.decimTer = Convert.ToDouble(info.decimTer);
                    item.decimCuar = Convert.ToDouble(info.decimCuar);
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

                    item.UsuarioModifica = info.UsuarioModifica;
                    item.FechaModifica = info.FechaModifica;
                    item.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                    item.Fecha_UltAnu = info.Fecha_UltAnu;
                    item.MotiAnula = info.MotiAnula;
 
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}

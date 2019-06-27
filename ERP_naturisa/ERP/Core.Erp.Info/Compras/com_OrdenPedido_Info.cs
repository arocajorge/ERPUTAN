﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Compras
{
    public class com_OrdenPedido_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenPedido { get; set; }
        public string op_Codigo { get; set; }
        public System.DateTime op_Fecha { get; set; }
        public string op_Observacion { get; set; }
        public decimal IdDepartamento { get; set; }
        public decimal IdSolicitante { get; set; }
        public string IdCatalogoEstado { get; set; }
        public bool Estado { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public string MotivoAnu { get; set; }

        #region Campos que no existen en la tabla
        public string nom_departamento { get; set; }
        public string nom_solicitante { get; set; }
        public string CatalogoEstado { get; set; }
        public List<com_OrdenPedidoDet_Info> ListaDetalle { get; set; }
        #endregion

        public bool EsCompraUrgente { get; set; }

        public string nom_punto_cargo { get; set; }

        public int? IdPunto_cargo { get; set; }
    }
}
﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18063
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="desarrollo")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Definiciones de métodos de extensibilidad
  partial void OnCreated();
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["desarrolloConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<copia> copia
	{
		get
		{
			return this.GetTable<copia>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.copia")]
public partial class copia
{
	
	private long _cedulasociado;
	
	private string _codnit;
	
	private string _codempresa;
	
	private string _coddependencia;
	
	private System.Nullable<char> _periododeduce;
	
	private System.Nullable<System.DateTime> _fechanacimiento;
	
	private System.Nullable<char> _deduceocacional;
	
	private System.Nullable<char> _sexo;
	
	private System.Nullable<char> _estudios;
	
	private string _codprofesion;
	
	private string _estadocivil;
	
	private string _nroacta;
	
	private System.Nullable<System.DateTime> _fechaacta;
	
	private decimal _salario;
	
	private string _codempresalabora;
	
	private System.Nullable<System.DateTime> _fechaingresoLabora;
	
	private string _tipocontrato;
	
	private System.Nullable<System.DateTime> _fechaterminacontrato;
	
	private string _cargo;
	
	private string _codbanco;
	
	private string _numerocuenta;
	
	private int _agencia;
	
	private long _codanalista;
	
	private string _rutaanalista;
	
	private System.Nullable<char> _tipocuenta;
	
	private char _estado;
	
	private System.Nullable<System.DateTime> _ultimaactualizacion;
	
	private string _operadoractualizo;
	
	private string _paisnace;
	
	private string _dptonace;
	
	private string _ciudadnace;
	
	private long _idnits;
	
	private System.Nullable<short> _idtipovivienda;
	
	private System.Nullable<byte> _szin;
	
	private System.Nullable<short> _idtiposalario;
	
	private System.Nullable<char> _tipopacto;
	
	private System.Nullable<byte> _web;
	
	private decimal _idasociados;
	
	private string _codigotipo;
	
	public copia()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cedulasociado", DbType="BigInt NOT NULL")]
	public long cedulasociado
	{
		get
		{
			return this._cedulasociado;
		}
		set
		{
			if ((this._cedulasociado != value))
			{
				this._cedulasociado = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codnit", DbType="VarChar(15)")]
	public string codnit
	{
		get
		{
			return this._codnit;
		}
		set
		{
			if ((this._codnit != value))
			{
				this._codnit = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codempresa", DbType="Char(10)")]
	public string codempresa
	{
		get
		{
			return this._codempresa;
		}
		set
		{
			if ((this._codempresa != value))
			{
				this._codempresa = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_coddependencia", DbType="Char(10)")]
	public string coddependencia
	{
		get
		{
			return this._coddependencia;
		}
		set
		{
			if ((this._coddependencia != value))
			{
				this._coddependencia = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_periododeduce", DbType="Char(1)")]
	public System.Nullable<char> periododeduce
	{
		get
		{
			return this._periododeduce;
		}
		set
		{
			if ((this._periododeduce != value))
			{
				this._periododeduce = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechanacimiento", DbType="DateTime")]
	public System.Nullable<System.DateTime> fechanacimiento
	{
		get
		{
			return this._fechanacimiento;
		}
		set
		{
			if ((this._fechanacimiento != value))
			{
				this._fechanacimiento = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_deduceocacional", DbType="Char(1)")]
	public System.Nullable<char> deduceocacional
	{
		get
		{
			return this._deduceocacional;
		}
		set
		{
			if ((this._deduceocacional != value))
			{
				this._deduceocacional = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sexo", DbType="Char(1)")]
	public System.Nullable<char> sexo
	{
		get
		{
			return this._sexo;
		}
		set
		{
			if ((this._sexo != value))
			{
				this._sexo = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estudios", DbType="Char(1)")]
	public System.Nullable<char> estudios
	{
		get
		{
			return this._estudios;
		}
		set
		{
			if ((this._estudios != value))
			{
				this._estudios = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codprofesion", DbType="Char(4)")]
	public string codprofesion
	{
		get
		{
			return this._codprofesion;
		}
		set
		{
			if ((this._codprofesion != value))
			{
				this._codprofesion = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estadocivil", DbType="Char(2)")]
	public string estadocivil
	{
		get
		{
			return this._estadocivil;
		}
		set
		{
			if ((this._estadocivil != value))
			{
				this._estadocivil = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nroacta", DbType="Char(10)")]
	public string nroacta
	{
		get
		{
			return this._nroacta;
		}
		set
		{
			if ((this._nroacta != value))
			{
				this._nroacta = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaacta", DbType="DateTime")]
	public System.Nullable<System.DateTime> fechaacta
	{
		get
		{
			return this._fechaacta;
		}
		set
		{
			if ((this._fechaacta != value))
			{
				this._fechaacta = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salario", DbType="Decimal(18,0) NOT NULL")]
	public decimal salario
	{
		get
		{
			return this._salario;
		}
		set
		{
			if ((this._salario != value))
			{
				this._salario = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codempresalabora", DbType="Char(12)")]
	public string codempresalabora
	{
		get
		{
			return this._codempresalabora;
		}
		set
		{
			if ((this._codempresalabora != value))
			{
				this._codempresalabora = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaingresoLabora", DbType="DateTime")]
	public System.Nullable<System.DateTime> fechaingresoLabora
	{
		get
		{
			return this._fechaingresoLabora;
		}
		set
		{
			if ((this._fechaingresoLabora != value))
			{
				this._fechaingresoLabora = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipocontrato", DbType="Char(3)")]
	public string tipocontrato
	{
		get
		{
			return this._tipocontrato;
		}
		set
		{
			if ((this._tipocontrato != value))
			{
				this._tipocontrato = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fechaterminacontrato", DbType="DateTime")]
	public System.Nullable<System.DateTime> fechaterminacontrato
	{
		get
		{
			return this._fechaterminacontrato;
		}
		set
		{
			if ((this._fechaterminacontrato != value))
			{
				this._fechaterminacontrato = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cargo", DbType="Char(4)")]
	public string cargo
	{
		get
		{
			return this._cargo;
		}
		set
		{
			if ((this._cargo != value))
			{
				this._cargo = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codbanco", DbType="Char(4)")]
	public string codbanco
	{
		get
		{
			return this._codbanco;
		}
		set
		{
			if ((this._codbanco != value))
			{
				this._codbanco = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numerocuenta", DbType="VarChar(20)")]
	public string numerocuenta
	{
		get
		{
			return this._numerocuenta;
		}
		set
		{
			if ((this._numerocuenta != value))
			{
				this._numerocuenta = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_agencia", DbType="Int NOT NULL")]
	public int agencia
	{
		get
		{
			return this._agencia;
		}
		set
		{
			if ((this._agencia != value))
			{
				this._agencia = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codanalista", DbType="BigInt NOT NULL")]
	public long codanalista
	{
		get
		{
			return this._codanalista;
		}
		set
		{
			if ((this._codanalista != value))
			{
				this._codanalista = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rutaanalista", DbType="Char(4) NOT NULL", CanBeNull=false)]
	public string rutaanalista
	{
		get
		{
			return this._rutaanalista;
		}
		set
		{
			if ((this._rutaanalista != value))
			{
				this._rutaanalista = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipocuenta", DbType="Char(1)")]
	public System.Nullable<char> tipocuenta
	{
		get
		{
			return this._tipocuenta;
		}
		set
		{
			if ((this._tipocuenta != value))
			{
				this._tipocuenta = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado", DbType="Char(1) NOT NULL")]
	public char estado
	{
		get
		{
			return this._estado;
		}
		set
		{
			if ((this._estado != value))
			{
				this._estado = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ultimaactualizacion", DbType="DateTime")]
	public System.Nullable<System.DateTime> ultimaactualizacion
	{
		get
		{
			return this._ultimaactualizacion;
		}
		set
		{
			if ((this._ultimaactualizacion != value))
			{
				this._ultimaactualizacion = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_operadoractualizo", DbType="VarChar(4)")]
	public string operadoractualizo
	{
		get
		{
			return this._operadoractualizo;
		}
		set
		{
			if ((this._operadoractualizo != value))
			{
				this._operadoractualizo = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_paisnace", DbType="Char(3)")]
	public string paisnace
	{
		get
		{
			return this._paisnace;
		}
		set
		{
			if ((this._paisnace != value))
			{
				this._paisnace = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dptonace", DbType="Char(2)")]
	public string dptonace
	{
		get
		{
			return this._dptonace;
		}
		set
		{
			if ((this._dptonace != value))
			{
				this._dptonace = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ciudadnace", DbType="Char(5)")]
	public string ciudadnace
	{
		get
		{
			return this._ciudadnace;
		}
		set
		{
			if ((this._ciudadnace != value))
			{
				this._ciudadnace = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idnits", DbType="BigInt NOT NULL")]
	public long idnits
	{
		get
		{
			return this._idnits;
		}
		set
		{
			if ((this._idnits != value))
			{
				this._idnits = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idtipovivienda", DbType="SmallInt")]
	public System.Nullable<short> idtipovivienda
	{
		get
		{
			return this._idtipovivienda;
		}
		set
		{
			if ((this._idtipovivienda != value))
			{
				this._idtipovivienda = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_szin", DbType="TinyInt")]
	public System.Nullable<byte> szin
	{
		get
		{
			return this._szin;
		}
		set
		{
			if ((this._szin != value))
			{
				this._szin = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idtiposalario", DbType="SmallInt")]
	public System.Nullable<short> idtiposalario
	{
		get
		{
			return this._idtiposalario;
		}
		set
		{
			if ((this._idtiposalario != value))
			{
				this._idtiposalario = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipopacto", DbType="Char(1)")]
	public System.Nullable<char> tipopacto
	{
		get
		{
			return this._tipopacto;
		}
		set
		{
			if ((this._tipopacto != value))
			{
				this._tipopacto = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_web", DbType="TinyInt")]
	public System.Nullable<byte> web
	{
		get
		{
			return this._web;
		}
		set
		{
			if ((this._web != value))
			{
				this._web = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idasociados", AutoSync=AutoSync.Always, DbType="Decimal(18,0) NOT NULL IDENTITY", IsDbGenerated=true)]
	public decimal idasociados
	{
		get
		{
			return this._idasociados;
		}
		set
		{
			if ((this._idasociados != value))
			{
				this._idasociados = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigotipo", DbType="Char(2)")]
	public string codigotipo
	{
		get
		{
			return this._codigotipo;
		}
		set
		{
			if ((this._codigotipo != value))
			{
				this._codigotipo = value;
			}
		}
	}
}
#pragma warning restore 1591

﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Data_KTDL")]
	public partial class Data_KTDLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public Data_KTDLDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Data_KTDLConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Data_KTDLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Data_KTDLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Data_KTDLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Data_KTDLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CNPM> CNPMs
		{
			get
			{
				return this.GetTable<CNPM>();
			}
		}
		
		public System.Data.Linq.Table<HTTT> HTTTs
		{
			get
			{
				return this.GetTable<HTTT>();
			}
		}
		
		public System.Data.Linq.Table<KHPTDL> KHPTDLs
		{
			get
			{
				return this.GetTable<KHPTDL>();
			}
		}
		
		public System.Data.Linq.Table<MMT> MMTs
		{
			get
			{
				return this.GetTable<MMT>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CNPM")]
	public partial class CNPM
	{
		
		private System.Nullable<double> _NMLT_LT;
		
		private System.Nullable<double> _NMLT_TH;
		
		private System.Nullable<double> _LTHDT_LT;
		
		private System.Nullable<double> _LTHDT_TH;
		
		private System.Nullable<double> _CTDL_LT;
		
		private System.Nullable<double> _CTDL_TH;
		
		public CNPM()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NMLT_LT", DbType="Float")]
		public System.Nullable<double> NMLT_LT
		{
			get
			{
				return this._NMLT_LT;
			}
			set
			{
				if ((this._NMLT_LT != value))
				{
					this._NMLT_LT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NMLT_TH", DbType="Float")]
		public System.Nullable<double> NMLT_TH
		{
			get
			{
				return this._NMLT_TH;
			}
			set
			{
				if ((this._NMLT_TH != value))
				{
					this._NMLT_TH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LTHDT_LT", DbType="Float")]
		public System.Nullable<double> LTHDT_LT
		{
			get
			{
				return this._LTHDT_LT;
			}
			set
			{
				if ((this._LTHDT_LT != value))
				{
					this._LTHDT_LT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LTHDT_TH", DbType="Float")]
		public System.Nullable<double> LTHDT_TH
		{
			get
			{
				return this._LTHDT_TH;
			}
			set
			{
				if ((this._LTHDT_TH != value))
				{
					this._LTHDT_TH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTDL_LT", DbType="Float")]
		public System.Nullable<double> CTDL_LT
		{
			get
			{
				return this._CTDL_LT;
			}
			set
			{
				if ((this._CTDL_LT != value))
				{
					this._CTDL_LT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTDL_TH", DbType="Float")]
		public System.Nullable<double> CTDL_TH
		{
			get
			{
				return this._CTDL_TH;
			}
			set
			{
				if ((this._CTDL_TH != value))
				{
					this._CTDL_TH = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HTTT")]
	public partial class HTTT
	{
		
		private System.Nullable<double> _NMLT_LT;
		
		private System.Nullable<double> _NMLT_TH;
		
		private System.Nullable<double> _CSDL_LT;
		
		private System.Nullable<double> _CSDL_TH;
		
		private System.Nullable<double> _HQTCSDL;
		
		public HTTT()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NMLT_LT", DbType="Float")]
		public System.Nullable<double> NMLT_LT
		{
			get
			{
				return this._NMLT_LT;
			}
			set
			{
				if ((this._NMLT_LT != value))
				{
					this._NMLT_LT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NMLT_TH", DbType="Float")]
		public System.Nullable<double> NMLT_TH
		{
			get
			{
				return this._NMLT_TH;
			}
			set
			{
				if ((this._NMLT_TH != value))
				{
					this._NMLT_TH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CSDL_LT", DbType="Float")]
		public System.Nullable<double> CSDL_LT
		{
			get
			{
				return this._CSDL_LT;
			}
			set
			{
				if ((this._CSDL_LT != value))
				{
					this._CSDL_LT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CSDL_TH", DbType="Float")]
		public System.Nullable<double> CSDL_TH
		{
			get
			{
				return this._CSDL_TH;
			}
			set
			{
				if ((this._CSDL_TH != value))
				{
					this._CSDL_TH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HQTCSDL", DbType="Float")]
		public System.Nullable<double> HQTCSDL
		{
			get
			{
				return this._HQTCSDL;
			}
			set
			{
				if ((this._HQTCSDL != value))
				{
					this._HQTCSDL = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHPTDL")]
	public partial class KHPTDL
	{
		
		private System.Nullable<double> _CTDLGT_LT;
		
		private System.Nullable<double> _CTDLGT_TH;
		
		private System.Nullable<double> _CSDL_LT;
		
		private System.Nullable<double> _CSDL_TH;
		
		private System.Nullable<double> _TTNT;
		
		public KHPTDL()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTDLGT_LT", DbType="Float")]
		public System.Nullable<double> CTDLGT_LT
		{
			get
			{
				return this._CTDLGT_LT;
			}
			set
			{
				if ((this._CTDLGT_LT != value))
				{
					this._CTDLGT_LT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CTDLGT_TH", DbType="Float")]
		public System.Nullable<double> CTDLGT_TH
		{
			get
			{
				return this._CTDLGT_TH;
			}
			set
			{
				if ((this._CTDLGT_TH != value))
				{
					this._CTDLGT_TH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CSDL_LT", DbType="Float")]
		public System.Nullable<double> CSDL_LT
		{
			get
			{
				return this._CSDL_LT;
			}
			set
			{
				if ((this._CSDL_LT != value))
				{
					this._CSDL_LT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CSDL_TH", DbType="Float")]
		public System.Nullable<double> CSDL_TH
		{
			get
			{
				return this._CSDL_TH;
			}
			set
			{
				if ((this._CSDL_TH != value))
				{
					this._CSDL_TH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TTNT", DbType="Float")]
		public System.Nullable<double> TTNT
		{
			get
			{
				return this._TTNT;
			}
			set
			{
				if ((this._TTNT != value))
				{
					this._TTNT = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MMT")]
	public partial class MMT
	{
		
		private System.Nullable<double> _NMLT_LT;
		
		private System.Nullable<double> _NMLT_TH;
		
		private System.Nullable<double> _HDH;
		
		private System.Nullable<double> _MMT_LT;
		
		private System.Nullable<double> _MMT_TH;
		
		public MMT()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NMLT_LT", DbType="Float")]
		public System.Nullable<double> NMLT_LT
		{
			get
			{
				return this._NMLT_LT;
			}
			set
			{
				if ((this._NMLT_LT != value))
				{
					this._NMLT_LT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NMLT_TH", DbType="Float")]
		public System.Nullable<double> NMLT_TH
		{
			get
			{
				return this._NMLT_TH;
			}
			set
			{
				if ((this._NMLT_TH != value))
				{
					this._NMLT_TH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HDH", DbType="Float")]
		public System.Nullable<double> HDH
		{
			get
			{
				return this._HDH;
			}
			set
			{
				if ((this._HDH != value))
				{
					this._HDH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MMT_LT", DbType="Float")]
		public System.Nullable<double> MMT_LT
		{
			get
			{
				return this._MMT_LT;
			}
			set
			{
				if ((this._MMT_LT != value))
				{
					this._MMT_LT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MMT_TH", DbType="Float")]
		public System.Nullable<double> MMT_TH
		{
			get
			{
				return this._MMT_TH;
			}
			set
			{
				if ((this._MMT_TH != value))
				{
					this._MMT_TH = value;
				}
			}
		}
	}
}
#pragma warning restore 1591

/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace DAL
{
	public abstract class _Region : SqlClientEntity
	{
		public _Region()
		{
			this.QuerySource = "Region";
			this.MappingName = "Region";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_RegionLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ID, ID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_RegionLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ID
			{
				get
				{
					return new SqlParameter("@ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter RegionName
			{
				get
				{
					return new SqlParameter("@RegionName", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter RegionCode
			{
				get
				{
					return new SqlParameter("@RegionCode", SqlDbType.VarChar, 50);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string RegionName = "RegionName";
            public const string RegionCode = "RegionCode";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _Region.PropertyNames.ID;
					ht[RegionName] = _Region.PropertyNames.RegionName;
					ht[RegionCode] = _Region.PropertyNames.RegionCode;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ID = "ID";
            public const string RegionName = "RegionName";
            public const string RegionCode = "RegionCode";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _Region.ColumnNames.ID;
					ht[RegionName] = _Region.ColumnNames.RegionName;
					ht[RegionCode] = _Region.ColumnNames.RegionCode;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ID = "s_ID";
            public const string RegionName = "s_RegionName";
            public const string RegionCode = "s_RegionCode";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ID
	    {
			get
	        {
				return base.Getint(ColumnNames.ID);
			}
			set
	        {
				base.Setint(ColumnNames.ID, value);
			}
		}

		public virtual string RegionName
	    {
			get
	        {
				return base.Getstring(ColumnNames.RegionName);
			}
			set
	        {
				base.Setstring(ColumnNames.RegionName, value);
			}
		}

		public virtual string RegionCode
	    {
			get
	        {
				return base.Getstring(ColumnNames.RegionCode);
			}
			set
	        {
				base.Setstring(ColumnNames.RegionCode, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ID) ? string.Empty : base.GetintAsString(ColumnNames.ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ID);
				else
					this.ID = base.SetintAsString(ColumnNames.ID, value);
			}
		}

		public virtual string s_RegionName
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.RegionName) ? string.Empty : base.GetstringAsString(ColumnNames.RegionName);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.RegionName);
				else
					this.RegionName = base.SetstringAsString(ColumnNames.RegionName, value);
			}
		}

		public virtual string s_RegionCode
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.RegionCode) ? string.Empty : base.GetstringAsString(ColumnNames.RegionCode);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.RegionCode);
				else
					this.RegionCode = base.SetstringAsString(ColumnNames.RegionCode, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter RegionName
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.RegionName, Parameters.RegionName);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter RegionCode
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.RegionCode, Parameters.RegionCode);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ID
		    {
				get
		        {
					if(_ID_W == null)
	        	    {
						_ID_W = TearOff.ID;
					}
					return _ID_W;
				}
			}

			public WhereParameter RegionName
		    {
				get
		        {
					if(_RegionName_W == null)
	        	    {
						_RegionName_W = TearOff.RegionName;
					}
					return _RegionName_W;
				}
			}

			public WhereParameter RegionCode
		    {
				get
		        {
					if(_RegionCode_W == null)
	        	    {
						_RegionCode_W = TearOff.RegionCode;
					}
					return _RegionCode_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _RegionName_W = null;
			private WhereParameter _RegionCode_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_RegionName_W = null;
				_RegionCode_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter RegionName
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.RegionName, Parameters.RegionName);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter RegionCode
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.RegionCode, Parameters.RegionCode);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ID
		    {
				get
		        {
					if(_ID_W == null)
	        	    {
						_ID_W = TearOff.ID;
					}
					return _ID_W;
				}
			}

			public AggregateParameter RegionName
		    {
				get
		        {
					if(_RegionName_W == null)
	        	    {
						_RegionName_W = TearOff.RegionName;
					}
					return _RegionName_W;
				}
			}

			public AggregateParameter RegionCode
		    {
				get
		        {
					if(_RegionCode_W == null)
	        	    {
						_RegionCode_W = TearOff.RegionCode;
					}
					return _RegionCode_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _RegionName_W = null;
			private AggregateParameter _RegionCode_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_RegionName_W = null;
				_RegionCode_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_RegionInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_RegionUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_RegionDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.RegionName);
			p.SourceColumn = ColumnNames.RegionName;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.RegionCode);
			p.SourceColumn = ColumnNames.RegionCode;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}

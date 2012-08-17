
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
	public abstract class _Pallet : SqlClientEntity
	{
		public _Pallet()
		{
			this.QuerySource = "Pallet";
			this.MappingName = "Pallet";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PalletLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_PalletLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter PalletNo
			{
				get
				{
					return new SqlParameter("@PalletNo", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter StorageTypeID
			{
				get
				{
					return new SqlParameter("@StorageTypeID", SqlDbType.Int, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string PalletNo = "PalletNo";
            public const string StorageTypeID = "StorageTypeID";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _Pallet.PropertyNames.ID;
					ht[PalletNo] = _Pallet.PropertyNames.PalletNo;
					ht[StorageTypeID] = _Pallet.PropertyNames.StorageTypeID;

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
            public const string PalletNo = "PalletNo";
            public const string StorageTypeID = "StorageTypeID";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _Pallet.ColumnNames.ID;
					ht[PalletNo] = _Pallet.ColumnNames.PalletNo;
					ht[StorageTypeID] = _Pallet.ColumnNames.StorageTypeID;

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
            public const string PalletNo = "s_PalletNo";
            public const string StorageTypeID = "s_StorageTypeID";

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

		public virtual int PalletNo
	    {
			get
	        {
				return base.Getint(ColumnNames.PalletNo);
			}
			set
	        {
				base.Setint(ColumnNames.PalletNo, value);
			}
		}

		public virtual int StorageTypeID
	    {
			get
	        {
				return base.Getint(ColumnNames.StorageTypeID);
			}
			set
	        {
				base.Setint(ColumnNames.StorageTypeID, value);
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

		public virtual string s_PalletNo
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PalletNo) ? string.Empty : base.GetintAsString(ColumnNames.PalletNo);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PalletNo);
				else
					this.PalletNo = base.SetintAsString(ColumnNames.PalletNo, value);
			}
		}

		public virtual string s_StorageTypeID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.StorageTypeID) ? string.Empty : base.GetintAsString(ColumnNames.StorageTypeID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.StorageTypeID);
				else
					this.StorageTypeID = base.SetintAsString(ColumnNames.StorageTypeID, value);
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

				public WhereParameter PalletNo
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PalletNo, Parameters.PalletNo);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter StorageTypeID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.StorageTypeID, Parameters.StorageTypeID);
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

			public WhereParameter PalletNo
		    {
				get
		        {
					if(_PalletNo_W == null)
	        	    {
						_PalletNo_W = TearOff.PalletNo;
					}
					return _PalletNo_W;
				}
			}

			public WhereParameter StorageTypeID
		    {
				get
		        {
					if(_StorageTypeID_W == null)
	        	    {
						_StorageTypeID_W = TearOff.StorageTypeID;
					}
					return _StorageTypeID_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _PalletNo_W = null;
			private WhereParameter _StorageTypeID_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_PalletNo_W = null;
				_StorageTypeID_W = null;

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

				public AggregateParameter PalletNo
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PalletNo, Parameters.PalletNo);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter StorageTypeID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.StorageTypeID, Parameters.StorageTypeID);
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

			public AggregateParameter PalletNo
		    {
				get
		        {
					if(_PalletNo_W == null)
	        	    {
						_PalletNo_W = TearOff.PalletNo;
					}
					return _PalletNo_W;
				}
			}

			public AggregateParameter StorageTypeID
		    {
				get
		        {
					if(_StorageTypeID_W == null)
	        	    {
						_StorageTypeID_W = TearOff.StorageTypeID;
					}
					return _StorageTypeID_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _PalletNo_W = null;
			private AggregateParameter _StorageTypeID_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_PalletNo_W = null;
				_StorageTypeID_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PalletInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PalletUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_PalletDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.PalletNo);
			p.SourceColumn = ColumnNames.PalletNo;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.StorageTypeID);
			p.SourceColumn = ColumnNames.StorageTypeID;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}

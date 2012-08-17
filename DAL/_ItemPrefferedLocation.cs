
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
	public abstract class _ItemPrefferedLocation : SqlClientEntity
	{
		public _ItemPrefferedLocation()
		{
			this.QuerySource = "ItemPrefferedLocation";
			this.MappingName = "ItemPrefferedLocation";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ItemPrefferedLocationLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ItemPrefferedLocationLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter ItemID
			{
				get
				{
					return new SqlParameter("@ItemID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PalletLocationID
			{
				get
				{
					return new SqlParameter("@PalletLocationID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter IsFixed
			{
				get
				{
					return new SqlParameter("@IsFixed", SqlDbType.Bit, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string ItemID = "ItemID";
            public const string PalletLocationID = "PalletLocationID";
            public const string IsFixed = "IsFixed";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _ItemPrefferedLocation.PropertyNames.ID;
					ht[ItemID] = _ItemPrefferedLocation.PropertyNames.ItemID;
					ht[PalletLocationID] = _ItemPrefferedLocation.PropertyNames.PalletLocationID;
					ht[IsFixed] = _ItemPrefferedLocation.PropertyNames.IsFixed;

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
            public const string ItemID = "ItemID";
            public const string PalletLocationID = "PalletLocationID";
            public const string IsFixed = "IsFixed";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _ItemPrefferedLocation.ColumnNames.ID;
					ht[ItemID] = _ItemPrefferedLocation.ColumnNames.ItemID;
					ht[PalletLocationID] = _ItemPrefferedLocation.ColumnNames.PalletLocationID;
					ht[IsFixed] = _ItemPrefferedLocation.ColumnNames.IsFixed;

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
            public const string ItemID = "s_ItemID";
            public const string PalletLocationID = "s_PalletLocationID";
            public const string IsFixed = "s_IsFixed";

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

		public virtual int ItemID
	    {
			get
	        {
				return base.Getint(ColumnNames.ItemID);
			}
			set
	        {
				base.Setint(ColumnNames.ItemID, value);
			}
		}

		public virtual int PalletLocationID
	    {
			get
	        {
				return base.Getint(ColumnNames.PalletLocationID);
			}
			set
	        {
				base.Setint(ColumnNames.PalletLocationID, value);
			}
		}

		public virtual bool IsFixed
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsFixed);
			}
			set
	        {
				base.Setbool(ColumnNames.IsFixed, value);
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

		public virtual string s_ItemID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ItemID) ? string.Empty : base.GetintAsString(ColumnNames.ItemID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ItemID);
				else
					this.ItemID = base.SetintAsString(ColumnNames.ItemID, value);
			}
		}

		public virtual string s_PalletLocationID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PalletLocationID) ? string.Empty : base.GetintAsString(ColumnNames.PalletLocationID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PalletLocationID);
				else
					this.PalletLocationID = base.SetintAsString(ColumnNames.PalletLocationID, value);
			}
		}

		public virtual string s_IsFixed
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.IsFixed) ? string.Empty : base.GetboolAsString(ColumnNames.IsFixed);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.IsFixed);
				else
					this.IsFixed = base.SetboolAsString(ColumnNames.IsFixed, value);
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

				public WhereParameter ItemID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ItemID, Parameters.ItemID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PalletLocationID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PalletLocationID, Parameters.PalletLocationID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsFixed
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsFixed, Parameters.IsFixed);
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

			public WhereParameter ItemID
		    {
				get
		        {
					if(_ItemID_W == null)
	        	    {
						_ItemID_W = TearOff.ItemID;
					}
					return _ItemID_W;
				}
			}

			public WhereParameter PalletLocationID
		    {
				get
		        {
					if(_PalletLocationID_W == null)
	        	    {
						_PalletLocationID_W = TearOff.PalletLocationID;
					}
					return _PalletLocationID_W;
				}
			}

			public WhereParameter IsFixed
		    {
				get
		        {
					if(_IsFixed_W == null)
	        	    {
						_IsFixed_W = TearOff.IsFixed;
					}
					return _IsFixed_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _ItemID_W = null;
			private WhereParameter _PalletLocationID_W = null;
			private WhereParameter _IsFixed_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_ItemID_W = null;
				_PalletLocationID_W = null;
				_IsFixed_W = null;

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

				public AggregateParameter ItemID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ItemID, Parameters.ItemID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PalletLocationID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PalletLocationID, Parameters.PalletLocationID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsFixed
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsFixed, Parameters.IsFixed);
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

			public AggregateParameter ItemID
		    {
				get
		        {
					if(_ItemID_W == null)
	        	    {
						_ItemID_W = TearOff.ItemID;
					}
					return _ItemID_W;
				}
			}

			public AggregateParameter PalletLocationID
		    {
				get
		        {
					if(_PalletLocationID_W == null)
	        	    {
						_PalletLocationID_W = TearOff.PalletLocationID;
					}
					return _PalletLocationID_W;
				}
			}

			public AggregateParameter IsFixed
		    {
				get
		        {
					if(_IsFixed_W == null)
	        	    {
						_IsFixed_W = TearOff.IsFixed;
					}
					return _IsFixed_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _ItemID_W = null;
			private AggregateParameter _PalletLocationID_W = null;
			private AggregateParameter _IsFixed_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_ItemID_W = null;
				_PalletLocationID_W = null;
				_IsFixed_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ItemPrefferedLocationInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ItemPrefferedLocationUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ItemPrefferedLocationDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.ItemID);
			p.SourceColumn = ColumnNames.ItemID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PalletLocationID);
			p.SourceColumn = ColumnNames.PalletLocationID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsFixed);
			p.SourceColumn = ColumnNames.IsFixed;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}

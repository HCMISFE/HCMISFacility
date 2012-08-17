
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
	public abstract class _ReceivePallet : SqlClientEntity
	{
		public _ReceivePallet()
		{
			this.QuerySource = "ReceivePallet";
			this.MappingName = "ReceivePallet";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ReceivePalletLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ReceivePalletLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter ReceiveID
			{
				get
				{
					return new SqlParameter("@ReceiveID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter PalletID
			{
				get
				{
					return new SqlParameter("@PalletID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter ReceivedQuantity
			{
				get
				{
					return new SqlParameter("@ReceivedQuantity", SqlDbType.BigInt, 0);
				}
			}
			
			public static SqlParameter Balance
			{
				get
				{
					return new SqlParameter("@Balance", SqlDbType.BigInt, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string ReceiveID = "ReceiveID";
            public const string PalletID = "PalletID";
            public const string ReceivedQuantity = "ReceivedQuantity";
            public const string Balance = "Balance";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _ReceivePallet.PropertyNames.ID;
					ht[ReceiveID] = _ReceivePallet.PropertyNames.ReceiveID;
					ht[PalletID] = _ReceivePallet.PropertyNames.PalletID;
					ht[ReceivedQuantity] = _ReceivePallet.PropertyNames.ReceivedQuantity;
					ht[Balance] = _ReceivePallet.PropertyNames.Balance;

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
            public const string ReceiveID = "ReceiveID";
            public const string PalletID = "PalletID";
            public const string ReceivedQuantity = "ReceivedQuantity";
            public const string Balance = "Balance";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _ReceivePallet.ColumnNames.ID;
					ht[ReceiveID] = _ReceivePallet.ColumnNames.ReceiveID;
					ht[PalletID] = _ReceivePallet.ColumnNames.PalletID;
					ht[ReceivedQuantity] = _ReceivePallet.ColumnNames.ReceivedQuantity;
					ht[Balance] = _ReceivePallet.ColumnNames.Balance;

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
            public const string ReceiveID = "s_ReceiveID";
            public const string PalletID = "s_PalletID";
            public const string ReceivedQuantity = "s_ReceivedQuantity";
            public const string Balance = "s_Balance";

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

		public virtual int ReceiveID
	    {
			get
	        {
				return base.Getint(ColumnNames.ReceiveID);
			}
			set
	        {
				base.Setint(ColumnNames.ReceiveID, value);
			}
		}

		public virtual int PalletID
	    {
			get
	        {
				return base.Getint(ColumnNames.PalletID);
			}
			set
	        {
				base.Setint(ColumnNames.PalletID, value);
			}
		}

		public virtual long ReceivedQuantity
	    {
			get
	        {
				return base.Getlong(ColumnNames.ReceivedQuantity);
			}
			set
	        {
				base.Setlong(ColumnNames.ReceivedQuantity, value);
			}
		}

		public virtual long Balance
	    {
			get
	        {
				return base.Getlong(ColumnNames.Balance);
			}
			set
	        {
				base.Setlong(ColumnNames.Balance, value);
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

		public virtual string s_ReceiveID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReceiveID) ? string.Empty : base.GetintAsString(ColumnNames.ReceiveID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReceiveID);
				else
					this.ReceiveID = base.SetintAsString(ColumnNames.ReceiveID, value);
			}
		}

		public virtual string s_PalletID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.PalletID) ? string.Empty : base.GetintAsString(ColumnNames.PalletID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.PalletID);
				else
					this.PalletID = base.SetintAsString(ColumnNames.PalletID, value);
			}
		}

		public virtual string s_ReceivedQuantity
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ReceivedQuantity) ? string.Empty : base.GetlongAsString(ColumnNames.ReceivedQuantity);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ReceivedQuantity);
				else
					this.ReceivedQuantity = base.SetlongAsString(ColumnNames.ReceivedQuantity, value);
			}
		}

		public virtual string s_Balance
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Balance) ? string.Empty : base.GetlongAsString(ColumnNames.Balance);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Balance);
				else
					this.Balance = base.SetlongAsString(ColumnNames.Balance, value);
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

				public WhereParameter ReceiveID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReceiveID, Parameters.ReceiveID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter PalletID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.PalletID, Parameters.PalletID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ReceivedQuantity
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ReceivedQuantity, Parameters.ReceivedQuantity);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Balance
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Balance, Parameters.Balance);
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

			public WhereParameter ReceiveID
		    {
				get
		        {
					if(_ReceiveID_W == null)
	        	    {
						_ReceiveID_W = TearOff.ReceiveID;
					}
					return _ReceiveID_W;
				}
			}

			public WhereParameter PalletID
		    {
				get
		        {
					if(_PalletID_W == null)
	        	    {
						_PalletID_W = TearOff.PalletID;
					}
					return _PalletID_W;
				}
			}

			public WhereParameter ReceivedQuantity
		    {
				get
		        {
					if(_ReceivedQuantity_W == null)
	        	    {
						_ReceivedQuantity_W = TearOff.ReceivedQuantity;
					}
					return _ReceivedQuantity_W;
				}
			}

			public WhereParameter Balance
		    {
				get
		        {
					if(_Balance_W == null)
	        	    {
						_Balance_W = TearOff.Balance;
					}
					return _Balance_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _ReceiveID_W = null;
			private WhereParameter _PalletID_W = null;
			private WhereParameter _ReceivedQuantity_W = null;
			private WhereParameter _Balance_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_ReceiveID_W = null;
				_PalletID_W = null;
				_ReceivedQuantity_W = null;
				_Balance_W = null;

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

				public AggregateParameter ReceiveID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReceiveID, Parameters.ReceiveID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter PalletID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.PalletID, Parameters.PalletID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ReceivedQuantity
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ReceivedQuantity, Parameters.ReceivedQuantity);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Balance
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Balance, Parameters.Balance);
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

			public AggregateParameter ReceiveID
		    {
				get
		        {
					if(_ReceiveID_W == null)
	        	    {
						_ReceiveID_W = TearOff.ReceiveID;
					}
					return _ReceiveID_W;
				}
			}

			public AggregateParameter PalletID
		    {
				get
		        {
					if(_PalletID_W == null)
	        	    {
						_PalletID_W = TearOff.PalletID;
					}
					return _PalletID_W;
				}
			}

			public AggregateParameter ReceivedQuantity
		    {
				get
		        {
					if(_ReceivedQuantity_W == null)
	        	    {
						_ReceivedQuantity_W = TearOff.ReceivedQuantity;
					}
					return _ReceivedQuantity_W;
				}
			}

			public AggregateParameter Balance
		    {
				get
		        {
					if(_Balance_W == null)
	        	    {
						_Balance_W = TearOff.Balance;
					}
					return _Balance_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _ReceiveID_W = null;
			private AggregateParameter _PalletID_W = null;
			private AggregateParameter _ReceivedQuantity_W = null;
			private AggregateParameter _Balance_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_ReceiveID_W = null;
				_PalletID_W = null;
				_ReceivedQuantity_W = null;
				_Balance_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ReceivePalletInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ReceivePalletUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ReceivePalletDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.ReceiveID);
			p.SourceColumn = ColumnNames.ReceiveID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.PalletID);
			p.SourceColumn = ColumnNames.PalletID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ReceivedQuantity);
			p.SourceColumn = ColumnNames.ReceivedQuantity;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Balance);
			p.SourceColumn = ColumnNames.Balance;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}

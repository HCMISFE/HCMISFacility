
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

// Generated by MyGeneration Version # (1.3.0.9)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace DAL
{
	public abstract class _ReceivingUnits : SqlClientEntity
	{
		public _ReceivingUnits()
		{
			this.QuerySource = "ReceivingUnits";
			this.MappingName = "ReceivingUnits";

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
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ReceivingUnitsLoadAll]", parameters);
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

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_ReceivingUnitsLoadByPrimaryKey]", parameters);
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
			
			public static SqlParameter Name
			{
				get
				{
					return new SqlParameter("@Name", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Description
			{
				get
				{
					return new SqlParameter("@Description", SqlDbType.Text, 2147483647);
				}
			}
			
			public static SqlParameter Phone
			{
				get
				{
					return new SqlParameter("@Phone", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Woreda
			{
				get
				{
					return new SqlParameter("@Woreda", SqlDbType.VarChar, 50);
				}
			}
			
			public static SqlParameter Route
			{
				get
				{
					return new SqlParameter("@Route", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Min
			{
				get
				{
					return new SqlParameter("@Min", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter Max
			{
				get
				{
					return new SqlParameter("@Max", SqlDbType.Float, 0);
				}
			}
			
			public static SqlParameter IsActive
			{
				get
				{
					return new SqlParameter("@IsActive", SqlDbType.Bit, 0);
				}
			}

            public static SqlParameter FacilityType
            {
                get
                {
                    return new SqlParameter("@FacilityType", SqlDbType.VarChar, 50);
                }
            }

            public static SqlParameter Region
            {
                get
                {
                    return new SqlParameter("@Region", SqlDbType.VarChar, 50);
                }
            }

            public static SqlParameter Zone
            {
                get
                {
                    return new SqlParameter("@Zone", SqlDbType.VarChar, 50);
                }
            }
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string Name = "Name";
            public const string Description = "Description";
            public const string Phone = "Phone";
            public const string Woreda = "Woreda";
            public const string Route = "Route";
            public const string Min = "Min";
            public const string Max = "Max";
            public const string IsActive = "IsActive";

            public const string Region = "Region";
            public const string Zone = "Zone";
            public const string FacilityType = "FacilityType";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _ReceivingUnits.PropertyNames.ID;
					ht[Name] = _ReceivingUnits.PropertyNames.Name;
					ht[Description] = _ReceivingUnits.PropertyNames.Description;
					ht[Phone] = _ReceivingUnits.PropertyNames.Phone;
					ht[Woreda] = _ReceivingUnits.PropertyNames.Woreda;
					ht[Route] = _ReceivingUnits.PropertyNames.Route;
					ht[Min] = _ReceivingUnits.PropertyNames.Min;
					ht[Max] = _ReceivingUnits.PropertyNames.Max;
					ht[IsActive] = _ReceivingUnits.PropertyNames.IsActive;
                    ht[Region] = _ReceivingUnits.PropertyNames.Region;
                    ht[Zone] = _ReceivingUnits.PropertyNames.Zone;
                    ht[FacilityType] = _ReceivingUnits.PropertyNames.FacilityType;

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
            public const string Name = "Name";
            public const string Description = "Description";
            public const string Phone = "Phone";
            public const string Woreda = "Woreda";
            public const string Route = "Route";
            public const string Min = "Min";
            public const string Max = "Max";
            public const string IsActive = "IsActive";
            public const string Region = "Region";
            public const string Zone = "Zone";
            public const string FacilityType = "FacilityType";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _ReceivingUnits.ColumnNames.ID;
					ht[Name] = _ReceivingUnits.ColumnNames.Name;
					ht[Description] = _ReceivingUnits.ColumnNames.Description;
					ht[Phone] = _ReceivingUnits.ColumnNames.Phone;
					ht[Woreda] = _ReceivingUnits.ColumnNames.Woreda;
					ht[Route] = _ReceivingUnits.ColumnNames.Route;
					ht[Min] = _ReceivingUnits.ColumnNames.Min;
					ht[Max] = _ReceivingUnits.ColumnNames.Max;
					ht[IsActive] = _ReceivingUnits.ColumnNames.IsActive;
                    ht[Region] = _ReceivingUnits.ColumnNames.Region;
                    ht[Zone] = _ReceivingUnits.ColumnNames.Zone;
                    ht[FacilityType] = _ReceivingUnits.ColumnNames.FacilityType;
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
            public const string Name = "s_Name";
            public const string Description = "s_Description";
            public const string Phone = "s_Phone";
            public const string Woreda = "s_Woreda";
            public const string Route = "s_Route";
            public const string Min = "s_Min";
            public const string Max = "s_Max";
            public const string IsActive = "s_IsActive";
            public const string Region = "s_Region";
            public const string Zone = "s_Zone";
            public const string FacilityType = "s_FacilityType";

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

		public virtual string Name
	    {
			get
	        {
				return base.Getstring(ColumnNames.Name);
			}
			set
	        {
				base.Setstring(ColumnNames.Name, value);
			}
		}

		public virtual string Description
	    {
			get
	        {
				return base.Getstring(ColumnNames.Description);
			}
			set
	        {
				base.Setstring(ColumnNames.Description, value);
			}
		}

		public virtual string Phone
	    {
			get
	        {
				return base.Getstring(ColumnNames.Phone);
			}
			set
	        {
				base.Setstring(ColumnNames.Phone, value);
			}
		}

		public virtual string Woreda
	    {
			get
	        {
				return base.Getstring(ColumnNames.Woreda);
			}
			set
	        {
				base.Setstring(ColumnNames.Woreda, value);
			}
		}

		public virtual int Route
	    {
			get
	        {
				return base.Getint(ColumnNames.Route);
			}
			set
	        {
				base.Setint(ColumnNames.Route, value);
			}
		}

		public virtual double Min
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Min);
			}
			set
	        {
				base.Setdouble(ColumnNames.Min, value);
			}
		}

		public virtual double Max
	    {
			get
	        {
				return base.Getdouble(ColumnNames.Max);
			}
			set
	        {
				base.Setdouble(ColumnNames.Max, value);
			}
		}

		public virtual bool IsActive
	    {
			get
	        {
				return base.Getbool(ColumnNames.IsActive);
			}
			set
	        {
				base.Setbool(ColumnNames.IsActive, value);
			}
		}

        public virtual string Region
        {
            get
            {
                return base.Getstring(ColumnNames.Region);
            }
            set
            {
                base.Setstring(ColumnNames.Region, value);
            }
        }

        public virtual string Zone
        {
            get
            {
                return base.Getstring(ColumnNames.Zone);
            }
            set
            {
                base.Setstring(ColumnNames.Zone, value);
            }
        }

        public virtual string FacilityType
        {
            get
            {
                return base.Getstring(ColumnNames.FacilityType);
            }
            set
            {
                base.Setstring(ColumnNames.FacilityType, value);
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

		public virtual string s_Name
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Name) ? string.Empty : base.GetstringAsString(ColumnNames.Name);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Name);
				else
					this.Name = base.SetstringAsString(ColumnNames.Name, value);
			}
		}

		public virtual string s_Description
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Description) ? string.Empty : base.GetstringAsString(ColumnNames.Description);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Description);
				else
					this.Description = base.SetstringAsString(ColumnNames.Description, value);
			}
		}

		public virtual string s_Phone
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Phone) ? string.Empty : base.GetstringAsString(ColumnNames.Phone);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Phone);
				else
					this.Phone = base.SetstringAsString(ColumnNames.Phone, value);
			}
		}

		public virtual string s_Woreda
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Woreda) ? string.Empty : base.GetstringAsString(ColumnNames.Woreda);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Woreda);
				else
					this.Woreda = base.SetstringAsString(ColumnNames.Woreda, value);
			}
		}

		public virtual string s_Route
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Route) ? string.Empty : base.GetintAsString(ColumnNames.Route);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Route);
				else
					this.Route = base.SetintAsString(ColumnNames.Route, value);
			}
		}

		public virtual string s_Min
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Min) ? string.Empty : base.GetdoubleAsString(ColumnNames.Min);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Min);
				else
					this.Min = base.SetdoubleAsString(ColumnNames.Min, value);
			}
		}

		public virtual string s_Max
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Max) ? string.Empty : base.GetdoubleAsString(ColumnNames.Max);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Max);
				else
					this.Max = base.SetdoubleAsString(ColumnNames.Max, value);
			}
		}

		public virtual string s_Region
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Region) ? string.Empty : base.GetstringAsString(ColumnNames.Region);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Region);
				else
					this.Region = base.SetstringAsString(ColumnNames.Region, value);
			}
		}

        public virtual string s_Zone
        {
            get
            {
                return this.IsColumnNull(ColumnNames.Zone) ? string.Empty : base.GetstringAsString(ColumnNames.Zone);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.Zone);
                else
                    this.Zone = base.SetstringAsString(ColumnNames.Zone, value);
            }
        }

        public virtual string s_FacilityType
        {
            get
            {
                return this.IsColumnNull(ColumnNames.FacilityType) ? string.Empty : base.GetstringAsString(ColumnNames.FacilityType);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.FacilityType);
                else
                    this.FacilityType = base.SetstringAsString(ColumnNames.FacilityType, value);
            }
        }

        public virtual string s_IsActive
        {
            get
            {
                return this.IsColumnNull(ColumnNames.IsActive) ? string.Empty : base.GetboolAsString(ColumnNames.IsActive);
            }
            set
            {
                if (string.Empty == value)
                    this.SetColumnNull(ColumnNames.IsActive);
                else
                    this.IsActive = base.SetboolAsString(ColumnNames.IsActive, value);
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

				public WhereParameter Name
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Name, Parameters.Name);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Description
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Description, Parameters.Description);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Phone
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Phone, Parameters.Phone);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Woreda
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Woreda, Parameters.Woreda);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Route
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Route, Parameters.Route);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Min
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Min, Parameters.Min);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Max
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Max, Parameters.Max);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter IsActive
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.IsActive, Parameters.IsActive);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

                public WhereParameter Region
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Region, Parameters.Region);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter Zone
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.Zone, Parameters.Zone);
                        this._clause._entity.Query.AddWhereParameter(where);
                        return where;
                    }
                }

                public WhereParameter FacilityType
                {
                    get
                    {
                        WhereParameter where = new WhereParameter(ColumnNames.FacilityType, Parameters.FacilityType);
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

			public WhereParameter Name
		    {
				get
		        {
					if(_Name_W == null)
	        	    {
						_Name_W = TearOff.Name;
					}
					return _Name_W;
				}
			}

			public WhereParameter Description
		    {
				get
		        {
					if(_Description_W == null)
	        	    {
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public WhereParameter Phone
		    {
				get
		        {
					if(_Phone_W == null)
	        	    {
						_Phone_W = TearOff.Phone;
					}
					return _Phone_W;
				}
			}

			public WhereParameter Woreda
		    {
				get
		        {
					if(_Woreda_W == null)
	        	    {
						_Woreda_W = TearOff.Woreda;
					}
					return _Woreda_W;
				}
			}

			public WhereParameter Route
		    {
				get
		        {
					if(_Route_W == null)
	        	    {
						_Route_W = TearOff.Route;
					}
					return _Route_W;
				}
			}

			public WhereParameter Min
		    {
				get
		        {
					if(_Min_W == null)
	        	    {
						_Min_W = TearOff.Min;
					}
					return _Min_W;
				}
			}

			public WhereParameter Max
		    {
				get
		        {
					if(_Max_W == null)
	        	    {
						_Max_W = TearOff.Max;
					}
					return _Max_W;
				}
			}

			

            public WhereParameter Region
            {
                get
                {
                    if (_Region_W == null)
                    {
                        _Region_W = TearOff.Region;
                    }
                    return _Region_W;
                }
            }

            public WhereParameter Zone
            {
                get
                {
                    if (_Zone_W == null)
                    {
                        _Zone_W = TearOff.Zone;
                    }
                    return _Zone_W;
                }
            }

            public WhereParameter FacilityType
            {
                get
                {
                    if (_FacilityType_W == null)
                    {
                        _FacilityType_W = TearOff.FacilityType;
                    }
                    return _FacilityType_W;
                }
            }


            public WhereParameter IsActive
            {
                get
                {
                    if (_IsActive_W == null)
                    {
                        _IsActive_W = TearOff.IsActive;
                    }
                    return _IsActive_W;
                }
            }

			private WhereParameter _ID_W = null;
			private WhereParameter _Name_W = null;
			private WhereParameter _Description_W = null;
			private WhereParameter _Phone_W = null;
			private WhereParameter _Woreda_W = null;
			private WhereParameter _Route_W = null;
			private WhereParameter _Min_W = null;
			private WhereParameter _Max_W = null;
            private WhereParameter _IsActive_W = null;
            private WhereParameter _Region_W = null;
            private WhereParameter _Zone_W = null;
            private WhereParameter _FacilityType_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_Name_W = null;
				_Description_W = null;
				_Phone_W = null;
				_Woreda_W = null;
				_Route_W = null;
				_Min_W = null;
				_Max_W = null;
				_IsActive_W = null;
                _Region_W = null;
                _Zone_W = null;
                _FacilityType_W = null;

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

				public AggregateParameter Name
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Name, Parameters.Name);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Description
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Description, Parameters.Description);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Phone
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Phone, Parameters.Phone);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Woreda
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Woreda, Parameters.Woreda);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Route
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Route, Parameters.Route);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Min
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Min, Parameters.Min);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Max
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Max, Parameters.Max);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter IsActive
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.IsActive, Parameters.IsActive);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}
               
                public AggregateParameter Region
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Region, Parameters.Region);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }
                public AggregateParameter Zone
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.Zone, Parameters.Zone);
                        this._clause._entity.Query.AddAggregateParameter(aggregate);
                        return aggregate;
                    }
                }

                public AggregateParameter FacilityType
                {
                    get
                    {
                        AggregateParameter aggregate = new AggregateParameter(ColumnNames.FacilityType, Parameters.FacilityType);
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

			public AggregateParameter Name
		    {
				get
		        {
					if(_Name_W == null)
	        	    {
						_Name_W = TearOff.Name;
					}
					return _Name_W;
				}
			}

			public AggregateParameter Description
		    {
				get
		        {
					if(_Description_W == null)
	        	    {
						_Description_W = TearOff.Description;
					}
					return _Description_W;
				}
			}

			public AggregateParameter Phone
		    {
				get
		        {
					if(_Phone_W == null)
	        	    {
						_Phone_W = TearOff.Phone;
					}
					return _Phone_W;
				}
			}

			public AggregateParameter Woreda
		    {
				get
		        {
					if(_Woreda_W == null)
	        	    {
						_Woreda_W = TearOff.Woreda;
					}
					return _Woreda_W;
				}
			}

			public AggregateParameter Route
		    {
				get
		        {
					if(_Route_W == null)
	        	    {
						_Route_W = TearOff.Route;
					}
					return _Route_W;
				}
			}

			public AggregateParameter Min
		    {
				get
		        {
					if(_Min_W == null)
	        	    {
						_Min_W = TearOff.Min;
					}
					return _Min_W;
				}
			}

			public AggregateParameter Max
		    {
				get
		        {
					if(_Max_W == null)
	        	    {
						_Max_W = TearOff.Max;
					}
					return _Max_W;
				}
			}
            public AggregateParameter Region
            {
                get
                {
                    if (_Region_W == null)
                    {
                        _Region_W = TearOff.Region;
                    }
                    return _Region_W;
                }
            }

            public AggregateParameter Zone
            {
                get
                {
                    if (_Zone_W == null)
                    {
                        _Zone_W = TearOff.Zone;
                    }
                    return _Zone_W;
                }
            }

            public AggregateParameter FacilityType
            {
                get
                {
                    if (_FacilityType_W == null)
                    {
                        _FacilityType_W = TearOff.FacilityType;
                    }
                    return _FacilityType_W;
                }
            }
			public AggregateParameter IsActive
		    {
				get
		        {
					if(_IsActive_W == null)
	        	    {
						_IsActive_W = TearOff.IsActive;
					}
					return _IsActive_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _Name_W = null;
			private AggregateParameter _Description_W = null;
			private AggregateParameter _Phone_W = null;
			private AggregateParameter _Woreda_W = null;
			private AggregateParameter _Route_W = null;
			private AggregateParameter _Min_W = null;
			private AggregateParameter _Max_W = null;
			private AggregateParameter _IsActive_W = null;
            private AggregateParameter _Region_W = null;
            private AggregateParameter _Zone_W = null;
            private AggregateParameter _FacilityType_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_Name_W = null;
				_Description_W = null;
				_Phone_W = null;
				_Woreda_W = null;
				_Route_W = null;
				_Min_W = null;
				_Max_W = null;
				_IsActive_W = null;
                _Region_W = null;
                _Zone_W = null;
                _FacilityType_W = null;

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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ReceivingUnitsInsert]";
	
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
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ReceivingUnitsUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_ReceivingUnitsDelete]";
	
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

			p = cmd.Parameters.Add(Parameters.Name);
			p.SourceColumn = ColumnNames.Name;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Description);
			p.SourceColumn = ColumnNames.Description;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Phone);
			p.SourceColumn = ColumnNames.Phone;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Woreda);
			p.SourceColumn = ColumnNames.Woreda;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Route);
			p.SourceColumn = ColumnNames.Route;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Min);
			p.SourceColumn = ColumnNames.Min;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Max);
			p.SourceColumn = ColumnNames.Max;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.IsActive);
			p.SourceColumn = ColumnNames.IsActive;
			p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Region);
            p.SourceColumn = ColumnNames.Region;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.Zone);
            p.SourceColumn = ColumnNames.Zone;
            p.SourceVersion = DataRowVersion.Current;

            p = cmd.Parameters.Add(Parameters.FacilityType);
            p.SourceColumn = ColumnNames.FacilityType;
            p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}

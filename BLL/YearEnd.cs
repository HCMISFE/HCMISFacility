
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using System.Linq;
using DAL;
using System.Data;
using EthiopianDate;
using MyGeneration.dOOdads;

namespace BLL
{
    public class YearEnd : _YearEnd
    {
        public YearEnd()
        {

        }

        public DataTable GetAllBalance(int year, int storeId)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.StoreID.Value = storeId;
            this.Where.Year.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            this.Where.Year.Value = year;
            this.Query.Load();
            return this.DataTable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="storeId"></param>
        /// <param name="includeAutomatic">Whether to include automatically entered data or not.</param>
        /// <returns></returns>
        public bool DoesBalanceExist(int year, int storeId, bool includeAutomatic)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.StoreID.Value = storeId;
            this.Where.Year.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            this.Where.Year.Value = year;

            if (includeAutomatic == false)
            {
                this.Where.AutomaticallyEntered.Conjuction = WhereParameter.Conj.And;
                this.Where.AutomaticallyEntered.Value = includeAutomatic;
            }

            this.Query.Load();

            if (this.DataTable.Rows.Count > 0)
                return true;

            return false;
        }


        public bool IsInventoryEntered(int year)
        {
            string query = string.Format(@"SELECT * FROM dbo.YearEnd WHERE [Year]={0} AND AutomaticallyEntered =0", year);
            this.LoadFromSql(query);
            return this.DataTable.Rows.Count >= 100;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemID"></param>
        /// <param name="storeID"></param>
        /// <param name="year"></param>
        /// <returns>0 is returned if the item hasn't been loaded.</returns>
        public int LoadByItemIDStoreAndYear(int itemID, int storeID, int year, bool includeAutomatic)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.ItemID.Value = itemID;
            this.Where.StoreID.Value = storeID;
            this.Where.Year.Value = year;
            this.Where.AutomaticallyEntered.Value = includeAutomatic;
            this.Query.Load();
            return this.RowCount > 0 ? this.ID : 0;
        }

        public int LoadByItemIDStoreUnitAndYear(int itemID, int storeID, int year, bool includeAutomatic,int unitid)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.ItemID.Value = itemID;
            this.Where.StoreID.Value = storeID;
            this.Where.Year.Value = year;
            this.Where.AutomaticallyEntered.Value = includeAutomatic;
            this.Where.UnitID.Value = unitid;
            this.Query.Load();
            return this.RowCount > 0 ? this.ID : 0;
        }

        public int LoadByItemIDStoreAndYearAndUnit(int itemID, int storeID, int year, bool includeAutomatic, int unitId)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.ItemID.Value = itemID;
            this.Where.StoreID.Value = storeID;
            this.Where.Year.Value = year;
            this.Where.AutomaticallyEntered.Value = includeAutomatic;
            this.Where.UnitID.Value = unitId;
            this.Query.Load();
            return this.RowCount > 0 ? this.ID : 0;
        }

        public bool IsInventoryComplete(int year, int storeId)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.StoreID.Value = storeId;
            this.Where.Year.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            this.Where.Year.Value = year;
            this.Where.AutomaticallyEntered.Conjuction = WhereParameter.Conj.And;
            this.Where.AutomaticallyEntered.Value = true;
            this.Query.Load();

            if (this.DataTable.Rows.Count > 0)
                return false;

            return true;
        }

        public bool IsInventoryCompleteToReceive(int year, int storeId)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.StoreID.Value = storeId;
            this.Where.Year.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            this.Where.Year.Value = year;
            this.Where.AutomaticallyEntered.Conjuction = WhereParameter.Conj.And;
            this.Where.AutomaticallyEntered.Value = false;
            this.Query.Load();

            if (this.DataTable.Rows.Count > 0)
                return true;

            return false;
        }
        public void MarkInventoryAsComplete(int year, int storeID)
        {
            string query = string.Format("Select");
            this.Where.AutomaticallyEntered.Value = true;
            this.Query.Load();
            while (!this.EOF)
            {

            }
        }

        public bool DoesBalanceExist(int year, int storeId, int itemID, bool includeAutomatic)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.StoreID.Value = storeId;
            this.Where.Year.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            this.Where.Year.Value = year;
            this.Where.AutomaticallyEntered.Conjuction = WhereParameter.Conj.And;
            this.Where.AutomaticallyEntered.Value = includeAutomatic;
            this.Where.ItemID.Conjuction = WhereParameter.Conj.And;
            this.Where.ItemID.Value = itemID;
            this.Query.Load();

            if (this.DataTable.Rows.Count > 0)
                return true;

            return false;
        }

        public bool DoesBalanceExistByUnit(int year, int itemId,int storeId, bool includeAutomatic,int unitId)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.StoreID.Value = storeId;
            this.Where.Year.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            this.Where.Year.Value = year;
            this.Where.AutomaticallyEntered.Conjuction = WhereParameter.Conj.And;
            this.Where.AutomaticallyEntered.Value = includeAutomatic;
            this.Where.ItemID.Conjuction = WhereParameter.Conj.And;
            this.Where.ItemID.Value = itemId;
            this.Where.UnitID.Conjuction = WhereParameter.Conj.And;
            this.Where.UnitID.Value = unitId;
            this.Query.Load();

            if (this.DataTable.Rows.Count > 0)
                return true;

            return false;
        }

        public bool InventoryRequired(bool ignoreAutomatic)
        {
            var ethDate = new EthiopianDate.EthiopianDate();
            if ((ethDate.Month == 10 && ethDate.Day == 30) || ethDate.Month == 11)
            {
                var stores = new Stores();
                stores.GetActiveStores();
                while (!stores.EOF)
                {
                    Items itm = new Items();
                    itm.ExcludeNeverReceivedItemsNoCategory(stores.ID);

                    if (!this.DoesBalanceExist(ethDate.Year, stores.ID, !ignoreAutomatic) && itm.RowCount > 0)
                    {
                        return true;
                    }
                    stores.MoveNext();
                }
            }
            return false;
        }

        public bool InventoryRequiredForHandlingUnit(bool ignoreAutomatic)
        {
            var ethDate = new EthiopianDate.EthiopianDate();
            if ((ethDate.Month == 10 && ethDate.Day == 30) || ethDate.Month == 11)
            {
                var stores = new Stores();
                stores.GetActiveStores();
                while (!stores.EOF)
                {
                    var itm = new Items();
                    itm.ExcludeNeverReceivedItemsNoCategoryForHandlingUnit(stores.ID);
                    if (!this.DoesBalanceExist(ethDate.Year,stores.ID, !ignoreAutomatic) && itm.RowCount > 0)
                    {
                        return true;
                    }
                    stores.MoveNext();
                }
            }
            return false;
        }

        public DataTable GetBalanceByItemId(int year, int storeId, int itemId)
        {
            this.FlushData();
            string query =
                string.Format(
                    "select * from YearEnd where ItemID = {0} and [Year] = {1} and StoreID = {2} and AutomaticallyEntered = 0",
                    itemId, year, storeId);
            this.LoadFromRawSql(query);
            return this.DataTable;
        }

        public DataTable GetBalanceByItemIdByUnitID(int year, int storeId, int itemId, int unitId)
        {
            this.FlushData();
            string query =
                string.Format(
                    "select * from YearEnd where ItemID = {0} and [Year] = {1} and StoreID = {2} and UnitID= {3} and AutomaticallyEntered = 0",
                    itemId, year, storeId, unitId);
            this.LoadFromRawSql(query);
            return this.DataTable;
        }

        public void GenerateAutomaticInventory()
        {
            var ethDate = new EthiopianDate.EthiopianDate();
            if (InventoryRequired(false))
            {
                Stores stores = new Stores();
                stores.GetActiveStores();
                while (!stores.EOF) //This needs to be done for each store
                {
                  if (!DoesBalanceExist(ethDate.Year, stores.ID, true))
                        //If Inventory information hasn't already been filled for this store
                    {
                        var itm = new Items();
                        itm.ExcludeNeverReceivedItemsNoCategory(stores.ID);
                        while (!itm.EOF) //For each time
                        {
                            var yearEnd = new YearEnd();
                            var balance = new Balance();

                            yearEnd.LoadByItemIDStoreAndYear(itm.ID, stores.ID, ethDate.Year, true);

                            if (yearEnd.RowCount > 0)
                            {
                                return;
                            }

                            //YearEnd.PurgeAutomaticallyEnteredInventory(itm.ID, stores.ID, ethDate.Year);
                            yearEnd.AddNew();
                            yearEnd.ItemID = itm.ID;
                            yearEnd.StoreID = stores.ID;
                            yearEnd.Year = ethDate.Year;
                            yearEnd.EBalance = balance.GetSOH(itm.ID, stores.ID, 10, ethDate.Year);
                            yearEnd.PhysicalInventory = yearEnd.EBalance;
                            yearEnd.AutomaticallyEntered = true;
                            yearEnd.UnitID = 0;
                            yearEnd.Save();
                            itm.MoveNext();
                        }
                    }
                    stores.MoveNext();
                }

            }
        }

        public static void PurgeAutomaticallyEnteredInventory(int itemID, int storeID, int year)
        {
            YearEnd yearEnd = new YearEnd();
            yearEnd.Where.ItemID.Value = itemID;
            yearEnd.Where.StoreID.Value = storeID;
            yearEnd.Where.Year.Value = year;
            yearEnd.Where.AutomaticallyEntered.Value = true;
            yearEnd.Query.Load();
            yearEnd.DeleteAll();
            yearEnd.Save();
        }

        public static void PurgeAutomaticallyEnteredInventoryForUnit(int itemID, int storeID, int year,int unitID)
        {
            YearEnd yearEnd = new YearEnd();
            yearEnd.Where.ItemID.Value = itemID;
            yearEnd.Where.StoreID.Value = storeID;
            yearEnd.Where.Year.Value = year;
            yearEnd.Where.AutomaticallyEntered.Value = true;
            yearEnd.Where.UnitID.Value = unitID;
            yearEnd.Query.Load();
            yearEnd.DeleteAll();
            yearEnd.Save();
        }
        /* public Int64 GetBBalance(int year, int storeId, int itemId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("Select * from YearEnd where StoreID = {0} AND ItemID = {1} AND Year = {2}",storeId,itemId,year));
            
            Int64 bb = ( this.DataTable.Rows.Count > 0)? Convert.ToInt64(this.DataTable.Rows[0]["BBalance"]):0;

            return bb;
        }*/

        public double GetBBalanceAmount(int year, int storeId, int itemId, int month)
        {
            //CALENDAR:
            this.FlushData();
            double bb = 0;
            EthiopianDate.EthiopianDate ethioDate = new EthiopianDate.EthiopianDate(year, month, 30);
            //int bYear = ((month > 10) ? year : year - 1);
            int bYear = ethioDate.StartOfFiscalYear.Year;
            string query = String.Format("Select * from YearEnd where StoreID = {0} AND ItemID = {1} AND Year = {2}",
                                         storeId, itemId, bYear);
            this.LoadFromRawSql(query);
            if (this.DataTable.Rows.Count > 0)
            {
                bb = ((this.DataTable.Rows[0]["PhysicalInventoryPrice"].ToString() != "")
                          ? Convert.ToInt64(this.DataTable.Rows[0]["PhysicalInventoryPrice"])
                          : 0);
            }
            else
            {
                string queryString =
                    String.Format("Select * from YearEnd where StoreID = {0} AND ItemID = {1} AND Year = {2}", storeId,
                                  itemId, year - 1);
                this.LoadFromRawSql(queryString);
                if (this.DataTable.Rows.Count > 0)
                {
                    bb = ((this.DataTable.Rows[0]["PhysicalInventoryPrice"].ToString() != "")
                              ? Convert.ToInt64(this.DataTable.Rows[0]["PhysicalInventoryPrice"])
                              : 0);
                }
                else if (((year + 8) > DateTime.Now.Year) || (month > 10 && (year + 8) == DateTime.Now.Year))
                    // to check if it is different year from current
                {
                    double cons = 0;
                    IssueDoc iss = new IssueDoc();
                    ReceiveDoc rec = new ReceiveDoc();
                    Disposal dis = new Disposal();
                    if ((year + 8) > DateTime.Now.Year) // to check if it is hamle and Nehase
                        year = year - 1;
                    month = 10;
                    //}

                    double ReceivedAmount = rec.GetReceivedAmountTillMonth(itemId, storeId, month, year);
                    double AdjustedAmount = dis.GetAdjustedAmountTillMonth(itemId, storeId, month, year);
                    double IssuedAmount = iss.GetIssuedAmountTillMonth(itemId, storeId, month, year);
                    double LostAmount = dis.GetLossesAmountTillMonth(itemId, storeId, month, year);
                    cons = ((ReceivedAmount + AdjustedAmount - IssuedAmount) - LostAmount);
                    bb = cons;
                }
            }
            if (bb < 0)
            {

            }
            return bb;


            //this.FlushData();
            //this.LoadFromRawSql(String.Format("Select * from YearEnd where StoreID = {0} AND ItemID = {1} AND Year = {2}", storeId, itemId, year-1));

            //double bb = (this.DataTable.Rows.Count > 0) ? ((this.DataTable.Rows[0]["PhysicalInventoryPrice"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["PhysicalInventoryPrice"]) : 0) : 0;

            //return bb;
        }

        /* public Int64 GetBBalanceAll(int year, int itemId)
         {
             this.FlushData();
             this.LoadFromRawSql(String.Format("Select * from YearEnd where  ItemID = {0} AND Year = {1}", itemId, year));

             Int64 bb = (this.DataTable.Rows.Count > 0) ? Convert.ToInt64(this.DataTable.Rows[0]["BBalance"]) : 0;

             return bb;
         }*/

        /// <summary>
        /// Gets the beginning balance of an item in a store
        /// </summary>
        /// <param name="fiscalYear">The Fiscal year in Ethiopian Calendar</param>
        /// <param name="storeId"></param>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public Int64 GetBBalance(int fiscalYear, int storeId, int itemId)
        {
            //CALENDAR:
            this.FlushData();
            Int64 bb = 0;
            int year = fiscalYear;
            int month = 10;
            string query =
                String.Format(
                    "Select * from YearEnd where StoreID = {0} AND ItemID = {1} AND Year = {2} order by PhysicalInventory desc",
                    storeId, itemId, fiscalYear - 1);
            this.LoadFromRawSql(query);

            if (this.DataTable.Rows.Count > 0)
            {
                bb = Convert.ToInt64(this.DataTable.Rows[0]["PhysicalInventory"]);
            }
            else
            {
                if (((year + 8) > DateTime.Now.Year) || (month > 10 && (year + 8) == DateTime.Now.Year))
                    // to check if it is different year from current
                {
                    Int64 cons = 0;
                    IssueDoc iss = new IssueDoc();
                    ReceiveDoc rec = new ReceiveDoc();
                    Disposal dis = new Disposal();
                    if ((year + 8) > DateTime.Now.Year) // to check if it is hamle and Nehase
                        year = year - 1;
                    month = 10;
                    //}

                    long RecievedQuantity = rec.GetReceivedQuantityTillMonth(itemId, storeId, month, year);
                    long AdjustedQuantity = dis.GetAdjustedQuantityTillMonth(itemId, storeId, month, year);
                    long IssuedQuantity = iss.GetIssuedQuantityTillMonth(itemId, storeId, month, year);
                    long LossQuantity = dis.GetLossesQuantityTillMonth(itemId, storeId, month, year);
                    // long BalanceQuantity = yEnd.GetBBalance(year, storeId, itemId, month);
                    cons = (RecievedQuantity + AdjustedQuantity - IssuedQuantity - LossQuantity);

                    //cons = (rec.GetReceivedQuantityTillMonth(itemId, storeId, month, year) + dis.GetAdjustedQuantityTillMonth(itemId, storeId, month, year) - iss.GetIssuedQuantityTillMonth(itemId, storeId, month, year) - dis.GetLossesQuantityTillMonth(itemId, storeId, month, year));
                    bb = cons;
                }
            }

            return bb;
        }

        public Int64 GetBBalance(int year, int storeId, int itemId, int month)
        {
            //CALENDAR:
            this.FlushData();
            Int64 bb = 0;
            //int bYear = ((month > 10) ? year : year - 1);
            EthiopianDate.EthiopianDate ethioDate = new EthiopianDate.EthiopianDate(year, month, 30);
            int bYear = ethioDate.FiscalYear;
            string query =
                String.Format(
                    "Select * from YearEnd where StoreID = {0} AND ItemID = {1} AND Year = {2}  and (AutomaticallyEntered = 0 or AutomaticallyEntered is null) order by PhysicalInventory desc",
                    storeId, itemId, bYear);
            this.LoadFromRawSql(query);
            if (this.DataTable.Rows.Count > 0 && this.DataTable.Rows[0]["PhysicalInventory"] != DBNull.Value)
            {
                bb = Convert.ToInt64(this.DataTable.Rows[0]["PhysicalInventory"]);
            }
            else
            {
                this.LoadFromRawSql(
                    String.Format(
                        "Select * from YearEnd where StoreID = {0} AND ItemID = {1} AND Year = {2} and (AutomaticallyEntered = 0  or AutomaticallyEntered is null)",
                        storeId, itemId, year - 1));
                if (this.DataTable.Rows.Count > 0)
                {
                    bb = Convert.ToInt64(this.DataTable.Rows[0]["PhysicalInventory"]);
                }
                else if (((year + 8) > DateTime.Now.Year) || (month > 10 && (year + 8) == DateTime.Now.Year))
                    // to check if it is different year from current
                {
                    Int64 cons = 0;
                    IssueDoc iss = new IssueDoc();
                    ReceiveDoc rec = new ReceiveDoc();
                    Disposal dis = new Disposal();
                    if ((year + 8) > DateTime.Now.Year) // to check if it is hamle and Nehase
                        year = year - 1;
                    month = 10;
                    //}

                    long RecievedQuantity = rec.GetReceivedQuantityTillMonth(itemId, storeId, month, year);
                    long AdjustedQuantity = dis.GetAdjustedQuantityTillMonth(itemId, storeId, month, year);
                    long IssuedQuantity = iss.GetIssuedQuantityTillMonth(itemId, storeId, month, year);
                    long LossQuantity = dis.GetLossesQuantityTillMonth(itemId, storeId, month, year);
                    // long BalanceQuantity = yEnd.GetBBalance(year, storeId, itemId, month);
                    cons = (RecievedQuantity + AdjustedQuantity - IssuedQuantity - LossQuantity);

                    //cons = (rec.GetReceivedQuantityTillMonth(itemId, storeId, month, year) + dis.GetAdjustedQuantityTillMonth(itemId, storeId, month, year) - iss.GetIssuedQuantityTillMonth(itemId, storeId, month, year) - dis.GetLossesQuantityTillMonth(itemId, storeId, month, year));
                    bb = cons;
                }
            }

            return bb;
        }


        public Int64 GetBBalanceByUnit(int year, int storeId, int itemId, int month, int unitId)
        {
            //CALENDAR:
            this.FlushData();
            Int64 bb = 0;
            //int bYear = ((month > 10) ? year : year - 1);
            EthiopianDate.EthiopianDate ethioDate = new EthiopianDate.EthiopianDate(year, month, 30);
            int bYear = ethioDate.FiscalYear;
            string query =
                String.Format(
                    "Select * from YearEnd where StoreID = {0} AND ItemID = {1} AND Year = {2}  and UnitID={3} and (AutomaticallyEntered = 0 or AutomaticallyEntered is null) order by PhysicalInventory desc",
                    storeId, itemId, bYear, unitId);
            this.LoadFromRawSql(query);
            if (this.DataTable.Rows.Count > 0 && this.DataTable.Rows[0]["PhysicalInventory"] != DBNull.Value)
            {
                bb = Convert.ToInt64(this.DataTable.Rows[0]["PhysicalInventory"]);
            }
            else
            {
                this.LoadFromRawSql(
                    String.Format(
                        "Select * from YearEnd where StoreID = {0} AND ItemID = {1} AND Year = {2} and UnitID={3} and (AutomaticallyEntered = 0  or AutomaticallyEntered is null)",
                        storeId, itemId, year - 1, unitId));
                if (this.DataTable.Rows.Count > 0)
                {
                    bb = Convert.ToInt64(this.DataTable.Rows[0]["PhysicalInventory"]);
                }
                else if (((year + 8) > DateTime.Now.Year) || (month > 10 && (year + 8) == DateTime.Now.Year))
                    // to check if it is different year from current
                {
                    Int64 cons = 0;
                    IssueDoc iss = new IssueDoc();
                    ReceiveDoc rec = new ReceiveDoc();
                    Disposal dis = new Disposal();
                    if ((year + 8) > DateTime.Now.Year) // to check if it is hamle and Nehase
                        year = year - 1;
                    month = 10;
                    //}

                    long RecievedQuantity = rec.GetReceivedQuantityTillMonthByUnit(itemId, storeId, month, year,
                                                                                   unitId);
                    long AdjustedQuantity = dis.GetAdjustedQuantityTillMonthByUnit(itemId, storeId, month, year,
                                                                                   unitId);
                    long IssuedQuantity = iss.GetIssuedQuantityTillMonthByUnit(itemId, storeId, month, year, unitId);
                    long LossQuantity = dis.GetLossesQuantityTillMonthByUnit(itemId, storeId, month, year, unitId);
                    // long BalanceQuantity = yEnd.GetBBalance(year, storeId, itemId, month);
                    cons = (RecievedQuantity + AdjustedQuantity - IssuedQuantity - LossQuantity);

                    //cons = (rec.GetReceivedQuantityTillMonth(itemId, storeId, month, year) + dis.GetAdjustedQuantityTillMonth(itemId, storeId, month, year) - iss.GetIssuedQuantityTillMonth(itemId, storeId, month, year) - dis.GetLossesQuantityTillMonth(itemId, storeId, month, year));
                    bb = cons;
                }
            }

            return bb;
        }

        /// <summary>
        /// Returns the beginning balance of a certain item inside a certain store (Uses a stored proc on the backend)
        /// </summary>
        /// <param name="storeID"></param>
        /// <param name="itemID"></param>
        /// <returns></returns>
        public Int64 GetBeginningBalance(int storeID, int itemID)
        {
            this.FlushData();
            System.Collections.Specialized.ListDictionary ld = new System.Collections.Specialized.ListDictionary();
            ld.Add("@StoreID", storeID);
            ld.Add("@ItemID", itemID);
            this.LoadFromSql("rpt_BeginningBalance", ld, CommandType.StoredProcedure);
            if (this.RowCount > 0)
            {
                return Convert.ToInt64(this.DataTable.Rows[0][0]);
            }
            else
                return 0;
        }

        public Int64 GetBBalanceAll(int year, int itemId)
        {
            this.FlushData();
            Int64 bb = 0;
            this.LoadFromRawSql(String.Format("Select * from YearEnd where ItemID = {0} AND Year = {1}", itemId, year));
            if (this.DataTable.Rows.Count > 0)
            {
                bb = Convert.ToInt64(this.DataTable.Rows[0]["PhysicalInventory"]);
            }
            else
            {
                this.LoadFromRawSql(String.Format("Select * from YearEnd where ItemID = {0} AND Year = {1}", itemId,
                                                  year - 1));
                if (this.DataTable.Rows.Count > 0)
                {
                    bb = Convert.ToInt64(this.DataTable.Rows[0]["PhysicalInventory"]);
                }
                else if (((year + 8) > DateTime.Now.Year)) // to check if it is different year from current
                {
                    Int64 cons = 0;
                    IssueDoc iss = new IssueDoc();
                    ReceiveDoc rec = new ReceiveDoc();
                    Disposal dis = new Disposal();

                    if ((year + 8) > DateTime.Now.Year) // to check if it is hamle and Nehase
                        year = year - 1;
                    int month = 10;
                    cons = (rec.GetReceivedQuantityTillMonthAll(itemId, month, year) +
                            dis.GetAdjustedQuantityTillMonthAll(itemId, month, year) -
                            iss.GetIssuedQuantityTillMonthAll(itemId, month, year) -
                            dis.GetLossesQuantityTillMonthAll(itemId, month, year));
                    bb = cons;
                }
            }
            return bb;
        }

        public DataTable GetDocumentByYear(int storeID, int year)
        {
            this.FlushData();
            this.LoadFromRawSql(
                String.Format(
                    "Select *, ROW_NUMBER() OVER (ORDER BY Year DESC) as RowNo from YearEnd ye JOIN vwGetAllItems vw on vw.ID = ye.ItemID where StoreID = {0} AND Year = {1} AND (ye.AutomaticallyEntered=0  or AutomaticallyEntered is null)",
                    storeID, year));
            return this.DataTable;
        }

        public DataTable GetDistinctYear(int storeID)
        {
            this.FlushData();
            this.LoadFromRawSql(
                String.Format(
                    "Select DISTINCT Year FROM YearEnd WHERE StoreID = {0} AND (AutomaticallyEntered=0 or AutomaticallyEntered is null)",
                    storeID));
            return this.DataTable;
        }

        public DataTable GetDocumentAll(int storeID)
        {
            this.FlushData();
            this.LoadFromRawSql(
                String.Format(
                    "Select *,ROW_NUMBER() OVER (ORDER BY Year DESC) as RowNo from YearEnd ye JOIN vwGetAllItems vw on vw.ID = ye.ItemID where StoreID = {0}  AND (ye.AutomaticallyEntered=0  or ye.AutomaticallyEntered is null) ORDER BY Year DESC",
                    storeID));
            return this.DataTable;
        }

        public void GenerateAutomaticInventoryByUnit()
        {
            var ethDate = new EthiopianDate.EthiopianDate();
            var stores = new Stores();
            stores.GetActiveStores();
            var rec = new ReceiveDoc();
            var itm = new Items();
            var yearEnd = new YearEnd();
            var balance = new Balance();

            if (!InventoryRequiredForHandlingUnit(false)) return;
            while (!stores.EOF) //This needs to be done for each store and for each item
            {
                itm.ExcludeNeverReceivedItemsNoCategoryForHandlingUnit(stores.ID);
                while (!itm.EOF) //For each item
                {
                    var receivedoc = rec.GetDistinctUnitIDFromReceivedDoc(itm.ID);
                    foreach (var dr in receivedoc.Rows.Cast<DataRow>().Where(dr =>!DoesBalanceExistByUnit(ethDate.Year, itm.ID, stores.ID, true,Convert.ToInt32(dr["UnitID"]))))
                    {
                        yearEnd.LoadByItemIDStoreAndYearAndUnit(itm.ID, stores.ID, ethDate.Year, true,Convert.ToInt32(dr["UnitID"]));
                        if (yearEnd.RowCount > 0) continue;
                        yearEnd.AddNew();
                        yearEnd.ItemID = itm.ID;
                        yearEnd.StoreID = stores.ID;
                        yearEnd.Year = ethDate.Year;
                        yearEnd.EBalance = balance.GetSOHByUnit(itm.ID, stores.ID, ethDate.Month, ethDate.Year,Convert.ToInt32(dr["UnitID"]));
                        yearEnd.PhysicalInventory = yearEnd.EBalance;
                        yearEnd.AutomaticallyEntered = true;
                        yearEnd.UnitID = Convert.ToInt32(dr["UnitID"]);
                        yearEnd.Save();
                       
                    }
                    itm.MoveNext();
                }
                stores.MoveNext();
            }
        }


        // End going through all stores!
    }
}


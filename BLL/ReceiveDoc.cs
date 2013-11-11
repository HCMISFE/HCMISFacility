
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using DAL;
using System.Data;

namespace BLL
{
    /// <summary>
    /// This class is a proxy to access all the recieve documens
    /// </summary>
    public class ReceiveDoc : _ReceiveDoc
    {
        public ReceiveDoc()
        {

        }

        /// <summary>
        ///  Loads all the batchs that didn't yet get issued
        ///  Only loads batch numbers that do have some balance
        /// </summary>
        /// <param name="storeId">The logical store that the items need to be issued from</param>
        /// <param name="itemId">The Item that is about to be Issued</param>
        /// <param name="dt">Data of propossed Issue</param>
        /// <returns></returns>
        public DataTable GetBatchToIssue(int storeId, int itemId, DateTime dt)
        {
            FlushData();
            var query = String.Format("SELECT * FROM ReceiveDoc WHERE (ExpDate > GETDATE()) AND (ItemID = {1}) " +
                                      "AND (Out = 0) AND (QuantityLeft != 0) AND (StoreID = {0} AND (Date <= '{2}')) " +
                                      "ORDER BY ExpDate", storeId, itemId, dt.ToString());
            LoadFromRawSql(query);
            return DataTable;
        }

        public DataTable GetDistinctUnitIDFromReceivedDoc(int itemID)
        {
            FlushData();
            var query = String.Format("SELECT DISTINCT(UnitID) FROM ReceiveDoc WHERE ItemID={0}", itemID);
            LoadFromRawSql(query);
            return DataTable;
        }

        /// <summary>
        /// Loads all the items that were received with some quantity.
        /// This is used for the Year End Process to see how much of the given batch number still exists in the warehouse.
        /// </summary>
        /// <param name="storeId">The Logical store from which the items are to be issued</param>
        /// <param name="itemId">The Item that is about to be isseud</param>
        /// <param name="dt">Date at which we want to see the respective batch numbers</param>
        /// <returns></returns>
        public DataTable GetBatchWithValue(int storeId, int itemId, DateTime dt)
        {
            this.FlushData();
            string query =
                String.Format(
                    "SELECT * FROM ReceiveDoc WHERE (ItemID = {1}) AND (Out = 0) AND QuantityLeft > 0 AND (StoreID = {0}) AND (Date <= '{2}') ORDER BY Quantity DESC",
                    storeId, itemId, dt.ToString());
            this.LoadFromRawSql(query);
            return this.DataTable;
        }


        public DataTable GetBatchWithValueByUnit(int storeId, int itemId, DateTime dt ,int unitId)
        {
            this.FlushData();
            string query =
                String.Format(
                    "SELECT * FROM ReceiveDoc WHERE (ItemID = {1}) AND (Out = 0) AND (UnitID={3}) AND QuantityLeft > 0 AND (StoreID = {0}) AND (Date <= '{2}') ORDER BY Quantity DESC",
                    storeId, itemId, dt.ToString(),unitId);
            this.LoadFromRawSql(query);
            return this.DataTable;
        }

        public DataTable GetTransactionByRefNo(string refNo)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT * FROM ReceiveDoc where RefNo = '{0}'", refNo));
            return this.DataTable;
        }
        /// <summary>
        /// Loads all the items that were received with some quantity.
        /// This is used for the Year End Process to see how much of the given batch number still exists in the warehouse.
        /// </summary>
        /// <param name="storeId">The Logical store from which the items are to be issued</param>
        /// <param name="itemId">The Item that is about to be isseud</param>
        /// <returns></returns>
        public DataTable GetBatchWithValue(int storeId, int itemId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT * FROM ReceiveDoc WHERE (ItemID = {1}) AND (Out = 0) AND QuantityLeft > 0  AND (StoreID = {0}) ORDER BY Quantity DESC", storeId, itemId));
            return this.DataTable;
        }

        /// <summary>
        /// Supplies dont have batch numbers
        /// This function allows to list Items that were stored without batch number
        /// TODO/FIX: This could be simmilar to GetBatchToIssue function, if it could be properly labeled.
        /// 
        /// </summary>
        /// <param name="storeId">Logical Store from which to issue</param>
        /// <param name="itemId"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public DataTable GetSupplyToIssueWithOutBatch(int storeId, int itemId, DateTime dt)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT * FROM ReceiveDoc WHERE(ItemID = {1}) AND Date <= GETDATE()  AND (Out = 0) AND (StoreID = {0}) ORDER BY Date", storeId, itemId, dt.ToString()));
            return this.DataTable;
        }

        /// <summary>
        /// Loads All the Receive Transactions of An Item with the Batch number in a logical store
        /// Note: this function might not work for supplies that do not reqire batch number
        /// </summary>
        /// <param name="itemId">Item That has been Receive</param>
        /// <param name="batchNo">Batch Number of the Item That has been Received</param>
        /// <param name="storeId">Logical Store ID</param>
        /// <returns></returns>
        public DataTable GetTransactionByBatch(int itemId, string batchNo, int storeId)
        {
            this.FlushData();
            string query = string.Format("select * from ReceiveDoc where ItemID = {0} and BatchNo = '{1}' and StoreID = {2}", itemId, batchNo, storeId);
            this.LoadFromRawSql(query);

            return this.DataTable;
        }

        /// <summary>
        /// Lodads specific item that was received
        /// This function requires the batch number, item id and receive ID in addition to the Logical store ID
        /// </summary>
        /// <param name="itemId">Item ID</param>
        /// <param name="batchNo">The Batch Number of the itemReceived</param>
        /// <param name="storeId">Logical Store ID</param>
        /// <param name="receiveID">Specific Receive ID</param>
        /// <returns></returns>
        public DataTable GetTransactionByBatchAndID(int itemId, string batchNo, int storeId, int receiveID)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.ItemID.Value = itemId;
            this.Where.StoreID.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            this.Where.StoreID.Value = storeId;
            this.Where.BatchNo.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            this.Where.BatchNo.Value = batchNo;
            this.Where.ID.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            this.Where.ID.Value = receiveID;
            this.Query.Load();
            return this.DataTable;
        }

        /// <summary>
        /// This return a distinct Receive Documents by their reference number
        /// This is for the Receive Log Screen and on the left side
        /// The output of this function could be rendered on a tree control because the receive documents are 
        /// classified by the year in which they were transacted
        /// </summary>
        /// <param name="storeId">Logical store ID</param>
        /// <returns>Data Tabe containing all reference numbers that are distinct and a parenet ID field with the year</returns>
        public DataTable GetDistinctRecDocments(int storeId)
        {
            this.FlushData();
            string query = String.Format("SELECT DISTINCT RefNo as RefNo, Date, StoreID,  cast (Year(Date) as varchar) as ParentID, rtrim(RefNo) + cast(Date as varchar) as ID FROM ReceiveDoc WHERE StoreId = {0} ORDER BY Date DESC", storeId);
            this.LoadFromRawSql(query);
            DataTable dtbl = this.DataTable;
            this.LoadFromRawSql("select distinct Year(Date) as Year from ReceiveDoc order by year(Date) DESC");
            while (!this.EOF)
            //The following is added for the benefit of tree control and having parents there.
            {
                DataRowView drv = dtbl.DefaultView.AddNew();
                drv["RefNo"] = drv["ID"] = (this.DataRow["Year"].ToString());
                this.MoveNext();
            }
            return dtbl;
        }


        public DataTable GetTransactionByRefNo(string refNo, int storeId, string dt)
        {
            this.FlushData();
            string query = String.Format("SELECT *,ROW_NUMBER() OVER (ORDER BY Date DESC) as RowNo , (rd.Cost * QtyPerPack) as PackPrice , datediff(day, EurDate, ExpDate) as DBER FROM ReceiveDoc rd join vwGetAllItems vw on rd.ItemID = vw.ID  WHERE (RefNo = '{0}' AND Date = '{2}') AND StoreId = {1} ORDER BY Date DESC", refNo, storeId, dt);
            this.LoadFromRawSql(query);
            return this.DataTable;
        }

        public DataTable GetTransactionByDateRange(int storeId, DateTime dt1, DateTime dt2)
        {
            this.FlushData();
            string query = String.Format("SELECT *, ROW_NUMBER() OVER (ORDER BY Date DESC) as RowNo ," +
                                         " (rd.Cost * QtyPerPack) as PackPrice, datediff(day, EurDate, ExpDate) as DBER " +
                                         "FROM ReceiveDoc rd join vwGetAllItems vw on rd.ItemID = vw.ID join ItemUnit iu on rd.UnitID =iu.ID WHERE StoreId = {0} AND (Date BETWEEN '{1}' AND '{2}' )" +
                                         " ORDER BY Date DESC", storeId, dt1.ToShortDateString(), dt2.ToShortDateString());
            this.LoadFromRawSql(query);
            return this.DataTable;
        }



        public DataTable GetAllTransaction(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT *, ROW_NUMBER() OVER (ORDER BY Date DESC) as RowNo , (rd.Cost * QtyPerPack) as PackPrice, datediff(day, EurDate, ExpDate) as DBER FROM ReceiveDoc rd join vwGetAllItems vw on rd.ItemID = vw.ID WHERE StoreId = {0} ORDER BY Date DESC", storeId));
            return this.DataTable;
        }

        public DataTable GetTransactionBySupplierId(int storeId, int supplierId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT *,ROW_NUMBER() OVER (ORDER BY Date DESC) as RowNo , (rd.Cost * QtyPerPack) as PackPrice, datediff(day, EurDate, ExpDate) as DBER FROM ReceiveDoc rd join vwGetAllItems vw on rd.ItemID = vw.ID WHERE StoreId = {0} AND SupplierID = {1} ORDER BY Date DESC", storeId, supplierId));
            return this.DataTable;
        }



        public Int64 GetReceivedQtyByDateRange(int itemId, int storeId, DateTime dt1, DateTime dt2)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT Sum( Quantity ) AS Received FROM ReceiveDoc WHERE StoreId = {0} AND ItemID = {3} AND (Date BETWEEN '{1}' AND '{2}' )", storeId, dt1.ToShortDateString(), dt2.ToShortDateString(), itemId));
            return ((this.DataTable.Rows[0]["Received"] != DBNull.Value) ? Convert.ToInt64(this.DataTable.Rows[0]["Received"]) : 0);
        }

        public double GetReceivedAmountByDateRange(int itemId, int storeId, DateTime dt1, DateTime dt2)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT sum(Cost * Quantity) as Price FROM ReceiveDoc WHERE StoreId = {0} AND ItemID = {3} AND (Date BETWEEN '{1}' AND '{2}' )", storeId, dt1.ToShortDateString(), dt2.ToShortDateString(), itemId));
            return ((this.DataTable.Rows[0]["Price"] != DBNull.Value) ? Convert.ToDouble(this.DataTable.Rows[0]["Price"]) : 0);
        }

        public Int64 GetReceivedQuantity(int itemId, int storeId, int year)
        {

            this.FlushData();
            string query = String.Format("SELECT SUM(Quantity) AS Quantity FROM ReceiveDoc WHERE (ItemID = {0}) AND (StoreID = {1}) AND ((Year(Date) = {2} AND Month(Date) < 11) OR (Year(Date) = {3} AND Month(Date) > 10))", itemId, storeId, year, year - 1);
            this.LoadFromRawSql(query);
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["Quantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["Quantity"]) : 0;
            return quant;
        }

        public Int64 GetReceivedQuantityTillMonth(int itemId, int storeId, int month, int year)
        {
            //CALENDAR
            this.FlushData();
            int yr = (month < 11) ? year - 1 : year;
            DateTime dt1 = new DateTime(yr, 11, 1);
            DateTime dt2 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS Quantity FROM ReceiveDoc WHERE (ItemID = {0}) AND (StoreID = {1} AND ( Date between '{2}' AND '{3}'))", itemId, storeId, dt1.ToString(), dt2.ToString()));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["Quantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["Quantity"]) : 0;
            return quant;
        }

        public Int64 GetReceivedQuantityTillMonthByUnit(int itemId, int storeId, int month, int year ,int unitId)
        {
            //CALENDAR
            this.FlushData();
            int yr = (month < 11) ? year - 1 : year;
            DateTime dt1 = new DateTime(yr, 11, 1);
            DateTime dt2 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS Quantity FROM ReceiveDoc WHERE (ItemID = {0}) AND (UnitID ={4}) AND (StoreID = {1} AND ( Date between '{2}' AND '{3}'))", itemId, storeId, dt1.ToString(), dt2.ToString(),unitId));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["Quantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["Quantity"]) : 0;
            return quant;
        }
        public Int64 GetReceivedQuantityTillMonthAll(int itemId, int month, int year)
        {

            this.FlushData();
            //this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS Quantity FROM ReceiveDoc WHERE (ItemID = {0}) AND (StoreID = {1} AND ((Month(Date) <= {2} AND Year(Date) = {3}) OR (Month(Date) > 10 AND Year(Date) = {4})))", itemId, storeId, month, year, year - 1));
            DateTime dt1 = new DateTime(year - 1, 11, 1);
            int yr = (month > 10) ? year - 1 : year;
            DateTime dt2 = new DateTime(yr, month, DateTime.DaysInMonth(yr, month));
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS Quantity FROM ReceiveDoc WHERE (ItemID = {0} AND ( Date between '{1}' AND '{2}'))", itemId, dt1.ToString(), dt2.ToString()));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["Quantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["Quantity"]) : 0;
            return quant;
        }

        public Int64 GetReceivedQuantityPastMonth(int itemId, int storeId, int month, int year)
        {

            this.FlushData();
            //this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS Quantity FROM ReceiveDoc WHERE (ItemID = {0}) AND (StoreID = {1} AND ((Month(Date) <= {2} AND Year(Date) = {3}) OR (Month(Date) > 10 AND Year(Date) = {4})))", itemId, storeId, month, year, year - 1));
            DateTime dt1 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            int yr = (month > 10) ? year - 1 : year;
            DateTime dt2 = dt1.AddMonths(-12);
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS Quantity FROM ReceiveDoc WHERE (ItemID = {0}) AND (StoreID = {1} AND ( Date between '{2}' AND '{3}'))", itemId, storeId, dt1.ToString(), dt2.ToString()));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["Quantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["Quantity"]) : 0;
            return quant;
        }

        public Int64 GetReceivedQuantityPerMonth(int itemId, int storeId, int month, int year)
        {

            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS Quantity FROM ReceiveDoc WHERE (ItemID = {0}) AND (StoreID = {1} AND ((Month(Date) = {2} AND Year(Date) = {3}) OR (Month(Date) = 11 AND Year(Date) = {4}) OR (Month(Date) = 12 AND Year(Date) = {4})))", itemId, storeId, month, year, year - 1));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["Quantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["Quantity"]) : 0;
            return quant;
        }

        public double GetReceivedAmount(int itemId, int storeId, int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity * Cost) AS Price FROM ReceiveDoc WHERE (ItemID = {0}) AND (StoreID = {1}) AND ((Year(Date) = {2} AND Month(Date) < 11) OR (Year(Date) = {3} AND Month(Date) > 10))", itemId, storeId, year, year - 1));
            double price = 0;
            price = (this.DataTable.Rows[0]["Price"].ToString() != "") ? Convert.ToDouble(this.DataTable.Rows[0]["Price"]) : 0;
            return price;
        }

        public double GetReceivedAmountTillMonth(int itemId, int storeId, int month, int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            int yr = (month < 11) ? year - 1 : year;
            DateTime dt1 = new DateTime(yr, 11, 1);
            DateTime dt2 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            string query = String.Format("SELECT SUM(Quantity * Cost) AS Price FROM ReceiveDoc WHERE (ItemID = {0}) AND (StoreID = {1}) AND ( Date between '{2}' AND '{3}')", itemId, storeId, dt1.ToString(), dt2.ToString());
            this.LoadFromRawSql(query);
            double price = 0;
            price = (this.DataTable.Rows[0]["Price"].ToString() != "") ? Convert.ToDouble(this.DataTable.Rows[0]["Price"]) : 0;
            return price;
        }

        public double GetLastReceivedCost(int itemId, int storeId)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT Cost FROM ReceiveDoc WHERE (ItemID = {0}) AND (StoreID = {1}) Order By Date DESC", itemId, storeId));
            double price = 0;
            price = (this.DataTable.Rows[0]["Cost"].ToString() != "") ? Convert.ToDouble(this.DataTable.Rows[0]["Cost"]) : 0;
            return price;
        }

        public DataTable GetTransactionByItemId(int storeId, int itemId, int year)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT * FROM ReceiveDoc WHERE StoreID = {0} AND ItemID ={1} AND (( YEAR(Date)={2} AND Month(Date) < 11 ) OR (Year(Date) ={3} AND Month(Date) > 10 ))ORDER BY Date", storeId, itemId, year, year - 1));
            return this.DataTable;
        }

        //public DataTable GetTransactionByItemId(int storeId, int itemId, int year)
        //{
        //    this.FlushData();
        //    this.LoadFromRawSql(String.Format("SELECT * FROM ReceiveDoc WHERE StoreID = {0} AND ItemID ={1} AND (( YEAR(Date)={2} AND Month(Date) < 11 ) OR (Year(Date) ={3} AND Month(Date) > 10 ))ORDER BY Date", storeId, itemId, year, year - 1));
        //    return this.DataTable;
        //}


        public DateTime GetLastReceivedDate(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT TOP (1) Date FROM ReceiveDoc WHERE (StoreID = {0})ORDER BY Date DESC", storeId));
            DateTime dt = (this.DataTable.Rows.Count > 0) ? Convert.ToDateTime(this.DataTable.Rows[0]["Date"]) : new DateTime();

            return dt;
        }

        public bool ValidateReceiveDate(DateTime receiveDate)
        {
            string query = "select top(1) * from receiveDoc where EurDate is not null order by EurDate asc";
            this.LoadFromRawSql(query);
            DateTime firstReceiveDate;
            if (this.RowCount > 0)
            {
                //string dateString = this.GetColumn("FirstReceiveDate").ToString();
                firstReceiveDate = this.EurDate;// Convert.ToDateTime(dateString);
            }
            else
            {
                firstReceiveDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);//So that we don't get the exact time of the receive which would make the receive date entered earlier than now.
            }

            long difference = receiveDate.Subtract(firstReceiveDate).Ticks;
            if (difference < 0)// receiveDate < firstReceiveDate)
            {
                return false;
            }

            else
                return true;
        }

        public DataTable GetTopReceivedItems(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("select TOP 10 count(*)AS NoOfRec,ID, (ItemName + ' ' + DosageForm + ' ' + Strength) as FullItemName,Unit,StockCode from vwGetReceivedItemsByBatch where storeId = {0} Group By ID,ItemName,DosageForm,Strength,Unit,StockCode order by NoOfRec DESC", storeId));
            return this.DataTable;
        }

        public DataTable GetLeastReceivedItems(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("select TOP 10 count(*)AS NoOfRec,vw.FullItemName,v.ID,v.ItemName,v.DosageForm,v.Strength,v.Unit,v.StockCode from vwGetReceivedItemsByBatch v join vwGetAllItems vw on v.ID = vw.ID where v.StoreId = {0} Group By v.ID,v.ItemName,v.DosageForm,v.Strength,v.Unit,v.StockCode, vw.FullItemName order by NoOfRec ASC", storeId));
            return this.DataTable;
        }

        public DataTable GetNeverReceivedItems(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT * FROM  dbo.vwGetAllItems WHERE (ID NOT IN (SELECT ItemID FROM  dbo.ReceiveDoc WHERE (StoreID = {0}))) AND (IsInHospitalList = 1)", storeId));
            return this.DataTable;
        }

        public DataTable GetAllReceivedItems(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT * FROM  dbo.vwGetAllItems WHERE (ID IN (SELECT ItemID FROM  dbo.ReceiveDoc WHERE (StoreID = {0}))) AND (IsInHospitalList = 1)", storeId));
            return this.DataTable;
        }

        public DataTable GetReceivedItems(int recid,int itemId, int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql("select * from ReceiveDoc where ItemID ={0} And StoreID={1} and ID={2}", itemId, storeId,recid);
            return this.DataTable;

        }
        public int CountNeverReceivedItems(int storeId)
        {
            this.FlushData();
            if (storeId == 0)
            {
                this.LoadFromRawSql(String.Format("SELECT count(*) as Count FROM  dbo.vwGetAllItems WHERE (ID NOT IN (SELECT ItemID FROM  dbo.ReceiveDoc)) AND (IsInHospitalList = 1)"));
            }
            else
            {
                this.LoadFromRawSql(String.Format("SELECT Count(*) as Count FROM  dbo.vwGetAllItems WHERE (ID NOT IN (SELECT ItemID FROM  dbo.ReceiveDoc WHERE (StoreID = {0}))) AND (IsInHospitalList = 1)", storeId));
            }

            return this.Getint("Count");
        }

        public DataTable GetReceivedNotIssuedItems(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT * FROM  dbo.vwGetAllItems WHERE (ID IN (SELECT ItemID FROM  dbo.ReceiveDoc WHERE (StoreID = {0}))) AND (IsInHospitalList = 1) AND (ID NOT IN (SELECT ItemID FROM  dbo.IssueDoc WHERE (StoreID = {0})))", storeId));
            return this.DataTable;
        }

        public int CountReceivedNotIssuedItems(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT Count(*) as Count FROM  dbo.vwGetAllItems WHERE (ID IN (SELECT ItemID FROM  dbo.ReceiveDoc WHERE (StoreID = {0}))) AND (IsInHospitalList = 1) AND (ID NOT IN (SELECT ItemID FROM  dbo.IssueDoc WHERE (StoreID = {0})))", storeId));
            return this.Getint("Count");
        }

        /// <summary>
        /// //ChangedDate:
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="storeId"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public DataTable GetAllTransaction(int itemId, int storeId, int month, int year)
        {
            this.FlushData();
            //DateTime dt1 = new DateTime(year - 1, 11, 1);
            //int yr = (month > 10) ? year - 1 : year;
            //DateTime dt2 = new DateTime(yr, month, DateTime.DaysInMonth(yr, month));
            EthiopianDate.EthiopianDate ethioDate = new EthiopianDate.EthiopianDate(year, month, 30);
            DateTime startOfFiscalYear = ethioDate.StartOfFiscalYear.ToGregorianDate();
            DateTime toDate = ethioDate.ToGregorianDate();
            //int yr = (month < 11) ? year - 1 : year;
            //DateTime dt1 = new DateTime(yr, 11, 1);
            //DateTime dt2 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            //this.LoadFromRawSql(String.Format("select ID,BatchNo,Cost,Date,RefNo,Quantity,ItemID,StoreID,1 AS Transact from ReceiveDoc where ItemID = {0} AND StoreID = {1} AND ( Date between '{2}' AND '{3}') union select ID,BatchNo,Cost,Date,RefNo,Quantity,ItemID,StoreID,0 AS Transact from IssueDoc where ItemID = {0} AND StoreID = {1} AND ( Date between '{2}' AND '{3}') Order by Date ASC, Transact DESC", itemId, storeId, dt1.ToString(), dt2.ToString()));
            string query =
                String.Format(
                    "select ID,BatchNo,Cost,Date,RefNo,Quantity,ItemID,StoreID,1 AS Transact from ReceiveDoc where ItemID = {0} AND StoreID = {1} AND ( EurDate between '{2}' AND '{3}') union select ID,BatchNo,Cost,Date,RefNo,Quantity,ItemID,StoreID,0 AS Transact from IssueDoc where ItemID = {0} AND StoreID = {1} AND ( EurDate between '{2}' AND '{3}') Order by Date ASC, Transact DESC",
                    itemId, storeId, startOfFiscalYear, toDate);
            this.LoadFromRawSql(query);
            return this.DataTable;
        }

        public DataTable GetAllTransaction(int itemId, int storeId, int fiscalYear)
        {
            this.FlushData();
            EthiopianDate.EthiopianDate ethioDate = new EthiopianDate.EthiopianDate(fiscalYear, 1, 1);
            DateTime startOfFiscalYear = ethioDate.StartOfFiscalYear.ToGregorianDate().AddDays(-1);
            DateTime endOfFiscalYear = ethioDate.EndOfFiscalYear.ToGregorianDate();
            //int yr = (month < 11) ? year - 1 : year;
            //DateTime dt1 = new DateTime(yr, 11, 1);
            //DateTime dt2 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            //this.LoadFromRawSql(String.Format("select ID,BatchNo,Cost,Date,RefNo,Quantity,ItemID,StoreID,1 AS Transact from ReceiveDoc where ItemID = {0} AND StoreID = {1} AND ( Date between '{2}' AND '{3}') union select ID,BatchNo,Cost,Date,RefNo,Quantity,ItemID,StoreID,0 AS Transact from IssueDoc where ItemID = {0} AND StoreID = {1} AND ( Date between '{2}' AND '{3}') Order by Date ASC, Transact DESC", itemId, storeId, dt1.ToString(), dt2.ToString()));
            string query =
                String.Format(
                    "select ID,BatchNo,Cost,Date,RefNo,Quantity,ItemID,StoreID,1 AS Transact from ReceiveDoc where ItemID = {0} AND StoreID = {1} AND ( EurDate between '{2}' AND '{3}') union select ID,BatchNo,Cost,Date,RefNo,Quantity,ItemID,StoreID,0 AS Transact from IssueDoc where ItemID = {0} AND StoreID = {1} AND ( EurDate between '{2}' AND '{3}') Order by Date ASC, Transact DESC",
                    itemId, storeId, startOfFiscalYear, endOfFiscalYear);
            this.LoadFromRawSql(query);
            return this.DataTable;
        }

        public DataTable GetRecievedItemsWithBalance(int itemID)
        {

            string query = String.Format("select BatchNo,ItemID,SupplierID, ExpDate ExpiryDate, StoreID, QuantityLeft, RefNo, Cost, Balance, ManufacturerID,m.Name as ManufacturerName,ReceiveID, PalletID, EurDate, PalletNo from ReceiveDoc rd join ReceivePallet rp on rd.ID = rp.ReceiveID join Manufacturers m on m.ID = rd.ManufacturerID left join Pallet p on p.ID = rp.PalletID where ItemID = {0} and QuantityLeft > 0", itemID);
            this.LoadFromRawSql(query);
            return this.DataTable;
        }

        public DataTable GetRecievedItemsWithBalanceForStore(int storeID, int typeID)
        {
            var query = String.Format("select vw.FullItemName, vw.TypeID ,vw.Unit,vw.StockCode, rd.ID as ReceiveID,BatchNo,ItemID,SupplierID, ExpDate ExpiryDate," +
                                         " StoreID,QuantityLeft,RefNo,rd.UnitID, rd.Cost, EurDate from ReceiveDoc rd " +
                                         "join vwGetAllItems vw on rd.ItemID = vw.ID where StoreID = {0} and TypeID={1} and QuantityLeft > 0 order by FullItemName", storeID, typeID);
            this.LoadFromRawSql(query);
            return this.DataTable;
        }


        public bool MergeStore(int storeone, int storetwo)
        {
            this.FlushData();
            return this.LoadFromRawSql(String.Format("UPDATE ReceiveDoc SET StoreID = {0} WHERE StoreID = {1}", storeone, storetwo));
        }

        internal static int ItemReceived(int itemID, int storeId)
        {
            string query = string.Format("select sum(Quantity) as Quantity from ReceiveDoc rd where ItemID = {0} and StoreID = {1}", itemID, storeId);
            ReceiveDoc rd = new ReceiveDoc();
            rd.LoadFromRawSql(query);
            if (rd.RowCount > 0 && !rd.IsColumnNull("Quantity") && rd.Quantity > 0)
            {
                return 1;
            }
            return 0;
        }

        public void GetLastReceivedBatchAfterIssue(int storeId, int itemID)
        {
            string query = string.Format("select TOP (1) * from ReceiveDoc where StoreID = {0} and ItemID = {1} order by ID desc", storeId, itemID);
            this.LoadFromRawSql(query);
        }

        public static bool MarkReceivedBatchAsEmpty(int receiveID)
        {
            try
            {
                BLL.ReceiveDoc rec = new ReceiveDoc();
                rec.LoadByPrimaryKey(receiveID);
                if (rec.RowCount > 0)
                {
                    rec.QuantityLeft = 0;
                    rec.Out = true;
                    rec.Save();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Gets the last issued date for the facility
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public static DateTime GetLastReceivedDate()
        {
            var rd = new ReceiveDoc();
            rd.LoadFromRawSql(String.Format("SELECT TOP (1) EurDate FROM ReceiveDoc ORDER BY EurDate DESC"));
            DateTime dt = (rd.DataTable.Rows.Count > 0) ? Convert.ToDateTime(rd.DataTable.Rows[0]["EurDate"]) : new DateTime();
            return dt;
        }


        public void GetAllWithQuantityLeft(int itemID, int storeID, int programID)
        {
            this.FlushData();
            string query = string.Format("select * from receivedoc where quantityleft>0 and itemid={0} and storeID={1} and SubProgramID={2}", itemID, storeID, programID);
            this.LoadFromRawSql(query);
        }

        public DataTable GetBatchToIssueByUnit(int storeId, int itemId, DateTime dtIss, int unitid)
        {
            FlushData();
            string query = String.Format("SELECT * FROM ReceiveDoc WHERE (ExpDate > GETDATE()) AND (ItemID = {1}) AND (Out = 0) AND (QuantityLeft != 0) AND (StoreID = {0} AND (Date <= '{2}') AND (UnitID= {3})) ORDER BY ExpDate", storeId, itemId, dtIss.ToString(),unitid);
            LoadFromRawSql(query);
            return DataTable;
        }
    }
}

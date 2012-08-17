
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using DAL;
using System.Data;

namespace BLL
{
	public class IssueDoc : _IssueDoc
	{
		public IssueDoc()
		{
		
		}

        public DataTable GetTransactionByRefNo(string refNo, System.DateTime date)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT *, ROW_NUMBER() OVER (ORDER BY id.DATE DESC) as RowNo, datediff(day, id.EurDate, ExpDate) as DBEI FROM IssueDoc id Join ReceiveDoc rd on id.RecievDocID = rd.ID join vwGetAllItems vw on id.ItemID = vw.ID  WHERE id.RefNo = '{0}' and id.Date = '{1}'", refNo, date.ToShortDateString()));
            return this.DataTable;
        }

        public Int64 GetIssuedQuantity(int itemId, int storeId,int year)
        { 
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS IssuedQuantity FROM  IssueDoc WHERE (IsApproved = 1) AND ItemID = {0} AND StoreId = {1} AND ((Year(Date) = {2} AND Month(Date) <11) OR (Year(Date) = {3} AND Month(Date)>10 ))", itemId,storeId,year,year -1 ));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["IssuedQuantity"].ToString()!= "" ) ? Convert.ToInt64(this.DataTable.Rows[0]["IssuedQuantity"]) : 0;
            return quant;
        }

        public double GetIssuedAmount(int itemId, int storeId,int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity * Cost) AS Amount FROM  IssueDoc WHERE (IsApproved = 1) AND (ItemID = {0} AND StoreId = {1}) AND ((Year(Date) = {2} AND Month(Date) < 11) OR (Year(Date) = {3} AND Month(Date)> 10))", itemId, storeId,year,year-1));
            double price = 0;
            price = (this.DataTable.Rows[0]["Amount"].ToString() != "") ? Convert.ToDouble(this.DataTable.Rows[0]["Amount"]) : 0;
            return price;
        }

        public double GetIssuedAmountTillMonth(int itemId, int storeId,int month, int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            int yr = (month < 11) ? year - 1 : year;
            DateTime dt1 = new DateTime(yr, 11, 1);
            DateTime dt2 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity * Cost) AS Amount FROM  IssueDoc WHERE (IsApproved = 1) AND (ItemID = {0} AND StoreId = {1}) AND ( Date between '{2}' AND '{3}')", itemId, storeId, dt1.ToString(), dt2.ToString()));
            double price = 0;
            price = (this.DataTable.Rows[0]["Amount"].ToString() != "") ? Convert.ToDouble(this.DataTable.Rows[0]["Amount"]) : 0;
            return price;
        }

        public int GetAvailableNoOfMonths(int itemId, int storeId,DateTime dt1, DateTime dt2)
        {

            int count = 1;
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT Date, ID, ItemID, StoreId FROM IssueDoc WHERE (ItemID = {0} AND StoreId = {1}) AND (Date Between '{2}' AND '{3}')",itemId,storeId,dt1.ToString(),dt2.ToString()));
            DateTime dtLast = (this.DataTable.Rows.Count > 0)?Convert.ToDateTime(this.DataTable.Rows[0]["Date"]): dt2;
            TimeSpan tDiff = dt2 - dtLast;
            count = tDiff.Days / 30;
           // count = (count == 0)? 1: ((count == 1)? 2 :count);
            count = count + 1;
            return count;
        }

        public int GetAvailableNoOfMonthsAll(int itemId, DateTime dt1, DateTime dt2)
        {

            int count = 1;
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT Date, ID, ItemID, StoreId FROM IssueDoc WHERE (ItemID = {0} AND (Date Between '{1}' AND '{2}'))", itemId, dt1.ToString(), dt2.ToString()));
            DateTime dtLast = (this.DataTable.Rows.Count > 0) ? Convert.ToDateTime(this.DataTable.Rows[0]["Date"]) : dt2;
            TimeSpan tDiff = dt2 - dtLast;
            count = tDiff.Days / 30;
            count = (count > 0) ? count : 1;
            return count;
        }

        public Int64 GetIssuedQuantityByMonth(int itemId, int storeId,int month,int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS IssuedQuantity FROM  IssueDoc WHERE (IsApproved = 1) AND (ItemID = {0} AND StoreId = {1} AND Month(Date) = {2} AND Year(Date) = {3})", itemId, storeId,month,year));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["IssuedQuantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["IssuedQuantity"]) : 0;
            return quant;
        }

        public double GetIssuedAmountByDateRange(int itemId, int storeId, DateTime dt1, DateTime dt2)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity * Cost) AS Amount FROM  IssueDoc WHERE (IsApproved = 1) AND (ItemID = {0} AND StoreId = {1})AND (Date between '{2}' AND '{3}')", itemId, storeId, dt1.ToString(), dt2.ToString()));
            double price = 0;
            price = (this.DataTable.Rows[0]["Amount"].ToString() != "") ? Convert.ToDouble(this.DataTable.Rows[0]["Amount"]) : 0;
            return price;
        }

        public Int64 GetIssuedQuantityByDateRange(int itemId, int storeId, DateTime dt1, DateTime dt2)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS IssuedQuantity FROM  IssueDoc WHERE (IsApproved = 1) AND (ItemID = {0} AND StoreId = {1} AND (Date between '{2}' AND '{3}'))", itemId, storeId, dt1.ToString(), dt2.ToString()));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["IssuedQuantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["IssuedQuantity"]) : 0;
            return quant;
        }

        public Int64 GetIssuedQuantityByDateRangeAll(int itemId, DateTime dt1, DateTime dt2)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS IssuedQuantity FROM  IssueDoc WHERE (IsApproved = 1) AND (ItemID = {0} AND (Date between '{1}' AND '{2}'))", itemId, dt1.ToString(), dt2.ToString()));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["IssuedQuantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["IssuedQuantity"]) : 0;
            return quant;
        }

        public Int64 GetIssuedQuantityTillMonth(int itemId, int storeId, int month, int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            int yr = (month < 11) ? year - 1 : year;
            DateTime dt1 = new DateTime(yr, 11, 1);
            DateTime dt2 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS IssuedQuantity FROM  IssueDoc WHERE (IsApproved = 1) AND (ItemID = {0} AND StoreId = {1} AND (Date between '{2}' AND '{3}'))",itemId,storeId,dt1.ToString(),dt2.ToString()));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["IssuedQuantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["IssuedQuantity"]) : 0;
            return quant;
        }

        public Int64 GetIssuedQuantityTillMonthAll(int itemId, int month, int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            //this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS IssuedQuantity FROM  IssueDoc WHERE (IsApproved = 1) AND (ItemID = {0} AND StoreId = {1} AND ((Month(Date) <= {2} AND Year(Date) = {3}) OR (Month(Date) > 10 AND Year(Date) = {4})))", itemId, storeId, month, year, year - 1));
            DateTime dt1 = new DateTime(year - 1, 11, 1);
            int yr = (month > 10) ? year - 1 : year;
            DateTime dt2 = new DateTime(yr, month, DateTime.DaysInMonth(yr, month));
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS IssuedQuantity FROM  IssueDoc WHERE (IsApproved = 1) AND (ItemID = {0}  AND (Date between '{1}' AND '{2}'))", itemId, dt1.ToString(), dt2.ToString()));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["IssuedQuantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["IssuedQuantity"]) : 0;
            return quant;
        }

        public Int64 GetIssuedQuantityPastMonth(int itemId, int storeId, int month, int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            //this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS IssuedQuantity FROM  IssueDoc WHERE (IsApproved = 1) AND (ItemID = {0} AND StoreId = {1} AND ((Month(Date) <= {2} AND Year(Date) = {3}) OR (Month(Date) > 10 AND Year(Date) = {4})))", itemId, storeId, month, year, year - 1));
            DateTime dt1 = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            int yr = (month > 10) ? year - 1 : year;
            DateTime dt2 = dt1.AddMonths(-12);
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS IssuedQuantity FROM  IssueDoc WHERE (IsApproved = 1) AND (ItemID = {0} AND StoreId = {1} AND (Date between '{2}' AND '{3}'))", itemId, storeId, dt1.ToString(), dt2.ToString()));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["IssuedQuantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["IssuedQuantity"]) : 0;
            return quant;
        }

        public Int64 GetIssuedQuantityPerMonth(int itemId, int storeId, int month, int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS IssuedQuantity FROM  IssueDoc WHERE (IsApproved = 1) AND (ItemID = {0} AND StoreId = {1} AND ((Month(Date) = {2} AND Year(Date) = {3}) OR (Month(Date) = 11 AND Year(Date) = {4}) OR (Month(Date) =12 AND Year(Date) = {4})))", itemId, storeId, month, year, year - 1));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["IssuedQuantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["IssuedQuantity"]) : 0;
            return quant;
        }

        public Int64 GetIssuedQuantityByReceivingUnit(int itemId, int storeId,int recevingUnitId,int year)
        { 
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS Quantity FROM IssueDoc WHERE (ReceivingUnitID = {2}) AND (ItemID = {0}) AND (StoreId = {1} AND Year(Date) = {3})", itemId,storeId,recevingUnitId,year));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["Quantity"].ToString()!= "" ) ? Convert.ToInt64(this.DataTable.Rows[0]["Quantity"]) : 0;
            return quant;
        }

        public Int64 GetIssuedQuantityByReceivingUnitDate(int itemId, int storeId, int recevingUnitId,string from, string to)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS Quantity FROM IssueDoc WHERE (ReceivingUnitID = {2}) AND (ItemID = {0}) AND (StoreId = {1}) AND (Date BETWEEN '{3}' AND '{4}')", itemId, storeId, recevingUnitId,from,to));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["Quantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["Quantity"]) : 0;
            return quant;
        }


        public DataTable GetIssueByRefNo(string refNo,int storeId,string date)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT *,ROW_NUMBER() OVER (ORDER BY Date DESC) as RowNo FROM IssueDoc WHERE (RefNo = '{0}' AND Date = '{2}') AND StoreId = {1} ORDER BY Date DESC", refNo, storeId, date));
            return this.DataTable;
        }

        public DataTable GetAllTransaction(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT vw.FullItemName, *, ROW_NUMBER() OVER (ORDER BY id.Date DESC) as RowNo , datediff(day, id.EurDate, ExpDate) as DBEI FROM IssueDoc id Join ReceiveDoc rd on id.RecievDocID = rd.ID join vwGetAllItems vw on vw.ID = id.ItemID WHERE id.StoreId = {0} ORDER BY id.Date DESC", storeId));
            return this.DataTable;
        }

        public DataTable GetTransactionByReceivingUnit(int storeId,int recUnitId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT * , ROW_NUMBER() OVER (ORDER BY id.Date DESC) as RowNo , datediff(day, id.EurDate, ExpDate) as DBEI  FROM IssueDoc id Join ReceiveDoc rd on id.RecievDocID = rd.ID  join vwGetAllItems vw on id.ItemID = vw.ID   WHERE id.StoreId = {0} AND id.ReceivingUnitID = {1} ORDER BY id.Date DESC", storeId, recUnitId));
            return this.DataTable;
        }

        /// <summary>
        /// Gets transaction by Date Range
        /// CalendarFix: Fixed!
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="dt1">European Date</param>
        /// <param name="dt2">European Date</param>
        /// <returns></returns>
        public DataTable GetTransactionByDateRange(int storeId, DateTime dt1, DateTime dt2)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT *, ROW_NUMBER() OVER (ORDER BY id.EurDate DESC) as RowNo , datediff(day, id.EurDate, ExpDate) as DBEI FROM IssueDoc id Join ReceiveDoc rd on id.RecievDocID = rd.ID  join vwGetAllItems vw on id.ItemID = vw.ID   WHERE id.StoreId = {0} AND (id.EurDate BETWEEN '{1}' AND '{2}' ) ORDER BY id.EurDate DESC", storeId, dt1.ToShortDateString(), dt2.ToShortDateString()));
            return this.DataTable;
        }

        public Int64 GetIssueByDateRange(int itemId,int storeId, DateTime dt1, DateTime dt2)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT Sum(Quantity) AS Issued FROM IssueDoc WHERE StoreId = {0} AND ItemID = {3} AND (Date BETWEEN '{1}' AND '{2}' )", storeId, dt1.ToShortDateString(), dt2.ToShortDateString(),itemId));
            return ((this.DataTable.Rows[0]["Issued"] != DBNull.Value) ? Convert.ToInt64(this.DataTable.Rows[0]["Issued"]) : 0);
        }

        public DataTable GetDistinctIssueDocments(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT DISTINCT RefNo, StoreId, Date,  cast (Year(Date) as varchar) as ParentID, RefNo + cast(Date as varchar) as ID FROM IssueDoc  WHERE StoreId = {0} ORDER BY Date DESC", storeId));
            DataTable dtbl = this.DataTable;
            this.LoadFromRawSql("select distinct Year(Date) as Year from IssueDoc order by year(Date) DESC");
            while (!this.EOF)//The following is added for the benefit of tree control and having parents there.
            {
                DataRowView drv = dtbl.DefaultView.AddNew();
                drv["RefNo"] = drv["ID"] = (this.DataRow["Year"].ToString());
                this.MoveNext();
            }
            return dtbl;
        }

        /// <summary>
        /// //ChangedDate:
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="itemId"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public DataTable GetTransactionByItemId(int storeId,int itemId,int year)
        {
            this.FlushData();
            EthiopianDate.EthiopianDate ethioDate = new EthiopianDate.EthiopianDate(year, 1, 1);
            DateTime startOfFiscalYear = ethioDate.StartOfFiscalYear.ToGregorianDate();
            DateTime endOfFiscalYear = ethioDate.EndOfFiscalYear.ToGregorianDate();
            //this.LoadFromRawSql(String.Format("SELECT *,ROW_NUMBER() OVER (ORDER BY Date DESC) as RowNo FROM IssueDoc id  join vwGetAllItems vw on id.ItemID = vw.ID   WHERE StoreId = {0} AND ItemID ={1} AND ((YEAR(Date)={2} AND Month(Date) < 11) OR (Year(Date) = {3} AND Month(Date) > 10)) ORDER BY Date DESC", storeId, itemId, year, year - 1));
            this.LoadFromRawSql(String.Format("SELECT *,ROW_NUMBER() OVER (ORDER BY EurDate DESC) as RowNo FROM IssueDoc id  join vwGetAllItems vw on id.ItemID = vw.ID   WHERE StoreId = {0} AND ItemID ={1} AND (EurDate between '{2}' and '{3}') ORDER BY Date DESC", storeId, itemId, startOfFiscalYear, endOfFiscalYear));
            return this.DataTable;
        }

        public DateTime GetLastIssuedDate(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT TOP (1) Date FROM IssueDoc WHERE (StoreId = {0})ORDER BY Date DESC", storeId));
            DateTime dt = (this.DataTable.Rows.Count > 0) ? Convert.ToDateTime(this.DataTable.Rows[0]["Date"]) : new DateTime();

            return dt;
        }

        public DataTable GetTopIssuedItems(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("select top 10 count(*)AS NoOfRec,v.ID,vw.FullItemName, vw.StockCode,vw.Unit from vwGetIssuedItemsByBatch v join vwGetAllitems vw on v.ID = vw.ID where storeId = {0} Group By v.ID,vw.FullItemName,vw.StockCode, vw.Unit order by NoOfRec DESC", storeId));
            return this.DataTable;
        }

        public DataTable GetLeastIssuedItems(int storeId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("select top 10 count(*)AS NoOfRec,v.ID,v.ItemName,vw.FullItemName,v.DosageForm,v.Strength,v.Unit,v.StockCode from vwGetIssuedItemsByBatch v join vwGetAllItems vw on v.ID = vw.ID where v.StoreId = {0} Group By v.ID,v.ItemName,v.DosageForm,v.Strength,v.Unit,v.StockCode,vw.FullItemName order by NoOfRec ASC", storeId));
            return this.DataTable;
        }

        //DU INfo

        public DataTable GetDULastIssue(int itemId, int receivingUnit)
        {
           
            this.FlushData();
            this.LoadFromRawSql(String.Format("select * from IssueDoc where ItemID = {0} AND ReceivingUnitID = {1} Order by Date DESC", itemId, receivingUnit));
            return this.DataTable;
        }

        public int GetDULastIssueQty(int itemId, int receivingUnit)
        {
            int qty = 0;
            this.FlushData();
            this.LoadFromRawSql(String.Format("select Sum(Quantity) AS Quantity from IssueDoc where ItemID = {0} AND ReceivingUnitID = {1} Group By Date Order by Date DESC", itemId, receivingUnit));
            qty = ((this.DataTable.Rows.Count > 0)? Convert.ToInt32(this.DataTable.Rows[0]["Quantity"]): 0);
            return qty;
        }

        public int GetDULastSOH(int itemId, int receivingUnit)
        {
  
            this.FlushData();
            this.LoadFromRawSql(String.Format("select DUSOH from IssueDoc where ItemID = {0} AND ReceivingUnitID = {1} Order by Date DESC", itemId, receivingUnit));
            if (this.RowCount > 0 && ! this.IsColumnNull("DUSOH"))
            {
                return (int)this.DUSOH;
            }
            return 0;
        }

        public int GetAvailableNoOfMonthsDU(int itemId, int receivingUnit, DateTime dt1, DateTime dt2)
        {

            int count = 1;
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT Date, ID, ItemID, ReceivingUnitID FROM IssueDoc WHERE (ItemID = {0} AND ReceivingUnitID = {1}) AND (Date Between '{2}' AND '{3}')", itemId, receivingUnit, dt1.ToString(), dt2.ToString()));
            DateTime dtLast = (this.DataTable.Rows.Count > 0) ? Convert.ToDateTime(this.DataTable.Rows[0]["Date"]) : dt2;
            TimeSpan tDiff = dt2 - dtLast;
            count = tDiff.Days / 30;
            // count = (count == 0)? 1: ((count == 1)? 2 :count);
            count = count + 1;
            return count;
        }

        public Int64 GetDUIssuedQuantityByDateRange(int itemId, int duId, DateTime dt1, DateTime dt2)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity - DUSOH) AS Cons FROM  IssueDoc WHERE (IsApproved = 1) AND (ItemID = {0} AND ReceivingUnitID = {1} AND (Date between '{2}' AND '{3}'))", itemId, duId, dt1.ToString(), dt2.ToString()));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["Cons"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["Cons"]) : 0;
            return quant;
        }

        public Int64 GetDUConsumptionByMonth(int itemId, int duId, int month, int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity - isnull(DUSOH,0)) AS Cons FROM  IssueDoc WHERE (ItemID = {0} AND ReceivingUnitID = {1} AND (Month(Date) = {2} AND Year(Date) = {3}))", itemId, duId, month, year));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["Cons"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["Cons"]) : 0;
            return quant;
        }

        public Int64 GetDUConsumptionAfterMonth(int itemId, int duId, int month, int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            string date = string.Format("{0}/1/{1}", month, year);
            string query = String.Format("SELECT SUM(Quantity - isnull(DUSOH,0)) AS Cons FROM  IssueDoc WHERE (ItemID = {0} AND ReceivingUnitID = {1} AND Date > '{2}')", itemId, duId, date);
            this.LoadFromRawSql(query);
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["Cons"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["Cons"]) : 0;
            return quant;
        }

        public Int64 GetDUSOHByMonth(int itemId, int duId, int month, int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(DUSOH) AS DUSOH FROM  IssueDoc WHERE (ItemID = {0} AND ReceivingUnitID = {1} AND (Month(Date) = {2} AND Year(Date) = {3}))", itemId, duId, month, year));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["DUSOH"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["DUSOH"]) : 0;
            return quant;
        }

        public Int64 GetDUIssueByMonth(int itemId, int duId, int month, int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity - DUSOH) AS IssQuantity FROM  IssueDoc WHERE (ItemID = {0} AND ReceivingUnitID = {1} AND (Month(Date) = {2} AND Year(Date) = {3}))", itemId, duId, month, year));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["IssQuantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["IssQuantity"]) : 0;
            return quant;
        }

        public Int64 GetDUReceiveByMonth(int itemId, int duId, int month, int year)
        {
            //There should be a date range for the last month or some thing
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT SUM(Quantity) AS IssQuantity FROM  IssueDoc WHERE (ItemID = {0} AND ReceivingUnitID = {1} AND (Month(Date) = {2} AND Year(Date) = {3}))", itemId, duId, month, year));
            Int64 quant = 0;
            quant = (this.DataTable.Rows[0]["IssQuantity"].ToString() != "") ? Convert.ToInt64(this.DataTable.Rows[0]["IssQuantity"]) : 0;
            return quant;
        }
        
        public DateTime GetLastIssuedDateByItem(int storeId, int itemId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("SELECT TOP (1) Date FROM IssueDoc WHERE (StoreId = {0} AND ItemID = {1})ORDER BY Date DESC", storeId,itemId));
            DateTime dt = (this.DataTable.Rows.Count > 0) ? Convert.ToDateTime(this.DataTable.Rows[0]["Date"]) : new DateTime();
            this.LoadFromRawSql(String.Format("SELECT TOP (1) Date FROM Disposal WHERE (StoreId = {0} AND ItemID = {1})ORDER BY Date DESC", storeId, itemId));
            DateTime dt1 = (this.DataTable.Rows.Count > 0) ? Convert.ToDateTime(this.DataTable.Rows[0]["Date"]) : new DateTime();
            if(dt < dt1)
                return dt1;
            return dt;
        }

        public DataTable GetIssueByBatchAndId(int itemId, string batchNo, int recId)
        {
            this.FlushData();
            this.LoadFromRawSql(String.Format("select * from IssueDoc where ItemID = {0} And BatchNo = '{1}' And RecievDocID = {2}", itemId, batchNo,recId));
            return this.DataTable;
        }

        public bool MergeStore(int storeone, int storetwo)
        {
            this.FlushData();
            return this.LoadFromRawSql(String.Format("UPDATE IssueDoc SET StoreID = {0} WHERE StoreID = {1}", storeone, storetwo));
        }

        /// <summary>
        /// Gets the last issued date for the Facility
        /// </summary>
        /// <param name="storeId"></param>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public static DateTime GetLastIssuedDate()
        {
            BLL.IssueDoc id = new IssueDoc();
            id.LoadFromRawSql(String.Format("SELECT TOP (1) EurDate FROM IssueDoc ORDER BY EurDate DESC"));
            DateTime dt = (id.DataTable.Rows.Count > 0) ? Convert.ToDateTime(id.DataTable.Rows[0]["EurDate"]) : new DateTime();

            return dt;
        }
    }
}


// Generated by MyGeneration Version # (1.3.0.3)

using System;
using DAL;
using System.Data;

namespace BLL
{
	public class ItemSupplier : _ItemSupplier
	{
		public ItemSupplier()
		{
		
		}

        public DataTable GetSupplierByItem(int itemId)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.ItemID.Value = itemId;
            this.Query.Load();
            return this.DataTable;
        }

        public void DeleteAllSupForItem(int itemId)
        {
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.ItemID.Value = itemId;
            this.Query.Load();
            foreach(DataRowView dv in this.DataTable.DefaultView)
            {
                this.LoadByPrimaryKey(Convert.ToInt32(dv["ID"]));
                this.MarkAsDeleted();
                this.Save();
            }
        }


        public bool CheckIfExist(int itemId, int supplierId)
        {
            bool exist = false;
            this.FlushData();
            this.Where.WhereClauseReset();
            this.Where.ItemID.Value = itemId;
            this.Where.SupplierID.Conjuction = MyGeneration.dOOdads.WhereParameter.Conj.And;
            this.Where.SupplierID.Value = supplierId;
            this.Query.Load();
            if (this.DataTable.Rows.Count > 0)
                exist = true;

            return exist;
        }

	}
}

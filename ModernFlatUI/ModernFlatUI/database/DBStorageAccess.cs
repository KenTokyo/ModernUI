using Dapper;
using ModernFlatUI.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Windows.Shapes;

namespace ModernFlatUI
{
    public class DBStorageAccess
    {

        private string m_orderBy = "Id";
        private string m_order = "ASC";
        private string m_where = "Title";
        private string m_select = "* from StockData";


        private IDbConnection m_idbConnection;
        public DBStorageAccess(IDbConnection p_idbConnection)
        {
            m_idbConnection = p_idbConnection;
        }

        public List<StockModel> LoadStockData()
        {
            IEnumerable<StockModel> output = null;
            output = m_idbConnection.Query<StockModel>("select " + m_select + " Order By " + m_orderBy + " " + m_order, new DynamicParameters());
            ResetSelection();
            ResetWhere();
            return output.ToList();
        }

        public void SaveStockItem(StockModel stockItem)
        {
            m_idbConnection.Execute("insert into StockData (Title, Qty, Price) values (@Title, @Qty, @Price)", stockItem);
        }

        public void DeleteStockItem(StockModel stockItem)
        {
            m_idbConnection.Execute("DELETE FROM StockData WHERE Id = @Id", stockItem);
        }


        public void UpdateStockItem(StockModel selectedStockItem)
        {
            m_idbConnection.Execute("UPDATE StockData SET Title = '" + selectedStockItem.Title + "', Qty = '" + selectedStockItem.Qty + "' WHERE Id = @Id", selectedStockItem);
        }

        public void SearchForOccurence(String p_keywords)
        {
            m_select = "* from StockData Where " + m_where + " like  '%" + p_keywords + "%'";

        }

        public void OrderByCategory(string p_category)
        {
            m_orderBy = p_category;
        }

        public void OrderType(string p_type)
        {
            m_order = p_type;
        }

        public void SelectWhere(string p_category)
        {
            m_where = p_category;
        }

        public void ResetSelection()
        {
            m_select = "* from StockData ";
        }

        public void ResetWhere()
        {
            m_where = "Title";
        }

    }
}

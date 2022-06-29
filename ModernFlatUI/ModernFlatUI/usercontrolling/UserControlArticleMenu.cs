using ModernFlatUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ModernFlatUI.usercontrolling
{
    public partial class UserControlArticleMenu : UserControl
    {
        private DBStorageAccess m_dbStorage;

        List<StockModel> stockList = new List<StockModel>();

        public UserControlArticleMenu()
        {
            InitializeComponent();
        }

        public void LoadStockList()
        {
            m_dbStorage = FormMainMenu.m_dbStorageAccess;
            stockList = m_dbStorage.LoadStockData();
            WireUpStockList();
        }


        public void WireUpStockList()
        {
            stockListGrid.DataSource = stockList;
        }

        private void AddStockButton_Click(object sender, EventArgs e)
        {
            StockModel stock = new StockModel();

            if (String.IsNullOrWhiteSpace(TitleText.Text) || String.IsNullOrWhiteSpace(QuantityText.Text))
            {
                Utils.ShowErrorForm("Beide Felder müssen ausgefüllt sein!");
                return;
            }

            stock.Title = TitleText.Text;
            stock.Qty = int.Parse(QuantityText.Text);
            stock.Price = textBoxPrice.Text;

            m_dbStorage.SaveStockItem(stock);

            TitleText.Text = "";
            QuantityText.Text = "";
            LoadStockList();
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadStockList();
        }

        private StockModel CheckIfDBIsEmpty()
        {
            try
            {
                StockModel stock = stockListGrid.SelectedRows[0].DataBoundItem as StockModel;
                return stock;
            }
            catch (ArgumentOutOfRangeException)
            {
                Utils.ShowErrorForm("Keine Einträge in Datenbank vorhanden.");
                return null;
            }

        }

        private void RemoveStock_Click(object sender, EventArgs e)
        {

            if (CheckIfDBIsEmpty() != null)
            {
                StockModel stock = stockListGrid.SelectedRows[0].DataBoundItem as StockModel;
                m_dbStorage.DeleteStockItem(stock);
                LoadStockList();
            }

        }

        private void UpdateStockButton_Click(object sender, EventArgs e)
        {
            if (CheckIfDBIsEmpty() != null)
            {
                StockModel selectedStock = stockListGrid.SelectedRows[0].DataBoundItem as StockModel;
                m_dbStorage.UpdateStockItem(selectedStock);
                LoadStockList();
            }
        }


        private void SortingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_dbStorage.OrderByCategory(SortComboBox.SelectedItem.ToString());
            LoadStockList();
        }

        private void ascendingButton_Click(object sender, EventArgs e)
        {
            m_dbStorage.OrderType("ASC");
            LoadStockList();
        }

        private void descendingButton_Click(object sender, EventArgs e)
        {
            m_dbStorage.OrderType("DESC");
            LoadStockList();
        }

        private void SelectWhereBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_dbStorage.SelectWhere(SelectWhereBox.SelectedItem.ToString());
            SearchButton_Click(sender, e);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                m_dbStorage.SearchForOccurence(SearchTextBox.Text);
                LoadStockList();
            }

        }

        private void UserControlArticleMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

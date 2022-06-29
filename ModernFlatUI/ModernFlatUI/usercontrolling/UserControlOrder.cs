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
    public partial class UserControlOrder : UserControl
    {
        private DBStorageAccess m_dbStorage;

        List<StockModel> stockList = new List<StockModel>();
        List<StockModel> selloutList = new List<StockModel>();
        public UserControlOrder()
        {
            InitializeComponent();
        }

        private void OrderUserControl_Load(object sender, EventArgs e)
        {

        }

        public void LoadConnection()
        {
            m_dbStorage = FormMainMenu.m_dbStorageAccess;
        }

        public void FindArticle()
        {
            stockList = m_dbStorage.LoadStockData();
            WireUpStockList();
        }

        public void LoadSelloutList()
        {
            listBoxOrder.DataSource = null;
            listBoxOrder.DataSource = selloutList;
            listBoxOrder.DisplayMember = "Title";
        }

        public void WireUpStockList()
        {
            dataGridView1.DataSource = stockList;
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                m_dbStorage.SearchForOccurence(textBoxTitle.Text);
                FindArticle();
            }

        }


        private StockModel CheckIfDBIsEmpty()
        {
            try
            {
                StockModel stock = dataGridView1.SelectedRows[0].DataBoundItem as StockModel;
                return stock;
            }
            catch (ArgumentOutOfRangeException)
            {
                Utils.ShowErrorForm("Keine Einträge in Datenbank vorhanden.");
                return null;
            }
        }

        private void AddArticleToSellout(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(QuantityText.Text) || String.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                Utils.ShowErrorForm("Beide Felder müssen ausgefüllt sein!");
                return;
            }

            if (CheckIfDBIsEmpty() == null)
            {
                Utils.ShowErrorForm("Datenbank ist leer!");
                return;
            }

            StockModel stock = CheckIfDBIsEmpty();
            selloutList.Add(stock);
            LoadSelloutList();


        }


    }


}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GallerySQL
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=KAAN-MATEBOOK;Initial Catalog=gallery;Integrated Security=True");
        private DataSet galleryset = new DataSet();
        private void searchstockbutton_Click(object sender, EventArgs e)
        {
            LoadData("Select * from stock");
            searchcustomerpanel.Visible = false;
            searchstockpanel.Visible = true;
            searchcostpanel.Visible = false;
        }

        private void searchcostbutton_Click(object sender, EventArgs e)
        {
            searchcustomerpanel.Visible = false;
            searchstockpanel.Visible = false;
            searchcostpanel.Visible = true;
            LoadData("Select * from cost");
        }

        private void searchcustomersbutton_Click(object sender, EventArgs e)
        {
            searchcustomerpanel.Visible = true;
            searchstockpanel.Visible = false;
            searchcostpanel.Visible = false;
            LoadData("Select * from customers");
        }

        private void searchorderbutton_Click(object sender, EventArgs e)
        {
            searchcustomerpanel.Visible = true;
            searchstockpanel.Visible = false;
            searchcostpanel.Visible = false;
            LoadData("Select * from orders");
        }

        private void LoadData(string query)
        {
            if (galleryset.Tables.Count > 0)
            {
                galleryset.Tables.Clear();
            }

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            galleryset.Tables.Add(table);

            dataviewgrid.DataSource = galleryset.Tables[0];
        }

        private void ApplyFilter(string filterColumn, string filterValue)
        {
            if (string.IsNullOrWhiteSpace(filterValue))
            {
                dataviewgrid.DataSource = galleryset.Tables[0];
                return;
            }

            DataView dv = galleryset.Tables[0].DefaultView;
            dv.RowFilter = string.Format("{0} LIKE '%{1}%'", filterColumn, filterValue);
            dataviewgrid.DataSource = dv;
        }


        private void searchstockbrandtext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("brand", searchstockbrandtext.Text);
        }

        private void searchstockserialcodetext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("serialcode", searchstockserialcodetext.Text);
        }

        private void searchstockmodeltext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("model", searchstockmodeltext.Text);
        }

        private void searchstockcaryeartext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("model", searchstockcaryeartext.Text);
        }

        private void searchstockpricetext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("price", searchstockpricetext.Text);
        }

        private void searchstockarrivaldatetext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("arrivaldate", searchstockarrivaldatetext.Text);
        }

        private void searchcostserialcodetext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("serialcode", searchcostserialcodetext.Text);
        }

        private void searchcostcosttext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("cost", searchcostcosttext.Text);
        }

        private void searchcostannualcosttext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("annualcost", searchcostannualcosttext.Text);
        }

        private void searchcustomercustomeridtext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("customerid", searchcustomercustomeridtext.Text);
        }

        private void searchcustomernametext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("customername", searchcustomernametext.Text);
        }

        private void searchcustomercontacttext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("contact", searchcustomercontacttext.Text);
        }

        private void searchcustomeremailtext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("email", searchcustomeremailtext.Text);
        }

        private void searchorderorderidtext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("orderid", searchorderorderidtext.Text);
        }

        private void searchordercustomeridtext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("customerid", searchordercustomeridtext.Text);
        }

        private void searchorderserialcodetext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("serialcode", searchorderserialcodetext.Text);
        }

        private void searchorderreceiptcodetext_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter("receiptcode", searchorderreceiptcodetext.Text);
        }
    }
}

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
    public partial class Crud : Form
    {

        private DataSet galleryset = new DataSet();
        public Crud()
        {
            InitializeComponent();
            selectionscreen.Visible = true;
            insertscreen.Visible = false;
            updatescreen.Visible = false;
            
        }


        SqlConnection conn = new SqlConnection("Data Source=KAAN-MATEBOOK;Initial Catalog=gallery;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            toinsertpage.Visible = true;
            toupdatescreen.Visible = false;
        }
        private void insertstock_Click(object sender, EventArgs e)
        {
            stockPanel.Visible = true;
            orderpanel.Visible = false;
            customerpanel.Visible = false;
            costPanel.Visible = false;
        }

        private void insertcost_Click(object sender, EventArgs e)
        {
            stockPanel.Visible = false;
            orderpanel.Visible = false;
            customerpanel.Visible = false;
            costPanel.Visible = true;
        }

        private void insertcustomer_Click(object sender, EventArgs e)
        {
            stockPanel.Visible = false;
            orderpanel.Visible = false;
            customerpanel.Visible = true;
            costPanel.Visible = false;
        }

        private void insertorder_Click(object sender, EventArgs e)
        {
            stockPanel.Visible = false;
            orderpanel.Visible = true;
            customerpanel.Visible = false;
            costPanel.Visible = false;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (stockPanel.Visible)
            {
                insertstockdata();
            }
            else if (orderpanel.Visible)
            {
                insertorderdata();
            }
            else if (customerpanel.Visible)
            {
                insertcustomerdata();
            }
            else if (costPanel.Visible)
            {
                insertcostdata();
            }
        }

        private void insertcustomerdata()
        {
            SqlCommand insertcustomer = new SqlCommand("insert into customers(CustomerID,CustomerName,Contact,Email) values(@cid,@name,@con,@mail)", conn);
            insertcustomer.Parameters.AddWithValue("@cid", insertcustomercustomeridtext.Text);
            insertcustomer.Parameters.AddWithValue("@name", insertcustomercustomernametext.Text);
            insertcustomer.Parameters.AddWithValue("@con", insertcustomercontacttext.Text);
            insertcustomer.Parameters.AddWithValue("@mail", insertcustomeremailtext.Text);
            conn.Open();
            insertcustomer.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully to Customers");
            insertcustomercustomeridtext.Text = "";
            insertcustomercustomernametext.Text = "";
            insertcustomercontacttext.Text = "";
            insertcustomeremailtext.Text = "";
        }

        private void insertstockdata()
        {
            SqlCommand insertstock = new SqlCommand("insert into stock(SerialCode,Brand,Model,CarYear,Price,ArrivalDate) values (@sr,@br,@mo,@cr,@pr,@ad)", conn);
            insertstock.Parameters.AddWithValue("@sr", serialcodestocktextbox.Text);
            insertstock.Parameters.AddWithValue("@br", brandinsertstock.Text);
            insertstock.Parameters.AddWithValue("@mo", modelinsertstock.Text);
            insertstock.Parameters.AddWithValue("@cr", caryearinsertstock.Text);
            insertstock.Parameters.AddWithValue("@pr", priceinsertstock.Text);
            insertstock.Parameters.AddWithValue("ad", arrivaldateinsertstock.Text);
            conn.Open();

            insertstock.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Saved Successfully to Stock");
            serialcodestocktextbox.Text = "";
            brandinsertstock.Text = "";
            modelinsertstock.Text = "";
            caryearinsertstock.Text = "";
            priceinsertstock.Text = "";
            arrivaldateinsertstock.Text = "";
        }

        private void insertorderdata()
        {
            SqlCommand insertorder = new SqlCommand("insert into orders(OrderID,CustomerID,SerialCode,ReceiptCode) values(@oid,@cid,@sc,@rc", conn);
            insertorder.Parameters.AddWithValue("@oid", orderinsertorderidtext.Text);
            insertorder.Parameters.AddWithValue("@cid", orderinsertcustomeridtext.Text);
            insertorder.Parameters.AddWithValue("@sc", orderinsertserialcodetext.Text);
            insertorder.Parameters.AddWithValue("@rc", orderinsertreceiptcodetext.Text);
            conn.Open();
            insertorder.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully to Orders");
            orderinsertorderidtext.Text = "";
            orderinsertcustomeridtext.Text = "";
            orderinsertserialcodetext.Text = "";
            orderinsertreceiptcodetext.Text = "";
        }

        private void insertcostdata()
        {
            SqlCommand insertcost = new SqlCommand("insert into cost(SerialCode,MaintenanceCost,AnnualCost) values (@sc,@mc,@ac)", conn);
            insertcost.Parameters.AddWithValue("@sc", costserialcodetext.Text);
            insertcost.Parameters.AddWithValue("@mc", costmaintenancecosttext.Text);
            insertcost.Parameters.AddWithValue("@ac", costannualcosttext.Text);
            conn.Open();
            insertcost.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully to Cost");
            costserialcodetext.Text = "";
            costmaintenancecosttext.Text = "";
            costannualcosttext.Text = "";
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            if (deletescreen.Visible) 
            {
                deletescreen.Visible = false; 
                todeletepage.Visible = true; 
                updatescreen.Visible = true; 
            }
            else if (updatescreen.Visible) 
            {
                updatescreen.Visible = false; 
                insertscreen.Visible = true; 
                toupdatescreen.Visible = true;
                toinsertpage.Visible = false;
            }
            else if (insertscreen.Visible) 
            {
                insertscreen.Visible = false; 
                toinsertpage.Visible = true; 
                toupdatescreen.Visible = false;
            }



        }

        private void toupdatescreen_Click(object sender, EventArgs e)
        { 
            updatescreen.Visible = true;
            toinsertpage.Visible = true;
            toupdatescreen.Visible = false;
            deletescreen.Visible = false;  
        }

        

        private void toinsertpage_Click(object sender, EventArgs e)
        {
            insertscreen.Visible = true;
            toinsertpage.Visible = false;
            updatescreen.Visible = false;
            toupdatescreen.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (galleryset.Tables.Count > 0)
            {
                galleryset.Tables.Clear();
            }

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM stock", conn);
            DataTable stockTable = new DataTable();
            adapter.Fill(stockTable);
            galleryset.Tables.Add(stockTable);

            dataGridView1.DataSource = galleryset.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (galleryset.Tables.Count > 0)
            {
                galleryset.Tables.Clear();
            }

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM cost", conn);
            DataTable costTable = new DataTable();
            adapter.Fill(costTable);
            galleryset.Tables.Add(costTable);

            dataGridView1.DataSource = galleryset.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (galleryset.Tables.Count > 0)
            {
                galleryset.Tables.Clear();
            }

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM customers", conn);
            DataTable customersTable = new DataTable();
            adapter.Fill(customersTable);
            galleryset.Tables.Add(customersTable);

            dataGridView1.DataSource = galleryset.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (galleryset.Tables.Count > 0)
            {
                galleryset.Tables.Clear();
            }

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM orders", conn);
            DataTable ordersTable = new DataTable();
            adapter.Fill(ordersTable);
            galleryset.Tables.Add(ordersTable);

            dataGridView1.DataSource = galleryset.Tables[0];
        }


        private void button5_Click(object sender, EventArgs e)
        {
            updatescreen.Visible = false;
            insertscreen.Visible = true;
            toupdatescreen.Visible = true;
        }

        private void updatescreenupdatestockbutton_Click(object sender, EventArgs e)
        {
            updatescreenserialcodestockpanel.Visible = true;
            updatescreenorderidpanel.Visible = false;
            updatescreenserialcodecostpanel.Visible = false;
            updatescreencustomeridpanel.Visible = false;    
        }

        private void updatescreenupdatecost_Click(object sender, EventArgs e)
        {
            updatescreenserialcodestockpanel.Visible = false;
            updatescreenorderidpanel.Visible = false;
            updatescreenserialcodecostpanel.Visible = true;
            updatescreencustomeridpanel.Visible = false;
        }

        private void updatescreenupdatecustomerbutton_Click(object sender, EventArgs e)
        {
            updatescreenserialcodestockpanel.Visible = false;
            updatescreenorderidpanel.Visible = false;
            updatescreenserialcodecostpanel.Visible = false;
            updatescreencustomeridpanel.Visible = true;
        }

        private void updatescreenupdateorderbutton_Click(object sender, EventArgs e)
        {
            updatescreenserialcodestockpanel.Visible = false;
            updatescreenorderidpanel.Visible = true;
            updatescreenserialcodecostpanel.Visible = false;
            updatescreencustomeridpanel.Visible = false;
        }

        private void updatescreengotoupdatebutton_Click(object sender, EventArgs e)
        {
            if (updatescreenserialcodestockpanel.Visible)
            {
                updatescreenupdateorderpanel.Visible = false;
                updatescreenupdatecostpanel.Visible = false;
                updatescreenupdatecustomerpanel.Visible = false;
                updatescreenupdatestockpanel.Visible = true;

            }
            else if (updatescreenserialcodecostpanel.Visible)
            {
                updatescreenupdateorderpanel.Visible = false;
                updatescreenupdatecostpanel.Visible = true;
                updatescreenupdatecustomerpanel.Visible = false;
                updatescreenupdatestockpanel.Visible = false;
            }

            else if (updatescreenorderidpanel.Visible)
            {
                updatescreenupdateorderpanel.Visible = true;
                updatescreenupdatecostpanel.Visible = false;
                updatescreenupdatecustomerpanel.Visible = false;
                updatescreenupdatestockpanel.Visible = false;
            }
            else if (updatescreencustomeridpanel.Visible)
            {
                updatescreenupdateorderpanel.Visible = false;
                updatescreenupdatecostpanel.Visible = false;
                updatescreenupdatecustomerpanel.Visible = true;
                updatescreenupdatestockpanel.Visible = false;
            }
        }

        private void updatescreenupdatebutton_Click(object sender, EventArgs e)
        {
            if (updatescreenupdatecustomerpanel.Visible)
            {
                updatecustomerdata();
            }
            else if (updatescreenupdatecostpanel.Visible)
            {
                updatecostdata();
            }
            else if (updatescreenupdatestockpanel.Visible)
            {
                updatestockdata();
            }
            else if (updatescreenupdateorderpanel.Visible)
            {
                updateorderdata();
            }
        }


        private void updatestockdata()
        {
            SqlCommand updatestock = new SqlCommand("UPDATE Stock SET Brand = @br,Model = @mo, CarYear = @cy, @Price = @pr, ArrivalDate = @ad where SerialCode = @sc", conn);
            updatestock.Parameters.AddWithValue("@br", updatestockpanelbrandlabel.Text);
            updatestock.Parameters.AddWithValue("@mo", updatestockpanelmodeltext.Text);
            updatestock.Parameters.AddWithValue("@cy", updatestockpanelcaryeartext.Text);
            updatestock.Parameters.AddWithValue("@pr", updatestockpanelpricetext.Text);
            updatestock.Parameters.AddWithValue("ad", updatestockpanelarrivaldatetext.Text);
            updatestock.Parameters.AddWithValue("@sc",updatescreenstockserialcodetext.Text);

            conn.Open();
            updatestock.ExecuteNonQuery();
            MessageBox.Show("Updated Succesfully :)");
            conn.Close();
        }

        private void updatecostdata()
        {
            SqlCommand updatecost = new SqlCommand("UPDATE Cost SET MaintenanceCost = @mc ,AnnualCost =@mc*2 where SerialCode = @sc", conn);
            updatecost.Parameters.AddWithValue("@mc", updatecostpanelcosttext.Text);
            updatecost.Parameters.AddWithValue("@sc", updatescreenserialcodecosttext.Text);
            conn.Open();
            updatecost.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully :)");
            conn.Close();
        }

        private void updateorderdata()
        {
            SqlCommand updateorder = new SqlCommand("UPDATE Orders SET ReceiptCode = @rc where OrderID = @oid", conn);
            updateorder.Parameters.AddWithValue("@rc", updatescreenupdateorderreceiptcodetext.Text);
            updateorder.Parameters.AddWithValue("@oid", updatescreenorderidinputtext.Text);
            conn.Open();
            updateorder.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully :)");
            conn.Close();
        }

        private void updatecustomerdata()
        {
            SqlCommand updatecustomer = new SqlCommand("UPDATE Customers SET CustomerName = @name,Contact = @con,Email = @mail WHERE CustomerID = @cid", conn);

            updatecustomer.Parameters.AddWithValue("@name", updatescreenupdatecustomernametext.Text);
            updatecustomer.Parameters.AddWithValue("@con", updatescreenupdatecontacttext.Text);
            updatecustomer.Parameters.AddWithValue("@mail", updatescreenupdateemailtext.Text);
            updatecustomer.Parameters.AddWithValue("@cid", updatescreencustomeridtext.Text);

            conn.Open();
            updatecustomer.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully :)");
            conn.Close();
        }

        private void todeletepage_Click(object sender, EventArgs e)
        {
            deletescreen.Visible = true;
            toupdatescreen.Visible = false;
        }

        private void deletefromstockbutton_Click(object sender, EventArgs e)
        {
            deletestockpanel.Visible = true;
            deletecostpanel.Visible = false;
            deleteorderpanel.Visible = false;
            deletecustomerpanel.Visible = false;
        }

        private void deletecostbutton_Click(object sender, EventArgs e)
        {
            deletecostpanel.Visible = true;
            deletestockpanel.Visible = false;
            deleteorderpanel.Visible = false;
            deletecustomerpanel.Visible = false;
        }

        private void deletecustomerbutton_Click(object sender, EventArgs e)
        {
            deletecostpanel.Visible = false;
            deletestockpanel.Visible = false;
            deleteorderpanel.Visible = false;
            deletecustomerpanel.Visible = true;
        }

        private void deleteorderbutton_Click(object sender, EventArgs e)
        {
            deletecostpanel.Visible = false;
            deletestockpanel.Visible = false;
            deleteorderpanel.Visible = true;
            deletecustomerpanel.Visible = false;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                                          "Confirm Delete",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                if (deletestockpanel.Visible)
                {
                    SqlCommand deletefromstock = new SqlCommand("DELETE from stock where SerialCode = @sc", conn);
                    deletefromstock.Parameters.AddWithValue("@sc", deletefromstocktext.Text);
                    conn.Open();
                    deletefromstock.ExecuteNonQuery();
                    MessageBox.Show("Data deleting was successful");
                    conn.Close();
                }
                else if (deletecostpanel.Visible)
                {
                    SqlCommand deletefromcost = new SqlCommand("Delete from cost where serialcode = @sc", conn);
                    deletefromcost.Parameters.AddWithValue("@sc", deletefromcosttext.Text);
                    conn.Open();
                    deletefromcost.ExecuteNonQuery();
                    MessageBox.Show("Data deleting was successful");
                    conn.Close();
                }
                else if (deletecustomerpanel.Visible)
                {
                    SqlCommand deletefromcustomer = new SqlCommand("Delete from customers where CustomerID = @cid", conn);
                    deletefromcustomer.Parameters.AddWithValue("@cid", deletefromcustomertext.Text);
                    conn.Open();
                    deletefromcustomer.ExecuteNonQuery();
                    MessageBox.Show("Data deleting was successful");
                    conn.Close();
                }
                else if (deleteorderpanel.Visible)
                {
                    SqlCommand deletefromorder = new SqlCommand("Delete from orders where OrderID = @oid", conn);
                    deletefromorder.Parameters.AddWithValue("@oid", deletefromordertext.Text);
                    conn.Open();
                    deletefromorder.ExecuteNonQuery();
                    MessageBox.Show("Data deleting was successful");
                    conn.Close();
                }
            } 
            else if(result == DialogResult.No)
            {
                MessageBox.Show("Nothing was deleted :)");
            }
            
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search search = new Search();
            search.Show();
        }
    }
}

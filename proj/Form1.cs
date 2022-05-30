using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projectsamozachet
{
    public partial class Form1 : Form
    {
        Facade facade;
        MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();

            this.facade = new Facade();
            this.connection = new MySqlConnection("server=127.0.0.1;username=root;password=root;database=automasterskaya");
            connect();
        }

        public Form1(Facade facade)
        {
            InitializeComponent();

            this.facade = facade;
            this.connection = new MySqlConnection("server=127.0.0.1;username=root;password=root;database=automasterskaya");
        }

        private void ingredient_Click(object sender, EventArgs e)
        {
            //Ingredient ingredient = new Ingredient(facade, this);
            //ingredient.Show();
            //Hide();
        }

        private void dish_Click(object sender, EventArgs e)
        {
            ClientForm cl = new ClientForm(facade, this);
            cl.Show();
            Hide();
        }

        private void product_Click(object sender, EventArgs e)
        {
            //Product product = new Product(facade, this);
            //product.Show();
            //Hide();
        }

        void connect()
        {
            string query = "SELECT * FROM client";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
                facade.create_client_list(row.ItemArray);
            query = "SELECT * FROM visit";
            table = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
                facade.create_visit_list(row.ItemArray);
        }
    }
}

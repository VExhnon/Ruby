using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace projectsamozachet
{
    public partial class ClientForm : Form
    {
        Facade facade;
        Form1 form1;
        MySqlConnection connection;
        MySqlCommand command;

        public ClientForm(Facade facade, Form1 form1)
        {
            InitializeComponent();

            this.facade = facade;
            this.form1 = form1;
            this.connection = new MySqlConnection("server=127.0.0.1;username=root;password=root;database=restaurant");
            connect();
        }

        void connect()
        {
            init_view();
            data_reuse();
        }

        void init_view()
        {
            this.dgv_dish.Columns.Add("clientID", "clientID");
            this.dgv_dish.Columns.Add("Name", "Name");
            this.dgv_dish.Columns.Add("Surname", "Surname");
            this.dgv_dish.Columns.Add("LastName", "LastName");
            this.dgv_dish.Columns.Add("automobil", "automobil");
            this.dgv_dish.Columns.Add("phone", "phone");
        }

        void data_reuse()
        {
            this.dgv_dish.Rows.Clear();
            List<List<string>> list_cl = this.facade.client_List.mass_klient();
            foreach (List<string> cl in list_cl)
                dgv_dish.Rows.Add(cl[0], cl[1], cl[2], cl[3], cl[4], cl[5]);
        }

        private void Dish_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            int id_dish = Convert.ToInt32(tb_id_dish.Text);
            string name_dish = tb_name_dish.Text;
            string type_dish = tb_type_dish.Text;
            int weight_gram = Convert.ToInt32(tb_weight_gram.Text);
            int price_rub = Convert.ToInt32(tb_price_rub.Text);
            /*if (el_is_valid(name_dish, price_1kg_rub.ToString()) &&
                (!facade.dish_list.get_list_id().Contains(id_dish.ToString())))
            {*/
            Object[] list = { id_dish, name_dish, type_dish, weight_gram, price_rub };
            //facade.create_dish_list(list);
            string insert_query = "INSERT INTO dish(id_dish, name_dish, type_dish, " +
                "weight_gram, price_rub) VALUES " +
                $"({id_dish}, \"{name_dish}\", \"{type_dish}\", {weight_gram}, {price_rub})";
            executeMyQuery(insert_query);
            /*}*/
            data_reuse();
        }
        private void button_update_Click(object sender, EventArgs e)
        {
            int id_dish = Convert.ToInt32(tb_id_dish.Text);
            string name_dish = tb_name_dish.Text;
            string type_dish = tb_type_dish.Text;
            int weight_gram = Convert.ToInt32(tb_weight_gram.Text);
            int price_rub = Convert.ToInt32(tb_price_rub.Text);
            /*if (el_is_valid(name_dish, price_1kg_rub.ToString()) &&
                (!facade.dish_list.get_list_id().Contains(id_dish.ToString())))
            {*/
            Object[] list = { id_dish, name_dish, type_dish, weight_gram, price_rub };
            //facade.update_client_List(list);
            string insert_query = string.Format("UPDATE dish SET " +
                "`id_dish`={0}, `name_dish`='{1}', `type_dish`='{2}', " +
                "`weight_gram`={3}, `price_rub`={4} " +
                "WHERE `id_dish`={0}",
                id_dish.ToString(), name_dish, type_dish,
                weight_gram.ToString(), price_rub.ToString());
            executeMyQuery(insert_query);
            /*}*/
            data_reuse();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            facade.client_List.delete_el(Convert.ToInt32(tb_id_dish.Text));
            string insert_query = string.Format("DELETE FROM `dish` WHERE `id_dish`={0}",
                Convert.ToInt32(tb_id_dish.Text));
            executeMyQuery(insert_query);
            data_reuse();
        }

        private bool el_is_valid(string name_dish, string price_rub)
        {
            bool flag = true;
            string regex = @"[0-9]{11}";
            if (!Regex.IsMatch(price_rub, regex))
                flag = false;
            if (name_dish == "")
                flag = false;
            return flag;
        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    execute_info.ForeColor = System.Drawing.Color.Green;
                    execute_info.Text = "Выполнено";
                }
                else
                {
                    execute_info.ForeColor = System.Drawing.Color.Red;
                    execute_info.Text = "Не выполнено";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        private void dgv_dish_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using daunTrip.screen;
using MySql.Data.MySqlClient;


namespace daunTrip
{

    public partial class Add_Room : Form
    {

        string _server = "localhost";
        int _port = 3306;
        string _database = "new_schema";
        string _id = "root";
        string _pw = "123456";
        string _connection = "4";


        //screen.china chinaScreen = new screen.china();
        //screen.japan japanScreen = new screen.japan();
        //screen.korea koreaScreen = new screen.korea();

        //public Button CreateButton(string Name, string text)
        //{
        //    Button btn = new Button();
        //    btn.Name = Name;
        //    btn.Text = text;
        //    btn.Dock = DockStyle.Fill;

        //    return btn;
        //}




        //private void selectTable() 
        //{

        //    try
        //    {
        //        using (MySqlConnection mysql = new MySqlConnection(_connection))
        //        {
        //            mysql.Open();

        //            string selectQuery = string.Format("SELECT * FROM room_table");

        //            MySqlCommand command = new MySqlCommand(selectQuery, mysql);

        //            MySqlDataReader table = command.ExecuteReader();
                    
        //            while (table.Read())
        //            {
        //                TableLayoutPanel item = new TableLayoutPanel();
        //                CreateButton(item.Name, item.Text);
        //            }
                  
                    
        //            while (table.Read())
        //            {
        //                Button btn = CreateButton("button1", "btn1");

     
        //            }

        //                label4.Text = "done";

                    
        //            table.Close();
        //        }

        //    } catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        public Add_Room()
        {
            InitializeComponent();
            _connection = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
                                                                          
            string seletedOption = null;
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    seletedOption = radioButton.Text; // clicked radio value
                       break;
                }
            }
       
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    mysql.Open();

                    string formattedDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    string insertQuery = string.Format("INSERT INTO room_table(country, title, name, date) VALUES ('{0}','{1}','{2}','{3}');", seletedOption, textBox1.Text, textBox2.Text, formattedDate);

                    MySqlCommand cmd = new MySqlCommand(insertQuery, mysql);
                    if (cmd.ExecuteNonQuery() != 1)
                        MessageBox.Show("failed to insert data");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    //selectTable();
                    
                }
            } catch (Exception exc)


            {
                MessageBox.Show(exc.Message);
            }
            

            
        }

        private void Add_Room_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }


    

    }
}

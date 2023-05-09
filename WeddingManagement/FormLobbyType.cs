using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WeddingManagement
{
    public partial class FormLobbyType : Form
    {
        public static string currentTypeId = "";
        DataTable table = new DataTable();
        DataColumn column;
        DataRow row;

        void load_data_LobbyType()
        {
            table = new DataTable();
            // first column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "LobbyTypeName";
            column.AutoIncrement = false;
            column.Caption = "Type";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            // second column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int64");
            column.ColumnName = "MinTablePrice";
            column.AutoIncrement = false;
            column.Caption = "Minimum Table Price";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);

            // third column
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "LobbyTypeNo";
            column.AutoIncrement = false;
            column.Caption = "LobbyTypeNo";
            column.ReadOnly = true;
            column.Unique = true;
            column.ColumnMapping = MappingType.Hidden;
            table.Columns.Add(column);

            DataColumn[] keys = new DataColumn[1];
            keys[0] = table.Columns["LobbyTypeNo"];
            table.PrimaryKey = keys;

            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;


            List<LobbyType> lobbyTypes = new List<LobbyType>();
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM LOBBY_TYPE WHERE Available > 0", sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lobbyTypes.Add(
                                new LobbyType(
                                    reader["LobbyTypeNo"].ToString(), 
                                    reader["LobbyName"].ToString(), 
                                    Convert.ToInt64(reader["MinTablePrice"])
                                    )
                                );
                        }
                    }
                }
            }
            WeddingClient.listLobbyTypes = lobbyTypes;
            foreach (LobbyType lobbyType in lobbyTypes)
            {
                row = table.NewRow();
                row["LobbyTypeName"] = lobbyType.LobbyName;
                row["MinTablePrice"] = lobbyType.MinTablePrice;
                row["LobbyTypeNo"] = lobbyType.LobbyTypeNo;
                table.Rows.Add(row);
            }
        }
        public FormLobbyType()
        {
            InitializeComponent();
        }

        private void FormLobbyType_Load(object sender, EventArgs e)
        {
            load_data_LobbyType();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= table.Rows.Count)
            {
                currentTypeId = "";
                return;
            }
            var rowItem = (DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            int i = table.Rows.IndexOf(rowItem.Row);
            DataRow row = table.Rows[i];
            comboBox1.Text = row[0].ToString();
            textBox1.Text = row[1].ToString();
            if (i < WeddingClient.listLobbyTypes.Count)
            {
                currentTypeId = WeddingClient.listLobbyTypes[i].LobbyTypeNo;
            }
            else
            {
                currentTypeId = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WeddingClient.client_priority > 2)
            {
                MessageBox.Show("You don't have permission to do this!", "NOT PERMIT", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (comboBox1.Text == "" || !long.TryParse(textBox1.Text, out long price))
                {
                    MessageBox.Show("Please fill all the fields!", "LACK", MessageBoxButtons.OK);
                }
                else
                {
                    using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                    {
                        sql.Open();
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO LOBBY_TYPE (LobbyTypeNo, LobbyName, MinTablePrice, " +
                            "Available) VALUES (@LobbyTypeNo, @LobbyName, @MinTablePrice, 1)", sql))
                        {
                            string newTypeId = "LT" + WeddingClient.GetNewIdFromTable("LT").ToString().PadLeft(19, '0');
                            cmd.Parameters.AddWithValue("@LobbyTypeNo", newTypeId);
                            cmd.Parameters.AddWithValue("@LobbyName", comboBox1.Text);
                            cmd.Parameters.AddWithValue("@MinTablePrice", price);
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                row = table.NewRow();
                                row["LobbyTypeName"] = comboBox1.Text;
                                row["MinTablePrice"] = price;
                                row["LobbyTypeNo"] = newTypeId;
                                table.Rows.Add(row);
                                MessageBox.Show("New type added!");
                                WeddingClient.listLobbyTypes.Add(new LobbyType(newTypeId, comboBox1.Text, price));
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WeddingClient.client_priority > 2)
            {
                MessageBox.Show("You don't have permission to do this!", "NOT PERMIT", MessageBoxButtons.OK);
                return;
            }
            else
            {
                // check if current type ID is not empty
                if (currentTypeId == "")
                {
                    MessageBox.Show("Please select a type!", "LACK", MessageBoxButtons.OK);
                }
                else
                {
                    using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                    {
                        sql.Open();
                        using (SqlCommand cmd = new SqlCommand("UPDATE LOBBY_TYPE " +
                            "SET Available = 0 WHERE LobbyTypeNo = @LobbyTypeNo", sql))
                        {
                            cmd.Parameters.AddWithValue("@IdLobbyType", currentTypeId);
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                foreach (LobbyType lobbyType in WeddingClient.listLobbyTypes)
                                {
                                    if (lobbyType.LobbyTypeNo == currentTypeId)
                                    {
                                        WeddingClient.listLobbyTypes.Remove(lobbyType);
                                        break;
                                    }
                                }
                                table.Rows.Remove(table.Rows.Find(currentTypeId));
                                MessageBox.Show("Type deleted!", "SUCCESS", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
                FormLobbyType.currentTypeId = "";
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (WeddingClient.client_priority > 2)
            {
                MessageBox.Show("You don't have permission to do this!", "NOT PERMIT", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (comboBox1.Text == "" || !long.TryParse(textBox1.Text, out long price))
                {
                    MessageBox.Show("Please fill all the fields!", "LACK", MessageBoxButtons.OK);
                }
                else
                {
                    if (currentTypeId == "")
                    {
                        MessageBox.Show("Please select a type!", "LACK", MessageBoxButtons.OK);
                    }
                    else
                    {
                        using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                        {
                            sql.Open();
                            using (SqlCommand cmd = new SqlCommand("UPDATE LOBBY_TYPE " +
                                "SET LobbyName=@name, MinTablePrice=@price WHERE LobbyTypeNo = @LobbyTypeNo", sql))
                            {
                                cmd.Parameters.AddWithValue("@LobbyTypeNo", currentTypeId);
                                cmd.Parameters.AddWithValue("@name", comboBox1.Text);
                                cmd.Parameters.AddWithValue("@price", long.Parse(textBox1.Text));
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Type Update!", "SUCCESS", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
                    FormLobbyType.currentTypeId = "";
                    load_data_LobbyType();
                }
            }
        }
    }
}
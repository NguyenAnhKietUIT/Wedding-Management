using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WeddingManagement
{
    public partial class FormWedding : Form
    {
        public static string currentWeddingId = "";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table1 = new DataTable();

        public FormWedding()
        {
            InitializeComponent();
            load_gridView_wedding();
            load_comboBox_shift();
            load_comboBox_lobby();
            load_comboBox_menu();
            load_comboBox_service();
        }

        public FormWedding(string id) : this()
        {
            FormWedding.currentWeddingId = id;
            Load_data_wedding(id);
        }

        void Load_data_wedding(string id)
        {
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT LobbyName, ShiftName, Representative, PhoneNumber, BookingDate, " +
                    "WeddingDate, GroomName, BrideName, AmountOfTable, AmountOfContingencyTable, TablePrice, Deposit, " +
                    "WD.LobbyNo, S.ShiftNo FROM LOBBY LB, SHIFT S, WEDDING WD WHERE WD.ShiftNo = S.ShiftNo AND " +
                    "WD.LobbyNo = LB.LobbyNo AND WD.WeddingNo = @id", sql))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cbb_lobby.SelectedIndex = WeddingClient.listLobbies.FindIndex(
                                x => x.LobbyNo == reader["LobbyNo"].ToString());
                            cbb_shift.SelectedIndex = WeddingClient.listShifts.FindIndex(
                                x => x.ShiftNo == reader["ShiftNo"].ToString());
                            cbt_representative.Text = reader.GetString(2);
                            cbt_phone.Text = reader.GetString(3);
                            date_booking.Value = reader.GetDateTime(4);
                            date_wedding.Value = reader.GetDateTime(5);
                            cbt_groom.Text = reader.GetString(6);
                            cbt_bride.Text = reader.GetString(7);
                            cbt_table.Text = reader.GetInt32(8).ToString();
                            cbt_contigency.Text = reader.GetInt32(9).ToString();
                            cbt_deposit.Text = reader.GetInt64(11).ToString();

                            DataRow row = table1.NewRow();
                            row.ItemArray = new object[] { reader["LobbyName"].ToString(), reader["ShiftName"].ToString(), cbt_representative.Text, cbt_phone.Text, date_booking.Value.ToString(), date_wedding.Value.ToString(), cbt_groom.Text, cbt_bride.Text, cbt_table.Text, cbt_contigency.Text, 0, cbt_deposit.Text, id };
                            table1.Rows.Add(row);
                        }
                    }
                }
            }
        }

        void load_gridView_wedding()
        {
            DataColumn column;
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "lobbyName";
            column.AutoIncrement = false;
            column.Caption = "Lobby name";
            column.ReadOnly = true;
            column.Unique = false;
            table1.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "shiftName";
            column.AutoIncrement = false;
            column.Caption = "Shift";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "representative";
            column.AutoIncrement = false;
            column.Caption = "Representative";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "phoneNumber";
            column.AutoIncrement = false;
            column.Caption = "Phone number";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.DateTimeMode = DataSetDateTime.Unspecified;
            column.ColumnName = "bookingDate";
            column.AutoIncrement = false;
            column.Caption = "Booking date";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.DateTimeMode = DataSetDateTime.Unspecified;
            column.ColumnName = "weddingDate";
            column.AutoIncrement = false;
            column.Caption = "Wedding date";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "groomName";
            column.AutoIncrement = false;
            column.Caption = "Groom name";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "brideName";
            column.AutoIncrement = false;
            column.Caption = "Bride name";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "amountOfTable";
            column.AutoIncrement = false;
            column.Caption = "Amount of table";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "amountOfContingencyTable";
            column.AutoIncrement = false;
            column.Caption = "Amount of contingency table";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int64");
            column.ColumnName = "tablePrice";
            column.AutoIncrement = false;
            column.Caption = "Table price";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int64");
            column.ColumnName = "deposit";
            column.AutoIncrement = false;
            column.Caption = "Deposit";
            column.ReadOnly = false;
            column.Unique = false;
            table1.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "WeddingNo";
            column.AutoIncrement = false;
            column.Caption = "WeddingNo";
            column.ReadOnly = false;
            column.Unique = false;
            column.ColumnMapping = MappingType.Hidden;
            table1.Columns.Add(column);

            dataWedding.DataSource = table1;
            foreach (DataGridViewColumn col in dataWedding.Columns)
            {
                col.HeaderText = table1.Columns[col.DataPropertyName].Caption;
            }
            dataWedding.Columns["bookingDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataWedding.Columns["weddingDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            dataWedding.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataWedding_RowHeaderMouseClick);
        }

        private void dataWedding_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var rowItem = (DataRowView)dataWedding.Rows[e.RowIndex].DataBoundItem;
            int index = table1.Rows.IndexOf(rowItem.Row);
            DataRow row = table1.Rows[index];
            FormWedding.currentWeddingId = row["WeddingNo"].ToString();
            Console.WriteLine(FormWedding.currentWeddingId);
        }

        void load_comboBox_shift()
        {
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ShiftNo, ShiftName, Starting, Ending FROM SHIFT " +
                    "where Available > 0", sql))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            WeddingClient.listShifts = new List<Shift>();
                            var dt = new DataTable();
                            dt.Load(dr);
                            cbb_shift.DataSource = dt;
                            cbb_shift.DisplayMember = "ShiftName";
                            foreach (DataRow row in dt.Rows)
                            {
                                WeddingClient.listShifts.Add(new Shift()
                                {
                                    ShiftNo = row["ShiftNo"].ToString(),
                                    ShiftName = row["ShiftName"].ToString(),
                                    Starting = (TimeSpan)row["Starting"],
                                    Ending = (TimeSpan)row["Ending"]
                                }); ;
                            }
                        }
                    }
                }
            }
        }

        void load_comboBox_lobby()
        {
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT LobbyNo, LobbyNoType, LobbyName, MaxTable, Note FROM LOBBY " +
                    "WHERE Available > 0", sql))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            WeddingClient.listLobbies = new List<Lobby>();
                            var dt = new DataTable();
                            dt.Load(dr);
                            dr.Dispose();
                            cbb_lobby.DataSource = dt;
                            cbb_lobby.DisplayMember = "LobbyName";
                            foreach (DataRow row in dt.Rows)
                            {
                                WeddingClient.listLobbies.Add(
                                    new Lobby(
                                        row["LobbyNo"].ToString(), 
                                        row["LobbyNoType"].ToString(), 
                                        row["LobbyName"].ToString(), 
                                        Convert.ToInt32(row["MaxTable"]), 
                                        row["Note"].ToString()
                                        )
                                    );
                            }
                        }
                    }
                }
            }
        }

        void load_comboBox_menu()
        {
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ItemNo, ItemName, ItemPrice FROM MENU " +
                    "where Available > 0", sql))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            WeddingClient.listItems = new List<Item>();
                            var dt = new DataTable();
                            dt.Load(dr);
                            cbb_item.DataSource = dt;
                            cbb_item.DisplayMember = "ItemName";
                            foreach (DataRow row in dt.Rows)
                            {
                                WeddingClient.listItems.Add(new Item()
                                {
                                    ItemNo = (row["ItemNo"]).ToString(),
                                    ItemName = row["ItemName"].ToString(),
                                    ItemPrice = Convert.ToInt64(row["ItemPrice"])
                                });
                            }
                            cbt_price_item.Text = WeddingClient.listItems[0].ItemPrice.ToString() + " VND";
                        }
                    }
                }
            }
        }


        // đổ dữ liệu từ db lên comboBox service
        void load_comboBox_service()
        {
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ServiceNo, ServiceName, ServicePrice, Note FROM SERVICE " +
                    "where Available > 0", sql))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr != null)
                        {
                            WeddingClient.listServices = new List<Service>();
                            var dt = new DataTable();
                            dt.Load(dr);
                            cbb_service.DataSource = dt;
                            cbb_service.DisplayMember = "ServiceName";
                            foreach (DataRow row in dt.Rows)
                            {
                                WeddingClient.listServices.Add(new Service()
                                {
                                    ServiceNo = (row["ServiceNo"]).ToString(),
                                    ServiceName = row["ServiceName"].ToString(),
                                    ServicePrice = Convert.ToInt64(row["ServicePrice"]),
                                    Note = row["Note"].ToString()
                                });
                            }
                            cbt_price_service.Text = WeddingClient.listItems[0].ItemPrice.ToString() + " VND";
                        }
                    }
                }
            }
        }

        private void cbb_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbb_item.SelectedIndex;
            Item dishes = WeddingClient.listItems[index];
            cbt_price_item.Text = dishes.ItemPrice.ToString() + " VND";
        }

        private void cbb_service_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbb_service.SelectedIndex;
            Service service = WeddingClient.listServices[index];
            cbt_price_service.Text = service.ServicePrice.ToString() + " VND";
        }

        private void btn_detail_item_Click(object sender, EventArgs e)
        {
            if (FormWedding.currentWeddingId != null && FormWedding.currentWeddingId.Length == 21)
            {
                FormGridViewItem show = new FormGridViewItem(FormWedding.currentWeddingId);
                show.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a wedding!", "LACK", MessageBoxButtons.OK);
            }
        }

        private void btn_add_menu_Click(object sender, EventArgs e)
        {
            if (FormWedding.currentWeddingId != null && FormWedding.currentWeddingId.Length == 21)
            {
                int index = cbb_item.SelectedIndex;
                Item dishes = WeddingClient.listItems[index];
                if (cbt_item_price.Text.Length > 0 && long.TryParse(cbt_item_price.Text, out long count))
                {
                    using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                    {
                        sql.Open();
                        long currentDishesPrice = 0;
                        using (SqlCommand check = new SqlCommand("SELECT AmountOfItems FROM TABLE_DETAIL " +
                            "WHERE WeddingNo = @WeddingNo AND ItemNo = @ItemNo", sql))
                        {
                            check.Parameters.AddWithValue("@WeddingNo", FormWedding.currentWeddingId);
                            check.Parameters.AddWithValue("@ItemNo", dishes.ItemNo);
                            using (SqlDataReader reader = check.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    currentDishesPrice = Convert.ToInt32(reader["AmountOfItems"]) * dishes.ItemPrice;
                                }
                                else
                                {
                                    currentDishesPrice = 0;
                                }
                            }
                        }
                        long newDishesPrice = 0;
                        if (currentDishesPrice == 0)
                        {
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO TABLE_DETAIL (WeddingNo, ItemNo, " +
                                "AmountOfItems, TotalItemsPrice, Note) VALUES (@WeddingNo, @ItemNo, @AmountOfItems, " +
                                "@TotalItemsPrice, @Note)", sql))
                            {
                                cmd.Parameters.AddWithValue("@WeddingNo", FormWedding.currentWeddingId);
                                cmd.Parameters.AddWithValue("@ItemNo", dishes.ItemNo);
                                cmd.Parameters.AddWithValue("@AmountOfItems", Convert.ToInt32(cbt_item_price.Text));
                                cmd.Parameters.AddWithValue("@TotalItemsPrice", dishes.ItemPrice * 
                                    Convert.ToInt32(cbt_item_price.Text));
                                cmd.Parameters.AddWithValue("@Note", "");
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    newDishesPrice = dishes.ItemPrice * Convert.ToInt32(cbt_item_price.Text);
                                    using (SqlCommand cmd2 = new SqlCommand("UPDATE BILL SET TablePriceTotal = " +
                                        "TablePriceTotal + @tableChanged, Total = Total + @tableChanged WHERE " +
                                        "WeddingNo = @WeddingNo", sql))
                                    {
                                        cmd2.Parameters.AddWithValue("@WeddingNo", FormWedding.currentWeddingId);
                                        cmd2.Parameters.AddWithValue("@tableChanged", newDishesPrice);
                                        if (cmd2.ExecuteNonQuery() > 0)
                                        {
                                            MessageBox.Show("Add successfully!", "SUCCESS", MessageBoxButtons.OK);
                                            cbt_item_price.Text = "";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                        }

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                }
                            }
                        }
                        else
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE TABLE_DETAIL " +
                                "SET AmountOfItems = @AmountOfItems, TotalItemsPrice = @TotalItemsPrice " +
                                "WHERE WeddingNo = @WeddingNo AND ItemNo = @ItemNo", sql))
                            {
                                cmd.Parameters.AddWithValue("@WeddingNo", FormWedding.currentWeddingId);
                                cmd.Parameters.AddWithValue("@ItemNo", dishes.ItemNo);
                                cmd.Parameters.AddWithValue("@AmountOfItems", Convert.ToInt32(cbt_item_price.Text));
                                cmd.Parameters.AddWithValue("@TotalItemsPrice", dishes.ItemPrice * 
                                    Convert.ToInt32(cbt_item_price.Text));
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    newDishesPrice = dishes.ItemPrice * Convert.ToInt32(cbt_item_price.Text);
                                    long changes = newDishesPrice - currentDishesPrice;
                                    using (SqlCommand cmd2 = new SqlCommand("UPDATE BILL " +
                                        "SET TablePriceTotal = TablePriceTotal + @tableChanged, Total = Total + @tableChanged," +
                                        " MoneyLeft = MoneyLeft + @tableChanged WHERE WeddingNo = @WeddingNo", sql))
                                    {
                                        cmd2.Parameters.AddWithValue("@WeddingNo", FormWedding.currentWeddingId);
                                        cmd2.Parameters.AddWithValue("@tableChanged", changes);
                                        if (cmd2.ExecuteNonQuery() > 0)
                                        {
                                            MessageBox.Show("Add successfully!", "SUCCESS", MessageBoxButtons.OK);
                                            cbt_item_price.Text = "";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                        }

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                }
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please type amount of dish!", "LACK", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please add a wedding to choose dishes!", "LACK", MessageBoxButtons.OK);
            }
        }

        private void btn_detail_service_Click(object sender, EventArgs e)
        {
            if (FormWedding.currentWeddingId != null && FormWedding.currentWeddingId.Length == 21)
            {
                FormGridViewService show = new FormGridViewService(FormWedding.currentWeddingId);
                show.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a wedding!", "LACK", MessageBoxButtons.OK);
            }
        }

        private void btn_add_service_Click(object sender, EventArgs e)
        {
            if (FormWedding.currentWeddingId != null && FormWedding.currentWeddingId.Length == 21)
            {
                int index = cbb_service.SelectedIndex;
                Service service = WeddingClient.listServices[index];
                if (cbt_service_price.Text.Length > 0 && long.TryParse(cbt_service_price.Text, out long count))
                {
                    using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                    {
                        sql.Open();
                        long currentServicePrice = 0;
                        using (SqlCommand check = new SqlCommand("SELECT AmountOfService " +
                            "FROM SERVICE_DETAIL WHERE WeddingNo = @WeddingNo AND ServiceNo = @ServiceNo", sql))
                        {
                            check.Parameters.AddWithValue("@WeddingNo", FormWedding.currentWeddingId);
                            check.Parameters.AddWithValue("@ServiceNo", service.ServiceNo);
                            using (SqlDataReader reader = check.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    currentServicePrice = Convert.ToInt32(reader["AmountOfService"]) * service.ServicePrice;
                                }
                                else
                                {
                                    currentServicePrice = 0;
                                }
                            }
                        }
                        long newServicePrice = 0;
                        if (currentServicePrice == 0)
                        {
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO SERVICE_DETAIL (WeddingNo, ServiceNo, " +
                                "AmountOfService, TotalServicePrice, Note) VALUES (@WeddingNo, @ServiceNo, @AmountOfService, " +
                                "@TotalServicePrice, @Note)", sql))
                            {
                                cmd.Parameters.AddWithValue("@WeddingNo", FormWedding.currentWeddingId);
                                cmd.Parameters.AddWithValue("@ServiceNo", service.ServiceNo);
                                cmd.Parameters.AddWithValue("@AmountOfService", Convert.ToInt32(cbt_service_price.Text));
                                cmd.Parameters.AddWithValue("@TotalServicePrice", service.ServicePrice * 
                                    Convert.ToInt32(cbt_service_price.Text));
                                cmd.Parameters.AddWithValue("@Note", "");
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    newServicePrice = service.ServicePrice * Convert.ToInt32(cbt_service_price.Text);
                                    using (SqlCommand cmd2 = new SqlCommand("UPDATE BILL " +
                                        "SET ServicePriceTotal = ServicePriceTotal + @serviceChanged, " +
                                        "Total = Total + @serviceChanged, MoneyLeft = MoneyLeft + @serviceChanged " +
                                        "WHERE WeddingNo = @WeddingNo", sql))
                                    {
                                        cmd2.Parameters.AddWithValue("@WeddingNo", FormWedding.currentWeddingId);
                                        cmd2.Parameters.AddWithValue("@serviceChanged", newServicePrice);
                                        if (cmd2.ExecuteNonQuery() > 0)
                                        {
                                            MessageBox.Show("Add successfully!", "SUCCESS", MessageBoxButtons.OK);
                                            cbt_service_price.Text = "";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                }
                            }
                        }
                        else
                        {
                            using (SqlCommand cmd = new SqlCommand("UPDATE SERVICE_DETAIL " +
                                "SET AmountOfService = @AmountOfService, TotalServicePrice = @TotalServicePrice " +
                                "WHERE WeddingNo = @WeddingNo AND ServiceNo = @ServiceNo", sql))
                            {
                                cmd.Parameters.AddWithValue("@WeddingNo", FormWedding.currentWeddingId);
                                cmd.Parameters.AddWithValue("@ServiceNo", service.ServiceNo);
                                cmd.Parameters.AddWithValue("@AmountOfService", Convert.ToInt32(cbt_service_price.Text));
                                cmd.Parameters.AddWithValue("@TotalServicePrice", service.ServicePrice * Convert.ToInt32(cbt_service_price.Text));
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    newServicePrice = service.ServicePrice * Convert.ToInt32(cbt_service_price.Text);
                                    long changes = newServicePrice - currentServicePrice;
                                    using (SqlCommand cmd2 = new SqlCommand("UPDATE BILL " +
                                        "SET ServicePriceTotal = ServicePriceTotal + @serviceChanged, " +
                                        "Total = Total + @serviceChanged, MoneyLeft = MoneyLeft + @serviceChanged " +
                                        "WHERE WeddingNo = @WeddingNo", sql))
                                    {
                                        cmd2.Parameters.AddWithValue("@WeddingNo", FormWedding.currentWeddingId);
                                        cmd2.Parameters.AddWithValue("@serviceChanged", changes);
                                        if (cmd2.ExecuteNonQuery() > 0)
                                        {
                                            MessageBox.Show("Add successfully!", "SUCCESS", MessageBoxButtons.OK);
                                            cbt_service_price.Text = "";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please type amount of dish!", "LACK", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please add a wedding to choose services!", "LACK", MessageBoxButtons.OK);
            }
        }

        private void btn_add_wedding_Click(object sender, EventArgs e)
        {
            int index = cbb_shift.SelectedIndex;
            if (index < 0 || index > WeddingClient.listShifts.Count)
            {
                MessageBox.Show("Please choose a shift!", "LACK", MessageBoxButtons.OK);
                return;
            }

            Shift shift = WeddingClient.listShifts[index];
            int indexLobby = cbb_lobby.SelectedIndex;
            if (indexLobby < 0 || indexLobby > WeddingClient.listLobbies.Count)
            {
                MessageBox.Show("Please choose a lobby!", "LACK", MessageBoxButtons.OK);
                return;
            }
            Lobby lobby = WeddingClient.listLobbies[indexLobby];

            if (!IsLobbyAvailable(lobby.LobbyNo, shift.ShiftNo))
            {
                MessageBox.Show("This lobby is not available at this shift!", "LACK", MessageBoxButtons.OK);
                return;
            }

            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                long typePrice = 0;
                using (SqlCommand cmd = new SqlCommand("SELECT MinTablePrice FROM LOBBY_TYPE " +
                    "WHERE LobbyTypeNo = @LobbyTypeNo", sql))
                {
                    cmd.Parameters.AddWithValue("@LobbyTypeNo", lobby.LobbyTypeNo);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            typePrice = Convert.ToInt64(reader["MinTablePrice"]);
                        }
                    }
                }
                long basePrice = typePrice * (Convert.ToInt32(cbt_table.Text) + Convert.ToInt32(cbt_contigency.Text));
                string newId = "WD" + WeddingClient.GetNewIdFromTable("WD").ToString().PadLeft(19, '0');
                using (SqlCommand cmd = new SqlCommand("INSERT INTO WEDDING (WeddingNo, LobbyNo, ShiftNo, BookingDate, " +
                    "WeddingDate, PhoneNumber, GroomName, BrideName, AmountOfTable, AmountOfContingencyTable, TablePrice, " +
                    "Deposit, Representative) VALUES (@WeddingNo, @LobbyNo, @ShiftNo, @BookingDate, @WeddingDate, " +
                    "@PhoneNumber, @GroomName, @BrideName, @AmountOfTable, @AmountOfContingencyTable, @TablePrice, @Deposit, " +
                    "@representative )", sql))
                {
                    cmd.Parameters.AddWithValue("@WeddingNo", newId);
                    cmd.Parameters.AddWithValue("@LobbyNo", lobby.LobbyNo);
                    cmd.Parameters.AddWithValue("@ShiftNo", shift.ShiftNo);
                    cmd.Parameters.AddWithValue("@BookingDate", date_booking.Value);
                    cmd.Parameters.AddWithValue("@WeddingDate", date_wedding.Value);
                    cmd.Parameters.AddWithValue("@PhoneNumber", cbt_phone.Text);
                    cmd.Parameters.AddWithValue("@GroomName", cbt_groom.Text);
                    cmd.Parameters.AddWithValue("@BrideName", cbt_bride.Text);
                    cmd.Parameters.AddWithValue("@AmountOfTable", Convert.ToInt32(cbt_table.Text));
                    cmd.Parameters.AddWithValue("@AmountOfContingencyTable", Convert.ToInt32(cbt_contigency.Text));
                    cmd.Parameters.AddWithValue("@TablePrice", basePrice);
                    cmd.Parameters.AddWithValue("@Deposit", Convert.ToInt64(cbt_deposit.Text));
                    cmd.Parameters.AddWithValue("@representative", cbt_representative.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        using (SqlCommand cmd2 = new SqlCommand("INSERT INTO BILL (BillNo, InvoiceDate, TablePriceTotal, " +
                            "ServicePriceTotal, Total, PaymentDate, MoneyLeft) VALUES (@BillNo, @InvoiceDate, " +
                            "@TablePricetotal, @ServicePriceTotal, @Total, @PaymentDate, @MoneyLeft) ", sql))
                        {
                            cmd2.Parameters.AddWithValue("@BillNo", newId);
                            cmd2.Parameters.AddWithValue("@InvoiceDate", date_wedding.Value);
                            cmd2.Parameters.AddWithValue("@TablePricetotal", 0);
                            cmd2.Parameters.AddWithValue("@ServicePriceTotal", 0);
                            cmd2.Parameters.AddWithValue("@Total", basePrice);
                            cmd2.Parameters.AddWithValue("@PaymentDate", DBNull.Value);
                            cmd2.Parameters.AddWithValue("@MoneyLeft", basePrice - Convert.ToInt64(cbt_deposit.Text));
                            if (cmd2.ExecuteNonQuery() > 0)
                            {
                                DataRow row = table1.NewRow();
                                row.ItemArray = new object[] { 
                                    lobby.LobbyName, 
                                    shift.ShiftName, 
                                    cbt_representative.Text, 
                                    cbt_phone.Text, 
                                    date_booking.Value.ToString(), 
                                    date_wedding.Value.ToString(), 
                                    cbt_groom.Text, 
                                    cbt_bride.Text, 
                                    cbt_table.Text, 
                                    cbt_contigency.Text, 
                                    basePrice, 
                                    cbt_deposit.Text, 
                                    newId 
                                };
                                table1.Rows.Add(row);
                                MessageBox.Show("Add wedding successfully!", "SUCCESS", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Fail to add wedding!", "FAIL", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
        }

        private bool IsLobbyAvailable(string LobbyNo, string ShiftNo)
        {
            using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM WEDDING " +
                    "WHERE LobbyNo = @LobbyNo AND ShiftNo = @ShiftNo AND Available is NULL", sql))
                {
                    cmd.Parameters.AddWithValue("@LobbyNo", LobbyNo);
                    cmd.Parameters.AddWithValue("@ShiftNo", ShiftNo);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void btn_delete_wedding_Click(object sender, EventArgs e)
        {
            if (currentWeddingId != null && currentWeddingId.Length == 21)
            {
                using (SqlConnection sql = new SqlConnection(WeddingClient.sqlConnectionString))
                {
                    sql.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE WEDDING set Available = 0 " +
                        "WHERE WeddingNo = @WeddingNo", sql))
                    {
                        cmd.Parameters.AddWithValue("@WeddingNo", currentWeddingId);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            table1.Rows.RemoveAt(dataWedding.CurrentRow.Index);
                            MessageBox.Show("Wedding deleted!", "SUCCESS", MessageBoxButtons.OK);
                            FormWedding.currentWeddingId = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a wedding to delete!", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

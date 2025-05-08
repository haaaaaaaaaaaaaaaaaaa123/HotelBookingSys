using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using HotelBookingSystem.Forms;
using HotelBookingSystem.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelBookingSystem
{
    internal class myDatabase
    {
        private static string connectionString = "server=localhost;user=root;password=;database=hotelbooking;port=3306;";

        private static Guna2Panel selectedPnl = null;
        
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool Login(string email, string password)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT role FROM users WHERE email = @email AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();
                        if (role == "admin")
                        {
                            Forms.frm_admin admin = new frm_admin();
                            admin.Show();
                        }
                        else if (role == "user")
                        {
                            Forms.frm_user user = new frm_user(email);
                            user.Show();
                        }

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password!");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public static bool SignUp(string firstname, string lastname, string email, string password)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE email = @email";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@email", email);

                    int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("Email already been used!");
                        return false;
                    }

                    string insertQuery = "INSERT INTO users (first_name, last_name, email, password, role) VALUES (@firstname, @lastname, @email, @password, 'user')";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@firstname", firstname);
                    insertCmd.Parameters.AddWithValue("@lastname", lastname);
                    insertCmd.Parameters.AddWithValue("@email", email);
                    insertCmd.Parameters.AddWithValue("@password", password);

                    int rowsInserted = insertCmd.ExecuteNonQuery();

                    if (rowsInserted > 0)
                    {
                        MessageBox.Show("Sign-up successful!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sign-up failed!");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public static bool AddRoom(byte[] img1, byte[] img2, byte[] img3, int roomNo, string description, int roomPrice, string category)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM rooms WHERE room_number = @room_number";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@room_number", roomNo);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Room number already exists!");
                            return false;
                        }
                    }

                    string insertQuery = "INSERT INTO rooms (img1, img2, img3, room_number, description, type, price, status) VALUES (@img1, @img2, @img3, @room_number, @description, @type, @price, 'available')";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.Add("@img1", MySqlDbType.LongBlob).Value = img1 ?? new byte[0];
                        insertCmd.Parameters.Add("@img2", MySqlDbType.LongBlob).Value = img2 ?? new byte[0];
                        insertCmd.Parameters.Add("@img3", MySqlDbType.LongBlob).Value = img3 ?? new byte[0];
                        insertCmd.Parameters.AddWithValue("@room_number", roomNo);
                        insertCmd.Parameters.AddWithValue("@description", description);
                        insertCmd.Parameters.AddWithValue("@type", category);
                        insertCmd.Parameters.AddWithValue("@price", roomPrice);

                        int rowsInserted = insertCmd.ExecuteNonQuery();
                        MessageBox.Show(rowsInserted > 0 ? "Room added successfully!" : "Adding room failed!");
                        return rowsInserted > 0;
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public static bool DeleteRoom(int roomNo)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();

                    string checkBookingQuery = "SELECT COUNT(*) FROM bookings WHERE room_number = @room_number AND status = 'approved'";
                    MySqlCommand checkCmd = new MySqlCommand(checkBookingQuery, conn);
                    checkCmd.Parameters.AddWithValue("@room_number", roomNo);
                    int activeBookings = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (activeBookings > 0)
                    {
                        MessageBox.Show("Cannot delete this room. There is an active booking associated with it.");
                        return false;
                    }

                    string deleteQuery = "DELETE FROM rooms WHERE room_number = @room_number";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@room_number", roomNo);

                    int rowsDeleted = deleteCmd.ExecuteNonQuery();

                    if (rowsDeleted > 0)
                    {
                        MessageBox.Show("Room deleted successfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Room number not found or already deleted.");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public static bool UpdateRoom(int originalRoomNumber, byte[] newImage1, byte[] newImage2, byte[] newImage3, int newRoomNo, string newDescription, int newPrice, string newType)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string getIdQuery = "SELECT id FROM rooms WHERE room_number = @room_number";
                    MySqlCommand getIdCmd = new MySqlCommand(getIdQuery, conn);
                    getIdCmd.Parameters.AddWithValue("@room_number", originalRoomNumber);
                    object result = getIdCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Room not found!");
                        return false;
                    }

                    int roomId = Convert.ToInt32(result);

                    string updateQuery = "UPDATE rooms SET img1 = @img1, img2 = @img2, img3 = @img3, room_number = @room_number, description = @description, price = @price, type = @type WHERE id = @id";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.Add("@img1", MySqlDbType.LongBlob).Value = newImage1 ?? new byte[0];
                    updateCmd.Parameters.Add("@img2", MySqlDbType.LongBlob).Value = newImage2 ?? new byte[0];
                    updateCmd.Parameters.Add("@img3", MySqlDbType.LongBlob).Value = newImage3 ?? new byte[0];
                    updateCmd.Parameters.AddWithValue("@room_number", newRoomNo);
                    updateCmd.Parameters.AddWithValue("@description", newDescription);
                    updateCmd.Parameters.AddWithValue("@price", newPrice);
                    updateCmd.Parameters.AddWithValue("@type", newType);
                    updateCmd.Parameters.AddWithValue("@id", roomId);

                    int rowsUpdated = updateCmd.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Room updated successfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Room update failed!");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public static void DisplayRooms(Guna2DataGridView dgv)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT img1 AS 'Image 1', img2 AS 'Image 2', img3 AS 'Image 3', room_number AS 'Room No.', description AS 'Description', price AS 'Price', type AS 'Category', status AS 'Availability' FROM rooms";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;

                    if (dgv.Columns["Image 1"] is DataGridViewImageColumn imageColumn1 && dgv.Columns["Image 2"] is DataGridViewImageColumn imageColumn2 && dgv.Columns["Image 3"] is DataGridViewImageColumn imageColumn3)
                    {
                        imageColumn1.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        imageColumn2.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        imageColumn3.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }

                    dgv.RowTemplate.Height = 40;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message);
                }
            }
        }

        public static void Rooms(FlowLayoutPanel container)
        {
            container.Controls.Clear();

            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT img1 AS 'Image', room_number AS 'RoomNo', type AS 'Category', price AS 'Price' FROM rooms WHERE status = 'Available'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        Guna2Panel pnl = new Guna2Panel()
                        {
                            BackColor = Color.Transparent,
                            FillColor = Color.White,
                            BorderRadius = 12,
                            Margin = new Padding(0, 0, 16, 16),
                            Size = new Size(190, 200),
                            Cursor = Cursors.Hand,
                        };

                        pnl.ShadowDecoration.Parent = pnl;
                        pnl.ShadowDecoration.Depth = 30;
                        pnl.ShadowDecoration.BorderRadius = 12;
                        pnl.ShadowDecoration.Enabled = true;
                        pnl.ShadowDecoration.Color = Color.Silver;
                        pnl.ShadowDecoration.Shadow = new Padding(4, 4, 4, 4);

                        Guna2PictureBox pbx = new Guna2PictureBox()
                        {
                            BackColor = Color.Transparent,
                            FillColor = Color.LightGray,
                            BorderRadius = 8,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(170, 110),
                            Location = new Point(10, 10),
                        };

                        Label lbl_room = new Label()
                        {
                            ForeColor = Color.FromArgb(64, 64, 64),
                            Font = new Font("Segoe UI", 11f, FontStyle.Bold),
                            Location = new Point(10, 129),
                            Text = "Room" + Convert.ToString(row["RoomNo"]),
                            Size = new Size(150, 20),
                        };

                        Label lbl_category = new Label()
                        {
                            ForeColor = Color.FromArgb(64, 64, 64),
                            Font = new Font("Segoe UI", 9f, FontStyle.Regular),
                            Location = new Point(10, 149),
                            Text = row["Category"] + " Room",
                            Size = new Size(150, 20),
                        };

                        Label lbl_price = new Label()
                        {
                            ForeColor = Color.FromArgb(64, 64, 64),
                            Font = new Font("Segoe UI", 11f, FontStyle.Bold),
                            Location = new Point(10, 167),
                            Text = "₱" + Convert.ToDecimal(row["Price"]).ToString("0.00") + "/ Night",
                            Size = new Size(150, 20),
                        };

                        pnl.Controls.Add(pbx);
                        pnl.Controls.Add(lbl_room);
                        pnl.Controls.Add(lbl_category);
                        pnl.Controls.Add(lbl_price);

                        if (row["Image"] != DBNull.Value)
                        {
                            byte[] imgBytes = (byte[])row["Image"];
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                pbx.Image = Image.FromStream(ms);
                            }
                        }

                        pnl.Controls.Add(pbx);
                        pnl.Controls.Add(lbl_room);
                        pnl.Controls.Add(lbl_category);
                        pnl.Controls.Add(lbl_price);

                        container.Controls.Add(pnl);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading rooms: " + ex.Message);
                }
            }
        }

        public static void DisplayRoomsOnUser(FlowLayoutPanel container)
        {
            container.Controls.Clear();

            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT img1 AS 'Image', room_number AS 'RoomNo', type AS 'Category', price AS 'Price' FROM rooms WHERE status = 'Available'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        string roomNo = row["RoomNo"].ToString();

                        Guna2Panel pnl = new Guna2Panel()
                        {
                            BackColor = Color.Transparent,
                            FillColor = Color.White,
                            BorderRadius = 12,
                            Margin = new Padding(0, 0, 16, 16),
                            Size = new Size(170, 190),
                            Cursor = Cursors.Hand,
                            Tag = roomNo,
                        };
                        pnl.Click += RoomPanel_Click;

                        pnl.ShadowDecoration.Parent = pnl;
                        pnl.ShadowDecoration.Depth = 30;
                        pnl.ShadowDecoration.BorderRadius = 12;
                        pnl.ShadowDecoration.Enabled = true;
                        pnl.ShadowDecoration.Color = Color.Silver;
                        pnl.ShadowDecoration.Shadow = new Padding(4, 4, 4, 4);

                        Guna2PictureBox pbx = new Guna2PictureBox()
                        {
                            BackColor = Color.Transparent,
                            FillColor = Color.LightGray,
                            BorderRadius = 8,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Size = new Size(150, 100),
                            Location = new Point(10, 10),
                            Tag = roomNo,
                        };
                        pbx.Click += RoomPanel_Click;

                        Label lbl_room = new Label()
                        {
                            ForeColor = Color.FromArgb(64, 64, 64),
                            Font = new Font("Segoe UI", 11f, FontStyle.Bold),
                            Location = new Point(10, 119),
                            Text = "Room" + Convert.ToString(row["RoomNo"]),
                            Size = new Size(150, 20),
                            Tag = roomNo,
                        };
                        lbl_room.Click += RoomPanel_Click;

                        Label lbl_category = new Label()
                        {
                            ForeColor = Color.FromArgb(64, 64, 64),
                            Font = new Font("Segoe UI", 9f, FontStyle.Regular),
                            Location = new Point(10, 139),
                            Text = row["Category"] + " Room",
                            Size = new Size(150, 20),
                            Tag = roomNo,
                        };
                        lbl_category.Click += RoomPanel_Click;

                        Label lbl_price = new Label()
                        {
                            ForeColor = Color.FromArgb(64, 64, 64),
                            Font = new Font("Segoe UI", 11f, FontStyle.Bold),
                            Location = new Point(10, 157),
                            Text = "₱" + Convert.ToDecimal(row["Price"]).ToString("0.00") + "/ Night",
                            Size = new Size(150, 20),
                            Tag = roomNo,
                        };
                        lbl_price.Click += RoomPanel_Click;

                        pnl.Controls.Add(pbx);
                        pnl.Controls.Add(lbl_room);
                        pnl.Controls.Add(lbl_category);
                        pnl.Controls.Add(lbl_price);

                        if (row["Image"] != DBNull.Value)
                        {
                            byte[] imgBytes = (byte[])row["Image"];
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                pbx.Image = Image.FromStream(ms);
                            }
                        }

                        pnl.Controls.Add(pbx);
                        pnl.Controls.Add(lbl_room);
                        pnl.Controls.Add(lbl_category);
                        pnl.Controls.Add(lbl_price);

                        container.Controls.Add(pnl);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading rooms: " + ex.Message);
                }
            }
        }

        private static void RoomPanel_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;

            if (clickedControl != null && clickedControl.Tag != null)
            {
                string roomNo = clickedControl.Tag.ToString();

                Guna2Panel clickedPanel = null;

                Control parent = clickedControl;
                while (parent != null && !(parent is Guna2Panel))
                {
                    parent = parent.Parent;
                }

                if (parent is Guna2Panel)
                {
                    clickedPanel = (Guna2Panel)parent;

                    if (selectedPnl != null)
                    {
                        selectedPnl.BorderThickness = 0;
                        selectedPnl.ShadowDecoration.BorderRadius = 12;
                        selectedPnl.ShadowDecoration.Color = Color.Silver;
                    }

                    selectedPnl = clickedPanel;
                    selectedPnl.BorderThickness = 2;
                    selectedPnl.ShadowDecoration.BorderRadius = 12;
                    selectedPnl.ShadowDecoration.Color = Color.LightBlue;
                    selectedPnl.BorderColor = Color.LightBlue; 
                }

                using (MySqlConnection conn = GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = @"SELECT img1, img2, img3, room_number, description, type, price FROM rooms WHERE room_number = @roomNo";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@roomNo", roomNo);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Image img1 = null, img2 = null, img3 = null;

                                if (reader["img1"] != DBNull.Value)
                                {
                                    byte[] imgBytes = (byte[])reader["img1"];
                                    using (MemoryStream ms = new MemoryStream(imgBytes))
                                    {
                                        img1 = Image.FromStream(ms);
                                    }
                                }

                                if (reader["img2"] != DBNull.Value)
                                {
                                    byte[] imgBytes = (byte[])reader["img2"];
                                    using (MemoryStream ms = new MemoryStream(imgBytes))
                                    {
                                        img2 = Image.FromStream(ms);
                                    }
                                }

                                if (reader["img3"] != DBNull.Value)
                                {
                                    byte[] imgBytes = (byte[])reader["img3"];
                                    using (MemoryStream ms = new MemoryStream(imgBytes))
                                    {
                                        img3 = Image.FromStream(ms);
                                    }
                                }

                                string number = reader["room_number"].ToString();
                                string price = "₱" + Convert.ToDecimal(reader["price"]).ToString("0.00") + "/ Night";
                                string description = reader["description"].ToString();

                                uc_bookRoom.Instance.roomDetails(img1, img2, img3, number, price, description);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading room details: " + ex.Message);
                    }
                }
            }
        }

        public static bool bookRoom(string roomNo, string fname, string lname, string contact, string email, DateTime checkIn, DateTime checkOut, decimal price, decimal gtotal)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        long bookingId; // To store the inserted booking ID

                        // Insert into bookings
                        string bookingQuery = @"INSERT INTO bookings (room_number, customer_fname, customer_lname, contact_number, email, check_in_date, check_out_date)
                                        VALUES (@room_number, @fname, @lname, @contact, @email, @checkin, @checkout)";
                        using (MySqlCommand bookingCmd = new MySqlCommand(bookingQuery, conn, transaction))
                        {
                            bookingCmd.Parameters.AddWithValue("@room_number", roomNo);
                            bookingCmd.Parameters.AddWithValue("@fname", fname);
                            bookingCmd.Parameters.AddWithValue("@lname", lname);
                            bookingCmd.Parameters.AddWithValue("@contact", contact);
                            bookingCmd.Parameters.AddWithValue("@email", email);
                            bookingCmd.Parameters.AddWithValue("@checkin", checkIn.Date);
                            bookingCmd.Parameters.AddWithValue("@checkout", checkOut.Date);

                            bookingCmd.ExecuteNonQuery();
                            bookingId = bookingCmd.LastInsertedId; // Get the ID from bookings
                        }

                        // Insert into receipts with correct booking_id
                        string fullName = fname + " " + lname;
                        string receiptQuery = @"INSERT INTO receipts (booking_id, room_number, customer_name, price, gtotal, payment_status)
                                        VALUES (@booking_id, @room_number, @customer_name, @price, @gtotal, @status)";
                        using (MySqlCommand receiptCmd = new MySqlCommand(receiptQuery, conn, transaction))
                        {
                            receiptCmd.Parameters.AddWithValue("@booking_id", bookingId);
                            receiptCmd.Parameters.AddWithValue("@room_number", roomNo);
                            receiptCmd.Parameters.AddWithValue("@customer_name", fullName);
                            receiptCmd.Parameters.AddWithValue("@price", price);
                            receiptCmd.Parameters.AddWithValue("@gtotal", gtotal);
                            receiptCmd.Parameters.AddWithValue("@status", "pending");

                            receiptCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Console.WriteLine("Booking and receipt inserted successfully.");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error during booking/receipt insertion: " + ex.Message);
                    return false;
                }
            }

        }

        public static void DisplayUserReservations(Guna2DataGridView dgv, string email)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    id AS 'ID', 
                    room_number AS 'Room No.', 
                    CONCAT(customer_fname, ' ', customer_lname) AS 'Customer Name', 
                    contact_number AS 'Contact', 
                    check_in_date AS 'IN Date', 
                    check_out_date AS 'OUT Date', 
                    status AS 'Status' 
                FROM bookings 
                WHERE email = @email";
                    
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgv.DataSource = dt;
                        dgv.RowTemplate.Height = 40;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading reservations: " + ex.Message);
                }
            }
        }

        public static void DisplayPendingReservations(Guna2DataGridView dgv)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    id AS 'ID', 
                    room_number AS 'Room No.', 
                    CONCAT(customer_fname, ' ', customer_lname) AS 'Customer Name', 
                    contact_number AS 'Contact', 
                    check_in_date AS 'IN Date', 
                    check_out_date AS 'OUT Date', 
                    status AS 'Status' 
                FROM bookings 
                WHERE status = 'Pending'";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv.DataSource = dt;
                    dgv.RowTemplate.Height = 40;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading reservations: " + ex.Message);
                }
            }
        }

        public static void DisplayHistoryReservations(Guna2DataGridView dgv)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    id AS 'ID', 
                    room_number AS 'Room No.', 
                    CONCAT(customer_fname, ' ', customer_lname) AS 'Customer Name', 
                    contact_number AS 'Contact', 
                    check_in_date AS 'IN Date', 
                    check_out_date AS 'OUT Date', 
                    status AS 'Status' 
                FROM bookings 
                WHERE status != 'Pending' AND status != 'Approved'";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv.DataSource = dt;
                    dgv.RowTemplate.Height = 40;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading reservations: " + ex.Message);
                }
            }
        }

        public static void DisplayApprovedReservations(Guna2DataGridView dgv)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    b.id AS 'ID',
                    b.room_number AS 'ROOM NO.',
                    CONCAT(b.customer_fname, ' ', b.customer_lname) AS 'NAME',
                    b.check_in_date AS 'CHECK-IN',
                    b.check_out_date AS 'CHECK-OUT',
                    b.status AS 'STATUS',
                    r.payment_status AS 'PAYMENT STATUS'
                FROM bookings b
                JOIN receipts r ON b.id = r.booking_id
                WHERE b.status = 'Approved' 
                  AND b.check_in_date >= CURDATE()
                ORDER BY b.check_in_date ASC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgv.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching upcoming reservations: " + ex.Message);
                }
            }
        }

        public static void getBookingData(string bookingID, Action<string, string, string, string, string, string, string, string> callback)
        {
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"SELECT b.customer_fname, b.customer_lname, b.contact_number, b.email, 
                                    b.check_in_date, b.check_out_date, b.room_number, r.price,  r.gtotal, b.status
                             FROM bookings b
                             JOIN receipts r ON b.room_number = r.room_number
                             WHERE b.id = @ID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", bookingID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fullName = reader["customer_fname"] + " " + reader["customer_lname"];
                                string roomNo = reader["room_number"].ToString();
                                string contact = reader["contact_number"].ToString();
                                string checkIn = Convert.ToDateTime(reader["check_in_date"]).ToShortDateString();
                                string checkOut = Convert.ToDateTime(reader["check_out_date"]).ToShortDateString();
                                string total = Convert.ToDecimal(reader["gtotal"]).ToString();
                                string price = Convert.ToDecimal(reader["price"]).ToString();
                                string status = reader["status"].ToString();

                                // Call the form's method to populate the labels
                                callback(fullName, roomNo, contact, checkIn, checkOut, price, total, status);
                            }
                            else
                            {
                                MessageBox.Show("No booking found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public static bool ApproveReservation(int reservationId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 1. Retrieve reservation details
                    string getBookingQuery = @"SELECT room_number, check_in_date, check_out_date, status 
                                       FROM bookings 
                                       WHERE id = @id";

                    string roomNo = "";
                    DateTime checkIn = DateTime.MinValue;
                    DateTime checkOut = DateTime.MinValue;
                    string status = "";

                    using (MySqlCommand getCmd = new MySqlCommand(getBookingQuery, conn))
                    {
                        getCmd.Parameters.AddWithValue("@id", reservationId);
                        using (var reader = getCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                roomNo = reader["room_number"].ToString();
                                checkIn = reader.GetDateTime("check_in_date");
                                checkOut = reader.GetDateTime("check_out_date");
                                status = reader.GetString("status");
                            }
                            else
                            {
                                Console.WriteLine("Reservation not found.");
                                return false;
                            }
                        }
                    }

                    if (status != "Pending")
                    {
                        MessageBox.Show("Reservation is not in pending state.");
                        return false;
                    }

                    // 2. Check for conflicting bookings
                    string overlapQuery = @"
                                        SELECT check_in_date, check_out_date 
                                        FROM bookings 
                                        WHERE room_number = @roomNo 
                                          AND status = 'Approved' 
                                          AND id != @id 
                                          AND (
                                               (@checkIn < check_out_date AND @checkOut > check_in_date)
                                              )";

                    using (MySqlCommand overlapCmd = new MySqlCommand(overlapQuery, conn))
                    {
                        overlapCmd.Parameters.AddWithValue("@roomNo", roomNo);
                        overlapCmd.Parameters.AddWithValue("@checkIn", checkIn);
                        overlapCmd.Parameters.AddWithValue("@checkOut", checkOut);
                        overlapCmd.Parameters.AddWithValue("@id", reservationId);

                        using (MySqlDataReader reader = overlapCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DateTime conflictCheckIn = reader.GetDateTime("check_in_date");
                                DateTime conflictCheckOut = reader.GetDateTime("check_out_date");

                                MessageBox.Show($"Room is already booked from {conflictCheckIn:yyyy-MM-dd} to {conflictCheckOut:yyyy-MM-dd}.",
                                                "Booking Conflict",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Warning);
                                return false;
                            }
                        }
                    }

                    // 3. Approve the booking
                    string approveQuery = @"UPDATE bookings SET status = 'Approved' WHERE id = @id";
                    using (MySqlCommand approveCmd = new MySqlCommand(approveQuery, conn))
                    {
                        approveCmd.Parameters.AddWithValue("@id", reservationId);
                        int rows = approveCmd.ExecuteNonQuery();

                        return rows > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during approval: " + ex.Message);
                    return false;
                }
            }
        }

        public static bool RejectReservation(int reservationId)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to reject this reservation?",
                "Confirm Rejection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE bookings SET status = @status WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", "Rejected");
                        cmd.Parameters.AddWithValue("@id", reservationId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Cancellation aborted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public static bool CancelReservation(int reservationId)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel this reservation?",
                "Confirm Rejection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE bookings SET status = @status WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", "Cancelled");
                        cmd.Parameters.AddWithValue("@id", reservationId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Cancellation aborted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public static void getTotalPrice(string id, Label lbl)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT gtotal FROM receipts WHERE booking_id = @id";
                    
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string total = Convert.ToDecimal(reader["gtotal"]).ToString();

                                lbl.Text = "₱" + total;
                            }
                            else
                            {
                                MessageBox.Show("No booking found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public static bool updatePaymentStatus(string id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE receipts SET payment_status = @payment_status WHERE booking_id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@payment_status", "Paid");
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static void UpdatePastReservationsStatus()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                DateTime currentDate = DateTime.Now.Date;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;

                string approvedQuery = @"UPDATE bookings 
                                       SET status = 'Checked Out' 
                                       WHERE (check_out_date < @CurrentDate) 
                                       AND status = 'Approved'";

                using (MySqlCommand cmdApproved = new MySqlCommand(approvedQuery, conn))
                {
                    cmdApproved.Parameters.AddWithValue("@CurrentDate", currentDate);
                    cmdApproved.ExecuteNonQuery();
                }

                string pendingQuery = @"UPDATE bookings b
                                        JOIN receipts r ON b.id = r.booking_id
                                        SET b.status = 'Cancelled'
                                        WHERE b.check_out_date < @CurrentDate
                                          AND b.status = 'Approved'
                                          AND r.payment_status = 'Pending'";

                using (MySqlCommand cmdPending = new MySqlCommand(pendingQuery, conn))
                {
                    cmdPending.Parameters.AddWithValue("@CurrentDate", currentDate);
                    cmdPending.ExecuteNonQuery();
                }
            }
        }

        public static void getOverview(Label totalCheckedIn, Label totalCheckOut, Label totalRooms, Label revenue)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                DateTime currentDate = DateTime.Now.Date;

                // Guests currently checked in (i.e., today is between check-in and check-out)
                string checkedInQuery = @"
            SELECT COUNT(*) FROM bookings 
            WHERE check_in_date <= @CurrentDate 
              AND check_out_date > @CurrentDate 
              AND status = 'Approved'";

                // Guests who have already checked out
                string checkedOutQuery = @"
            SELECT COUNT(*) FROM bookings 
            WHERE status = 'Checked Out'";

                // Count of distinct room numbers used in bookings
                string totalRoomsQuery = @"
            SELECT COUNT(DISTINCT room_number) FROM bookings";

                string totalRevenue = @"SELECT SUM(gtotal) AS total_sales FROM receipts WHERE payment_status = 'Paid';";

                using (MySqlCommand cmd = new MySqlCommand(checkedInQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@CurrentDate", currentDate);
                    totalCheckedIn.Text = cmd.ExecuteScalar().ToString();
                }

                using (MySqlCommand cmd = new MySqlCommand(checkedOutQuery, conn))
                {
                    totalCheckOut.Text = cmd.ExecuteScalar().ToString();
                }

                using (MySqlCommand cmd = new MySqlCommand(totalRoomsQuery, conn))
                {
                    totalRooms.Text = cmd.ExecuteScalar().ToString() + " Rooms";
                }

                using (MySqlCommand cmd = new MySqlCommand(totalRevenue, conn))
                {
                    revenue.Text = "₱" + cmd.ExecuteScalar().ToString();
                }
            }
        }
    }
}

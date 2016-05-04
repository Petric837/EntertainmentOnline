using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace EntertainmentOnline
{
    public class userRow
    {
        public string username;
        public string password;
        public string address;
        public string phone;
        public string cardType;
        public string cardNumber;
        public string role;
    }

    public class rentalRow
    {
        public int id;
        public string type;
        public string title;
        public string genre;
        public string releaseDate;
        public string price;
        public string reviewScore;
    }

    public class DatabaseConnection
    {

        MySqlConnection myConnection;

        public List<userRow> userList = new List<userRow>();
        public List<rentalRow> rentalList = new List<rentalRow>();


        public DatabaseConnection()
        {
            myConnection = new MySqlConnection();
            myConnection.ConnectionString = "server=db1.cs.uakron.edu;database=WP_jgp18;uid=jgp18;pwd=Goose12345;allow zero datetime=yes";
        }

        public void createUserList()
        {
            userList.Clear();

            try
            {
                // Connect to DB
                myConnection.Open();

                // Create SQL command
                MySqlCommand myCommand = new MySqlCommand("SELECT * FROM Users;", myConnection);

                // Read result data
                MySqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    userRow row = new userRow();
                    row.username    = reader["username"].ToString();
                    row.password    = reader["password"].ToString();
                    row.address     = reader["address"].ToString();
                    row.phone       = reader["phone"].ToString();
                    row.cardType    = reader["cardType"].ToString();
                    row.cardNumber  = reader["cardNumber"].ToString();
                    row.role        = reader["role"].ToString();

                    userList.Add(row);
                }

                // Close DB connection
                myConnection.Close();
            }
            catch (Exception exc) { throw exc; }
        }




        public void addUser(string username, string password, string address, string phone, string cardType, string cardNumber)
        {

            try
            {
                // Connect to DB
                myConnection.Open();

                // Create SQL command
                MySqlCommand myCommand = new MySqlCommand("INSERT INTO Users (username, password, address, phone, cardType, cardNumber, role) " +
                                                          "Values ('" + username + "', '" + password + "', '" + address + "', '" + phone + "', '" + cardType + "', '" + cardNumber + "', 'regular')", myConnection);

                // Execute SQL command
                myCommand.ExecuteNonQuery();

                // Close DB connection
                myConnection.Close();
            }
            catch (Exception exc) { throw exc; }
        }


        public bool userExists(string username, string password)
        {

            try
            {
                // Connect to DB
                myConnection.Open();

                // Create SQL command
                MySqlCommand myCommand = new MySqlCommand("SELECT * FROM Users " + 
                                                          "WHERE username='" + username + "' AND password='" + password + "';", myConnection);

                // Read result data
                MySqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    return reader.HasRows;
                }

                // Close DB connection
                myConnection.Close();
            }
            catch (Exception exc) { throw exc; }

            return false;

        }


        public userRow findUser(string username)
        {

            userRow result = new userRow();

            try
            {
                // Connect to DB
                myConnection.Open();

                // Create SQL command
                MySqlCommand myCommand = new MySqlCommand("SELECT * FROM Users " +
                                                          "WHERE username='" + username + "';", myConnection);

                // Read result data
                MySqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    result.username = reader["username"].ToString();
                    result.password = reader["password"].ToString();
                    result.address = reader["address"].ToString();
                    result.phone = reader["phone"].ToString();
                    result.cardType = reader["cardType"].ToString();
                    result.cardNumber = reader["cardNumber"].ToString();
                    result.role = reader["role"].ToString();
                }

                // Close DB connection
                myConnection.Close();
            }
            catch (Exception exc) { throw exc; }

            return result;

        }


        public void editUser(string username, string password, string address, string phone, string cardType, string cardNumber, string role)
        {

            try
            {
                // Connect to DB
                myConnection.Open();

                // Create SQL command
                MySqlCommand myCommand = new MySqlCommand("UPDATE Users " +
                                                          "SET username='" + username + "', password='" + password + "', address='" + address + "', phone='" + phone + "', cardType='" + cardType +
                                                          "', cardNumber='" + cardNumber + "', role='" + role + "' " +
                                                          "WHERE username='" + username + "';", myConnection);

                // Execute SQL command
                myCommand.ExecuteNonQuery();

                // Close DB connection
                myConnection.Close();
            }
            catch (Exception exc) { throw exc; }
        }


        public void deleteUser(string username)
        {

            try
            {
                // Connect to DB
                myConnection.Open();

                // Create SQL command
                MySqlCommand myCommand = new MySqlCommand("DELETE FROM Users " +
                                                          "WHERE username='" + username + "';", myConnection);

                // Execute SQL command
                myCommand.ExecuteNonQuery();

                // Close DB connection
                myConnection.Close();
            }
            catch (Exception exc) { throw exc; }
        }


        public void createRentalList()
        {
            rentalList.Clear();

            try
            {
                // Connect to DB
                myConnection.Open();

                // Create SQL command
                MySqlCommand myCommand = new MySqlCommand("SELECT * FROM Rentals;", myConnection);

                // Read result data
                MySqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    rentalRow row = new rentalRow();
                    row.id = Convert.ToInt32(reader["id"]);
                    row.type = reader["type"].ToString();
                    row.title = reader["title"].ToString();
                    row.genre = reader["genre"].ToString();
                    row.releaseDate = reader["releaseDate"].ToString();
                    row.price = reader["price"].ToString();
                    row.reviewScore = reader["reviewScore"].ToString();

                    rentalList.Add(row);
                }

                // Close DB connection
                myConnection.Close();
            }
            catch (Exception exc) { throw exc; }
        }


        public void addRental(string type, string title, string genre, string releaseDate, string price, string reviewScore)
        {

            try
            {
                // Connect to DB
                myConnection.Open();

                // Create SQL command
                MySqlCommand myCommand = new MySqlCommand("INSERT INTO Rentals (type, title, genre, releaseDate, price, reviewScore) " +
                                                          "Values ('" + type + "', '" + title + "', '" + genre + "', '" + releaseDate + "', '" + price + "', '" + reviewScore + "')", myConnection);

                // Execute SQL command
                myCommand.ExecuteNonQuery();

                // Close DB connection
                myConnection.Close();
            }
            catch (Exception exc) { throw exc; }
        }


        public rentalRow findRental(string id)
        {

            rentalRow result = new rentalRow();

            try
            {
                // Connect to DB
                myConnection.Open();

                // Create SQL command
                MySqlCommand myCommand = new MySqlCommand("SELECT * FROM Rentals " +
                                                          "WHERE id=" + id + ";", myConnection);

                // Read result data
                MySqlDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    result.type = reader["type"].ToString();
                    result.title = reader["title"].ToString();
                    result.genre = reader["genre"].ToString();
                    result.releaseDate = reader["releaseDate"].ToString();
                    result.price = reader["price"].ToString();
                    result.reviewScore = reader["reviewScore"].ToString();
                }

                // Close DB connection
                myConnection.Close();
            }
            catch (Exception exc) { throw exc; }

            return result;

        }


        public void editRental(string id, string type, string title, string genre, string releaseDate, string price, string reviewScore)
        {

            try
            {
                // Connect to DB
                myConnection.Open();

                // Create SQL command
                MySqlCommand myCommand = new MySqlCommand("UPDATE Rentals " +
                                                          "SET type='" + type + "', title='" + title + "', genre='" + genre + "', releaseDate='" + releaseDate + "', price='" + price +
                                                          "', reviewScore='" + reviewScore + "' " +
                                                          "WHERE id=" + id + ";", myConnection);

                // Execute SQL command
                myCommand.ExecuteNonQuery();

                // Close DB connection
                myConnection.Close();
            }
            catch (Exception exc) { throw exc; }
        }


        public void deleteRental(string id)
        {

            try
            {
                // Connect to DB
                myConnection.Open();

                // Create SQL command
                MySqlCommand myCommand = new MySqlCommand("DELETE FROM Rentals " +
                                                          "WHERE id=" + id + ";", myConnection);

                // Execute SQL command
                myCommand.ExecuteNonQuery();

                // Close DB connection
                myConnection.Close();
            }
            catch (Exception exc) { throw exc; }
        }


    }
}
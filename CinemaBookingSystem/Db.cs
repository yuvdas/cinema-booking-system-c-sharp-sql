using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CinemaBookingSystem
{
    class Db
    {
        public static OleDbConnection GetConnection()
        {
            //string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\dassy001\Downloads\CinemaBookingSystem\CinemaBookingSystem\CinemaBookingSystem\Database.accdb'";//sql command
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='U:\Visual Studio 2013\Projects\CinemaBookingSystem\CinemaBookingSystem\Database.accdb'";//sql command            
            return new OleDbConnection(directory);//returns database connection
        }

        public static string GetDetailsFilmTitle(string filmID)
        {

            string LBname = "";

            OleDbConnection myConnection = Db.GetConnection();
            string myQuery = "select * from Films where FilmID = " + filmID + "";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    string Dataneeded = "FilmTitle";
                    LBname = reader[Dataneeded].ToString();
                    return LBname;
                }
            }
            catch (Exception ex)
            {
                LBname = "Exception in DBHandler" + ex;
                return LBname;
            }
            finally
            {
                myConnection.Close();

            }

            return LBname;//
        }

        public static string GetDetailsFilmDescription(string filmID)
        {

            string LBname = "";

            OleDbConnection myConnection = Db.GetConnection();
            string myQuery = "select * from Films where FilmID = " + filmID + "";
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    string Dataneeded = "FilmDescription";
                    LBname = reader[Dataneeded].ToString();
                    return LBname;
                }
            }
            catch (Exception ex)
            {
                LBname = "Exception in DBHandler" + ex;
                return LBname;
            }
            finally
            {
                myConnection.Close();

            }

            return LBname;//
        }

        public static string ADDDetailsCustomers(string firstName, string lastName, string email)
        {
            //string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\dassy001\Downloads\CinemaBookingSystem\CinemaBookingSystem\CinemaBookingSystem\Database.accdb'";//sql command
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='U:\Visual Studio 2013\Projects\CinemaBookingSystem\CinemaBookingSystem\Database.accdb'";//sql command   
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "INSERT INTO Customers( FirstName, LastName, Email)  VALUES ( '" + firstName + "' , '" + lastName + "' , '" + email + "')";//sql command
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "ok";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }

        public static string ADDDetailsOrders(string firstName, string lastName, string email, string filmID)
        {
            //string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\dassy001\Downloads\CinemaBookingSystem\CinemaBookingSystem\CinemaBookingSystem\Database.accdb'";//sql command
            string directory = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source='U:\Visual Studio 2013\Projects\CinemaBookingSystem\CinemaBookingSystem\Database.accdb'";//sql command   
            OleDbConnection databaseConnection = new OleDbConnection(directory);//returns database connection
            string query = "INSERT INTO Orders( FilmID, CustomerID)  VALUES ( '" + filmID + "' , 'SELECT CustomerID FROM Customers WHERE FirstName = " + firstName + " AND LastName = " + lastName + " AND Email = " + email + "')";//sql command
            OleDbCommand command = new OleDbCommand(query, databaseConnection);//create command for query 
            string returnedValue;
            try
            {
                databaseConnection.Open();//open database
                command.ExecuteNonQuery();//runs query in database
                returnedValue = "ok";
                return returnedValue;
            }

            catch (Exception ex)//if it fails
            {
                returnedValue = "Exception in DBHandler" + ex;
                return returnedValue;//returns error
            }

            finally
            {
                databaseConnection.Close();//closes database connection
            }
        }
    }
}

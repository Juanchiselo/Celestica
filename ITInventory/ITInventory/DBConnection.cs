using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Data;
using System.Configuration;

public sealed class DBConnection
{
    private static readonly DBConnection instance = new DBConnection();

    private DBConnection()
    {
        Initialize();
    }

    public static DBConnection Instance
    {
        get { return instance; }
    }


    private MySqlConnection connection;
    private string server = System.Configuration.ConfigurationManager.AppSettings["server"];
    private string database = System.Configuration.ConfigurationManager.AppSettings["database"];
    private string uid = System.Configuration.ConfigurationManager.AppSettings["uid"];
    private string password = System.Configuration.ConfigurationManager.AppSettings["password"];

    public void Initialize()
    {
        string connectionString;

        connectionString = "SERVER=" + server + ";DATABASE=" + database
            + ";UID=" + uid + ";PASSWORD=" + password + ";";
        connection = new MySqlConnection(connectionString);
    }

    private bool OpenConnection()
    {
        try
        {
            if (DoesDatabaseExist())
            {
                connection.Open();
                return true;
            }
            else
                return false;
        }
        catch(MySqlException exception)
        {
            MessageBox.Show("ERROR: " + exception.Message);

            switch(exception.Number)
            {
                case 0:
                    MessageBox.Show("Cannot connect to server. Contact administrator.");
                    break;
                case 1045:
                    MessageBox.Show("Invalid username/password, please try again.");
                    break;
            }
            return false;
        }
    }

    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch(MySqlException exception)
        {
            MessageBox.Show(exception.Message);
            return false;
        }
    }

    public bool Insert(string query)
    {
        Console.WriteLine(query);

        if(this.OpenConnection())
        {
            // Creates a command and assigns the query and the connection
            // from the constructor.
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                // Executes the command.
                command.ExecuteNonQuery();
                this.CloseConnection();
                return true;
            }
            catch(MySqlException exception)
            {
                MessageBox.Show("ERROR: " + exception.Message);

                // Closes the connection.
                this.CloseConnection();

                return false;
            }
        }

        return false;
    }

    public bool Update(string query)
    {
        Console.WriteLine(query);

        if(this.OpenConnection())
        {
            // Creates a command and assigns the query and the connection
            // from the constructor.
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                // Executes the command.
                command.ExecuteNonQuery();
                this.CloseConnection();
                return true;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("ERROR: " + exception.Message);

                // Closes the connection.
                this.CloseConnection();

                return false;
            }
        }

        return false;
    }

    public void Delete(string query)
    {
        Console.WriteLine(query);

        if(this.OpenConnection())
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            this.CloseConnection();
        }
    }
   
    public DataTable Select(string query)
    {
        Console.WriteLine(query);

        // Create a list to store the results.
        DataTable dataTable = new DataTable();

        if (this.OpenConnection())
        {
            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader dataReader = command.ExecuteReader();

            dataTable.Load(dataReader);

            dataReader.Close();

            this.CloseConnection();

            return dataTable;
        }
        else
        {
            return dataTable;
        }
    }

    public int Count(string query)
    {
        int Count = -1;

        if (this.OpenConnection())
        {
            MySqlCommand command = new MySqlCommand(query, connection);

            Count = int.Parse(command.ExecuteScalar() + "");

            this.CloseConnection();

            return Count;
        }
        else
            return Count;
    }

    public void Backup()
    {

    }

    public void Restore()
    {

    }

    public DataTable ViewTable(string table)
    {
        DataTable dataTable = new DataTable();

        if (this.OpenConnection())
        {
            string query = "SELECT assetTag, serial, PCID, tbltype.type, tblbrand.brand, "
                + "tblmodel.model, tbllocation.location, comment, belongsTo, "
                + "CONCAT(tbluser.firstName, ' ', tbluser.lastName) AS name, tblos.os FROM tblinventory "
                + "LEFT JOIN tbltype ON tblinventory.typeID = tbltype.typeID "
                + "LEFT JOIN tblbrand ON tblinventory.brandID = tblbrand.brandID "
                + "LEFT JOIN tblmodel ON tblinventory.modelID = tblmodel.modelID "
                + "LEFT JOIN tbllocation ON tblinventory.locationID = tbllocation.locationID "
                + "LEFT JOIN tbluser ON tblinventory.userID = tbluser.userID "
                + "LEFT JOIN tblos ON tblinventory.osID = tblos.osID;";

            Console.WriteLine(query);

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = command;

            
            mySqlDataAdapter.Fill(dataTable);
                        
            this.CloseConnection();
        }

        return dataTable;
    }

    public bool DoesDatabaseExist()
    {
        if (server.Equals("")
            && database.Equals("")
            && uid.Equals("")
            && password.Equals(""))
            return false;
        else
            return true;
    }

    public bool CreateDatabase(string server, string database,
        string uid, string password)
    {
        string connectionString = "Data source=" + server
            + ";UserId=" + uid + ";Password=" + password + ";";

        connection = new MySqlConnection(connectionString);

        MySqlCommand command = new MySqlCommand();

        try
        {
            command.Connection = connection;
            command.Connection.Open();
            Console.WriteLine("Connection opened.");
        }
        catch(NullReferenceException exception)
        {
            Console.WriteLine("ERROR: {0}", exception.ToString());
        }

        string query = "CREATE DATABASE IF NOT EXISTS "
                    + database + ";";

        command.CommandText = query;

        Console.WriteLine(query);

        try
        {
            command.ExecuteNonQuery();
            Console.WriteLine("Database created.");

            command.CommandText = "USE " + database + ";";
            command.ExecuteNonQuery();

            command.CommandText = "CREATE TABLE IF NOT EXISTS tblUser "
                + "(userID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY, "
                + "username VARCHAR(50) NOT NULL UNIQUE, "
                + "firstName VARCHAR(50) NOT NULL, "
                + "lastName VARCHAR(50) NOT NULL, "
                + "isAdmin TINYINT(1) NOT NULL);";
            command.ExecuteNonQuery();
            
            command.CommandText = "CREATE TABLE IF NOT EXISTS tblType "
                + "(typeID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY, "
                + "type VARCHAR(50) NOT NULL UNIQUE);";
            command.ExecuteNonQuery();

            command.CommandText = "CREATE TABLE IF NOT EXISTS tblBrand "
                + "(brandID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY, "
                + "brand VARCHAR(50) NOT NULL, "
                + "typeID INT(11));";
            command.ExecuteNonQuery();
            
            command.CommandText = "CREATE TABLE IF NOT EXISTS tblModel "
                + "(modelID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY, "
                + "model VARCHAR(50) NOT NULL, "
                + "brandID INT(11) NOT NULL);";
            command.ExecuteNonQuery();
            
            command.CommandText = "CREATE TABLE IF NOT EXISTS tblOS "
                + "(osID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY, "
                + "os VARCHAR(50) NOT NULL UNIQUE);";
            command.ExecuteNonQuery();

            command.CommandText = "CREATE TABLE IF NOT EXISTS tblLocation "
                + "(locationID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY, "
                + "location VARCHAR(50) NOT NULL UNIQUE);";
            command.ExecuteNonQuery();

            command.CommandText = "CREATE TABLE IF NOT EXISTS tblInventory "
                + "(inventoryID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY, "
                + "assetTag VARCHAR(50) NOT NULL UNIQUE, "
                + "serial VARCHAR(50) NOT NULL, "
                + "typeID INT(11) NOT NULL, "
                + "brandID INT(11) NOT NULL, "
                + "modelID INT(11) NOT NULL, "
                + "locationID INT(11) NOT NULL, "
                + "osID INT(11) NOT NULL, "
                + "pcID VARCHAR(50) NOT NULL, "
                + "belongsTo VARCHAR(50) NOT NULL, "
                + "userID INT(11) NOT NULL, "
                + "editedBy INT(11) NOT NULL, "
                + "comment TEXT, "
                + "hasMouse TINYINT(1), "
                + "hasKeyboard TINYINT(1), "
                + "hasScanner TINYINT(1), "
                + "hasCamera TINYINT(1), "
                + "hasPSU TINYINT(1), "
                + "hasDockingStation TINYINT(1));";
            command.ExecuteNonQuery();

            command.CommandText = "CREATE TABLE IF NOT EXISTS tblPM "
               + "(pmID INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY, "
               + "locationID INT(11) NOT NULL, "
               + "pcID VARCHAR(50) NOT NULL, "
               + "ticketNumber VARCHAR(50), "
               + "userID INT(11) NOT NULL, "
               + "commentCategory VARCHAR(50), "
               + "comment TEXT, "
               + "isValidComputerName TINYINT(1), "
               + "isConnectedToNetwork TINYINT(1), "
               + "hasMcafee TINYINT(1), "
               + "hasViperLink TINYINT(1), "
               + "hasChrome TINYINT(1), "
               + "isMouseWorking TINYINT(1), "
               + "isKeyboardWorking TINYINT(1), "
               + "isScannerWorking TINYINT(1), "
               + "hasNewpassSticker TINYINT(1), "
               + "hasPCIDSticker TINYINT(1), "
               + "didCleanWorkstation TINYINT(1), "
               + "didCableManagement TINYINT(1));";
            command.ExecuteNonQuery();
        }
        catch (MySqlException exception)
        {
            Console.WriteLine("ERROR: {0}", exception.ToString());
            return false;
        }
        finally
        {
            command.Connection.Close();
            Console.WriteLine("Connection closed.");
        }
        return true;
    }

    public string Server
    {
        get { return server; }
        set { server = value; }
    }

    public string Database
    {
        get { return database; }
        set { database = value; }
    }

    public string UID
    {
        get { return uid; }
        set { uid = value; }
    }

    public string Password
    {
        get { return password; }
        set { password = value; }
    }
}
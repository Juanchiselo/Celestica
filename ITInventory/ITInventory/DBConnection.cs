using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Data;

public sealed class DBConnection
{
    private static readonly DBConnection instance = new DBConnection();

    private DBConnection()
    {
        Initialize();
    }

    public static DBConnection Instance
    {
        get
        {
            return instance;
        }
    }


    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    private void Initialize()
    {
        server = "ONTDTVFV";
        database = "ont_inventory";
        uid = "inventory";
        password = "viper123";
        string connectionString;
        connectionString = "SERVER=" + server + ";DATABASE=" + database
            + ";UID=" + uid + ";PASSWORD=" + password + ";";
        connection = new MySqlConnection(connectionString);
    }

    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
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

    public BindingSource ViewTable(string table)
    {
        BindingSource bindingSource = new BindingSource();

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

            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource.DataSource = dataTable;
            
            this.CloseConnection();
        }

        return bindingSource;
    }

    public bool DoesDatabaseExist()
    {
        return OpenConnection();
    }
}
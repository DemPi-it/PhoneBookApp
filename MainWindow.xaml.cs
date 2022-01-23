using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PhoneBookApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string sqlRequest = "SELECT * FROM [dbo].[PhoneBookTable]";
            DataTable dt = Select(sqlRequest);
            dgPhoneNumber.ItemsSource = dt.DefaultView; // Filling DataGrid with data from DataBase
        }

        public DataTable Select(string selectSQL) // Method to get data from DataBase
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=DESKTOP-7SHDMNV\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=PhoneBook;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ControlDigit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _connectionEstablished = false;
        private LibraCentralEntities dbCentral = null;
        private LibraSofiaEntities dbSofia = null;
        private LibraBurgasEntities dbBurgas = null;
        private LibraVarnaEntities dbVarna = null;
        private LibraPlovdivEntities dbPlovdiv = null;
        private LibraVelikoTyrnovoEntities dbVelikoTyrnovo = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!isValid(textBox.Text))
            {
                textBox.Text = "";
                textLabel.Content = "";
            }
            else
            {
                Calculate();
                if (_connectionEstablished)
                    GetDataFromDB(textBox.Text);
            }
        }

        private void GetDataFromDB(string text)
        {
            if (Int32.TryParse(text, out int intVal))
            {
                Article a = null; 
                string article = "";
                string customer = "";
                try
                {
                    a = dbCentral.Articles.Find(intVal);
                    if (a == null)
                    {
                        article = "Няма артикул с този номер";
                    }
                    else
                    {
                        article += a.CyrName;
                    }
                }
                catch (Exception)
                {
                    article = "Не е намерен артикул с този номер";
                }
                try
                {
                    Customer c = null;
                    int i = Int32.Parse(text[0].ToString());
                    switch (i)
                    {
                        case 2:
                            if (dbSofia == null)
                                customer = "Няма връзка с база данни dbSofia!";
                            else
                                c = dbSofia.Customers.Find(intVal);
                            break;
                        case 3:
                            if (dbBurgas == null)
                                customer = "Няма връзка с база данни dbBurgas!";
                            else
                                c = dbBurgas.Customers.Find(intVal);
                            break;
                        case 4:
                            if (dbVarna == null)
                                customer = "Няма връзка с база данни dbVarna!";
                            else
                                c = dbVarna.Customers.Find(intVal);
                            break;
                        case 5:
                            if (dbPlovdiv == null)
                                customer = "Няма връзка с база данни dbPlovdiv!";
                            else
                                c = dbPlovdiv.Customers.Find(intVal);
                            break;
                        case 7:
                            if (dbVelikoTyrnovo == null)
                                customer = "Няма връзка с база данни dbVelikoTyrnovo!";
                            else
                                c = dbVelikoTyrnovo.Customers.Find(intVal);
                            break;
                        default:
                            if (dbCentral == null)
                                customer = "Няма връзка с база данни dbCentral!";
                            else
                                c = dbCentral.Customers.Find(intVal);
                            break;
                    }
                    if (c == null)
                    {
                        if (customer == "")
                            customer = "Не е намерен клиент с този номер";
                    }
                    else
                    {
                        customer += c.Name;
                    }
                    PopulateDataGrid(c, a);
                }
                catch (Exception)
                {
                    customer = "Няма връзка с базата или не е намерен клиент с този номер!";
                }
                
                //textLabel.Content = "Артикул: " + Environment.NewLine + article + Environment.NewLine + "Клиент:" + Environment.NewLine + customer;
            }
        }

        private void PopulateDataGrid(Customer c, Article a)
        {
            ObservableCollection<Article> articles = new ObservableCollection<Article>();
            if (a != null)
            {
                articles.Add(a);
            }
            ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
            if (c != null)
            {
                customers.Add(c);
            }
            if(articles != null)
            {
                dataGridArticle.ItemsSource = articles;
            }
            if(customers != null)
            {
                dataGridCustomer.ItemsSource = customers;
            }
        }

        private void Calculate()
        {
            if(int.TryParse(textBox.Text, out int number))
            {
                int result = (7 * ((number / 1) % 10) + 6 * ((number / 10) % 10)
                + 5 * ((number / 100) % 10) + 4 * ((number / 1000) % 10)
                + 3 * ((number / 10000) % 10) + 2 * ((number / 100000) % 10));
                if ((result % 11) == 10)
                    number = number * 10 + 0;
                else
                    number = number * 10 + (result % 11);
                textLabel.Content = number;
            }
            
        }

        private bool isValid(string input)
        {
            try
            {
                int.Parse(input);
            }
            catch
            {
                if (input != "" && input != null)
                    textLabel.Content = "Въведете валиден номер!!!";
                return false;
            }
            return true;
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            string currentDb = "";
            try
            {
                dbCentral = new LibraCentralEntities();
                currentDb += "Central - connected;";
                dbSofia = new LibraSofiaEntities();
                currentDb += "Sofia - connected;";
                dbBurgas = new LibraBurgasEntities();
                currentDb += "Burgas - connected;";
                dbVarna = new LibraVarnaEntities();
                currentDb += "Varna - connected;";
                dbPlovdiv = new LibraPlovdivEntities();
                currentDb += "Plovdiv - connected;";
                dbVelikoTyrnovo = new LibraVelikoTyrnovoEntities();
                currentDb += "VelikoTyrnovo - connected;";
                _connectionEstablished = true;
            }
            catch (Exception)
            {
                textLabel.Content = "No Connection to some of the databases!" + Environment.NewLine + currentDb;
            }
        }
    }
}

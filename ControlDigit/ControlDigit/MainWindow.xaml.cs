using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
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
        //private LibraSofiaEntities dbSofia = null;
        //private LibraBurgasEntities dbBurgas = null;
        //private LibraVarnaEntities dbVarna = null;
        //private LibraPlovdivEntities dbPlovdiv = null;
        //private LibraVelikoTyrnovoEntities dbVelikoTyrnovo = null;
        //private List<LibraEntities> dataBases = new List<LibraEntities>();
        public MainWindow()
        {
            InitializeComponent();
        }        

        private int GetFirstDigit(int i)
        {
            while (i >= 10)
                i /= 10;
            return i;
        }

        private void GetDataFromDB(int intVal)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                dataGridArticle.ItemsSource = null;
                dataGridCustomer.ItemsSource = null;
            }));
            CustomerMasterData c = dbCentral.CustomerMasterDatas.Find(intVal);
            if (c != null)
            {
                PopulateDataGrid(c);
            }
            Article a = dbCentral.Articles.Find(intVal);
            if (a != null)
            {
                PopulateDataGrid(a);
            }
        }

        private void PopulateDataGrid(CustomerMasterData c = null, Article a = null)
        {
            if(c != null)
                PopulateDataGrid(c);
            if(a != null)
                PopulateDataGrid(a);            
        }

        private void PopulateDataGrid<T>(T obj)
        {
            ObservableCollection<T> collection = new ObservableCollection<T>();
            if (obj != null)
            {
                collection.Add(obj);
            }
            if (collection != null)
            {
                if (obj.GetType() == typeof(CustomerMasterData))
                {
                    try
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            dataGridCustomer.ItemsSource = collection;
                        }));
                    }
                    catch (Exception){ }
                }
                else if (obj.GetType() == typeof(Article))
                {
                    try
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            dataGridArticle.ItemsSource = collection;
                        }));
                    }
                    catch (Exception) { }
                }
            }
        }

        private void Calculate(int number)
        {
            int result = (7 * ((number / 1) % 10) + 6 * ((number / 10) % 10)
            + 5 * ((number / 100) % 10) + 4 * ((number / 1000) % 10)
            + 3 * ((number / 10000) % 10) + 2 * ((number / 100000) % 10));
            if ((result % 11) == 10)
                number = number * 10 + 0;
            else
                number = number * 10 + (result % 11);
            textLabel.Text = number.ToString();
        }

        private bool isValid(string input, out int number)
        {
            if(int.TryParse(input, out int i))
            {
                number = i;
                return true;
            }
            else
            {
                if (input != "" && input != null)
                    textLabel.Text = "Въведете валиден номер!!!";
                number = 0;
                return false;
            }
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                dbCentral = new LibraCentralEntities();
                /*dataBases.Add(dbCentral);
                dbSofia = new LibraSofiaEntities();
                currentDb += "Sofia - connected;";
                dataBases.Add(dbSofia);
                dbBurgas = new LibraBurgasEntities();
                currentDb += "Burgas - connected;";
                dataBases.Add(dbBurgas);
                dbVarna = new LibraVarnaEntities();
                currentDb += "Varna - connected;";
                dataBases.Add(dbVarna);
                dbPlovdiv = new LibraPlovdivEntities();
                currentDb += "Plovdiv - connected;";
                dataBases.Add(dbPlovdiv);
                dbVelikoTyrnovo = new LibraVelikoTyrnovoEntities();
                currentDb += "VelikoTyrnovo - connected;";
                dataBases.Add(dbVelikoTyrnovo);//*/
                _connectionEstablished = true;
            }
            catch (Exception)
            {
                textLabel.Text = "No Connection to the database!";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isValid(textBox.Text, out int i))
            {
                Calculate(i);
                if (_connectionEstablished)
                {
                    if (Int32.TryParse(textBox.Text, out int intVal))
                    {
                        Thread t = new Thread(() => GetDataFromDB(intVal));
                        t.Start();
                        t.Join();
                    }
                }
            }
            else
            {
                textBox.Text = "";
                textLabel.Text = "Невалидно число!";
            }
        }
    }
}

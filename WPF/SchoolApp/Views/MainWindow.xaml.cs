using SistemaEscola.Enum;
using SistemaEscola.ViewModel;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SchoolApp.Views
{
    /// <summary>
    /// Lógica interna para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            ComboAdicionarPessoas.ItemsSource = Enum.GetValues(typeof(AdicionarPessoas)).Cast<AdicionarPessoas>();
            
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void DisableButton()
        //{
        //    Button1.IsEnabled = false;
        //}
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

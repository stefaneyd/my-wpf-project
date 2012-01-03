using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person src = new Person { Name = "Stefán", Age = 39 };
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = src;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = src.Name + " is " + src.Age;
            MessageBox.Show(message);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            src.Age += 1;

            //ageText.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
        }
    }
}

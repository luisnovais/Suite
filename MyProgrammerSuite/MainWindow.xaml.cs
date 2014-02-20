using System;
using System.Collections.Generic;
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
using Core;
using MyProgrammerSuite.Utilities;

namespace MyProgrammerSuite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Entities _entities = new Entities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String value = this.txtField.Text.ToString();
            String translation = this.txtTranslateValue.Text.ToString();

            
            _entities.AddNewEntity(new Entity(value,translation));

            //MessageBox.Show(String.Format("Valor: {0} \nTradução: {1}", value, translation));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EntitiesSave entitiesSave = new EntitiesSave(_entities.EntitiesList);
        }
    }
}

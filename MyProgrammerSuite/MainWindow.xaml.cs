using System;
using System.Windows;
using System.Windows.Controls;
using Core.Suite;
using MyProgrammerSuite.Utilities;

namespace MyProgrammerSuite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly Entities _entities = new Entities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            String value = this.txtField.Text;
            String translation = this.txtTranslateValue.Text;
            _entities.AddNewEntity(new Entity(value,translation));
        }

        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            var entitiesSave = new EntitiesSave(_entities.EntitiesList);
            foreach (var scriptLineTop in entitiesSave.ScriptLinesListTop)
            {
                lstScriptTopLines.Items.Add(new ListBoxItem {Content = scriptLineTop});
            }

            foreach (var scriptLineBot in entitiesSave.ScriptLinesListBot)
            {
                lstScriptBotLines.Items.Add(new ListBoxItem { Content = scriptLineBot });
            }
        }
    }
}

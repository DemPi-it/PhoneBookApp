using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PhoneBookApp
{
    /// <summary>
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        public void ColorsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color selectedColor = (Color)(ColorsBox.SelectedItem as PropertyInfo).GetValue(1,null);
            var ColorSet = new SolidColorBrush(selectedColor);
            this.Background = ColorSet;
            
        }

        public void TextBlock_Loaded(object sender, RoutedEventArgs e)
        {
            ColorsBox.ItemsSource = typeof(Colors).GetProperties();
        }
    }
}

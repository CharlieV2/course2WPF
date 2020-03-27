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

namespace wpftest.ControlCollection
{
    /// <summary>
    /// Логика взаимодействия для eye_TextBox.xaml
    /// </summary>
    public partial class eye_TextBox : UserControl
    {
        public eye_TextBox()
        {
            InitializeComponent();
            rectangle.Stroke = new SolidColorBrush(Color.FromRgb(235, 235, 235));
            Content.Text = "";
        }

        private void Content_GotFocus(object sender, RoutedEventArgs e)
        {
            rectangle.Stroke = new SolidColorBrush(Color.FromRgb(86, 157, 229));
        }

        private void Content_LostFocus(object sender, RoutedEventArgs e)
        {
            rectangle.Stroke = new SolidColorBrush(Color.FromRgb(235, 235, 235));
        }
    }
}

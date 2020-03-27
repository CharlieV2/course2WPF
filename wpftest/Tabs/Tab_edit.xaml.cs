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
using wpftest.HelpClasses;
using System.IO;

namespace wpftest.Tabs
{
    /// <summary>
    /// Логика взаимодействия для Tab_edit.xaml
    /// </summary>
    public partial class Tab_edit : UserControl
    {
        public Tab_edit()
        {
            InitializeComponent();
        }

        private void btnAddRandom_Click(object sender, RoutedEventArgs e)
        {             
            Vars.sportsmens.Add(new Sportsmen().Create());

            //StringBuilder final = new StringBuilder();

            //foreach (Sportsmen item in Vars.sportsmens)
            //{
            //    final.Append(item.Country + "_" +
            //                 item.Name + "_" +
            //                 item.Surname + "_" +
            //                 item.Age + "_" +
            //                 item.Sport + "_" +
            //                 item.Gold + "_" +
            //                 item.Silver + "_" +
            //                 item.Bronze + "\n");
            //}

            //File.WriteAllText(Vars.DesktopPath + "ff" + ".bd", final.ToString());
        }

        private void btnFillRandom_Click(object sender, RoutedEventArgs e)
        {
            Sportsmen sportsmen = new Sportsmen().Create();

            txtCountry.Content.Text = sportsmen.Country;
            txtName.Content.Text = sportsmen.Name;
            txtSurname.Content.Text = sportsmen.Surname;
            txtSport.Content.Text = sportsmen.Sport;
            txtAge.Content.Text = sportsmen.Age.ToString();
        }
    }
}

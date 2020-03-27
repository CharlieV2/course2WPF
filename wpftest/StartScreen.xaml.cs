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
using System.Xml.Linq;
using wpftest.HelpClasses;
using System.IO;

namespace wpftest
{
    /// <summary>
    /// Логика взаимодействия для StartScreen.xaml
    /// </summary>
    public partial class StartScreen : UserControl
    {
        FileWorker fileWorker = new FileWorker();

        public StartScreen()
        {
            InitializeComponent();
            
        }

        // --- Action buttons --- 
        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            fileWorker.CreateBD(txtBDname.Text);
            txtBDname.Clear();
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            fileWorker.DeleteBD(txtBDname.Text);
            txtBDname.Clear();
        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            txtBDname.Clear();
        }


        // --- Drag & Drop --- 
        private void StartPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effects = DragDropEffects.All;
            }
        }
        private void StartPanel_Drop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (System.IO.Path.GetExtension(file[0]) == ".bd")
            {
                Vars.DesktopPath = System.IO.Path.GetDirectoryName(file[0]) + @"\";

                txtBDname.Text = System.IO.Path.GetFileNameWithoutExtension(file[0]);
            }
        }


        // --- Input handler --- 
        private void txtBDname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBDname.Text != "")
            {
                statusBorder.Visibility = Visibility.Visible;
                lblstatusBD.Visibility = Visibility.Visible;

                string statusBD = fileWorker.CheckBD(txtBDname.Text);
                lblstatusBD.Content = statusBD;

                switch (statusBD)
                {
                    case "All good":
                        btnCreate.Content = "Rewrite";

                        statusBorder.Stroke = Brushes.Lime;
                        break;

                    case "Empty":
                        btnCreate.Content = "Rewrite";

                        statusBorder.Stroke = Brushes.Yellow;
                        break;

                    case "Not exist":
                        btnCreate.Content = "Add";

                        statusBorder.Stroke = Brushes.Tomato;
                        break;
                }
            }
            else
            {
                btnCreate.Content = "Add";

                lblstatusBD.Visibility = Visibility.Hidden;
                statusBorder.Visibility = Visibility.Hidden;
            }
        }
    }
}

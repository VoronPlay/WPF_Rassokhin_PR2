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

namespace WPF_Rassokhin_PR3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Schet_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += Environment.NewLine + "Практическая работа 2";

            double h = double.Parse(H.Text);

            Itog.Text += Environment.NewLine + "H = " + h.ToString();

            double R = double.Parse(Ra.Text);

            Itog.Text += Environment.NewLine + "R = " + R.ToString();

            double r = double.Parse(Rs.Text);

            Itog.Text += Environment.NewLine + "r = " + r.ToString();

            double l = Math.Sqrt(h * h + (R - r * r));

            Itog.Text += Environment.NewLine + "Результат l" + l.ToString();
        }
    }
}

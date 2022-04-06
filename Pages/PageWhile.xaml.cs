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

namespace PracWork9.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageWhile.xaml
    /// </summary>
    public partial class PageWhile : Page
    {
        public PageWhile()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            //табулирование функции циклом While 
            double x0 = Convert.ToDouble(txtX0.Text);
            double xk = Convert.ToDouble(txtXK.Text);
            double dx = Convert.ToDouble(txtDX.Text);
            double a = Convert.ToDouble(txtA.Text);

            // Цикл для табулирования функции
            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y = a * Math.Log(x); // формула функции
                lstTable.Items.Add($"x={x}  y={y}");
                x = x + dx;
            }
        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            clsFrame.frmObject.Navigate(new PageDoWhile());
        }
    }
}

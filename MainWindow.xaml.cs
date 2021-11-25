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

namespace HomeworkWPF14T1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                Name= "Креветки аргентинские 2кг",
                Price= 1900,
                Image=@"Data\krevetki.png",
                Category=Category.Продукты
            });
            products.Add(new Product()
            {
                Name = "Игра чёрная осетровая",
                Price = 10000,
                Image = @"Data\caviar.png",
                Category = Category.Продукты
            });
            products.Add(new Product()
            {
                Name = "Кофемашина Krups",
                Price = 60000,
                Image = @"Data\cofe.png",
                Category = Category.Бытовая_техника
            });

            lstBox.ItemsSource = products;






        }
    }
}

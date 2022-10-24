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

namespace Pract6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            Pair pair3 = new Pair(2, 4);
            pair3++;
            MessageBox.Show(pair3.ToString());
        }



        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Поливода А.А.\n" + "Практическая работа 5\n" + "Создать класс Pair (пара четных чисел). Создать необходимые методы и свойства. " +
                "\r\nОпределить метод вычисления произведения чисел. Создать перегруженный метод " +
                "\r\nдля вычисления произведения 2 пар чисел – (а, b) * (с, d) \n = (a * c) , (b * d).");
        }

        private void Start(object sender, RoutedEventArgs e)
        {

            try
            {
                var selectedPair = ListPair.SelectedItems;
                if (selectedPair.Count == 1)
                {
                    Pair pair1 = ListPair.Items[ListPair.SelectedIndex] as Pair;
                    Result.Text = pair1.Myltiply().ToString();
                }
                else
                {
                    Pair pair1 = selectedPair[0] as Pair;
                    Pair pair2 = selectedPair[1] as Pair;
                    Result.Text = pair2.Myltiply(pair1).ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AddPair(object sender, RoutedEventArgs e)
        {
            Pair pair = new Pair(Convert.ToInt32(FirstValue.Text), Convert.ToInt32(SecondValue.Text));
            ListPair.Items.Add(pair);
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

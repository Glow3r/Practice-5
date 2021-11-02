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

namespace Practice_5
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

        private void AddNumberToTriad_Click(object sender, RoutedEventArgs e)
        {
            Triad firstTriad = new Triad(int.Parse(firsttriadA.Text), int.Parse(secondtriadA.Text), int.Parse(thirdtriadA.Text));

            Triad resultTriad = firstTriad.Add(int.Parse(inputNumber.Text));

            MessageBox.Show($"{resultTriad.First} {resultTriad.Second} {resultTriad.Third}", $"Результат сложения триады A с числом {inputNumber.Text}", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void MultiplyTriadByNumber_Click(object sender, RoutedEventArgs e)
        {
            Triad firstTriad = new Triad(int.Parse(firsttriadA.Text), int.Parse(secondtriadA.Text), int.Parse(thirdtriadA.Text));

            Triad resultTriad = firstTriad.Multiply(int.Parse(inputNumber.Text));

            MessageBox.Show($"{resultTriad.First} {resultTriad.Second} {resultTriad.Third}", $"Результат уножения триады A с числом {inputNumber.Text}", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void AreTriadsEqual_Click(object sender, RoutedEventArgs e)
        {
            Triad firstTriad = new Triad(int.Parse(firsttriadA.Text), int.Parse(secondtriadA.Text), int.Parse(thirdtriadA.Text));

            if (firstTriad.AreEqual())
            {
                MessageBox.Show("Числа триады А равны!", "Проверка чисел триады А на равенство", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else MessageBox.Show("Числа триады А неравны!", "Проверка чисел триады А на равенство", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void SumTriads_Click(object sender, RoutedEventArgs e)
        {
            Triad firstTriad = new Triad(int.Parse(firsttriadA.Text), int.Parse(secondtriadA.Text), int.Parse(thirdtriadA.Text));

            Triad secondTriad = new Triad(int.Parse(firsttriadB.Text), int.Parse(secondtriadB.Text), int.Parse(thirdtriadB.Text));

            Triad resultTriad = firstTriad.Add(secondTriad);

            MessageBox.Show($"Результат сложения триады А с триадой В - {resultTriad.First} {resultTriad.Second} {resultTriad.Third}", "Сложение триад", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void GetInformation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Гаврюшин К. А. ИСП-34.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}


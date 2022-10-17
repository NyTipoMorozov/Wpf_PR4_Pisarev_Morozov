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

namespace Wpf_PR4_Pisarev_Morozov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random randomNumber = new Random();

        int number = 0;
        int guesses = 0;

        public MainWindow()
        {
         InitializeComponent();

            loadQuestions();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(txtEnterNumber.Text);

            guesses += 1;
            lblGuessed.Content = "Ты использовал " + guesses + " попыток";

            if (i == number)
            {
                MessageBox.Show("Круто, ты победил");
                loadQuestions();
                txtEnterNumber.Text = "";
                guesses = 0;
                this.Close();
            }
            else if (i < number)
            {
                MessageBox.Show("Идешь низко");
            }

            else
            {
                MessageBox.Show("Идешь высоко");
            }
        }

        private void loadQuestions()
        {
            number = randomNumber.Next(0, 10);
            lblQuestion.Content = "Угадай правельное чило: 0 до 10 ";
        }
    }
}

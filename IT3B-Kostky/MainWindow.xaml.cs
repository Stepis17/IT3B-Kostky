using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IT3B_Kostky
{
 /// <summary>
 /// Interaction logic for MainWindow.xaml
 /// </summary>
        public partial class MainWindow : Window
        {
            private Dice _dice;

            public MainWindow()
            {
                InitializeComponent();
                _dice = new Dice();
            }

            private void RollDiceButton_Click(object sender, RoutedEventArgs e)
            {
                Dice1.Text = _dice.Roll().ToString();
                Dice2.Text = _dice.Roll().ToString();
                Dice3.Text = _dice.Roll().ToString();
                Dice4.Text = _dice.Roll().ToString();
                Dice5.Text = _dice.Roll().ToString();
                Dice6.Text = _dice.Roll().ToString();
            }
        }
    }
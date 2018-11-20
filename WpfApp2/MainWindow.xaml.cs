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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game A_game;
        public MainWindow()
        {
            InitializeComponent();
           
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            A_game = new Game();
            A_game.startGame();
           

        }
        public static void MessageBoxShow(string a)            
        {
            MessageBox.Show(a);
        }

       

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            while (!A_game.gameover())
            {
                A_game.step();

            }
            MessageBoxShow("the winer is " + A_game.winer());

        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxShow(A_game.player1.ToString());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBoxShow(A_game.player2.ToString());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            A_game.step();
        }
    }
}

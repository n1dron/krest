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

namespace krest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class OknoWindow : Window
    {
        public string Move = "X";
        public string BotMove = "O";

        private bool Gang;
        private bool Bang = false;
        public OknoWindow()
        {
            InitializeComponent();
        }
        public int randomchik()
        {
            Random randomaz = new Random();
            int lol = randomaz.Next(0, 9);
            return lol;
        }
        public void Okno()
        {
            Random randomaz = new Random();
            int tyt = randomaz.Next(1, 3);
            if (tyt == 1)
            {
                robot();
            }
        }
        public void Krenol()
        {
            List<Button> spisok = new List<Button>() { but, but1, but2, but3, but4, but5, but6, but7, but8 };
            if ((but.Content == "X" && but1.Content == "X" && but2.Content == "X") || (but3.Content == "X" && but4.Content == "X" && but5.Content == "X")
                || (but6.Content == "X" && but7.Content == "X" && but8.Content == "X") || (but.Content == "X" && but3.Content == "X" && but6.Content == "X")
                || (but1.Content == "X" && but4.Content == "X" && but7.Content == "X") || (but2.Content == "X" && but5.Content == "X" && but8.Content == "X")
                || (but.Content == "X" && but4.Content == "X" && but8.Content == "X") || (but2.Content == "X" && but4.Content == "X" && but6.Content == "X"))
            {
                for (int i = 0; i < spisok.Count; i++)
                {
                    spisok[i].IsEnabled = false;
                }
                Text1.Text = "X Победил!";
                Bang = true;
            }
            else if ((but.Content == "O" && but4.Content == "O" && but2.Content == "O") || (but3.Content == "O" && but4.Content == "O" && but5.Content == "O")
                || (but6.Content == "O" && but7.Content == "O" && but8.Content == "O") || (but.Content == "O" && but3.Content == "O" && but6.Content == "O")
                || (but1.Content == "O" && but4.Content == "O" && but7.Content == "O") || (but2.Content == "O" && but5.Content == "O" && but8.Content == "O")
                || (but.Content == "O" && but4.Content == "O" && but8.Content == "O") || (but2.Content == "O" && but4.Content == "O" && but6.Content == "O"))
            {
                for (int i = 0; i < spisok.Count; i++)
                {
                    spisok[i].IsEnabled = false;
                }
                Text1.Text = "O Победил!";
                Bang = true;
            }
            else if ((but.IsEnabled == false) && (but1.IsEnabled == false) && (but2.IsEnabled == false) && (but3.IsEnabled == false)
                && (but4.IsEnabled == false) && (but5.IsEnabled == false) && (but6.IsEnabled == false) && (but7.IsEnabled == false) && (but8.IsEnabled == false))
            {
                for (int i = 0; i < spisok.Count; i++)
                {
                    spisok[i].IsEnabled = false;
                }
                Text1.Text = "Ничья:(";
                Bang = true;
            }
        }
        public void robot()
        {
            List<Button> spisok = new List<Button>() { but, but1, but2, but3, but4, but5, but6, but7, but8 };
            for (int i = 0; i < spisok.Count; i++)
            {
                if (spisok[i].IsEnabled == false || spisok[i].Content.ToString() != "")
                {
                    spisok.RemoveAt(i);
                }
            }
            Random opyatrandom = new Random();
            int z = 0;
            if (Gang == true)
            {
                if (spisok.Count > 0)
                {
                    while (true)
                    {
                        z = opyatrandom.Next(0, spisok.Count - 1);
                        if (spisok[z].IsEnabled == false)
                        {
                            z = opyatrandom.Next(0, spisok.Count - 1);
                        }
                        else
                            break;
                    }
                }
                else if (spisok.Count == 1)
                {
                    z = 0;
                }
                spisok[z].Content = "O";
                spisok[z].IsEnabled = false;
                Krenol();
            }
        }
        private void StartGame_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Move == "O" && BotMove == "X")
            {
                Move = "X";
                BotMove = "O";
            }
            else
            {
                Move = "O";
                BotMove = "X";
            }
            MessageBox.Show($"Вы: {Move}");
        //Структура кнопок
        }
        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            List<Button> spisok = new List<Button> { but, but1, but2, but3, but4, but5, but6, but7, but8 };
            foreach (Button button in spisok)
            {
                button.IsEnabled = true;
                button.Content = "";
            }
            Bang = false;
        }
        private void but_Click(object sender, RoutedEventArgs e)
        {
            but.Content = "X";
            but.IsEnabled = false;
            Gang = true;

            Krenol();
            if (Bang != true)
            {
                robot();
            }
        }
        private void but1_Click(object sender, RoutedEventArgs e)
        {
            but1.Content = "X";
            but1.IsEnabled = false;
            Gang = true;
            Krenol();
            if (Bang != true)
            {
                robot();
            }
        }
        private void but2_Click(object sender, RoutedEventArgs e)
        {
            but2.Content = "X";
            but2.IsEnabled = false;
            Gang = true;
            Krenol();
            if (Bang != true)
            {
                robot();
            }
        }
        private void but3_Click(object sender, RoutedEventArgs e)
        {
            but3.Content = "X";
            but3.IsEnabled = false;
            Gang = true;
            Krenol();
            if (Bang != true)
            {
                robot();
            }
        }
        private void but4_Click(object sender, RoutedEventArgs e)
        {
            but4.Content = "X";
            Gang = true;
            but4.IsEnabled = false;
            Krenol();
            if (Bang != true)
            {
                robot();
            }
        }
        private void but5_Click(object sender, RoutedEventArgs e)
        {
            but5.Content = "X";
            but5.IsEnabled = false;
            Gang = true;
            Krenol();
            if (Bang != true)
            {
                robot();
            }
        }
        private void but6_Click(object sender, RoutedEventArgs e)
        {
            but6.Content = "X";
            but6.IsEnabled = false;
            Gang = true;
            Krenol();
            if (Bang != true)
            {
                robot();
            }
        }
        private void but7_Click(object sender, RoutedEventArgs e)
        {
            but7.Content = "X";
            but7.IsEnabled = false;
            Gang = true;
            Krenol();
            if (Bang != true)
            {
                robot();
            }
        }
        private void but8_Click(object sender, RoutedEventArgs e)
        {
            but8.Content = "X";
            but8.IsEnabled = false;
            Gang = true;
            Krenol();
            if (Bang != true)
            {
                robot();
            }
        }
    }
}
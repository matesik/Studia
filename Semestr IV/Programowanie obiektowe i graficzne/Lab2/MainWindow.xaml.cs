using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System;


namespace Lab_02_4
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly List<Piłkarz> players;
        private readonly SaveToFile saveToFile;

        public MainWindow()
        {
            InitializeComponent();
            saveToFile = new SaveToFile();
            players = saveToFile.GetAll();

            foreach(var player in players)
            {
                listBox_pilkarze.Items.Add(player);
            }
        }

        private void button_dodaj_Click(object sender, RoutedEventArgs e)
        {
            Piłkarz newPlayer = new Piłkarz(
                 imie: textBox_imie.Text,
                 nazwisko: textBox_nazwisko.Text,
                 wzrost: Int32.Parse(textBox_wzrost.Text),
                 waga: Int32.Parse(textBox_waga.Text),
                 pozycja: (Pozycja)comboBox_pozycje.SelectedIndex);;
            listBox_pilkarze.Items.Add(newPlayer);
            players.Add(newPlayer);
            saveToFile.Save(players);

        }

        private void button_edytuj_Click(object sender, RoutedEventArgs e)
        {
            var index = listBox_pilkarze.SelectedIndex;
            if (index > -1)
            {
                var currentPlayer = new Piłkarz(listBox_pilkarze.SelectedItem as Piłkarz)
                {
                    Imię = textBox_imie.Text,
                    Nazwisko = textBox_nazwisko.Text,
                    Waga = Int32.Parse(textBox_waga.Text),
                    Wzrost = Int32.Parse(textBox_wzrost.Text),
                    Pozycja = (Pozycja)comboBox_pozycje.SelectedIndex,
                };

                listBox_pilkarze.Items[index] = currentPlayer;
                players[index] = currentPlayer;
                saveToFile.Save(players);
            }
        }

        private void listBox_pilkarze_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox_pilkarze.SelectedIndex > -1)
            {
                var currentPlayer = listBox_pilkarze.SelectedItem as Piłkarz;
                textBox_imie.Text = currentPlayer.Imię;
                textBox_nazwisko.Text = currentPlayer.Nazwisko;
                textBox_waga.Text = currentPlayer.Waga.ToString();
                textBox_wzrost.Text = currentPlayer.Wzrost.ToString();
                comboBox_pozycje.SelectedIndex = (int)currentPlayer.Pozycja;
            }
        }

        private void button_Usun_Click(object sender, RoutedEventArgs e)
        {
            var currentPlayerIndex = listBox_pilkarze.SelectedIndex;

            if (currentPlayerIndex > -1)
            {
                listBox_pilkarze.Items.RemoveAt(currentPlayerIndex);
                players.RemoveAt(currentPlayerIndex);

                saveToFile.Save(players);


                textBox_imie.Text = "Imię";
                textBox_nazwisko.Text = "Nazwisko";
                textBox_waga.Text = "Waga";
                textBox_wzrost.Text = "Wzrost";
                comboBox_pozycje.SelectedIndex = -1;
            }
        }
    }
}

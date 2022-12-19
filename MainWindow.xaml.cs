using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace CyberClub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Team> teams = new List<Team>();
        Team PlayerTeam;
        Tournament tournament;


        public MainWindow()
        {
            InitializeComponent();
            teams.Add(new Team("NaVi",1));
            teams.Add(new Team("G2", 2));
            teams.Add(new Team("Gambit", 3));
            teams.Add(new Team("NIP", 4));
            PlayerTeam = teams[0];
            YourTeam.Content = PlayerTeam.Name;
            tournament = new Tournament(teams);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenuButtons.Visibility = Visibility.Visible;
            TeamButtons.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainMenuButtons.Visibility = Visibility.Collapsed;
            TeamButtons.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainMenuButtons.Visibility = Visibility.Collapsed;
            EntranceWindow.Visibility = Visibility.Collapsed;
            TeamButtons.Visibility = Visibility.Collapsed;
            MatchWindow.Visibility = Visibility.Visible;

            Match NextMatch = tournament.PlayTournamentMatch();
            if (tournament.TournamentWinner != null)
            {
                MatchResult.Content = "В финале турнира победила команда " + tournament.TournamentWinner;
            }
            else
            {
                MatchResult.Content = "В матче турнира победила команда " + NextMatch.Winner;
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab6ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<SoccerTeams> 
            TeamsList { get; set; } = new ObservableCollection<SoccerTeams>();
        public ListViewGroup()
        {
            InitializeComponent();
            TeamsList.Add(new SoccerTeams("Peru",new[] {new Teams
            {
                Nombre = "Alianza Lima",
                DT_actual= "Carlos Bustos"
            },
            new Teams
            {
                Nombre="Universitario",
                DT_actual="Jorge Araujo"
            },
            new Teams
            {
                Nombre="FC Melgar",
                DT_actual="Nestor Lorenzo"

            }}));

            TeamsList.Add(new SoccerTeams("Brasil", new[] {new Teams
            {
                Nombre = "Palmeiras",
                DT_actual="Abel Ferreira"
            },
            new Teams
            {
                Nombre="Atletico Mineiro",
                DT_actual="Antonio Mohamed"
            },
            new Teams
            {
                Nombre="Flamengo",
                DT_actual="Paulo Souza"

            }}));

            TeamsList.Add(new SoccerTeams("Argentina", new[] {new Teams
            {
                Nombre = "River Plate",
                DT_actual="Marcelo Gallardo"
            },
            new Teams
            {
                Nombre="Estudiantes",
                DT_actual="Ricardo Zielinski"
            },
            new Teams
            {
                Nombre="Racing",
                DT_actual="Fernando Gago"

            }}));

            TeamsList.Add(new SoccerTeams("Argentina", new[] {new Teams
            {
                Nombre = "River Plate",
                DT_actual="Marcelo Gallardo"
            },
            new Teams
            {
                Nombre="Estudiantes",
                DT_actual="Ricardo Zielinski"
            },
            new Teams
            {
                Nombre="Racing",
                DT_actual="Fernando Gago"

            }}));


            BindingContext = this;
        }
    }
}
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionLibrary
{
    public class ObservableListe : ObservableObject
    {
        private readonly Liste liste;

        public ObservableListe(Liste liste) => this.liste = liste;

        public int Numero
        {
            get => liste.Numero;
            set => SetProperty(liste.Numero, value, liste, (u, n) => u.Numero = n);
        }

        public string Nom
        {
            get => liste.Nom;
            set => SetProperty(liste.Nom, value, liste, (u, n) => u.Nom = n);
        }
        public string Abreviation
        {
            get => liste.Abreviation;
            set => SetProperty(liste.Abreviation, value, liste, (u, n) => u.Abreviation = n);
        }
        public List<Candidat> Candidats
        {
            get => liste.Candidats;
            set => SetProperty(liste.Candidats, value, liste, (u, n) => u.Candidats = n);
        }
    }
}

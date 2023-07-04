using ElectionLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GestionElectionUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Commune> Communes = new ObservableCollection<Commune>();
        public MainWindow()
        {
            InitializeComponent();
            InitialiteTestData();
            MainTreeView.ItemsSource = Communes;

        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (MainTreeView.SelectedItem is Election)
            {
                var election = (Election)MainTreeView.SelectedItem;
                var dg = new DataGrid();
                var lst = new List<Liste>(election.Listes);
                dg.ItemsSource = lst;
                ScrollPanel.Content = dg;
            }
            
            //if(CommuneItem.IsSelected)
            //{
            //    Election.IsEnabled = false;
            //    Commune.IsEnabled = true;
            //} else 
            //{
            //    Commune.IsEnabled = false;
            //    Election.IsEnabled = true;
            //}
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        void InitialiteTestData()
        {
            var stimier = new Commune() { Nom = "St-Imier", Elections = new List<Election>()};
            Communes.Add(stimier);
            var ele1 = new Election() { Nom = "Conseil communale 2023", Listes = new List<Liste>()};
            stimier.Elections.Add(ele1);
            var lst1 = new Liste() { Nom = "UDC" };
            var lst2 = new Liste() { Nom = "PLR" };
            var lst3 = new Liste() { Nom = "PS" };
            ele1.Listes.Add(lst1);
            ele1.Listes.Add(lst2);
        }
    }
}

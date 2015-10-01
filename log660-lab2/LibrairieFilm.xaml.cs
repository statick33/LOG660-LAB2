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
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace log660_lab2
{
    /// <summary>
    /// Interaction logic for LibrairieFilm.xaml
    /// </summary>
    public partial class LibrairieFilm : Window
    {
        private int idCurrentPersonne;
        private int idCurrentCriteria = 0;
        public ObservableCollection<Film> filmList = new ObservableCollection<Film>();

        public LibrairieFilm()
        {
            InitializeComponent();
            LoadDataInMemory();
            FillDataGrid();
            LoadCriterias();
        }

        public LibrairieFilm(int idPersonne)
        {
            idCurrentPersonne = idPersonne;
            InitializeComponent();
            LoadDataInMemory();
            FillDataGrid();
        }

        private void LoadDataInMemory()
        {
            filmList.Add(new Film(1, "Terminator", new Pays(1, "USA")));
            filmList.Add(new Film(2, "Les Boys", new Pays(2, "Canada")));
        }

        private void FillDataGrid()
        {
            datagridFilm.ItemsSource = filmList;
        }

        private void LoadCriterias()
        {
            cmbCriteriaType.Items.Add("Titre Film");
            cmbCriteriaType.Items.Add("Année Sortie");
            cmbCriteriaType.Items.Add("Pays Film");
            cmbCriteriaType.Items.Add("Langue Film");
            cmbCriteriaType.Items.Add("Nom Genre Film");
            cmbCriteriaType.Items.Add("Réalisateur Film");
            cmbCriteriaType.Items.Add("Acteur Film");
        }

        private void RemoveCriteria(object sender, RoutedEventArgs e)
        {

        }

        private void datagridFilm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            Film selectedFilm = (Film)dataGrid.SelectedItems[0];
            MessageBox.Show("test");
        }

        private void datagridFilm_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.Header.ToString() == "idFilm")
            {
                e.Column.Visibility = Visibility.Hidden;
            }
            //sender
            if (e.Column.Header.ToString() == "paysFilm")
            {
            }
        }

        private void datagridFilm_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {

        }

        private void btnAddCriteria_Click(object sender, RoutedEventArgs e)
        {
            lstCriteria.Items.Add("Critère : " + cmbCriteriaType.Text + " | valeur : " + txtCriteriaValue.Text);
            idCurrentCriteria++;
        }

        private void btnRemoveCriteria_Click(object sender, RoutedEventArgs e)
        {
            if (lstCriteria.SelectedIndex != -1)
            {
                lstCriteria.Items.RemoveAt(lstCriteria.SelectedIndex);
            }
        }
    }
}

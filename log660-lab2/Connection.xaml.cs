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

namespace log660_lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Connection : Window
    {
        private List<Utilisateur> userList = new List<Utilisateur>();

        private void LoadDataInMemory()
        {
            userList.Add(new Utilisateur(1, "alex", "gilbert"));
        }

        public Connection()
        {
            InitializeComponent();
            LoadDataInMemory();
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            foreach (Utilisateur iteratorUser in userList)
            {
                if (iteratorUser.usernameUtilisateur == txtUsername.Text && iteratorUser.passwordUtilisateur == txtPassword.Text)
                {
                    LibrairieFilm librairieFilm = new LibrairieFilm(iteratorUser.idPersonne);
                    librairieFilm.Show();
                    this.Close();
                }
            }
        }
    }
}

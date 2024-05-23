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

namespace Week_8_list_view_second_try
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        List<ClassesDnd> characterNames = new List<ClassesDnd>() ;
        public MainWindow()
        {
            InitializeComponent();

            characterNames.Add(new ClassesDnd("Will","McDurken",3,26, 14,9));
            characterNames.Add(new ClassesDnd("Rafael", "Ragavan QuickSmith",3,24, 18, 16));
            characterNames.Add(new ClassesDnd("Charles", "Conan" ,3,35,10, 17));
            lvCharacters.ItemsSource = characterNames;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex =lvCharacters.SelectedIndex;

            if(lvCharacters.SelectedIndex != -1)
            {
                //ClassesDnd selectedCharacter = (ClassesDnd)lvCharacters.SelectedValue;

                ClassesDnd selectedCharacter = (ClassesDnd)lvCharacters.SelectedValue as ClassesDnd;

                MessageBox.Show(selectedCharacter.PlayerName);
            }
            else
            {
                MessageBox.Show("Selected a row from the list view");
            }



        }
    }
}
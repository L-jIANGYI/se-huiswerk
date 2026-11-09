using System.Windows;
using System.Windows.Controls;
using week1.Models;

namespace week1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> persons = new List<Person>();
        private Person selectedPerson = null;

        /// <summary>
        /// Init 2 persons
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            AddPerson("Jiangyi", "Liu", 22);
            AddPerson("Random", "Guy", 123);
        }

        /// <summary>
        /// Add person on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPersonClicked(object sender, RoutedEventArgs e)
        {
            int age = Convert.ToInt32(Age.Text);
            Person person = AddPerson(FirstName.Text, LastName.Text, age);

            selectedPerson = person;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAnimalClicked(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        /// <summary>
        /// Show selected person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersonSelected(object sender, SelectionChangedEventArgs e)
        {
            selectedPerson = (Person)ListViewPersons.SelectedItem;
            if (selectedPerson != null) MessageBox.Show(selectedPerson.ToString());
        }

        /// <summary>
        /// Add person helper
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        private Person AddPerson(string firstName, string lastName, int age)
        {
            Person person = new Person(firstName, lastName, age);
            persons.Add(person);

            ListViewPersons.ItemsSource = null;
            ListViewPersons.ItemsSource = persons;

            return person;
        }
    }
}
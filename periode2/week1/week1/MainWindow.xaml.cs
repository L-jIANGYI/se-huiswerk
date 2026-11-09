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

            selectedPerson = AddPerson("Jiangyi", "Liu", 22);
            AddPerson("Random", "Guy", 123);

            selectedPerson.AddPet(new Animal("Asd", "Hond"));
            UpdateAnimalList();
        }

        /// <summary>
        /// Add person on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPersonClicked(object sender, RoutedEventArgs e)
        {
            int age = Convert.ToInt32(Age.Value);
            Person person = AddPerson(FirstName.Text, LastName.Text, age);

            selectedPerson = person;

            FirstName.Text = "";
            LastName.Text = "";
            Age.Value = 18;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAnimalClicked(object sender, RoutedEventArgs e)
        {
            if (selectedPerson == null) MessageBox.Show("Selecteer eerst een person");
            else
            {
                Animal pet = new Animal(PetName.Text, PetType.Text);
                selectedPerson.AddPet(pet);

                UpdateAnimalList();

                PetName.Text = "";
                PetType.Text = "";
            }
        }

        /// <summary>
        /// Show selected person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersonSelected(object sender, SelectionChangedEventArgs e)
        {
            selectedPerson = (Person)ListViewPersons.SelectedItem;
            if (selectedPerson != null) UpdateAnimalList();
        }

        private void AnimalSelected(object sender, SelectionChangedEventArgs e)
        {
            Animal selectedAnimal = (Animal)ListViewPets.SelectedItem;
            MessageBox.Show($"Baasje: {selectedPerson.GetName()}\n{selectedAnimal}");
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

        private void UpdateAnimalList()
        {
            ListViewPets.ItemsSource = null;

            bool havePets = selectedPerson.GetPets().Count != 0;

            if (havePets) ListViewPets.ItemsSource = selectedPerson.GetPets();
            else
                ListViewPets.ItemsSource = new List<string>
                    { $"Nog geen huisdier geregistreerd voor {selectedPerson.GetName()}" };
        }
    }
}
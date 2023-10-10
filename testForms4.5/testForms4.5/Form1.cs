using System;
using System.Windows.Forms;

namespace testForms4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //List<List<string>> listOfPersons = new List<List<string>>();
        //List<string> listPerson = new List<string>();
        //string ShowJson(List<string> json)
        //{
        //    string result = "";
        //    foreach (var item in json)
        //    {
        //        result += item;
        //    }

        //    return result;
        //}
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (nameInput.TextLength == 0 || ageInput.TextLength == 0)
            {
                MessageBox.Show("Merci de remplir tous les champs");
            }
            else
            {
                try
                {
                    var name = this.nameInput.Text.Trim();
                    var nameToCapitalize = char.ToUpper(name[0]) + name.Substring(1);
                    var age = int.Parse(this.ageInput.Text);
                    var person = new Person(nameToCapitalize, age);
                    //string json = JsonConvert.SerializeObject(person);
                    //listPerson.Add(json);
                    //afficher sur la vue
                    labelResult.Text += $"id n°{person.Id} | Nom : {person.Name} Age : {person.Age} \n";
                    //labelResult.Text += ShowJson(listPerson) + "\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Merci de rentrer des données valides : {ex.Message}");
                }
            }
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            nameInput.MaxLength = 10;
        }

        private void ageInput_TextChanged(object sender, EventArgs e)
        {
            ageInput.MaxLength = 3;
        }

    }

    class Person
    {
        static int init = 0;
        readonly public int Id;
        public string Name { get; private set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            init++;
            this.Id = init;
            this.Name = name;
            this.Age = age;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTasks
{
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void AddCountryButton_Click(object sender, EventArgs e)
        {
            NameLabel.Visible = true;
            PopulationLabel.Visible = true;
            CountryPopulationTExtBox.Visible = true;
            CountryNameTextBox.Visible = true;
        }

        private void CountryNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CountryPopulationTExtBox.Text != string.Empty & CountryNameTextBox.Text != string.Empty)
            {
                AddCountryButtonFinally.Visible = true;
            }
            else
            {
                AddCountryButtonFinally.Visible = false;
            }
        }

        private void CountryPopulationTExtBox_TextChanged(object sender, EventArgs e)
        {
            if (CountryPopulationTExtBox.Text != string.Empty&CountryNameTextBox.Text!=string.Empty)
            {
                AddCountryButtonFinally.Visible = true;
            }
            else
            {
                AddCountryButtonFinally.Visible = false;
            }
        }

        private void AddCountryButtonFinally_Click(object sender, EventArgs e)
        {
            CreateCountries(CountryNameTextBox, CountryPopulationTExtBox, InfLabel4, CountriescheckedListBox1);
            NameLabel.Visible = false;
            PopulationLabel.Visible = false;
            CountryPopulationTExtBox.Clear();
            CountryPopulationTExtBox.Visible = false;
            CountryNameTextBox.Clear();
            CountryNameTextBox.Visible = false;
            CalculateAveragePopulationFromTheList(ListOfCountries.Countries, label4, AveragePopulationLabelEveryCountriesFromList, InfLabel4);
        }

        private static void CreateCountries(TextBox Name, TextBox Population, Label inf, CheckedListBox checkedListBox)
        {
            string name = Name.Text;
            int population = 0;
            try
            {
                population = Convert.ToInt32(Population.Text);
                Country country = new Country(name, population);
                ListOfCountries.Countries.Add(country);
                checkedListBox.Items.Add(country);
            }
            catch 
            {
                inf.Text = "Input correct value";
            }
           

        }

        private void CountriescheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < ListOfCountries.Countries.Count; i++)
            {
                if (CountriescheckedListBox1.SelectedItem.Equals(ListOfCountries.Countries[i]) == true)
                    {
                    AveragePopulationLabel.Text = Convert.ToString(ListOfCountries.Countries[i].population);
                    label2.Text = $"Average population of{ListOfCountries.Countries[i].name}";
                    }
            }
            
        }
        private void CalculateAveragePopulationFromTheList(List<Country> list, Label MiniLabel, Label ValueLabel, Label YellowLabel)
        {
            int _population = 0;
            if (list.Count == 0)
            {
                ValueLabel.Text = Convert.ToString(_population);
                YellowLabel.Text = "You have not aded any countries in List\nOr inputed values are not valid";
                MiniLabel.Text = "ZERO";
            }
            else if(list.Count == 1)
            {
                _population = list[0].population;
                ValueLabel.Text = Convert.ToString(_population);
                MiniLabel.Text = $"Average population of {list[0].name}";
                YellowLabel.Text = $"You have aded 1 Country in List";

            }
            else if(list.Count >1)
            {
                _population = 0;
                int counter=0;
                for (int i = 0; i < list.Count; i++)
                {
                    counter = counter + list[i].population;
                    YellowLabel.Text = $"You have aded {i + 1} Countries in List";
                    MiniLabel.Text = $"Average population of {i + 1} Countries";
                }
                _population = counter / list.Count;
                ValueLabel.Text = Convert.ToString(_population);
                //_population = 0;
            }
            
        }

    }
}

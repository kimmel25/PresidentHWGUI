using PopupForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresidentHWGUI
{
    public partial class MainPage : Form
    {
        bool rebelled;
        bool impeached;
        bool naturalCitizen;
        string yearOfBirth;
        string yearsInUnitedStates;
        string priorTermsServed;

        public MainPage()
        {
            InitializeComponent();
        }

        private void haveRebelled_CheckedChanged(object sender, EventArgs e)
        {
            rebelled = !rebelled;
            Debug.WriteLine("the rebelled is: " + rebelled);
        }

        private void haveBeenImpeached_CheckedChanged(object sender, EventArgs e)
        {
            impeached = !impeached;
            Debug.WriteLine("the impeached is: " + impeached);
        }

        private void naturalBornCitizen_CheckedChanged(object sender, EventArgs e)
        {
            naturalCitizen = !naturalCitizen;
            Debug.WriteLine("the natural citizen is: " + naturalCitizen);

        }

        private void birthYear_TextChanged(object sender, EventArgs e)
        {
            yearOfBirth = birthYear.Text;
            Debug.WriteLine(yearOfBirth);
        }

        private void yearsInUS_TextChanged(object sender, EventArgs e)
        {
            yearsInUnitedStates = yearsInUS.Text;
            Debug.WriteLine(yearsInUnitedStates);
        }

        private void priorTerms_TextChanged(object sender, EventArgs e)
        {
            priorTermsServed = priorTerms.Text;
            Debug.WriteLine(priorTermsServed);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (yearOfBirth == null || yearsInUnitedStates == null || priorTermsServed == null)
            {
                NullBoxes nullPopup = new NullBoxes();
                nullPopup.Show();
                return;
            }
            int parsedYearsInUS = int.Parse(yearsInUnitedStates);
            int parsedPriorTerms = int.Parse(priorTermsServed);
            int parsedBirth = int.Parse(yearOfBirth);


            Popup pop = new Popup();
            if (naturalCitizen && !rebelled && !impeached &&
                parsedYearsInUS >= 14 && parsedPriorTerms <= 2 && parsedBirth >= 35)
            {
                pop.Show();
            }
            else
            {
                CanNotBePres popNoPres = new CanNotBePres();
                popNoPres.Show();
            }

        }
    }
}

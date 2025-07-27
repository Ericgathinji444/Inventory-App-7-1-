// Name: Eric Gathinji
// Project: PresentationLayer
// Framework: .NET 8
// Citation: Adapted from CST-150 Activity 7 Guidelines by Grand Canyon University

using BusinessLayer; 
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmDetails : Form
    {
        // Constructor accepts a Pet object to populate the form
        public FrmDetails(Pet pet)
        {
            InitializeComponent();

            // Populate the label fields with pet data
            lblNameValue.Text = pet.Name;
            lblTypeValue.Text = pet.Type;
            lblAgeValue.Text = pet.Age.ToString();
        }

        // Closes the details form and returns to main form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

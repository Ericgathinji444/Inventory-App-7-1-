// 
// CST-150 Activity 7
// Author: Eric Gathinji
// Date:  24 July 2025
// 
using BusinessLayer;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PresentationLayer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event to send pet data to the details form.
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string type = txtType.Text;
                int age = int.Parse(txtAge.Text);

                Pet pet = new Pet(name, type, age);
                FrmDetails detailsForm = new FrmDetails(pet);
                detailsForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid inputs for all fields.");
            }
        }
    }
}

using Clinic.Controller;
using Clinic.Model;
using System;
using System.Windows.Forms;

namespace Clinic.View
{
    public partial class NurseDALEditNurseTestForm : Form
    {
        private readonly NurseController nurseController;

        public NurseDALEditNurseTestForm()
        {
            InitializeComponent();
            this.nurseController = new NurseController();
        }

        private void TestButton_Click(object sender, System.EventArgs e)
        {
            Nurse originalNurse = new Nurse
            {
                PersonId = 13,
                NurseId = 3,
                IsActive = true,
                LastName = "Bob",
                FirstName = "Builder",
                DateOfBirth = new DateTime(1970, 6, 1),
                SocialSecurityNumber = "485-97-4902",
                Gender = "M",
                PhoneNumber = "(555) 555-3333",
                AddressLine1 = "5 E. The St.",
                City = "Bison",
                State = "WY",
                ZipCode = "33333"
            };

            Nurse revisedNurse = new Nurse
            {
                PersonId = 13,
                NurseId = 3,
                IsActive = false,
                LastName = "Bob",
                FirstName = "Builder",
                DateOfBirth = new DateTime(1970, 6, 1),
                SocialSecurityNumber = "485-97-4902",
                Gender = "M",
                PhoneNumber = "(555) 555-3333",
                AddressLine1 = "5 E. The St.",
                City = "Bison",
                State = "WY",
                ZipCode = "33333"
            };

            bool result = this.nurseController.EditNurse(originalNurse, revisedNurse);
            MessageBox.Show(result.ToString());
        }
    }
}
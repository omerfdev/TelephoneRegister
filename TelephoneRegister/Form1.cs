using TelephoneRegister.Models;

namespace TelephoneRegister
{
    public partial class Form1 : Form
    {
        KisiRehberiDBContext db;
        public Form1()
        {
            InitializeComponent();
            db = new KisiRehberiDBContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGVFill();
            btnAdd.Click += Click;
            btnUpdate.Click += Click;
            btnDelete.Click += Click;
        }
        private void Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            object tag = btn.Tag;

            switch (tag)
            {
                case "1":

                    AddProcess();
                    txtBoxID.Enabled = true;
                    break;

                case "2":

                    UpdateProcess();
                    txtBoxID.Enabled = true;
                    break;

                case "3":

                    DeleteProcess();
                    txtBoxID.Enabled = true;
                    break;
            }

            DGVFill();
        }

        private void DGVFill()
        {
            var result = db.Contacts.ToList();
            dgvTelephoneList.DataSource = result;
            txtBoxID.Enabled = false;
            TextBoxClear();
        }
        private void TextBoxClear()
        {
            txtBoxID.Text = string.Empty;
            txtBoxFirstName.Text = string.Empty;
            txtBoxLastName.Text = string.Empty;
            msktxtBoxTelephone.Text = string.Empty;
        }


        private void DeleteProcess()
        {
            int ContactID = int.Parse(txtBoxID.Text);
            string FirstName = txtBoxFirstName.Text.Trim();
            string LastName = txtBoxFirstName.Text.Trim();
            string PhoneNumber = msktxtBoxTelephone.Text.Trim();

            try
            {
                Contact contact = db.Contacts.Find(ContactID);
                db.Contacts.Remove(contact);
                db.SaveChanges();
                MessageBox.Show(db.Entry<Contact>(contact).State.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("You have to select a Row to delete");
            }
        }

        private void AddProcess()
        {
            string FirstName = txtBoxFirstName.Text.Trim();
            string LastName = txtBoxLastName.Text.Trim();
            string PhoneNumber = msktxtBoxTelephone.Text.Trim();
            try
            {
                if (FirstName != null && LastName != null && PhoneNumber != null)
                {
                    txtBoxID.Enabled = false;
                    Contact contact = new Contact()
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        PhoneNumber = PhoneNumber,

                    };
                    db.Contacts.Add(contact);
                    db.SaveChanges();
                    MessageBox.Show(db.Entry<Contact>(contact).State.ToString());
                }


            }
            catch (Exception)
            {

                MessageBox.Show("You Should Fill TextBox");
            }

        }

        private void UpdateProcess()
        {
            int ContactID = int.Parse(txtBoxID.Text);
            string FirstName = txtBoxFirstName.Text.Trim();
            string LastName = txtBoxFirstName.Text.Trim();
            string PhoneNumber = msktxtBoxTelephone.Text.Trim();
            Contact contact = db.Contacts.Find(ContactID);

            if (contact != null)

            {
                if (!string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(PhoneNumber))
                {
                    contact.FirstName = FirstName;
                    contact.LastName = LastName;
                    contact.PhoneNumber = PhoneNumber;
                }
                db.SaveChanges();
                MessageBox.Show(db.Entry<Contact>(contact).State.ToString());
            }
        }



        private void dgvTelephoneList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (dgvTelephoneList.SelectedRows.Count > 1)
            {
                MessageBox.Show("You can not select more than one rows");
                dgvTelephoneList.ClearSelection();
            }

            else if (dgvTelephoneList.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvTelephoneList.Rows[rowIndex];
                txtBoxID.Text = selectedRow.Cells["ContactId"].Value.ToString();
                txtBoxFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtBoxLastName.Text = selectedRow.Cells["LastName"].Value.ToString().Trim();
                msktxtBoxTelephone.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                txtBoxID.Enabled = false;
                MessageBox.Show($" ID: {txtBoxID.Text} has been selected");

            }
        }
    }
}
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using EventPlanner.Models;
using System.Drawing;


namespace EventPlanner
{
    public partial class GuestForm : Form
    {
        EventContext context = new EventContext();
        Guest selectedGuest = null;

        public GuestForm()
        {
            InitializeComponent();
            dgvGuests.SelectionChanged += dgvGuests_SelectionChanged;
            this.BackColor = Color.Black;
            // Set Form background
            this.BackColor = Color.Black;

            // Loop through all controls and style them
            foreach (Control ctrl in this.Controls)
            {
                // Label text color
                if (ctrl is Label)
                {
                    ctrl.ForeColor = Color.WhiteSmoke;
                }

                // Buttons styling
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.DimGray;
                    btn.ForeColor = Color.WhiteSmoke;
                    btn.FlatStyle = FlatStyle.Flat;
                }


                // TextBoxes styling
                if (ctrl is TextBox)
                {
                    ctrl.BackColor = Color.White;
                    ctrl.ForeColor = Color.Black;
                    ((TextBox)ctrl).BorderStyle = BorderStyle.FixedSingle;
                }

                // ComboBoxes styling
                if (ctrl is ComboBox)
                {
                    ctrl.BackColor = Color.DimGray;
                    ctrl.ForeColor = Color.WhiteSmoke;
                }

                // DataGridView styling
                if (ctrl is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.DimGray;
                    dgv.ForeColor = Color.Black;
                    dgv.GridColor = Color.Gray;

                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                    dgv.RowHeadersDefaultCellStyle.BackColor = Color.White;
                    dgv.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

                    dgv.EnableHeadersVisualStyles = false;
                }
            }


        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            LoadGuests();
        }

        private void LoadGuests()
        {
            dgvGuests.AutoGenerateColumns = true;
            dgvGuests.DataSource = context.Guests.ToList();
        }

        private void ClearInputs()
        {
            Name_Input.Clear();
            Email_Input.Clear();
            Phone_Input.Clear();
            selectedGuest = null;
        }

        private void Guest_Add_Click(object sender, EventArgs e)
        {
            var newGuest = new Guest
            {
                Name = Name_Input.Text,
                Email = Email_Input.Text,
                Phone = Phone_Input.Text
            };

            context.Guests.Add(newGuest);
            context.SaveChanges();
            LoadGuests();
            ClearInputs();
        }

        private void dgvGuests_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGuests.SelectedRows.Count > 0 && dgvGuests.CurrentRow != null)
            {
                var selectedRow = dgvGuests.CurrentRow;
                var guest = selectedRow.DataBoundItem as Guest;

                if (guest != null)
                {
                    selectedGuest = context.Guests.FirstOrDefault(g => g.Id == guest.Id);

                    if (selectedGuest != null)
                    {
                        Name_Input.Text = selectedGuest.Name;
                        Email_Input.Text = selectedGuest.Email;
                        Phone_Input.Text = selectedGuest.Phone;

                        Console.WriteLine("Selected guest: " + selectedGuest.Name); // للتأكيد
                    }
                }
            }
        }


        private void Guest_Edit_Click(object sender, EventArgs e)
        {
            if (selectedGuest == null)
            {
                MessageBox.Show("Please select a guest to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update values from input
            selectedGuest.Name = Name_Input.Text;
            selectedGuest.Email = Email_Input.Text;
            selectedGuest.Phone = Phone_Input.Text;

            context.SaveChanges();
            LoadGuests();
            ClearInputs();

            MessageBox.Show("Guest updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Guest_Delete_Click(object sender, EventArgs e)
        {
            if (selectedGuest != null)
            {
                context.Guests.Remove(selectedGuest);
                context.SaveChanges();
                LoadGuests();
                ClearInputs();
            }
        }

       
    }
}

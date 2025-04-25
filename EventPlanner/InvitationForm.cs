using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using EventPlanner.Models;

namespace EventPlanner
{
    public partial class InvitationForm : Form
    {
        EventContext context = new EventContext();

        public InvitationForm()
        {
            InitializeComponent();
        }

        private void InvitationForm_Load(object sender, EventArgs e)
        {
            LoadGuests();
            LoadEvents();
            LoadRSVPStatuses();
            LoadInvitations();
        }

        private void LoadGuests()
        {
            comboBox1.DataSource = context.Guests.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = -1;
        }

        private void LoadEvents()
        {
            comboBox2.DataSource = context.Events.ToList();
            comboBox2.DisplayMember = "Title";
            comboBox2.ValueMember = "Id";
            comboBox2.SelectedIndex = -1;
        }

        private void LoadRSVPStatuses()
        {
            comboBox3.DataSource = Enum.GetValues(typeof(RSVPStatus));
            comboBox3.SelectedIndex = -1;
        }

        private void LoadInvitations()
        {
            dgvInvitations.DataSource = context.Invitations
                .Select(i => new
                {
                    i.Id,
                    GuestName = i.Guest.Name,
                    EventTitle = i.Event.Title,
                    i.RSVPStatus,
                    i.Note
                })
                .ToList();
            //  Styling after setting the DataSource
            dgvInvitations.DefaultCellStyle.ForeColor = Color.Black;
            dgvInvitations.DefaultCellStyle.BackColor = Color.White;
            dgvInvitations.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgvInvitations.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvInvitations.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvInvitations.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgvInvitations.EnableHeadersVisualStyles = false;
        }

        private void ClearInputs()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            Note_Input.Clear();
        }

        private void add_invit_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Please select guest, event and RSVP status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newInvitation = new Invitation
            {
                GuestId = (int)comboBox1.SelectedValue,
                EventId = (int)comboBox2.SelectedValue,
                RSVPStatus = (RSVPStatus)Enum.Parse(typeof(RSVPStatus), comboBox3.SelectedItem.ToString()),
                Note = Note_Input.Text
            };

            context.Invitations.Add(newInvitation);
            context.SaveChanges();
            LoadInvitations();
            ClearInputs();

            MessageBox.Show("Invitation added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void delete_invit_Click(object sender, EventArgs e)
        {
            if (dgvInvitations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an invitation to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvInvitations.SelectedRows[0];
            int invitationId = (int)selectedRow.Cells["Id"].Value;

            var invitationToDelete = context.Invitations.Find(invitationId);

            if (invitationToDelete != null)
            {
                context.Invitations.Remove(invitationToDelete);
                context.SaveChanges();
                LoadInvitations();
                ClearInputs();

                MessageBox.Show("Invitation deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using EventPlanner.Models;

namespace EventPlanner
{
    public partial class SearchForm : Form
    {
        EventContext context = new EventContext();

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            
            cmbSearchType.Items.AddRange(new string[] { "Guests", "Events", "Invitations" });
            cmbSearchType.SelectedIndex = 0;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedType = cmbSearchType.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Please enter a search keyword.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedType == "Guests")
            {
                var results = context.Guests
                    .Where(g => g.Name.ToLower().Contains(keyword) || g.Email.ToLower().Contains(keyword))
                    .Select(g => new { g.Id, g.Name, g.Email, g.Phone })
                    .ToList();
                dgvResults.DataSource = results;
                StyleDataGridView(dgvResults);

            }
            else if (selectedType == "Events")
            {
                var results = context.Events
                    .Where(ev => ev.Title.ToLower().Contains(keyword) || ev.Description.ToLower().Contains(keyword))
                    .Select(ev => new { ev.Id, ev.Title, ev.Date, ev.Description })
                    .ToList();
                dgvResults.DataSource = results;
                StyleDataGridView(dgvResults);

            }
            else if (selectedType == "Invitations")
            {
                var results = context.Invitations
                    .Where(i => i.Guest.Name.ToLower().Contains(keyword) || i.Event.Title.ToLower().Contains(keyword))
                    .Select(i => new
                    {
                        i.Id,
                        GuestName = i.Guest.Name,
                        EventTitle = i.Event.Title,
                        i.RSVPStatus,
                        i.Note
                    })
                    .ToList();
                dgvResults.DataSource = results;
                StyleDataGridView(dgvResults);

            }
        }
        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.DimGray;
            dgv.DefaultCellStyle.BackColor = Color.DimGray;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Gray;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.GridColor = Color.Gray;
            dgv.EnableHeadersVisualStyles = false;
        }

    }
}

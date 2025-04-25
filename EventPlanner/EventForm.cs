using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventPlanner.Models; 

namespace EventPlanner
{
    public partial class EventForm : Form
    {
        EventContext context = new EventContext();
        Event selectedEvent = null;

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void LoadEvents()
        {
            dgvEvents.DataSource = context.Events.ToList();
            dgvEvents.DefaultCellStyle.ForeColor = Color.Black;
            dgvEvents.DefaultCellStyle.BackColor = Color.White;
            dgvEvents.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvEvents.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvEvents.EnableHeadersVisualStyles = false;

        }

        private void ClearInputs()
        {
            TitleInput.Clear();
            LocationInput.Clear();
            DescriptionInput.Clear();
            dateInput.Value = DateTime.Now;
            selectedEvent = null;
        }

        private void add_event_Click(object sender, EventArgs e)
        {
            var newEvent = new Event
            {
                Title = TitleInput.Text,
                Date = dateInput.Value,
                Location = LocationInput.Text,
                Description = DescriptionInput.Text
            };

            context.Events.Add(newEvent);
            context.SaveChanges();
            LoadEvents();
            ClearInputs();
        }

        private void dgvEvents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEvents.SelectedRows.Count > 0)
            {
                var row = dgvEvents.SelectedRows[0];
                var evt = row.DataBoundItem as Event;

                if (evt != null)
                {
                    selectedEvent = context.Events.Find(evt.Id);

                    TitleInput.Text = selectedEvent.Title;
                    dateInput.Value = selectedEvent.Date;
                    LocationInput.Text = selectedEvent.Location;
                    DescriptionInput.Text = selectedEvent.Description;
                }
            }
        }


        private void edit_event_Click(object sender, EventArgs e)
        {
            if (dgvEvents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an event to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var selectedRow = dgvEvents.SelectedRows[0];
            var evt = selectedRow.DataBoundItem as Event;

            if (evt == null)
            {
                MessageBox.Show("Could not get event from selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var eventToUpdate = context.Events.FirstOrDefault(e => e.Id == evt.Id);

            if (eventToUpdate != null)
            {
                eventToUpdate.Title = TitleInput.Text;
                eventToUpdate.Date = dateInput.Value;
                eventToUpdate.Location = LocationInput.Text;
                eventToUpdate.Description = DescriptionInput.Text;

                context.SaveChanges();

                LoadEvents();
                ClearInputs();

                MessageBox.Show("Event updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Event not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_event_Click(object sender, EventArgs e)
        {
            if (selectedEvent != null)
            {
                context.Events.Remove(selectedEvent);
                context.SaveChanges();
                LoadEvents();
                ClearInputs();
            }
        }

        
    }
}

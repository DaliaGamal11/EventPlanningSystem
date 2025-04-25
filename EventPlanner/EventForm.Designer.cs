namespace EventPlanner
{
    partial class EventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvEvents = new DataGridView();
            add_event = new Button();
            edit_event = new Button();
            delete_event = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateInput = new DateTimePicker();
            TitleInput = new TextBox();
            LocationInput = new TextBox();
            DescriptionInput = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEvents).BeginInit();
            SuspendLayout();
            // 
            // dgvEvents
            // 
            dgvEvents.BackgroundColor = Color.Gray;
            dgvEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvEvents.DefaultCellStyle = dataGridViewCellStyle1;
            dgvEvents.Location = new Point(12, 254);
            dgvEvents.Name = "dgvEvents";
            dgvEvents.RowHeadersWidth = 51;
            dgvEvents.Size = new Size(776, 188);
            dgvEvents.TabIndex = 0;
            dgvEvents.SelectionChanged += dgvEvents_SelectionChanged;
            // 
            // add_event
            // 
            add_event.BackColor = Color.DimGray;
            add_event.Location = new Point(540, 51);
            add_event.Name = "add_event";
            add_event.Size = new Size(132, 57);
            add_event.TabIndex = 1;
            add_event.Text = "ADD";
            add_event.UseVisualStyleBackColor = false;
            add_event.Click += add_event_Click;
            // 
            // edit_event
            // 
            edit_event.BackColor = Color.DimGray;
            edit_event.Location = new Point(540, 114);
            edit_event.Name = "edit_event";
            edit_event.Size = new Size(132, 62);
            edit_event.TabIndex = 2;
            edit_event.Text = "Edit";
            edit_event.UseVisualStyleBackColor = false;
            edit_event.Click += edit_event_Click;
            // 
            // delete_event
            // 
            delete_event.BackColor = Color.DimGray;
            delete_event.Location = new Point(540, 182);
            delete_event.Name = "delete_event";
            delete_event.Size = new Size(132, 66);
            delete_event.TabIndex = 3;
            delete_event.Text = "Delete";
            delete_event.UseVisualStyleBackColor = false;
            delete_event.Click += delete_event_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 52);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 102);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 5;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 161);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 6;
            label3.Text = "Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 213);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 7;
            label4.Text = "Description";
            // 
            // dateInput
            // 
            dateInput.Location = new Point(169, 102);
            dateInput.Name = "dateInput";
            dateInput.Size = new Size(250, 27);
            dateInput.TabIndex = 8;
            // 
            // TitleInput
            // 
            TitleInput.Location = new Point(169, 52);
            TitleInput.Name = "TitleInput";
            TitleInput.Size = new Size(250, 27);
            TitleInput.TabIndex = 9;
            // 
            // LocationInput
            // 
            LocationInput.Location = new Point(169, 158);
            LocationInput.Name = "LocationInput";
            LocationInput.Size = new Size(250, 27);
            LocationInput.TabIndex = 10;
            // 
            // DescriptionInput
            // 
            DescriptionInput.Location = new Point(169, 213);
            DescriptionInput.Name = "DescriptionInput";
            DescriptionInput.Size = new Size(250, 27);
            DescriptionInput.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(314, 9);
            label5.Name = "label5";
            label5.Size = new Size(188, 38);
            label5.TabIndex = 12;
            label5.Text = "Event Details";
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(DescriptionInput);
            Controls.Add(LocationInput);
            Controls.Add(TitleInput);
            Controls.Add(dateInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(delete_event);
            Controls.Add(edit_event);
            Controls.Add(add_event);
            Controls.Add(dgvEvents);
            ForeColor = Color.WhiteSmoke;
            Name = "EventForm";
            Text = "EventForm";
            Load += EventForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEvents;
        private Button add_event;
        private Button edit_event;
        private Button delete_event;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateInput;
        private TextBox TitleInput;
        private TextBox LocationInput;
        private TextBox DescriptionInput;
        private Label label5;
    }
}
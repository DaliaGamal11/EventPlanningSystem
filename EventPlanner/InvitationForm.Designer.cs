namespace EventPlanner
{
    partial class InvitationForm
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dgvInvitations = new DataGridView();
            comboBox3 = new ComboBox();
            label3 = new Label();
            add_invit = new Button();
            delete_invit = new Button();
            label4 = new Label();
            Note_Input = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInvitations).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 70);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Guest";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 122);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Event";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(224, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(224, 122);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            // 
            // dgvInvitations
            // 
            dgvInvitations.BackgroundColor = Color.DimGray;
            dgvInvitations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvInvitations.DefaultCellStyle = dataGridViewCellStyle1;
            dgvInvitations.Location = new Point(454, 66);
            dgvInvitations.Name = "dgvInvitations";
            dgvInvitations.RowHeadersWidth = 51;
            dgvInvitations.Size = new Size(300, 188);
            dgvInvitations.TabIndex = 4;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(224, 185);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 185);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Status";
            // 
            // add_invit
            // 
            add_invit.BackColor = Color.DimGray;
            add_invit.Location = new Point(271, 332);
            add_invit.Name = "add_invit";
            add_invit.Size = new Size(94, 29);
            add_invit.TabIndex = 7;
            add_invit.Text = "Add";
            add_invit.UseVisualStyleBackColor = false;
            add_invit.Click += add_invit_Click;
            // 
            // delete_invit
            // 
            delete_invit.BackColor = Color.DimGray;
            delete_invit.Location = new Point(454, 332);
            delete_invit.Name = "delete_invit";
            delete_invit.Size = new Size(94, 29);
            delete_invit.TabIndex = 8;
            delete_invit.Text = "Delete";
            delete_invit.UseVisualStyleBackColor = false;
            delete_invit.Click += delete_invit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 236);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 9;
            label4.Text = "Note";
            // 
            // Note_Input
            // 
            Note_Input.Location = new Point(224, 236);
            Note_Input.Name = "Note_Input";
            Note_Input.Size = new Size(151, 27);
            Note_Input.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(271, 9);
            label5.Name = "label5";
            label5.Size = new Size(243, 38);
            label5.TabIndex = 11;
            label5.Text = "Invitation Details";
            // 
            // InvitationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(Note_Input);
            Controls.Add(label4);
            Controls.Add(delete_invit);
            Controls.Add(add_invit);
            Controls.Add(comboBox3);
            Controls.Add(label3);
            Controls.Add(dgvInvitations);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.WhiteSmoke;
            Name = "InvitationForm";
            Text = "InvitationForm";
            Load += InvitationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvitations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridView dgvInvitations;
        private ComboBox comboBox3;
        private Label label3;
        private Button add_invit;
        private Button delete_invit;
        private Label label4;
        private TextBox Note_Input;
        private Label label5;
    }
}
namespace EventPlanner
{
    partial class GuestForm
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
            dgvGuests = new DataGridView();
            Guest_Add = new Button();
            Guest_Edit = new Button();
            Guest_Delete = new Button();
            label1 = new Label();
            label2 = new Label();
            Name_Input = new TextBox();
            Email_Input = new TextBox();
            label3 = new Label();
            Phone_Input = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGuests).BeginInit();
            SuspendLayout();
            // 
            // dgvGuests
            // 
            dgvGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuests.Location = new Point(461, 52);
            dgvGuests.Name = "dgvGuests";
            dgvGuests.RowHeadersWidth = 51;
            dgvGuests.Size = new Size(300, 188);
            dgvGuests.TabIndex = 0;
            // 
            // Guest_Add
            // 
            Guest_Add.Location = new Point(111, 309);
            Guest_Add.Name = "Guest_Add";
            Guest_Add.Size = new Size(94, 49);
            Guest_Add.TabIndex = 1;
            Guest_Add.Text = "ADD";
            Guest_Add.UseVisualStyleBackColor = true;
            Guest_Add.Click += Guest_Add_Click;
            // 
            // Guest_Edit
            // 
            Guest_Edit.Location = new Point(323, 309);
            Guest_Edit.Name = "Guest_Edit";
            Guest_Edit.Size = new Size(101, 49);
            Guest_Edit.TabIndex = 2;
            Guest_Edit.Text = "Edit";
            Guest_Edit.UseVisualStyleBackColor = true;
            Guest_Edit.Click += Guest_Edit_Click;
            // 
            // Guest_Delete
            // 
            Guest_Delete.Location = new Point(558, 309);
            Guest_Delete.Name = "Guest_Delete";
            Guest_Delete.Size = new Size(94, 49);
            Guest_Delete.TabIndex = 3;
            Guest_Delete.Text = "Delete";
            Guest_Delete.UseVisualStyleBackColor = true;
            Guest_Delete.Click += Guest_Delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 80);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 137);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // Name_Input
            // 
            Name_Input.Location = new Point(195, 73);
            Name_Input.Name = "Name_Input";
            Name_Input.Size = new Size(168, 27);
            Name_Input.TabIndex = 6;
            // 
            // Email_Input
            // 
            Email_Input.Location = new Point(195, 130);
            Email_Input.Name = "Email_Input";
            Email_Input.Size = new Size(168, 27);
            Email_Input.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 24);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 8;
            label3.Text = "Guest Details";
           
            // 
            // Phone_Input
            // 
            Phone_Input.Location = new Point(195, 184);
            Phone_Input.Name = "Phone_Input";
            Phone_Input.Size = new Size(168, 27);
            Phone_Input.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 200);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 10;
            label4.Text = "phone";
            // 
            // GuestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Phone_Input);
            Controls.Add(label3);
            Controls.Add(Email_Input);
            Controls.Add(Name_Input);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Guest_Delete);
            Controls.Add(Guest_Edit);
            Controls.Add(Guest_Add);
            Controls.Add(dgvGuests);
            Name = "GuestForm";
            Text = "GuestForm";
            Load += GuestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGuests;
        private Button Guest_Add;
        private Button Guest_Edit;
        private Button Guest_Delete;
        private Label label1;
        private Label label2;
        private TextBox Name_Input;
        private TextBox Email_Input;
        private Label label3;
        private TextBox Phone_Input;
        private Label label4;
    }
}
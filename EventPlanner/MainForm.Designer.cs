namespace EventPlanner
{
    partial class MainForm
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Search_bt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(203, 27);
            label1.Name = "label1";
            label1.Size = new Size(363, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Event Planner";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(272, 88);
            button1.Name = "button1";
            button1.Size = new Size(218, 49);
            button1.TabIndex = 1;
            button1.Text = "Manage Guests";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(272, 156);
            button2.Name = "button2";
            button2.Size = new Size(218, 44);
            button2.TabIndex = 2;
            button2.Text = "Manage Events";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(272, 224);
            button3.Name = "button3";
            button3.Size = new Size(218, 46);
            button3.TabIndex = 3;
            button3.Text = "Manage Invitations";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(272, 367);
            button4.Name = "button4";
            button4.Size = new Size(218, 42);
            button4.TabIndex = 4;
            button4.Text = "About";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Search_bt
            // 
            Search_bt.BackColor = Color.DimGray;
            Search_bt.FlatStyle = FlatStyle.Flat;
            Search_bt.Location = new Point(272, 299);
            Search_bt.Name = "Search_bt";
            Search_bt.Size = new Size(218, 42);
            Search_bt.TabIndex = 5;
            Search_bt.Text = "Search";
            Search_bt.UseVisualStyleBackColor = false;
            Search_bt.Click += Search_bt_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(Search_bt);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button Search_bt;
    }
}
namespace CA_W5_ANGEL_L
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button_delete = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_team1 = new System.Windows.Forms.ComboBox();
            this.comboBox_team2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_score1 = new System.Windows.Forms.TextBox();
            this.textBox_score2 = new System.Windows.Forms.TextBox();
            this.button_addmatch = new System.Windows.Forms.Button();
            this.button_addteam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(950, 277);
            this.dataGridView.TabIndex = 0;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(24, 308);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(107, 48);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(311, 317);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(305, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBox_team1
            // 
            this.comboBox_team1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_team1.FormattingEnabled = true;
            this.comboBox_team1.Location = new System.Drawing.Point(311, 358);
            this.comboBox_team1.Name = "comboBox_team1";
            this.comboBox_team1.Size = new System.Drawing.Size(121, 28);
            this.comboBox_team1.TabIndex = 3;
            this.comboBox_team1.SelectedIndexChanged += new System.EventHandler(this.comboBox_team1_SelectedIndexChanged);
            // 
            // comboBox_team2
            // 
            this.comboBox_team2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_team2.FormattingEnabled = true;
            this.comboBox_team2.Items.AddRange(new object[] {
            ""});
            this.comboBox_team2.Location = new System.Drawing.Point(483, 358);
            this.comboBox_team2.Name = "comboBox_team2";
            this.comboBox_team2.Size = new System.Drawing.Size(133, 28);
            this.comboBox_team2.TabIndex = 4;
            this.comboBox_team2.SelectedIndexChanged += new System.EventHandler(this.comboBox_team2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "VS";
            // 
            // textBox_score1
            // 
            this.textBox_score1.Location = new System.Drawing.Point(311, 402);
            this.textBox_score1.MaxLength = 3;
            this.textBox_score1.Name = "textBox_score1";
            this.textBox_score1.Size = new System.Drawing.Size(121, 26);
            this.textBox_score1.TabIndex = 6;
            this.textBox_score1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_score1_KeyPress);
            // 
            // textBox_score2
            // 
            this.textBox_score2.Location = new System.Drawing.Point(483, 402);
            this.textBox_score2.MaxLength = 3;
            this.textBox_score2.Name = "textBox_score2";
            this.textBox_score2.Size = new System.Drawing.Size(133, 26);
            this.textBox_score2.TabIndex = 7;
            this.textBox_score2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_score2_KeyPress);
            // 
            // button_addmatch
            // 
            this.button_addmatch.Location = new System.Drawing.Point(319, 461);
            this.button_addmatch.Name = "button_addmatch";
            this.button_addmatch.Size = new System.Drawing.Size(113, 38);
            this.button_addmatch.TabIndex = 8;
            this.button_addmatch.Text = "Add Match";
            this.button_addmatch.UseVisualStyleBackColor = true;
            this.button_addmatch.Click += new System.EventHandler(this.button_addmatch_Click);
            // 
            // button_addteam
            // 
            this.button_addteam.Location = new System.Drawing.Point(494, 461);
            this.button_addteam.Name = "button_addteam";
            this.button_addteam.Size = new System.Drawing.Size(113, 38);
            this.button_addteam.TabIndex = 9;
            this.button_addteam.Text = "Add Team";
            this.button_addteam.UseVisualStyleBackColor = true;
            this.button_addteam.Click += new System.EventHandler(this.button_addteam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 520);
            this.Controls.Add(this.button_addteam);
            this.Controls.Add(this.button_addmatch);
            this.Controls.Add(this.textBox_score2);
            this.Controls.Add(this.textBox_score1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_team2);
            this.Controls.Add(this.comboBox_team1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_score1;
        private System.Windows.Forms.TextBox textBox_score2;
        private System.Windows.Forms.Button button_addmatch;
        private System.Windows.Forms.Button button_addteam;
        public System.Windows.Forms.ComboBox comboBox_team1;
        public System.Windows.Forms.ComboBox comboBox_team2;
    }
}


namespace librarymanagement
{
    partial class Members
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 94);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(496, 23);
            label1.Name = "label1";
            label1.Size = new Size(195, 47);
            label1.TabIndex = 0;
            label1.Text = "MEMBERS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 356);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.LightCyan;
            button5.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(272, 9);
            button5.Name = "button5";
            button5.Size = new Size(82, 30);
            button5.TabIndex = 11;
            button5.Text = "Display";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightCyan;
            button4.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold);
            button4.Location = new Point(85, 265);
            button4.Name = "button4";
            button4.Size = new Size(70, 44);
            button4.TabIndex = 10;
            button4.Text = "ADD";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCyan;
            button3.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold);
            button3.Location = new Point(198, 265);
            button3.Name = "button3";
            button3.Size = new Size(70, 44);
            button3.TabIndex = 9;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCyan;
            button2.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold);
            button2.Location = new Point(198, 196);
            button2.Name = "button2";
            button2.Size = new Size(70, 44);
            button2.TabIndex = 8;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.Font = new Font("MS Gothic", 11.25F, FontStyle.Bold);
            button1.Location = new Point(85, 196);
            button1.Name = "button1";
            button1.Size = new Size(70, 44);
            button1.TabIndex = 7;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Gothic", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(44, 95);
            label5.Name = "label5";
            label5.Size = new Size(75, 19);
            label5.TabIndex = 3;
            label5.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Gothic", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(33, 132);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 2;
            label4.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Gothic", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(66, 58);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 0;
            label2.Text = "ID :";
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(360, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(440, 356);
            dataGridView1.TabIndex = 2;
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Members";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Members";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button button5;
        private DataGridView dataGridView1;
    }
}
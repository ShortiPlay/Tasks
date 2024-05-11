namespace Tasks
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label14 = new Label();
            richTextBox1 = new RichTextBox();
            panel2 = new Panel();
            label13 = new Label();
            button5 = new Button();
            label12 = new Label();
            textBoxTime = new TextBox();
            textBoxName = new TextBox();
            label11 = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label10 = new Label();
            comboBox6 = new ComboBox();
            label9 = new Label();
            comboBox5 = new ComboBox();
            listView1 = new ListView();
            titel = new ColumnHeader();
            type = new ColumnHeader();
            status = new ColumnHeader();
            term = new ColumnHeader();
            urgency = new ColumnHeader();
            tabPage2 = new TabPage();
            comboBox4 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            listView2 = new ListView();
            employee = new ColumnHeader();
            missia = new ColumnHeader();
            post = new ColumnHeader();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.Location = new Point(-6, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1134, 570);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Azure;
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(comboBox6);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(comboBox5);
            tabPage1.Controls.Add(listView1);
            tabPage1.ForeColor = Color.FromArgb(0, 0, 64);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1126, 538);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Задачи";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label14.Location = new Point(936, 225);
            label14.Name = "label14";
            label14.Size = new Size(88, 23);
            label14.TabIndex = 25;
            label14.Text = "Заметки";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(831, 261);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(289, 270);
            richTextBox1.TabIndex = 24;
            richTextBox1.Text = "";
            // 
            // panel2
            // 
            panel2.Controls.Add(label13);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(textBoxTime);
            panel2.Controls.Add(textBoxName);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(513, 254);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 277);
            panel2.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(101, 5);
            label13.Name = "label13";
            label13.Size = new Size(100, 23);
            label13.TabIndex = 29;
            label13.Text = "Изменить";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(134, 207, 250);
            button5.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.Location = new Point(90, 207);
            button5.Name = "button5";
            button5.Size = new Size(105, 49);
            button5.TabIndex = 28;
            button5.Text = "Изменить";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.Location = new Point(72, 113);
            label12.Name = "label12";
            label12.Size = new Size(162, 22);
            label12.TabIndex = 26;
            label12.Text = "Срок выполнения";
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(45, 137);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(200, 27);
            textBoxTime.TabIndex = 27;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(45, 73);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 27);
            textBoxName.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(109, 50);
            label11.Name = "label11";
            label11.Size = new Size(90, 22);
            label11.TabIndex = 24;
            label11.Text = "Название";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(14, 254);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 277);
            panel1.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Lavender;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Важныве и долгосрочные", "Текукщие важные", "Повседневные", "Ситуатывные" });
            comboBox1.Location = new Point(4, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 27);
            comboBox1.TabIndex = 8;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Не важные и срочные", "Важные и срочные", "Не срочные и не важные", "Важные но не срочные" });
            comboBox3.Location = new Point(112, 167);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(192, 27);
            comboBox3.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(134, 207, 250);
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(282, 225);
            button1.Name = "button1";
            button1.Size = new Size(105, 49);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(244, 7);
            label4.Name = "label4";
            label4.Size = new Size(162, 22);
            label4.TabIndex = 13;
            label4.Text = "Срок выполнения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(128, 142);
            label5.Name = "label5";
            label5.Size = new Size(161, 22);
            label5.TabIndex = 14;
            label5.Text = "Срочность задачи";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(134, 207, 250);
            button2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(59, 225);
            button2.Name = "button2";
            button2.Size = new Size(105, 49);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(259, 76);
            label3.Name = "label3";
            label3.Size = new Size(128, 22);
            label3.TabIndex = 11;
            label3.Text = "Статус задачи";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(4, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(59, 5);
            label1.Name = "label1";
            label1.Size = new Size(90, 22);
            label1.TabIndex = 7;
            label1.Text = "Название";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "В процессе выполнения", "Выполнена", "Отменена", "Запланирована" });
            comboBox2.Location = new Point(228, 99);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(192, 27);
            comboBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 27);
            textBox1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(53, 73);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 9;
            label2.Text = "Тип задачи";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(844, 78);
            label10.Name = "label10";
            label10.Size = new Size(279, 23);
            label10.TabIndex = 21;
            label10.Text = "Сортировка по статусу задачи";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "В процессе выполнения", "Выполнена", "Отменена", "Запланирована" });
            comboBox6.Location = new Point(870, 104);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(227, 27);
            comboBox6.TabIndex = 20;
            // 
            // label9
            // 
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(844, 6);
            label9.Name = "label9";
            label9.Size = new Size(234, 20);
            label9.TabIndex = 19;
            label9.Text = "Сортирвка по срочности задачи";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Не важные и срочные", "Важные и срочные", "Не срочные и не важные", "Важные но не срочные" });
            comboBox5.Location = new Point(870, 29);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(227, 27);
            comboBox5.TabIndex = 18;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { titel, type, status, term, urgency });
            listView1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listView1.ForeColor = SystemColors.Desktop;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(7, 6);
            listView1.Name = "listView1";
            listView1.Size = new Size(816, 242);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Click += listView1_Click;
            // 
            // titel
            // 
            titel.Text = "Название";
            titel.Width = 170;
            // 
            // type
            // 
            type.Text = "Тип задачи";
            type.TextAlign = HorizontalAlignment.Center;
            type.Width = 110;
            // 
            // status
            // 
            status.Text = "Статус задачи";
            status.TextAlign = HorizontalAlignment.Center;
            status.Width = 140;
            // 
            // term
            // 
            term.Text = "Срок выполнения";
            term.TextAlign = HorizontalAlignment.Center;
            term.Width = 170;
            // 
            // urgency
            // 
            urgency.Text = "Срочность задачи";
            urgency.TextAlign = HorizontalAlignment.Center;
            urgency.Width = 170;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Azure;
            tabPage2.Controls.Add(comboBox4);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(listView2);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1126, 538);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Сотрудники";
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Программист", "Менеджер", "Дизайнер", "Тестировщик", "Team lead", "Системный адиминстратор" });
            comboBox4.Location = new Point(75, 204);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(245, 27);
            comboBox4.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(151, 181);
            label6.Name = "label6";
            label6.Size = new Size(106, 22);
            label6.TabIndex = 12;
            label6.Text = "Должность";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(163, 97);
            label7.Name = "label7";
            label7.Size = new Size(66, 22);
            label7.TabIndex = 11;
            label7.Text = "Задача";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(122, 16);
            label8.Name = "label8";
            label8.Size = new Size(160, 22);
            label8.TabIndex = 10;
            label8.Text = "ФИО Сотрудника";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(75, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 27);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(75, 41);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(245, 27);
            textBox4.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(134, 207, 250);
            button4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.FromArgb(0, 0, 64);
            button4.Location = new Point(57, 271);
            button4.Name = "button4";
            button4.Size = new Size(102, 56);
            button4.TabIndex = 3;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(134, 207, 250);
            button3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.FromArgb(0, 0, 64);
            button3.Location = new Point(218, 271);
            button3.Name = "button3";
            button3.Size = new Size(102, 56);
            button3.TabIndex = 2;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listView2
            // 
            listView2.BackColor = Color.White;
            listView2.Columns.AddRange(new ColumnHeader[] { employee, missia, post });
            listView2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listView2.ForeColor = Color.FromArgb(0, 0, 64);
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(404, 6);
            listView2.Name = "listView2";
            listView2.Size = new Size(716, 525);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // employee
            // 
            employee.Text = "ФИО Сотрудника";
            employee.Width = 200;
            // 
            // missia
            // 
            missia.Text = "Задача (название)";
            missia.TextAlign = HorizontalAlignment.Center;
            missia.Width = 250;
            // 
            // post
            // 
            post.Text = "Должность";
            post.TextAlign = HorizontalAlignment.Center;
            post.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(94, 163, 222);
            ClientSize = new Size(1128, 569);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListView listView1;
        private TabPage tabPage2;
        private ColumnHeader titel;
        private ColumnHeader type;
        private ColumnHeader status;
        private ColumnHeader term;
        private ColumnHeader urgency;
        private ColumnHeader name;
        private Button button2;
        private Button button1;
        private ListView listView2;
        private ColumnHeader employee;
        private ColumnHeader missia;
        private ColumnHeader post;
        private Button button4;
        private Button button3;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox3;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Label label9;
        private Label label10;
        private Panel panel1;
        private Panel panel2;
        private Label label13;
        private Button button5;
        private Label label12;
        private TextBox textBoxTime;
        private TextBox textBoxName;
        private Label label11;
        private Label label14;
        private RichTextBox richTextBox1;
    }
}

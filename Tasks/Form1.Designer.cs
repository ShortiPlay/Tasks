﻿namespace Tasks
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
            label10 = new Label();
            comboBox6 = new ComboBox();
            label9 = new Label();
            comboBox5 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
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
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-6, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(812, 501);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Azure;
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(comboBox6);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(comboBox5);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(comboBox3);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(listView1);
            tabPage1.ForeColor = Color.FromArgb(0, 0, 64);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(804, 468);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Задачи";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(568, 251);
            label10.Name = "label10";
            label10.Size = new Size(218, 20);
            label10.TabIndex = 21;
            label10.Text = "Сортировка по статусу задачи";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "В процессе выполнения", "Выполнена", "Отменена", "Запланирована" });
            comboBox6.Location = new Point(581, 274);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(192, 28);
            comboBox6.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(558, 178);
            label9.Name = "label9";
            label9.Size = new Size(234, 20);
            label9.TabIndex = 19;
            label9.Text = "Сортирвка по срочности задачи";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Не важные и срочные", "Важные и срочные", "Не срочные и не важные", "Важные но не срочные" });
            comboBox5.Location = new Point(580, 201);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(192, 28);
            comboBox5.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(253, 360);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 27);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Не важные и срочные", "Важные и срочные", "Не срочные и не важные", "Важные но не срочные" });
            comboBox3.Location = new Point(253, 265);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(192, 28);
            comboBox3.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 242);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 14;
            label5.Text = "Срочность задачи";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 336);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 13;
            label4.Text = "Срок выполнения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 336);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 11;
            label3.Text = "Статус задачи";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "В процессе выполнения", "Выполнена", "Отменена", "Запланирована" });
            comboBox2.Location = new Point(40, 359);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(192, 28);
            comboBox2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 242);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 9;
            label2.Text = "Тип задачи";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Lavender;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Важныве и долгосрочные", "Текукщие важные", "Повседневные", "Ситуатывные" });
            comboBox1.Location = new Point(40, 265);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 28);
            comboBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 178);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "Название";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(134, 207, 250);
            button2.Location = new Point(127, 407);
            button2.Name = "button2";
            button2.Size = new Size(105, 49);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(134, 207, 250);
            button1.Location = new Point(253, 407);
            button1.Name = "button1";
            button1.Size = new Size(105, 49);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { titel, type, status, term, urgency });
            listView1.ForeColor = SystemColors.Desktop;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(7, 6);
            listView1.Name = "listView1";
            listView1.Size = new Size(791, 150);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            status.Width = 110;
            // 
            // term
            // 
            term.Text = "Срок выполнения";
            term.TextAlign = HorizontalAlignment.Center;
            term.Width = 145;
            // 
            // urgency
            // 
            urgency.Text = "Срочность задачи";
            urgency.TextAlign = HorizontalAlignment.Center;
            urgency.Width = 140;
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
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(804, 468);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Сотрудники";
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Программист", "Менеджер", "Дизайнер", "Тестировщик", "Team lead", "Системный адиминстратор" });
            comboBox4.Location = new Point(43, 219);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(172, 28);
            comboBox4.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.Location = new Point(91, 196);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 12;
            label6.Text = "Должность";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(103, 112);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 11;
            label7.Text = "Задача";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(0, 0, 64);
            label8.Location = new Point(69, 33);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 10;
            label8.Text = "ФИО Сотрудника";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(43, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 27);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(43, 56);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(172, 27);
            textBox4.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(134, 207, 250);
            button4.ForeColor = Color.FromArgb(0, 0, 64);
            button4.Location = new Point(15, 271);
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
            button3.ForeColor = Color.FromArgb(0, 0, 64);
            button3.Location = new Point(154, 271);
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
            listView2.ForeColor = Color.FromArgb(0, 0, 64);
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(273, 6);
            listView2.Name = "listView2";
            listView2.Size = new Size(524, 453);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // employee
            // 
            employee.Text = "ФИО Сотрудника";
            employee.Width = 170;
            // 
            // missia
            // 
            missia.Text = "Задача (название)";
            missia.TextAlign = HorizontalAlignment.Center;
            missia.Width = 200;
            // 
            // post
            // 
            post.Text = "Должность";
            post.TextAlign = HorizontalAlignment.Center;
            post.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(94, 163, 222);
            ClientSize = new Size(804, 501);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
    }
}

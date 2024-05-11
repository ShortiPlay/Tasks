namespace Tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Кнопка добавления в ListView у задач
        private void button1_Click(object sender, EventArgs e)
        {
            //Проверка введённой информации во всех используемых полях
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(comboBox3.Text))
            {
                //Вывод сообщения, если условие выполняется
                MessageBox.Show("Введите значение в текстовое поле перед добавлением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Вызов метода добавления всех элементов в список
                add(textBox2.Text, comboBox1.Text, comboBox2.Text, textBox1.Text, comboBox3.Text);
                //Очистка TextBox
                textBox2.Clear();
                //Очистка ComboBox
                comboBox1.SelectedIndex = -1;
                //Очистка ComboBox
                comboBox2.SelectedIndex = -1;
                //Очистка TextBox
                textBox1.Clear();
                //Очистка ComboBox
                comboBox3.SelectedIndex = -1;
            }
        }
        //Кнопка добавления в ListView у сотрудников
        private void button3_Click(object sender, EventArgs e)
        {
            //Проверка введённой информации во всех используемых полях
            if (string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(comboBox4.Text))
            {
                //Вывод сообщения, если условие выполняется
                MessageBox.Show("Введите значение в текстовое поле перед добавлением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Вызов метода добавления всех элементов в список
                addColoborators(textBox4.Text, textBox3.Text, comboBox4.Text);
                //Очистка TextBox
                textBox4.Clear();
                //Очистка TextBox
                textBox3.Clear();
                //Очистка ComboBox
                comboBox4.SelectedIndex = -1;
            }
        }
        //Кнопка удаление элементов из списка задач
        private void button2_Click(object sender, EventArgs e)
        {
            //цикл для удаления элементов из списка
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }
        //Кнопка удаление элементов из списка сотрудников
        private void button4_Click(object sender, EventArgs e)
        {
            //цикл для удаления элементов из списка
            foreach (ListViewItem item in listView2.SelectedItems)
            {
                listView2.Items.Remove(item);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //Метод добавления элеметнов в список задач
        private void add(string titel, string type, string status, string term, string urgency)
        {
            string[] row = { titel, type, status, term, urgency };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
        //Метод добавления элементов в список сотрудников
        private void addColoborators(string employee, string missia, string post)
        {
            string[] rows = { employee, missia, post };
            ListViewItem item = new ListViewItem(rows);
            listView2.Items.Add(item);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                if (item.SubItems.Count >= 2)
                {
                    textBoxName.Text = item.SubItems[0].Text;
                    textBoxTime.Text = item.SubItems[3].Text;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

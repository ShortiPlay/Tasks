namespace Tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(comboBox3.Text))
            {
                MessageBox.Show("Введите значение в текстовое поле перед добавлением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                add(textBox2.Text, comboBox1.Text, comboBox2.Text, textBox1.Text, comboBox3.Text);
                textBox2.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                textBox1.Clear();
                comboBox3.SelectedIndex = -1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(comboBox4.Text))
            {
                MessageBox.Show("Введите значение в текстовое поле перед добавлением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addColoborators(textBox4.Text, textBox3.Text, comboBox4.Text);
                textBox4.Clear();
                textBox3.Clear();
                comboBox4.SelectedIndex = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView2.Items.Count > 0)
            {
                listView2.Items.Remove(listView2.SelectedItems[0]);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void add(string titel, string type, string status, string term, string urgency)
        {
            string[] row = {  titel, type, status, term, urgency };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
        private void addColoborators(string employee, string missia, string post)
        {
            string[] rows = { employee, missia, post };
            ListViewItem item = new ListViewItem(rows);
            listView2.Items.Add(item);
        }
    }
}

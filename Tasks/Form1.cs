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
            if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text))
                return;
            ListViewItem item = new ListViewItem(textBox2.Text);
            item.SubItems.Add(textBox1.Text);
            listView1.Items.Add(item);
            textBox2.Clear();
            textBox1.Clear();
            textBox2.Focus();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count >0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
    }
}

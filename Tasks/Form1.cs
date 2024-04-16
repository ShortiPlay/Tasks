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
            if (string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox3.Text))
                return;
            ListViewItem Item = new ListViewItem(textBox4.Text);
            Item.SubItems.Add(textBox3.Text);
            listView2.Items.Add(Item);
            textBox4.Clear();
            textBox3.Clear();
            textBox4.Focus();
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
    }
}

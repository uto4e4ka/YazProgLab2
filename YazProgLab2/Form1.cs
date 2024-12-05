namespace YazProgLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LinkedList linkedList = new LinkedList();
        LinkedList linkedList2 = new LinkedList();
        int insertMode = 0;
        int l1 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            switch (insertMode)
            {
                case 0:
                    if (l1 == 0)
                        linkedList.addFirst(textBox1.Text);
                    else if (l1 == 1) linkedList2.addFirst(textBox1.Text);
                    break;
                case 1:
                    if (l1 == 0)
                        linkedList.addLast(textBox1.Text);
                    else if (l1 == 1) linkedList2.addLast(textBox1.Text);
                    break;
                case 2:
                    int pos;
                    if (int.TryParse(textBox2.Text, out pos))
                    {
                        if (l1 == 0)
                            linkedList.addToPos(textBox1.Text, pos);
                        else if (l1 == 1) linkedList2.addToPos(textBox1.Text, pos);
                    }
                    break;
            }
            show();



        }
        private void show()
        {
            listBox1.Items.Clear();
            int i = 0;
            while (linkedList.getSize() > i)
            {
                listBox1.Items.Add(i + ". " + linkedList.get(i));
                i++;
            }
            listBox2.Items.Clear();
            i = 0;
            while (linkedList2.getSize() > i)
            {
                listBox2.Items.Add(i + ". " + linkedList2.get(i));
                i++;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void вНачалоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertMode = 0;
            modeCahnge(insertMode);
        }

        private void вКонецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertMode = 1;
            modeCahnge(insertMode);
        }

        private void вПроизвольнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insertMode = 2;
            modeCahnge(insertMode);
        }
        void modeCahnge(int mode)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            if (mode == 2)
            {
                textBox2.Enabled = true;
                label5.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                label5.Enabled = false;
            }
            switch (mode)
            {
                case 0:
                    label4.Text = "Вставка в начало списка";
                    break;
                case 1:
                    label4.Text = "Вставка в конец списка";
                    break;
                case 2:
                    label4.Text = "Вставка в произвольную позицию";
                    break;
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void изНачалаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (l1 == 0)
                linkedList.removeFirst();
            else if (l1 == 1)
                linkedList2.removeFirst();
            show();
        }

        private void сКонцаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (l1 == 0)
                linkedList.removeLast();
            else if (l1 == 1) linkedList2.removeLast();
            show();
        }

        private void произвольноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox3.Text, out int value))
            {

                if (l1 == 0)
                {
                    if (value >= linkedList.getSize()) return;
                    linkedList.removeToPos(value);
                }
                else if (l1 == 1)
                {
                    if (value >= linkedList2.getSize()) return;
                    linkedList2.removeToPos(value);
                }
            }
            show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            l1 = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            l1 = 1;
        }

        private void объеденитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            int i = 0;
            LinkedList merged = LinkedList.merge(linkedList, linkedList2);
            while (i < merged.getSize())
            {
                listBox3.Items.Add(i + ". " + merged.get(i));
                i++;
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
       "Задание:\n15. Задана строка S из N символов. Реализуйте рекурсивный алгоритм проверки,  является ли симметричной часть строки, начинающаяся i-м и заканчивающаяся j-м ее  элементом.\n\nВыполнил: студент группы 6204-090301D\nЖестков А.С.",
       "Сообщение",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.DefaultDesktopOnly);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы точно хотите выйти из программы",
                "Выход",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (dialog == DialogResult.Yes) { Application.Exit(); }
        }
    }
}

using System.Drawing;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace OOP1lb
{
    internal partial class Form1 : Form
    {
        String selectedkey = "";
        MyHashTable zheckList = new MyHashTable();
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(MyHashTable zheckList1)
        {
            InitializeComponent();
            foreach (Zheck zheck in zheckList1) listBox1.Items.Add(zheck.Name1);
            zheckList = zheckList1;
            zheckList.objectCreated += (String key) =>
            {
                MessageBox.Show("������  " + key + " ������");
            };
            zheckList.objectDeleted += (String key) =>
            {
                MessageBox.Show("������  " + key + " ������");
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string region = textReg.Text;
                string name = textNam.Text;
                double numberHabitians = (double)textHab.Value;
                double numberPayments = (double)textServ.Value;
                double numberOfBuildings = (double)textInn.Value;
                string contactEmail = textEmail.Text;
                float serviceArea = float.Parse(textSquare.Text);
                Zheck zheck = new Zheck(region, name, numberHabitians, numberPayments, numberOfBuildings, contactEmail, serviceArea);
                zheckList.Add(zheck);
                count.Text = Zheck.counter.ToString();
                listBox1.Items.Add(zheck.Name1);
            }
            catch (FormatException ex)
            {
                Win32.MessageBox(0, "�������� ��������� ���� ������� ������������", "������", 0);
            }
            catch (MyException ex)
            {
                Win32.MessageBox(0, ex.Message, "������", 0);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedkey = (String)listBox1.SelectedItem;
            Zheck? selected = zheckList[selectedkey];
            if (selected != null)
            {
                SelectedZheck(selected);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!zheckList.Contains(selectedkey))
                {
                    throw new ArrayExeption("������� �� ������", selectedkey);
                }
                Zheck? selected = zheckList[selectedkey];
                selected.ContactEmail1 = changingEmail.Text;
                selected.NumberHabitians1 = (double)changingHab.Value;
                selected.NumberOfBuildings1 = (double)changingHous.Value;
                selected.Region1 = changingReg.Text;
                selected.NumberPayments1 = (double)changingServ.Value;
                selected.Name1 = changing_name.Text;
                selected.ServiceArea1 = float.Parse(changingSquare.Text);
            }
            catch (FormatException)
            {
                Win32.MessageBox(0, "�������� ��������� ���� ������� ������������", "������", 0);
            }
            catch (MyException ex)
            {
                Win32.MessageBox(0, ex.Message, "������", 0);
            }
            catch (ArrayExeption ex)
            {
                Win32.MessageBox(0, ex.Message + ex.Index, "������", 0);
            }
        }


        private void SelectedZheck(Zheck selected)
        {
            changingEmail.Text = selected.ContactEmail1;
            changingHab.Value = (decimal)selected.NumberHabitians1;
            changingHous.Value = (decimal)selected.NumberOfBuildings1;
            changingReg.Text = selected.Region1;
            changingServ.Value = (decimal)selected.NumberPayments1;
            changing_name.Text = selected.Name1;
            changing_number.Text = selected.Number1.ToString();
            changing_number_hex.Text = selected.GetNumberInHex();
            changingSquare.Text = selected.ServiceArea1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Zheck? selected = zheckList[search.Text];
                if (selected != null)
                {
                    SelectedZheck(selected);
                }
                else
                {
                    throw new ArrayExeption("������� �� ������ ", search.Text);
                }
            }
            catch (ArrayExeption ex)
            {
                Win32.MessageBox(0, ex.Message + " " + ex.Index, "������", 0);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string region = textBox2.Text;
                Zheck zheck = new Zheck(region, name);
                zheckList.Add(zheck);
                count.Text = zheckList.Count.ToString();
                listBox1.Items.Add(zheck);
            }
            catch (MyException ex)
            {
                Win32.MessageBox(0, ex.Message, "������", 0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zheck zheck = new();
            zheckList.Add(zheck);
            count.Text = zheckList.Count.ToString();
            listBox1.Items.Add(zheck.Name1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (!zheckList.Contains(selectedkey))
                {
                    throw new ArrayExeption("������� �� ����������");
                }

                zheckList.Remove(selectedkey);
                listBox1.Items.Remove(selectedkey);
                selectedkey = "";
                count.Text = zheckList.Count.ToString();
            }
            catch (ArrayExeption ex)
            {
                Win32.MessageBox(0, ex.Message, "������", 0);
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
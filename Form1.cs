using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPrivalov
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        List<Pacient> pacientList;
        private void Form1_Load(object sender, EventArgs e)
        {
            Pacient pacient1 = new Pacient("Danil", 20);
            Pacient pacient2 = new Pacient("Oleg", 30);
            Pacient pacient3 = new Pacient("Nikita", 25);
            Pacient pacient4 = new Pacient("Misha", 21);
            Pacient pacient5 = new Pacient("Olya", 10);
            Pacient pacient6 = new Pacient("Kolya", 15);
            Pacient pacient7 = new Pacient("Filip", 64);

            pacientList = new List<Pacient>();
            pacientList.Add(pacient1);
            pacientList.Add(pacient2);
            pacientList.Add(pacient3);
            pacientList.Add(pacient4);
            pacientList.Add(pacient5);
            pacientList.Add(pacient6);
            pacientList.Add(pacient7);
            dataGridView1.DataSource = pacientList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            dataGridView1.DataSource = null;

            List<Pacient> newlist = new List<Pacient>();
            newlist.Add(pacientList[2]);
            dataGridView1.DataSource = newlist;

            if(textBox1.Text == "")
            {
                dataGridView1.DataSource = pacientList;
            }
        }
    }

    public class Pacient
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Pacient(string n, int a)
        {
            name = n;
            age = a;
        }
    }
}

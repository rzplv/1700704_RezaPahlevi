using pv03_1700704_RezaPahlevi.Model;
using pv03_1700704_RezaPahlevi.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pv03_1700704_RezaPahlevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TodoRepository todo = new TodoRepository();

            textBox1.Enabled = false;

            string nim = textBox1.Text;

            button2.Enabled = true;
            button1.Enabled = false;

            dataGridView1.DataSource = todo.getByNim(nim);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.NimMhs = textBox1.Text;
            temp.Nama = textBox2.Text;
            temp.Kategori = textBox3.Text;

            TodoRepository todo = new TodoRepository();

            todo.addTodo(temp);

            string nim = textBox1.Text;

            dataGridView1.DataSource = todo.getByNim(nim);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            Todo temp = new Todo();

            temp.Id = Convert.ToInt16(textBox4.Text);

            TodoRepository todo = new TodoRepository();

            todo.dellTodo(temp);

            string nim = textBox1.Text;

            dataGridView1.DataSource = todo.getByNim(nim);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            textBox5.Enabled = false;
            Todo temp = new Todo();

            temp.Id = Convert.ToInt16(textBox5.Text);
            temp.Nama = textBox6.Text;
            temp.Kategori = textBox7.Text;

            TodoRepository todo = new TodoRepository();

            todo.updateTodo(temp);

            string nim = textBox1.Text;

            dataGridView1.DataSource = todo.getByNim(nim);
        }
    }
}

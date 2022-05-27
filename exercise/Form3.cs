using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form5 datagrid = new Form5();
            datagrid.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            datagrid.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            datagrid.textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            datagrid.textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            datagrid.textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            datagrid.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}

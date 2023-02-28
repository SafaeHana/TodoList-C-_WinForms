using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList2
{
    public partial class Form1 : Form
    {


        public int taskCounter = 0;
        public int DonetaskCounter = 0;

        //private int poss;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void AddItem(string Text, bool Checked)
        {
            ToDoITask task = new ToDoITask(Text, Checked);
            task.Top = panel1.Controls.Count * task.Height; //poss;
            panel1.Controls.Add(task);

            /*
              ToDoITask task = new ToDoITask(this);
              task.Dock=DockStyle.Top;
              panel1.Controls.Add(task);

            */
        }

        private void AddNewTaskButton_Click(object sender, EventArgs e)
        {
            AddItem(textBox1.Text, false);
            taskCounter = taskCounter + 1;
            UpdateTaskCounter(taskCounter);


        }
        public void UpdateTaskCounter(int c)
        {
            label1.Text = "Number of tasks:  " + c; // Mettre à jour le texte du Label
        }
        public void UpdateDoneTaskCounter(int c)
        {
            label2.Text = "Number of done tasks:  " + c; // Mettre à jour le texte du Label
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

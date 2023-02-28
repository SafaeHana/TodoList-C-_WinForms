using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList2
{

    public partial class ToDoITask : UserControl
    {

        public ToDoITask(string Text, bool Checked)
        {
            InitializeComponent();
            
            label1.Text = Text;
            checkBox1.Checked = Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Strikeout);
                Panel pnl = this.Parent as Panel;
                // Get the parent form
                Form1 form = pnl.Parent as Form1;
                // increment the done task counter
                form.DonetaskCounter = form.DonetaskCounter + 1;
                form.UpdateDoneTaskCounter(form.DonetaskCounter);

            }
            else
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.SizeInPoints, FontStyle.Regular);
            }   
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Panel pnl = this.Parent as Panel;
            // Get the parent form
            Form1 form = pnl.Parent as Form1;

            // Decrement the task counter
            form.taskCounter = form.taskCounter - 1;
            form.UpdateTaskCounter(form.taskCounter);

            pnl.Controls.Remove(this);
            this.Dispose();
            reorderListrView(pnl);
           





        }

        private void reorderListrView(Panel pnl)
        {
            int index = 0;
            foreach (Control c in pnl.Controls)
            {
                c.Top = index * c.Height;
                index++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack_ornk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Stack<int> stack1 = new Stack<int>();
            stack1.Push(1);
            stack1.Push(50);
            stack1.Push(3);
            stack1.Push(90);

            listBox1.DataSource = stack1.ToList();
            stack1.Pop();
            stack1.Pop();
            listBox2.DataSource= stack1.ToList();
            
        }
    }
}

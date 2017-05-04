using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebbrowserJs
{
    [ComVisible(true)]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.ObjectForScripting = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] objects = new object[1];
            objects[0] = this.textBox1.Text;
            webBrowser1.Document.InvokeScript("Message", objects);
        }

        //[ComVisible(false)]
        public void Message(string message)
        {
            this.richTextBox1.Text = message;
        }
    }

}

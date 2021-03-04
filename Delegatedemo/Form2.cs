using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegatedemo
{
    public partial class Form2 : Form
    {
        //Khai báo delegate
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        public int value;
        public Form2()
        {
            InitializeComponent();
            //Tạo con trỏ tới hàm GetMessage
            Sender = new SendMessage(GetMessage);
        }    //Hàm có nhiệm vụ lấy tham số truyền vào
        private void GetMessage(string Message)
        {
            textBox1.Text = Message;
            MessageBox.Show(textBox1.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }
    }
}

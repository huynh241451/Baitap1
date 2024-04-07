using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Security_Panel
{
    public partial class Form1 : Form
    {
        StreamWriter write;
        public Form1()
        {
            InitializeComponent();
            loadFile();

        }


        public void loadFile()
        {
            StreamReader read = new StreamReader("Text.txt");
            string text = "";
            while (true)
            {
                text = read.ReadLine();
                if (text != null)
                    listcode.Items.Add(text);
                else break;
            }
            read.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //textcode.Text = btn1.Text;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Button)
            {
                textcode.PasswordChar = '*';
                //textcode.MaxLength = 4;
                System.Windows.Forms.Button getnumber = (System.Windows.Forms.Button)sender;

                if (getnumber.Text == "C")
                {
                    textcode.Text = "";
                    //MessageBox.Show(textcode.Text);
                }
                if (getnumber.Text == "#")
                {
                    DateTime now = DateTime.Now;
                    write = new StreamWriter("Text.txt", true);
                    if (textcode.Text == "1234")
                    {
                        //write.WriteLine(textcode.Text + " ban da nhap dung");

                        string formattedString = string.Format("{0,-57} {1,10:C}", now, "Restricted Access!");
                        write.WriteLine(formattedString);
                        listcode.Items.Add(formattedString);
                        textcode.Text = "";
                    }
                    else
                    {
                        string formattedString = string.Format("{0,-57} {1,10:C}", now, "Scientists");
                        write.WriteLine(formattedString);
                        listcode.Items.Add(formattedString);
                        textcode.Text = "";
                    }
                    write.Close();
                }
                if (getnumber.Text != "C" && getnumber.Text != "#" && textcode.TextLength < 4)
                {
                    textcode.Text += getnumber.Text;
                }

            }
        }

        private void lbcode_Click(object sender, EventArgs e)
        {

        }
        public static string t;
        public void ButtonClick(object sender, EventArgs e)
        {
            //System.Windows.Forms.Button button = sender as Button;
            //if (button != null)
            //{
            //    t += button.text;
            //    textBox1.Text = t;
            //}
        }

        private void textcode_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    btn0.PerformClick();
                    break;
                case Keys.D2:
                    btn1.PerformClick();
                    break;
                case Keys.D3:
                    btn2.PerformClick();
                    break;
                case Keys.D4:
                    btn2.PerformClick();
                    break;

                //case Keys.Oemplus:
                //    if(!e.Shift)
                //    {

                //    }
            }
        }
    }
}

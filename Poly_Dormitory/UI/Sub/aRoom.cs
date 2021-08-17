using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Poly_Dormitory
{
    public partial class aRoom : Form
    {
        private MySqlConnection mConnection; // DB접속
        public static String url = "SERVER=LOCALHOST; USER=root; DATABASE=polydormi;" +
                                   "PORT=3306; PASSWORD=0159; CharSet=utf8;";
        public static string roomvalue;

        public aRoom()
        {
            InitializeComponent();
        }

        private void Halla_Room_Load(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            L_Room.Text = roomvalue; R_Room.Text = roomvalue;
            this.Text = roomvalue + "호 정보";

            mConnection = new MySqlConnection(url);
            mConnection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM halla_stu WHERE room='"+roomvalue+
                                                                      "'AND outtime='"+ "" +"'", mConnection);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read() == true)
            {
                string name = dr["stu_Name"].ToString();
                string num = dr["major"].ToString();
                string grade = dr["grade"].ToString();
                string sex = dr["sex"].ToString();

                textBox1.AppendText(name + "\x01");
                textBox2.AppendText(num + "\x01");
                name = textBox1.Text;
                num = textBox2.Text;
                if (name.Contains("\x01"))
                {
                    string[] stack = name.Split('\x01');
                    L_Name.Text = stack[0];
                    R_Name.Text = stack[1];
                    
                }
                if (num.Contains('\x01'))
                {
                    string[] stack = num.Split('\x01');
                    L_Major.Text = stack[0];
                    R_Major.Text = stack[1];
                }

                //학년 체크
                if (a == 0)
                {
                    if (grade == "1학년")
                    {
                        radioButton1.Checked = true;
                    }
                    else if (grade == "2학년")
                    {
                        radioButton2.Checked = true;
                    }
                    a++;
                }else if (a == 1)
                {
                    if (grade == "1학년")
                    {
                        radioButton7.Checked = true;
                    }
                    else if (grade == "2학년")
                    {
                        radioButton8.Checked = true;
                    }
                    a = 0;
                }

                
                //성별 체크
                if (b == 0)
                {
                    if (sex == "남")
                    {
                        radioButton3.Checked = true;
                    }
                    else if (sex == "여")
                    {
                        radioButton4.Checked = true;
                    }
                    b++;
                }
                else if (b == 1)
                {
                    if (sex == "남")
                    {
                        radioButton6.Checked = true;
                    }
                    else if (sex == "여")
                    {
                        radioButton5.Checked = true;
                    }
                }
            }
            mConnection.Close();

            if (L_Name.Text == "")
            {
                MessageBox.Show("빈 호실 입니다.", "빈 호실", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}

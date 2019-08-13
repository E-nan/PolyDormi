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
    public partial class Baekdu_S_New : Form
    {
        private MySqlConnection mConnection; // DB접속
        public static String url = "SERVER=LOCALHOST; USER=root; DATABASE=polydormi;" +
                                   "PORT=3306; PASSWORD=0159; CharSet=utf8;";

        string grade;
        string sex;
        string date;
        string stuA;
        string stuB;
        string stunum;

        Boolean up = true;

        //부모폼에도 최신화 시켜줌
        Baekdu main = null;
        public Baekdu_S_New(Baekdu main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void InsertDB()
        {
            MySqlCommand cmd1 = new MySqlCommand("INSERT INTO baekdu_stu values('" + new_Room.Text + "','"
                                                                                     + new_Name.Text + "','"
                                                                                     + new_Class.Text + "','"
                                                                                     + new_Num.Text + "','"
                                                                                     + grade + "','"
                                                                                     + sex + "','"
                                                                                     + date + "','"
                                                                                     + "" + "')", mConnection);

            cmd1.Connection = mConnection;
            cmd1.ExecuteNonQuery();

            MessageBox.Show("입력되었습니다", "입력완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            main.btn_refresh.PerformClick();
            this.Close();
        }
        private void Baekdu_S_New_Load(object sender, EventArgs e)
        {
            mConnection = new MySqlConnection(url);
            DateTime dt = dateTimePicker1.Value;
            date = dt.ToString("yyyy-MM-dd");
            mConnection.Open();
        }
        private void roomchoice()
        {
            MessageBox.Show("호실을 선택해 주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (new_Room.Text == "")
            {
                roomchoice();
            }
            if (new_Name.Text == "")
            {
                new_Name.Focus();
                roomchoice();
            }
            if (new_Class.Text == "")
            {
                roomchoice();
            }
            if (new_Num.Text == "")
            {
                roomchoice();
            }

            if (btn_1.Checked)
            {
                grade = "1학년";
            }
            else if (btn_2.Checked)
            {
                grade = "2학년";
            }
            else
            {
                MessageBox.Show("학년을 선택해 주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btn_Male.Checked)
            {
                sex = "남";
            }
            else if (btn_Female.Checked)
            {
                sex = "여";
            }
            else
            {
                MessageBox.Show("성별을 선택해 주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlCommand same = new MySqlCommand("SELECT * FROM baekdu_stat WHERE room = '" + new_Room.Text + "'", mConnection);
            MySqlDataReader dr = same.ExecuteReader();
            while (dr.Read() == true)
            {
                stuA = dr[1].ToString();
                stuB = dr[2].ToString();
            }
            dr.Close();

            if (!Equals(stuB, ""))
            {
                MessageBox.Show("해당 호실에 이미 2명의 학생이 있습니다!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (Equals(stuA, ""))
            {
                MySqlCommand cmd2 = new MySqlCommand("UPDATE baekdu_stat SET stuA='" + new_Name.Text +
                                                                  "'WHERE room ='" + new_Room.Text + "'", mConnection);
                cmd2.Connection = mConnection;
                cmd2.ExecuteNonQuery();

                InsertDB();
                up = false;
            }
            if (!Equals(stuA, ""))
            {
                MySqlCommand same2 = new MySqlCommand("SELECT * FROM baekdu_stu WHERE stu_num='" + new_Num.Text + "'", mConnection);
                MySqlDataReader dr1 = same2.ExecuteReader();

                while (dr1.Read() == true)
                {
                    stunum = dr1[3].ToString();
                }
                dr1.Close();
                up = true;
            }
            //중복학번검사
            if (up == true)
            {
                //중복된 학번이 아니라면
                if (!Equals(stunum, new_Num.Text))
                {
                    InsertDB();
                    MySqlCommand cmd2 = new MySqlCommand("UPDATE baekdu_stat SET stuB='" + new_Name.Text +
                                                             "'WHERE room ='" + new_Room.Text + "'", mConnection);
                    cmd2.Connection = mConnection;
                    cmd2.ExecuteNonQuery();
                    up = true;
                }
                else if (Equals(stunum, new_Num.Text))
                {
                    MessageBox.Show("중복된 학번입니다.!", "중복", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mConnection.Close();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            date = dt.ToString("yyyy-MM-dd");
        }
    }
}

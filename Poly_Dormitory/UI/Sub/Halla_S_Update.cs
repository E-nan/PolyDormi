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
    public partial class Halla_S_Update : Form
    {
        private MySqlConnection mConnection; // DB접속
        public static String url = "SERVER=LOCALHOST; USER=root; DATABASE=polydormi;" +
                                   "PORT=3306; PASSWORD=Enan)!%(; CharSet=utf8;";

        public static string namevalue;
        public static string numvalue;

        string grade;
        string sex;
        string date;

        Halla main = null;
        public Halla_S_Update(Halla main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void Halla_S_Update_Load(object sender, EventArgs e)
        {
            mConnection = new MySqlConnection(url);
            DateTime dt = dateTimePicker1.Value;
            date = dt.ToString("yyyy-MM-dd");
            new_Name.Text = namevalue;
            new_Num.Text = numvalue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new_Room.Text == "")
            {
                MessageBox.Show("호실을 선택해 주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (new_Class.Text == "")
            {

                MessageBox.Show("학과를 선택해 주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

            mConnection.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE halla_stu SET room='" + new_Room.Text +
                                                                   "',major='"+ new_Class.Text +
                                                                   "',grade='"+ grade +
                                                                   "',sex='"  + sex +
                                                               "',jointime='" + date+
                                                          "' WHERE stu_num='" + numvalue + "'", mConnection);  //이름과 학번을 기준으로 학생을 찾아서 이름,학번을 제외하고 수정

            cmd.Connection = mConnection;
            cmd.ExecuteNonQuery();
            mConnection.Close();

            MessageBox.Show("입력되었습니다", "입력완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
            main.btn_refresh.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            date = dt.ToString("yyyy-MM-dd");
        }
    }
}

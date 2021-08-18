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
    public partial class Baekdu_Build : Form
    {
        private MySqlConnection mConnection; // DB접속
        public static String url = "SERVER=LOCALHOST; USER=root; DATABASE=polydormi;" +
                                   "PORT=3306; PASSWORD=Enan)!%(; CharSet=utf8;";
        string floor;
        string date;

        Baekdu main = null;
        public Baekdu_Build(Baekdu main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void Baekdu_Build_Load(object sender, EventArgs e)
        {
            mConnection = new MySqlConnection(url);
            DateTime dt = dateTimePicker1.Value;
            date = dt.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn_1.Checked)
            {
                floor = "1F";
            }
            else if (btn_2.Checked)
            {
                floor = "2F";
            }
            else if (btn_3.Checked)
            {
                floor = "3F";
            }
            else if (btn_4.Checked)
            {
                floor = "4F";
            }
            else
            {
                MessageBox.Show("층을 선택해 주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (build_name.Text == "")
            {
                MessageBox.Show("시설을 선택해주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mConnection.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO build_baekdu values('" + floor + "','"              //층
                                                                                    + build_name.Text + "','"    //시설 이름
                                                                                    + "x" + "','"                //수리여부
                                                                                    + date + "','"               //고장난 날짜
                                                                                    + "" + "')", mConnection);   //수리된 날짜
            cmd.Connection = mConnection;
            cmd.ExecuteNonQuery();
            mConnection.Close();

            MessageBox.Show("입력되었습니다", "입력완료", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            main.btn_refresh.PerformClick();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            date = dt.ToString("yyyy-MM-dd");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

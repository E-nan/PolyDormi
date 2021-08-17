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
    public partial class Baekdu : Form
    {
        private MySqlConnection mConnection; // DB접속
        public static String url = "SERVER=LOCALHOST; USER=root; DATABASE=polydormi;" +
                                   "PORT=3306; PASSWORD=0159; CharSet=utf8;";

        string name;
        string num;
        string room;
        string outtime = System.DateTime.Now.ToString("yyyy-MM-dd");
        string stuA;
        string stuB;

        string buildfloor;
        string buildinfo;

        ListViewItem list;

        public Baekdu()
        {
            InitializeComponent();
        }
        private void selectdb()
        {
            mConnection = new MySqlConnection(url);
            Student_View.Items.Clear();
            Build_View.Items.Clear();
            mConnection.Open();
            //입사학생정보
            MySqlCommand cmd = new MySqlCommand("select * from baekdu_stu WHERE outtime= '" + "" + "'ORDER BY room", mConnection);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read() == true)
            {
                list = new ListViewItem(dr[0].ToString());
                list.SubItems.Add(dr[1].ToString());
                list.SubItems.Add(dr[3].ToString());
                list.SubItems.Add(dr[2].ToString());
                list.SubItems.Add(dr[4].ToString());
                list.SubItems.Add(dr[5].ToString());
                Student_View.Items.Add(list);
            }
            dr.Close();

            //시설정보
            MySqlCommand bl = new MySqlCommand("select * from build_baekdu WHERE repair= '" + "" + "'ORDER BY floor", mConnection);
            MySqlDataReader drbl = bl.ExecuteReader();
            while (drbl.Read() == true)
            {
                list = new ListViewItem(drbl[0].ToString());
                list.SubItems.Add(drbl[1].ToString()); 
                Build_View.Items.Add(list);
            }
            drbl.Close();
            mConnection.Close();
        }
        private void Baekdu_Load(object sender, EventArgs e)
        {
            selectdb();
        }

        private void First_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("호실을 선택해주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            aRoom.roomvalue = comboBox1.Text;
            aRoom hr = new aRoom();
            hr.Show();
        }

        private void Second_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("호실을 선택해주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            aRoom.roomvalue = comboBox2.Text;
            aRoom hr = new aRoom();
            hr.Show();
        }

        private void Third_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                MessageBox.Show("호실을 선택해주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            aRoom.roomvalue = comboBox3.Text;
            aRoom hr = new aRoom();
            hr.Show();
        }

        private void Fourth_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "")
            {
                MessageBox.Show("호실을 선택해주세요!", "경고", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            aRoom.roomvalue = comboBox4.Text;
            aRoom hr = new aRoom();
            hr.Show();
        }

        //시설 관련 버튼
        private void Build_New_Click(object sender, EventArgs e)
        {
            Baekdu_Build bb = new Baekdu_Build(this);
            bb.ShowDialog();
        }

        private void Build_Repair_Click(object sender, EventArgs e)
        {
            if (Build_View.SelectedIndices.Count == 0)
            {
                MessageBox.Show("수리 완료 시킬 시설을 선택해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Build_View.SelectedIndices.Count == 1)
            {
                if (MessageBox.Show("이 시설을 수리완료 하시겠습니까?", "수리", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {// no 일때 

                }
                else
                {// yes일때
                    Build_View.Items.RemoveAt(Build_View.SelectedIndices[0]);
                    mConnection.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE build_baekdu SET ox='" + "o" +
                                                                         "',repair= '" + outtime +
                                                                "'WHERE floor='" + buildfloor +
                                                                "'AND build_name='" + buildinfo + "'", mConnection);

                    cmd.Connection = mConnection;
                    cmd.ExecuteNonQuery();
                    mConnection.Close();

                    MessageBox.Show("수리 완료된 날짜 : " + outtime);
                }
            }
            else
            {
                MessageBox.Show("하나의 시설만 선택해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mConnection.Close();
            }
        }

        //학생정보 버튼
        private void Stu_New_Click(object sender, EventArgs e)
        {
            Baekdu_S_New hn = new Baekdu_S_New(this);
            hn.ShowDialog();
        }

        private void Stu_Update_Click(object sender, EventArgs e)
        {
            if (Student_View.SelectedIndices.Count == 0)
            {
                MessageBox.Show("수정할 학생을 선택해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Student_View.SelectedIndices.Count == 1)
            {
                Baekdu_S_Update.namevalue = name;
                Baekdu_S_Update.numvalue = num;

                Baekdu_S_Update hn = new Baekdu_S_Update(this);
                hn.ShowDialog();
            }
            else
            {
                MessageBox.Show("한명의 학생만 선택해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Stu_Out_Click(object sender, EventArgs e)
        {
            if (Student_View.SelectedIndices.Count == 0)
            {
                MessageBox.Show("퇴사시킬 학생을 선택해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Student_View.SelectedIndices.Count == 1)
            {
                if (MessageBox.Show("이 학생을 현시간 부로 퇴사 처리 하시겠습니까?", "퇴사", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {// no 일때 

                }
                else
                {// yes일때
                    Student_View.Items.RemoveAt(Student_View.SelectedIndices[0]);

                    mConnection.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE baekdu_stu SET outtime = '" + outtime +
                                                                      "' WHERE stu_num = '" + num + "'", mConnection);
                    //현황 업데이트 위한 부분
                    MySqlCommand up = new MySqlCommand("SELECT * FROM baekdu_stat WHERE room= '" + room + "'", mConnection);
                    MySqlDataReader drup = up.ExecuteReader();
                    while (drup.Read() == true)
                    {
                        stuA = drup[1].ToString();
                        stuB = drup[2].ToString();
                    }
                    drup.Close();

                    if (name.Equals(stuA))
                    {
                        MySqlCommand aup = new MySqlCommand("UPDATE baekdu_stat SET stuA='" + stuB +
                                                                                 "',stuB='" + "" +
                                                                           "'WHERE room ='" + room + "'", mConnection);
                        aup.Connection = mConnection;
                        aup.ExecuteNonQuery();
                    }
                    if (!name.Equals(stuA))
                    {
                        MySqlCommand bup = new MySqlCommand("UPDATE baekdu_stat SET stuB='" + "" +
                                                                           "'WHERE room ='" + room + "'", mConnection);
                        bup.Connection = mConnection;
                        bup.ExecuteNonQuery();
                    }
                    MessageBox.Show("퇴사 처리된 날짜 : " + outtime);
                    cmd.ExecuteNonQuery();
                    mConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("한명의 학생만 선택해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mConnection.Close();
            }
        }

        private void Stat_Click(object sender, EventArgs e)
        {
            Baekdu_Stat hs = new Baekdu_Stat(this);
            hs.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {// no 일때 
                return;
            }
            else
            {// yes일때
                Application.Exit();
            }
        }

        private void Student_View_MouseClick(object sender, MouseEventArgs e)
        {
            room = Student_View.FocusedItem.SubItems[0].Text;
            name = Student_View.FocusedItem.SubItems[1].Text;
            num = Student_View.FocusedItem.SubItems[2].Text;
            stu_search.Text = num;
        }

        private void Build_View_MouseClick(object sender, MouseEventArgs e)
        {
            buildfloor = Build_View.FocusedItem.SubItems[0].Text;//층
            buildinfo = Build_View.FocusedItem.SubItems[1].Text;//위치
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            selectdb();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchnum = stu_search.Text;
            if (Equals(searchnum, ""))
            {
                MessageBox.Show("학번을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            mConnection.Open();

            MySqlCommand ser = new MySqlCommand("SELECT * FROM baekdu_stu WHERE stu_num = '" + searchnum +
                                                                          "'AND outtime = '" + "" + "'", mConnection);
            MySqlDataReader dser = ser.ExecuteReader();

            int i = 0;
            while (dser.Read() == true)
            {
                info_name.Text = (dser[1].ToString());
                info_num.Text = (dser[3].ToString());
                info_grade.Text = (dser[4].ToString());
                info_major.Text = (dser[2].ToString());
                info_room.Text = (dser[0].ToString());
                info_sex.Text = (dser[5].ToString());
                info_join.Text = (dser[6].ToString());
                i++;
            }
            dser.Close();
            ser.Connection = mConnection;
            ser.ExecuteNonQuery();
            mConnection.Close();

            if (i == 0)
            {
                MessageBox.Show("학번을 확인해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

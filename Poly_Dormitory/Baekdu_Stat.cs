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
using Microsoft.VisualBasic;

namespace Poly_Dormitory
{
    public partial class Baekdu_Stat : Form
    {
        private MySqlConnection mConnection; // DB접속
        public static String url = "SERVER=LOCALHOST; USER=root; DATABASE=polydormi;" +
                                   "PORT=3306; PASSWORD=0159; CharSet=utf8;";

        ListViewItem list;
        string room;
        string name;
        string num;
        string floor;
        string info;

        Baekdu main = null;
        public Baekdu_Stat(Baekdu main)
        {
            this.main = main;
            InitializeComponent();
        }
        private void selectdb()
        {
            mConnection = new MySqlConnection(url);

            Student_View.Items.Clear();
            Build_View.Items.Clear();
            Now_View.Items.Clear();
            mConnection.Open();

            //입.퇴사 현황
            MySqlCommand cmd1 = new MySqlCommand("select * from baekdu_stu ORDER BY outtime, stu_name", mConnection);
            MySqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read() == true)
            {
                list = new ListViewItem(dr1[1].ToString());
                list.SubItems.Add(dr1[3].ToString());
                list.SubItems.Add(dr1[2].ToString());
                list.SubItems.Add(dr1[0].ToString());
                list.SubItems.Add(dr1[6].ToString());
                list.SubItems.Add("~");
                list.SubItems.Add(dr1[7].ToString());
                Student_View.Items.Add(list);
            }
            dr1.Close();

            //기숙사 현황
            MySqlCommand cmd2 = new MySqlCommand("select * from baekdu_stat ORDER BY room", mConnection);
            MySqlDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read() == true)
            {
                list = new ListViewItem(dr2[0].ToString());
                list.SubItems.Add(dr2[1].ToString());
                list.SubItems.Add(dr2[2].ToString());
                Now_View.Items.Add(list);
            }
            dr2.Close();

            //시설 현황
            MySqlCommand cmd3 = new MySqlCommand("select * from build_baekdu ORDER BY ox desc, floor", mConnection);
            MySqlDataReader dr3 = cmd3.ExecuteReader();

            while (dr3.Read() == true)
            {
                list = new ListViewItem(dr3[0].ToString());
                list.SubItems.Add(dr3[1].ToString());
                list.SubItems.Add(dr3[2].ToString());
                list.SubItems.Add(dr3[3].ToString());
                Build_View.Items.Add(list);
            }
            dr3.Close();
            mConnection.Close();
        }
        private void Baekdu_Stat_Load(object sender, EventArgs e)
        {
            selectdb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.btn_refresh.PerformClick();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Student_View.SelectedIndices.Count == 0)
            {
                MessageBox.Show("삭제시킬 학생을 선택해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Student_View.SelectedIndices.Count == 1)
            {
                if (MessageBox.Show("이 학생을 완전히 삭제하시겠습니까?", "삭제", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.No)
                {// no 일때 

                }
                else
                {
                    Student_View.Items.RemoveAt(Student_View.SelectedIndices[0]);

                    mConnection.Open();
                    MySqlCommand same1 = new MySqlCommand("SELECT * FROM baekdu_stat WHERE stuA= '" + name +
                                                                                     "'AND room= '" + room + "'", mConnection);
                    MySqlDataReader dr1 = same1.ExecuteReader();
                    int i = 0;
                    int j = 0;
                    while (dr1.Read() == true)
                    {
                        i++;
                        j = 0;
                    }
                    dr1.Close();
                    
                    MySqlCommand same2 = new MySqlCommand("SELECT * FROM baekdu_stat WHERE stuB= '" + name +
                                                                                     "'AND room= '" + room + "'", mConnection);
                    MySqlDataReader dr2 = same2.ExecuteReader();
                    while (dr2.Read() == true)
                    {
                        j++;
                        i = 0;
                    }
                    dr2.Close();
                    
                    //삭제하는 학생이 A라면
                    if (i != 0)
                    {
                        MySqlCommand up1 = new MySqlCommand("UPDATE baekdu_stat SET stuA = '" + "" +
                                                                              "'WHERE room='" + room + "'", mConnection);
                        up1.Connection = mConnection;
                        up1.ExecuteNonQuery();
                    }
                    //삭제하는 학생이 B라면
                    if (j != 0)
                    {
                        MySqlCommand up2 = new MySqlCommand("UPDATE baekdu_stat SET stuB = '" + "" +
                                                                              "'WHERE room='" + room + "'", mConnection);
                        up2.Connection = mConnection;
                        up2.ExecuteNonQuery();
                    }

                    MySqlCommand cmd = new MySqlCommand("DELETE FROM baekdu_stu WHERE stu_num = '" + num + "'", mConnection);
                    cmd.Connection = mConnection;
                    cmd.ExecuteNonQuery();

                    //학생을 삭제하면 현재 현황에도 업데이트
                    Now_View.Items.Clear();
                    MySqlCommand cmd2 = new MySqlCommand("select * from baekdu_stat;", mConnection);
                    MySqlDataReader dr3 = cmd2.ExecuteReader();

                    while (dr3.Read() == true)
                    {
                        list = new ListViewItem(dr3[0].ToString());
                        list.SubItems.Add(dr3[1].ToString());
                        list.SubItems.Add(dr3[2].ToString());
                        Now_View.Items.Add(list);
                    }
                    dr3.Close();
                    mConnection.Close();
                    MessageBox.Show("삭제되었습니다", "삭제완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("한명의 학생만 선택해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mConnection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Build_View.SelectedIndices.Count == 0)
            {
                MessageBox.Show("삭제시킬 시설을 선택해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Build_View.SelectedIndices.Count == 1)
            {
                if (MessageBox.Show("이 시설을 완전히 삭제 하시겠습니까?", "삭제", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.No)
                {// no 일때 

                }
                else
                {
                    mConnection.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM build_baekdu WHERE build_name= '" + info + "'", mConnection);
                    cmd.Connection = mConnection;
                    cmd.ExecuteNonQuery();
                    mConnection.Close();

                    Build_View.Items.RemoveAt(Build_View.SelectedIndices[0]);
                    MessageBox.Show("삭제되었습니다", "삭제완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Student_View_MouseClick(object sender, MouseEventArgs e)
        {
            name = Student_View.FocusedItem.SubItems[0].Text;
            num = Student_View.FocusedItem.SubItems[1].Text;
            room = Student_View.FocusedItem.SubItems[2].Text;
        }

        private void Build_View_MouseClick(object sender, MouseEventArgs e)
        {
            floor = Build_View.FocusedItem.SubItems[0].Text;
            info = Build_View.FocusedItem.SubItems[1].Text;
        }

        private void AllClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("전체 데이터가 삭제됩니다. 계속 하시겠습니까?", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.No)
            {// no 일때 

            }
            else
            {//yes 일때
                //취소누를때도 비밀번호 틀렸다고함
                string myValue = Interaction.InputBox("전체 데이터를 삭제하시려면 비밀번호를 입력하세요.", "관리자 비밀번호 입력", "Admin Pass", 100, 100);

                if (myValue == "1234")
                {
                    mConnection.Open();
                    MySqlCommand all1 = new MySqlCommand("DELETE FROM baekdu_stu ;", mConnection);
                    all1.Connection = mConnection;
                    all1.ExecuteNonQuery();

                    MySqlCommand all2 = new MySqlCommand("UPDATE baekdu_stat set stuA='" + "" +
                                                                             "',stuB='" + "" + "'", mConnection);
                    all2.Connection = mConnection;
                    all2.ExecuteNonQuery();

                    MySqlCommand all3 = new MySqlCommand("DELETE FROM build_baekdu ;", mConnection);
                    all3.Connection = mConnection;
                    all3.ExecuteNonQuery();
                    mConnection.Close();
                    MessageBox.Show("전체 데이터가 삭제되었습니다.");

                    selectdb();
                }
                else if (myValue != "1234")
                {
                    MessageBox.Show("비밀번호가 맞지 않습니다.");
                }
        }
        }
    }
}

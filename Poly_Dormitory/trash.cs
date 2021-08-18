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
    public partial class trash : Form
    {
        public static String url = "SERVER=LOCALHOST; USER=root; DATABASE=polydormi;" +
                                   "PORT=3306; PASSWORD=Enan)!%(; CHARSET=utf8";
                                   // DB접속 URL 설정 - SERVER : DB주소, USER : ID명, DATABASE : DB명, PORT : TCP 포트번호
                                   // PASSWORD : 비밀번호, 언어설정

        private MySqlConnection mConnection; // DB접속



        int room;
        string grade;
        string sex;
        string date;
        string stuA;
        string stuB;
        string stunum;
        string name;
        string major;
        string num;

        public trash()
        {
            InitializeComponent();
        }

        private void trash_Load(object sender, EventArgs e)
        {
            mConnection = new MySqlConnection(url);

            MySqlCommand sel = new MySqlCommand("SELECT * FROM halla_stu WHERE outtime= '" + "" + "'ORDER BY room", mConnection);
            MySqlCommand upd = new MySqlCommand("UPDATE halla_stat SET stuA = '" + "" + "'WHERE room='" + room + "'", mConnection);
            MySqlCommand del = new MySqlCommand("DELETE FROM halla_stu WHERE stu_num = '" + num + "'", mConnection);
            MySqlCommand ins = new MySqlCommand("INSERT INTO halla_stu values('" + room + "','"
                                                                                  + name + "','"
                                                                                  + major + "','"
                                                                                  + num + "','"
                                                                                  + grade + "','"
                                                                                  + sex + "','"
                                                                                  + date + "','"
                                                                                  + "" + "')", mConnection);
        }
    }
}

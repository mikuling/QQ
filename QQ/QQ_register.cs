using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//新加命名空间  
using System.Data.SqlClient;
using System.Reflection;  

namespace QQ
{
    public partial class QQ_register : Form
    {
        public QQ_register()
        {
            InitializeComponent();
        }

        private void Ispassword_textBox3_TextChanged(object sender, EventArgs e)
        {
            if(Ispassword_textBox3.Text != Password_textBox.Text)
            {
                Repassword_label.ForeColor = Color.Red;
                Repassword_label.Text = "密码不一致";
            }
            else
            {
                Repassword_label.Text = "";
                Repassword_label.Image = Image.FromFile(Application.StartupPath+"\\images\\check.png");
            }
        }

        private void Man_radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                   
        }
        private void Woman_radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Sign_button_Click(object sender, EventArgs e)
        {
            //字符串赋值:用户名 密码  
            string username = Name_textBox.Text.Trim();
            string userpwd = Password_textBox.Text.Trim();
            
            //定义数据库连接语句:服务器=.(本地) 数据库名=QQMS 
            string consqlserver = "Data Source=.; User ID=sa; Password = 1; Initial Catalog=QQMS;";
            //定义SQL Server连接对象 打开数据库  
            SqlConnection conn = new SqlConnection(consqlserver);
            try
            {
                
                conn.Open();
                //定义查询命令:表示对数据库执行一个SQL语句或存储过程  
 //               SqlCommand selectCmd = new SqlCommand("select * from QQ_table1", conn);
                //对性别作出判断
                int sex;
                if (Man_radioButton1.Checked)
                {
                    sex = 1;
                }
                else
                {
                    sex = 2;
                }
                string QQID = Set_random();
                string InsertSql = "insert into QQ_table1(QQID,Name,sex,Password,telephone) values ('"+ QQID +"','" + Name_textBox.Text + "','" + sex + "','" + Password_textBox.Text + "','" + Telephone_textBox4.Text + "')";
                SqlCommand selectCmd = new SqlCommand(InsertSql, conn);
                selectCmd.ExecuteNonQuery();
                //SqlDataAdapter da1 = new SqlDataAdapter();
                //da1.SelectCommand = selectCmd;
    /*            DataSet ds1 = new DataSet();
                da1.Fill(ds1,"QQ_table1");
                SqlCommandBuilder sqlCb1 = new SqlCommandBuilder(da1);*/

           /*     DataRow newRow = ds1.Tables["QQ_table1"].NewRow();
                newRow["QQID"] = Guid.NewGuid().ToString();
                newRow["Name"] = Name_textBox.Text;
                if (Ispassword_textBox3.Text != Password_textBox.Text)
                {
                   MessageBox.Show("密码不一致");
                }
                newRow["Password"] = Password_textBox.Text;
              
                newRow["Sex"] = sex;
                newRow["telephone"] = Telephone_textBox4;
                ds1.Tables["QQ_table1"].Rows.Add(newRow);
                da1.Update(ds1, "QQ_table1");
                ds1.Tables["QQ_table1"].AcceptChanges();*/
                if (Name_textBox.Text != "" && Password_textBox.Text != "" && Telephone_textBox4.Text != "")
                    MessageBox.Show("注册成功!\r\n" + "你的qq号为:" + QQID);
                else MessageBox.Show("注册失败!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "打开数据库失败!");
            }
            finally
            { 
                conn.Close();                    //关闭连接  
                conn.Dispose();                  //释放连接
                this.Close();
 //               da1.Dispose();                   //释放资源  
            }
            
            
        }
        private string Set_random()
        {
            Random ro = new Random();
            int iResult;
            int iUp = 99999999;
            int iDown = 10000000;
            iResult = ro.Next(iDown, iUp);
            string QQID = iResult.ToString();
            string consqlserver = "Data Source=.; User ID=sa; Password = 1; Initial Catalog=QQMS;";
            //定义SQL Server连接对象 打开数据库  
            SqlConnection conn = new SqlConnection(consqlserver);
            try
            {
                conn.Open();
                string InquireSql = "select * from QQ_table1 where QQID='" + QQID + "'";
                SqlCommand selectCmd = new SqlCommand(InquireSql, conn);
                SqlDataReader sread = selectCmd.ExecuteReader();
                while (sread.Read())
                {
                    iResult = ro.Next(iDown, iUp);
                    QQID = iResult.ToString();
                    selectCmd = new SqlCommand(InquireSql, conn);
                    sread = selectCmd.ExecuteReader();

                }
                return QQID;
            }
            catch (Exception msg)
            {
                throw new Exception(msg.ToString());  //处理异常信息  
            }

        }

        private void QQ_register_Load(object sender, EventArgs e)
        {
            PasswordTip_label1.Text = "";
            PasswordTip_label2.Text = "";
            PasswordTip_label3.Text = "";
            Repassword_label.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Name_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            IDTIP_label.ForeColor = Color.Black;
                IDTIP_label.Text = "请输入昵称!";
                
    //             Name_textBox.BorderStyle = Fixed3D;
        }

        private void Name_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_textBox.Text))
            {
                IDTIP_label.ForeColor = Color.Red;
                IDTIP_label.Text = "昵称不能为空!";
            }
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void PasswordTip_label2_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTip_label3_Click(object sender, EventArgs e)
        {

        }

        private void Password_textBox_Enter(object sender, EventArgs e)
        {
            PasswordTip_label1.Text = "长度为6-16个字符";
            PasswordTip_label2.Text = "不能是9位以下纯数字";
            PasswordTip_label3.Text = "不能包含空格";
        }

        private void Ispassword_textBox3_Enter(object sender, EventArgs e)
        {
            Repassword_label.BackColor = Color.Transparent;
            Repassword_label.Text = "请再次输入密码!";
        }

        private void Repassword_label_Enter(object sender, EventArgs e)
        {
           
        }

        private void Name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDTIP_label_Click(object sender, EventArgs e)
        {

        }

        

       
    }
}

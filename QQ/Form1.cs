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
using System.Xml;
using System.Runtime.InteropServices;

namespace QQ
{
    public partial class qqlog : Form
    {
        public qqlog()
        {
            InitializeComponent();
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

       

        

        private void register_label_Click(object sender, EventArgs e)
        {
            Form QQ_register = new QQ_register();
            QQ_register.ShowDialog();
        }

        private void qqlog_Load(object sender, EventArgs e)
        {
            Minimized_label.Text = "";
            Close_label.Text = "";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(qqlog_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(qqlog_Move);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(qqlog_MouseUp); 
            label2.Text = "";
            XmlDocument doc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释
            XmlReader reader = XmlReader.Create("User.xml", settings);
            doc.Load(reader);

            // 得到根节点Users
            XmlNode xn = doc.SelectSingleNode("Users");

            // 得到根节点的所有子节点
            XmlNodeList xnl = xn.ChildNodes;
            User user1 = new User();
            XmlElement xe;
            XmlNodeList xnll;
            //DataSet xmlds = new DataSet();
            //xmlds.ReadXml("User.xml");
            //this.log_comboBox.DataSource = xmlds.Tables["XmlNode"];
            //this.log_comboBox.DisplayMember = "user";
            //this.log_comboBox.ValueMember = "user";
            foreach (XmlNode xn1 in xnl)
            {


                xe = (XmlElement)xn1;
                xnll = xe.ChildNodes;
                user1.UserName = xnll.Item(0).InnerText;
                user1.PassWord = xnll.Item(1).InnerText;

                if (user1.UserName != "" && user1.PassWord != "")
                {
                   // this.log_comboBox.Items.Insert(0, user1.UserName);
                    this.log_comboBox.Items.Add(user1.UserName);
                    this.Password_Box.Text = user1.PassWord;
                    this.rmpassword_Button.Checked = true;
                }
                else
                {
                    this.log_comboBox.Items.Add(user1.UserName);
                    this.rmpassword_Button.Checked = false;
                }

            }
            reader.Close();

            //  用户名默认选中第一个
            if (this.log_comboBox.Items.Count > 0)
            {
                this.log_comboBox.SelectedIndex = this.log_comboBox.Items.Count - 1;
            }


        }

        private void log_button_Click(object sender, EventArgs e)
        {
            //字符串赋值:用户名 密码  
            string QQID = log_comboBox.Text.Trim();
            string Password = Password_Box.Text.Trim();

            //定义数据库连接语句:服务器=.(本地) 数据库名=QQMS
            string consqlserver = "Data Source=.;User ID=sa; Password = 1;Initial Catalog=QQMS;";

            //定义SQL查询语句:用户名 密码  
            string sql = "select * from QQ_table1 where QQID='" + QQID + "' and Password='" + Password + "'";

            //定义SQL Server连接对象 打开数据库  
            SqlConnection con = new SqlConnection(consqlserver);
            con.Open();
            
            //定义查询命令:表示对数据库执行一个SQL语句或存储过程  
            SqlCommand com = new SqlCommand(sql, con);

            //执行查询:提供一种读取数据库行的方式  
            SqlDataReader sread = com.ExecuteReader();

            try
            {
                //如果存在用户名和密码正确数据执行进入系统操作  
                if (sread.Read())
                {
                    MessageBox.Show("登录成功");
                }
                else
                {
                    MessageBox.Show("请输入正确的用户名和密码");
                }
            }
            catch (Exception msg)
            {
                throw new Exception(msg.ToString());  //处理异常信息  
            }
            finally
            {
                con.Close();                    //关闭连接  
                con.Dispose();                  //释放连接  
                sread.Dispose();                //释放资源  
            }
            if (this.rmpassword_Button.Checked)
            {
                XmlDocument xml = new XmlDocument();
        //        xml.Load("User.xml");
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreComments = true;//忽略文档里面的注释
                XmlReader reader = XmlReader.Create("User.xml", settings);
                xml.Load(reader);
                //XmlElement xe = xml.DocumentElement;
                //string strPath =string.Format("/Users/user/username")
                //if()
                //{

                //}
                //XmlDocument xmlDoc = new XmlDocument();//修改添加的一行
                //xmlDoc.Load("User.xml");//修改添加的一行

                XmlNode xn = xml.SelectSingleNode("Users");

                //// 得到根节点的所有子节点
                XmlNodeList xnl = xn.ChildNodes;
                //User user1 = new User();
                XmlElement xe;
                XmlNodeList xnll;
                int mark = 0;   //标记变量
                foreach (XmlNode xn1 in xnl)//遍歷所有子節點
                {
                    xe = (XmlElement)xn1;//將子節點類型轉換為XmlElement類型
                    xnll = xe.ChildNodes;
                    if (xnll.Item(0).InnerText == this.log_comboBox.Text)
                    {
                        mark = 1;
                        
                        break;
                    }
                }
                if(mark == 0)
                {
                    //创建一个节点
                    XmlNode stnode_1 = xml.CreateElement("username");//这里是需要创建的节点的名字  
                    stnode_1.InnerText = this.log_comboBox.Text;//这里可以设置节点中的文本 
                    XmlNode stnode_2 = xml.CreateElement("password");//这里是需要创建的节点的名字 
                    stnode_2.InnerText = this.Password_Box.Text;//这里可以设置节点中的文本 
                    XmlNode stnode = xml.CreateElement("user");//这里是需要创建的节点的名字 
                    stnode.AppendChild(stnode_1);
                    stnode.AppendChild(stnode_2);
                    xml.DocumentElement.AppendChild(stnode);
                    reader.Close();
                    xml.Save("User.xml");
                }
                else reader.Close();
                
                
            }
            else this.Password_Box.Text = "";
            
        }

        private void Autolog_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void register_label_MouseMove(object sender, MouseEventArgs e)
        {
            register_label.Cursor = Cursors.Hand;
        }

        private void register_label_MouseEnter(object sender, EventArgs e)
        {
            register_label.ForeColor = Color.LightSkyBlue;
        }

        private void register_label_MouseLeave(object sender, EventArgs e)
        {
            register_label.ForeColor = Color.DodgerBlue;
        }

        private void Findpassword_label_MouseEnter(object sender, EventArgs e)
        {
            Findpassword_label.ForeColor = Color.LightSkyBlue;
        }

        private void Findpassword_label_MouseLeave(object sender, EventArgs e)
        {
            Findpassword_label.ForeColor = Color.DodgerBlue;
        }

        private void log_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void log_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void log_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释
            XmlReader reader = XmlReader.Create("User.xml", settings);
            doc.Load(reader);

            // 得到根节点Users
            XmlNode xn = doc.SelectSingleNode("Users");

            // 得到根节点的所有子节点
            XmlNodeList xnl = xn.ChildNodes;

            foreach (XmlNode xn1 in xnl)
            {
                User user1 = new User();

                XmlElement xe = (XmlElement)xn1;
                XmlNodeList xnll = xe.ChildNodes;
                if (xnll.Item(0).InnerText == this.log_comboBox.Text)
                {
                    user1.UserName = xnll.Item(0).InnerText;
                    user1.PassWord = xnll.Item(1).InnerText;
                    if (user1.UserName != "")
                    {

                        this.Password_Box.Text = user1.PassWord;
                        this.rmpassword_Button.Checked = true;
                    }
                    else
                    {
                        this.Password_Box.Text = "";
                        this.rmpassword_Button.Checked = false;
                    }
                }
                   
            }
            reader.Close();
        }

        private void Findpassword_label_MouseMove(object sender, MouseEventArgs e)
        {
            Findpassword_label.Cursor = Cursors.Hand;
        }

        private void log_button_MouseMove(object sender, MouseEventArgs e)
        {
            log_button.BackColor = Color.DodgerBlue;
        }

        private void log_button_MouseEnter(object sender, EventArgs e)
        {
            log_button.BackColor = Color.DodgerBlue;
        }

        private void log_button_MouseLeave(object sender, EventArgs e)
        {
            log_button.BackColor = Color.DeepSkyBlue;
        }
        Point mouseOff;//鼠标移动位置变量  
        private bool leftFlag;//这个用来判断鼠标左键是否按下 
        private void qqlog_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值  
                leftFlag = true;                  //点击左键按下时标注为true;  
            }  
        }

        private void qqlog_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;  
            }  
        }

        private void qqlog_Move(object sender, EventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置  
                Location = mouseSet;
                //ReleaseCapture();
                //SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
                ////               (((System.Windows.Forms.PictureBox)sender).Parent).Location = mouseSet;
            }
             
        }

        private void Close_label_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Minimized_label_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_label_Click(object sender, EventArgs e)
        {

        }

        private void Close_label_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Close_label_Click_1(object sender, EventArgs e)
        {

        }

        private void Minimized_label_MouseEnter(object sender, EventArgs e)
        {
            Minimized_label.BackColor = Color.LightSkyBlue;
        }

        private void Minimized_label_MouseLeave(object sender, EventArgs e)
        {
            Minimized_label.BackColor = Color.Transparent;
        }

        private void Close_label_MouseEnter(object sender, EventArgs e)
        {
            Close_label.BackColor = Color.LightSkyBlue;
        }

        private void Close_label_MouseLeave(object sender, EventArgs e)
        {
            Close_label.BackColor = Color.Transparent;
        }
        //[DllImport("user32.dll")]
        //public static extern bool ReleaseCapture();
        //[DllImport("user32.dll")]
        //public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        //public const int WM_SYSCOMMAND = 0x0112;
        //public const int SC_MOVE = 0xF010;
        //public const int HTCAPTION = 0x0002;

        //private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        //{
           
        //}  
        

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace GuidanceAPP
{
  
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();

        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //连接数据库
        private void SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source=sqlite.db;Version=3;New=False;Compress=True;"); 
        }

        //set executequery
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }


        //set loadDB
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from data";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();

            //SetConnection();
            //sql_con.Open();
            //sql_cmd = sql_con.CreateCommand();
            //string cfzCommandText = "select * from CFZ";
            //DB = new SQLiteDataAdapter(cfzCommandText, sql_con);
            //DS.Reset();
            //DB.Fill(DS);
            //DT = DS.Tables[0];
            //CFZcomboBox.DataSource = DT;
            //CFZcomboBox.DisplayMember = "初复诊";

        }


        //add

        private void button1_Click(object sender, EventArgs e)
        {
            //string txtQuery = "insert into data (ID,Name,Gender)values('" + IDlabel.Text + "','" + textBox2.Text + "','"+XBcombox.Text+"')";
            string txtQuery = "insert into data (Date,Diseases,Name,Gender,Age,VisitStatus,Province,City,Area,Phone,Medium,MediumC,Reservation,Clinic,Treatment,Guidance,Remarks)values('" +RQdateTimePicker.Value +"','" +BZCombox.Text +"','" +XMtextBox.Text+"','" + XBcombox.Text+ "','" +NLtextBox.Text + "','" +CFZcomboBox.Text +"','" +SFcomboBox.Text + "','" + CScomboBox.Text+ "','" + QXcomboBox.Text+"','" +DHtextBox.Text + "','" + MTcomboBox.Text+ "','" +MTFLcomboBox.Text +"','" +SFYYcomboBox.Text + "','" + ZScomboBox.Text+ "','" +SFZLtextBox.Text +"','" +DZtextBox.Text + "','" + BZtextBox.Text+ "')";
            ExecuteQuery(txtQuery);
            LoadData();
        }


        //edit
        private void button2_Click(object sender, EventArgs e)
        {
            string txtQuery = "update data set Name ='" + XMtextBox.Text + "', Gender = '"+XBcombox.Text+"' where ID='" + IDlabel.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IDlabel.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                //RQdateTimePicker.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[1].Value);
                BZCombox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                XMtextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                XBcombox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                NLtextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }


        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from data where ID='" + IDlabel.Text + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void CFZcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string cfzCommandText = "select * from CFZ";
            DB = new SQLiteDataAdapter(cfzCommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            CFZcomboBox.DataSource = DT;
            CFZcomboBox.DisplayMember = "初复诊";
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WordGame
{
    public partial class Form1 : Form
    {
        bool key = true;
        Random Random = new Random();
        int rnd;
        string answer;

        int correct_n = 0;
        int timer = 30;
     
        public Form1()
        {
            InitializeComponent();
        }

        string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gokay\\Documents\\DBDict.accdb";

        private void btn_game_Click(object sender, EventArgs e)
        {

            if(key == true)
            {
                tr_txt.Enabled = true;

                timer1.Start();
                btn_game.Text = "Restart";
                key = false;

                game();
            }
            else if(key == false)
            {
                correct_n = 0;
                tr_txt.Enabled = true;
                tr_txt.Clear();

                timer = 30;
                timer1.Start();

                game();

            }
        }

        private void tr_txt_TextChanged(object sender, EventArgs e)
        {
            control();
        }

        private void game()
        {
            correct.Text = correct_n.ToString();

            using (OleDbConnection conn = new OleDbConnection(connection))
            {
                conn.Open();
                rnd = Random.Next(1, 2490);

                OleDbCommand cmd = new OleDbCommand("Select * from Dict where ID=@p1", conn);
                cmd.Parameters.AddWithValue("@p1", rnd);

                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    eng_txt.Text = reader[1].ToString();
                    answer = reader[2].ToString();
                }
            }
        }

        private void control()
        {
            if(answer == tr_txt.Text)
            {
                correct_n++;
                game();
                timer += 10;
                tr_txt.Clear();
                tr_txt.Focus();
            }
            else if(answer.ToLower() == tr_txt.Text)
            {
                correct_n++;
                game();
                timer += 10;
                tr_txt.Clear();
                tr_txt.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;
            time.Text = timer.ToString();

            if(timer == 0)
            {
                timer1.Stop();
                MessageBox.Show($"Game Over >> Correct: {correct_n} ");
                tr_txt.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time.Text = timer.ToString();
        }
    }
}

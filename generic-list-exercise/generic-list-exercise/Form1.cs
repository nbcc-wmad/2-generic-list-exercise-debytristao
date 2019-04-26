using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace generic_list_exercise
{
    /*Autohor: Debora Tristao
    *Date: Apr. 26/2019
    *Exercise: Generic List Exercise 1
    */

    public struct Score
    {
        public int maxpoint;
        public string gradeLetter;
    }
    public partial class Form1 : Form
    {

        //ArrayList to hold my grades
        private Score score;
        private List<Score> scoreList = new List<Score>();

        List<Score> gradesTypedList = new List<Score>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindGrade_Click(object sender, EventArgs e)
        {
            int userType = Convert.ToInt32(txtScore.Text.Trim());


            foreach (Score item in scoreList)
            {

                if (userType <= item.maxpoint)
                {
                    MessageBox.Show($"Grade is {item.gradeLetter}");
                    break;
                }

            }
          
            txtScore.ResetText();
            txtScore.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            score.maxpoint = 299;
            score.gradeLetter = "F";
            scoreList.Add(score);
            //gradesTypedList.Add(score);

            score.maxpoint = 349;
            score.gradeLetter = "D";
            scoreList.Add(score);
            //gradesTypedList.Add(score);

            score.maxpoint = 399;
            score.gradeLetter = "C";
            scoreList.Add(score);
            //gradesTypedList.Add(score);

            score.maxpoint = 449;
            score.gradeLetter = "B";
            scoreList.Add(score);
            //gradesTypedList.Add(score);

            score.maxpoint = 500;
            score.gradeLetter = "A";
            scoreList.Add(score);
            //gradesTypedList.Add(score);
        }

    }
}

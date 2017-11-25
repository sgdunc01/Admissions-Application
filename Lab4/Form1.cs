// Lab 4
// CIS 199-01/-75
// Due: 2/16/2016
// By: Spencer G. Duncan

// This program displays wether or not an applicant
// is accepted after the user enters the test score 
// and gpa. The program keeps a count of how many
// applicants have been accepted and rejected. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {

        private int numAccept = 0;// this variable is initialized at the start and keeps count of how many have been accepted
        private int numReject = 0;// this variable is initialized at the start and keeps count of how many have been rejected
        
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //Initialize variables
            const double gpaRequirement = 3.0;// stores the gpa value that is used for comparison
            const int lowTest = 60;// stores the lowest test value required with a gpa above 3.0
            const int highTest = 80;// stores the lowest test value required with a gpa bellow 3.0
            double gpa;// stores the applicants gpa
            int test;// storest the applicants test score
            
            //assign values to variables from text
            gpa = double.Parse(gpaTxt.Text);
            test = int.Parse(testTxt.Text);

            //logic statement to determine if applicant is accepted
            if ((gpa >= gpaRequirement) && (test >= lowTest))
            {
                decisionLbl.Text = "Accept";
                numAccept++;
            }
            else if ((gpa < gpaRequirement) && (test >= highTest))
            {
                decisionLbl.Text = "Accept";
                numAccept++;
            }
            else
            {
                decisionLbl.Text = "Reject";
                numReject++;
            }

            //output of the running total
            numberAccepted.Text = numAccept.ToString();
            numberRejected.Text = numReject.ToString();
        }
    }
}

// Using built-in libraries for Windows Forms and the tools within the app, including labels, buttons, text boxes, message boxes, links, etc
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name of my project where all my forms and code is stored
namespace WindowsFormsApp2
{
    // Represents a form that pops up and displays the users score
    public partial class scoreCard : Form
    {
        // Runs when the scoreCard window is created, recieves the totals of correct and wrong answers from the Sanrio Main form
        public scoreCard(int correct, int wrong)
        {
            // Sets up all the buttons, labels, textboxes, and controls
            InitializeComponent();
            // Displays the total number of correct answers on the screen recieved from the Sanrio Main window game
            lblCorrect.Text = $"Correct Answers: {correct}";
            // Displays the total number of wrong answers on the screen recieved from the Sanrio Main window game
            lblWrong.Text = $"Wrong Answers: {wrong}";
        }
    }
}

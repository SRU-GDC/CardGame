﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_q8_MNS_11_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables
        const int ROWS = 3;
        const int COLS = 3;
        readonly int[,] array = new int[ROWS, COLS];
        readonly Random rand = new Random();
        //Bools to check who won
        bool playerOWin = false;
        bool playerXWin = false;

        private void NewGamebutton_Click(object sender, EventArgs e)
        {
            bool playerOWin = false;
            bool playerXWin = false;
            Winnerlabel.Text = "";
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    array[row, col] = rand.Next(2);
                    /*Testing Output
                     * MessageBox.Show(game[row, col].ToString());*/
                }
            }

            //Assigning Values to Box: X = 1 & O = 0
            //ROW ONE
            #region
            //Row 1, Column 1
            if (array[0, 0] == 1)
            {
                C1R1.Text = "X";
            }
            else if (array[0, 0] == 0)
            {
                C1R1.Text = "O";
            }
            //Row 1, Column 2
            if (array[0, 1] == 1)
            {
                C2R1.Text = "X";
            }
            else if (array[0, 1] == 0)
            {
                C2R1.Text = "O";
            }
            //Row 1, Column 3
            if (array[0, 2] == 1)
            {
                C3R1.Text = "X";
            }
            else if (array[0, 2] == 0)
            {
                C3R1.Text = "O";
            }
            #endregion

            //ROW TWO 
            #region
            //Row 2, Column 1
            if (array[1, 0] == 1)
            {
                C1R2.Text = "X";
            }
            else if (array[1, 0] == 0)
            {
                C1R2.Text = "O";
            }
            //Row 2, Column 2
            if (array[1, 1] == 1)
            {
                C2R2.Text = "X";
            }
            else if (array[1, 1] == 0)
            {
                C2R2.Text = "O";
            }
            //Row 2, Column 3
            if (array[1, 2] == 1)
            {
                C3R2.Text = "X";
            }
            else if (array[1, 2] == 0)
            {
                C3R2.Text = "O";
            }
            #endregion

            //ROW 3
            #region
            //Row 3, Column 1
            if (array[2, 0] == 1)
            {
                C1R3.Text = "X";
            }
            else if (array[2, 0] == 0)
            {
                C1R3.Text = "O";
            }
            //Row 3, Column 2
            if (array[2, 1] == 1)
            {
                C2R3.Text = "X";
            }
            else if (array[2, 1] == 0)
            {
                C2R3.Text = "O";
            }
            //Row 3, Column 3
            if (array[2, 2] == 1)
            {
                C3R3.Text = "X";
            }
            else if (array[2, 2] == 0)
            {
                C3R3.Text = "O";
            }
            #endregion



            //Checking Who Won (Horizontally across the board) : X = 1 & O = 0

            /* Row (R) Column (C) [R,C]
             * Check if [0,0] is equal to 0 & check in [0,1] & [0,2] are equal to [0,0]
             * Check if [1,0] is equal to 0 & check in [1,1] & [1,2] are equal to [1,0]
             * Check if [2,0] is equal to 0 & check in [2,1] & [2,2] are equal to [2,0]
             */
            //PLAYER "O" WINS
            if (array[0, 0] == 0 && (array[0, 0] == array[0, 1]) && (array[0, 0] == array[0, 2]) || (array[1, 0] == 0 && (array[1, 0] == array[1, 1]) && (array[1, 0] == array[1, 2])) || (array[2, 0] == 0 && (array[2, 0] == array[2, 1]) && (array[1, 0] == array[2, 2])))
            {
                playerOWin = true;
            }
            /* Row (R) Column (C) [R,C]
             * Check if [0,0] is equal to 0 & check in [1,0] & [2,0] are equal to [0,0]
             * Check if [0,1] is equal to 0 & check in [1,1] & [2,1] are equal to [0,1]
             * Check if [0,2] is equal to 0 & check in [1,2] & [2,2] are equal to [2,0]
             */
            //PLAYER "X" WINS
            if (array[0, 0] == 1 && (array[0, 0] == array[0, 1]) && (array[0, 0] == array[0, 2]) || (array[1, 0] == 1 && (array[1, 0] == array[1, 1]) && (array[1, 0] == array[1, 2])) || (array[2, 0] == 1 && (array[2, 0] == array[2, 1]) && (array[1, 0] == array[2, 2])))
            {
                playerXWin = true;
            }
            //Checking Who Won (Vertically across the board) : X = 1 & O = 0
            //PLAYER "O" WINS
            if (array[0, 0] == 0 && (array[0, 0] == array[1, 0]) && (array[0, 0] == array[2, 0]) || (array[0, 1] == 0 && (array[0, 1] == array[1, 1]) && (array[0, 1] == array[2, 1])) || (array[0, 2] == 0 && (array[0, 2] == array[1, 2]) && (array[0, 2] == array[2, 2])))
            {
                playerOWin = true;
            }
            //PLAYER "X" WINS
            if (array[0, 0] == 1 && (array[0, 0] == array[1, 0]) && (array[0, 0] == array[2, 0]) || (array[0, 1] == 1 && (array[0, 1] == array[1, 1]) && (array[0, 1] == array[2, 1])) || (array[0, 2] == 1 && (array[0, 2] == array[1, 2]) && (array[0, 2] == array[2, 2])))
            {
                playerXWin = true;
            }

            //Returning value to the winner label
            if (playerXWin == true && playerOWin == true)
            {
                Winnerlabel.Text = ("The game is a Tie");
            }
            else if (playerXWin == false && playerOWin == false)
            {
                Winnerlabel.Text = ("The game is a Tie");
            }
            else if (playerOWin == true && playerXWin == false)
            {
                Winnerlabel.Text = ("Player O is the Winner!");
            }
            else if (playerXWin == true && playerOWin == false)
            {
                Winnerlabel.Text = ("Player X is the Winner!");
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            //Closes out of form application
            Close();
        }
    }
}

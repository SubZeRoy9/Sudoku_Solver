using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaeringProject
{
    public partial class Form1 : Form
    {
        /************************variables we will be using*****************/
        static int BOARD_SIZE = 9;
        int[,] board = new int[9, 9]
        {
            {5, 3, 0, 0, 7, 0, 0, 0, 0},
            {6, 0, 0, 1, 9, 5, 0, 0, 0},
            {0, 9, 8, 0, 0, 0, 0, 6, 0},
            {8, 0, 0, 0, 6, 0, 0, 0, 3},
            {4, 0, 0, 8, 0, 3, 0, 0, 1},
            {7, 0, 0, 0, 2, 0, 0, 0, 6},
            {0, 6, 0, 0, 0, 0, 2, 8, 0},
            {0, 0, 0, 4, 1, 9, 0, 0, 5},
            {0, 0, 0, 0, 8, 0, 0, 7, 9}
        };

        //Driver Code
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            button1.Click += button1Clicked; //Easy more concise and readable way to make event handler
        }

        //Initialize the datagridview here
        public void InitializeDataGridView()
        {
            //Sets rows and columns of datagrid to 9x9. 
            dataGridView1.RowCount = BOARD_SIZE;
            dataGridView1.ColumnCount = BOARD_SIZE;
            
            
            //nested for loop goes through the board and assignes it to that position in the datagrid. 
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = board[i, j];
                    dataGridView1.Rows[i].Height = 30; //sets size
                    dataGridView1.Columns[i].Width = 30; // sets size
                }
            }
        }
        //***********************Holy Crap it works. Good job Roy****************************//

        //***********************************************Sudoku Solver logic***********************************************//
        //If number exists in row return true
        static Boolean isNumberInRow(int[,] board, int number, int row)
        {
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                if (board[row, i] == number)
                {
                    return true;
                }
            }
            return false;
        }

        //if number exists in column return true
        static Boolean isNumberInColumn(int[,] board, int number, int column)
        {
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                if (board[i, column] == number)
                {
                    return true;
                }
            }
            return false;

        }

        //3x3 box so modulo 3 returns location of top left position in local box. 
        static Boolean isNumberInBox(int[,] board, int number, int row, int column)
        {
            int localBoxRow = row - row % 3; //for example if we use row 4. 4 % 3 is 1. 4 = 1 is 3.
            int localBoxColumn = column - column % 3; //if number is 5. 5 % 3 is 2. 5 - 2 is 3. this function always gives us top left corner. 

            for (int i = localBoxRow; i < localBoxRow + 3; i++)
            {
                for (int j = localBoxColumn; j < localBoxColumn + 3; j++) //traverses local box. 
                {
                    if (board[i, j] == number)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Uses isNumberInRow, isNumberInColumn, isNumberInBox to decide if it is valid placement. If all methods return false, then it is valid. 
        static Boolean isValidPlacement(int[,] board, int number, int row, int column)
        {
            return !isNumberInRow(board, number, row) &&
                !isNumberInColumn(board, number, column) &&
                !isNumberInBox(board, number, row, column);
        }

        //Solver logic.
        static Boolean solveBoard(int[,] board)
        {
            for (int row = 0; row < BOARD_SIZE; row++)
            {
                for (int column = 0; column < BOARD_SIZE; column++)
                {
                    if (board[row, column] == 0)
                    {
                        for (int numberToTry = 1; numberToTry <= BOARD_SIZE; numberToTry++)
                        {
                            if (isValidPlacement(board, numberToTry, row, column))
                            {
                                board[row, column] = numberToTry;

                                if (solveBoard(board))
                                {
                                    return true;
                                }
                                else
                                {
                                    board[row, column] = 0;
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private void populateWithSolution()
        {
            if (solveBoard(board)) {

                for (int i = 0; i < BOARD_SIZE; i++)
                {
                    for (int j = 0; j < BOARD_SIZE; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = board[i, j];
                        dataGridView1.Rows[i].Height = 30; //sets size
                        dataGridView1.Columns[i].Width = 30; // sets size
                    }
                }

            }
            else
            {
                System.Console.Write("unsolvable");
            }
        }

        private void button1Clicked(object sender, EventArgs e)
        {
            populateWithSolution();
        }
    }
}

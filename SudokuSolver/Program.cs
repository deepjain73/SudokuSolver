﻿using SudokuSolver.Strategies;
using SudokuSolver.Workers;
using System;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SudokuMapper sudokuMapper = new SudokuMapper();
                SudokuBoardStateManager sudokuBoardStateManager = new SudokuBoardStateManager();
                SudokuSolverEngine sudokuSolverEngine = new SudokuSolverEngine(sudokuBoardStateManager,sudokuMapper);
                SudokuFileReader sudokuFileReader = new SudokuFileReader();
                SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();

                Console.WriteLine("Please enter the filename containing the sudoku puzzle:");
                var filename = Console.ReadLine();

                var sudokuBoard = sudokuFileReader.ReadFile(filename);
                sudokuBoardDisplayer.Display("Initial State", sudokuBoard);

                bool isSudokuSolved = sudokuSolverEngine.Solve(sudokuBoard);
                sudokuBoardDisplayer.Display("Final State", sudokuBoard);

                Console.WriteLine(isSudokuSolved ? "You have successfully solved this sudoku puzzle!" : "unfortunately, current algorithm(s) were not enough to solve the current sudoku puzzle!");

            }

            catch(Exception ex)
            {
                // In real world we would want to log this message
                Console.WriteLine("{0} : {1}", "Sudoku Puzzle cannot be solved because there was an error:", ex.Message);
            }
        }
    }
}

using SudokuSolver.Workers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver.Strategies
{
    class NakedPairStrategy : ISudokuStrategy
    {
        private readonly SudokuMapper _sudokuMapper;

        public NakedPairStrategy(SudokuMapper sudokuMapper)
        {
            _sudokuMapper = sudokuMapper;
        }

        public int[,] Solve(int[,] sudokuBoard)
        {
            for (int row = 0; row < sudokuBoard.GetLength(0); row++)
            {
                for (int col = 0; col < sudokuBoard.GetLength(1); col++)
                {
                    EliminateNakedPairFromOthersInRow(sudokuBoard, row, col);
                    EliminateNakedPairFromOthersInCol(sudokuBoard, row, col);
                    EliminateNakedPairFromOthersInBlock(sudokuBoard, row, col);

                }
            }

            return sudokuBoard;
        }

        private void EliminateNakedPairFromOthersInRow(int[,] sudokuBoard, int row, int col)
        {
            throw new NotImplementedException();
        }


        private void EliminateNakedPairFromOthersInCol(int[,] sudokuBoard, int row, int col)
        {
            throw new NotImplementedException();
        }

        private void EliminateNakedPairFromOthersInBlock(int[,] sudokuBoard, int row, int col)
        {
            throw new NotImplementedException();
        }

        
     
    }
}

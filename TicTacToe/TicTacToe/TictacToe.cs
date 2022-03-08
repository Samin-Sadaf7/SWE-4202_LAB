using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal static class TictacToe
    {
        public static string[,] arr=new string[3,3];
        public static bool WinGame(int i,int j)
        {   
            if(arr[0,j]==arr[1,j] && arr[2, j] == arr[1, j] && (arr[0,j]=="X"|| arr[0,j]=="O"))
            {
                return true;
            }
            else if(arr[i,1]==arr[i,2] && arr[i, 2] == arr[i, 0] && (arr[i, 0] == "X" || arr[i, 0] == "O"))
            {
                return true;
            }
            else if(i==2 && j==2 && (arr[i, j] == arr[i - 1, j - 1]) && (arr[i - 1, j - 1] == arr[i - 2, j - 2]) && (arr[i, j] == "X" || arr[i, j] == "O"))
            {
                return true;
            }
            else if (i == 1 && j == 1 && (arr[i, j] == arr[i - 1, j - 1]) && (arr[i + 1, j + 1] == arr[i - 1, j - 1]) && (arr[i, j] == "X" || arr[i, j] == "O"))
            {
                return true;
            }
            else if (i == 0 && j == 2 && (arr[i, j] == arr[i + 1, j - 1]) && (arr[i + 2, j - 2] == arr[i , j]) && (arr[i, j] == "X" || arr[i, j] == "O"))
            {
                return true;
            }
            else if (i == 1 && j == 1 && (arr[i, j] == arr[i - 1, j + 1]) && (arr[i + 1, j - 1] == arr[i- 1, j+1]) && (arr[i, j] == "X" || arr[i, j] == "O"))
            {
                return true;
            }
            else if (i == 2 && j == 0 && (arr[i, j] == arr[i - 1, j +1]) && (arr[i -2, j + 2] == arr[i - 1, j + 1]) && (arr[i, j] == "X" || arr[i, j] == "O"))
            {
                return true;
            }
            else if (i == 0 && j == 0 && (arr[i, j] == arr[i + 1, j + 1]) && (arr[i + 1, j + 1] == arr[i + 2, j + 2]) && (arr[i, j] == "X" || arr[i, j] == "O"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Check_Game()
        {
            for (int i = 0;i < 3; i++){
                for(int j = 0; j < 3; j++)
                {
                    if(arr[i,j]!="X" && arr[i,j]!="O")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static int Winner(Player pl1, Player pl2)
        {
            if (pl1.point > pl2.point)
            {
                return 1;
            }
            else if(pl2.point > pl1.point)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        public static void ArrayRefresh()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j=0; j < 3; j++)
                {
                    arr[i, j] = " ";
                }
            }
        }

    }
}

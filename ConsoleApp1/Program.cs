using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        const int row = 17;
        const int column = 13;
        static void Main(string[] args)
        {
            int horizontalCount = (row * 2) - 1;
            Atom[,] atoms= new Atom[row, horizontalCount];

            int index = 1;
            for (int columnIndex = row-1; columnIndex >= 0; columnIndex--)
            {
                for (int j = 0; j < column; j++)
                {
                    int r = columnIndex - j;
                    if (r<0)
                    {
                        break;
                    }
                    
                    int y = row - j;
                    atoms[r, columnIndex] = new Atom() { value=j+1,modified=true };

                    y = row - j;
                    atoms[r, horizontalCount-columnIndex-1] = new Atom() { value = j + 1, modified = true };
                    index++;
                }
                index = 0;


            }
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < horizontalCount; j++)
                {
                    if (atoms[i, j] != null)
                    {
                        if (atoms[i, j].value<10)
                        {
                            stringBuilder.Append(" ");
                            stringBuilder.Append(atoms[i, j].value.ToString());
                        }
                        else
                        {
                            stringBuilder.Append(atoms[i, j].value.ToString());
                        }
                    }
                    else
                    {
                        stringBuilder.Append("  ");
                    }
                }
                stringBuilder.Append("\r\n");
            }
            Console.WriteLine(stringBuilder.ToString());
            Console.ReadKey();
        }
        class Atom
        {
           public int value = -1;
           public bool modified = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TreeExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new TreeExpression.Tree();
            string expression = System.IO.File.ReadAllText("expression.txt");
            Console.WriteLine(expression);
            Read.ReadExpressionFromString(tree, expression);
            var i = tree.CountTree();
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}

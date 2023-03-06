using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCaseNo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "1. Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu program komputer yang dapat mengenali, meringkas, menerjemahkan, memprediksi, dan menghasilkan teks";

            Console.WriteLine(message); 
            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            openingPosition += 1;

            int length = closingPosition - openingPosition;
            Console.Write("Output: ");
            Console.WriteLine(message.Substring(openingPosition, length));
        }
    }
}

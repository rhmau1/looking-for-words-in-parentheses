using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyCaseNo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "2. Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu program komputer yang dapat (mengenali), (meringkas), (menerjemahkan), (memprediksi), dan (menghasilkan teks)";
            Console.WriteLine(message); 
            Console.WriteLine("Output:");

            while (true)
            {
                int openingPosition = message.IndexOf('(');
                if (openingPosition == -1) break;

                openingPosition += 1;
                int closingPosition = message.IndexOf(')');
                int length = closingPosition - openingPosition;
                Console.WriteLine($"-{message.Substring(openingPosition, length)}");
                
                message = message.Substring(closingPosition + 1);
            }
        }
    }
}

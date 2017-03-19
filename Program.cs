using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PatchSearch
{
// teste teste
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                return;
            }

            // obter todos os arquivos da pasta
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());

            foreach (var item in files) //teste
            {
                using (StreamReader reader = new StreamReader(item))
                {
                    string fileContent = reader.ReadToEnd();

                    int qt = 0;//teste 7

                    foreach (var term in args)
                    {
                        if (fileContent.Contains(term))
                        {
                            qt++;
                        }
                    }

                    if (qt == args.Length)
                    {
                        Console.WriteLine(Path.GetFileName(item));
                    }
                }
            }
        }
    }
}
//teste c
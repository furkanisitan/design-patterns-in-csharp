using System;
using System.IO;

namespace Command
{
    public class Kernel
    {
        public void DirListAPI(string path)
        {
            if (string.IsNullOrEmpty(path))
                Console.WriteLine("List command requires a valid path!");
            else
            {
                string[] files = Directory.GetFiles(path);
                foreach (var f in files)
                    Console.WriteLine(f);
            }
        }

        public void MkDirAPI(string path)
        {
            Directory.CreateDirectory(path);
        }

        public void DeleteAPI(string path)
        {
            File.Delete(path);
        }

        public void QuitAPI()
        {
            Console.WriteLine("-------- FreeCSD ---------");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}

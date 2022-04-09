using AnimaisAPI.Models;

namespace AnimaisAPI.Service
{
    public class CriaGato
    {
        public void create()
        {
            string path = @"C:\Users\lucas\OneDrive\Área de Trabalho\GOCASHLESS\animais.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("This");
                sw.WriteLine("is Extra");
                sw.WriteLine("Text");
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}

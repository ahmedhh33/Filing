namespace Fileing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String filename = "SometextfileWithoutUsing.txt";
            WritingfileWithoutUsing(filename);
            String ffilename = "SometextfileWitUsing.txt";
            WritingfileWithUsing(ffilename);
        }
        private static void WritingfileWithoutUsing(String filename)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(filename);
                writer.WriteLine("Hello Word");
                Console.WriteLine("The Writing in file completed");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                writer.Flush();//delet the buffer becouse it just have 1024 bites
                writer.Close();//closing file
            }
        }
        private static void WritingfileWithUsing(String filename)
        {
            
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine("Hello Word WITH USING S");
                }
                Console.WriteLine("The Writing in file completed");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

    }

}
using System;
namespace SkillFactoryCSharp10Interfaces
{
    public interface IWriter
    {
        void Write();
    }

    public interface IReader
    {
        void Read();
    }

    public interface IMailer
    {
        void SendEmail();
    }

    public class FileManager : IWriter, IReader, IMailer
    {
        public void Write() { }

        public void Read() { }

        public void SendEmail() { }

    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Console.ReadKey();
        }
    }
}
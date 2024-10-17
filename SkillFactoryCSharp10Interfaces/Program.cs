using System;
namespace SkillFactoryCSharp10Interfaces
{
    public class Manager : IManager
    {
        public void Create()
        {

        }

        public void Read()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }

    public class Writer : IWriter
    {
        void IWriter.Write()
        {

        }
    }

    public class Worker : IWorker
    {
        void IWorker.Build()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Writer writer = new Writer();

            // ((IWriter)writer).Write();

            Worker worker = new Worker();
            ((IWorker)worker).Build();

            Console.ReadKey();
        }
    }
}
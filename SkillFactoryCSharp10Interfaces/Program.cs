using System;
namespace SkillFactoryCSharp10Interfaces
{
    public interface ICreatable
    {
        void Create();
    }

    public interface IDeletable
    {
        void Delete();
    }

    public interface IUpdatable
    {
        void Update();
    }

    public class Entity : ICreatable, IDeletable, IUpdatable
    {
        public void Create()
        {

        }

        public void Delete()
        {

        }

        public void Update()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Console.ReadKey();
        }
    }
}
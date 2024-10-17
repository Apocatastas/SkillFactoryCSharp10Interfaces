using System;
namespace SkillFactoryCSharp10Interfaces
{
    public interface IBook
    {
        void Read();
    }

    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }

    public class ElectronicBook : IBook, IDevice
    {
        void IBook.Read()
        {

        }

        void IDevice.TurnOn()
        {

        }

        void IDevice.TurnOff()
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
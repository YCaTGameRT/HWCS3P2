using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCS3P2 {
    class Program {
        static void Main(string[] args) {
            string FName, FAuthor, FPublisher;
            int FYear, FVolume;
            Console.Write("Введите название\n>>: ");
            FName = Console.ReadLine();
            Console.Write("Введите автора\n>>: ");
            FAuthor = Console.ReadLine();
            Console.Write("Введите год выпуска\n>>: ");
            FYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите объем в листах\n>>: ");
            FVolume = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите издательство\n>>: ");
            FPublisher = Console.ReadLine();
            Console.Write("\n");
            FeaturesBooks FBook = new FeaturesBooks(FName, FAuthor, FYear, FVolume, FPublisher);

            string MName, MAuthor, MPublisher;
            int MYear, MVolume;
            Console.Write("Введите название\n>>: ");
            MName = Console.ReadLine();
            Console.Write("Введите автора\n>>: ");
            MAuthor = Console.ReadLine();
            Console.Write("Введите год выпуска\n>>: ");
            MYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите объем в листах\n>>: ");
            MVolume = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите издательство\n>>: ");
            MPublisher = Console.ReadLine();
            Console.Write("\n");
            MethodBooks MBook = new MethodBooks(MName, MAuthor, MYear, MVolume, MPublisher);

            string name, author, publisher;
            int year, volume;
            Console.Write("Введите название\n>>: ");
            name = Console.ReadLine();
            Console.Write("Введите автора\n>>: ");
            author = Console.ReadLine();
            Console.Write("Введите год выпуска\n>>: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите объем в листах\n>>: ");
            volume = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите издательство\n>>: ");
            publisher = Console.ReadLine();
            Console.Write("\n");
            MethodBooks IDKBook = new MethodBooks(name, author, year, volume, publisher);

            Console.Write(FBook.Information() + "\n");
            Console.Write(MBook.Information() + "\n");
            Console.Write("\n");

            FBook.Name = "Who";
            //FBook.Author = "Am";
            FBook.Year = 2000;
            FBook.Volume = 200;
            //FBook.Publisher = "CaT";

            MBook.SetName("Cool");
            MBook.SetYear(2010);
            MBook.SetVolume(800);

            Console.Write(FBook.Name + "\n");
            Console.Write(FBook.Author + "\n");
            Console.Write(FBook.Year + "\n");
            Console.Write(FBook.Volume + "\n");
            Console.Write(FBook.Publisher + "\n");
            Console.Write("\n");

            Console.Write(MBook.GetName() + "\n");
            Console.Write(MBook.GetAuthor() + "\n");
            Console.Write(MBook.GetYear() + "\n");
            Console.Write(MBook.GetVolume() + "\n");
            Console.Write(MBook.GetPublisher() + "\n");
            Console.Write("\n");

            Console.ReadKey();
        }
    }
}

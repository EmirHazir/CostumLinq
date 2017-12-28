using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLinq
{

    class Musteri
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Musteri[] _musteriler = new Musteri[]
            {
                new Musteri
                {
                    Name = "Emir",
                    LastName = "Hazır"
                },
                new Musteri
                {
                    Name = "Can",
                    LastName = "Hazır"
                },
                new Musteri
                {
                    Name = "Aziz",
                    LastName = "Can"
                },
                new Musteri
                {
                    Name = "Mustafa",
                    LastName = "Yakup"
                },
            };

            var _adlar = _musteriler.Sec(m => new
            {
                m.Name
            });
            foreach (var item in _adlar)
            {
                Console.WriteLine(item.Name);
            }

            var _adlar1 = _musteriler.Sorgu(x => x.Name.Contains("a"));
            foreach (var item in _adlar1)
            {
                Console.WriteLine(item.Name);
            }
            string[] _isimler = new string[]
            {
                "Emir",
                "Aziz",
                "Cem",
                "Ece"
            };
            bool _controlVarMi = _isimler.VarMi((o) => o == "Emir");
            if (_controlVarMi)
            {
                Console.WriteLine(_controlVarMi + " geldi");
            }
         
            Console.ReadKey();
        }
    }
}

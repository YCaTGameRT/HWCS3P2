using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCS3P2 {
    class FeaturesBooks {
        private string _name, _author;
        private int _year, _volume;

        public FeaturesBooks(string name, string author, int year, int volume, string publisher) {
            Name = name;
            _author = author;
            Year = year;
            Volume = volume;
            Publisher = publisher;
        }

        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public string Author {
            get { return _author; }
        }
        public int Year {
            get { return _year; }
            set { _year = value; }
        }
        public int Volume {
            get { return _volume; }
            set { _volume = value; }
        }
        public string Publisher { get; private set; }

        public string Information() {
            return "Название: " + _name + "; атор: " + _author + "; год выпуска: " + _year + "; объем в листах: " + _volume + "; издательство: " + Publisher;
        }
    }
}

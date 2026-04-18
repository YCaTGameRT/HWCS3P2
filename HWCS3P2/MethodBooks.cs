using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCS3P2 {
    class MethodBooks {
        private string _name, _author, _publisher;
        private int _year, _volume;

        public MethodBooks(string name, string author, int year, int volume, string publisher) {
            SetName(name);
            _author = author;
            SetYear(year);
            SetVolume(volume);
            SetPublisher(publisher);
        }

        public void SetName(string name) {
            _name = name;
        }
        public string GetName() {
            return _name;
        }

        public string GetAuthor() {
            return _author;
        }

        public void SetYear(int year) {
            _year = year;
        }
        public int GetYear() {
            return _year;
        }

        public void SetVolume(int volume) {
            _volume = volume;
        }
        public int GetVolume() {
            return _volume;
        }

        private void SetPublisher(string publisher) {
            _publisher = publisher;
        }
        public string GetPublisher() {
            return _publisher;
        }

        public string Information() {
            return "Название: " + _name + "; атор: " + _author + "; год выпуска: " + _year + "; объем в листах: " + _volume + "; издательство: " + _publisher;
        }
    }
}

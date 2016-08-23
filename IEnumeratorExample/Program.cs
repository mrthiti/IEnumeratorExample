using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorExample {
    class Program {
        static void Main(string[] args) {

            Month objMonth = new Month();

            foreach (string item in objMonth) {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }

    class Month : IEnumerable {

        public string[] arrMonth = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public IEnumerator GetEnumerator() {
            return new AllMonth(this);
        }
    }

    class AllMonth : IEnumerator {

        private Month _month;
        private int index = -1;

        public AllMonth(Month inMonth) {
            _month = inMonth;
        }

        public object Current {
            get {
                return _month.arrMonth[index];
            }
        }

        public bool MoveNext() {
            index++;
            if (index < _month.arrMonth.Length) {
                return true;
            } else {
                return false;
            }
        }

        public void Reset() {
            index = -1;
        }
    }
}

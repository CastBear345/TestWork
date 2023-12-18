using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG
{
    public class PublicClass
    {
        public PublicClass() { }

        public PublicClass(string str) {
            Property = str;
        }

        private string field;

        public string Property { get; set; }

        public void VoidMethod() {
            int result = IntMethod(90);
        }

        public void VoidMethod(int result) { }

        private int IntMethod(int i) {
            return i;
        }

        public static string Print(string str) {
            return str;
        }
    }
}

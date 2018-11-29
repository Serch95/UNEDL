using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions {
    class DB {
        public DB(int edad) {
            if (edad > 100) {
                throw new ExceptionEdad();
            }
        }
    }
}

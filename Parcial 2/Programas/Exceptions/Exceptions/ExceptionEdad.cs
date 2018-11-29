using System;
using System.Runtime.Serialization;

namespace Exceptions {
    [Serializable]
    class ExceptionEdad : Exception{
        public ExceptionEdad() {
            Console.WriteLine("No se pueden tener tantos anios");
        }


        public ExceptionEdad(string message)
            : base(message) {
            Console.WriteLine("No se pueden tener tantos anios");
        }

        public ExceptionEdad(string message, Exception innerException)
            : base(message, innerException) {
            Console.WriteLine("No se pueden tener tantos anios");
        }
    }

    
}

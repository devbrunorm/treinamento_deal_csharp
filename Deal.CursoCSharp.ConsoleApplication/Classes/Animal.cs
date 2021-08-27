using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Classes
{
    public abstract class Animal
    {
        public string coleira;
        public string pelo;
        public string olhos;

        public abstract void Latir();

        public string Correr()
        {
            return "Animal está correndo";
        }
    }
}

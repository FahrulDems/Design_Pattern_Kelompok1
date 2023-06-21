using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern;

public class Singleton
{
    private static Singleton? _singleton; //atribut
    private Singleton() //constructor
    {
        Console.WriteLine("Get Instance");
    }

    public static Singleton GetInstance()
    {
        if (_singleton == null) 
        {
            _singleton = new Singleton();
        }

        return _singleton;
    }
}

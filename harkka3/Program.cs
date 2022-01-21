using System;

namespace harkka3
{
    class Program
    {
        static void Main(string[] args)
        {
            Käyttäjä harkka3 = new Käyttäjä();

            harkka3.UserInstruction();
            harkka3.CreateUser();
            harkka3.CheckUser();
            harkka3.UserQuery();

        }

    }
}


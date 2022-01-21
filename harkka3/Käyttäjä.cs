using System;

namespace harkka3
{
    //Käyttäjän ominaisuudet
    public class Käyttäjä
    {
        public string UserName { private get; set; }
        public string Password { private get; set; }
        string key;
        string _username;
        string _password;
        string _password2;

        //------------------------------------------------------------------------------------------------------------

        //Konstruktori käyttäjälle
        public Käyttäjä()
        {
            UserName = _username;
            Password = _password;
            Password = _password2;
        }

        //------------------------------------------------------------------------------------------------------------

        //Metodiviidakko

        public void UserInstruction()       //Ohjeet tunnuksen luomiseen
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("--Ohje käyttäjätunnuksen luomiseen--");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Anna pyydettäessä tunnus ja salasana. Luotu tunnus toimii käyttäjätilinäsi");
            Console.WriteLine();

            Console.WriteLine("Jatka painamalla Y");
            Console.WriteLine();

            key = Console.ReadLine();
            Console.WriteLine();

            if (key == "Y" || key == "y")
            {
                Console.WriteLine("Siirrytään tunnuksen luomiseen");
                Console.WriteLine();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        //------------------------------------------------------------------------------------------------------------

        public void CreateUser()        //Tunnuksen ja salasanan luominen
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("--Luodaan käyttäjätunnus--");
            Console.WriteLine("---------------------------");

            Console.Write("Aseta käyttäjätunnus: ");
            UserName = Console.ReadLine();

            Console.Write("Aseta salasana: ");
            Password = Console.ReadLine();

            Console.Write("Aseta salasana uudelleen: ");
            _password2 = Console.ReadLine();
            Console.WriteLine();

            if (_password2 != Password)
            {
                Console.WriteLine("Salasanat eivät täsmää!");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine($"Käyttäjä: {UserName} luotu");
            }

            Console.WriteLine();
        }

        //------------------------------------------------------------------------------------------------------------

        public void CheckUser()     //Kirjautuminen ja heitto tunnuksen tarkistamiseen
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("--Kirjautuminen--");
            Console.WriteLine("---------------------------");

            Console.Write("Anna käyttäjätunnus: ");

            _username = Console.ReadLine();

            Console.Write("Anna salasana: ");

            _password = Console.ReadLine();
            Console.WriteLine();

            if (_username == UserName && _password == Password)
            {
                Console.WriteLine("> Kirjautuminen onnistui");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Väärä käyttäjätunnus tai salasana");
                Console.WriteLine();
            }
        }

        //------------------------------------------------------------------------------------------------------------

        public void UserQuery()     //Tunnuksen tarkistaminen
        {
            if (_username != UserName || _password != Password)

                Console.WriteLine("Kyselläänkö käyttäjätunnusta Y/N ?");
            Console.WriteLine();

            key = Console.ReadLine();

            if (key == "Y" || key == "y")
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("--Käyttäjä kysely--");
                Console.WriteLine("---------------------------");

                string ThreeLastCharacters = UserName;
                Console.WriteLine($"Käyttäjänimi loppuu: {ThreeLastCharacters = ThreeLastCharacters.Substring(ThreeLastCharacters.Length - 3)} ");
                Console.WriteLine("Salasana: ********");
            }

        }
    }
}





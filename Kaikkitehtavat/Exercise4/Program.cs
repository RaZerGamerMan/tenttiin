using System;
// 4 c) Luo pääohjelmaan aliohjelma, johon voi syöttää parametreina useamman Character luokan. Ohjelma kutsuu annetuista olioista Character luokan PrintInformation() funktiota.
// for(...) loop tai
// foreach(...) suositeltava tässä käytettäväksi.


// 5b) Päivitä edellisen tehtävän pääohjelmaa siten,
// että käytät kaikkia hahmojen luomiseen toteutettuja konstruktoreita. Katso miten ohjelma toimii käyttämällä Visual Studion debugger työkalua.
namespace Exercise45
{
    class Program
    {
        static void Main(string[] args)
        {
            Character C1, C2, C3;
            C1 = new Character("");
            C2 = new Character("Pekka");
            C3 = new Character("Jussi", 2, 5);

            C1.name = "Jurmo";
            C1.SetLocation(0, 5);
            C2.SetLocation(1, 3);

            // Get all informations about created character objects

            CharacterInfo(C1, C2, C3);

        }
        static void CharacterInfo(params Character[] Characters)
        {
            foreach (Character character in Characters)
            {
                character.PrintInformation();
            }
        }
    }
}

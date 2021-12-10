using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using Figgle;

namespace SmallRPG
{
    class Game
    {

        private Pelaaja CurrentPlayer;
        private Character CurrentEnemy;
        private List<Character> Enemies;
        

        public Game()
        {
            
            Mies jorma = new Mies("Jorma", 10, ConsoleColor.Blue, 2);

            Mies seppo = new Mies("Seppo", 20, ConsoleColor.DarkGreen, 4);
            
            Mies2 raimo = new Mies2("Raimo", 25, ConsoleColor.Red, true);

            // Polymorfismia
            Enemies = new List<Character>() { jorma, seppo, raimo };
            

        }


        public void Run()
        {
            RunIntro();

            for (int i = 0; i < Enemies.Count; i += 1)
            {
                CurrentEnemy = Enemies[i];
                IntroCurrentEnemy();
                BattleCurrentEnemy();

                if (CurrentPlayer.IsDead)
                {
                    WriteLine("Menetät tajuntasi...");
                    WaitForKey();
                    break;
                }
                else
                {
                    WriteLine($"{CurrentEnemy.Name} päihitetty");
                    WaitForKey();
                }
            }

            RunGameOver();
        }

        private void RunIntro()
        {
            WriteLine(FiggleFonts.Ogre.Render("Suuri Baaritaistelu"));


            Write("Mikäs sinun nimesi on? ");
            string name = ReadLine();
            CurrentPlayer = new Pelaaja(name, 50, ConsoleColor.DarkCyan);

            ForegroundColor = ConsoleColor.Green;
            WriteLine(@"Olet tehnyt raskaan työpäivän ja olet lempibaarisi edessä. Mikään ei tuntuisi nyt paremmalta, kuin kylmä huurteinen!
_____________________________________________________
(                         .sssssssss.               )
(                   .sssssssssssssssssss            )
(                 sssssssssssssssssssssssss         )
(                ssssssssssssssssssssssssssss       )
(                 @@sssssssssssssssssssssss@ss      )
(                 |s@@@@sssssssssssssss@@@@s|s      )
(          _______|sssss@@@@@sssss@@@@@sssss|s      )
(        /         sssssssss@sssss@sssssssss|s      )
(       /  .------+.ssssssss@sssss@ssssssss.|       )
(      /  /       |...sssssss@sss@sssssss...|       )
(     |  |        |.......sss@sss@ssss......|       )
(     |  |        |..........s@ss@sss.......|       )
(     |  |        |...........@ss@..........|       )
(      \  \       |............ss@..........|       )
(       \  '------+...........ss@...........|       )
(        \________ .........................|       )
(                 |.........................|       )
(                /...........................\      )
(               |.............................|     )
(                  |.......................|        )
(                      |...............|            )
(___________________________________________________)                         
                        (/)
                       (/)
                 ,#####,
                 #_   _#
                 |a` `a|
                 |  u  |
                 \  =  /
                 |\___/|
        ___ ____/:     :\____ ___
      .'   `.-===-\   /-===-.`   '. 
");
            ResetColor();
            WaitForKey();

            Clear();
            WriteLine($@"Päätät astua sisälle baariin, mutta muutama juoppo katselee sinua oudosti.
Kolme juoppoa nousee pöydästään ja lähestyy sinua. He huutelevat sinulle epäsoveliaasti ja he vaikuttavat agressiivisilta.
Sinulla on ollut pitkä työpäivä takana ja menetät malttisi, kun juoppo heittää olutta housuillesi.
Portsaria tai poliisia ei ole lähimaillakaan, joten päätät ottaa oikeuden omiin käsiisi. 
Vastassassi on nyt {Enemies.Count} juoppoa...
");
            CurrentPlayer.DisplayInfo();
            WaitForKey();
        }

        private void RunGameOver()
        {
            Clear();
            if (CurrentPlayer.IsDead)
            {
                WriteLine($@"{FiggleFonts.Epic.Render("Nyt kävi huonosti...")}
Olet päihitetty ja baaritappelusi päättyi tähän. Baarin henkilökunta soittaa ambulanssin ja sinut viedään sairaalaan.
Yritä uudestaan paremmalla onnella!
");
            }
            else
            {
                WriteLine($@"{FiggleFonts.Epic.Render("Onneksi olkoon!!")}
Olet päihittänyt kaikki juopot baarista. Koko baari ylistää sinua ja taputtaa.
Saat ilmaiset juomat baarin piikkiin seuraavaksi vuodeksi.
Onneksi olkoon!
");
            }

            WriteLine(@"Kiitos pelaamisesta!
ASCII Art:
~ Tuntematon https://www.asciiart.eu/food-and-drinks/beers
~ Sherry Stowers https://www.asciiart.eu/people/faces
~ Joan Stark https://www.asciiart.eu/people/men
~ jgs/akg https://www.asciiart.eu/people/women
");
            WaitForKey();
        }

        private void IntroCurrentEnemy()
        {
            Clear();
            ForegroundColor = CurrentEnemy.Color;
            WriteLine($"Juoppo lähestyy...");
            ResetColor();
            CurrentEnemy.DisplayInfo();
            WriteLine();
            WaitForKey();
        }

        private void BattleCurrentEnemy()
        {
            

            while (CurrentPlayer.IsAlive && CurrentEnemy.IsAlive)
            {
                Clear();
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();
                WriteLine();

                // pelaaja voi hyökätä viholliseen ja näytä tulokset
                CurrentPlayer.Fight(CurrentEnemy);

                WriteLine();
                WaitForKey();

                // katsotaan kuoleeko pelaaja tai vihollinen
                if (CurrentPlayer.IsDead || CurrentEnemy.IsDead)
                {
                    break;
                }

                // näytetään uudestaan päivitetyt elämäpisteet
                Clear();
                CurrentPlayer.DisplayHealthBar();
                CurrentEnemy.DisplayHealthBar();
                WriteLine();

                // vihollinen voi hyökätä pelaajaan ja näytä tulokset
                CurrentEnemy.Fight(CurrentPlayer);

                WaitForKey();
            }
        }

        private void WaitForKey()
        {
            WriteLine("Paina jotain näppäintä jatkaaksesi...\n");
            ReadKey(true);
        }
    }
}

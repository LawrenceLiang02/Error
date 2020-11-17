using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace BosunBot.Modules
{
    public class MorseCode : ModuleBase<SocketCommandContext>
    {
        [Command("morse")]
        public async Task morse([Remainder] string morseWord)
        {
            string currentMorseCode = "";

            string charString = "";
            //Console.WriteLine("Triggered");
            for (int i = 0; i < morseWord.Length; i++)
            {
                //Console.WriteLine("For loop");
                char character = morseWord[i];


                switch (char.ToLower(character))
                {
                    case 'a':
                        currentMorseCode = ".-" ;
                        break;
                    case 'b':
                        currentMorseCode = "-...";
                        break;
                    case 'c':
                        currentMorseCode = "-.-.";
                        break;
                    case 'd':
                        currentMorseCode = "-..";
                        break;
                    case 'e':
                        currentMorseCode = ".";
                        break;
                    case 'f':
                        currentMorseCode = "..-.";
                        break;
                    case 'g':
                        currentMorseCode = "--.";
                        break;
                    case 'h':
                        currentMorseCode = "....";
                        break;
                    case 'i':
                    case 'ï':
                        currentMorseCode = "..";
                        break;
                    case 'j':
                        currentMorseCode = ".---";
                        break;
                    case 'k':
                        currentMorseCode = "-.-";
                        break;
                    case 'l':
                        currentMorseCode = ".-..";
                        break;
                    case 'm':
                        currentMorseCode = "--";
                        break;
                    case 'n':
                        currentMorseCode = "-.";
                        break;
                    case 'o':
                        currentMorseCode = "---";
                        break;
                    case 'p':
                        currentMorseCode = ".--.";
                        break;
                    case 'q':
                        currentMorseCode = "--.-";
                        break;
                    case 'r':
                        currentMorseCode = ".-.";
                        break;
                    case 's':
                        currentMorseCode = "...";
                        break;
                    case 't':
                        currentMorseCode = "-";
                        break;
                    case 'u':
                        currentMorseCode = "..-";
                        break;
                    case 'v':
                        currentMorseCode = "...-";
                        break;
                    case 'w':
                        currentMorseCode = ".--";
                        break;
                    case 'x':
                        currentMorseCode = "-..-";
                        break;
                    case 'y':
                        currentMorseCode = "-.--";
                        break;
                    case 'z':
                        currentMorseCode = "--..";
                        break;
                    case '1':
                        currentMorseCode = ".----";
                        break;
                    case '2':
                        currentMorseCode = "..---";
                        break;
                    case '3':
                        currentMorseCode = "...--";
                        break;
                    case '4':
                        currentMorseCode = "....-";
                        break;
                    case '5':
                        currentMorseCode = ".....";
                        break;
                    case '6':
                        currentMorseCode = "-....";
                        break;
                    case '7':
                        currentMorseCode = "--...";
                        break;
                    case '8':
                        currentMorseCode = "---..";
                        break;
                    case '9':
                        currentMorseCode = "----.";
                        break;
                    case '0':
                        currentMorseCode = "-----";
                        break;
                    default:
                        currentMorseCode = "";
                        break;
                }
                charString = charString + currentMorseCode + " / ";
            }
            await ReplyAsync(charString);
        }
    }
}

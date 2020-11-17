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
    
    public class semaphore : ModuleBase<SocketCommandContext>
    {
        [Command("semaphore")]
        public async Task morse([Remainder] string morseWord)
        {
            string current = "";
            bool specChNeeded = false;
            string specialCh = "";
            string charString = "";

            //Console.WriteLine("Triggered");
            for (int i = 0; i < morseWord.Length; i++)
            {
                //Console.WriteLine("For loop");
                char character = morseWord[i];


                if (specChNeeded == false & character.Equals( '1' | '2' | '3' | '4' | '5'| '6'|'7'|'8'|'9'|'0' ))
                {
                    specChNeeded = true;
                    Console.WriteLine("1");
                    specialCh = "<:num:777946425740623952>";//"https://i.imgur.com/o5R8C94.png";
                }

                else if (specChNeeded == true & !character.Equals('1' | '2' | '3' | '4' | '5' | '6' | '7' | '8' | '9' | '0'))
                {
                    specialCh = "<:jalph:777946329673498664>";// "https://i.imgur.com/bCOvnKu.png";
                    specChNeeded = false;
                    Console.WriteLine("2");
                }

                else if (specChNeeded == true & character.Equals('1' | '2' | '3' | '4' | '5' | '6' | '7' | '8' | '9' | '0'))
                {
                    specialCh = "";
                    specChNeeded = true;
                    Console.WriteLine("3");
                }
                else
                {
                    specialCh = "";
                    specChNeeded = false;
                    Console.WriteLine("4");
                }

                switch (char.ToLower(character))
                {
                    case 'a':
                    case '1':
                        current = "a1:777946225798152202";//"https://i.imgur.com/QnkCXgk.png";
                        break;
                    case 'b':
                    case '2':
                        current = "b2:777946225815191653";// "https://i.imgur.com/jyu0J38.png";
                        break;
                    case 'c':
                    case '3':
                        current = "c3:777946225672585257";//"https://i.imgur.com/wasQC2B.png";
                        break;
                    case 'd':
                    case '4':
                        current = "d4:777946225562484817";//"https://i.imgur.com/w25menZ.png";
                        break;
                    case 'e':
                    case '5':
                        current = "e5:777946226053218334";// "https://i.imgur.com/jdp0DQf.png";
                        break;
                    case 'f':
                    case '6':
                        current = "f6:777946328700420118";//" https://i.imgur.com/XUfYAJt.png";
                        break;
                    case 'g':
                    case '7':
                        current = "g7:777946328713265194";// "https://i.imgur.com/hUGfZnx.png";
                        break;
                    case 'h':
                    case '8':
                        current = "h8:777946329137020958";//"https://i.imgur.com/3NgOREY.png";
                        break;
                    case 'i':
                    case '9':
                        current = "i9:777946329237684244";// "https://i.imgur.com/YYeykdh.png";
                        break;
                    case 'j':
                        current = "jalph:777946329673498664";//"https://i.imgur.com/bCOvnKu.png";
                        break;
                    case 'k':
                    case '0':
                        current = "k0:777946329376358440";//"https://i.imgur.com/qxwzGJi.png";
                        break;
                    case 'l':
                        current = "ll:777946329103859713";//"https://i.imgur.com/xDorJOn.png";
                        break;
                    case 'm':
                        current = "mm:777946329603113041";//"https://i.imgur.com/mIjJFXd.png";
                        break;
                    case 'n':
                        current = "nn:777946329619103764";//"https://i.imgur.com/SWOb0kM.png";
                        break;
                    case 'o':
                        current = "oo:777946329804308500";//"https://i.imgur.com/vHwHVbp.png";
                        break;
                    case 'p':
                        current = "pp:777946329778225202";// "https://i.imgur.com/PrL5xWS.png";
                        break;
                    case 'q':
                        current = "qq:777946329623035935";//"https://i.imgur.com/ws898sc.png";
                        break;
                    case 'r':
                        current = "rr:777946330270138398";//"https://i.imgur.com/Npcthag.png";
                        break;
                    case 's':
                        current = "ss:777946330299367444";// "https://i.imgur.com/wh2riV6.png";
                        break;
                    case 't':
                        current = "tt:777946330311819296";//"https://i.imgur.com/hn4HY5J.png";
                        break;
                    case 'u':
                        current = "uu:777946330374209596";// "https://i.imgur.com/KkS19RY.png";
                        break;
                    case 'v':
                        current = "vv:777946330307625010";//"https://i.imgur.com/zH4wPUl.png";
                        break;
                    case 'w':
                        current = "ww:777946330311557201";//"https://i.imgur.com/lu7jCSC.png";
                        break;
                    case 'x':
                        current = "xx:777946330311032852";//"https://i.imgur.com/kQEQHpm.png";
                        break;
                    case 'y':
                        current = "yy:777946330399113246";// "https://i.imgur.com/l8gETZc.png";
                        break;
                    case 'z':
                        current = "zz:777946330013237289";//"https://i.imgur.com/QKcoS3m.png";
                        break;
                    default:
                        current = "space:777946425698943017";// "https://i.imgur.com/wzxmTUi.png";
                        break;
                }
                string emoteString = "<:" + current + ">";
                //var emote = Emote.Parse(emoteString);
                //charString =  charString + specialCh + Emote.TryParse(emote, out var realEmote);
                charString = charString + specialCh + emoteString;
            }
            await ReplyAsync(charString);
        }
    }
}

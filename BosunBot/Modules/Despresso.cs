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
    public class Despresso : ModuleBase<SocketCommandContext>
    {
        [Command("imBored")]
        
        public async Task bored()
        {

            var user = Context.User;
            //Console.Write(user);
            DateTime today = DateTime.Now;
            if (user.Id == 82197304722857984)
            {


                if (today.DayOfWeek == DayOfWeek.Monday)
                {
                    if ((today.TimeOfDay >= new TimeSpan(8, 15, 0)) && (today.TimeOfDay < new TimeSpan(9, 45, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.psychology);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(9, 45, 0)) && (today.TimeOfDay < new TimeSpan(11, 15, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.wlm);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(12, 45, 0)) && (today.TimeOfDay < new TimeSpan(14, 45, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.frenchPoetry);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(16, 15, 0)) && (today.TimeOfDay < new TimeSpan(18, 15, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.algebra);
                    }
                    else
                    {
                        nothingtodo();
                    }

                }

                else if (today.DayOfWeek == DayOfWeek.Tuesday)
                {
                    if ((today.TimeOfDay >= new TimeSpan(8, 15, 0)) && (today.TimeOfDay < new TimeSpan(10, 15, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.wlm);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(10, 45, 0)) && (today.TimeOfDay < new TimeSpan(12, 45, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.orgChem);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(12, 45, 0)) && (today.TimeOfDay < new TimeSpan(14, 15, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.actPeriod);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(14, 15, 0)) && (today.TimeOfDay < new TimeSpan(15, 45, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.bollywood);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(16, 15, 0)) && (today.TimeOfDay < new TimeSpan(18, 15, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.fitness);
                    }
                    else
                    {
                        nothingtodo();
                    }

                }

                else if (today.DayOfWeek == DayOfWeek.Wednesday)
                {
                    if ((today.TimeOfDay >= new TimeSpan(8, 15, 0)) && (today.TimeOfDay < new TimeSpan(9, 45, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.psychology);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(11, 15, 0)) && (today.TimeOfDay < new TimeSpan(12, 45, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.orgChem);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(16, 15, 0)) && (today.TimeOfDay < new TimeSpan(17, 45, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.algebra);
                    }
                    else
                    {
                        nothingtodo();
                    }

                }
                else if (today.DayOfWeek == DayOfWeek.Thursday)
                {
                    if ((today.TimeOfDay >= new TimeSpan(9, 45, 0)) && (today.TimeOfDay < new TimeSpan(11, 15, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.frenchPoetry);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(12, 45, 0)) && (today.TimeOfDay < new TimeSpan(14, 15, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.actPeriod);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(14, 15, 0)) && (today.TimeOfDay < new TimeSpan(15, 45, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.bollywood);
                    }
                    else
                    {
                        nothingtodo();
                    }
                }
                else if (today.DayOfWeek == DayOfWeek.Friday)
                {
                    if ((today.TimeOfDay >= new TimeSpan(9, 45, 0)) && (today.TimeOfDay < new TimeSpan(11, 15, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.wlm);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(11, 15, 0)) && (today.TimeOfDay < new TimeSpan(12, 45, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.orgChem);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(12, 45, 0)) && (today.TimeOfDay < new TimeSpan(14, 15, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.algebra);
                    }
                    else
                    {
                        nothingtodo();
                    }
                }
                else if (today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday)
                {
                    await ReplyAsync("It's the weekend, go study. After that I will allow you to go play Arma 3.");
                }
            }
            else if (user.Id == 299016641524793345)
            {
                if (today.DayOfWeek == DayOfWeek.Monday)
                {
                    if ((today.TimeOfDay >= new TimeSpan(10, 0, 0)) && (today.TimeOfDay < new TimeSpan(12, 0, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.network);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(12, 30, 0)) && (today.TimeOfDay < new TimeSpan(14, 0, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.database);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(15, 30, 0)) && (today.TimeOfDay < new TimeSpan(17, 0, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.fob);
                    }
                    else
                    {
                        nothingtodo();
                    }

                }

                else if (today.DayOfWeek == DayOfWeek.Tuesday)
                {
                    if ((today.TimeOfDay >= new TimeSpan(8, 0, 0)) && (today.TimeOfDay < new TimeSpan(9, 30, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.java);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(9, 30, 0)) && (today.TimeOfDay < new TimeSpan(11, 0, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.iot);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(11, 0, 0)) && (today.TimeOfDay < new TimeSpan(12, 30, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.dotnet);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(13, 0, 0)) && (today.TimeOfDay < new TimeSpan(15, 0, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.tbc);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(16, 0, 0)) && (today.TimeOfDay < new TimeSpan(18, 00, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.database);
                    }
                    else
                    {
                        nothingtodo();
                    }

                }
                else if (today.DayOfWeek == DayOfWeek.Wednesday)
                {
                    if ((today.TimeOfDay >= new TimeSpan(8, 30, 0)) && (today.TimeOfDay < new TimeSpan(10, 30, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.eng);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(10, 30, 0)) && (today.TimeOfDay < new TimeSpan(12, 30, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.network);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(12, 30, 0)) && (today.TimeOfDay < new TimeSpan(14, 30, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.freeblock);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(14, 30, 0)) && (today.TimeOfDay < new TimeSpan(15, 30, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.dotnet);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(16, 0, 0)) && (today.TimeOfDay < new TimeSpan(17, 30, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.fob);
                    }
                    else
                    {
                        nothingtodo();
                    }

                }
                else if (today.DayOfWeek == DayOfWeek.Thursday)
                {
                    if ((today.TimeOfDay >= new TimeSpan(9, 30, 0)) && (today.TimeOfDay < new TimeSpan(11, 0, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.java);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(12, 30, 0)) && (today.TimeOfDay < new TimeSpan(14, 0, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.network);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(14, 00, 0)) && (today.TimeOfDay < new TimeSpan(17, 0, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.photo);
                    }
                    else
                    {
                        nothingtodo();
                    }

                }
                else if (today.DayOfWeek == DayOfWeek.Friday)
                {
                    if ((today.TimeOfDay >= new TimeSpan(8, 0, 0)) && (today.TimeOfDay < new TimeSpan(10, 0, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.eng);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(11, 0, 0)) && (today.TimeOfDay < new TimeSpan(12, 30, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.iot);
                    }
                    else if ((today.TimeOfDay >= new TimeSpan(12, 30, 0)) && (today.TimeOfDay < new TimeSpan(14, 0, 0)))
                    {
                        await ReplyAsync($"{Context.User.Mention} " + despressoStrings.dotnet);
                    }
                    else
                    {
                        nothingtodo();
                    }
                }
                else if (today.DayOfWeek == DayOfWeek.Saturday)
                {
                    await ReplyAsync("Bro you got cadets...stop skipping cadets");
                }
                else if (today.DayOfWeek == DayOfWeek.Sunday)
                {
                    await ReplyAsync("Unlike mr Desprsso, don't study and go play league :))) jk study a bit");
                }
            }
            else
            {
                await ReplyAsync("You are not mr Despresso nor Lawrence!");
            }
            //Console.Write(today);

        }

        private async void nothingtodo() 
        {
            Random random = new Random();
            int rand = random.Next(3);
            switch (rand)
            {
                case 1:
                    await ReplyAsync($"{Context.User.Mention} " + despressoStrings.noClass1);
                    break;
                case 2:
                    await ReplyAsync($"{Context.User.Mention} " + despressoStrings.noClass2);
                    break;
                case 0:
                    await ReplyAsync($"{Context.User.Mention} " + despressoStrings.noClass3);
                    break;
                default:
                    await ReplyAsync($"{Context.User.Mention} You got the random number" + rand);
                    break;
            }
        }
    }


}

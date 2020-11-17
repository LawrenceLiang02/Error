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
    public class Jokes : ModuleBase<SocketCommandContext>
    {
        [Command("joke")]
        public async Task eightBall([Remainder] string reason = null)
        {
            Random random = new Random();
            int rand = random.Next(19);
            switch (rand)
            {
                case 0:
                    await ReplyAsync($"{Context.User.Mention} Go look in a mirror");
                    break;
                case 1:
                    await ReplyAsync($"{Context.User.Mention} I have never seen two pretty best friends, one has to be ugly");
                    break;
                case 2:
                    await ReplyAsync($"{Context.User.Mention} Why do we tell actors to “break a leg?\n\nBecause every play has a cast.");
                    break;
                case 3:
                    await ReplyAsync($"{Context.User.Mention} Did you hear about the claustrophobic astronaut?\n\nHe just needed a little space.");
                    break;
                case 4:
                    await ReplyAsync($"{Context.User.Mention} Why don’t scientists trust atoms?\n\nBecause they make up everything.");
                    break;
                case 5:
                    await ReplyAsync($"{Context.User.Mention} Where are average things manufactured?\n\nThe satisfactory.");
                    break;
                case 6:
                    await ReplyAsync($"{Context.User.Mention} Don't be sad if your ex cheats on you, your parents always told you to let the younger kids play with your used toys.");
                    break;
                case 7:
                    await ReplyAsync($"{Context.User.Mention} I had a friend who was a deep sleeper. One day, a fire started in his house. Now he’s a really deep sleeper.");
                    break;
                case 8:
                    await ReplyAsync($"{Context.User.Mention} What is similar between sex, and fishing? \n\nIt doesn’t matter how deep you go, it matters how you wiggle the worm.");
                    break;
                case 9:
                    await ReplyAsync($"{Context.User.Mention} https://media.discordapp.net/attachments/523627522777153536/778039401342959639/image0.jpg");
                    break;
                case 10:
                    await ReplyAsync($"{Context.User.Mention} https://media.discordapp.net/attachments/523597821287333904/728361057768177814/472rsc.jpg");
                    break;
                case 11:
                    await ReplyAsync($"{Context.User.Mention} https://media.discordapp.net/attachments/523597821287333904/752889428342472794/WESTYY.png?width=585&height=677");
                    break;
                case 12:
                    await ReplyAsync($"{Context.User.Mention} https://media.discordapp.net/attachments/523597821287333904/752887643317993596/verygoood.jpg?width=585&height=677");
                    break;
                case 13:
                    await ReplyAsync($"{Context.User.Mention} https://media.discordapp.net/attachments/523597821287333904/752669408853229568/image0.png?width=597&height=677");
                    break;
                case 14:
                    await ReplyAsync($"{Context.User.Mention} https://media.discordapp.net/attachments/523597821287333904/752336288924827778/image0.png?width=754&height=677");
                    break;
                case 15:
                    await ReplyAsync($"{Context.User.Mention} https://media.discordapp.net/attachments/523597821287333904/752336270876868683/image0.png?width=1354&height=677");
                    break;
                case 16:
                    await ReplyAsync($"{Context.User.Mention} https://media.discordapp.net/attachments/523597821287333904/752278164885209219/image0.jpg");
                    break;
                case 17:
                    await ReplyAsync($"{Context.User.Mention} https://media.discordapp.net/attachments/523597821287333904/752273181703798915/image0.jpg");
                    break;
                case 18:
                    await ReplyAsync($"{Context.User.Mention} September 6, 2020 https://media.discordapp.net/attachments/523597821287333904/752270129387143219/image0.png");
                    break;
                default:
                    await ReplyAsync($"{Context.User.Mention} You have outsmarted the bot to have more or less than 8.");
                    break;
            }
        }
    }
}

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
    public class EightBall : ModuleBase<SocketCommandContext>
    {
        [Command("8ball")]
        public async Task eightBall([Remainder] string reason = null)
        {
            Random random = new Random();
            int rand = random.Next(9);
            switch (rand)
            {
                case 0:
                    await ReplyAsync($"{Context.User.Mention} Definately Yes!");
                    break;
                case 1:
                    await ReplyAsync($"{Context.User.Mention} Yes!");
                    break;
                case 2:
                    await ReplyAsync($"{Context.User.Mention} I guess!");
                    break;
                case 3:
                    await ReplyAsync($"{Context.User.Mention} Most likely!");
                    break;
                case 4:
                    await ReplyAsync($"{Context.User.Mention} Maybe!");
                    break;
                case 5:
                    await ReplyAsync($"{Context.User.Mention} Risky!");
                    break;
                case 6:
                    await ReplyAsync($"{Context.User.Mention} I don't know about that!");
                    break;
                case 7:
                    await ReplyAsync($"{Context.User.Mention} No!");
                    break;
                case 8:
                    await ReplyAsync($"{Context.User.Mention} Definately a no!");
                    break;
                default:
                    await ReplyAsync($"{Context.User.Mention} You have outsmarted the bot to have more or less than 8.");
                    break;
            }
        }
    }
}

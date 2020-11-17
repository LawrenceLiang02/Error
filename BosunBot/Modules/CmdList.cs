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
    public class CmdList : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task cmds()
        {
            var EmbedBuilder = new EmbedBuilder();
            EmbedBuilder.WithDescription($"{Context.User.Mention} \nHere are the list of commands:\n" +
                $"**Product**\n!products - List of products \n!info + name - Product info \n\n" +
                $"**Company Support:**\n!bosun - Bosun Shipbuilding Invite Link \n!support - [WIP]Ticket Request (blacklist or product support)\n!rules - [WIP] Rules\n!bosunfuture - Future of the Bosun Shipbuilding Inc.\n!copyright - Copyrights"+
                $"\n\n**Sponsored Partners:**\n!polarstar - Polarstar Invite Link \n!blackforest - Black Forest Invite Link\n!colcheter - Colchester Invite Link\n!pontenta - Pontenta's Shop\n!wdi - Western DI whatever"+
                $"\n\n**Miscellaneous**\n!8ball - 8ball random string generator" +
                $"\n!aerotech - Aerotech Release\n!aerotechfm - Aerotech Free models\n!joke - Jokes\n!morse + sentence - Morse Translator\n!aerotechcontrols - Aerotech Controls\n!semaphore + sentence - [WIP] Semaphore\n!discMode - Tests your discord mode" +
                $"\n\n**Admin**\n!kick + name + reason - Kick a user\n!ban + name + reason - Ban a user");

            //var user = Context.User as SocketGuildUser;
            //if (user.GuildPermissions.KickMembers)
            //{
                
            //}

            Embed embed = EmbedBuilder.Build();
            await ReplyAsync(embed: embed);
        }
    }
}

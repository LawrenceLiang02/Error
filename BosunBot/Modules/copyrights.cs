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
    public class copyrights : ModuleBase<SocketCommandContext>
    {

        [Command("copyright")]
        public async Task copyright()
        {
            var EmbedBuilder = new EmbedBuilder()
               .WithDescription($"The bot was made by Lawrence#6470 - NeatBosun for the Bosun Shipbuilding Inc.\n All rights reserved to the creator. \nLast updated: Nov. 2020")
               .WithFooter(footer =>
               {
                   footer
                   .WithText("©Bosun Shipbuilding Inc. 2020");
               } );
            Embed embed = EmbedBuilder.Build();
            await ReplyAsync(embed: embed);
        }
    }
}

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
    public class Kick : ModuleBase<SocketCommandContext>
    {
        [Command("kick")]
        [RequireUserPermission(GuildPermission.KickMembers, ErrorMessage = "You don't have the permission ``kick_member``!")]
        public async Task KickMember(IGuildUser user = null, [Remainder] string reason = null)
        {
            if (user == null)
            {
                await ReplyAsync("Please specify a user!");
                return;
            }
            if (reason == null) reason = "Not specified";

            await Context.Message.DeleteAsync();

            await user.KickAsync(reason);

            var EmbedBuilder = new EmbedBuilder()
                .WithDescription($":white_check_mark: {user.Mention} was kicked\n**Reason** {reason}")
                .WithFooter(footer =>
                {
                    footer
                    .WithText("User Kick Log")
                    .WithIconUrl("https://i.imgur.com/6Bi17B3.png");
                });
            Embed embed = EmbedBuilder.Build();
            await ReplyAsync(embed: embed);

            ITextChannel logChannel = Context.Client.GetChannel(587410674209128458) as ITextChannel;
            var EmbedBuilderLog = new EmbedBuilder()
                .WithDescription($"{user.Mention} was kick\n**Reason** {reason}\n**Moderator** {Context.User.Mention}")
                .WithFooter(footer =>
                {
                    footer
                    .WithText("User Kick Log")
                    .WithIconUrl("https://i.imgur.com/6Bi17B3.png");
                });
            Embed embedLog = EmbedBuilderLog.Build();
            await logChannel.SendMessageAsync(embed: embedLog);

        }
    }
}

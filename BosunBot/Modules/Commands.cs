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
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("iscoastiealoser")]
        public async Task coastieLoser()
        {
            //await Context.Message.DeleteAsync();
            await ReplyAsync($"{Context.User.Mention} Dead ass yes <@!193143206790168576> is a loser. \nHe owes <@!82197304722857984> 100$.");
        }
        [Command("fone")]
        public async Task fone()
        {
            //await Context.Message.DeleteAsync();
            await ReplyAsync($"{Context.User.Mention} Remember January 23rd.");
        }

        [Command("ping23")]
        public async Task pingEscobaro()
        {
            await Context.Message.DeleteAsync();
            await ReplyAsync($"Ghost ping <@!579703802765246465>");
        }

        [Command("pingscottish")]
        public async Task pingscottish()
        {
            await Context.Message.DeleteAsync();
            await ReplyAsync($"Ghost ping <@!398251004631580673>");
        }

        [Command("pingcoastie")]
        public async Task pingcoastie()
        {
            await Context.Message.DeleteAsync();
            await ReplyAsync($"Ghost ping <@!193143206790168576>");
        }

        [Command("noBootyPIcs")]
        public async Task special()
        {
            await Context.Message.DeleteAsync();
            await ReplyAsync($"<@!387462817747566602> Send booty pic to {Context.User.Mention}.");
        }

        [Command("installRoblox")]
        public async Task roblox()
        {
            await Context.Message.DeleteAsync();
            await ReplyAsync($"{Context.User.Mention} Don't install roblox. That game is toxic.");
        }

        [Command("darkvader356")]
        public async Task DarkVader356()
        {
            await Context.Message.DeleteAsync();
            await ReplyAsync($"<@!710258197771976756> Stop hating on me");
        }


        [Command("kiki")]
        public async Task kiki()
        {
            await Context.Message.DeleteAsync();
            await ReplyAsync($"<@!503662317905379343> Shut the fuck up hon hon baguette baguette go suck on the bloc quebecois' dick");
        }

        [Command("aerotech")]
        public async Task aerotechRelease()
        {
           // await Context.Message.DeleteAsync();
            await ReplyAsync($"{Context.User.Mention} https://www.roblox.com/library/5767637697/BSI-Aerotech-Configuration-release-instruction");
        }

        [Command("bosun")]
        public async Task inviteLink()
        {
           // await Context.Message.DeleteAsync();
            await ReplyAsync($"{Context.User.Mention} https://discord.gg/nU8Mm3G");
        }

        [Command("polarstar")]
        public async Task PolarstarInviteLink()
        {
            //await Context.Message.DeleteAsync();
            await ReplyAsync($"{Context.User.Mention} https://discord.gg/Polarstar");
        }

        [Command("pontenta")]
        public async Task PontentaInviteLink()
        {
            //await Context.Message.DeleteAsync();
            await ReplyAsync($"{Context.User.Mention} https://discord.gg/n8y6XWN");
        }

        [Command("colchester")]
        public async Task ColchesterInviteLink()
        {
            //await Context.Message.DeleteAsync();
            await ReplyAsync($"{Context.User.Mention} https://discord.gg/6aekptM");
        }

        [Command("blackforest")]
        public async Task BlackForestInviteLink()
        {
            //await Context.Message.DeleteAsync();
            await ReplyAsync($"{Context.User.Mention} https://discord.gg/yaB7NEu");
        }
        [Command("msi")]
        public async Task msi()
        {
            //await Context.Message.DeleteAsync();
            await ReplyAsync($"{Context.User.Mention} https://discord.com/invite/DVR93jW");
        }

        [Command("aerotechcontrols")]
        public async Task aerotechctrl()
        {
            //await Context.Message.DeleteAsync();
            var EmbedBuilder= new EmbedBuilder()
                .WithDescription($"{Context.User.Mention} \n**CONTROLS**\nHold T for 5 seconds to start up ship\nWASD for steering\nH for the horn\nE or Q for left/right thrusters\nG for the hook magnet (certain scripts)\nT to turn off the engine.");
            Embed embed = EmbedBuilder.Build();
            await ReplyAsync(embed: embed);
        }

        [Command("aerotechfm")]
        public async Task AerotechFm()
        {
            //await Context.Message.DeleteAsync();
            await ReplyAsync($"{Context.User.Mention} Swift Boat: https://www.roblox.com/library/5853759724/BSI-SwiftBoat-with-Aerotech \nPontenta's Ferry: https://www.roblox.com/library/5870859424/big-old-shuttle-AEROTECH \nIndependance Class: https://www.roblox.com/library/5820348321/INDEPENDANCE-CLASS");
        }

        [Command("discMode")]
        public async Task discMode()
        {
            await Context.Message.DeleteAsync();
            Random random = new Random();
            int rand = random.Next(2);
            switch (rand)
            {
                case 0:
                    await ReplyAsync("https://media.discordapp.net/attachments/754358697282633738/778029106180653056/936.png");
                    break;
                case 1:
                    await ReplyAsync("https://media.discordapp.net/attachments/639166026017275928/751265766090735636/image0-2-1.png");
                    break;
                default:
                    await ReplyAsync("You have outsmarted the bot");
                    Console.WriteLine("The answer you got is " + rand);
                    break;
            }
        }

        [Command("bosunfuture")]
        public async Task bosunFuture()
        {
            //await Context.Message.DeleteAsync();
            await ReplyAsync("https://gyazo.com/734d6890a871a5e54e670fa0369fa163");
        }

        [Command("wdi")]
        public async Task wdi()
        {
            //await Context.Message.DeleteAsync();
            await ReplyAsync("You actually thought I would put an invite for Western whatever? \n\nHere are 3 reasons why you should becareful of WDI and their potential scams!\n https://docs.google.com/document/d/1AKrRJdDL_FmRYlQDVyql_C_bElN_fs99P2WsjMz01aw/edit?usp=sharing");
        }
    }
}
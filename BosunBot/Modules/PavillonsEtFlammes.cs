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
   
    public class PavillonsEtFlammes : ModuleBase<SocketCommandContext>
    {
        [Command("signalFlag")]
        public async Task signalFlag([Remainder] string morseWord)
        {

        }
    }
}

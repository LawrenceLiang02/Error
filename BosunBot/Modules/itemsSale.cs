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
    public class itemsSale : ModuleBase<SocketCommandContext>
    {
        [Command("products")]
        public async Task showListofProduct()
        {
            var EmbedBuilder = new EmbedBuilder()
            .WithDescription($"{Context.User.Mention} **Here is a list of our products**\n" +
                $"For more details, please do ```!info + name```\n" +
                "To purchase a ship, DM <@!299016641524793345>\n" +
                "__Canadian Warships__:\nOrca class v1\n\n" +
                "__American Warships__:\nZumwalt Class\nOliver Hazard Perry Class\nUSCG Sentinel Class\nUSCG Marine Protector Class\nPBR mk2\nUSCG RHIB\nUSCG Patrol Boat/Pilot Boat\nRHIB\nTactical RHIB\nLCAC\n\n" +
                "__Spanish/Australian Warships__:\nJuan Carlos 1/HMAS Canberra\nLCPV\n\n" +
                "__Other warships__:\nLaFayette Class (FRANCE)\nNiteroi Class (BRAZIL)\n\n" +
                "__Civilian Boats__:\nPilot Boat/USCG Patrol Boat\nLife Raft\nSpeed boat\n\n" +
                "__Equipment__:\nLife vest\nCustom Cap\nAerotech Crane\nPFD");
            
            Embed embed = EmbedBuilder.Build();
            await ReplyAsync(embed: embed);

        }

        [Command("info")]
        public async Task info([Remainder] string reason = null)
        {

            switch (reason.ToLower())
            {
                
                case "lcac":
                    await ReplyAsync($"{Context.User.Mention} \n Name: LCAC\nPrice: 20$ USD\nDescription: It can hold 6 vehicles, animated ramps, and lights\nPicture: https://media.discordapp.net/attachments/523598196383940609/714298302228725833/unknown.png?width=1442&height=549 https://media.discordapp.net/attachments/523598196383940609/714298414019641364/unknown.png?width=1211&height=677");
                    break;
                case "oliver hazard perry":
                case "ohp":
                case "oliver":
                    await ReplyAsync($"{Context.User.Mention} \nName: Oliver Hazard Perry\nPrice: 50$ USD\nDescription: Rockets, middle turret, scripted flight deck, interrior\n" +
                        "Picture: https://media.discordapp.net/attachments/523598196383940609/633845472943144985/unknown.png " + 
                        "https://media.discordapp.net/attachments/523598196383940609/633845725364748338/unknown.png?width=1393&height=677 " +
                        "https://media.discordapp.net/attachments/523598196383940609/633846123697799178/unknown.png?width=1442&height=675 " +
                        "https://media.discordapp.net/attachments/523598196383940609/633846380888326145/unknown.png?width=1354&height=677 " +
                        "https://media.discordapp.net/attachments/523598196383940609/633846543329525760/unknown.png?width=1237&height=677 ");
                    break;
                case "zumwalt class":
                case "zumwalt":
                    await ReplyAsync($"{Context.User.Mention} \nName: Zumwalt Class\nPrice: 50$ USD\nDescription: Rockets, high detail interrior, lights, rear turrets, animated doors and deck\n" +
                        "https://giphy.com/gifs/VJlYZ7rrObPhC8UxdY \n https://gyazo.com/00956d1afc2464a1682a0bc796f2c8ff \n https://gyazo.com/8a26c5b153d029b96842d7213d9f2b56");
                    break;
                case "rhib":
                    await ReplyAsync($"{Context.User.Mention} \nName: RHIB\nPrice: 15$ USD\nDescription: Animated storage, Machine gun turret, Aerotech, no trailer\n" +
                        "https://media.discordapp.net/attachments/523598196383940609/708419998674190346/unknown.png");
                    break;
                case "uscg rhib":
                    await ReplyAsync($"{Context.User.Mention} \nName: USCG RHIB\nPrice: 15$ USD\nDescription: Animated storage, Machine gun turret, Aerotech, no trailer\n" +
                        "https://media.discordapp.net/attachments/523646051886956549/703782289561354300/unknown.png");
                    break;
                case "sentinel class":
                case "sentinel":
                case "uscg sentinel":
                case "uscg sentinel class":
                    await ReplyAsync($"{Context.User.Mention} \nName: Sentinel Class\nPrice: 30$ USD\nDescription: Front turret, interior, scripted ramp door, lights\n" +
                        "https://media.discordapp.net/attachments/523646051886956549/630970605298122762/unknown.png \n https://media.discordapp.net/attachments/523646051886956549/630970968625643540/unknown.png?width=1066&height=677");
                    break;
                case "marine protector class":
                case "marine":
                case "marine protector":
                case "uscg marine protector class":
                case "uscg marine protector":
                case "uscg marine":
                    await ReplyAsync($"{Context.User.Mention} \nName: Marine Protector Class\nPrice: 25$ USD\nDescription:Interior, Machine gun turret, Aerotech, comes with rear dinghy\n" +
                        "https://media.discordapp.net/attachments/523598196383940609/706304465380048896/unknown.png?width=1068&height=677 \n https://media.discordapp.net/attachments/523598196383940609/706304556249907221/unknown.png");
                    break;
                case "tactical rhib":
                    await ReplyAsync($"{Context.User.Mention} \nName: Tactical RHIB\nPrice: 15$ USD\nDescription:10 seats+, Machine gun turret, Aerotech, no trailer\n" +
                        "https://media.discordapp.net/attachments/523598196383940609/740650314369335336/unknown.png?width=1371&height=677");
                    break;
                case "pilot boat":
                case "pilot":
                case "uscg patrol boat":
                case "patrol boat":
                    await ReplyAsync($"{Context.User.Mention} \nName: Pilot Boat/USCG Patrol Boat\nPrice: 15$ USD\nDescription:Interior,Aerotech, no trailer\n" +
                        "https://media.discordapp.net/attachments/523598196383940609/740652032180092948/unknown.png?width=1419&height=677");
                    break;
                case "orca v1":
                case "orca class v1":
                case "orca":
                case "orca class":
                    await ReplyAsync($"{Context.User.Mention} \nName: Orca Class v1\nPrice: 15$ USD\nDescription:Interior,Old, Aerotech, Sold as it is.\n" +
                        "https://media.discordapp.net/attachments/523591767828987905/524062590343708673/9c2b889353fba22e0bf1ab271a0061ed-png.png https://media.discordapp.net/attachments/523591767828987905/524071619195437082/aea1490a29df02d67ca9015ffd68a6e7.png https://media.discordapp.net/attachments/523591767828987905/524071790989934592/a65a3c06950a9155f0f84e44ec935731.png?width=1054&height=677 https://media.discordapp.net/attachments/523591767828987905/524071819242635264/2089b60b8f3fa7daaf6320fd53a70607.png?width=1102&height=677");
                    break;
                case "lcm-1e":
                case "landing craft":
                case "lcpv":
                    await ReplyAsync($"{Context.User.Mention} \nName: LCM-1E\nPrice: 15$ USD\nDescription:Interior, can hold 6 vehicles,Aerotech, animated ramps\n" +
                        "https://cdn.discordapp.com/attachments/630950525512450059/630951006112317496/unknown.png");
                    break;
                case "pbr mk2":
                case "pbr":
                    await ReplyAsync($"{Context.User.Mention} \nName: PBR mk2\nPrice: 15$ USD\nDescription:Interior,Aerotech, no trailer, machine gun turret, 2 seats\n" +
                     "https://media.discordapp.net/attachments/630950525512450059/700060611693772880/unknown.png");
                    break;
                case "crane":
                case "aerotech crane":
                    await ReplyAsync($"{Context.User.Mention} \nName: Aerotech Crane\nPrice: 5$ USD\nDescription:Compatible with the Aerotech crane script\n" +
                     "https://gyazo.com/cf5bd97396cf3c9e67ad69c0aa880662");
                    break;
                case "pfd":
                    await ReplyAsync($"{Context.User.Mention} \nName: PFD\nPrice: 2$ USD\nDescription:It can float on roblox water\n" +
                     "https://media.discordapp.net/attachments/523646051886956549/703786291204194344/unknown.png");
                    break;
                case "life vest":
                case "orange life vest":
                    await ReplyAsync($"{Context.User.Mention} \nName: Orange life vest\nPrice: 2$ USD\nDescription:It can float on roblox water\n" +
                     "https://media.discordapp.net/attachments/523646051886956549/704170230947119135/unknown.png");
                    break;
                case "juan carlos 1":
                case "juan carlos":
                case "hmas canberra":
                case "canberra":
                case "juan":
                    await ReplyAsync($"{Context.User.Mention} \nName: Juan Carlos 1/HMAS Canberra\nPrice: 100 USD\nDescription: Interior, scripted ramps, elevator, can hold multiple air crafts, catapult (welds)" +
                        $"Pictures: https://media.discordapp.net/attachments/538071170411528192/563890979334127616/unknown.png?width=1442&height=490 https://media.discordapp.net/attachments/538071170411528192/563891181562626048/unknown.png https://media.discordapp.net/attachments/538071170411528192/563891277595410443/unknown.png?width=1442&height=603 https://media.discordapp.net/attachments/538071170411528192/563891364983734273/unknown.png?width=1100&height=677 https://media.discordapp.net/attachments/538071170411528192/563891481174343681/unknown.png?width=1442&height=630");
                    break;
                case "lafayette class (france)":
                case "lafayette":
                case "lafayette class":
                case "lafaguette":
                    await ReplyAsync($"{Context.User.Mention} \nName: LaFayette Class (FRANCE)\nPrice: 50 USD\nDescription: Interior, scripted ramps, front turret, missiles\nPictures: https://media.discordapp.net/attachments/701648231523811330/701649313545322588/unknown.png https://media.discordapp.net/attachments/701648231523811330/701649399100473484/unknown.png?width=973&height=677 https://media.discordapp.net/attachments/701648231523811330/701649455539028048/unknown.png?width=870&height=677");
                    break;
                case "niteroi":
                case "niteroi class":
                case "niteroi class (brazil)":
                    await ReplyAsync($"{Context.User.Mention} \nName: Niteroi Class (BRAZIL)\nPrice: 40 USD\nDescription: Interior, old with no support, front turret\nPictures: https://gyazo.com/90a1598c6f5ef6ee047de7a1989fb2f2 https://gyazo.com/da28727940d9de79e00e1cc464868cc8 https://gyazo.com/f84c738bd53e32c107f0de039c39f528");
                    break;
                case "speed boat":
                case "speedboat":
                case "speed":
                    await ReplyAsync($"{Context.User.Mention} \nName: Speed Boat\nPrice: 5$ USD\nDescription: Low Quality, it is what it is\nPictures: " +
                     "https://images-ext-2.discordapp.net/external/90lxC3yph55o-coP7cgvVOb_OlPqE4-C9BvQKHtwFyo/%3Fwidth%3D1076%26height%3D676/https/media.discordapp.net/attachments/523646051886956549/579483118877147138/unknown.png");
                    break;
                case "raft":
                case "life raft":
                    await ReplyAsync($"{Context.User.Mention} \nName: Life raft\nPrice: 5$ USD\nDescription: Can flow on roblox water, but weird physics\nPictures: " +
                     "https://gyazo.com/4b3beb9a7b0f9fc798f5aad3525b5deb");
                    break;
                default:
                    await ReplyAsync($"{Context.User.Mention} Mispelled or unavailable item!");
                    break;
            }

        }            
    }
}

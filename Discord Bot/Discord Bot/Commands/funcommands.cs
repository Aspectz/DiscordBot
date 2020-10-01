using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot.Commands
{
    public class funcommands :BaseCommandModule
    {
         
        [Command("ping")]
        public async Task Ping(CommandContext ctx) {
            await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }
        [Command("add")]
        public async Task Add(CommandContext ctx, int n1,int n2) {
            await ctx.Channel.SendMessageAsync((n1+n2)
                .ToString()) 
                .ConfigureAwait(false);

        }
        [Command("mover")]
        public async Task  mover(CommandContext ctx) {

            var autor = ctx.Message.Author.Username;
            string nombre="Canal de "+autor;
            var canal = await ctx.Guild.CreateVoiceChannelAsync( nombre ,ctx.Channel.Parent, null, 1, null, null);
            await ctx.Member.PlaceInAsync(canal);
            await Task.Delay(2);
            await canal.DeleteAsync().ConfigureAwait(false);
            
            


        }
    }
}

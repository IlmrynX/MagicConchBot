﻿namespace MagicConchBot.Modules
{
    using Discord;
    using Discord.Commands;

    using MagicConchBot.Common.Interfaces;
    using MagicConchBot.Services;

    public class MusicCommandContext : CommandContext
    {
        public MusicCommandContext(IDiscordClient client, IUserMessage msg) : base(client, msg)
        {
        }

        public IMusicService MusicService => MusicServiceProvider.GetService(Guild.Id);
    }
}

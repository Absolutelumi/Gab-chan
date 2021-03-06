﻿using Discord;
using Discord.Commands;

namespace ChitoseV2.Commands
{
    internal class Help : ICommandSet
    {
        public void AddCommands(DiscordClient client, CommandService commands)
        {
            commands.CreateCommand("helpme").Do(async (e) =>
            {
                string HelpMessage = e.User.Mention + "Hello! I'm a bot designated to do a plethora of different commands including(use prefix '!' before command): \n " +
                "__**General Commands**__ \n" +
                "**myrole**: Displays roles \n" +
                "**myav**: Displays profile picture \n" +
                "**osu <user>**: Displays profile information for that user \n" +
                "**purge <user>(optional)**: Purges last 50 messages of channel if user is left null, and last 50 messages of that user if given \n" +
                "**rate <waifu>**: Randomly generates score out of 100 for <waifu> \n" +
                "**anime <anime>**: Gives information of anime (From MAL) \n" +
                "\n" +
                "__**Music Commands**__ \n" +
                "**add <song>**: Adds <song> to quene \n" +
                "**clear**: Clears quene \n" +
                "**skip**: Skips currently playing song \n" +
                "**queue**: Displays queue \n" +
                "**next <index>**: Goes to the <index> of queue \n" +
                "**remove <index>**: Removes song fomr <index> of quene \n" +
                "**play**: Starts playing song \n" +
                "**stop**: Stops playing current song \n" +
                "**pause**: Pauses currently playing song \n" +
                "**resume**: Resumes paused song \n" +
                "**join <voice-channel>**: I join the <voice-channel> \n" +
                "**leave**: I leave the voice channel I'm currently in \n" +
                "**volume <volume-level>**: Sets volume out of 100 \n" +
                "\n" +
                "__**Picture Commands**__ \n" +
                "**reddit <subreddit>**: Pulls random image from the hot section of <subreddit> \n" +
                "**show <tags>**: Shows non-NSFW anime picture with same <tags> \n" +
                "**i**: Shows random NSFW hentai picture \n" +
                "**Blur <blur level> <picture link>**: Blurs the picture with gaussian blur \n" +
                "**tint <color> <picture link>**: Tints the picture with selected color \n" +
                "\n" +
                "__**Osu! Commands**__ \n" +
                "**user <user>**: Gives stats for specified user (Standard only) \n" +
                "**beatmap <beatmap_score_picture>**: Take a picture of a score, and then type the command directly under to get the info of that beatmap \n" +
                "**<betamapURL>**: Will give info of beatmap \n" +
                "**follow <osu_Username>**: (Only works if have channel named 'osu-scores') Will add the user to a queue to send every ranked submitted play to 'osu-scores' \n" +
                "**unfollow <osu_Username>**: Cancels the above \n";

                await e.User.SendMessage(HelpMessage);
            });
        }
    }
}
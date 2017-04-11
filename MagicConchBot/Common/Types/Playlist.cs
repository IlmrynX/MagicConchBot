﻿using System.Collections.Generic;

namespace MagicConchBot.Common.Types
{
    public class Playlist
    {
        public Playlist(string name = "Default")
        {
            Name = name;
            Songs = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Songs { get; set; }
    }
}
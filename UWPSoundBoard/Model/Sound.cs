﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    public class Sound
    {
        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string Audiofile { get; set; }
        public string ImageFile { get; set; }
        public enum SoundCategory
        {
            Animals,
            Cartoons,
            Taunts,
            Warnings

        }
        public Sound(string name, SoundCategory category)
        {
            Name = name;
            Category = category;
            Audiofile = $"/Assets/Audio/{category}/{name}.wav";
            ImageFile = $"/Assets/Audio/{category}/{name}.png";

        }
    }
    }

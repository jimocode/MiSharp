﻿using DeadDog.Audio.Libraries;
using ReactiveUI;

namespace MiSharp
{
    public class TrackViewModel : ReactiveObject
    {
        public TrackViewModel(Track track)
        {
            Track = track;
        }

        public Track Track { get; set; }
    }
}
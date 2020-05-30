using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace JukeboxControl.Core
{
    public class JukeboxCore
    {
        private List<JukeboxSong> songs = new List<JukeboxSong>();
        private Queue<JukeboxSong> queue = new Queue<JukeboxSong>();
        private Dictionary<int, string> categories = new Dictionary<int, string>();


        public JukeboxCore(string songDataPath)
        {
            
        }

        public void addToQueue(JukeboxSong song)
        {
            if (this.songs.IndexOf(song) != -1) addToQueue(this.songs.IndexOf(song));
        }

        public void addToQueue(int songId)
        {
            queue.Enqueue(songs.ElementAt(songId));
        }

        public void removeFromQueue(JukeboxSong song)
        {

        }

        public void clearQueue()
        {
            queue.Clear();
        }

    }

    public class JukeboxSong
    {
        public int category;
        public string filePath;
        public bool playedAlready;
    }
}

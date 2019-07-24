using SnapsLibrary;
using System;
using System.Collections.Generic;

class PlaySong
{
    /// <summary>
    /// Requires 2 args, int pitch, and double noteduration
    /// </summary>
    public struct SongNote
    {
        public int NotePitch;
        public double NoteDuration;

        public SongNote(int notepitch, double noteduration)
        {
            if (notepitch < 0 || notepitch > 12)
            {
                throw new Exception("Invalid pitch value");
            }
            if (noteduration < .1 || noteduration > 3)
            {
                throw new Exception("Invalid duration value");
            }
            NotePitch = notepitch;
            NoteDuration = noteduration;
        }
    }

    public void StartProgram()
    {

        List<SongNote> tune = new List<SongNote>();

        //int _notepitch = SnapsEngine.ReadInteger("Note Pitch");
        //double _noteduration = SnapsEngine.ReadInteger("Note Duration");





        //SongNote newNote = new SongNote(_notepitch, _noteduration);
        SongNote newNote1 = new SongNote(1, .4);
        SongNote newNote2 = new SongNote(4, .4);
        SongNote newNote3 = new SongNote(7, .4);



        tune.Add(newNote1);
        tune.Add(newNote2);
        tune.Add(newNote3);

        for (int i = 0; i < tune.Count; i++)
        {
            SnapsEngine.PlayNote(tune[i].NotePitch, tune[i].NoteDuration);
        }














        //Playing a song with an array 
        //SongNote[] notes = new SongNote[5];
        //notes[0].NotePitch = 0; notes[0].NoteDuration = .4;
        //notes[1].NotePitch = 2; notes[1].NoteDuration = .4;
        //notes[2].NotePitch = 4; notes[2].NoteDuration = .4;
        //notes[3].NotePitch = 6; notes[3].NoteDuration = .4;
        //notes[4].NotePitch = 8; notes[4].NoteDuration = .4;

        //for (int i = 0; i < notes.Length; i++)
        //{
        //    SnapsEngine.PlayNote(pitch: notes[i].NotePitch, duration: notes[i].NoteDuration);
        //}



    }
}


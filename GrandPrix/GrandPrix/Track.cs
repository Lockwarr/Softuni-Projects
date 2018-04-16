using System;
using System.Collections.Generic;
using System.Text;

public class Track
{
    private int lapsNumber;
    private int trackLength;
    private Weather weather;

    public Track(int lapsNumber, int trackLength)
    {
        this.lapsNumber = lapsNumber;
        this.trackLength = trackLength;
        this.Weather = Weather.Sunny;
        this.CurrentLap = 0;
    }

    public int LapsNumber { get; }
    public int TrackLenght{ get; set; }
    public int CurrentLap { get; set; }
    public Weather Weather { get; set; }

}

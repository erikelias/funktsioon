using System;

class Program
{
    static void Main(string[] args)
    {
        int meetriteArv = 1000; // Näide meetrite arvust
        string sugu = "mees"; // Näide jooksja soost

        string tulemus = Hindamine(meetriteArv, sugu);
        Console.WriteLine(tulemus);
    }

    public static string Hindamine(int meetrid, string soo)
    {
        int meesteMinMeetrid = 2800;
        int naisteMinMeetrid = 2600;
        int meesteMaxMeetrid = 2000;
        int naisteMaxMeetrid = 1800;

        int puuduMeetreid = 0;
        string hinne = "";

        if (soo.ToLower() == "mees")
        {
            if (meetrid >= meesteMinMeetrid)
            {
                hinne = "väga hea";
            }
            else if (meetrid < meesteMaxMeetrid)
            {
                hinne = "nõrk";
                puuduMeetreid = meesteMinMeetrid - meetrid;
            }
            else
            {
                hinne = "rahuldav";
            }
        }
        else if (soo.ToLower() == "naine")
        {
            if (meetrid >= naisteMinMeetrid)
            {
                hinne = "väga hea";
            }
            else if (meetrid < naisteMaxMeetrid)
            {
                hinne = "nõrk";
                puuduMeetreid = naisteMinMeetrid - meetrid;
            }
            else
            {
                hinne = "rahuldav";
            }
        }
        else
        {
            hinne = "Tundmatu sugu";
        }

        if (hinne == "nõrk" || hinne == "väga hea")
        {
            return $"{hinne}, jäi puudu {puuduMeetreid} meetrit";
        }
        else
        {
            return hinne;
        }
    }
}
using System.Collections.Generic;
using Patterns;

public class JigsawGameData : Singleton<JigsawGameData>
{
    // The image to be loaded for the level.
    public string mFilename;
    public double mSecondsSinceStart = 0;
    public int mTotalTilesInCorrectPosition = 0;

    public List<(string, string)> mNamedImages = new List<(string, string)>()
    {
        ("Nature1", "Images/image1"),
        ("Nature2", "Images/image2"),
        ("Nature3", "Images/image3"),
        ("Nature4", "Images/image4"),
        ("Nature5", "Images/image5"),
        ("Nature6", "Images/image6"),
        ("Nature7", "Images/image7"),
        ("Nature8", "Images/image8"),
        ("Nature9", "Images/image9"),
        ("Nature10", "Images/image10"),
    };
}
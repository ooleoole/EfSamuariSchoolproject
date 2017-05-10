namespace SamuraiWEB.ViewModels
{
    public class SamuraiViewModel
    {

        public int IdLevel1 { get; set; }
        public string Level1 { get; set; }
        public Level2 Level2 { get; set; }

    }

    public class Level2
    {
        public int IdLevel2 { get; set; }
        public string LevelString2 { get; set; }
        public Level3 Level3 { get; set; }
    }

    public class Level3
    {
        public int IdLevel3 { get; set; }
        public string LevelString3 { get; set; }
    }
}

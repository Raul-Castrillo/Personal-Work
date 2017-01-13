namespace Raul.Minesweeper.Library.Model
{
    public class Cell
    {
        public bool IsBomb { get; set; }
        public bool IsMarkedAsBomb { get; set; }
        public bool IsOpened { get; set; }
        public int Value { get; set; }
    }
}

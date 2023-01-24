namespace hubdejogos.Models.Chess{

    public abstract class Piece{

        public int Line { get; set; }
        public int Column { get; set; }
        public Color Color { get; set; }
        public string? Image { get; set; }
        public bool Eliminated { get; set; }
        public bool Selected { get; set; }
        public bool firstMove { get; set; } = true;

        public Piece(int line, int column, Color color, string image){
            Line = line;
            Column = column;
            Color = color;
            Image = image;
            Eliminated = false;
            Selected = false;
        }

        public abstract bool moveValidate(Board board, int destinyLine, int destinyColumn);

    }
}


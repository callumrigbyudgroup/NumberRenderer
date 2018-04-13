namespace NumberRenderer
{
    using System.Collections.Generic;

    public class TeenNumberRenderer : INumberRenderer
    {
        private Dictionary<int, string> numberWordStart = new Dictionary<int, string>
        {
            [13] = "Thir",
            [14] = "Four",
            [15] = "Fif",
            [16] = "Six",
            [17] = "Seven",
            [18] = "Eigh",
            [19] = "Nine"
        };

        public string ConvertNumberToWords(int value) => string.Concat(numberWordStart[value], "teen");
    }
}

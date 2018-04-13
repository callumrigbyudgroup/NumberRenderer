namespace NumberRenderer
{
    using System;

    public static class NumberRendererFactory
    {
        public static INumberRenderer Create(int value)
        {
            if (value < 0)
                throw new ArgumentException("Value can not be less than 0.", nameof(value));

            INumberRenderer numberRenderer = null;
            if (value <= 12)
                numberRenderer = new UnitAndTweenNumberRenderer();
            else if (value <= 19)
                numberRenderer = new TeenNumberRenderer();

            return numberRenderer;
        }
    }
}

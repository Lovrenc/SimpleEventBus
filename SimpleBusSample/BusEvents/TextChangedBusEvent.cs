namespace SimpleBusTest
{
    class TextChangedBusEvent
    {
        public readonly string Text;

        public TextChangedBusEvent(string val)
        {
            Text = val;
        }
    }
}
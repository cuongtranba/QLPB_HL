namespace Model.ViewModel
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public static ComboboxItem Empty = new ComboboxItem()
        {
            Text = string.Empty,
        };

        public override string ToString()
        {
            return Text;
        }
    }
}

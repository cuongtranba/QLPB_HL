namespace Model.ViewModel
{
    public class Component
    {
        public ComponentType Type { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
    }

    public enum ComponentType
    {
        Textbox,Combobox,RichTextBox
    }
}

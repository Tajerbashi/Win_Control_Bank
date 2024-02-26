namespace Account.Presentation.Generator
{
    public class ButtonGenerator
    {
        public Button CreateButton(int x,int y,string text)
        {
            var button = new Button();
            button.Text = text;
            button.Location = new Point(x, y);
            button.Size = new Size(500, 118);
            return button;
        }
    }
}

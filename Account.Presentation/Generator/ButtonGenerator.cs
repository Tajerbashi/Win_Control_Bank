namespace Account.Presentation.Generator
{
    public class ButtonGenerator
    {
        public Button CreateButton(int x, int y, string text, int width, int height)
        {
            var button = new Button();
            button.Text = text;
            button.Location = new Point(x, y);
            //button.Size = new Size(500, 118);
            button.Size = new Size(width, height);
            return button;
        }
    }
}

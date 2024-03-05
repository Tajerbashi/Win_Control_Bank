namespace Account.Presentation.Generator
{
    public class ButtonGenerator
    {
        public Button CreateButton(int x, int y, string text, int width, int height, Color back, Color fore)
        {
            var button = new Button();
            button.Text = text;
            button.Location = new Point(x, y);
            //button.Size = new Size(500, 118);
            button.Size = new Size(width, height);
            button.BackColor = back;
            button.ForeColor = fore;
            button.FlatStyle = FlatStyle.Flat;
            button.Cursor = Cursors.Hand;
            return button;
        }
    }
}

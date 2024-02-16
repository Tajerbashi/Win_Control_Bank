namespace Account.Presentation.Extentions
{
    public static class FormExtentions
    {
        public static void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

       
        public static void ClearLabel(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is Label)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearLabel(ctrl.Controls);
                }
            }
        }
        public static void ClearRichTextBox(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is RichTextBox)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearRichTextBox(ctrl.Controls);
                }
            }
        }

    }
}

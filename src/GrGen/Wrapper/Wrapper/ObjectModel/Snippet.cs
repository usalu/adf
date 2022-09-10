using System;
using System.Text;

namespace GrGenWrapper.ObjectModel
{
    /// <summary>
    /// Generic snippet for code parts.
    /// </summary>
    public class Snippet: IStatement
    {
        public string Text { get; set; }

        public Snippet(string text)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public void Write(StringBuilder builder)
        {
            builder.AppendLine(Text);
        }

    }
}

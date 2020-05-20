using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace text_wrap
{
    public class TextWrapper
    {
        public TextWrapper(){ }

        private string text = "";

        public TextWrapper Load(string fileName)
        {
            string currentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            text = System.IO.File.ReadAllText(Path.Combine(currentDirectory, fileName));
            return this;
        }

        public string Wrap(int lineSize)
        {
            return Regex.Replace(text, @"(.{1," + lineSize + @"})(\s|$)", "$1\n");
        }
    
    }

}


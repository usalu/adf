using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrGenWrapper.ObjectModel
{
    /// <summary>
    /// A GrGen file that can be serialized
    /// </summary>
    public abstract class GrGenFile
    {
        /// <summary>
        /// A unique name. Makes sure to only use letters as it will be part in many different parts with many restrictions.
        /// </summary>
        public string Name { get; }

        public abstract string FullName { get; }

        /// <summary>
        /// Everything that will be serialized is in that List.
        /// </summary>
        public List<IStatement> Statements { get; set; } = new List<IStatement>();
        /// <summary>
        /// A generic container for code snippets. No syntactical checks are performed. Only use this if you know what you are doing.
        /// </summary>
        public List<Snippet> Snippets { get; set; }

        public GrGenFile(string name, List<Snippet> snippets=null)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));
            Name = name;
            Snippets = snippets ?? new List<Snippet>();
           
        }

        /// <summary>
        /// Prepare is called before writing. It's main job is to add statements to the statement list.
        /// Call base.Prepare at the end to add all remaining generic parts.
        /// </summary>
        internal virtual void Prepare()
        {
            Statements.AddRange(Snippets);
        }
        public void Write(string folder)
        {
            var stringBuilder = new StringBuilder();
            Prepare();
            Statements.ForEach(x=>x.Write(stringBuilder));
            File.WriteAllText(Path.Combine(folder,FullName),stringBuilder.ToString());
        }
    }
}

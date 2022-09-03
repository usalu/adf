using System.Collections.Generic;

namespace GrGenWrapper.ObjectModel.GraphModels
{
    public class GraphModel:File
    {
        public GraphModel(string name, List<Snippet> snippets = null) : base(name, snippets)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication1.Api
{
    /// <summary>
    /// Dummy class that returns a comment containing html
    /// </summary>
    public class TestModel
    {
        public TestModel()
        {
            this.Name = "Some user";
            this.Comment = "<html><head></head><body><p>This is a comment</p></body></html>";
        }
        public string Name { get; set; }
        public string Comment { get; set; }
    }
}

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _AspNetCore_Testing.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Model> Modals { get; set; }
        public Make()
        {
            Modals=new Collection<Model>();
        }
    }
}
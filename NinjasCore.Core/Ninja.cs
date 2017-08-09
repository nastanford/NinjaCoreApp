using System;

namespace NinjasCore.Core
{
    public class Ninja
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Sex { get; set; }
        public DateTime Updated { get; set; }

        public Ninja()
        {
            this.Updated = DateTime.Now;
        }
    }

}

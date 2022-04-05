using System.Collections.Generic;

namespace HR_Management
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Position> GetPosition(string defaultPosition = "No Position")
        {
            return new List<Position>
            {
                new Position { Id = 0, Name = defaultPosition},
                new Position { Id = 1, Name = "Junior Office Worker" },
                new Position { Id = 2, Name = "Office Worker" },
                new Position{ Id = 3, Name = "Senior Office Worker"},
                new Position { Id = 4, Name = "Manager"},
                new Position { Id = 5, Name = "Director"},
                new Position{ Id = 6, Name = "CEO"}
                };
        }
    }
}

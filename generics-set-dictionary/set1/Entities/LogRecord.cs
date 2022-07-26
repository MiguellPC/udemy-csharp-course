using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1.Entities
{
    internal class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is not LogRecord)
            {
                return false;
            }

            LogRecord other = obj as LogRecord;

            return Username.Equals(other.Username);
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }
    }
}

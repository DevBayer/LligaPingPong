using Newtonsoft.Json;

namespace LligaPingPong
{
    public class League
    {
        [JsonIgnore]
        public string key;

        string name;
        string status;
        int matches_played = 0;
        int total_matches = 0;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int Matches_played
        {
            get
            {
                return matches_played;
            }

            set
            {
                matches_played = value;
            }
        }

        public int Total_matches
        {
            get
            {
                return total_matches;
            }

            set
            {
                total_matches = value;
            }
        }

        public override string ToString()
        {
            return name;
        }

    }

    public class InboundLeague : League
    {
        public long Timestamp { get; set; }
    }

    public class OutboundLeague : League
    {
        [JsonProperty("Timestamp")]
        public ServerTimeStamp TimestampPlaceholder { get; } = new ServerTimeStamp();
    }

    public class ServerTimeStamp
    {
        [JsonProperty(".sv")]
        public string TimestampPlaceholder { get; } = "timestamp";
    }


}
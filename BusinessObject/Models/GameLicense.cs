using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject.Models
{
    public partial class GameLicense
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string GameId { get; set; }
        public DateTime BuyTime { get; set; }
        public bool Status { get; set; }

        public virtual Game Game { get; set; }
        public virtual User User { get; set; }
    }
}

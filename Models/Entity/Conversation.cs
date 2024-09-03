using Belliso.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belliso.Models.Entity
{
    public class Conversation
    {
        [Key]
        public int Id { get; set; }
        public string CustomerUsername { get; set; } = null!;
        public int ManagerId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Manager Manager { get; set; } = null!;
        public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
    }

}

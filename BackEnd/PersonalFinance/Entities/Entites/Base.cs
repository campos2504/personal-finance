using Entities.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entites
{
    public class Base: Notify
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}

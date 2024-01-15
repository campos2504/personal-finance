using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notification
{
    public class Notify
    {
        public Notify() 
            => Notifications = [];
        [NotMapped]
        public string? PropertieName { get; set; }
        [NotMapped]
        public string Message { get; set; }
        [NotMapped]
        public List<Notify> Notifications { get; set; }

        public bool StringPropertieValidation(string value, string propertierName)
        {
            if (string.IsNullOrWhiteSpace(value)|| string.IsNullOrWhiteSpace(propertierName))
            {
                Notifications.Add(new Notify 
                { 
                    Message = "Field value is empty",
                    PropertieName = propertierName
                });

                return false;
            }  

            return true;
        }
        
        public bool IntPropertieValidaiton(int value, string propertierName)
        {
            if(value < 0 || string.IsNullOrWhiteSpace(propertierName))
            {
                Notifications.Add(new Notify
                {
                    Message = "Field value is invalid",
                    PropertieName = propertierName
                });
                return false;
            }
            return true;
        }
    }
}

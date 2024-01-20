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

        public bool StringPropertieValidation(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value)|| string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notify 
                { 
                    Message = "Field value is empty",
                    PropertieName = propertyName
                });

                return false;
            }  

            return true;
        }
        
        public bool IntPropertieValidaiton(int value, string propertyName)
        {
            if(value < 0 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notify
                {
                    Message = "Field value is invalid",
                    PropertieName = propertyName
                });
                return false;
            }
            return true;
        }
    }
}

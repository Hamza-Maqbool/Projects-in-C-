using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PMS_FORMS.BL
{
    class Staff
    {
        private string name;
        private string mobile;
        private string id;
        private string duty;

        public string Name { get => name; set => name = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        public string Id { get => id; set => id = value; }
        public string Duty { get => duty; set => duty = value; }

        public Staff(string Sname, string mobile, string id, string duty)
        {
            this.name = Sname;
            this.Mobile = mobile;
            this.Id = id;
            this.Duty = duty;
        }
        public Staff()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS_FORMS.BL
{
    class PhamacyName
    {
        private string pmsName;

        public string PmsName { get => pmsName; set => pmsName = value; }

        public PhamacyName(string pmsName)
        {
            this.pmsName = pmsName;
        }
        public PhamacyName()
        {

        }
    }
}

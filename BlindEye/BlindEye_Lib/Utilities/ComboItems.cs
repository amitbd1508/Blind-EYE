using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindEye_Lib.Utilities
{
    public class ComboItems
    {
        private string _ValueMember;

        public string ValueMember
        {
            get { return _ValueMember; }
            set { _ValueMember = value; }
        }
        private string _DisplayMember;

        public string DisplayMember
        {
            get { return _DisplayMember; }
            set { _DisplayMember = value; }
        }

    }
}

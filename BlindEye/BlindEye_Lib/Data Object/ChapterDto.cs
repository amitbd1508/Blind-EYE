using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindEye_Lib.Data_Object
{
    public class ChapterDto
    {
        private long _ChapterID;
        private string _ChapterName;
        private long _BookID;
        private string _Remarks;
        private DateTime _CreatedDate;
        private long _CreatedBy;
        private DateTime _ModifyDate;
        private long _ModifyedBy;

        public long ChapterID
        {
            get { return _ChapterID; }
            set { _ChapterID = value; }
        }
        public string ChapterName
        {
            get { return _ChapterName; }
            set { _ChapterName = value; }
        }
        public long BookID
        {
            get { return _BookID; }
            set { _BookID = value; }
        }
        public string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }
        public DateTime CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }
        public long CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }
        public DateTime ModifyDate
        {
            get { return _ModifyDate; }
            set { _ModifyDate = value; }
        }
        public long ModifyedBy
        {
            get { return _ModifyedBy; }
            set { _ModifyedBy = value; }
        }
    }
}

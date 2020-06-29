using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindEye_Lib.Data_Object
{
    public class ContentTextDto
    {
        private long _ContentID;

        public long ContentID
        {
            get { return _ContentID; }
            set { _ContentID = value; }
        }
        private long _ChapterID;

        public long ChapterID
        {
            get { return _ChapterID; }
            set { _ChapterID = value; }
        }
        private string _Content;

        public string Content
        {
            get { return _Content; }
            set { _Content = value; }
        }
        private string _Remarks;

        public string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }
        private DateTime _CreatedDate;

        public DateTime CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }
        private long _CreatedBy;

        public long CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }
        private DateTime _ModifyDate;

        public DateTime ModifyDate
        {
            get { return _ModifyDate; }
            set { _ModifyDate = value; }
        }
        private long _ModifyedBy;

        public long ModifyedBy
        {
            get { return _ModifyedBy; }
            set { _ModifyedBy = value; }
        }
        private long _BookID;

        public long BookID
        {
            get { return _BookID; }
            set { _BookID = value; }
        }
    }
}

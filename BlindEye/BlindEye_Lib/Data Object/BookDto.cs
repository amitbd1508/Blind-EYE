using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindEye_Lib.Data_Object
{
    public  class BookDto
    {

        #region Fields
        private long _BookID;
        private string _BookName;
        private string _AuthorName;
        private int _ReleseYear;
        private string _Remarks;
        private DateTime _CreatedDate;
        private long _CreatedBy;
        private DateTime _ModifyDate;
        private long _ModifyedBy;

        #endregion

        #region Properties
        public long BookID
        {
            get { return _BookID; }
            set { _BookID = value; }
        }
        public string BookName
        {
            get { return _BookName; }
            set { _BookName = value; }
        }
        public string AuthorName
        {
            get { return _AuthorName; }
            set { _AuthorName = value; }
        }
        public int ReleseYear
        {
            get { return _ReleseYear; }
            set { _ReleseYear = value; }
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
        #endregion
    }
}

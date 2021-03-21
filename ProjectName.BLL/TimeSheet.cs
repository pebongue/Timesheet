using System;
using System.Collections.Generic;
using System.Text;

namespace Aculocity.ProjectName.BLL
{
    class TimeSheet
    {
        private String Company;
        private String WorkCategory;
        private String Comments;
        private double Billable;
        private double Hours;
        private String Date;

        public String Comp
        {
            get
            {
                return Company;
            }
            set
            {
                Company = value;
            }
        }
        public String Work
        {
            get
            {
                return WorkCategory;
            }
            set
            {
                WorkCategory = value;
            }
        }
        public String Comm
        {
            get
            {
                return Comments;
            }
            set
            {
                Comments = value;
            }
        }
        public double Bill
        {
            get
            {
                return Billable;
            }
            set
            {
                Billable = value;
            }
        }
        public double Hour
        {
            get
            {
                return Hours;
            }
            set
            {
                Hours = value;
            }
        }
        public String Dat
        {
            get
            {
                return Date;
            }
            set
            {
                Date = value;
            }
        }
        
    }
}

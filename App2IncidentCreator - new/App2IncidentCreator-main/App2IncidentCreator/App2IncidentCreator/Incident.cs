using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2IncidentCreator
{
    internal class Incident
    {
        private string incidentID;
        private string incidentDate;
        private string reportedDate;
        private string comments;
        private string newIncidentMessage;
        Staff staff;


        public Incident()
        {
            this.incidentID = "ID1001";
            this.incidentDate = "06/10/2023";
            this.reportedDate = "07/10/2023";
            this.comments = "WebServer Login Error";
        }

        public Incident(string incidentID, string incidentDate, string reportedDate, string comments, Staff staff)
        {
            this.incidentID = incidentID;
            this.incidentDate = incidentDate;
            this.reportedDate = reportedDate;
            this.comments = comments;
            this.staff = staff;
        }
        public string IncidentID
        {
            get
            {
                return incidentID;
            }
            set
            {
                incidentID = value;
            }

        }
        public string IncidentDate
        {
            get
            {
                return incidentDate;
            }
            set
            {
                incidentDate = value;
            }
        }
        public string ReportedDate
        {
            get
            {
                return reportedDate;
            }
            set
            {
                reportedDate = value;
            }

        }
        public string Comments
        {
            get
            {
                return comments;
            }
            set
            {
                comments = value;
            }
        }

        public virtual string NewIncidentMessage()
        {
            return "New Incident created successfully";
        }
        public virtual void setnewIncidentMessage(string dosNewMessage)
        {
            newIncidentMessage = dosNewMessage;
        }
    }
}

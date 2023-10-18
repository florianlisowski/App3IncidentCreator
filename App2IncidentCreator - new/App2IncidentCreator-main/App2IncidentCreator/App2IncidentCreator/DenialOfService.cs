using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace App2IncidentCreator
{
    internal class DenialOfService : Incident
    {
        private string serverID;
        private string service;
        private string outcome;
        private string isActive;
        private string incidentMessage;
       //Line 18 and 19 are not required. This is because, the DenailOfService class is
       //already inheriting from the Incident class

        // The constructor should be

        public DenialOfService(string serverID, string service, string outcome, string incidentID, string incidentDate, string reportedDate, string comments, Staff staff):base( incidentID,  incidentDate,  reportedDate,  comments, staff) //base--> meams calls the constrcutor of the Incident class
        {
            this.serverID = serverID;
            this.service = service;
            this.outcome = outcome;

            //You have not done anything to the isActive and incidentMessage in the constructor?
        }

        

       /* Incident incident;
        Staff staff;

        public DenialOfService(string serverID, string service, string outcome, Incident incident,Staff staff) 
        {
            this.serverID = serverID;
            this.service = service;
            this.outcome = outcome;
            this.incident = incident;
            this.staff = staff;
            
        }

        public DenialOfService()
        {

        }*/

        public string ServerID
        {
            get
            {
                return serverID;
            }
            set
            {
                serverID = value;
            }
        }
        public string Service
        {
            get
            {
                return service;
            }
            set
            {
                service = value;
            }
        }
        public string Outcome
        {
            get
            {
                return outcome;
            }
            set
            {
                outcome = value;
            }
        }
        public string IsActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
            }
        }
        public string IncidentMeassage      
        {
            get
            {
                return incidentMessage;
            }
        }
        public string dosNewMessage()
        {
            return "New Denial of Service incident created successfully";
        }
        public override void setnewIncidentMessage(string dosNewMessage)
        {
            incidentMessage = dosNewMessage;
        }


    }
}

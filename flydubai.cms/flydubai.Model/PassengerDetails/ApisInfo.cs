namespace flydubai.Model.PassengerDetails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Apis Info
    /// </summary>
    public class ApisInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApisInfo"/> class.
        /// </summary>
        public ApisInfo()
        {
            this.APIS_INFO_INDEX = int.MinValue;
            this.SERIES_NUM = "299";
        }

        public int APIS_INFO_INDEX { get; set; }
        public string SERIES_NUM { get; set; }
        public string CONFIRMATION_NUM { get; set; }
        public int RECORD_NUM { get; set; }
        public string LAST_NAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string MIDDLE_NAME { get; set; }
        public DateTime BIRTH_DATE { get; set; }
        public string GENDER { get; set; }
        public string CITIZENSHIP { get; set; }
        public string RESIDENCE_COUNTRY { get; set; }
        public string STATUS { get; set; }
        public string CREW_TYPE { get; set; }
        public string HOME_ADDRESS { get; set; }
        public string HOME_CITY { get; set; }
        public string HOME_STATE { get; set; }
        public string HOME_POSTAL { get; set; }
        public string HOME_COUNTRY { get; set; }
        public string DEST_ADDRESS { get; set; }
        public string DEST_CITY { get; set; }
        public string DEST_STATE { get; set; }
        public string DEST_POSTAL { get; set; }
        public string DEST_COUNTRY { get; set; }
        public string EMBARKATION { get; set; }
        public string BIRTH_CITY { get; set; }
        public string BIRTH_STATE { get; set; }
        public string BIRTH_COUNTRY { get; set; }
        public string DOCUMENT_TYPE1 { get; set; }
        public string DOCUMENT_NUMBER1 { get; set; }
        public string ISSUE_COUNTRY1 { get; set; }
        public DateTime EXPIRY_DATE1 { get; set; }
        public string DOCUMENT_TYPE2 { get; set; }
        public string DOCUMENT_NUMBER2 { get; set; }
        public string ISSUE_COUNTRY2 { get; set; }
        public DateTime EXPIRY_DATE2 { get; set; }
        public int RESULT_CODE { get; set; }
        public string RESULT_MESSAGE { get; set; }
        public int PHYSICAL_FLIGHT_ID { get; set; }
        public int OA_FLIGHT_ID { get; set; }
        public DateTime ACTUAL_DEPART_DATE { get; set; }
        public string FLIGHT_NUMBER { get; set; }
        public string DEBARKATION { get; set; }
        public string ARRIVAL { get; set; }
        public int DOCUMENT_SCANNED1 { get; set; }
        public int DOCUMENT_SCANNED2 { get; set; }
    }
}

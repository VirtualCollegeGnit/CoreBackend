using System;

namespace core.data.Model.Member
{
    public class Document
    {
        public Document(bool isMedia, bool isAccepted, DateTime dateTime, string data, string documentType)
        {
            IsMedia = isMedia;
            IsAccepted = isAccepted;
            DateTime = dateTime;
            Data = data;
            DocumentType = documentType;
        }

        public int ID { get; set; }
        public bool IsMedia { get; set; }
        public bool IsAccepted { get; set; }
        public Admin? AcceptedBy { get; set; }
        public DateTime DateTime { get; set; }
        public string Data { get; set; }
        public string DocumentType { get; set; }
        public Member? Member { get; set; }
    }
}

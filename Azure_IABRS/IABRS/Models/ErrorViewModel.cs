using System;

//Class: ErrorViewModel
//Summary: This class contains information about an error that has occured

namespace IABRS.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
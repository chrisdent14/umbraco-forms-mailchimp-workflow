﻿namespace CD.UmbracoFormsMailchimpWorkflow.Models.Api.Response
{
    public class MailchimpErrorResponse
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public string Detail { get; set; }
        public string Instance { get; set; }
    }
}
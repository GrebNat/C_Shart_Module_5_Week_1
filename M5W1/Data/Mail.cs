﻿namespace M5W1.M5W1.Data
{
    public class Mail
    {
        public string mailTo;
        public string body;
        public string subject;

        public Mail(string mailTo, string body, string subject)
        {
            this.mailTo = mailTo;
            this.body = body;
            this.subject = subject;
        }
    }

}

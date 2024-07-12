﻿namespace WebUI.Dtos.SendMessageDto
{
    public class ResultSendMessageDto
    {
        public int Id { get; set; }
        public string Receiver { get; set; }
        public string ReceiverMail { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}

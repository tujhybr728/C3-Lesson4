﻿using MailSender.lib.Entityes.Base;

namespace MailSender.lib.Entityes
{
    public class Server : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Port { get; set; }
        public bool UseSSL { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }
    }
}
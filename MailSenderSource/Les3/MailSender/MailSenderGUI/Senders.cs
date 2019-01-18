﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.Service;

namespace MailSender.GUI
{
    /// <summary>
    /// Этот класс надо убрать переместив логику в модель представления, а данные в базу данных
    /// </summary>
    class Senders
    {
        public static Dictionary<string, string> SendersList { get; } = new Dictionary<string, string>
        {
            { "Sender1@server.ru", PasswordService.Encode("password1", 2) },
            { "Sender2@server.ru", PasswordService.Encode("Password2", 2) },
            { "Sender3@server.ru", PasswordService.Encode("pAssword3", 2) },
            { "Sender4@server.ru", PasswordService.Encode("paSsword4", 2) },
            { "Sender5@server.ru", PasswordService.Encode("passWord5", 2) },
        };
    }

   
}

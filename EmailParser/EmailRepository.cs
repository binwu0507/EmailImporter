using EAGetMail;
using EmailParser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailParser
{
    public class EmailRepository
    {
        private string Imap4Server = "imap.allstar.technology";
        private string eMailAddress;
        private string passWord;

        public EmailRepository(string emailAddress, string passWord)
        {
            this.eMailAddress = emailAddress;
            this.passWord = passWord;
        }
        public IEnumerable<MailPreview> GetMailPreviews(DateTime startDate, string senders = null)
        {
            MailServer server = new MailServer(Imap4Server, eMailAddress, passWord, ServerProtocol.Imap4);
            MailClient client = new MailClient("TryIt");

            server.SSLConnection = true;
            server.Port = 993;

            client.Connect(server);
            int count = client.GetMailCount();


            string startDateString = startDate.ToString("dd-MMM-yyyy");
            //            MailInfo[] mailInfos = client.SearchMail("ALL SINCE 30-JUL-2019 OR FROM WayfairOps5@wayfair.com FROM Lili@metrotex.com");//client.GetMailInfos();
            string searchFilter = "ALL SINCE " + startDateString + " OR FROM WayfairOps5@wayfair.com FROM Lili@metrotex.com";
            if(!String.IsNullOrEmpty(senders))
            {
                string[] senderArray = senders.Split(new char[] { ',', ';' });
                if(senderArray.Length > 0)
                {
                    searchFilter = "ALL OR";
                    foreach(string sender in senderArray)
                    {
                        searchFilter += " FROM " + sender.Trim();
                    }
                }
            }
            MailInfo[] mailInfos = client.SearchMail(searchFilter);//client.GetMailInfos();


            List<MailPreview> mailPreviews = new List<MailPreview>();
            for(int i= mailInfos.Length-1; i>= 0; i--)
            {
                Mail mail = new Mail("TryIt");
                mail.Load(client.GetMailHeader(mailInfos[i]));
                mailPreviews.Add(new MailPreview { Subject = mail.Subject, ReceivedDateTime = mail.ReceivedDate, From  = String.Format("{0} <{1}>",mail.From.Name, mail.From.Address), MailInfo = mailInfos[i] });
            }


            return mailPreviews;
        }

        public Mail GetMailDetail(MailInfo mailInfo)
        {
            MailServer server = new MailServer("imap.gmail.com", eMailAddress, passWord, ServerProtocol.Imap4);
            MailClient client = new MailClient("TryIt");

            server.SSLConnection = true;
            server.Port = 993;

            client.Connect(server);

            return client.GetMail(mailInfo);

        }
        //MailServer
    }
}

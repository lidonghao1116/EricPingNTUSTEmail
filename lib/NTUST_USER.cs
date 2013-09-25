using OpenPop.Mime;
using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using Message = OpenPop.Mime.Message;

namespace EricPingNTUSTEmail.lib
{
    public enum LoginStatus { ServerError, InvalidUser, Success };

    public class NTUST_USER
    {
        public Pop3Client pop3;

        public SmtpClient smtp;

        public List<Message> MailList = new List<Message>();
        public List<String> AttachmentList = new List<String>();
        public List<String> ReceiverList = new List<String>();
        private readonly string _server = "mail.ntust.edu.tw";
        public string _user { get; set; }
        public string _password { get; set; }
        private string folder;
        public string _folder
        {
            get
            {
                return this.folder;
            }
            set
            {
                value = value + "/attachFile";
                DirectoryInfo d = new DirectoryInfo(value);
                if (d.Exists) d.Delete(true);
                d.Create();
                this.folder = value;
            }
        }

        public int MessageCount
        {
            get
            {
                return this.pop3.GetMessageCount();
            }
        }

        public LoginStatus _status;

        public void setUserPassword(string user, string password)
        {
            this._user = user;
            this._password = password;
        }

        public long DirSize(String dir)
        {
            // 1.
            // Get array of all file names.
            string[] a = Directory.GetFiles(dir.ToString(), "*.*");

            // 2.
            // Calculate total bytes of all files in a loop.
            long b = 0;
            foreach (string name in a)
            {
                // 3.
                // Use FileInfo to get length of each file.
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }
            // 4.
            // Return total size
            return b;
        }

        #region POP
        public Boolean ConnectPop()
        {
            this.pop3 = new Pop3Client();
            try
            {
                if (this.pop3.Connected)
                    this.pop3.Disconnect();
                this.pop3.Connect(_server, 995, true);
                try
                {
                    this.pop3.Authenticate(_user, _password);
                    Console.WriteLine("Login Success!!!");
                    this._status = LoginStatus.Success;
                    return true;
                }
                catch
                {
                    Console.WriteLine("Login Failed!!!");
                    this._status = LoginStatus.InvalidUser;
                    return false;
                }
            }
            catch
            {
                Console.WriteLine("Cannot connect to server");
                this._status = LoginStatus.ServerError;
                return false;
            }
        }

        public void addMail(Message email)
        {
            this.MailList.Add(email);
        }

        public Boolean ProgressEmail(Message email, int MsgId)
        {
            Directory.CreateDirectory(this._folder + "\\" + MsgId);
            Byte[] content = null;
            String cont = null;
            try
            {
                content = email.FindFirstHtmlVersion().Body;
                cont = Encoding.Default.GetString(content);
            }
            catch
            {
                content = email.FindFirstPlainTextVersion().Body;
                cont = Encoding.UTF8.GetString(content);
            }
            finally
            {
                using (FileStream fs = File.OpenWrite(this._folder + "\\" + MsgId + "\\" + "index.html"))
                {
                    if (content.Length != 0)
                    {
                        cont = Regex.Replace(cont, @"@[A-Za-z0-9.]*", "").Replace("cid:", "");
                    }
                    else
                    {
                        cont = email.FindFirstPlainTextVersion().GetBodyAsText();
                        System.Windows.Forms.MessageBox.Show(cont);
                    }
                    content = Encoding.Default.GetBytes(cont);
                    fs.Write(content, 0, content.Length);
                }

                foreach (MessagePart attachment in email.FindAllAttachments())
                {
                    attachment.Save(new System.IO.FileInfo(this._folder + "\\" + MsgId + "\\" + attachment.FileName));
                }
            }
            return true;
        }

        #endregion

        public Boolean ConnectSmtp()
        {
            try
            {
                this.smtp = new SmtpClient(this._server, 25);
                this.smtp.Credentials = new NetworkCredential(this._user, this._password);
                //this.smtp.EnableSsl = true; //台科不支援        
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public Boolean sendMail(String subject, String body)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.Subject = subject;
                message.Body = body;
                message.From = new MailAddress(this._user + "@" + this._server, this._user);

                foreach (String email in this.ReceiverList)
                {
                    message.To.Add(email);
                }

                foreach (String attach in this.AttachmentList)
                {
                    message.Attachments.Add(new Attachment(attach));
                }
                this.smtp.Send(message);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public Boolean addReceiver(String email)
        {
            Boolean result = Regex.IsMatch(email, @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                  @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$", RegexOptions.IgnoreCase);
            if (this.ReceiverList.Contains(email))
            {
                return false;
            }
            if (result) this.ReceiverList.Add(email);
            return result;
        }

        public Boolean addAttachment(String path)
        {
            FileInfo p = new FileInfo(path);
            if (p.Exists == false)
            {
                return false;
            }
            else
            {
                if (this.AttachmentList.Contains(path))
                {
                    return false;
                }
                this.AttachmentList.Add(path);
                return true;
            }
        }

    }

}

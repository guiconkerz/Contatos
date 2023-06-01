using System.Net;
using System.Net.Mail;

namespace Contatos.Helper
{
    public class Email : IEmail
    {
        private readonly IConfiguration _configuration;

        public Email(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public bool EnviarEmail(string email, string assunto, string mensagem)
        {
            try
            {
                string host = _configuration.GetValue<string>(key: "SMTP:Host");
                string nome = _configuration.GetValue<string>(key: "SMTP:Nome");
                string username = _configuration.GetValue<string>(key: "SMTP:UserName");
                string senha = _configuration.GetValue<string>(key: "SMTP:Senha");
                int porta = _configuration.GetValue<int>(key: "SMTP:Porta");

                //Adiciona destino do email
                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(address: username, displayName: nome)
                };

                mail.To.Add(email);
                //Define o assunto
                mail.Subject = assunto;
                //Define a mensagem
                mail.Body = mensagem;
                //Habilita codigo html para o email
                mail.IsBodyHtml = true;
                //Define a prioridade do envio do email
                mail.Priority = MailPriority.High;

                using (SmtpClient smtp = new SmtpClient(host: host, port: porta))
                {
                    //Define as credenciais do email
                    smtp.Credentials = new NetworkCredential(userName: username, password: senha);
                    //Define o envio de email seguro
                    smtp.EnableSsl = true;

                    smtp.Send(message: mail);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

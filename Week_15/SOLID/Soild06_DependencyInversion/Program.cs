//using Soild06_DependencyInversion.Before;
using Soild06_DependencyInversion.After;
namespace Soild06_DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before
            //MailService mailService = new MailService();
            //mailService.SendMail(new GmailServer());
            #endregion

            #region After
            MailService mailService = new MailService();
            mailService.SendMail(new GmailServer(),"cemre@gmail.com","selam");
            mailService.SendMail(new HotmailServer(),"cemre@gmail.com","selam");
            #endregion
        }
    }
}
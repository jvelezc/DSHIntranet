using DSH.Intranet.Data.Contracts;
using DSH.Intranet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;

/// <summary>
/// Chad Corrin, 2/22/13 - This is just a generic utility controller I use for MISC methods that dont belong to a model object
/// </summary>
namespace DSH.Intranet.Web.Controllers
{
    public class UtilityController : ApiControllerBase
    {
        public UtilityController(IUnitOfWork uow)
        {
            Uow = uow;
        }

        public UtilityController() { }

        // Create a new record
        // POST /api/utility/sendmail
        //public HttpResponseMessage SendMail(Contact mailMessage)
        //{
        //    // Send email
        //    MailMessage mMailMessage = new MailMessage();
        //    mMailMessage.From = new MailAddress("contact@yourdomain.com");
        //    mMailMessage.To.Add("lawn.and.so.on@gmail.com");
        //    //mMailMessage.To.Add(new MailAddress("myaddress@mydomain.com"));
        //    mMailMessage.Subject = "New website message from: " + mailMessage.From;
        //    mMailMessage.Body = "New website message from: " + mailMessage.FromEmail + "<br/>" + mailMessage.Message;
        //    mMailMessage.IsBodyHtml = true;
        //    mMailMessage.Priority = MailPriority.Normal;
        //    SmtpClient mSmtpClient = new SmtpClient();
        //    NetworkCredential basicCredential = new NetworkCredential("EMAIL", "PASSWORD");
        //    mSmtpClient.Host = "smtp.yourserver.net";
        //    mSmtpClient.Port = 25;
        //    mSmtpClient.EnableSsl = false;
        //    mSmtpClient.UseDefaultCredentials = false;
        //    mSmtpClient.Credentials = basicCredential;
        //    mSmtpClient.Send(mMailMessage);

        //    var response = Request.CreateResponse(HttpStatusCode.Created, mailMessage);
        //    return response;
        //}
    }
}

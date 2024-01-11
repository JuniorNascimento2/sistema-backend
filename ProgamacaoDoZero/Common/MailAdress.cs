using System.Net.Mail;

namespace ProgamacaoDoZero.Common
{
    internal class MailAdress : MailAddress
    {
        public MailAdress(string address) : base(address)
        {
        }
    }
}
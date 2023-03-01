namespace DesignPatterns_Singleton_1.Services
{
    public class EmailLogger : ICustomLogger
    {
        private readonly string emailRecipient;

        public EmailLogger()
        {

        }

        public EmailLogger(string EmailRecipient)
        {
            emailRecipient = EmailRecipient;
        }
        public void Log(string message)
        {
            //Example to send a mail with this message to the email recipient
        }
    }
}

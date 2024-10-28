namespace KVSC.Application.Interface.IService;

public interface IEmailService
{
    Task<string> SendForgetPasswordEmail(string toEmail, string userName, string resetLink);

    public Task<string> SendAccountActivationEmail(string toEmail, string userName, string activationLink);

}
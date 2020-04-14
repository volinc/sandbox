using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace SendGridTest
{
    internal class Program
    {
        private const string HtmlContent =
@"<html>
<head>
<title></title>
</head>
<body>
Этот адрес электронной почты был указан при регистрации в сервисе @Model.ServiceName.<br />
Для подтверждения регистрации перейдите <a href=""@Model.Url"">по ссылке</a> или введите код самостоятельно.<br />
Ваш код подтверждения: @Model.Code<br />
Если Вы не отправляли запрос на регистрацию в сервисе @Model.ServiceName, то просто проигнорируйте это письмо.<br /><br />
Спасибо, что Вы с нами.<br />
Ваш @Model.ServiceName<br />
</body>
</html>";

        private const string PlainTextContent =
@"Этот адрес электронной почты был указан при регистрации в сервисе @Model.ServiceName.
Для подтверждения регистрации перейдите по ссылке или введите код самостоятельно.
Ваш код подтверждения: @Model.Code
Если Вы не отправляли запрос на регистрацию в сервисе @Model.ServiceName, то просто проигнорируйте это письмо.
Спасибо, что Вы с нами.
Ваш @Model.ServiceName";

        private async static Task Main()
        {
            var apiKey = Environment.GetEnvironmentVariable("ApiKey");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("test@example.com", "Example User");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("test@example.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}

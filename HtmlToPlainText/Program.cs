namespace HtmlToPlainText
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        private static void Main()
        {
            const string htmlString = 
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

            var plainText = GetPlainTextFromHtml(htmlString);
            Console.WriteLine(plainText);
        }

        private static string GetPlainTextFromHtml(string htmlString)
        {
            const string htmlTagPattern = "<.*?>";
            var regexCss = new Regex(@"(\\<script(.+?)\\)|(\\<style(.+?)\\)", RegexOptions.Singleline | RegexOptions.IgnoreCase);
            htmlString = regexCss.Replace(htmlString, string.Empty);
            htmlString = Regex.Replace(htmlString, htmlTagPattern, string.Empty);
            htmlString = Regex.Replace(htmlString, @"^\s+$[\r\n]*", "", RegexOptions.Multiline);
            //htmlString = htmlString.Replace(" ", string.Empty);

            return htmlString;
        }
    }
}

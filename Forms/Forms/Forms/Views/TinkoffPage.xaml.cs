using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TinkoffPage : ContentPage
	{
		public TinkoffPage()
		{
			InitializeComponent ();

            var htmlSource = new HtmlWebViewSource
            {
                Html = 
@"
<html>
<head><title>Tinkoff</title></head>
<body>
<style>.tinkoffPayRow{display:block;margin:1%;width:160px;}</style>
<script src=""https://securepay.tinkoff.ru/html/payForm/js/tinkoff.js""></script>
<form name=""TinkoffPayForm"" onsubmit=""pay(this); return false;"">
<input class=""tinkoffPayRow"" type=""hidden"" name=""terminalkey"" value=""TinkoffBankTest"">
<input class=""tinkoffPayRow"" type=""hidden"" name=""frame"" value=""true"">
<input class=""tinkoffPayRow"" type=""hidden"" name=""language"" value=""ru"">
<input class=""tinkoffPayRow"" type=""text"" placeholder=""Сумма заказа"" name=""amount"" required>
<input class=""tinkoffPayRow"" type=""text"" placeholder=""Номер заказа"" name=""order"">
<input class=""tinkoffPayRow"" type=""text"" placeholder=""Описание заказа"" name=""description"">
<input class=""tinkoffPayRow"" type=""text"" placeholder=""ФИО плательщика"" name=""name"" >
<input class=""tinkoffPayRow"" type=""text"" placeholder=""E-mail"" name=""email"">
<input class=""tinkoffPayRow"" type=""text"" placeholder=""Контактный телефон"" name=""phone"">
<input class=""tinkoffPayRow"" type=""submit"" value=""Оплатить"">
</form></body>
</html>
"
            };

            Browser.Source = htmlSource;            
		}
	}
}
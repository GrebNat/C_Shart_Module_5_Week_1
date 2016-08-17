using M5W1.M5W1.Data;
using M5W1.M5W1.PO;
using M5W1.M5W1.Test.DataProvider;
using NUnit.Framework;

namespace M5W1.M5W1.Test.TestScenarious.GoogleTest
{
    [TestFixture]
    class GoogleTest : BaseTest
    {

        [Test, TestCaseSource(typeof(MailProvider),"testMail")]
        public void VerifyMailSentCorrectly(Mail mail, User user)
        {
            AccountPanel accountPanel = new AccountPanel(driver);

            new MainPage(driver).Login(user);
            accountPanel.VerifyLogin();

            accountPanel
                    .NavigateMailPage()
                    .CreateNewMail(mail)
                    .CloseMailDialog()
                    .VerifyMailPresentInDraftFolder(mail)
                    .VerifyMailContentInDraftFolder(mail)
                    .SendMail()
                    .VerifyMailPresentInDraftFolder(mail)
                    .VerifyMailPresentInSentFolder(mail);

            accountPanel.Logoff();
        }

    }
}

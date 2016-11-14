using Nancy;
using FriendLetter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables();
        myLetterVariables.SetRecipient("Jessica");
        myLetterVariables.SetSender("John");
        myLetterVariables.SetItems("some dumb shirt");
        myLetterVariables.SetLocation("Canada");
        return View["hello.cshtml", myLetterVariables];
      };
    }
  }
}

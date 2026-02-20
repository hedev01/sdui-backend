using Server_Driven_UI.Application.Features.Login.Interfaces;
using Server_Driven_UI.Domain.Entities;

namespace Server_Driven_UI.Application.Features.Login.Services
{
    public class LoginService : ILoginScreenService
    {
        public Screen GetLoginScreen()
        {
            return new Screen
            {
                ScreenId = "Login",
                Components = new List<Component> {
                new Component{
                Type = "Image",
                Value = "/Images/Login/SignIn.svg",
                },
                new Component{
                Type = "Text",
                Value = "Welcome Back!",
                Size = 40
                },
                 new Component{
                Type = "Text",
                Value = "welcome back we missed you",
                Size = 14
                },
                 new Component{
                 Type = "TextField",
                 Title = "UserName"
                 },
                    new Component{
                 Type = "TextField",
                 Title = "Password"
                 },
                    new Component{ 
                    Type = "Text",
                    Value = "Forgot Password?",

                    },
                    new Component{ 
                        Type = "Button",
                        Title = "SignIn"
                        
                    }

            }
            };
        }
    }
}

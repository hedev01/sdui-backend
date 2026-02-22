using System.Drawing;
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
                Value = "/Images/Login/SignIn.png",
                },
                 new Component{
                Type = "Positioned",
                },
                new Component{
                Type = "Text",
                Value = "خوش اومدید",
                Size = 40,
                FontFamily = "IRANSansBold",
                Color = "#FFFFFF",
                Align = "center",

                },
                 new Component{
                Type = "Text",
                Value = "خوش برگشتی دلمون برات تنگ شده بود",
                Size = 16,
                FontFamily = "IRANSans",
                Color = "#FFFFFF",
                Align = "center",
                },
                 new Component{
                 Type = "TextField",
                 Title = "نام کاربری",
                 FontFamily = "IRANSans",
                 Size = 14,
                 prefixIcon = "/Images/Login/UserName.png"
                 },
                    new Component{
                 Type = "TextField",
                 Title = "رمز عبور",
                 FontFamily = "IRANSans",
                 Size = 14,
                 prefixIcon = "/Images/Login/Password.png",
                 suffixIcon = "/Images/Login/Obscure.png"
                 },
                    new Component{
                    Type = "Text",
                    Value = "فراموشی رمز عبور؟",
                      Size = 14,
                      FontFamily = "IRANSans",
                      Align = "right",
                    },
                    new Component{
                        Type = "Button",
                        Title = "وارد شوید",
                        Size = 18,
                        Color = "#FFFFFF",
                        FontFamily = "IRANSansBold",
                    }

            }
            };
        }
    }
}

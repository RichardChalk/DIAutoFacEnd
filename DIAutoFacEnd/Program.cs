using Autofac;
using DIAutoFacEnd;
using WithDI;

var myContainerBuilder = new ContainerBuilder();

myContainerBuilder.RegisterModule<ProgramModule>();

var myContainer = myContainerBuilder.Build();

var notificationService = myContainer.Resolve<INotificationService>();
var userService = myContainer.Resolve<UserService>();

var user1 = new User("Richard");

userService.ChangeUserName(user1, "Richard the Lionheart (With DI)");

Console.ReadLine();



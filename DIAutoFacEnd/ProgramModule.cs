﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithDI;

namespace DIAutoFacEnd
{
    public class ProgramModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleNotification>()
                .As<INotificationService>();
            builder.RegisterType<UserService>()
                .AsSelf();
        }
    }
}

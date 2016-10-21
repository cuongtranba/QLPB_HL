using System;
using Autofac;

namespace QLPB_HL
{
    public class IOCFactory
    {
        public static T Do<T>(Func<ILifetimeScope,T> action)
        {
            using (var scope=Program.Container.BeginLifetimeScope("FormScope"))
            {
                return action.Invoke(scope);
            }
        }
    }
}

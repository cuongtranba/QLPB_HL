using System;
using System.ComponentModel;

namespace _4.Helper
{
    public class LocalizedDisplayNameAttribute : DisplayNameAttribute
    {
        public LocalizedDisplayNameAttribute(string resourceId)
        : base(GetMessageFromResource(resourceId))
        { }

        private static string GetMessageFromResource(string resourceId)
        {
            return StringName.ResourceManager.GetString(resourceId);
        }
    }

    public class HiddenColumn : Attribute
    {
        
    }
}

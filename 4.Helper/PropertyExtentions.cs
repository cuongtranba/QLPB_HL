using System.Reflection;

namespace _4.Helper
{
    public static class PropertyExtentions
    {
        public static void TrySetProperty(this object obj, string property, object value)
        {
            var prop = obj.GetType().GetProperty(property, BindingFlags.Public | BindingFlags.Instance);
            if (prop != null && prop.CanWrite)
                prop.SetValue(obj, value, null);
        }
    }
}

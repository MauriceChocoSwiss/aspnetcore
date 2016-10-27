// <auto-generated />
namespace Microsoft.AspNetCore.Razor.Evolution
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Razor.Evolution.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The '{0}' operation is not valid when the builder is empty.
        /// </summary>
        internal static string IRBuilder_PopInvalid
        {
            get { return GetString("IRBuilder_PopInvalid"); }
        }

        /// <summary>
        /// The '{0}' operation is not valid when the builder is empty.
        /// </summary>
        internal static string FormatIRBuilder_PopInvalid(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("IRBuilder_PopInvalid"), p0);
        }

        /// <summary>
        /// The '{0}' phase requires a '{1}' provided by the '{2}'.
        /// </summary>
        internal static string PhaseDependencyMissing
        {
            get { return GetString("PhaseDependencyMissing"); }
        }

        /// <summary>
        /// The '{0}' phase requires a '{1}' provided by the '{2}'.
        /// </summary>
        internal static string FormatPhaseDependencyMissing(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("PhaseDependencyMissing"), p0, p1, p2);
        }

        /// <summary>
        /// The phase must be initialized by setting the '{0}' property.
        /// </summary>
        internal static string PhaseMustBeInitialized
        {
            get { return GetString("PhaseMustBeInitialized"); }
        }

        /// <summary>
        /// The phase must be initialized by setting the '{0}' property.
        /// </summary>
        internal static string FormatPhaseMustBeInitialized(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("PhaseMustBeInitialized"), p0);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}

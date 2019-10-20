using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace MyLeasing.Common.Helpers
{
    public static class Settings
    {//TODO: FORMA DE HACER UNA PERSISTENCIA DE DATOS,  SE DECLARAN LAS VARIABLES PRIVADAS DE LO QUE SE DESEA GUARDAR
        //Y LUEGO SE HACE LA PROPIEDAD PUBLICA
        private const string _propertyImages = "PropertyImages";
        private const string _property = "property";
        private const string _token = "token";
        private const string _owner = "owner";
        private const string _isRemembered = "IsRemembered";
        private static readonly string _settingsDefault = string.Empty;
        private static readonly bool _boolDefault = false;

        private static ISettings AppSettings => CrossSettings.Current;

        public static string PropertyImages
        {
            get => AppSettings.GetValueOrDefault(_propertyImages, _settingsDefault);
            set => AppSettings.AddOrUpdateValue(_propertyImages, value);
        }
        public static string Property
        {
            get => AppSettings.GetValueOrDefault(_property, _settingsDefault);
            set => AppSettings.AddOrUpdateValue(_property, value);
        }
        public static string Token
        {
            get => AppSettings.GetValueOrDefault(_token, _settingsDefault);
            set => AppSettings.AddOrUpdateValue(_token, value);
        }

        public static string Owner
        {
            get => AppSettings.GetValueOrDefault(_owner, _settingsDefault);
            set => AppSettings.AddOrUpdateValue(_owner, value);
        }
        public static bool IsRemembered
        {
            get => AppSettings.GetValueOrDefault(_isRemembered, _boolDefault);
            set => AppSettings.AddOrUpdateValue(_isRemembered, value);
        }

    }
}

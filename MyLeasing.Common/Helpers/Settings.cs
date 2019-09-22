using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace MyLeasing.Common.Helpers
{
    public static class Settings
    {//TODO: FORMA DE HACER UNA PERSISTENCIA DE DATOS,  SE DECLARAN LAS VARIABLES PRIVADAS DE LO QUE SE DESEA GUARDAR
        //Y LUEGO SE HACE LA PROPIEDAD PUBLICA
        private const string _propertyImages = "PropertyImages";
        private const string _property = "property";
        private static readonly string _settingsDefault = string.Empty;

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
    }
}

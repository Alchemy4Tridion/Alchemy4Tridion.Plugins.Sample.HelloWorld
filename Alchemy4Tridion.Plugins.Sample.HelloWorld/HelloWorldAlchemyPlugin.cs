
namespace Alchemy4Tridion.Plugins.Sample.HelloWorld
{
    /// <summary>
    /// The heart and soul of your plugin, every plugin must have one, no less and no more, of a class
    /// that inherits from AlchemyPluginBase. Nothing extra is needed.
    /// </summary>
    public class HelloWorldAlchemyPlugin : AlchemyPluginBase
    {
        /// <summary>
        /// Override the Configure class to set any custom settings or services that your plugin may need.
        /// </summary>
        /// <param name="services"></param>
        public override void Configure(IPluginServiceLocator services)
        {
            // this sets a custom key that you can then use to decrypt any encrypted custom settings with
            services.SettingsEncryptor.EncryptionKey = "HelloWorldKey";
        }
    }
}

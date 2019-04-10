namespace Pos_V9.ServiceReference1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.Threading.Tasks;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), DebuggerStepThrough]
    public class GlobalWeatherSoapClient : ClientBase<GlobalWeatherSoap>, GlobalWeatherSoap
    {
        public GlobalWeatherSoapClient()
        {
        }

        public GlobalWeatherSoapClient(string endpointConfigurationName) : base(endpointConfigurationName)
        {
        }

        public GlobalWeatherSoapClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
        {
        }

        public GlobalWeatherSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
        {
        }

        public GlobalWeatherSoapClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
        {
        }

        public string GetCitiesByCountry(string CountryName)
        {
            return base.Channel.GetCitiesByCountry(CountryName);
        }

        public Task<string> GetCitiesByCountryAsync(string CountryName)
        {
            return base.Channel.GetCitiesByCountryAsync(CountryName);
        }

        public string GetWeather(string CityName, string CountryName)
        {
            return base.Channel.GetWeather(CityName, CountryName);
        }

        public Task<string> GetWeatherAsync(string CityName, string CountryName)
        {
            return base.Channel.GetWeatherAsync(CityName, CountryName);
        }
    }
}


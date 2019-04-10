namespace Pos_V9.ServiceReference1
{
    using System;
    using System.CodeDom.Compiler;
    using System.ServiceModel;
    using System.Threading.Tasks;

    [GeneratedCode("System.ServiceModel", "4.0.0.0"), ServiceContract(Namespace="http://www.webserviceX.NET", ConfigurationName="ServiceReference1.GlobalWeatherSoap")]
    public interface GlobalWeatherSoap
    {
        [XmlSerializerFormat(SupportFaults=true), OperationContract(Action="http://www.webserviceX.NET/GetCitiesByCountry", ReplyAction="*")]
        string GetCitiesByCountry(string CountryName);
        [OperationContract(Action="http://www.webserviceX.NET/GetCitiesByCountry", ReplyAction="*")]
        Task<string> GetCitiesByCountryAsync(string CountryName);
        [OperationContract(Action="http://www.webserviceX.NET/GetWeather", ReplyAction="*"), XmlSerializerFormat(SupportFaults=true)]
        string GetWeather(string CityName, string CountryName);
        [OperationContract(Action="http://www.webserviceX.NET/GetWeather", ReplyAction="*")]
        Task<string> GetWeatherAsync(string CityName, string CountryName);
    }
}


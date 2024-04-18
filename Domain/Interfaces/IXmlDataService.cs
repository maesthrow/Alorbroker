using System.Xml.Serialization;

namespace Domain.Interfaces
{

    public interface IXmlDataService<T> where T : class
    {
        #region Methods

        async Task<T> LoadFromXml(string xmlFilePath)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var reader = new StreamReader(xmlFilePath))
                return (T) await Task.Run(() => serializer.Deserialize(reader));
        }

        #endregion
    }

}
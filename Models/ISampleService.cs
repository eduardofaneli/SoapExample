using System.ServiceModel;
using System.Xml.Linq;

namespace Models {

    [ServiceContract]
    public interface ISampleService {

        [OperationContract]
        string Teste (string s);

        [OperationContract]
        void XmlMethod (XElement xml);

        [OperationContract]
        MyCustomModel TestCustomModel (MyCustomModel inputModel);
    }
}
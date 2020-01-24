using System;
using System.Xml.Linq;
using Models;

public class SampleService: ISampleService {
    public string Teste(string s)
    {
        Console.WriteLine("Test Method Executed!");
        return s;                
    }

    public void XmlMethod(XElement xml)
    {
        Console.WriteLine(xml.ToString());
    }

    public MyCustomModel TestCustomModel(MyCustomModel customModel)
    {
        return customModel;
    }
    
}
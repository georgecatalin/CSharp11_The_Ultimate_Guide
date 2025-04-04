//prior to C# 11 the access modifiers for types were only 3: public, internal and private

internal class Service
{
    public string GetData()
    {
        AdditionalService service = new AdditionalService();
        return $"This is my data {service.GetAdditionalData()}";
    }
}

file class AdditionalService // you wish to be able to access the class , but only from this file
{
    internal string GetAdditionalData()
    {
        return "this is special data";
    }
}
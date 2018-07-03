﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICatalogService")]
public interface ICatalogService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/AddProduct", ReplyAction="http://tempuri.org/ICatalogService/AddProductResponse")]
    [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Mandatory)]
    void AddProduct(string name, System.Uri imageUrl);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogService/AddProduct", ReplyAction="http://tempuri.org/ICatalogService/AddProductResponse")]
    System.Threading.Tasks.Task AddProductAsync(string name, System.Uri imageUrl);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICatalogServiceChannel : ICatalogService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CatalogServiceClient : System.ServiceModel.ClientBase<ICatalogService>, ICatalogService
{
    
    public CatalogServiceClient()
    {
    }
    
    public CatalogServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CatalogServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CatalogServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CatalogServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void AddProduct(string name, System.Uri imageUrl)
    {
        base.Channel.AddProduct(name, imageUrl);
    }
    
    public System.Threading.Tasks.Task AddProductAsync(string name, System.Uri imageUrl)
    {
        return base.Channel.AddProductAsync(name, imageUrl);
    }
}

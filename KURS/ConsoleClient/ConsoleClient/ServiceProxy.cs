﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:2.0.50727.8000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleClient
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConsoleClient.IServer")]
    public interface IServer
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServer/DoQuery", ReplyAction="http://tempuri.org/IServer/DoQueryResponse")]
        string DoQuery(string query, bool ret);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IServerChannel : ConsoleClient.IServer, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ServerClient : System.ServiceModel.ClientBase<ConsoleClient.IServer>, ConsoleClient.IServer
    {
        
        public ServerClient()
        {
        }
        
        public ServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string DoQuery(string query, bool ret)
        {
            return base.Channel.DoQuery(query, ret);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Urlaubsantrag.VorgesetzterService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VorgesetzterService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AntragEmpfangen", ReplyAction="http://tempuri.org/IService/AntragEmpfangenResponse")]
        Urlaubsantrag.VorgesetzterService.AntragEmpfangenResponse AntragEmpfangen(Urlaubsantrag.VorgesetzterService.AntragEmpfangenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AntragEmpfangen", ReplyAction="http://tempuri.org/IService/AntragEmpfangenResponse")]
        System.Threading.Tasks.Task<Urlaubsantrag.VorgesetzterService.AntragEmpfangenResponse> AntragEmpfangenAsync(Urlaubsantrag.VorgesetzterService.AntragEmpfangenRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AntragEmpfangen", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AntragEmpfangenRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public UrlaubsantragService.Contract.Urlaubsantrag antrag;
        
        public AntragEmpfangenRequest() {
        }
        
        public AntragEmpfangenRequest(UrlaubsantragService.Contract.Urlaubsantrag antrag) {
            this.antrag = antrag;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AntragEmpfangenResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AntragEmpfangenResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string correlationid;
        
        public AntragEmpfangenResponse() {
        }
        
        public AntragEmpfangenResponse(string correlationid) {
            this.correlationid = correlationid;
        }
    }
}

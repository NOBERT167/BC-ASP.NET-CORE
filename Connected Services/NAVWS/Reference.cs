﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NAVWS
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", ConfigurationName="NAVWS.InstructorCrudOperations_Port")]
    public interface InstructorCrudOperations_Port
    {
        
        // CODEGEN: Generating message contract since the wrapper name (DeleteInstructor_Result) of message DeleteInstructor_Result does not match the default value (DeleteInstructor)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations:DeleteInstructor" +
            "", ReplyAction="*")]
        NAVWS.DeleteInstructor_Result DeleteInstructor(NAVWS.DeleteInstructor request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations:DeleteInstructor" +
            "", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.DeleteInstructor_Result> DeleteInstructorAsync(NAVWS.DeleteInstructor request);
        
        // CODEGEN: Generating message contract since the wrapper name (GetAllInstructors_Result) of message GetAllInstructors_Result does not match the default value (GetAllInstructors)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations:GetAllInstructor" +
            "s", ReplyAction="*")]
        NAVWS.GetAllInstructors_Result GetAllInstructors(NAVWS.GetAllInstructors request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations:GetAllInstructor" +
            "s", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.GetAllInstructors_Result> GetAllInstructorsAsync(NAVWS.GetAllInstructors request);
        
        // CODEGEN: Generating message contract since the wrapper name (GetInstructorById_Result) of message GetInstructorById_Result does not match the default value (GetInstructorById)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations:GetInstructorByI" +
            "d", ReplyAction="*")]
        NAVWS.GetInstructorById_Result GetInstructorById(NAVWS.GetInstructorById request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations:GetInstructorByI" +
            "d", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.GetInstructorById_Result> GetInstructorByIdAsync(NAVWS.GetInstructorById request);
        
        // CODEGEN: Generating message contract since the wrapper name (InsertInstructorData_Result) of message InsertInstructorData_Result does not match the default value (InsertInstructorData)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations:InsertInstructor" +
            "Data", ReplyAction="*")]
        NAVWS.InsertInstructorData_Result InsertInstructorData(NAVWS.InsertInstructorData request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations:InsertInstructor" +
            "Data", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.InsertInstructorData_Result> InsertInstructorDataAsync(NAVWS.InsertInstructorData request);
        
        // CODEGEN: Generating message contract since the wrapper name (UpdateInstructor_Result) of message UpdateInstructor_Result does not match the default value (UpdateInstructor)
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations:UpdateInstructor" +
            "", ReplyAction="*")]
        NAVWS.UpdateInstructor_Result UpdateInstructor(NAVWS.UpdateInstructor request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations:UpdateInstructor" +
            "", ReplyAction="*")]
        System.Threading.Tasks.Task<NAVWS.UpdateInstructor_Result> UpdateInstructorAsync(NAVWS.UpdateInstructor request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteInstructor", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", IsWrapped=true)]
    public partial class DeleteInstructor
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", Order=0)]
        public string instructorId;
        
        public DeleteInstructor()
        {
        }
        
        public DeleteInstructor(string instructorId)
        {
            this.instructorId = instructorId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteInstructor_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", IsWrapped=true)]
    public partial class DeleteInstructor_Result
    {
        
        public DeleteInstructor_Result()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllInstructors", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", IsWrapped=true)]
    public partial class GetAllInstructors
    {
        
        public GetAllInstructors()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllInstructors_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", IsWrapped=true)]
    public partial class GetAllInstructors_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", Order=0)]
        public string return_value;
        
        public GetAllInstructors_Result()
        {
        }
        
        public GetAllInstructors_Result(string return_value)
        {
            this.return_value = return_value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetInstructorById", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", IsWrapped=true)]
    public partial class GetInstructorById
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", Order=0)]
        public string instructorId;
        
        public GetInstructorById()
        {
        }
        
        public GetInstructorById(string instructorId)
        {
            this.instructorId = instructorId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetInstructorById_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", IsWrapped=true)]
    public partial class GetInstructorById_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", Order=0)]
        public string return_value;
        
        public GetInstructorById_Result()
        {
        }
        
        public GetInstructorById_Result(string return_value)
        {
            this.return_value = return_value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertInstructorData", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", IsWrapped=true)]
    public partial class InsertInstructorData
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", Order=0)]
        public string instructorName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", Order=1)]
        public string instructorId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", Order=2)]
        public string instructorPhoneNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", Order=3)]
        public string instructorEmail;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", Order=4)]
        public decimal instructorRate;
        
        public InsertInstructorData()
        {
        }
        
        public InsertInstructorData(string instructorName, string instructorId, string instructorPhoneNumber, string instructorEmail, decimal instructorRate)
        {
            this.instructorName = instructorName;
            this.instructorId = instructorId;
            this.instructorPhoneNumber = instructorPhoneNumber;
            this.instructorEmail = instructorEmail;
            this.instructorRate = instructorRate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="InsertInstructorData_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", IsWrapped=true)]
    public partial class InsertInstructorData_Result
    {
        
        public InsertInstructorData_Result()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateInstructor", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", IsWrapped=true)]
    public partial class UpdateInstructor
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", Order=0)]
        public string instructorId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", Order=1)]
        public string instructorName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", Order=2)]
        public string instructorPhoneNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", Order=3)]
        public string instructorEmail;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", Order=4)]
        public decimal instructorRate;
        
        public UpdateInstructor()
        {
        }
        
        public UpdateInstructor(string instructorId, string instructorName, string instructorPhoneNumber, string instructorEmail, decimal instructorRate)
        {
            this.instructorId = instructorId;
            this.instructorName = instructorName;
            this.instructorPhoneNumber = instructorPhoneNumber;
            this.instructorEmail = instructorEmail;
            this.instructorRate = instructorRate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateInstructor_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/InstructorCrudOperations", IsWrapped=true)]
    public partial class UpdateInstructor_Result
    {
        
        public UpdateInstructor_Result()
        {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface InstructorCrudOperations_PortChannel : NAVWS.InstructorCrudOperations_Port, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class InstructorCrudOperations_PortClient : System.ServiceModel.ClientBase<NAVWS.InstructorCrudOperations_Port>, NAVWS.InstructorCrudOperations_Port
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public InstructorCrudOperations_PortClient() : 
                base(InstructorCrudOperations_PortClient.GetDefaultBinding(), InstructorCrudOperations_PortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.InstructorCrudOperations_Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InstructorCrudOperations_PortClient(EndpointConfiguration endpointConfiguration) : 
                base(InstructorCrudOperations_PortClient.GetBindingForEndpoint(endpointConfiguration), InstructorCrudOperations_PortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InstructorCrudOperations_PortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(InstructorCrudOperations_PortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InstructorCrudOperations_PortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(InstructorCrudOperations_PortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public InstructorCrudOperations_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.DeleteInstructor_Result NAVWS.InstructorCrudOperations_Port.DeleteInstructor(NAVWS.DeleteInstructor request)
        {
            return base.Channel.DeleteInstructor(request);
        }
        
        public void DeleteInstructor(string instructorId)
        {
            NAVWS.DeleteInstructor inValue = new NAVWS.DeleteInstructor();
            inValue.instructorId = instructorId;
            NAVWS.DeleteInstructor_Result retVal = ((NAVWS.InstructorCrudOperations_Port)(this)).DeleteInstructor(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.DeleteInstructor_Result> NAVWS.InstructorCrudOperations_Port.DeleteInstructorAsync(NAVWS.DeleteInstructor request)
        {
            return base.Channel.DeleteInstructorAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.DeleteInstructor_Result> DeleteInstructorAsync(string instructorId)
        {
            NAVWS.DeleteInstructor inValue = new NAVWS.DeleteInstructor();
            inValue.instructorId = instructorId;
            return ((NAVWS.InstructorCrudOperations_Port)(this)).DeleteInstructorAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.GetAllInstructors_Result NAVWS.InstructorCrudOperations_Port.GetAllInstructors(NAVWS.GetAllInstructors request)
        {
            return base.Channel.GetAllInstructors(request);
        }
        
        public string GetAllInstructors()
        {
            NAVWS.GetAllInstructors inValue = new NAVWS.GetAllInstructors();
            NAVWS.GetAllInstructors_Result retVal = ((NAVWS.InstructorCrudOperations_Port)(this)).GetAllInstructors(inValue);
            return retVal.return_value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.GetAllInstructors_Result> NAVWS.InstructorCrudOperations_Port.GetAllInstructorsAsync(NAVWS.GetAllInstructors request)
        {
            return base.Channel.GetAllInstructorsAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.GetAllInstructors_Result> GetAllInstructorsAsync()
        {
            NAVWS.GetAllInstructors inValue = new NAVWS.GetAllInstructors();
            return ((NAVWS.InstructorCrudOperations_Port)(this)).GetAllInstructorsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.GetInstructorById_Result NAVWS.InstructorCrudOperations_Port.GetInstructorById(NAVWS.GetInstructorById request)
        {
            return base.Channel.GetInstructorById(request);
        }
        
        public string GetInstructorById(string instructorId)
        {
            NAVWS.GetInstructorById inValue = new NAVWS.GetInstructorById();
            inValue.instructorId = instructorId;
            NAVWS.GetInstructorById_Result retVal = ((NAVWS.InstructorCrudOperations_Port)(this)).GetInstructorById(inValue);
            return retVal.return_value;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.GetInstructorById_Result> NAVWS.InstructorCrudOperations_Port.GetInstructorByIdAsync(NAVWS.GetInstructorById request)
        {
            return base.Channel.GetInstructorByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.GetInstructorById_Result> GetInstructorByIdAsync(string instructorId)
        {
            NAVWS.GetInstructorById inValue = new NAVWS.GetInstructorById();
            inValue.instructorId = instructorId;
            return ((NAVWS.InstructorCrudOperations_Port)(this)).GetInstructorByIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.InsertInstructorData_Result NAVWS.InstructorCrudOperations_Port.InsertInstructorData(NAVWS.InsertInstructorData request)
        {
            return base.Channel.InsertInstructorData(request);
        }
        
        public void InsertInstructorData(string instructorName, string instructorId, string instructorPhoneNumber, string instructorEmail, decimal instructorRate)
        {
            NAVWS.InsertInstructorData inValue = new NAVWS.InsertInstructorData();
            inValue.instructorName = instructorName;
            inValue.instructorId = instructorId;
            inValue.instructorPhoneNumber = instructorPhoneNumber;
            inValue.instructorEmail = instructorEmail;
            inValue.instructorRate = instructorRate;
            NAVWS.InsertInstructorData_Result retVal = ((NAVWS.InstructorCrudOperations_Port)(this)).InsertInstructorData(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.InsertInstructorData_Result> NAVWS.InstructorCrudOperations_Port.InsertInstructorDataAsync(NAVWS.InsertInstructorData request)
        {
            return base.Channel.InsertInstructorDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.InsertInstructorData_Result> InsertInstructorDataAsync(string instructorName, string instructorId, string instructorPhoneNumber, string instructorEmail, decimal instructorRate)
        {
            NAVWS.InsertInstructorData inValue = new NAVWS.InsertInstructorData();
            inValue.instructorName = instructorName;
            inValue.instructorId = instructorId;
            inValue.instructorPhoneNumber = instructorPhoneNumber;
            inValue.instructorEmail = instructorEmail;
            inValue.instructorRate = instructorRate;
            return ((NAVWS.InstructorCrudOperations_Port)(this)).InsertInstructorDataAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAVWS.UpdateInstructor_Result NAVWS.InstructorCrudOperations_Port.UpdateInstructor(NAVWS.UpdateInstructor request)
        {
            return base.Channel.UpdateInstructor(request);
        }
        
        public void UpdateInstructor(string instructorId, string instructorName, string instructorPhoneNumber, string instructorEmail, decimal instructorRate)
        {
            NAVWS.UpdateInstructor inValue = new NAVWS.UpdateInstructor();
            inValue.instructorId = instructorId;
            inValue.instructorName = instructorName;
            inValue.instructorPhoneNumber = instructorPhoneNumber;
            inValue.instructorEmail = instructorEmail;
            inValue.instructorRate = instructorRate;
            NAVWS.UpdateInstructor_Result retVal = ((NAVWS.InstructorCrudOperations_Port)(this)).UpdateInstructor(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NAVWS.UpdateInstructor_Result> NAVWS.InstructorCrudOperations_Port.UpdateInstructorAsync(NAVWS.UpdateInstructor request)
        {
            return base.Channel.UpdateInstructorAsync(request);
        }
        
        public System.Threading.Tasks.Task<NAVWS.UpdateInstructor_Result> UpdateInstructorAsync(string instructorId, string instructorName, string instructorPhoneNumber, string instructorEmail, decimal instructorRate)
        {
            NAVWS.UpdateInstructor inValue = new NAVWS.UpdateInstructor();
            inValue.instructorId = instructorId;
            inValue.instructorName = instructorName;
            inValue.instructorPhoneNumber = instructorPhoneNumber;
            inValue.instructorEmail = instructorEmail;
            inValue.instructorRate = instructorRate;
            return ((NAVWS.InstructorCrudOperations_Port)(this)).UpdateInstructorAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.InstructorCrudOperations_Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.InstructorCrudOperations_Port))
            {
                return new System.ServiceModel.EndpointAddress("http://desktop-eq55q8h:7047/BC240/WS/CRONUS International Ltd./Codeunit/Instructo" +
                        "rCrudOperations");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return InstructorCrudOperations_PortClient.GetBindingForEndpoint(EndpointConfiguration.InstructorCrudOperations_Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return InstructorCrudOperations_PortClient.GetEndpointAddress(EndpointConfiguration.InstructorCrudOperations_Port);
        }
        
        public enum EndpointConfiguration
        {
            
            InstructorCrudOperations_Port,
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DuplexClient.ReportService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LaunchVehicleConfig", Namespace="http://schemas.datacontract.org/2004/07/ReportService")]
    [System.SerializableAttribute()]
    public partial class LaunchVehicleConfig : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrbitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PayloadConfigField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Orbit {
            get {
                return this.OrbitField;
            }
            set {
                if ((this.OrbitField.Equals(value) != true)) {
                    this.OrbitField = value;
                    this.RaisePropertyChanged("Orbit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PayloadConfig {
            get {
                return this.PayloadConfigField;
            }
            set {
                if ((object.ReferenceEquals(this.PayloadConfigField, value) != true)) {
                    this.PayloadConfigField = value;
                    this.RaisePropertyChanged("PayloadConfig");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TelemetryData", Namespace="http://schemas.datacontract.org/2004/07/ReportService")]
    [System.SerializableAttribute()]
    public partial class TelemetryData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int altitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double latitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double longtitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int temperatureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int timeToOrbitField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int altitude {
            get {
                return this.altitudeField;
            }
            set {
                if ((this.altitudeField.Equals(value) != true)) {
                    this.altitudeField = value;
                    this.RaisePropertyChanged("altitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double latitude {
            get {
                return this.latitudeField;
            }
            set {
                if ((this.latitudeField.Equals(value) != true)) {
                    this.latitudeField = value;
                    this.RaisePropertyChanged("latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double longtitude {
            get {
                return this.longtitudeField;
            }
            set {
                if ((this.longtitudeField.Equals(value) != true)) {
                    this.longtitudeField = value;
                    this.RaisePropertyChanged("longtitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int temperature {
            get {
                return this.temperatureField;
            }
            set {
                if ((this.temperatureField.Equals(value) != true)) {
                    this.temperatureField = value;
                    this.RaisePropertyChanged("temperature");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int timeToOrbit {
            get {
                return this.timeToOrbitField;
            }
            set {
                if ((this.timeToOrbitField.Equals(value) != true)) {
                    this.timeToOrbitField = value;
                    this.RaisePropertyChanged("timeToOrbit");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReportService.IReportService", CallbackContract=typeof(DuplexClient.ReportService.IReportServiceCallback))]
    public interface IReportService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IReportService/StartTelemetry")]
        void StartTelemetry(int serviceInd, DuplexClient.ReportService.LaunchVehicleConfig LVconfig);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IReportService/StartTelemetry")]
        System.Threading.Tasks.Task StartTelemetryAsync(int serviceInd, DuplexClient.ReportService.LaunchVehicleConfig LVconfig);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IReportService/StopTelemetry")]
        void StopTelemetry(int serviceInd, DuplexClient.ReportService.LaunchVehicleConfig LVconfig);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IReportService/StopTelemetry")]
        System.Threading.Tasks.Task StopTelemetryAsync(int serviceInd, DuplexClient.ReportService.LaunchVehicleConfig LVconfig);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IReportService/LaunchVehicle")]
        void LaunchVehicle(int serviceInd, DuplexClient.ReportService.LaunchVehicleConfig LVconfig);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IReportService/LaunchVehicle")]
        System.Threading.Tasks.Task LaunchVehicleAsync(int serviceInd, DuplexClient.ReportService.LaunchVehicleConfig LVconfig);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReportServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IReportService/Progress")]
        void Progress(DuplexClient.ReportService.TelemetryData telemetry, int serviceInd);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IReportService/reachOrbit")]
        void reachOrbit(int serviceInd, int latitude, int longtitude);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReportServiceChannel : DuplexClient.ReportService.IReportService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReportServiceClient : System.ServiceModel.DuplexClientBase<DuplexClient.ReportService.IReportService>, DuplexClient.ReportService.IReportService {
        
        public ReportServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ReportServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ReportServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ReportServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ReportServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void StartTelemetry(int serviceInd, DuplexClient.ReportService.LaunchVehicleConfig LVconfig) {
            base.Channel.StartTelemetry(serviceInd, LVconfig);
        }
        
        public System.Threading.Tasks.Task StartTelemetryAsync(int serviceInd, DuplexClient.ReportService.LaunchVehicleConfig LVconfig) {
            return base.Channel.StartTelemetryAsync(serviceInd, LVconfig);
        }
        
        public void StopTelemetry(int serviceInd, DuplexClient.ReportService.LaunchVehicleConfig LVconfig) {
            base.Channel.StopTelemetry(serviceInd, LVconfig);
        }
        
        public System.Threading.Tasks.Task StopTelemetryAsync(int serviceInd, DuplexClient.ReportService.LaunchVehicleConfig LVconfig) {
            return base.Channel.StopTelemetryAsync(serviceInd, LVconfig);
        }
        
        public void LaunchVehicle(int serviceInd, DuplexClient.ReportService.LaunchVehicleConfig LVconfig) {
            base.Channel.LaunchVehicle(serviceInd, LVconfig);
        }
        
        public System.Threading.Tasks.Task LaunchVehicleAsync(int serviceInd, DuplexClient.ReportService.LaunchVehicleConfig LVconfig) {
            return base.Channel.LaunchVehicleAsync(serviceInd, LVconfig);
        }
    }
}

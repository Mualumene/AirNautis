﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirNautis.ServiceAirNautis {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Airplane", Namespace="http://schemas.datacontract.org/2004/07/AirNautisService")]
    [System.SerializableAttribute()]
    public partial class Airplane : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ActiveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CapacityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> HangarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AirNautis.ServiceAirNautis.Hangar Hangar1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AirNautis.ServiceAirNautis.Travel[] TravelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
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
        public bool Active {
            get {
                return this.ActiveField;
            }
            set {
                if ((this.ActiveField.Equals(value) != true)) {
                    this.ActiveField = value;
                    this.RaisePropertyChanged("Active");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Capacity {
            get {
                return this.CapacityField;
            }
            set {
                if ((this.CapacityField.Equals(value) != true)) {
                    this.CapacityField = value;
                    this.RaisePropertyChanged("Capacity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Hangar {
            get {
                return this.HangarField;
            }
            set {
                if ((this.HangarField.Equals(value) != true)) {
                    this.HangarField = value;
                    this.RaisePropertyChanged("Hangar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AirNautis.ServiceAirNautis.Hangar Hangar1 {
            get {
                return this.Hangar1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Hangar1Field, value) != true)) {
                    this.Hangar1Field = value;
                    this.RaisePropertyChanged("Hangar1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AirNautis.ServiceAirNautis.Travel[] Travel {
            get {
                return this.TravelField;
            }
            set {
                if ((object.ReferenceEquals(this.TravelField, value) != true)) {
                    this.TravelField = value;
                    this.RaisePropertyChanged("Travel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Hangar", Namespace="http://schemas.datacontract.org/2004/07/AirNautisService")]
    [System.SerializableAttribute()]
    public partial class Hangar : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AirNautis.ServiceAirNautis.Airplane[] AirplaneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CapacityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberField;
        
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
        public AirNautis.ServiceAirNautis.Airplane[] Airplane {
            get {
                return this.AirplaneField;
            }
            set {
                if ((object.ReferenceEquals(this.AirplaneField, value) != true)) {
                    this.AirplaneField = value;
                    this.RaisePropertyChanged("Airplane");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Capacity {
            get {
                return this.CapacityField;
            }
            set {
                if ((this.CapacityField.Equals(value) != true)) {
                    this.CapacityField = value;
                    this.RaisePropertyChanged("Capacity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number {
            get {
                return this.NumberField;
            }
            set {
                if ((this.NumberField.Equals(value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Travel", Namespace="http://schemas.datacontract.org/2004/07/AirNautisService")]
    [System.SerializableAttribute()]
    public partial class Travel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AirplaneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AirNautis.ServiceAirNautis.Airplane Airplane1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DestinationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginField;
        
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
        public int Airplane {
            get {
                return this.AirplaneField;
            }
            set {
                if ((this.AirplaneField.Equals(value) != true)) {
                    this.AirplaneField = value;
                    this.RaisePropertyChanged("Airplane");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AirNautis.ServiceAirNautis.Airplane Airplane1 {
            get {
                return this.Airplane1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Airplane1Field, value) != true)) {
                    this.Airplane1Field = value;
                    this.RaisePropertyChanged("Airplane1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Destination {
            get {
                return this.DestinationField;
            }
            set {
                if ((object.ReferenceEquals(this.DestinationField, value) != true)) {
                    this.DestinationField = value;
                    this.RaisePropertyChanged("Destination");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Origin {
            get {
                return this.OriginField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginField, value) != true)) {
                    this.OriginField = value;
                    this.RaisePropertyChanged("Origin");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceAirNautis.IAirNautisService")]
    public interface IAirNautisService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetAirplaneById", ReplyAction="http://tempuri.org/IAirNautisService/GetAirplaneByIdResponse")]
        AirNautis.ServiceAirNautis.Airplane GetAirplaneById(int airplaneId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetAirplaneById", ReplyAction="http://tempuri.org/IAirNautisService/GetAirplaneByIdResponse")]
        System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Airplane> GetAirplaneByIdAsync(int airplaneId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetAllAirplanes", ReplyAction="http://tempuri.org/IAirNautisService/GetAllAirplanesResponse")]
        AirNautis.ServiceAirNautis.Airplane[] GetAllAirplanes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetAllAirplanes", ReplyAction="http://tempuri.org/IAirNautisService/GetAllAirplanesResponse")]
        System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Airplane[]> GetAllAirplanesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetAirplaneTravels", ReplyAction="http://tempuri.org/IAirNautisService/GetAirplaneTravelsResponse")]
        AirNautis.ServiceAirNautis.Travel[] GetAirplaneTravels(int airplaneId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetAirplaneTravels", ReplyAction="http://tempuri.org/IAirNautisService/GetAirplaneTravelsResponse")]
        System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Travel[]> GetAirplaneTravelsAsync(int airplaneId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetHangarAirplanes", ReplyAction="http://tempuri.org/IAirNautisService/GetHangarAirplanesResponse")]
        AirNautis.ServiceAirNautis.Airplane[] GetHangarAirplanes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetHangarAirplanes", ReplyAction="http://tempuri.org/IAirNautisService/GetHangarAirplanesResponse")]
        System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Airplane[]> GetHangarAirplanesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetOutAirplanes", ReplyAction="http://tempuri.org/IAirNautisService/GetOutAirplanesResponse")]
        AirNautis.ServiceAirNautis.Airplane[] GetOutAirplanes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetOutAirplanes", ReplyAction="http://tempuri.org/IAirNautisService/GetOutAirplanesResponse")]
        System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Airplane[]> GetOutAirplanesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetAllHangars", ReplyAction="http://tempuri.org/IAirNautisService/GetAllHangarsResponse")]
        AirNautis.ServiceAirNautis.Hangar[] GetAllHangars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetAllHangars", ReplyAction="http://tempuri.org/IAirNautisService/GetAllHangarsResponse")]
        System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Hangar[]> GetAllHangarsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetAvaiableHangars", ReplyAction="http://tempuri.org/IAirNautisService/GetAvaiableHangarsResponse")]
        AirNautis.ServiceAirNautis.Hangar[] GetAvaiableHangars();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetAvaiableHangars", ReplyAction="http://tempuri.org/IAirNautisService/GetAvaiableHangarsResponse")]
        System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Hangar[]> GetAvaiableHangarsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetActiveAirplanes", ReplyAction="http://tempuri.org/IAirNautisService/GetActiveAirplanesResponse")]
        AirNautis.ServiceAirNautis.Airplane[] GetActiveAirplanes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetActiveAirplanes", ReplyAction="http://tempuri.org/IAirNautisService/GetActiveAirplanesResponse")]
        System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Airplane[]> GetActiveAirplanesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetInactiveAirplanes", ReplyAction="http://tempuri.org/IAirNautisService/GetInactiveAirplanesResponse")]
        AirNautis.ServiceAirNautis.Airplane[] GetInactiveAirplanes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetInactiveAirplanes", ReplyAction="http://tempuri.org/IAirNautisService/GetInactiveAirplanesResponse")]
        System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Airplane[]> GetInactiveAirplanesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetHangar", ReplyAction="http://tempuri.org/IAirNautisService/GetHangarResponse")]
        AirNautis.ServiceAirNautis.Hangar GetHangar(int hangar_number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetHangar", ReplyAction="http://tempuri.org/IAirNautisService/GetHangarResponse")]
        System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Hangar> GetHangarAsync(int hangar_number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetAirplanesByHangar", ReplyAction="http://tempuri.org/IAirNautisService/GetAirplanesByHangarResponse")]
        AirNautis.ServiceAirNautis.Airplane[] GetAirplanesByHangar(int hangar_number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetAirplanesByHangar", ReplyAction="http://tempuri.org/IAirNautisService/GetAirplanesByHangarResponse")]
        System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Airplane[]> GetAirplanesByHangarAsync(int hangar_number);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetTravels", ReplyAction="http://tempuri.org/IAirNautisService/GetTravelsResponse")]
        AirNautis.ServiceAirNautis.Travel[] GetTravels();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/GetTravels", ReplyAction="http://tempuri.org/IAirNautisService/GetTravelsResponse")]
        System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Travel[]> GetTravelsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/InsertAirplane", ReplyAction="http://tempuri.org/IAirNautisService/InsertAirplaneResponse")]
        bool InsertAirplane(AirNautis.ServiceAirNautis.Airplane newAirplane);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/InsertAirplane", ReplyAction="http://tempuri.org/IAirNautisService/InsertAirplaneResponse")]
        System.Threading.Tasks.Task<bool> InsertAirplaneAsync(AirNautis.ServiceAirNautis.Airplane newAirplane);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/CreateHangar", ReplyAction="http://tempuri.org/IAirNautisService/CreateHangarResponse")]
        bool CreateHangar(AirNautis.ServiceAirNautis.Hangar newHangar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/CreateHangar", ReplyAction="http://tempuri.org/IAirNautisService/CreateHangarResponse")]
        System.Threading.Tasks.Task<bool> CreateHangarAsync(AirNautis.ServiceAirNautis.Hangar newHangar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/NewOutgoingTravel", ReplyAction="http://tempuri.org/IAirNautisService/NewOutgoingTravelResponse")]
        bool NewOutgoingTravel(AirNautis.ServiceAirNautis.Travel newTravel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/NewOutgoingTravel", ReplyAction="http://tempuri.org/IAirNautisService/NewOutgoingTravelResponse")]
        System.Threading.Tasks.Task<bool> NewOutgoingTravelAsync(AirNautis.ServiceAirNautis.Travel newTravel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/NewIncomingTravel", ReplyAction="http://tempuri.org/IAirNautisService/NewIncomingTravelResponse")]
        bool NewIncomingTravel(AirNautis.ServiceAirNautis.Travel newTravel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/NewIncomingTravel", ReplyAction="http://tempuri.org/IAirNautisService/NewIncomingTravelResponse")]
        System.Threading.Tasks.Task<bool> NewIncomingTravelAsync(AirNautis.ServiceAirNautis.Travel newTravel);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/EditAirplane", ReplyAction="http://tempuri.org/IAirNautisService/EditAirplaneResponse")]
        bool EditAirplane(AirNautis.ServiceAirNautis.Airplane airplane);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/EditAirplane", ReplyAction="http://tempuri.org/IAirNautisService/EditAirplaneResponse")]
        System.Threading.Tasks.Task<bool> EditAirplaneAsync(AirNautis.ServiceAirNautis.Airplane airplane);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/ActivateAirplane", ReplyAction="http://tempuri.org/IAirNautisService/ActivateAirplaneResponse")]
        bool ActivateAirplane(int airplane_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/ActivateAirplane", ReplyAction="http://tempuri.org/IAirNautisService/ActivateAirplaneResponse")]
        System.Threading.Tasks.Task<bool> ActivateAirplaneAsync(int airplane_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/DeactivateAirplane", ReplyAction="http://tempuri.org/IAirNautisService/DeactivateAirplaneResponse")]
        bool DeactivateAirplane(int airplane_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAirNautisService/DeactivateAirplane", ReplyAction="http://tempuri.org/IAirNautisService/DeactivateAirplaneResponse")]
        System.Threading.Tasks.Task<bool> DeactivateAirplaneAsync(int airplane_id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAirNautisServiceChannel : AirNautis.ServiceAirNautis.IAirNautisService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AirNautisServiceClient : System.ServiceModel.ClientBase<AirNautis.ServiceAirNautis.IAirNautisService>, AirNautis.ServiceAirNautis.IAirNautisService {
        
        public AirNautisServiceClient() {
        }
        
        public AirNautisServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AirNautisServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AirNautisServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AirNautisServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AirNautis.ServiceAirNautis.Airplane GetAirplaneById(int airplaneId) {
            return base.Channel.GetAirplaneById(airplaneId);
        }
        
        public System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Airplane> GetAirplaneByIdAsync(int airplaneId) {
            return base.Channel.GetAirplaneByIdAsync(airplaneId);
        }
        
        public AirNautis.ServiceAirNautis.Airplane[] GetAllAirplanes() {
            return base.Channel.GetAllAirplanes();
        }
        
        public System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Airplane[]> GetAllAirplanesAsync() {
            return base.Channel.GetAllAirplanesAsync();
        }
        
        public AirNautis.ServiceAirNautis.Travel[] GetAirplaneTravels(int airplaneId) {
            return base.Channel.GetAirplaneTravels(airplaneId);
        }
        
        public System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Travel[]> GetAirplaneTravelsAsync(int airplaneId) {
            return base.Channel.GetAirplaneTravelsAsync(airplaneId);
        }
        
        public AirNautis.ServiceAirNautis.Airplane[] GetHangarAirplanes() {
            return base.Channel.GetHangarAirplanes();
        }
        
        public System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Airplane[]> GetHangarAirplanesAsync() {
            return base.Channel.GetHangarAirplanesAsync();
        }
        
        public AirNautis.ServiceAirNautis.Airplane[] GetOutAirplanes() {
            return base.Channel.GetOutAirplanes();
        }
        
        public System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Airplane[]> GetOutAirplanesAsync() {
            return base.Channel.GetOutAirplanesAsync();
        }
        
        public AirNautis.ServiceAirNautis.Hangar[] GetAllHangars() {
            return base.Channel.GetAllHangars();
        }
        
        public System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Hangar[]> GetAllHangarsAsync() {
            return base.Channel.GetAllHangarsAsync();
        }
        
        public AirNautis.ServiceAirNautis.Hangar[] GetAvaiableHangars() {
            return base.Channel.GetAvaiableHangars();
        }
        
        public System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Hangar[]> GetAvaiableHangarsAsync() {
            return base.Channel.GetAvaiableHangarsAsync();
        }
        
        public AirNautis.ServiceAirNautis.Airplane[] GetActiveAirplanes() {
            return base.Channel.GetActiveAirplanes();
        }
        
        public System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Airplane[]> GetActiveAirplanesAsync() {
            return base.Channel.GetActiveAirplanesAsync();
        }
        
        public AirNautis.ServiceAirNautis.Airplane[] GetInactiveAirplanes() {
            return base.Channel.GetInactiveAirplanes();
        }
        
        public System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Airplane[]> GetInactiveAirplanesAsync() {
            return base.Channel.GetInactiveAirplanesAsync();
        }
        
        public AirNautis.ServiceAirNautis.Hangar GetHangar(int hangar_number) {
            return base.Channel.GetHangar(hangar_number);
        }
        
        public System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Hangar> GetHangarAsync(int hangar_number) {
            return base.Channel.GetHangarAsync(hangar_number);
        }
        
        public AirNautis.ServiceAirNautis.Airplane[] GetAirplanesByHangar(int hangar_number) {
            return base.Channel.GetAirplanesByHangar(hangar_number);
        }
        
        public System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Airplane[]> GetAirplanesByHangarAsync(int hangar_number) {
            return base.Channel.GetAirplanesByHangarAsync(hangar_number);
        }
        
        public AirNautis.ServiceAirNautis.Travel[] GetTravels() {
            return base.Channel.GetTravels();
        }
        
        public System.Threading.Tasks.Task<AirNautis.ServiceAirNautis.Travel[]> GetTravelsAsync() {
            return base.Channel.GetTravelsAsync();
        }
        
        public bool InsertAirplane(AirNautis.ServiceAirNautis.Airplane newAirplane) {
            return base.Channel.InsertAirplane(newAirplane);
        }
        
        public System.Threading.Tasks.Task<bool> InsertAirplaneAsync(AirNautis.ServiceAirNautis.Airplane newAirplane) {
            return base.Channel.InsertAirplaneAsync(newAirplane);
        }
        
        public bool CreateHangar(AirNautis.ServiceAirNautis.Hangar newHangar) {
            return base.Channel.CreateHangar(newHangar);
        }
        
        public System.Threading.Tasks.Task<bool> CreateHangarAsync(AirNautis.ServiceAirNautis.Hangar newHangar) {
            return base.Channel.CreateHangarAsync(newHangar);
        }
        
        public bool NewOutgoingTravel(AirNautis.ServiceAirNautis.Travel newTravel) {
            return base.Channel.NewOutgoingTravel(newTravel);
        }
        
        public System.Threading.Tasks.Task<bool> NewOutgoingTravelAsync(AirNautis.ServiceAirNautis.Travel newTravel) {
            return base.Channel.NewOutgoingTravelAsync(newTravel);
        }
        
        public bool NewIncomingTravel(AirNautis.ServiceAirNautis.Travel newTravel) {
            return base.Channel.NewIncomingTravel(newTravel);
        }
        
        public System.Threading.Tasks.Task<bool> NewIncomingTravelAsync(AirNautis.ServiceAirNautis.Travel newTravel) {
            return base.Channel.NewIncomingTravelAsync(newTravel);
        }
        
        public bool EditAirplane(AirNautis.ServiceAirNautis.Airplane airplane) {
            return base.Channel.EditAirplane(airplane);
        }
        
        public System.Threading.Tasks.Task<bool> EditAirplaneAsync(AirNautis.ServiceAirNautis.Airplane airplane) {
            return base.Channel.EditAirplaneAsync(airplane);
        }
        
        public bool ActivateAirplane(int airplane_id) {
            return base.Channel.ActivateAirplane(airplane_id);
        }
        
        public System.Threading.Tasks.Task<bool> ActivateAirplaneAsync(int airplane_id) {
            return base.Channel.ActivateAirplaneAsync(airplane_id);
        }
        
        public bool DeactivateAirplane(int airplane_id) {
            return base.Channel.DeactivateAirplane(airplane_id);
        }
        
        public System.Threading.Tasks.Task<bool> DeactivateAirplaneAsync(int airplane_id) {
            return base.Channel.DeactivateAirplaneAsync(airplane_id);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinMef730.InvioFlussi730 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ejb.invioTelematicoSS730p.sanita.finanze.it/", ConfigurationName="InvioFlussi730.InvioTelematicoSS730pMtom")]
    public interface InvioTelematicoSS730pMtom {
        
        // CODEGEN: Il parametro 'return' richiede informazioni sullo schema aggiuntive che non possono essere acquisite utilizzando la modalità parametro. L'attributo specifico è 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WinMef730.InvioFlussi730.inviaFileMtomResponse inviaFileMtom(WinMef730.InvioFlussi730.inviaFileMtomRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<WinMef730.InvioFlussi730.inviaFileMtomResponse> inviaFileMtomAsync(WinMef730.InvioFlussi730.inviaFileMtomRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ejb.invioTelematicoSS730p.sanita.finanze.it/")]
    public partial class proprietario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codiceRegioneField;
        
        private string codiceAslField;
        
        private string codiceSSAField;
        
        private string cfProprietarioField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codiceRegione {
            get {
                return this.codiceRegioneField;
            }
            set {
                this.codiceRegioneField = value;
                this.RaisePropertyChanged("codiceRegione");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string codiceAsl {
            get {
                return this.codiceAslField;
            }
            set {
                this.codiceAslField = value;
                this.RaisePropertyChanged("codiceAsl");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string codiceSSA {
            get {
                return this.codiceSSAField;
            }
            set {
                this.codiceSSAField = value;
                this.RaisePropertyChanged("codiceSSA");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string cfProprietario {
            get {
                return this.cfProprietarioField;
            }
            set {
                this.cfProprietarioField = value;
                this.RaisePropertyChanged("cfProprietario");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ejb.invioTelematicoSS730p.sanita.finanze.it/")]
    public partial class ricevutaInvio : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codiceEsitoField;
        
        private string dataAccoglienzaField;
        
        private string descrizioneEsitoField;
        
        private string dimensioneFileAllegatoField;
        
        private string nomeFileAllegatoField;
        
        private string protocolloField;
        
        private string idErroreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codiceEsito {
            get {
                return this.codiceEsitoField;
            }
            set {
                this.codiceEsitoField = value;
                this.RaisePropertyChanged("codiceEsito");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string dataAccoglienza {
            get {
                return this.dataAccoglienzaField;
            }
            set {
                this.dataAccoglienzaField = value;
                this.RaisePropertyChanged("dataAccoglienza");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string descrizioneEsito {
            get {
                return this.descrizioneEsitoField;
            }
            set {
                this.descrizioneEsitoField = value;
                this.RaisePropertyChanged("descrizioneEsito");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string dimensioneFileAllegato {
            get {
                return this.dimensioneFileAllegatoField;
            }
            set {
                this.dimensioneFileAllegatoField = value;
                this.RaisePropertyChanged("dimensioneFileAllegato");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string nomeFileAllegato {
            get {
                return this.nomeFileAllegatoField;
            }
            set {
                this.nomeFileAllegatoField = value;
                this.RaisePropertyChanged("nomeFileAllegato");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string protocollo {
            get {
                return this.protocolloField;
            }
            set {
                this.protocolloField = value;
                this.RaisePropertyChanged("protocollo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string idErrore {
            get {
                return this.idErroreField;
            }
            set {
                this.idErroreField = value;
                this.RaisePropertyChanged("idErrore");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="inviaFileMtom", WrapperNamespace="http://ejb.invioTelematicoSS730p.sanita.finanze.it/", IsWrapped=true)]
    public partial class inviaFileMtomRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ejb.invioTelematicoSS730p.sanita.finanze.it/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nomeFileAllegato;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ejb.invioTelematicoSS730p.sanita.finanze.it/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string pincodeInvianteCifrato;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ejb.invioTelematicoSS730p.sanita.finanze.it/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WinMef730.InvioFlussi730.proprietario datiProprietario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ejb.invioTelematicoSS730p.sanita.finanze.it/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string opzionale1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ejb.invioTelematicoSS730p.sanita.finanze.it/", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string opzionale2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ejb.invioTelematicoSS730p.sanita.finanze.it/", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string opzionale3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ejb.invioTelematicoSS730p.sanita.finanze.it/", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        public byte[] documento;
        
        public inviaFileMtomRequest() {
        }
        
        public inviaFileMtomRequest(string nomeFileAllegato, string pincodeInvianteCifrato, WinMef730.InvioFlussi730.proprietario datiProprietario, string opzionale1, string opzionale2, string opzionale3, byte[] documento) {
            this.nomeFileAllegato = nomeFileAllegato;
            this.pincodeInvianteCifrato = pincodeInvianteCifrato;
            this.datiProprietario = datiProprietario;
            this.opzionale1 = opzionale1;
            this.opzionale2 = opzionale2;
            this.opzionale3 = opzionale3;
            this.documento = documento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="inviaFileMtomResponse", WrapperNamespace="http://ejb.invioTelematicoSS730p.sanita.finanze.it/", IsWrapped=true)]
    public partial class inviaFileMtomResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ejb.invioTelematicoSS730p.sanita.finanze.it/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WinMef730.InvioFlussi730.ricevutaInvio @return;
        
        public inviaFileMtomResponse() {
        }
        
        public inviaFileMtomResponse(WinMef730.InvioFlussi730.ricevutaInvio @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface InvioTelematicoSS730pMtomChannel : WinMef730.InvioFlussi730.InvioTelematicoSS730pMtom, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InvioTelematicoSS730pMtomClient : System.ServiceModel.ClientBase<WinMef730.InvioFlussi730.InvioTelematicoSS730pMtom>, WinMef730.InvioFlussi730.InvioTelematicoSS730pMtom {
        
        public InvioTelematicoSS730pMtomClient() {
        }
        
        public InvioTelematicoSS730pMtomClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InvioTelematicoSS730pMtomClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InvioTelematicoSS730pMtomClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InvioTelematicoSS730pMtomClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WinMef730.InvioFlussi730.inviaFileMtomResponse WinMef730.InvioFlussi730.InvioTelematicoSS730pMtom.inviaFileMtom(WinMef730.InvioFlussi730.inviaFileMtomRequest request) {
            return base.Channel.inviaFileMtom(request);
        }
        
        public WinMef730.InvioFlussi730.ricevutaInvio inviaFileMtom(string nomeFileAllegato, string pincodeInvianteCifrato, WinMef730.InvioFlussi730.proprietario datiProprietario, string opzionale1, string opzionale2, string opzionale3, byte[] documento) {
            WinMef730.InvioFlussi730.inviaFileMtomRequest inValue = new WinMef730.InvioFlussi730.inviaFileMtomRequest();
            inValue.nomeFileAllegato = nomeFileAllegato;
            inValue.pincodeInvianteCifrato = pincodeInvianteCifrato;
            inValue.datiProprietario = datiProprietario;
            inValue.opzionale1 = opzionale1;
            inValue.opzionale2 = opzionale2;
            inValue.opzionale3 = opzionale3;
            inValue.documento = documento;
            WinMef730.InvioFlussi730.inviaFileMtomResponse retVal = ((WinMef730.InvioFlussi730.InvioTelematicoSS730pMtom)(this)).inviaFileMtom(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WinMef730.InvioFlussi730.inviaFileMtomResponse> WinMef730.InvioFlussi730.InvioTelematicoSS730pMtom.inviaFileMtomAsync(WinMef730.InvioFlussi730.inviaFileMtomRequest request) {
            return base.Channel.inviaFileMtomAsync(request);
        }
        
        public System.Threading.Tasks.Task<WinMef730.InvioFlussi730.inviaFileMtomResponse> inviaFileMtomAsync(string nomeFileAllegato, string pincodeInvianteCifrato, WinMef730.InvioFlussi730.proprietario datiProprietario, string opzionale1, string opzionale2, string opzionale3, byte[] documento) {
            WinMef730.InvioFlussi730.inviaFileMtomRequest inValue = new WinMef730.InvioFlussi730.inviaFileMtomRequest();
            inValue.nomeFileAllegato = nomeFileAllegato;
            inValue.pincodeInvianteCifrato = pincodeInvianteCifrato;
            inValue.datiProprietario = datiProprietario;
            inValue.opzionale1 = opzionale1;
            inValue.opzionale2 = opzionale2;
            inValue.opzionale3 = opzionale3;
            inValue.documento = documento;
            return ((WinMef730.InvioFlussi730.InvioTelematicoSS730pMtom)(this)).inviaFileMtomAsync(inValue);
        }
    }
}

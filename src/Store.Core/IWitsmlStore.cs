//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PDS.WITSMLstudio.Store
{
    /// <summary>
    /// Generated WitsmlStore service interface
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.witsml.org/wsdl/120", ConfigurationName="PDS.WITSMLstudio.Store.IWitsmlStore")]
    public interface IWitsmlStore
    {
        /// <summary>
        /// Returns the response for adding one WITSML data-object to the server
        /// </summary>
        /// <param name="request">The request object encapsulating the method input parameters.</param>
        /// <returns>A positive value indicates a success; a negative value indicates an error.</returns>   
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_AddToStore")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        PDS.WITSMLstudio.Store.WMLS_AddToStoreResponse WMLS_AddToStore(PDS.WITSMLstudio.Store.WMLS_AddToStoreRequest request);

        /// <summary>
        /// Returns the response for deleting one WITSML data-object to the server.
        /// </summary>
        /// <param name="request">he request object encapsulating the method input parameters.</param>
        /// <returns>A positive value indicates a success; a negative value indicates an error.</returns>
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_DeleteFromStore")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        PDS.WITSMLstudio.Store.WMLS_DeleteFromStoreResponse WMLS_DeleteFromStore(PDS.WITSMLstudio.Store.WMLS_DeleteFromStoreRequest request);

        /// <summary>
        /// Returns a string containing only the fixed (base) message text associated with a defined Return Value.
        /// </summary>
        /// <param name="request">The request object encapsulating the method input parameters.</param>
        /// <returns>The fixed descriptive message text associated with the Return Value.</returns>
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.witsml.org/message/120) of message WMLS_GetBaseMsgRequest does not match the default value (http://www.witsml.org/wsdl/120)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_GetBaseMsg")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        PDS.WITSMLstudio.Store.WMLS_GetBaseMsgResponse WMLS_GetBaseMsg(PDS.WITSMLstudio.Store.WMLS_GetBaseMsgRequest request);

        /// <summary>
        /// Returns the capServer object that describes the capabilities of the server for one Data Schema Version.
        /// </summary>
        /// <param name="request">The request object encapsulating the method input parameters.</param>
        /// <returns>A positive value indicates a success; a negative value indicates an error.</returns>
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_GetCap")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        PDS.WITSMLstudio.Store.WMLS_GetCapResponse WMLS_GetCap(PDS.WITSMLstudio.Store.WMLS_GetCapRequest request);

        /// <summary>
        /// Returns one or more WITSML data-objects from the server.
        /// </summary>
        /// <param name="request">The request object encapsulating the method input parameters.</param>
        /// <returns>
        /// A positive value indicating success along with one or more WITSML data-objects from the server, or a negative value indicating an error.
        /// </returns>
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_GetFromStore")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        PDS.WITSMLstudio.Store.WMLS_GetFromStoreResponse WMLS_GetFromStore(PDS.WITSMLstudio.Store.WMLS_GetFromStoreRequest request);

        /// <summary>
        /// Returns a string containing the Data Schema Version(s) that a server supports.
        /// </summary>
        /// <param name="request">The request object encapsulating the method input parameters.</param>
        /// <returns>A comma-separated list of Data Schema Versions (without spaces) that the server supports.</returns>
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.witsml.org/message/120) of message WMLS_GetVersionRequest does not match the default value (http://www.witsml.org/wsdl/120)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_GetVersion")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        PDS.WITSMLstudio.Store.WMLS_GetVersionResponse WMLS_GetVersion(PDS.WITSMLstudio.Store.WMLS_GetVersionRequest request);

        /// <summary>
        /// Returns the response for updating one WITSML data-object to the server.
        /// </summary>
        /// <param name="request">he request object encapsulating the method input parameters.</param>
        /// <returns>A positive value indicates a success; a negative value indicates an error.</returns>
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_UpdateInStore")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        PDS.WITSMLstudio.Store.WMLS_UpdateInStoreResponse WMLS_UpdateInStore(PDS.WITSMLstudio.Store.WMLS_UpdateInStoreRequest request);
    }

    /// <summary>
    /// AddToStore request class
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_AddToStore", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_AddToStoreRequest
    {
        /// <summary>
        /// The Witsml type
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string WMLtypeIn;

        /// <summary>
        /// The XML input
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string XMLin;

        /// <summary>
        /// The options in
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string OptionsIn;

        /// <summary>
        /// The capabilities in
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string CapabilitiesIn;

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_AddToStoreRequest"/> class.
        /// </summary>
        public WMLS_AddToStoreRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_AddToStoreRequest"/> class.
        /// </summary>
        /// <param name="WMLtypeIn">The Witsml type.</param>
        /// <param name="XMLin">The XML input.</param>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="CapabilitiesIn">The capabilities in.</param>
        public WMLS_AddToStoreRequest(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn)
        {
            this.WMLtypeIn = WMLtypeIn;
            this.XMLin = XMLin;
            this.OptionsIn = OptionsIn;
            this.CapabilitiesIn = CapabilitiesIn;
        }
    }

    /// <summary>
    /// AddToStore Response class
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_AddToStoreResponse", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_AddToStoreResponse
    {

        /// <summary>
        /// The result
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public short Result;

        /// <summary>
        /// The supplemental message
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string SuppMsgOut;

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_AddToStoreResponse"/> class.
        /// </summary>
        public WMLS_AddToStoreResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_AddToStoreResponse"/> class.
        /// </summary>
        /// <param name="Result">The result.</param>
        /// <param name="SuppMsgOut">The supp MSG out.</param>
        public WMLS_AddToStoreResponse(short Result, string SuppMsgOut)
        {
            this.Result = Result;
            this.SuppMsgOut = SuppMsgOut;
        }
    }

    /// <summary>
    /// DeleteFromStore Request class
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_DeleteFromStore", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_DeleteFromStoreRequest
    {
        /// <summary>
        /// The Witsml type
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string WMLtypeIn;

        /// <summary>
        /// The query in
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string QueryIn;

        /// <summary>
        /// The options in
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string OptionsIn;

        /// <summary>
        /// The capabilities in
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string CapabilitiesIn;

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_DeleteFromStoreRequest"/> class.
        /// </summary>
        public WMLS_DeleteFromStoreRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_DeleteFromStoreRequest"/> class.
        /// </summary>
        /// <param name="WMLtypeIn">The Witsml type.</param>
        /// <param name="QueryIn">The query in.</param>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="CapabilitiesIn">The capabilities in.</param>
        public WMLS_DeleteFromStoreRequest(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn)
        {
            this.WMLtypeIn = WMLtypeIn;
            this.QueryIn = QueryIn;
            this.OptionsIn = OptionsIn;
            this.CapabilitiesIn = CapabilitiesIn;
        }
    }

    /// <summary>
    /// DeleteFromStore Response class
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_DeleteFromStoreResponse", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_DeleteFromStoreResponse
    {

        /// <summary>
        /// The result
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public short Result;

        /// <summary>
        /// The supplemental message
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string SuppMsgOut;

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_DeleteFromStoreResponse"/> class.
        /// </summary>
        public WMLS_DeleteFromStoreResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_DeleteFromStoreResponse"/> class.
        /// </summary>
        /// <param name="Result">The result.</param>
        /// <param name="SuppMsgOut">The supplemental message.</param>
        public WMLS_DeleteFromStoreResponse(short Result, string SuppMsgOut)
        {
            this.Result = Result;
            this.SuppMsgOut = SuppMsgOut;
        }
    }

    /// <summary>
    /// GetBaseMsg Request class
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetBaseMsg", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetBaseMsgRequest
    {

        /// <summary>
        /// The return value in
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public short ReturnValueIn;

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetBaseMsgRequest"/> class.
        /// </summary>
        public WMLS_GetBaseMsgRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetBaseMsgRequest"/> class.
        /// </summary>
        /// <param name="ReturnValueIn">The return value in.</param>
        public WMLS_GetBaseMsgRequest(short ReturnValueIn)
        {
            this.ReturnValueIn = ReturnValueIn;
        }
    }

    /// <summary>
    /// GetBaseMsg Response class
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetBaseMsgResponse", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetBaseMsgResponse
    {

        /// <summary>
        /// The result
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string Result;

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetBaseMsgResponse"/> class.
        /// </summary>
        public WMLS_GetBaseMsgResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetBaseMsgResponse"/> class.
        /// </summary>
        /// <param name="Result">The result.</param>
        public WMLS_GetBaseMsgResponse(string Result)
        {
            this.Result = Result;
        }
    }

    /// <summary>
    /// GetCap Request class
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetCap", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetCapRequest
    {

        /// <summary>
        /// The options in
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string OptionsIn;

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetCapRequest"/> class.
        /// </summary>
        public WMLS_GetCapRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetCapRequest"/> class.
        /// </summary>
        /// <param name="OptionsIn">The options in.</param>
        public WMLS_GetCapRequest(string OptionsIn)
        {
            this.OptionsIn = OptionsIn;
        }
    }

    /// <summary>
    /// GetCap Response class
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetCapResponse", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetCapResponse
    {

        /// <summary>
        /// The result
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public short Result;

        /// <summary>
        /// The capabilities out
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string CapabilitiesOut;

        /// <summary>
        /// The supplemental message
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string SuppMsgOut;

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetCapResponse"/> class.
        /// </summary>
        public WMLS_GetCapResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetCapResponse"/> class.
        /// </summary>
        /// <param name="Result">The result.</param>
        /// <param name="CapabilitiesOut">The capabilities out.</param>
        /// <param name="SuppMsgOut">The supplemental message.</param>
        public WMLS_GetCapResponse(short Result, string CapabilitiesOut, string SuppMsgOut)
        {
            this.Result = Result;
            this.CapabilitiesOut = CapabilitiesOut;
            this.SuppMsgOut = SuppMsgOut;
        }
    }

    /// <summary>
    /// GetFromStore Request class
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetFromStore", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetFromStoreRequest
    {

        /// <summary>
        /// The Witsml type
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string WMLtypeIn;

        /// <summary>
        /// The query in
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string QueryIn;

        /// <summary>
        /// The options in
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string OptionsIn;

        /// <summary>
        /// The capabilities in
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string CapabilitiesIn;

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetFromStoreRequest"/> class.
        /// </summary>
        public WMLS_GetFromStoreRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetFromStoreRequest"/> class.
        /// </summary>
        /// <param name="WMLtypeIn">The Witsml type.</param>
        /// <param name="QueryIn">The query in.</param>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="CapabilitiesIn">The capabilities in.</param>
        public WMLS_GetFromStoreRequest(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn)
        {
            this.WMLtypeIn = WMLtypeIn;
            this.QueryIn = QueryIn;
            this.OptionsIn = OptionsIn;
            this.CapabilitiesIn = CapabilitiesIn;
        }
    }

    /// <summary>
    /// GetFromStore Response class
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetFromStoreResponse", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetFromStoreResponse
    {

        /// <summary>
        /// The result
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public short Result;

        /// <summary>
        /// The XML output
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string XMLout;

        /// <summary>
        /// The supplemental message
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string SuppMsgOut;

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetFromStoreResponse"/> class.
        /// </summary>
        public WMLS_GetFromStoreResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetFromStoreResponse"/> class.
        /// </summary>
        /// <param name="Result">The result.</param>
        /// <param name="XMLout">The XML output.</param>
        /// <param name="SuppMsgOut">The supplemental message.</param>
        public WMLS_GetFromStoreResponse(short Result, string XMLout, string SuppMsgOut)
        {
            this.Result = Result;
            this.XMLout = XMLout;
            this.SuppMsgOut = SuppMsgOut;
        }
    }

    /// <summary>
    /// GetVersion Request class
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetVersion", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetVersionRequest
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetVersionRequest"/> class.
        /// </summary>
        public WMLS_GetVersionRequest()
        {
        }
    }

    /// <summary>
    /// GetVersion Response class
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetVersionResponse", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetVersionResponse
    {

        /// <summary>
        /// The result
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string Result;

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetVersionResponse"/> class.
        /// </summary>
        public WMLS_GetVersionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_GetVersionResponse"/> class.
        /// </summary>
        /// <param name="Result">The result.</param>
        public WMLS_GetVersionResponse(string Result)
        {
            this.Result = Result;
        }
    }

    /// <summary>
    /// UpdateInStore Request class
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_UpdateInStore", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_UpdateInStoreRequest
    {

        /// <summary>
        /// The Witsml type
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string WMLtypeIn;

        /// <summary>
        /// The XML input
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string XMLin;

        /// <summary>
        /// The options in
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string OptionsIn;

        /// <summary>
        /// The capabilities in
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string CapabilitiesIn;

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_UpdateInStoreRequest"/> class.
        /// </summary>
        public WMLS_UpdateInStoreRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_UpdateInStoreRequest"/> class.
        /// </summary>
        /// <param name="WMLtypeIn">The Witsml type.</param>
        /// <param name="XMLin">The XML input.</param>
        /// <param name="OptionsIn">The options in.</param>
        /// <param name="CapabilitiesIn">The capabilities in.</param>
        public WMLS_UpdateInStoreRequest(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn)
        {
            this.WMLtypeIn = WMLtypeIn;
            this.XMLin = XMLin;
            this.OptionsIn = OptionsIn;
            this.CapabilitiesIn = CapabilitiesIn;
        }
    }

    /// <summary>
    /// UpdateInStore Response class
    /// </summary>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_UpdateInStoreResponse", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_UpdateInStoreResponse
    {

        /// <summary>
        /// The result
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public short Result;

        /// <summary>
        /// The supplemental message
        /// </summary>
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string SuppMsgOut;

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_UpdateInStoreResponse"/> class.
        /// </summary>
        public WMLS_UpdateInStoreResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WMLS_UpdateInStoreResponse"/> class.
        /// </summary>
        /// <param name="Result">The result.</param>
        /// <param name="SuppMsgOut">The supplemental message.</param>
        public WMLS_UpdateInStoreResponse(short Result, string SuppMsgOut)
        {
            this.Result = Result;
            this.SuppMsgOut = SuppMsgOut;
        }
    }
}

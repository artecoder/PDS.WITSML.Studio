// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Datatypes
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class SupportedProtocol : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""SupportedProtocol"",""namespace"":""Energistics.Datatypes"",""fields"":[{""name"":""protocol"",""type"":""int""},{""name"":""protocolVersion"",""type"":{""type"":""record"",""name"":""Version"",""namespace"":""Energistics.Datatypes"",""fields"":[{""name"":""major"",""type"":""int""},{""name"":""minor"",""type"":""int""},{""name"":""revision"",""type"":""int""},{""name"":""patch"",""type"":""int""}],""fullName"":""Energistics.Datatypes.Version"",""depends"":[]}},{""name"":""role"",""type"":""string""},{""name"":""protocolCapabilities"",""type"":{""type"":""map"",""values"":{""type"":""record"",""name"":""DataValue"",""namespace"":""Energistics.Datatypes"",""fields"":[{""name"":""item"",""type"":[""null"",""double"",""float"",""int"",""long"",""string"",{""type"":""record"",""name"":""ArrayOfDouble"",""namespace"":""Energistics.Datatypes"",""fields"":[{""name"":""values"",""type"":{""type"":""array"",""items"":""double""}}],""fullName"":""Energistics.Datatypes.ArrayOfDouble"",""depends"":[]},""boolean"",""bytes""]}],""fullName"":""Energistics.Datatypes.DataValue"",""depends"":[
  ""Energistics.Datatypes.ArrayOfDouble""
]}}}],""fullName"":""Energistics.Datatypes.SupportedProtocol"",""depends"":[
  ""Energistics.Datatypes.Version"",
  ""Energistics.Datatypes.DataValue""
]}");
		private int _protocol;
		private Energistics.Etp.v11.Datatypes.Version _protocolVersion;
		private string _role;
		private IDictionary<string,Energistics.Etp.v11.Datatypes.DataValue> _protocolCapabilities;
		public virtual Schema Schema
		{
			get
			{
				return SupportedProtocol._SCHEMA;
			}
		}
		public int Protocol
		{
			get
			{
				return this._protocol;
			}
			set
			{
				this._protocol = value;
			}
		}
		public Energistics.Etp.v11.Datatypes.Version ProtocolVersion
		{
			get
			{
				return this._protocolVersion;
			}
			set
			{
				this._protocolVersion = value;
			}
		}
		public string Role
		{
			get
			{
				return this._role;
			}
			set
			{
				this._role = value;
			}
		}
		public IDictionary<string,Energistics.Etp.v11.Datatypes.DataValue> ProtocolCapabilities
		{
			get
			{
				return this._protocolCapabilities;
			}
			set
			{
				this._protocolCapabilities = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._protocol;
			case 1: return this._protocolVersion;
			case 2: return this._role;
			case 3: return this._protocolCapabilities;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._protocol = (System.Int32)fieldValue; break;
			case 1: this._protocolVersion = (Energistics.Etp.v11.Datatypes.Version)fieldValue; break;
			case 2: this._role = (System.String)fieldValue; break;
			case 3: this._protocolCapabilities = (IDictionary<string,Energistics.Etp.v11.Datatypes.DataValue>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

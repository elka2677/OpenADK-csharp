// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;

namespace OpenADK.Library.Infra{

/// <summary>
	///       This element holds the sub-message being sent by the <SIF_SystemControl>
	///       message. This class is used internally by the ADK. To send a ping, sleep, or wakeup
	///       request to the Zone Integration Server, agents should call the sifPing,
	///       sleep, and wakeup methods of the Zone and Agent classes. SIF_GetMessage is
	///       automatically sent by the class framework for zones that are connected in
	///       Pull mode.
	///     </summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class SIF_SystemControlData : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a SIF_SystemControlData
	/// </summary>
	public SIF_SystemControlData() : base ( InfraDTD.SIF_SYSTEMCONTROLDATA ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="value">Gets or sets the content value of the &amp;lt;SIF_SystemControlData&amp;gt; element</param>
	///
	public SIF_SystemControlData( string value ) : base( InfraDTD.SIF_SYSTEMCONTROLDATA )
	{
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_SystemControlData( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InfraDTD.SIF_SYSTEMCONTROLDATA }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_SystemControlData&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;SIF_SystemControlData&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_SYSTEMCONTROLDATA ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_SYSTEMCONTROLDATA, new SifString( value ), value );
		}
	}

}}

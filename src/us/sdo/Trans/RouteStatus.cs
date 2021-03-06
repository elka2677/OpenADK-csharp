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
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Trans{

/// <summary>A RouteStatus</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class RouteStatus : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a RouteStatus
	/// </summary>
	public RouteStatus() : base ( TransDTD.ROUTESTATUS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="status">Status of the route.</param>
	///<param name="busRouteInfoRefId">GUID</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;RouteStatus&amp;gt; element</param>
	///
	public RouteStatus( RouteStatusStatus status, string busRouteInfoRefId, string value ) : base( TransDTD.ROUTESTATUS )
	{
		this.SetStatus( status );
		this.BusRouteInfoRefId = busRouteInfoRefId;
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected RouteStatus( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { TransDTD.ROUTESTATUS_BUSROUTEINFOREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RouteStatus&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;RouteStatus&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( TransDTD.ROUTESTATUS ) ;
		}
		set
		{
			SetFieldValue( TransDTD.ROUTESTATUS, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Status</c> attribute.
	/// </summary>
	/// <value> The <c>Status</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Status of the route."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Status
	{
		get
		{ 
			return GetFieldValue( TransDTD.ROUTESTATUS_STATUS );
		}
		set
		{
			SetField( TransDTD.ROUTESTATUS_STATUS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Status</c> attribute.
	/// </summary>
	/// <param name="val">A RouteStatusStatus object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Status of the route."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetStatus( RouteStatusStatus val )
	{
		SetField( TransDTD.ROUTESTATUS_STATUS, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>BusRouteInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>BusRouteInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "GUID"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string BusRouteInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( TransDTD.ROUTESTATUS_BUSROUTEINFOREFID ) ;
		}
		set
		{
			SetFieldValue( TransDTD.ROUTESTATUS_BUSROUTEINFOREFID, new SifString( value ), value );
		}
	}

}}

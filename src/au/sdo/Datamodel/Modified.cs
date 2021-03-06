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
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Datamodel{

/// <summary>A single modification event.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class Modified : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Modified
	/// </summary>
	public Modified() : base ( DatamodelDTD.MODIFIED ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="by">Identifier of the system or person that modified the data.</param>
	///<param name="dateTime">The date/time the modification occurred.</param>
	///
	public Modified( string by, DateTime? dateTime ) : base( DatamodelDTD.MODIFIED )
	{
		this.By = by;
		this.DateTime = dateTime;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Modified( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { DatamodelDTD.MODIFIED_DATETIME }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;By&gt;</c> element.
	/// </summary>
	/// <value> The <c>By</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Identifier of the system or person that modified the data."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string By
	{
		get
		{
			return (string) GetSifSimpleFieldValue( DatamodelDTD.MODIFIED_BY ) ;
		}
		set
		{
			SetFieldValue( DatamodelDTD.MODIFIED_BY, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DateTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>DateTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date/time the modification occurred."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public DateTime? DateTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( DatamodelDTD.MODIFIED_DATETIME ) ;
		}
		set
		{
			SetFieldValue( DatamodelDTD.MODIFIED_DATETIME, new SifDateTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Human readable description of the data modifications."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( DatamodelDTD.MODIFIED_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( DatamodelDTD.MODIFIED_DESCRIPTION, new SifString( value ), value );
		}
	}

}}

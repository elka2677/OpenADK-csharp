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

namespace OpenADK.Library.us.Library{

/// <summary>A CheckoutInfo</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class CheckoutInfo : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a CheckoutInfo
	/// </summary>
	public CheckoutInfo() : base ( LibraryDTD.CHECKOUTINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="returnBy">The date and time that this item is due to be returned.</param>
	///
	public CheckoutInfo( DateTime? returnBy ) : base( LibraryDTD.CHECKOUTINFO )
	{
		this.ReturnBy = returnBy;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected CheckoutInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { LibraryDTD.CHECKOUTINFO_RETURNBY }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReturnBy&gt;</c> element.
	/// </summary>
	/// <value> The <c>ReturnBy</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date and time that this item is due to be returned."</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;ReturnBy&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public DateTime? ReturnBy
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LibraryDTD.CHECKOUTINFO_RETURNBY ) ;
		}
		set
		{
			SetFieldValue( LibraryDTD.CHECKOUTINFO_RETURNBY, new SifDateTime( value ), value );
		}
	}

}}

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

namespace OpenADK.Library.us.Food{

/// <summary>This gives information about a staff member's meal status.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class EarnedStatus : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an EarnedStatus
	/// </summary>
	public EarnedStatus() : base ( FoodDTD.EARNEDSTATUS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="type">Earned status type.</param>
	///
	public EarnedStatus( YesNoNA type ) : base( FoodDTD.EARNEDSTATUS )
	{
		this.SetType( type );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected EarnedStatus( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { FoodDTD.EARNEDSTATUS_TYPE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <value> The <c>Type</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Earned status type."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Type
	{
		get
		{ 
			return GetFieldValue( FoodDTD.EARNEDSTATUS_TYPE );
		}
		set
		{
			SetField( FoodDTD.EARNEDSTATUS_TYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <param name="val">A YesNoNA object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Earned status type."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetType( YesNoNA val )
	{
		SetField( FoodDTD.EARNEDSTATUS_TYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StartDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>StartDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date on which earned status became effective (inclusive)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? StartDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( FoodDTD.EARNEDSTATUS_STARTDATE ) ;
		}
		set
		{
			SetFieldValue( FoodDTD.EARNEDSTATUS_STARTDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EndDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>EndDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date on which earned status was last in effect. This attribute is conditional upon the StartDate element. It exists only if the StartDate element exists."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? EndDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( FoodDTD.EARNEDSTATUS_ENDDATE ) ;
		}
		set
		{
			SetFieldValue( FoodDTD.EARNEDSTATUS_ENDDATE, new SifDate( value ), value );
		}
	}

}}

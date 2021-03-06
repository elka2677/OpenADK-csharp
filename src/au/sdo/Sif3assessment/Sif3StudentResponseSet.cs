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

namespace OpenADK.Library.au.Sif3assessment{

/// <summary>A Sif3StudentResponseSet</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Sif3StudentResponseSet : SifDataObject
{
	/// <summary>
	/// Creates an instance of a Sif3StudentResponseSet
	/// </summary>
	public Sif3StudentResponseSet() : base( Adk.SifVersion, Sif3assessmentDTD.SIF3STUDENTRESPONSESET ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">A RefId</param>
	///<param name="assessmentAdministrationRefId">An AssessmentAdministrationRefId</param>
	///<param name="studentPersonalRefId">A StudentPersonalRefId</param>
	///<param name="assessmentRegistrationRefId">An AssessmentRegistrationRefId</param>
	///<param name="items">An Items</param>
	///
	public Sif3StudentResponseSet( string refId, string assessmentAdministrationRefId, string studentPersonalRefId, string assessmentRegistrationRefId, ItemList items ) : base( Adk.SifVersion, Sif3assessmentDTD.SIF3STUDENTRESPONSESET )
	{
		this.RefId = refId;
		this.AssessmentAdministrationRefId = assessmentAdministrationRefId;
		this.StudentPersonalRefId = studentPersonalRefId;
		this.AssessmentRegistrationRefId = assessmentRegistrationRefId;
		this.Items = items;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Sif3StudentResponseSet( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.SIF3STUDENTRESPONSESET_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3STUDENTRESPONSESET_REFID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3STUDENTRESPONSESET_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>AssessmentAdministrationRefId</c> attribute.
	/// </summary>
	/// <value> The <c>AssessmentAdministrationRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentAdministrationRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3STUDENTRESPONSESET_ASSESSMENTADMINISTRATIONREFID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3STUDENTRESPONSESET_ASSESSMENTADMINISTRATIONREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>StudentPersonalRefId</c> attribute.
	/// </summary>
	/// <value> The <c>StudentPersonalRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string StudentPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3STUDENTRESPONSESET_STUDENTPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3STUDENTRESPONSESET_STUDENTPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>AssessmentRegistrationRefId</c> attribute.
	/// </summary>
	/// <value> The <c>AssessmentRegistrationRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentRegistrationRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3STUDENTRESPONSESET_ASSESSMENTREGISTRATIONREFID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3STUDENTRESPONSESET_ASSESSMENTREGISTRATIONREFID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Items&gt;</c> element.</summary>
	/// <param name="Item">An Item</param>
	///<remarks>
	/// <para>This form of <c>setItems</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Items</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetItems( Sif3Item Item ) {
		RemoveChild( Sif3assessmentDTD.SIF3STUDENTRESPONSESET_ITEMS);
		AddChild( Sif3assessmentDTD.SIF3STUDENTRESPONSESET_ITEMS, new ItemList( Item ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Items&gt;</c> element.
	/// </summary>
	/// <value> An ItemList </value>
	/// <remarks>
	/// <para>To remove the <c>ItemList</c>, set <c>Items</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public ItemList Items
	{
		get
		{
			return (ItemList)GetChild( Sif3assessmentDTD.SIF3STUDENTRESPONSESET_ITEMS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3STUDENTRESPONSESET_ITEMS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3STUDENTRESPONSESET_ITEMS, value );
			}
		}
	}

}}

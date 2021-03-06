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

namespace OpenADK.Library.uk.Common{

/// <summary>This is a common element used to specify a collection of supported National Curriculum Year Groups. It is used in SchoolInfo and assessment-related objects.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class NCYearGroupList : SifKeyedList<NCYearGroup>
{
	/// <summary>
	/// Creates an instance of a NCYearGroupList
	/// </summary>
	public NCYearGroupList() : base ( CommonDTD.NCYEARGROUPLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="ncYearGroup">Code representing a National Curriculum year group.</param>
	///
	public NCYearGroupList( NCYearGroup ncYearGroup ) : base( CommonDTD.NCYEARGROUPLIST )
	{
		this.SafeAddChild( CommonDTD.NCYEARGROUPLIST_NCYEARGROUP, ncYearGroup );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected NCYearGroupList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.NCYEARGROUPLIST_NCYEARGROUP }; }
	}

	///<summary>Adds the value of the <c>&lt;NCYearGroup&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;NCYearGroup&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setNCYearGroup</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddNCYearGroup</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddNCYearGroup( NCYear Value ) {
		AddChild( CommonDTD.NCYEARGROUPLIST_NCYEARGROUP, new NCYearGroup( Value ) );
	}

}}

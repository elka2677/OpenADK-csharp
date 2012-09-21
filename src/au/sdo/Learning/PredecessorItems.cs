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

namespace OpenADK.Library.au.Learning{

/// <summary>A PredecessorItems</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class PredecessorItems : SifKeyedList<LearningResourceRefIds>
{
	/// <summary>
	/// Creates an instance of a PredecessorItems
	/// </summary>
	public PredecessorItems() : base ( LearningDTD.PREDECESSORITEMS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="learningResourceRefId">A LearningResourceRefId</param>
	///
	public PredecessorItems( LearningResourceRefIds learningResourceRefId ) : base( LearningDTD.PREDECESSORITEMS )
	{
		this.SafeAddChild( LearningDTD.PREDECESSORITEMS_LEARNINGRESOURCEREFID, learningResourceRefId );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected PredecessorItems( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;LearningResourceRefId&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;LearningResourceRefIds&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setLearningResourceRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddLearningResourceRefId</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void AddLearningResourceRefId( string Value ) {
		AddChild( LearningDTD.PREDECESSORITEMS_LEARNINGRESOURCEREFID, new LearningResourceRefIds( Value ) );
	}

}}
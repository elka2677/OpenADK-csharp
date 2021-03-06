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

namespace OpenADK.Library.us.Assessment{

/// <summary>A ScoresSif3Rubric</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class ScoresSif3Rubric : SifKeyedList<ScoreSif3Rubric>
{
	/// <summary>
	/// Creates an instance of a ScoresSif3Rubric
	/// </summary>
	public ScoresSif3Rubric() : base ( AssessmentDTD.SCORESSIF3RUBRIC ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="scoreSif3Rubric">Provides a wrapper for the attributes of each score code.</param>
	///
	public ScoresSif3Rubric( ScoreSif3Rubric scoreSif3Rubric ) : base( AssessmentDTD.SCORESSIF3RUBRIC )
	{
		this.SafeAddChild( AssessmentDTD.SCORESSIF3RUBRIC_SCORESIF3RUBRIC, scoreSif3Rubric );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ScoresSif3Rubric( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.SCORESSIF3RUBRIC_SCORESIF3RUBRIC }; }
	}

	///<summary>Adds the value of the <c>&lt;ScoreSif3Rubric&gt;</c> element.</summary>
	/// <param name="ScoreValue">Numeric values for the score code. For example a 4 point rubric would typically have the values 1 through 4, plus zero for no score. The non-numeric score codes will likely have a score value of zero.</param>
	///<remarks>
	/// <para>This form of <c>setScoreSif3Rubric</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddScoreSif3Rubric</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddScoreSif3Rubric( decimal? ScoreValue ) {
		AddChild( AssessmentDTD.SCORESSIF3RUBRIC_SCORESIF3RUBRIC, new ScoreSif3Rubric( ScoreValue ) );
	}

}}

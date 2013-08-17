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

/// <summary>A ScoreValues</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class ScoreValues : SifKeyedList<ScoreValue>
{
	/// <summary>
	/// Creates an instance of a ScoreValues
	/// </summary>
	public ScoreValues() : base ( AssessmentDTD.SCOREVALUES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="scoreValue">A ScoreValue</param>
	///
	public ScoreValues( ScoreValue scoreValue ) : base( AssessmentDTD.SCOREVALUES )
	{
		this.SafeAddChild( AssessmentDTD.SCOREVALUES_SCOREVALUE, scoreValue );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ScoreValues( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.SCOREVALUES_SCOREVALUE }; }
	}

	///<summary>Adds the value of the <c>&lt;ScoreValue&gt;</c> element.</summary>
	/// <param name="FromScoreMetric">Indicates the score metric that is being used as the source to derive another score metric. For example, if this score table is using the raw score to derive a scaled score, then this will be the raw score metric (3478).</param>
	/// <param name="LowerCut">A LowerCut</param>
	/// <param name="UpperCut">An UpperCut</param>
	/// <param name="DerivedValue">This is the derived score value when the from-score is within the range specified. The unit used for this value should be represented in the units reported by the ToScoreMetric.</param>
	///<remarks>
	/// <para>This form of <c>setScoreValue</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddScoreValue</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddScoreValue( AssessmentReportingMethod FromScoreMetric, string LowerCut, string UpperCut, DerivedValue DerivedValue ) {
		AddChild( AssessmentDTD.SCOREVALUES_SCOREVALUE, new ScoreValue( FromScoreMetric, LowerCut, UpperCut, DerivedValue ) );
	}

}}
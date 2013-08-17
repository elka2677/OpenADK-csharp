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

/// <summary>A ScoreComments</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class ScoreComments : SifList<ScoreComment>
{
	/// <summary>
	/// Creates an instance of a ScoreComments
	/// </summary>
	public ScoreComments() : base ( AssessmentDTD.SCORECOMMENTS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="scoreComment">Provides a wrapper for the code and description pairs for comment codes.</param>
	///
	public ScoreComments( ScoreComment scoreComment ) : base( AssessmentDTD.SCORECOMMENTS )
	{
		this.SafeAddChild( AssessmentDTD.SCORECOMMENTS_SCORECOMMENT, scoreComment );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ScoreComments( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.SCORECOMMENTS_SCORECOMMENT }; }
	}

	///<summary>Adds the value of the <c>&lt;ScoreComment&gt;</c> element.</summary>
	/// <param name="CommentCode">This is the comment code that is likely entered or selected by the scorer and is provided in data files or reports.</param>
	/// <param name="Comment">A description of the comment code. This can be used to provide additional feedback to the student for the score they received.</param>
	///<remarks>
	/// <para>This form of <c>setScoreComment</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddScoreComment</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddScoreComment( string CommentCode, AbstractContentElementType Comment ) {
		AddChild( AssessmentDTD.SCORECOMMENTS_SCORECOMMENT, new ScoreComment( CommentCode, Comment ) );
	}

}}
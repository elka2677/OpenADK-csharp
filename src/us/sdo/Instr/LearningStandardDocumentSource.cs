// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Instr
{
	///<summary>
	/// Defines the set of values that can be specified whenever a LearningStandardDocumentSource
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a LearningStandardDocumentSource object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class LearningStandardDocumentSource : SifEnum
	{
	/// <summary>Classroom ("Classroom")</summary>
	public static readonly LearningStandardDocumentSource CLASSROOM = new LearningStandardDocumentSource("Classroom");

	/// <summary>Publisher ("Publisher")</summary>
	public static readonly LearningStandardDocumentSource PUBLISHER = new LearningStandardDocumentSource("Publisher");

	/// <summary>National ("National")</summary>
	public static readonly LearningStandardDocumentSource NATIONAL = new LearningStandardDocumentSource("National");

	/// <summary>District ("District")</summary>
	public static readonly LearningStandardDocumentSource DISTRICT = new LearningStandardDocumentSource("District");

	/// <summary>Regional ("Regional")</summary>
	public static readonly LearningStandardDocumentSource REGIONAL = new LearningStandardDocumentSource("Regional");

	/// <summary>State ("State")</summary>
	public static readonly LearningStandardDocumentSource STATE = new LearningStandardDocumentSource("State");

	/// <summary>Site ("Site")</summary>
	public static readonly LearningStandardDocumentSource SITE = new LearningStandardDocumentSource("Site");

	///<summary>Wrap an arbitrary string value in a LearningStandardDocumentSource object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static LearningStandardDocumentSource Wrap( String wrappedValue ) {
		return new LearningStandardDocumentSource( wrappedValue );
	}

	private LearningStandardDocumentSource( string enumDefValue ) : base( enumDefValue ) {}
	}
}
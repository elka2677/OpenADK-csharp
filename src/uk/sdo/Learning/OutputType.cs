// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Learning
{
	///<summary>
	/// Defines the set of values that can be specified whenever an OutputType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an OutputType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class OutputType : SifEnum
	{
	/// <summary>Year ("YR")</summary>
	public static readonly OutputType YR_YEAR = new OutputType("YR");

	/// <summary>TeachingGroup ("TG")</summary>
	public static readonly OutputType TG_TEACHINGGROUP = new OutputType("TG");

	/// <summary>Other Groups ("GR")</summary>
	public static readonly OutputType GR_OT_GROUPS = new OutputType("GR");

	///<summary>Wrap an arbitrary string value in an OutputType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static OutputType Wrap( String wrappedValue ) {
		return new OutputType( wrappedValue );
	}

	private OutputType( string enumDefValue ) : base( enumDefValue ) {}
	}
}

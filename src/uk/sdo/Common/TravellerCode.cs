// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever a TravellerCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a TravellerCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class TravellerCode : SifEnum
	{
	/// <summary>Traveller (Other) ("TR")</summary>
	public static readonly TravellerCode TRAVELLER_OTHER = new TravellerCode("TR");

	/// <summary>Not a Traveller ("NT")</summary>
	public static readonly TravellerCode NOT_A_TRAVELLER = new TravellerCode("NT");

	/// <summary>Occupational Traveller ("OT")</summary>
	public static readonly TravellerCode OCCUPATIONAL_TRAVELLER = new TravellerCode("OT");

	/// <summary>Gypsy/Roma (Travelling) ("GT")</summary>
	public static readonly TravellerCode GYPSY_ROMA_TRAVELLING = new TravellerCode("GT");

	/// <summary>Gypsy/Roma (Housed) ("GH")</summary>
	public static readonly TravellerCode GYPSY_ROMA_HOUSED = new TravellerCode("GH");

	///<summary>Wrap an arbitrary string value in a TravellerCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static TravellerCode Wrap( String wrappedValue ) {
		return new TravellerCode( wrappedValue );
	}

	private TravellerCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}

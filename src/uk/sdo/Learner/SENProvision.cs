// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Learner
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SENProvision
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SENProvision object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class SENProvision : SifEnum
	{
	/// <summary>No Special Educational Need ("N")</summary>
	public static readonly SENProvision NO_SPECIAL_EDUCATIONAL = new SENProvision("N");

	/// <summary>School Action Plus or Early Years Action Plus ("P")</summary>
	public static readonly SENProvision SCHOOL_ACTION_PLUS = new SENProvision("P");

	/// <summary>Statement ("S")</summary>
	public static readonly SENProvision STATEMENT = new SENProvision("S");

	/// <summary>School ActionPlus and Statutory Assessment (for historical and/or local purposes only - not valid for PLASC/School Census) ("Q")</summary>
	public static readonly SENProvision SCHOOL_ACTIONPLUS_STATUTORY = new SENProvision("Q");

	/// <summary>School Action or Early Years Action ("A")</summary>
	public static readonly SENProvision SCHOOL_ACTION = new SENProvision("A");

	///<summary>Wrap an arbitrary string value in a SENProvision object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SENProvision Wrap( String wrappedValue ) {
		return new SENProvision( wrappedValue );
	}

	private SENProvision( string enumDefValue ) : base( enumDefValue ) {}
	}
}
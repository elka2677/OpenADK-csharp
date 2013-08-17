// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Assessment
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SubTestIdentifierType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SubTestIdentifierType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	[Serializable]
	public class SubTestIdentifierType : SifEnum
	{
	/// <summary>custom ("custom")</summary>
	public static readonly SubTestIdentifierType OTHER = new SubTestIdentifierType("custom");

	/// <summary>assigned by the owner ("publisher")</summary>
	public static readonly SubTestIdentifierType PUBLISHER = new SubTestIdentifierType("publisher");

	/// <summary>assigned by the internal assessment service provider ("internal")</summary>
	public static readonly SubTestIdentifierType INTERNAL = new SubTestIdentifierType("internal");

	/// <summary>assigned by the client ("client")</summary>
	public static readonly SubTestIdentifierType CLIENT = new SubTestIdentifierType("client");

	///<summary>Wrap an arbitrary string value in a SubTestIdentifierType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SubTestIdentifierType Wrap( String wrappedValue ) {
		return new SubTestIdentifierType( wrappedValue );
	}

	private SubTestIdentifierType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
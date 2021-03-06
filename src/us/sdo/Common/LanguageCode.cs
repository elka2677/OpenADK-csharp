// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever a LanguageCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a LanguageCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	[Serializable]
	public class LanguageCode : SifEnum
	{
	/// <summary>Multiple Languages ("mul")</summary>
	public static readonly LanguageCode MULTIPLE = new LanguageCode("mul");

	/// <summary>Chechen ("che")</summary>
	public static readonly LanguageCode CHECHEN = new LanguageCode("che");

	/// <summary>English ("eng")</summary>
	public static readonly LanguageCode ENGLISH = new LanguageCode("eng");

	/// <summary>Hawaiian ("haw")</summary>
	public static readonly LanguageCode HAWAIIAN = new LanguageCode("haw");

	/// <summary>Spanish ("spn")</summary>
	public static readonly LanguageCode SPANISH = new LanguageCode("spn");

	/// <summary>Mohawk ("moh")</summary>
	public static readonly LanguageCode MOHAWK = new LanguageCode("moh");

	/// <summary>French ("fre")</summary>
	public static readonly LanguageCode FRENCH = new LanguageCode("fre");

	/// <summary>Japanese ("jpn")</summary>
	public static readonly LanguageCode JAPANESE = new LanguageCode("jpn");

	/// <summary>Hebrew ("heb")</summary>
	public static readonly LanguageCode HEBREW = new LanguageCode("heb");

	/// <summary>Italian ("ita")</summary>
	public static readonly LanguageCode ITALIAN = new LanguageCode("ita");

	/// <summary>Chinese ("chi")</summary>
	public static readonly LanguageCode CHINESE = new LanguageCode("chi");

	/// <summary>Korean ("kor")</summary>
	public static readonly LanguageCode KOREAN = new LanguageCode("kor");

	/// <summary>Cherokee ("chr")</summary>
	public static readonly LanguageCode CHEROKEE = new LanguageCode("chr");

	/// <summary>German ("ger")</summary>
	public static readonly LanguageCode GERMAN = new LanguageCode("ger");

	///<summary>Wrap an arbitrary string value in a LanguageCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static LanguageCode Wrap( String wrappedValue ) {
		return new LanguageCode( wrappedValue );
	}

	private LanguageCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}

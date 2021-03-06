// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Sif3assessment
{
	///<summary>
	/// Defines the set of values that can be specified whenever an AssetType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AssetType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	[Serializable]
	public class AssetType : SifEnum
	{
	/// <summary>map ("map")</summary>
	public static readonly AssetType MAP = new AssetType("map");

	/// <summary>graphing calculator ("graphing calculator")</summary>
	public static readonly AssetType GRAPHINGCALCULATOR = new AssetType("graphing calculator");

	/// <summary>graphic art ("graphic art")</summary>
	public static readonly AssetType GRAPHICART = new AssetType("graphic art");

	/// <summary>chart ("chart")</summary>
	public static readonly AssetType CHART = new AssetType("chart");

	/// <summary>english ruler ("english ruler")</summary>
	public static readonly AssetType ENGLISHRULER = new AssetType("english ruler");

	/// <summary>story board ("story board")</summary>
	public static readonly AssetType STORYBOARD = new AssetType("story board");

	/// <summary>formula sheet ("formula sheet")</summary>
	public static readonly AssetType FORMULASHEET = new AssetType("formula sheet");

	/// <summary>protractor ("protractor")</summary>
	public static readonly AssetType PROTRACTOR = new AssetType("protractor");

	/// <summary>video ("video")</summary>
	public static readonly AssetType VIDEO = new AssetType("video");

	/// <summary>table ("table")</summary>
	public static readonly AssetType TABLE = new AssetType("table");

	/// <summary>simulation ("simulation")</summary>
	public static readonly AssetType SIMULATION = new AssetType("simulation");

	/// <summary>basic calculator ("basic calculator")</summary>
	public static readonly AssetType BASICCALCULATOR = new AssetType("basic calculator");

	/// <summary>line draw ("line draw")</summary>
	public static readonly AssetType LINEDRAW = new AssetType("line draw");

	/// <summary>scientific calculator ("scientific calculator")</summary>
	public static readonly AssetType SCIENTIFICCALCULATOR = new AssetType("scientific calculator");

	/// <summary>audio ("audio")</summary>
	public static readonly AssetType AUDIO = new AssetType("audio");

	/// <summary>other interactive ("other interactive")</summary>
	public static readonly AssetType OTHERINTERACTIVE = new AssetType("other interactive");

	/// <summary>lab set ("lab set")</summary>
	public static readonly AssetType LABSET = new AssetType("lab set");

	/// <summary>scenario ("scenario")</summary>
	public static readonly AssetType SCENARIO = new AssetType("scenario");

	/// <summary>highlighter ("highlighter")</summary>
	public static readonly AssetType HIGHLIGHTER = new AssetType("highlighter");

	/// <summary>reading line ("reading line")</summary>
	public static readonly AssetType READINGLINE = new AssetType("reading line");

	/// <summary>standard calculator ("standard calculator")</summary>
	public static readonly AssetType STANDARDCALCULATOR = new AssetType("standard calculator");

	/// <summary>other non-interactive ("other non-interactive")</summary>
	public static readonly AssetType OTHERNONINTERACTIVE = new AssetType("other non-interactive");

	/// <summary>periodic table ("periodic table")</summary>
	public static readonly AssetType PERIODICTABLE = new AssetType("periodic table");

	/// <summary>other ("other")</summary>
	public static readonly AssetType OTHER = new AssetType("other");

	/// <summary>reading passage ("reading passage")</summary>
	public static readonly AssetType READINGPASSAGE = new AssetType("reading passage");

	/// <summary>translation dictionary ("translation dictionary")</summary>
	public static readonly AssetType TRANSLATIONDICTIONARY = new AssetType("translation dictionary");

	/// <summary>units ruler ("units ruler")</summary>
	public static readonly AssetType UNITSRULER = new AssetType("units ruler");

	/// <summary>metric ruler ("metric ruler")</summary>
	public static readonly AssetType METRICRULER = new AssetType("metric ruler");

	///<summary>Wrap an arbitrary string value in an AssetType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AssetType Wrap( String wrappedValue ) {
		return new AssetType( wrappedValue );
	}

	private AssetType( string enumDefValue ) : base( enumDefValue ) {}
	}
}

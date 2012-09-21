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

namespace OpenADK.Library.us.Food{

/// <summary>A Counts</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class Counts : SifKeyedList<Count>
{
	/// <summary>
	/// Creates an instance of a Counts
	/// </summary>
	public Counts() : base ( FoodDTD.COUNTS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="count">A Count</param>
	///
	public Counts( Count count ) : base( FoodDTD.COUNTS )
	{
		this.SafeAddChild( FoodDTD.COUNTS_COUNT, count );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Counts( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;Count&gt;</c> element.</summary>
	/// <param name="Value">The value of the count.</param>
	///<remarks>
	/// <para>This form of <c>setCount</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddCount</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddCount( decimal? Value ) {
		AddChild( FoodDTD.COUNTS_COUNT, new Count( Value ) );
	}

}}
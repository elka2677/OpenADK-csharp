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

namespace OpenADK.Library.Infra{

/// <summary>A SIF_ExtendedQuery</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class SIF_ExtendedQuery : SifElement
{
	/// <summary>
	/// Creates an instance of a SIF_ExtendedQuery
	/// </summary>
	public SIF_ExtendedQuery() : base ( InfraDTD.SIF_EXTENDEDQUERY ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifSelect">A SIF_Select</param>
	///<param name="sifFrom">A SIF_From</param>
	///
	public SIF_ExtendedQuery( SIF_Select sifSelect, SIF_From sifFrom ) : base( InfraDTD.SIF_EXTENDEDQUERY )
	{
		this.SIF_Select = sifSelect;
		this.SIF_From = sifFrom;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_ExtendedQuery( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { InfraDTD.SIF_EXTENDEDQUERY_SIF_SELECT, InfraDTD.SIF_EXTENDEDQUERY_SIF_FROM }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_DestinationProvider&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_DestinationProvider</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SIF_DestinationProvider
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_EXTENDEDQUERY_SIF_DESTINATIONPROVIDER ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_EXTENDEDQUERY_SIF_DESTINATIONPROVIDER, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_Select&gt;</c> element.</summary>
	/// <param name="Distinct">Specifies whether query results should return all rows (false) or just distinct ones (true). Rows are distinct if at least one column differs between them.</param>
	/// <param name="RowCount">The maximum number of rows to return. If All, return all rows, otherwise return the top rows up to the maximum row count indicated.</param>
	/// <param name="SifElement">A SIF_Element</param>
	///<remarks>
	/// <para>This form of <c>setSIF_Select</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_Select</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSIF_Select( bool? Distinct, string RowCount, SIFSelectElement SifElement ) {
		RemoveChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_SELECT);
		AddChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_SELECT, new SIF_Select( Distinct, RowCount, SifElement ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Select&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Select </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_Select</c>, set <c>SIF_Select</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_Select SIF_Select
	{
		get
		{
			return (SIF_Select)GetChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_SELECT);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_SELECT);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_SELECT, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_From&gt;</c> element.</summary>
	/// <param name="ObjectName">An ObjectName</param>
	/// <param name="SifObject">A SIF_Object</param>
	///<remarks>
	/// <para>This form of <c>setSIF_From</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_From</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSIF_From( string ObjectName, SIF_Object SifObject ) {
		RemoveChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_FROM);
		AddChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_FROM, new SIF_From( ObjectName, SifObject ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_From&gt;</c> element.
	/// </summary>
	/// <value> A SIF_From </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_From</c>, set <c>SIF_From</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_From SIF_From
	{
		get
		{
			return (SIF_From)GetChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_FROM);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_FROM);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_FROM, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_Where&gt;</c> element.</summary>
	/// <param name="SifConditionGroup">A SIF_ConditionGroup</param>
	///<remarks>
	/// <para>This form of <c>setSIF_Where</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_Where</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSIF_Where( SIF_ConditionGroup SifConditionGroup ) {
		RemoveChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_WHERE);
		AddChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_WHERE, new SIF_Where( SifConditionGroup ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Where&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Where </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_Where</c>, set <c>SIF_Where</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_Where SIF_Where
	{
		get
		{
			return (SIF_Where)GetChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_WHERE);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_WHERE);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_WHERE, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_OrderBy&gt;</c> element.</summary>
	/// <param name="SifElement">
	///         Indicates the element/attribute by which to sort.
	///       </param>
	///<remarks>
	/// <para>This form of <c>setSIF_OrderBy</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_OrderBy</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSIF_OrderBy( SIFOrderByElement SifElement ) {
		RemoveChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_ORDERBY);
		AddChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_ORDERBY, new SIF_OrderBy( SifElement ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_OrderBy&gt;</c> element.
	/// </summary>
	/// <value> A SIF_OrderBy </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_OrderBy</c>, set <c>SIF_OrderBy</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_OrderBy SIF_OrderBy
	{
		get
		{
			return (SIF_OrderBy)GetChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_ORDERBY);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_ORDERBY);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_EXTENDEDQUERY_SIF_ORDERBY, value );
			}
		}
	}

}}

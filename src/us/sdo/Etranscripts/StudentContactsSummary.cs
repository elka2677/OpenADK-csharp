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
using OpenADK.Library.us.Gradebook;
using OpenADK.Library.us.Student;

namespace OpenADK.Library.us.Etranscripts{

/// <summary>A StudentContactsSummary</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class StudentContactsSummary : SifElement
{
	/// <summary>
	/// Creates an instance of a StudentContactsSummary
	/// </summary>
	public StudentContactsSummary() : base ( EtranscriptsDTD.STUDENTCONTACTSSUMMARY ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentContactsSummary( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;ParentGuardian1&gt;</c> element.
	/// </summary>
	/// <value> A ParentGuardian </value>
	/// <remarks>
	/// <para>To remove the <c>ParentGuardian</c>, set <c>ParentGuardian1</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public ParentGuardian ParentGuardian1
	{
		get
		{
			return (ParentGuardian)GetChild( EtranscriptsDTD.STUDENTCONTACTSSUMMARY_PARENTGUARDIAN1);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STUDENTCONTACTSSUMMARY_PARENTGUARDIAN1);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STUDENTCONTACTSSUMMARY_PARENTGUARDIAN1, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ParentGuardian2&gt;</c> element.
	/// </summary>
	/// <value> A ParentGuardian </value>
	/// <remarks>
	/// <para>To remove the <c>ParentGuardian</c>, set <c>ParentGuardian2</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public ParentGuardian ParentGuardian2
	{
		get
		{
			return (ParentGuardian)GetChild( EtranscriptsDTD.STUDENTCONTACTSSUMMARY_PARENTGUARDIAN2);
		}
		set
		{
			RemoveChild( EtranscriptsDTD.STUDENTCONTACTSSUMMARY_PARENTGUARDIAN2);
			if( value != null)
			{
				AddChild( EtranscriptsDTD.STUDENTCONTACTSSUMMARY_PARENTGUARDIAN2, value );
			}
		}
	}

}}

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

namespace OpenADK.Library.us.Assessment{

/// <summary>An AssessmentGradeLevel</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class AssessmentGradeLevel : SifElement
{
	/// <summary>
	/// Creates an instance of an AssessmentGradeLevel
	/// </summary>
	public AssessmentGradeLevel() : base ( AssessmentDTD.ASSESSMENTGRADELEVEL ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentGradeLevel( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Code representing the grade level."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.ASSESSMENTGRADELEVEL_CODE );
		}
		set
		{
			SetField( AssessmentDTD.ASSESSMENTGRADELEVEL_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <param name="val">A GradeLevelCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Code representing the grade level."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetCode( GradeLevelCode val )
	{
		SetField( AssessmentDTD.ASSESSMENTGRADELEVEL_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( AssessmentDTD.ASSESSMENTGRADELEVEL_OTHERCODELIST);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTGRADELEVEL_OTHERCODELIST);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTGRADELEVEL_OTHERCODELIST, value );
			}
		}
	}

}}
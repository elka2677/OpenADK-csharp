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

/// <summary>An AcademicFoci</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.2</para>
/// </remarks>
[Serializable]
public class AcademicFoci : SifKeyedList<AcademicFocus>
{
	/// <summary>
	/// Creates an instance of an AcademicFoci
	/// </summary>
	public AcademicFoci() : base ( EtranscriptsDTD.ACADEMICFOCI ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="academicFocus">An AcademicFocus</param>
	///
	public AcademicFoci( AcademicFocus academicFocus ) : base( EtranscriptsDTD.ACADEMICFOCI )
	{
		this.SafeAddChild( EtranscriptsDTD.ACADEMICFOCI_ACADEMICFOCUS, academicFocus );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AcademicFoci( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;AcademicFocus&gt;</c> element.</summary>
	/// <param name="Code">A code to depict the focus of the educational program (replaces deprecated AcademicTrack.</param>
	///<remarks>
	/// <para>This form of <c>setAcademicFocus</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddAcademicFocus</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public void AddAcademicFocus( ProgramTypeCode Code ) {
		AddChild( EtranscriptsDTD.ACADEMICFOCI_ACADEMICFOCUS, new AcademicFocus( Code ) );
	}

}}

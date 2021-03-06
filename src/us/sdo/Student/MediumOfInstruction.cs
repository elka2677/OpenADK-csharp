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

namespace OpenADK.Library.us.Student{

/// <summary>A MediumOfInstruction</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class MediumOfInstruction : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a MediumOfInstruction
	/// </summary>
	public MediumOfInstruction() : base ( StudentDTD.MEDIUMOFINSTRUCTION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="code">Code representing the medium of instruction.</param>
	///
	public MediumOfInstruction( MediumOfInstructionCode code ) : base( StudentDTD.MEDIUMOFINSTRUCTION )
	{
		this.SetCode( code );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected MediumOfInstruction( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.MEDIUMOFINSTRUCTION_CODE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Code</c> attribute.
	/// </summary>
	/// <value> The <c>Code</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Code representing the medium of instruction."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( StudentDTD.MEDIUMOFINSTRUCTION_CODE );
		}
		set
		{
			SetField( StudentDTD.MEDIUMOFINSTRUCTION_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Code</c> attribute.
	/// </summary>
	/// <param name="val">A MediumOfInstructionCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Code representing the medium of instruction."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetCode( MediumOfInstructionCode val )
	{
		SetField( StudentDTD.MEDIUMOFINSTRUCTION_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( StudentDTD.MEDIUMOFINSTRUCTION_OTHERCODELIST);
		}
		set
		{
			RemoveChild( StudentDTD.MEDIUMOFINSTRUCTION_OTHERCODELIST);
			if( value != null)
			{
				AddChild( StudentDTD.MEDIUMOFINSTRUCTION_OTHERCODELIST, value );
			}
		}
	}

		///<summary>Returns the value of the <c>Code</c> attribute</summary>
		public override string ToString() {
			return this.Code;
	}

}}

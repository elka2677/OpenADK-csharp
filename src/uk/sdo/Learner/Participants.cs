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
using OpenADK.Library.uk.Common;

namespace OpenADK.Library.uk.Learner{

/// <summary>A Participants</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class Participants : SifElement
{
	/// <summary>
	/// Creates an instance of a Participants
	/// </summary>
	public Participants() : base ( LearnerDTD.PARTICIPANTS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="employees">An Employees</param>
	///<param name="learners">A Learners</param>
	///
	public Participants( Employee employees, Learner learners ) : base( LearnerDTD.PARTICIPANTS )
	{
		this.Employees =  new Employees( employees );
		this.Learners =  new Learners( learners );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Participants( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { LearnerDTD.PARTICIPANTS_EMPLOYEES, LearnerDTD.PARTICIPANTS_LEARNERS }; }
	}

	///<summary>Sets the value of the <c>&lt;Employees&gt;</c> element.</summary>
	/// <param name="Employee">An Employee</param>
	///<remarks>
	/// <para>This form of <c>setEmployees</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Employees</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetEmployees( Employee Employee ) {
		RemoveChild( LearnerDTD.PARTICIPANTS_EMPLOYEES);
		AddChild( LearnerDTD.PARTICIPANTS_EMPLOYEES, new Employees( Employee ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Employees&gt;</c> element.
	/// </summary>
	/// <value> An Employees </value>
	/// <remarks>
	/// <para>To remove the <c>Employees</c>, set <c>Employees</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public Employees Employees
	{
		get
		{
			return (Employees)GetChild( LearnerDTD.PARTICIPANTS_EMPLOYEES);
		}
		set
		{
			RemoveChild( LearnerDTD.PARTICIPANTS_EMPLOYEES);
			if( value != null)
			{
				AddChild( LearnerDTD.PARTICIPANTS_EMPLOYEES, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Learners&gt;</c> element.</summary>
	/// <param name="Learner">A Learner</param>
	///<remarks>
	/// <para>This form of <c>setLearners</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Learners</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetLearners( Learner Learner ) {
		RemoveChild( LearnerDTD.PARTICIPANTS_LEARNERS);
		AddChild( LearnerDTD.PARTICIPANTS_LEARNERS, new Learners( Learner ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Learners&gt;</c> element.
	/// </summary>
	/// <value> A Learners </value>
	/// <remarks>
	/// <para>To remove the <c>Learners</c>, set <c>Learners</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public Learners Learners
	{
		get
		{
			return (Learners)GetChild( LearnerDTD.PARTICIPANTS_LEARNERS);
		}
		set
		{
			RemoveChild( LearnerDTD.PARTICIPANTS_LEARNERS);
			if( value != null)
			{
				AddChild( LearnerDTD.PARTICIPANTS_LEARNERS, value );
			}
		}
	}

}}
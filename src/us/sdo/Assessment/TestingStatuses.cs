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

/// <summary>A TestingStatuses</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class TestingStatuses : SifKeyedList<TestingStatus>
{
	/// <summary>
	/// Creates an instance of a TestingStatuses
	/// </summary>
	public TestingStatuses() : base ( AssessmentDTD.TESTINGSTATUSES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="testingStatus">Records a single student-specific special condition before, during or after the test.</param>
	///
	public TestingStatuses( TestingStatus testingStatus ) : base( AssessmentDTD.TESTINGSTATUSES )
	{
		this.SafeAddChild( AssessmentDTD.TESTINGSTATUSES_TESTINGSTATUS, testingStatus );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected TestingStatuses( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.TESTINGSTATUSES_TESTINGSTATUS }; }
	}

	///<summary>Adds the value of the <c>&lt;TestingStatus&gt;</c> element.</summary>
	/// <param name="TestingStatusCode">A code that identifies the specific testing status. Code values are determined by the testing program.</param>
	///<remarks>
	/// <para>This form of <c>setTestingStatus</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddTestingStatus</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddTestingStatus( string TestingStatusCode ) {
		AddChild( AssessmentDTD.TESTINGSTATUSES_TESTINGSTATUS, new TestingStatus( TestingStatusCode ) );
	}

}}

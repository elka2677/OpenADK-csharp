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

/// <summary>Contains one of the SIF message types.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class SIF_Ack : SifMessagePayload
{
	/// <summary>
	/// Creates an instance of a SIF_Ack
	/// </summary>
	public SIF_Ack() : base ( InfraDTD.SIF_ACK ){}
	/// <summary>
	/// Creates an instance of a SIF_Ack
	/// </summary>
	///  <param name="sifVersion">The version of SIF to render this message in</param>
	///
	public SIF_Ack( SifVersion sifVersion ) : base( sifVersion, InfraDTD.SIF_ACK ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_Ack( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Header&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Header </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Header information associated with this message."</para>
	/// <para>To remove the <c>SIF_Header</c>, set <c>SIF_Header</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_Header SIF_Header
	{
		get
		{
			return (SIF_Header)GetChild( InfraDTD.SIF_ACK_SIF_HEADER);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ACK_SIF_HEADER);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ACK_SIF_HEADER, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_OriginalSourceId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_OriginalSourceId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The SIF_SourceId of the infrastructure message for which the SIF_Ack serves as a response."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SIF_OriginalSourceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_ACK_SIF_ORIGINALSOURCEID ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_ACK_SIF_ORIGINALSOURCEID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_OriginalMsgId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_OriginalMsgId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The SIF_MsgId of the infrastructure message for which the SIF_Ack message serves as a response."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SIF_OriginalMsgId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_ACK_SIF_ORIGINALMSGID ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_ACK_SIF_ORIGINALMSGID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Status&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Status </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "This element is used to signal a successful response."</para>
	/// <para>To remove the <c>SIF_Status</c>, set <c>SIF_Status</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_Status SIF_Status
	{
		get
		{
			return (SIF_Status)GetChild( InfraDTD.SIF_ACK_SIF_STATUS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ACK_SIF_STATUS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ACK_SIF_STATUS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Error&gt;</c> element.
	/// </summary>
	/// <value> A SIF_Error </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "This element is used to signal an unsuccessful response."</para>
	/// <para>To remove the <c>SIF_Error</c>, set <c>SIF_Error</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SIF_Error SIF_Error
	{
		get
		{
			return (SIF_Error)GetChild( InfraDTD.SIF_ACK_SIF_ERROR);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_ACK_SIF_ERROR);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_ACK_SIF_ERROR, value );
			}
		}
	}

		#region EXTRA METHODS

// BEGIN EXTRA METHODS (C:/GitHub/rafidzal/OpenADK-java/adk-generator/../adk-generator/datadef/core/sif20/SIF_Ack.txt.cs)

		internal OpenADK.Library.SifMessagePayload message;
		
		/// <summary>  Determines if this SIF_Ack has a specific status code.</summary>
		/// <param name="code">The status code to test for
		/// </param>
		/// <returns> true if the SIF_Ack has one or more SIF_Status children and one
		/// of those contains the status code
		/// </returns>
		public virtual bool HasStatusCode(int code)
		{
			SIF_Status stat = this.SIF_Status;
            if( stat != null && stat.SIF_Code == code )
            {
                return true;
            }
			
			return false;
		}
		
		/// <summary>  Determines if this SIF_Ack communicates an error</summary>
		/// <returns> true if there is at least one SIF_Error child of SIF_Ack
		/// </returns>
		public virtual bool HasError()
		{
			return this.SIF_Error != null;
		}
		
		/// <summary>  Determines if this SIF_Ack contains the specified error code</summary>
		/// <param name="category">The error category
		/// </param>
		/// <param name="code">The error code
		/// </param>
		/// <returns> true if the SIF_Ack contains this error
		/// </returns>
		public virtual bool HasError(int category, int code)
		{
			string ca = category.ToString();
			string co = code.ToString();
			SIF_Error error = this.SIF_Error;
            if( error != null &&  error.SIF_Category == category && error.SIF_Code == code )
            {
                return true;
            }
			
			return false;
		}
		
		
		public override void  LogSend(log4net.ILog log)
		{
			if ((Adk.Debug & AdkDebugFlags.Messaging ) != 0)
			{
				LogCommon("Send ", log);
			}
		}
		
		
		public override void  LogRecv(log4net.ILog log)
		{
			if ((Adk.Debug & AdkDebugFlags.Messaging ) != 0)
			{
				LogCommon("Receive ", log);
			}
		}
		
		private void  LogCommon(string direction, log4net.ILog log)
		{
			System.Text.StringBuilder b = new System.Text.StringBuilder(direction);
			b.Append( ElementDef.Tag(SifVersion));
			b.Append(" (Status = ");

            SIF_Status stat = this.SIF_Status;
            if( stat != null )
            {
                b.Append( stat.SIF_Code );
            }
            else
            {
                b.Append( "none" );
            }
			
			SIF_Error err = this.SIF_Error;
			if (err != null)
			{
				b.Append("; 1 Error");
			}
			
			b.Append(")");
			log.Debug(b.ToString());
			
			if (err != null && (Adk.Debug & AdkDebugFlags.Messaging) != 0)
			{
				log.Debug(err.ToString());
			}
			
			if ((Adk.Debug & AdkDebugFlags.Messaging_Detailed ) != 0)
			{
				string id = MsgId;
				log.Debug("  MsgId: " + ( id == null?"<none>":id));
				id = SIF_OriginalMsgId;
				log.Debug("  OrgId: " + ( id == null?"<none>":id));
			}
		}

// END EXTRA METHODS

		#endregion // EXTRA METHODS
}}

//
// System.Data.StrongTypingException.cs
//
// Author: Duncan Mak  (duncan@ximian.com)
//
// (C) Ximian, Inc.

using System;
using System.Runtime.Serialization;

namespace System.Data {

	[Serializable]
	public class StrongTypingException : DataException
	{
		public StrongTypingException ()
			: base (Locale.GetText ("Trying to access a DBNull value in a strongly-typed DataSet"))
		{
		}

		public StrongTypingException (string message)
			: base (message)
		{
		}

		protected StrongTypingException (SerializationInfo info, StreamingContext context)
			: base (info, context)
		{
		}
	}
}

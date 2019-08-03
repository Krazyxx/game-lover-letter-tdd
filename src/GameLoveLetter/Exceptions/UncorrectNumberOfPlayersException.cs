using System;
using System.Runtime.Serialization;

namespace GameLoveLetter
{
	public class UncorrectNumberOfPlayersException : Exception
	{
		public UncorrectNumberOfPlayersException(string message)
			: base(message)
		{
		}
	}
}
using System;

public class AgeException : Exception
{
	public AgeException() : base ( "Вам меньше 20" ){}
}

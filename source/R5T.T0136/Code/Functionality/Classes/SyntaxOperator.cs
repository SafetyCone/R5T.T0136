using System;


namespace R5T.T0136
{
	public class SyntaxOperator : ISyntaxOperator
	{
		#region Infrastructure

	    public static SyntaxOperator Instance { get; } = new();

	    private SyntaxOperator()
	    {
	    }

	    #endregion
	}
}
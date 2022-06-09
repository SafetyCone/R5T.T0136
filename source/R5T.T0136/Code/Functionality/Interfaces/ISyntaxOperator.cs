using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0132;


namespace R5T.T0136
{
	[FunctionalityMarker]
	public interface ISyntaxOperator : IFunctionalityMarker
	{
        public TBaseType ModifyAsBraced<TBaseType>(
            TBaseType baseType,
            Action<IBraced> modifier)
            where TBaseType : BaseTypeDeclarationSyntax
        {
            var namedBraced = BaseTypeBraced.From(baseType);

            modifier(namedBraced);

            var outputNamespace = namedBraced.BaseType;
            return outputNamespace;
        }
    }
}
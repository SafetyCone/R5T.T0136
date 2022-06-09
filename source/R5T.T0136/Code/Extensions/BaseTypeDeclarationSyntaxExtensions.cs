using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0136;


namespace System
{
    public static class BaseTypeDeclarationSyntaxExtensions
    {
        public static TBaseType ModifyAsBraced<TBaseType>(this TBaseType baseType,
            Action<IBraced> modifier)
            where TBaseType : BaseTypeDeclarationSyntax
        {
            return Instances.SyntaxOperator.ModifyAsBraced(
                baseType,
                modifier);
        }
    }
}

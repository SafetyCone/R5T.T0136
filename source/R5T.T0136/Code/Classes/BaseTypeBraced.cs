using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace R5T.T0136
{
    public class BaseTypeBraced<TBaseType> : IBraced
        where TBaseType : BaseTypeDeclarationSyntax
    {
        public TBaseType BaseType { get; private set; }

        public SyntaxToken CloseBrace
        {
            get => this.BaseType.CloseBraceToken;
            set
            {
                this.BaseType = this.BaseType.WithCloseBraceToken(value) as TBaseType;
            }
        }
        public SyntaxToken OpenBrace
        {
            get => this.BaseType.OpenBraceToken;
            set
            {
                this.BaseType = this.BaseType.WithOpenBraceToken(value) as TBaseType;
            }
        }


        public BaseTypeBraced(
            TBaseType baseType)
        {
            this.BaseType = baseType;
        }
    }


    public static class BaseTypeBraced
    {
        public static BaseTypeBraced<TBaseType> From<TBaseType>(TBaseType baseType)
            where TBaseType : BaseTypeDeclarationSyntax
        {
            var output = new BaseTypeBraced<TBaseType>(baseType);
            return output;
        }
    }
}
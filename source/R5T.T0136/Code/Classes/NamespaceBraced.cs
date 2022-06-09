using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace R5T.T0136
{
    public class NamespaceBraced : IBraced
    {
        #region Static

        public static NamespaceBraced From(NamespaceDeclarationSyntax @namespace)
        {
            var output = new NamespaceBraced(@namespace);
            return output;
        }

        #endregion


        public NamespaceDeclarationSyntax Namespace { get; private set; }

        public SyntaxToken CloseBrace
        {
            get => this.Namespace.CloseBraceToken;
            set
            {
                this.Namespace = this.Namespace.WithCloseBraceToken(value);
            }
        }
        public SyntaxToken OpenBrace
        {
            get => this.Namespace.OpenBraceToken;
            set
            {
                this.Namespace = this.Namespace.WithOpenBraceToken(value);
            }
        }


        public NamespaceBraced(
            NamespaceDeclarationSyntax @namespace)
        {
            this.Namespace = @namespace;
        }
    }
}
using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0136;


namespace System
{
    public static class NamespaceDeclarationSyntaxExtensions
    {
        public static NamespaceDeclarationSyntax ModifyAsBraced(this NamespaceDeclarationSyntax @namespace,
            Action<IBraced> modifier)
        {
            var namedBraced = NamespaceBraced.From(@namespace);

            modifier(namedBraced);

            var outputNamespace = namedBraced.Namespace;
            return outputNamespace;
        }
    }
}

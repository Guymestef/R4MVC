using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static R4Mvc.Tools.Extensions.SyntaxNodeHelpers;

namespace R4Mvc.Tools.Extensions
{
    public static class GeneratorExtensions
    {
        const string ViewNamesClassName = "_ViewNamesClass";

        public static ClassDeclarationSyntax WithActionNameClass(this ClassDeclarationSyntax node, ITypeSymbol controllerClass)
        {
            // create ActionNames sub class using symbol method names
            return node.WithSubClassMembersAsStrings(
                controllerClass,
                "ActionNamesClass",
                SyntaxKind.PublicKeyword,
                SyntaxKind.ReadOnlyKeyword);
        }

        public static ClassDeclarationSyntax WithActionConstantsClass(this ClassDeclarationSyntax node, ITypeSymbol controllerClass)
        {
            // create ActionConstants sub class
            return node.WithSubClassMembersAsStrings(
                controllerClass,
                "ActionNameConstants",
                SyntaxKind.PublicKeyword,
                SyntaxKind.ConstKeyword);
        }

        public static ClassDeclarationSyntax WithViewsClass(this ClassDeclarationSyntax node, string controllerName, string areaName, IEnumerable<View> viewFiles)
        {
            var allControllerViews = viewFiles
                .Where(x => 
                    string.Equals(x.ControllerName, controllerName, StringComparison.CurrentCultureIgnoreCase) &&
                    string.Equals(x.AreaName, areaName, StringComparison.OrdinalIgnoreCase))
                .GroupBy(v => v.TemplateKind);

            // create subclass called ViewsClass
            // create ViewNames get property returning static instance of _ViewNamesClass subclass
            //	create subclass in ViewsClass called _ViewNamesClass 
            //		create string field per view
            var viewClassNode = SyntaxFactory.ClassDeclaration("ViewsClass")
                .WithModifiers(SyntaxKind.PublicKeyword)
                .WithGeneratedNonUserCodeAttributes()
                .WithStaticFieldBackedProperty("ViewNames", ViewNamesClassName, SyntaxKind.PublicKeyword);

            var controllerViews = allControllerViews.Where(x => string.IsNullOrEmpty(x.Key)).SelectMany(x => x).ToImmutableArray();

            var viewFields = controllerViews
                .Select(x => CreateStringFieldDeclaration(x.ViewName.SanitiseFieldName(), x.RelativePath.ToString(), SyntaxKind.PublicKeyword))
                .ToArray<MemberDeclarationSyntax>();
            viewClassNode = viewClassNode
                .WithViewNamesClassNode(controllerViews)
                .AddMembers(viewFields);

            foreach (var templateKind in allControllerViews.Where(x => !string.IsNullOrEmpty(x.Key)))
            {
                viewClassNode = viewClassNode.WithViewTemplateMembers(templateKind.Key, templateKind);
            }

            return node
                .AddMembers(viewClassNode)
                .WithStaticFieldBackedProperty("Views", "ViewsClass", SyntaxKind.PublicKeyword);
        }

        private static ClassDeclarationSyntax WithViewTemplateMembers(this ClassDeclarationSyntax node, string templateKind, IEnumerable<View> viewFiles)
        {
            var className = $"_{templateKind}Class";
            var templateClass = SyntaxFactory.ClassDeclaration(className)
                .WithModifiers(SyntaxKind.PublicKeyword, SyntaxKind.PartialKeyword)
                .WithGeneratedNonUserCodeAttributes();

            if (templateKind == "DisplayTemplates" || templateKind == "EditorTemplates")
            {
                templateClass = templateClass.AddMembers(viewFiles
                    .Select(t => CreateStringFieldDeclaration(t.ViewName.SanitiseFieldName(), t.ViewName, SyntaxKind.PublicKeyword, SyntaxKind.ReadOnlyKeyword))
                    .ToArray());
            }
            else
            {
                templateClass = templateClass
                    .WithViewNamesClassNode(viewFiles)
                    .WithStaticFieldBackedProperty("ViewNames", ViewNamesClassName, SyntaxKind.PublicKeyword);

                var viewFields = viewFiles
                    .Select(x => CreateStringFieldDeclaration(x.ViewName.SanitiseFieldName(), x.RelativePath.ToString(), SyntaxKind.PublicKeyword, SyntaxKind.ReadOnlyKeyword))
                    .ToArray<MemberDeclarationSyntax>();
                templateClass = templateClass.AddMembers(viewFields);
            }

            node = node
                .AddMembers(templateClass)
                .WithStaticFieldBackedProperty(templateKind, className, SyntaxKind.PublicKeyword);
            return node;
        }

        private static ClassDeclarationSyntax WithViewNamesClassNode(this ClassDeclarationSyntax node, IEnumerable<View> controllerViews)
        {
            var viewNamesClassNode = SyntaxFactory.ClassDeclaration(ViewNamesClassName).WithModifiers(SyntaxKind.PublicKeyword);
            var viewNameFields = controllerViews
                .Select(x => CreateStringFieldDeclaration(x.ViewName.SanitiseFieldName(), x.ViewName, SyntaxKind.PublicKeyword, SyntaxKind.ReadOnlyKeyword))
                .ToArray<MemberDeclarationSyntax>();
            viewNamesClassNode = viewNamesClassNode.AddMembers(viewNameFields);
            return node.AddMembers(viewNamesClassNode);
        }

        public static ClassDeclarationSyntax WithStaticFieldsForFiles(this ClassDeclarationSyntax node, IEnumerable<StaticFile> staticFiles)
        {
            var staticNodes = staticFiles
                .Select(x => CreateStringFieldDeclaration(x.FileName, x.RelativePath.ToString(), SyntaxKind.PublicKeyword, SyntaxKind.StaticKeyword))
                .ToArray<MemberDeclarationSyntax>();
            return node.AddMembers(staticNodes);
        }

        public static ClassDeclarationSyntax WithUrlMethods(this ClassDeclarationSyntax node)
        {
            // TODO add url methods that call delegated virtual path provider
            return node;
        }

        public static NamespaceDeclarationSyntax WithDummyClass(this NamespaceDeclarationSyntax node)
        {
            var dummyClass = SyntaxFactory.ClassDeclaration(Constants.DummyClass)
                .WithModifiers(SyntaxKind.PublicKeyword)
                .WithGeneratedNonUserCodeAttributes()
                .WithDefaultConstructor(false, SyntaxKind.PrivateKeyword)
                .WithField(Constants.DummyClassInstance, Constants.DummyClass, SyntaxKind.PublicKeyword, SyntaxKind.StaticKeyword);

            return node.AddMembers(dummyClass);
        }
    }
}

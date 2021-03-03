﻿namespace Vivian.CodeAnalysis.Syntax
{
    public enum SyntaxKind
    {
        BadToken,

        // Trivia
        LineBreakTrivia,
        MultiLineCommentTrivia,
        SingleLineCommentTrivia,
        SkippedTextTrivia,
        WhitespaceTrivia,

        // Tokens
        AmpersandAmpersandToken,
        AmpersandEqualsToken,
        AmpersandToken,
        BangEqualsToken,
        BangToken,
        CharToken,
        CloseBraceToken,
        CloseParenthesisToken,
        ColonToken,
        CommaToken,
        DotToken,
        EndOfFileToken,
        EqualsEqualsToken,
        EqualsToken,
        GreaterOrEqualsToken,
        GreaterToken,
        HatEqualsToken,
        HatToken,
        IdentifierToken,
        LessOrEqualsToken,
        LessToken,
        MinusEqualsToken,
        MinusToken,
        NumberToken,
        OpenBraceToken,
        OpenParenthesisToken,
        PipeEqualsToken,
        PipePipeToken,
        PipeToken,
        PlusEqualsToken,
        PlusToken,
        PercentToken,
        SlashEqualsToken,
        SlashToken,
        StarEqualsToken,
        StarToken,
        StringToken,
        TildeToken,

        // Keywords
        BreakKeyword,
        ContinueKeyword,
        DefaultKeyword,
        DoKeyword,
        ElseKeyword,
        FalseKeyword,
        ForKeyword,
        FunctionKeyword,
        IfKeyword,
        LetKeyword,
        ReturnKeyword,
        StructKeyword,
        ThisKeyword,
        ToKeyword,
        TrueKeyword,
        VarKeyword,
        WhileKeyword,

        // Nodes
        CompilationUnit,
        ElseClause,
        FunctionDeclaration,
        GlobalStatement,
        Parameter,
        StructDeclaration,
        TypeClause,

        // Statements
        BlockStatement,
        BreakStatement,
        ContinueStatement,
        DoWhileStatement,
        ExpressionStatement,
        ForStatement,
        IfStatement,
        MemberBlockStatement,
        ReturnStatement,
        VariableDeclaration,
        WhileStatement,

        // Expressions
        AssignmentExpression,
        BinaryExpression,
        CallExpression,
        CompoundAssignmentExpression,
        LiteralExpression,
        MemberAccessExpression,
        NameExpression,
        ParenthesizedExpression,
        UnaryExpression,
    }
}
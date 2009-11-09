﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Irony {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Irony.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nn.
        /// </summary>
        internal static string ConsoleNoChars {
            get {
                return ResourceManager.GetString("ConsoleNoChars", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Yy.
        /// </summary>
        internal static string ConsoleYesChars {
            get {
                return ResourceManager.GetString("ConsoleYesChars", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ambiguous grammar, unresolvable reduce-reduce conflicts. State {0}, lookaheads [{1}].
        /// </summary>
        internal static string ErrAmbigGrammarRR {
            get {
                return ResourceManager.GetString("ErrAmbigGrammarRR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ambiguous grammar, unresolvable shift-reduce conflicts. State {0}, lookaheads [{1}].
        /// </summary>
        internal static string ErrAmbigGrammarSR {
            get {
                return ResourceManager.GetString("ErrAmbigGrammarSR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument list not found in the stack. Expected: ValueList, found: {0}..
        /// </summary>
        internal static string ErrArgListNotFound {
            get {
                return ResourceManager.GetString("ErrArgListNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid length of char literal - should be a single character..
        /// </summary>
        internal static string ErrBadChar {
            get {
                return ResourceManager.GetString("ErrBadChar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mal-formed  string literal - cannot find termination symbol..
        /// </summary>
        internal static string ErrBadStrLiteral {
            get {
                return ResourceManager.GetString("ErrBadStrLiteral", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid unicode escape ({0}), expected {1} hex digits..
        /// </summary>
        internal static string ErrBadUnEscape {
            get {
                return ResourceManager.GetString("ErrBadUnEscape", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid \x escape, at least one digit expected..
        /// </summary>
        internal static string ErrBadXEscape {
            get {
                return ResourceManager.GetString("ErrBadXEscape", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot convert value from type {0} to type {1}, type converter not defined..
        /// </summary>
        internal static string ErrCannotConvertValue {
            get {
                return ResourceManager.GetString("ErrCannotConvertValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} State {1} on inputs: {2}.
        /// </summary>
        internal static string ErrConflictMsgTemplate {
            get {
                return ResourceManager.GetString("ErrConflictMsgTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fatal error:.
        /// </summary>
        internal static string ErrConsoleFatalError {
            get {
                return ResourceManager.GetString("ErrConsoleFatalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Construct &apos;{0}&apos; is not supported (yet) by language implementation..
        /// </summary>
        internal static string ErrConstructNotSupported {
            get {
                return ResourceManager.GetString("ErrConstructNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate switch &apos;{0}&apos; for regular expression..
        /// </summary>
        internal static string ErrDupRegexSwitch {
            get {
                return ResourceManager.GetString("ErrDupRegexSwitch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to convert the value: {0}.
        /// </summary>
        internal static string ErrFailedConvert {
            get {
                return ResourceManager.GetString("ErrFailedConvert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create AST node for non-terminal [{0}], error: {1}.
        /// </summary>
        internal static string ErrFailedCreateNode {
            get {
                return ResourceManager.GetString("ErrFailedCreateNode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Interpreter error, DataStack.Pop() operation failed - stack is empty..
        /// </summary>
        internal static string ErrInternalErrDataPopFailed {
            get {
                return ResourceManager.GetString("ErrInternalErrDataPopFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Interpreter is busy..
        /// </summary>
        internal static string ErrInterpreterIsBusy {
            get {
                return ResourceManager.GetString("ErrInterpreterIsBusy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid AstMode value in call to Evaluate method. Node: {0}, mode: {1}..
        /// </summary>
        internal static string ErrInvalidAstMode {
            get {
                return ResourceManager.GetString("ErrInvalidAstMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid character: &apos;{0}&apos;..
        /// </summary>
        internal static string ErrInvalidChar {
            get {
                return ResourceManager.GetString("ErrInvalidChar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid dedent level, no previous matching indent found..
        /// </summary>
        internal static string ErrInvDedent {
            get {
                return ResourceManager.GetString("ErrInvDedent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid escape sequence: \{0}..
        /// </summary>
        internal static string ErrInvEscape {
            get {
                return ResourceManager.GetString("ErrInvEscape", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid escape sequence..
        /// </summary>
        internal static string ErrInvEscSeq {
            get {
                return ResourceManager.GetString("ErrInvEscSeq", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid escape symbol, expected &apos;u&apos; or &apos;U&apos; only..
        /// </summary>
        internal static string ErrInvEscSymbol {
            get {
                return ResourceManager.GetString("ErrInvEscSymbol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid number..
        /// </summary>
        internal static string ErrInvNumber {
            get {
                return ResourceManager.GetString("ErrInvNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid switch &apos;{0}&apos; for regular expression.
        /// </summary>
        internal static string ErrInvRegexSwitch {
            get {
                return ResourceManager.GetString("ErrInvRegexSwitch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error in string literal [{0}]: No start/end symbols specified..
        /// </summary>
        internal static string ErrInvStrDef {
            get {
                return ResourceManager.GetString("ErrInvStrDef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NLALR process is in indefinite loop, number of states exceeded 3000..
        /// </summary>
        internal static string ErrNLALRhang {
            get {
                return ResourceManager.GetString("ErrNLALRhang", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning: AstNodeType or AstNodeCreator is not set on non-terminals: {0}..
        /// </summary>
        internal static string ErrNodeTypeNotSetOn {
            get {
                return ResourceManager.GetString("ErrNodeTypeNotSetOn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No end symbol for regex literal..
        /// </summary>
        internal static string ErrNoEndForRegex {
            get {
                return ResourceManager.GetString("ErrNoEndForRegex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UnExprNode: no implementation for unary operator &apos;{0}&apos;..
        /// </summary>
        internal static string ErrNoImplForUnaryOp {
            get {
                return ResourceManager.GetString("ErrNoImplForUnaryOp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number cannot be followed by a letter..
        /// </summary>
        internal static string ErrNoLetterAfterNum {
            get {
                return ResourceManager.GetString("ErrNoLetterAfterNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ParserDataBuilder error: inadequate state {0}, reduce item &apos;{1}&apos; has no lookaheads..
        /// </summary>
        internal static string ErrNoLkhds {
            get {
                return ResourceManager.GetString("ErrNoLkhds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-terminal {0} has uninitialized Rule property..
        /// </summary>
        internal static string ErrNtRuleIsNull {
            get {
                return ResourceManager.GetString("ErrNtRuleIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempt to evaluate NULL AST node. The AST node for term &apos;{0}&apos; was not created during parsing..
        /// </summary>
        internal static string ErrNullNodeEval {
            get {
                return ResourceManager.GetString("ErrNullNodeEval", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operator &apos;{0}&apos; is not defined for types {1} and {2}..
        /// </summary>
        internal static string ErrOpNotDefinedForTypes {
            get {
                return ResourceManager.GetString("ErrOpNotDefinedForTypes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operator &apos;{0} not imlemented..
        /// </summary>
        internal static string ErrOpNotImplemented {
            get {
                return ResourceManager.GetString("ErrOpNotImplemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid unary operator node: {0}; operator symbol not registered in Invalid unary operator node: {0}; operator symbol not registered in Grammar.Post/PrefixUnaryOperators sets..
        /// </summary>
        internal static string ErrOpSymbolNotRegistered {
            get {
                return ResourceManager.GetString("ErrOpSymbolNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: {1}.
        /// </summary>
        internal static string ErrOutErrorPrintFormat {
            get {
                return ResourceManager.GetString("ErrOutErrorPrintFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CodeOutlineFilter: line continuation symbol &apos;{0}&apos; should be added to Grammar.NonGrammarTerminals list..
        /// </summary>
        internal static string ErrOutlineFilterContSymbol {
            get {
                return ResourceManager.GetString("ErrOutlineFilterContSymbol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax error, expected: {0}.
        /// </summary>
        internal static string ErrParserUnexpInput {
            get {
                return ResourceManager.GetString("ErrParserUnexpInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parsed tree is null, cannot evaluate..
        /// </summary>
        internal static string ErrParseTreeNull {
            get {
                return ResourceManager.GetString("ErrParseTreeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parse tree root is null, cannot evaluate..
        /// </summary>
        internal static string ErrParseTreeRootNull {
            get {
                return ResourceManager.GetString("ErrParseTreeRootNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Root AST node is null, cannot evaluate..
        /// </summary>
        internal static string ErrRootAstNodeNull {
            get {
                return ResourceManager.GetString("ErrRootAstNodeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Root AST node does not implement IInterpretedAstNode interface, cannot evaluate..
        /// </summary>
        internal static string ErrRootAstNoInterface {
            get {
                return ResourceManager.GetString("ErrRootAstNoInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Root property of the grammar is not set..
        /// </summary>
        internal static string ErrRootNotSet {
            get {
                return ResourceManager.GetString("ErrRootNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reduce-reduce conflict. State {0}, lookaheads: {1}. Selected reduce on first production in conflict set..
        /// </summary>
        internal static string ErrRRConflict {
            get {
                return ResourceManager.GetString("ErrRRConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rule for NonTerminal {0} contains null as an operand in position {1} in one of productions..
        /// </summary>
        internal static string ErrRuleContainsNull {
            get {
                return ResourceManager.GetString("ErrRuleContainsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shift-reduce conflict. State {0}, lookaheads [{1}]. Selected shift as preferred action..
        /// </summary>
        internal static string ErrSRConflict {
            get {
                return ResourceManager.GetString("ErrSRConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Syntax error..
        /// </summary>
        internal static string ErrSyntaxErrorNoInfo {
            get {
                return ResourceManager.GetString("ErrSyntaxErrorNoInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unclosed comment block.
        /// </summary>
        internal static string ErrUnclosedComment {
            get {
                return ResourceManager.GetString("ErrUnclosedComment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected end of file..
        /// </summary>
        internal static string ErrUnexpEof {
            get {
                return ResourceManager.GetString("ErrUnexpEof", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected indentation..
        /// </summary>
        internal static string ErrUnexpIndent {
            get {
                return ResourceManager.GetString("ErrUnexpIndent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unmatched closing brace &apos;{0}&apos;..
        /// </summary>
        internal static string ErrUnmatchedCloseBrace {
            get {
                return ResourceManager.GetString("ErrUnmatchedCloseBrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable {0} is not a callable function..
        /// </summary>
        internal static string ErrVarIsNotCallable {
            get {
                return ResourceManager.GetString("ErrVarIsNotCallable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable {0} not defined..
        /// </summary>
        internal static string ErrVarNotDefined {
            get {
                return ResourceManager.GetString("ErrVarNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid number of arguments. Expected {0}, found {1}..
        /// </summary>
        internal static string ErrWrongArgCount {
            get {
                return ResourceManager.GetString("ErrWrongArgCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ({0}:{1}).
        /// </summary>
        internal static string FmtRowCol {
            get {
                return ResourceManager.GetString("FmtRowCol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accept.
        /// </summary>
        internal static string LabelActionAccept {
            get {
                return ResourceManager.GetString("LabelActionAccept", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Jump to {0}..
        /// </summary>
        internal static string LabelActionJump {
            get {
                return ResourceManager.GetString("LabelActionJump", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operator, shift to {0}/reduce on {1}..
        /// </summary>
        internal static string LabelActionOp {
            get {
                return ResourceManager.GetString("LabelActionOp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reduce on {0}.
        /// </summary>
        internal static string LabelActionReduce {
            get {
                return ResourceManager.GetString("LabelActionReduce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Shift to {0}.
        /// </summary>
        internal static string LabelActionShift {
            get {
                return ResourceManager.GetString("LabelActionShift", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Unknown action type).
        /// </summary>
        internal static string LabelActionUnknown {
            get {
                return ResourceManager.GetString("LabelActionUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (EOF).
        /// </summary>
        internal static string LabelEofMark {
            get {
                return ResourceManager.GetString("LabelEofMark", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [end-of-statement].
        /// </summary>
        internal static string LabelEosLabel {
            get {
                return ResourceManager.GetString("LabelEosLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (INITIAL STATE).
        /// </summary>
        internal static string LabelInitialState {
            get {
                return ResourceManager.GetString("LabelInitialState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Key symbol).
        /// </summary>
        internal static string LabelKeySymbol {
            get {
                return ResourceManager.GetString("LabelKeySymbol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Keyword).
        /// </summary>
        internal static string LabelKeyword {
            get {
                return ResourceManager.GetString("LabelKeyword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [line break].
        /// </summary>
        internal static string LabelLineBreak {
            get {
                return ResourceManager.GetString("LabelLineBreak", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Location:.
        /// </summary>
        internal static string LabelLocation {
            get {
                return ResourceManager.GetString("LabelLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ....
        /// </summary>
        internal static string LabelSrcHaveMore {
            get {
                return ResourceManager.GetString("LabelSrcHaveMore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (unassigned).
        /// </summary>
        internal static string LabelUnassigned {
            get {
                return ResourceManager.GetString("LabelUnassigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (unnamed).
        /// </summary>
        internal static string LabelUnnamed {
            get {
                return ResourceManager.GetString("LabelUnnamed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Abort script(y/n)?.
        /// </summary>
        internal static string MsgAbortScriptYN {
            get {
                return ResourceManager.GetString("MsgAbortScriptYN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Console.\r\nPress Ctrl-C to exit the program.\r\n.
        /// </summary>
        internal static string MsgDefaultConsoleGreeting {
            get {
                return ResourceManager.GetString("MsgDefaultConsoleGreeting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Console.
        /// </summary>
        internal static string MsgDefaultConsoleTitle {
            get {
                return ResourceManager.GetString("MsgDefaultConsoleTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exit console (y/n)?.
        /// </summary>
        internal static string MsgExitConsoleYN {
            get {
                return ResourceManager.GetString("MsgExitConsoleYN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NLALR transform: Add WrapTail() in &apos;.&apos; position to [{0}]..
        /// </summary>
        internal static string MsgNLALRAdvice {
            get {
                return ResourceManager.GetString("MsgNLALRAdvice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press any key to end the program..
        /// </summary>
        internal static string MsgPressAnyKeyToExit {
            get {
                return ResourceManager.GetString("MsgPressAnyKeyToExit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;[{0}], at {1}.
        /// </summary>
        internal static string MsgSrcPosToString {
            get {
                return ResourceManager.GetString("MsgSrcPosToString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parsing conflict resolved in code..
        /// </summary>
        internal static string MsgTraceConflictResolved {
            get {
                return ResourceManager.GetString("MsgTraceConflictResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operator - resolved to {0}.
        /// </summary>
        internal static string MsgTraceOpResolved {
            get {
                return ResourceManager.GetString("MsgTraceOpResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Popped state from stack, pushing {0}.
        /// </summary>
        internal static string MsgTracePoppedState {
            get {
                return ResourceManager.GetString("MsgTracePoppedState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to *** FAILED TO RECOVER ***.
        /// </summary>
        internal static string MsgTraceRecoverFailed {
            get {
                return ResourceManager.GetString("MsgTraceRecoverFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to *** RECOVERING - searching for state with error shift ***.
        /// </summary>
        internal static string MsgTraceRecovering {
            get {
                return ResourceManager.GetString("MsgTraceRecovering", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to *** RECOVERED ***.
        /// </summary>
        internal static string MsgTraceRecoverSuccess {
            get {
                return ResourceManager.GetString("MsgTraceRecoverSuccess", resourceCulture);
            }
        }
    }
}

#region License
/* **********************************************************************************
 * Copyright (c) Roman Ivantsov
 * This source code is subject to terms and conditions of the MIT License
 * for Irony. A copy of the license can be found in the License.txt file
 * at the root of this distribution. 
 * By using this source code in any fashion, you are agreeing to be bound by the terms of the 
 * MIT License.
 * You must not remove this notice from this software.
 * **********************************************************************************/
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Irony.Compiler {

  //Note: this class was not tested at all
  // Based on contributions by CodePlex user sakana280
  public class RegexBasedTerminal : Terminal {
    public RegexBasedTerminal(string pattern, params string[] prefixes) : base ("RegEx:{" + pattern + "}") {
      Pattern = pattern;
      Prefixes.AddRange(prefixes);
    }

    #region public properties
    public readonly string Pattern;
    public readonly StringList Prefixes = new StringList();

    public Regex Expression {
      get { return _expression; }
    } Regex  _expression;
    #endregion

    public override void Init(Irony.Compiler.Grammar grammar) {
      base.Init(grammar);
      string workPattern = @"\G(" + Pattern + ")";
      RegexOptions options = (grammar.CaseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase);
      _expression = new Regex(workPattern, options);
    }

    public override IList<string> GetFirsts() {
      return Prefixes;
    }

    public override Token TryMatch(CompilerContext context, ISourceStream source) {
      Match m = _expression.Match(source.Text, source.Position);
      if (!m.Success || m.Index != source.Position) 
        return null;
      source.Position += m.Length;
      string text = source.GetLexeme();
      return Token.Create(this, context, source.TokenStart, text);
    }

  }//class




}//namespace

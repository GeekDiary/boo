﻿#region license
// boo - an extensible programming language for the CLI
// Copyright (C) 2004 Rodrigo B. de Oliveira
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// As a special exception, if you link this library with other files to
// produce an executable, this library does not by itself cause the
// resulting executable to be covered by the GNU General Public License.
// This exception does not however invalidate any other reasons why the
// executable file might be covered by the GNU General Public License.
//
// Contact Information
//
// mailto:rbo@acm.org
#endregion

// $ANTLR 2.7.2: "src/Boo.Antlr/boo.g" -> "BooLexer.cs"$

namespace Boo.Antlr
{
	public class BooTokenTypes
	{
		public const int EOF = 1;
		public const int NULL_TREE_LOOKAHEAD = 3;
		public const int TIMESPAN = 4;
		public const int REAL = 5;
		public const int LONG = 6;
		public const int ESEPARATOR = 7;
		public const int INDENT = 8;
		public const int DEDENT = 9;
		public const int COMPILATION_UNIT = 10;
		public const int PARAMETERS = 11;
		public const int PARAMETER = 12;
		public const int ELIST = 13;
		public const int DLIST = 14;
		public const int TYPE = 15;
		public const int CALL = 16;
		public const int STMT = 17;
		public const int BLOCK = 18;
		public const int FIELD = 19;
		public const int MODIFIERS = 20;
		public const int MODULE = 21;
		public const int LITERAL = 22;
		public const int LIST_LITERAL = 23;
		public const int UNPACKING = 24;
		public const int AND = 25;
		public const int AS = 26;
		public const int BREAK = 27;
		public const int CONTINUE = 28;
		public const int CLASS = 29;
		public const int CONSTRUCTOR = 30;
		public const int DEF = 31;
		public const int ELSE = 32;
		public const int ENSURE = 33;
		public const int ENUM = 34;
		public const int EXCEPT = 35;
		public const int FAILURE = 36;
		public const int FINAL = 37;
		public const int FROM = 38;
		public const int FOR = 39;
		public const int FALSE = 40;
		public const int GET = 41;
		public const int GIVEN = 42;
		public const int IMPORT = 43;
		public const int INTERFACE = 44;
		public const int INTERNAL = 45;
		public const int IS = 46;
		public const int ISA = 47;
		public const int IF = 48;
		public const int IN = 49;
		public const int NOT = 50;
		public const int NULL = 51;
		public const int OR = 52;
		public const int OTHERWISE = 53;
		public const int OVERRIDE = 54;
		public const int PASS = 55;
		public const int NAMESPACE = 56;
		public const int PROPERTY = 57;
		public const int PUBLIC = 58;
		public const int PROTECTED = 59;
		public const int PRIVATE = 60;
		public const int RAISE = 61;
		public const int RETURN = 62;
		public const int RETRY = 63;
		public const int SET = 64;
		public const int SELF = 65;
		public const int SUPER = 66;
		public const int STATIC = 67;
		public const int SUCCESS = 68;
		public const int TRY = 69;
		public const int TRANSIENT = 70;
		public const int TRUE = 71;
		public const int UNLESS = 72;
		public const int UNTIL = 73;
		public const int VOID = 74;
		public const int WHEN = 75;
		public const int WHILE = 76;
		public const int YIELD = 77;
		public const int EOS = 78;
		public const int TRIPLE_QUOTED_STRING = 79;
		public const int ID = 80;
		public const int ASSIGN = 81;
		public const int LBRACK = 82;
		public const int COMMA = 83;
		public const int RBRACK = 84;
		public const int LPAREN = 85;
		public const int RPAREN = 86;
		public const int COLON = 87;
		public const int QMARK = 88;
		public const int ADD = 89;
		public const int SUBTRACT = 90;
		public const int BITWISE_OR = 91;
		public const int MULT_OPERATOR = 92;
		public const int INCREMENT = 93;
		public const int DECREMENT = 94;
		public const int CMP_OPERATOR = 95;
		public const int DOT = 96;
		public const int INT = 97;
		public const int DOUBLE_QUOTED_STRING = 98;
		public const int SINGLE_QUOTED_STRING = 99;
		public const int LBRACE = 100;
		public const int RBRACE = 101;
		public const int RE_LITERAL = 102;
		public const int SL_COMMENT = 103;
		public const int WS = 104;
		public const int ESCAPED_EXPRESSION = 105;
		public const int DQS_ESC = 106;
		public const int SQS_ESC = 107;
		public const int SESC = 108;
		public const int RE_CHAR = 109;
		public const int RE_ESC = 110;
		public const int ID_LETTER = 111;
		public const int DIGIT = 112;
		
	}
}

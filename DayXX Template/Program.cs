using AdventOfCode;
using AdventOfCode.Parsing;
using System;
using System.Linq;
using System.Collections.Generic;

namespace $safeprojectname$ {
	class Program : ProgramStructure<string> {

		Program() : base(new Parser()
			.Parse(new StringReader())
		) { }

		static void Main(string[] args) {
			new Program().Run(args);
		}

		protected override object SolvePart1(string input) {
			return null;
		}

		protected override object SolvePart2(string input) {
			return null;
		}

	}
}

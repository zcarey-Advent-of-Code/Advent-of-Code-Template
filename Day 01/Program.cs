using AdventOfCode;
using AdventOfCode.Parsing;
using AdventOfCode.Visualization;
using AdventOfCode.Utils;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Day_01 {
	class Program : ProgramStructure<string> {

		Program() : base(new Parser()
			.Parse(new StringReader())
		) { }

		static void Main(string[] args) {
			new Program().Run(args);
		}

		// Parameter "visualizer" is null unless program is ran with "--visualizer" flag.
		protected override object SolvePart1(string input, Visualizer visualizer) {
			return input;
		}

		// Parameter "visualizer" is null unless program is ran with "--visualizer" flag.
		protected override object SolvePart2(string input, Visualizer visualizer) {
			return null;
		}

	}
}

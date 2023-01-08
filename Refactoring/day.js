// Get day number

// Step 2
// 'D' is never reassigned. Use 'const' instead

"use strict";

const D = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

const _parse_day_ = (s) => {
  let i;
  for (i = 0; i < D.length; i++) {
    if (s.startsWith(D[i].toLowerCase())) {
      return i + 1;
    }
  }
  return -1;
};

require("../Tests/day.js")(_parse_day_);

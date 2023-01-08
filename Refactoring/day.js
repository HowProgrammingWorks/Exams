// Get day number

// Step 1
// Add 'use strict';
// fix '_parse_day_' is not defined
// Format code indentation and spacing

"use strict";

let D = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

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

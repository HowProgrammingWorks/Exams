// Get day number

// Step 3
// Rename 'D' into 'Days'
// Identifier '_parse_day_' is not in camel case

"use strict";

const Days = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

const parseDay = (s) => {
  let i;
  for (i = 0; i < Days.length; i++) {
    if (s.startsWith(Days[i].toLowerCase())) {
      return i + 1;
    }
  }
  return -1;
};

require("../Tests/day.js")(parseDay);

// Get day number

// Step 4
// Replace initialization of i into for instead of global context of function.

"use strict";

const Days = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

const parseDay = (s) => {
  for (let i = 0; i < Days.length; i++) {
    if (s.startsWith(Days[i].toLowerCase())) {
      return i + 1;
    }
  }
  return -1;
};

require("../Tests/day.js")(parseDay);

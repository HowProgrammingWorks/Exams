// Get day number

// Step 5
// Rename s into str(string)

"use strict";

const Days = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

const parseDay = (str) => {
  for (let i = 0; i < Days.length; i++) {
    if (str.startsWith(Days[i].toLowerCase())) {
      return i + 1;
    }
  }
  return -1;
};

require("../Tests/day.js")(parseDay);

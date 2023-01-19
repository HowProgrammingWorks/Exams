// Return an array without duplicates
"use strict";

// Step 2
// Removed useless else (we already got early return)
// Enabled use strict mode
// Changed for to while for less operations

const duplicate = (value, N) => {
  const res = [];
  if (N <= 0) res;
  while (res.length < N) {
    res.push(value);
  }
  return res;
};

require("../Tests/duplicate.js")(duplicate);

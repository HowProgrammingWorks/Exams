// Return an array without duplicates
"use strict";

// Step 4
// Finished refactor with using ternar operations and arrow function syntax

const duplicate = (value, N) => (N <= 0 ? [] : new Array(N).fill(value));

require("../Tests/duplicate.js")(duplicate);

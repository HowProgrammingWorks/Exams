// Step 4 
// Enabled strict mode
// Used arrow function syntax to avoid return word

"use strict"

const count = (obj) => Object.values(obj)
    .filter((value) => typeof value === "number")
    .reduce((acc, key) => acc + Number(key), 0);

require('../Tests/count.js')(count);


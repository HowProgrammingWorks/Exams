// Find an intersection of two dictionaries

"use strict";

// Step 4
// Finished refactoring

const intersection = (firstObject, secondObject = args) => {
  for (const key of Object.keys(firstObject)) {
    firstObject[key] === secondObject[key]
      ? (secondObject[key] = firstObject[key])
      : delete firstObject[key];
  }

  return firstObject;
};

require("../Tests/intersection.js")(intersection);

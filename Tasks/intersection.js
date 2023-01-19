// Find an intersection of two dictionaries

"use strict";

// Step 2
// Enabled strict mode
// Destructurize incoming array into 2 object

const intersection = (...argsOfObjects) => {
  const [firstObject, secondObject] = argsOfObjects;
  for (const attribute_name of Object.keys(firstObject)) {
    if (firstObject[attribute_name] === secondObject[attribute_name]) {
      secondObject[attribute_name] = firstObject[attribute_name];
    } else {
      delete firstObject[attribute_name];
    }
  }
  return firstObject;
};

require("../Tests/intersection.js")(intersection);

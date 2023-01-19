// Find an intersection of two dictionaries

"use strict";

// Step 3
// Changed if else construstion to ternar operator
// Changed way to desctrusture
// Changed some other variables name

const intersection = (...argsOfObjects) => {
  const [firstObject, secondObject] = argsOfObjects;
  for (const key of Object.keys(firstObject)) {
    firstObject[key] === secondObject[key]
      ? (secondObject[key] = firstObject[key])
      : delete firstObject[key];
  }

  return firstObject;
};

require("../Tests/intersection.js")(intersection);

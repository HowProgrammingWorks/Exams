// Find an intersection of two dictionaries

// Step 1
// Changed function declaration to function expression
// Added variables declaration where needed
// Changed some variables names
// Removed non-usable lexical environments

const intersection = (firstObject, secondObject) => {
  const first_keys = Object.keys(firstObject);
  for (attribute_name of first_keys) {
    if (firstObject[attribute_name] === secondObject[attribute_name]) {
      secondObject[attribute_name] = firstObject[attribute_name];
    } else {
      delete firstObject[attribute_name];
    }
  }
  return firstObject;
};

require("../Tests/intersection.js")(intersection);

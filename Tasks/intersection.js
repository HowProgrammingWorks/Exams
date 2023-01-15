// Find an intersection of two dictionaries
"use strict";

const intersection = (object1, object2) => {
  const arrayOfKeys = Object.keys(object1);

  for (const key of arrayOfKeys) {
    const mutual =
        object1[key] === object2[key]
            ? (object2[key] = object1[key])
            : delete object1[key];
  }
  return object1;
};

require("../Tests/intersection.js")(intersection);

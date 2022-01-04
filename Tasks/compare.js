// Compare two dictionaries
"use strict";

const compare = (firstObj, secondObj) => {
  const firstKeys = Object.keys(firstObj).sort();
  const secondKeys = Object.keys(secondObj).sort();

  if (firstKeys.join("-") !== secondKeys.join("-")) {
    return false;
  }

  for (const key of firstKeys) {
    if (firstObj[key] !== secondObj[key]) {
      return false;
    }
  }

  return true;
};

const result = compare({ a: 1, c: "hello" }, { a: 1, c: "hello" });
console.log(result);

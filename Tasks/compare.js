// Compare two dictionaries
"use strict";

const compare = (firstObj, secondObj) => {
  const firstKeys = Object.keys(firstObj);
  const secondKeys = Object.keys(secondObj);

  if (firstKeys.sort().join("-") !== secondKeys.sort().join("-")) {
    return false;
  }

  for (const key of firstKeys) {
    if (firstObj[key] !== secondObj[key]) return false;
  }

  return true;
};

const result = compare({ a: 1, c: "hello" }, { a: 1, c: "hello" });
console.log(result);

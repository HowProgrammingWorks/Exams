// Compare two dictionaries
"use strict";

const compare = (firstObj, secondObj) => {
  const firstKeys = Object.keys(firstObj);
  const secondKeys = Object.keys(secondObj);
  if (firstKeys.join("-") !== secondKeys.join("-")) return false;
  let evaluate = true;
  for (const key of firstKeys) {
    if (firstObj[key] === secondObj[key]) evaluate = evaluate && true;
    else {
      evaluate = evaluate && false;
    }
  }
  return evaluate;
};

const result = compare({ a: 1, c: "hello" }, { a: 1, c: "hello" });
console.log(result);

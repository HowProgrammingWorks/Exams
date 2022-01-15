"use strict";

// Delete listed keys from dictionary

const drop = (object, ...badKeys) => {
  const result = { ...object };
  for (const key in result) {
    if (badKeys.includes(key)) delete result[key];
  }
  return result;
};

const inputObject = { a: "uno", b: "due", c: "tre" };
const result = drop(inputObject, "b", "f");
console.log("Result:", result);
console.log("Input object:", inputObject);

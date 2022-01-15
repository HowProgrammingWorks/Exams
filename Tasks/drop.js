"use strict";

// Delete listed keys from dictionary

const drop = (object, ...badKeys) => {
  const keys = Object.keys(object);
  keys.forEach((key) => {
    if (badKeys.includes(key)) {
      delete object[key];
    }
  });
  return object;
};

const inputObject = { a: "uno", b: "due", c: "tre" };
const result = drop(inputObject, "b", "f");
console.log("Result:", result);
console.log("Input object:", inputObject);

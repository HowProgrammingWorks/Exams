// Finde a difference of two dictionaries

"use strict";

const diff = (objectFirst, objectSecond) => {
  let objectDiff = objectFirst;
  const keysSecond = Object.keys(objectSecond);
  for (const key of keysSecond) {
    objectDiff[key] = objectSecond[key];
    delete objectDiff[key];
  }
  return objectDiff;
};

const result = diff({ a: "uno", b: "due" }, { a: "uno", c: "tre" });
console.log(result);

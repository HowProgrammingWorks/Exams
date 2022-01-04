// Finde a difference of two dictionaries

"use strict";

const diff = (objectFirst, objectSecond) => {
  for (const key in objectSecond) {
    objectFirst[key] = objectSecond[key];
    delete objectFirst[key];
  }
  return objectFirst;
};

const result = diff({ a: "uno", b: "due" }, { a: "uno", c: "tre" });
console.log(result);

"use strict";
// Find an intersection of two dictionaries

const intersection = (object_1, object_2) => {
  const key = Object.keys(object_1);
  for (const name of key) {
    if (name !== "" && object_2[name]) {
      object_2[name] = object_1[name];
    } else {
      delete object_1[name];
    }
  }
  return object_1;
};
const result = intersection({ a: "uno", b: "due" }, { a: "uno", c: "tre" });
console.log(result);